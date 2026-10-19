"""
BEN - ThirdGame maze autopilot.

Moves the real Windows cursor through the red "don't touch the text" maze
for you: start marker -> anticheat checkpoint -> the butterfly/Navi end
marker, staying clear of every wall label and both trap zones.

How the path was computed: every wall/trap in the maze is a real,
precisely-positioned WinForms control in BEN/ThirdGame.Designer.cs
(Panel1-4 = outer border, Label1-56 = the red glyph segments,
triggerCheater/triggerTrap = instant-punishment zones). Those exact
rectangles were pulled from the source and fed to an A* search to find a
route that never enters any of them (plus a safety margin), routed through
the "anticheat" panel on the way so you get the legit ending rather than
the "cheater" one.

Requirements: Windows, Python 3 (stdlib only, no pip installs needed).

Usage:
  1. Get to the maze screen in BEN.exe (the "yOUr frIEND wiLL lEAD yOu tO
     thE eNd" screen) and dismiss the message box so the maze is visible.
  2. Run:  python maze_autopilot.py
  3. Don't touch your mouse until it finishes - it will take over the
     cursor, snap it to the start marker, then trace the path to the end.
  4. Press ESC at any time to abort early and give control back.
"""

import ctypes
from ctypes import wintypes
import heapq
import sys
import time

user32 = ctypes.windll.user32
kernel32 = ctypes.windll.kernel32

try:
    user32.SetProcessDPIAware()
except Exception:
    pass

# ---------------------------------------------------------------------------
# Maze geometry, pulled directly from BEN/ThirdGame.Designer.cs
# ---------------------------------------------------------------------------

WALLS = [
    (12, 457, 731, 28), (12, 12, 731, 28), (12, 39, 37, 419), (706, 39, 37, 419),
    (49, 84, 305, 21), (255, 124, 24, 203), (372, 84, 24, 203), (319, 163, 24, 83),
    (212, 124, 122, 21), (133, 46, 252, 21), (212, 163, 24, 216), (293, 257, 80, 21),
    (585, 75, 24, 131), (92, 301, 24, 131), (92, 123, 24, 83), (112, 175, 90, 21),
    (142, 105, 38, 56), (142, 196, 24, 183), (181, 239, 21, 65), (181, 334, 21, 65),
    (160, 262, 27, 19), (198, 344, 16, 19), (215, 386, 21, 49), (115, 414, 100, 18),
    (92, 259, 16, 19), (55, 216, 53, 19), (255, 430, 304, 21), (293, 399, 127, 15),
    (432, 399, 71, 15), (521, 399, 99, 15), (614, 438, 17, 17), (458, 420, 16, 10),
    (255, 349, 24, 34), (232, 386, 39, 19), (405, 57, 251, 21), (665, 97, 24, 177),
    (663, 274, 24, 141), (620, 228, 24, 186), (432, 75, 24, 203), (293, 284, 24, 95),
    (462, 299, 24, 95), (336, 318, 107, 49), (489, 205, 80, 21), (545, 238, 24, 141),
    (509, 306, 36, 21), (489, 349, 36, 21), (405, 142, 16, 19), (405, 238, 16, 19),
    (293, 195, 16, 19), (63, 351, 16, 96), (489, 116, 76, 69), (625, 131, 19, 19),
    (581, 420, 17, 17), (584, 266, 36, 21), (573, 342, 36, 21), (581, 380, 17, 17),
    (485, 241, 38, 42), (521, 82, 16, 19), (372, 294, 70, 13),
    (645, 251, 19, 19), (645, 380, 19, 19),  # dormant trap1/trap2, avoided anyway
]

DANGER = [
    (687, 374, 16, 17),  # triggerCheater -> instant jumpscare
    (643, 315, 21, 17),  # triggerTrap -> traps you until a forced reset
]

POINT_DEPART = (80, 46, 36, 35)   # start marker
FAKE_WIN = (668, 419, 32, 32)     # butterfly / Navi end marker
ANTICHEAT = (500, 400, 25, 16)    # legit-route checkpoint

PLAY_X0, PLAY_Y0, PLAY_X1, PLAY_Y1 = 49, 40, 706, 457
MARGIN = 3
DANGER_MARGIN = 6
STEP = 2

TARGET_CLIENT_W = 755
TARGET_CLIENT_H = 497


def center(rect):
    x, y, w, h = rect
    return (x + w / 2.0, y + h / 2.0)


def blocked(x, y):
    if not (PLAY_X0 <= x <= PLAY_X1 and PLAY_Y0 <= y <= PLAY_Y1):
        return True
    for (wx, wy, ww, wh) in WALLS:
        if wx - MARGIN <= x <= wx + ww + MARGIN and wy - MARGIN <= y <= wy + wh + MARGIN:
            return True
    for (dx, dy, dw, dh) in DANGER:
        if dx - DANGER_MARGIN <= x <= dx + dw + DANGER_MARGIN and dy - DANGER_MARGIN <= y <= dy + dh + DANGER_MARGIN:
            return True
    return False


def snap(p):
    return (round(p[0] / STEP) * STEP, round(p[1] / STEP) * STEP)


