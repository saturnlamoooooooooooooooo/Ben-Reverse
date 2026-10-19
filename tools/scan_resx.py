import sys, re, base64, hashlib, collections

path = sys.argv[1]
text = open(path, "r", encoding="utf-8", errors="replace").read()
pat = re.compile(r'<data name="([^"]+)"(?:[^>]*?mimetype="([^"]+)")?[^>]*>\s*<value>(.*?)</value>', re.S)

types = collections.Counter()
total = 0
flags = []
rows = []
for name, mime, val in pat.findall(text):
    if not mime:
        continue
    raw = base64.b64decode(re.sub(r"\s+", "", val))
    total += len(raw)
    head = raw[:600]
    m = re.search(rb"System\.Drawing\.[A-Za-z]+|System\.Byte\[\]|System\.IO\.[A-Za-z]+", head)
    t = m.group(0).decode() if m else "UNKNOWN"
    # find the inner payload magic
    magic = "?"
    for sig, lbl in ((b"\x89PNG", "PNG"), (b"GIF8", "GIF"), (b"BM", "BMP"), (b"\xff\xd8\xff", "JPEG"), (b"RIFF", "RIFF/WAV")):
        if sig in raw[:4096]:
            magic = lbl
            break
    pe = raw.find(b"MZ\x90\x00") >= 0 or (raw.find(b"This program cannot be run in DOS mode") >= 0)
    types[(t, magic)] += 1
    rows.append((name, t, magic, len(raw), hashlib.sha256(raw).hexdigest()[:16], pe))
    if pe:
        flags.append(name)

print("binary resource entries:", len(rows), " decoded bytes:", total)
for k, v in sorted(types.items(), key=lambda x: -x[1]):
    print(f"  {v:3d} x {k[0]:28s} payload-magic={k[1]}")
print("PE/executable markers inside any blob:", flags if flags else "NONE")
unk = [r for r in rows if r[1] == "UNKNOWN"]
print("entries with unrecognised serialized type:", [r[0] for r in unk] if unk else "NONE")