def astar(start, goal):
    start = snap(start)
    goal = snap(goal)

    def h(p):
        return abs(p[0] - goal[0]) + abs(p[1] - goal[1])

    openset = [(h(start), 0, start, None)]
    came = {}
    gscore = {start: 0}
    visited = set()
    dirs = [(-STEP, 0), (STEP, 0), (0, -STEP), (0, STEP),
            (-STEP, -STEP), (-STEP, STEP), (STEP, -STEP), (STEP, STEP)]
    while openset:
        f, g, cur, parent = heapq.heappop(openset)
        if cur in visited:
            continue
        visited.add(cur)
        came[cur] = parent
        if abs(cur[0] - goal[0]) <= STEP and abs(cur[1] - goal[1]) <= STEP:
            path = [cur]
            p = parent
            while p is not None:
                path.append(p)
                p = came.get(p)
            path.reverse()
            return path
        for dx, dy in dirs:
            nxt = (cur[0] + dx, cur[1] + dy)
            if nxt in visited or blocked(nxt[0], nxt[1]):
                continue
            ng = g + (1.41421356 if dx and dy else 1)
            if nxt not in gscore or ng < gscore[nxt]:
                gscore[nxt] = ng
                heapq.heappush(openset, (ng + h(nxt), ng, nxt, cur))
    return None


def simplify(path):
    if not path:
        return path
    def sgn(v):
        return 0 if v == 0 else (1 if v > 0 else -1)
    simplified = [path[0]]
    for i in range(1, len(path) - 1):
        a, b, c = simplified[-1], path[i], path[i + 1]
        d1 = (b[0] - a[0], b[1] - a[1])
        d2 = (c[0] - b[0], c[1] - b[1])
        if sgn(d1[0]) == sgn(d2[0]) and sgn(d1[1]) == sgn(d2[1]):
            continue
        simplified.append(b)
    simplified.append(path[-1])
    return simplified


def compute_path():
    leg1 = astar(center(POINT_DEPART), center(ANTICHEAT))
    leg2 = astar(center(ANTICHEAT), center(FAKE_WIN)) if leg1 else None
    if leg1 and leg2:
        return simplify(leg1 + leg2[1:])
    direct = astar(center(POINT_DEPART), center(FAKE_WIN))
    if direct:
        return simplify(direct)
    return None


# ---------------------------------------------------------------------------
# Window discovery (pure ctypes, no extra packages)
# ---------------------------------------------------------------------------

PROCESS_QUERY_LIMITED_INFORMATION = 0x1000


def get_process_exe(pid):
    hproc = kernel32.OpenProcess(PROCESS_QUERY_LIMITED_INFORMATION, False, pid)
    if not hproc:
        return None
    try:
        buf = ctypes.create_unicode_buffer(260)
        size = wintypes.DWORD(260)
        ok = kernel32.QueryFullProcessImageNameW(hproc, 0, buf, ctypes.byref(size))
        if not ok:
            return None
        return buf.value
    finally:
        kernel32.CloseHandle(hproc)


def find_thirdgame_window():
    candidates = []
    EnumWindowsProc = ctypes.WINFUNCTYPE(wintypes.BOOL, wintypes.HWND, wintypes.LPARAM)

    def callback(hwnd, lparam):
        if not user32.IsWindowVisible(hwnd):
            return True
        pid = wintypes.DWORD()
        user32.GetWindowThreadProcessId(hwnd, ctypes.byref(pid))
        exe = get_process_exe(pid.value) or ""
        if not exe.lower().endswith("ben.exe"):
            return True
        rect = wintypes.RECT()
        user32.GetClientRect(hwnd, ctypes.byref(rect))
        w, h = rect.right - rect.left, rect.bottom - rect.top
        if w == TARGET_CLIENT_W and h == TARGET_CLIENT_H:
            candidates.append(hwnd)
        return True

    user32.EnumWindows(EnumWindowsProc(callback), 0)
    return candidates[0] if candidates else None


def client_origin(hwnd):
    pt = wintypes.POINT(0, 0)
    user32.ClientToScreen(hwnd, ctypes.byref(pt))
    return pt.x, pt.y


def set_cursor(x, y):
    user32.SetCursorPos(int(round(x)), int(round(y)))


VK_ESCAPE = 0x1B


def escape_pressed():
    return bool(user32.GetAsyncKeyState(VK_ESCAPE) & 0x8000)


def animate(waypoints, ox, oy, step_px=2.0, delay=0.004):
    for i in range(len(waypoints) - 1):
        x0, y0 = waypoints[i]
        x1, y1 = waypoints[i + 1]
        dist = max(1.0, ((x1 - x0) ** 2 + (y1 - y0) ** 2) ** 0.5)
        steps = max(1, int(dist / step_px))
        for s in range(1, steps + 1):
            if escape_pressed():
                print("Aborted (ESC pressed).")
                return False
            t = s / steps
            x = x0 + (x1 - x0) * t
            y = y0 + (y1 - y0) * t
            set_cursor(ox + x, oy + y)
            time.sleep(delay)
    return True


def main():
    path = compute_path()
    if not path:
        print("Could not find a safe path through the maze data - aborting.")
        sys.exit(1)

    print(f"Computed a {len(path)}-waypoint safe route through the maze.")

    hwnd = find_thirdgame_window()
    if not hwnd:
        print("Could not find the ThirdGame maze window.")
        print("Make sure BEN.exe is running and the maze screen "
              "('yOUr frIEND wiLL lEAD yOu tO thE eNd') is on screen, "
              "then run this again.")
        sys.exit(1)

    user32.SetForegroundWindow(hwnd)
    time.sleep(0.3)
    ox, oy = client_origin(hwnd)

    start_x, start_y = center(POINT_DEPART)
    print("Snapping cursor to the start marker...")
    set_cursor(ox + start_x, oy + start_y)
    time.sleep(0.5)

    print("Tracing the safe path to the end marker (ESC to abort)...")
    ok = animate(path, ox, oy)
    if ok:
        print("Done - cursor should now be on the butterfly/end marker.")


if __name__ == "__main__":
    main()
