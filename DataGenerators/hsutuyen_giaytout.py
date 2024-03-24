from numpy import random, ceil

dir_path = "dataGenerators"
out_file = "out.txt"

prefix = 'N3'
hs_stats = ['CHUA DU DIEU KIEN', 'DU DIEU KIEN', 'DA XU LY', 'DA DAT']
giaytos = ['SO YEU LY LICH', 'DON XIN VIEC', 'CV XIN VIEC', 'SO HO KHAU (BAN SAO CONG CHUNG)',
           'CAN CUOC CONG DAN (BAN SAO CONG CHUNG)', 'GIAY KHAI SINH (BAN SAO CONG CHUNG)',
           'GIAY KHAM SUC KHOE (DUOI 6 THANG)', 'ANH THE HO SO (3X4 HOAC 4X6)',
           'CHUNG CHI LIEN QUAN']
pttdts = []

def pop_pttdts(folder="tables"):
    file = open(f"{dir_path}/{folder}/pttdangtuyen.txt", "r", encoding="utf-8")
    comm = "SELECT"
    for line in file:
        line, lco = line.strip(), len(comm)
        if line[:lco] != comm: continue
        line = line.split(", ")[:5]
        ptt = f"{line[0][len(comm) + 2:-1]}, {line[1][1:-1]}, {line[3]}"
        pttdts.append(ptt)
    file.close()

def gen_hosoungtuyen(uv_size, nv_size, fmode="w"):
    file = open(f"{dir_path}/out.txt", fmode, encoding="utf-8")
    ins_cl = "INSERT INTO HOSOUNGTUYEN\n"
    hsuts, rng = [], random.default_rng()
    pv_dn, pv_ptt, skfl = '', '', False
    for ptt in pttdts:
        ptt = ptt.split(", ")
        if pv_dn != ptt[0]:
            if pv_dn != '':
                file.write(";\n")
                skfl = True
            pv_dn = ptt[0]
            file.write(f"{ins_cl}-- {pv_dn}\n")

        if pv_ptt != ptt[1]:
            if pv_ptt != '' and not skfl: file.write(f" UNION ALL\n")
            skfl = False
            pv_ptt = ptt[1]
            file.write(f"--\t{pv_ptt}\n")
        else: file.write(" UNION ALL\n")

        uvs = rng.choice(uv_size, replace=False,
                         size=random.randint(min(ceil(uv_size / 2), int(ptt[2]))) + 1)
        uvs.sort()
        for ui, uv in enumerate(uvs):
            uv = f"{prefix}UV{uv + 1:04}"
            data = f"\tSELECT '{uv}', '{ptt[0]}', '{ptt[1]}', "
            data += f"{random.randint(10) + 1}, '', "
            data += f"{random.randint(len(hs_stats)) + 1}, "
            data += f"'{prefix}NV{random.randint(nv_size) + 1:04}' FROM DUAL"

            if ui != len(uvs) - 1: data += " UNION ALL\n"
            file.write(data)
            hsuts.append(f"{uv}, {ptt[0]}, {ptt[1]}")
    file.write(";\n")
    file.close()
    return hsuts

def gen_giaytout(hsuts:list[str], fmode="a"):
    file = open(f"{dir_path}/out.txt", fmode, encoding="utf-8")
    ins_cl = "INSERT INTO GIAYTOUT\n"
    rng = random.default_rng()
    pv_ptt, pv_hs, skfl = '', '', False
    for hs in hsuts:
        hs = hs.split(", ")

        if pv_ptt != hs[2]:
            if pv_ptt != '':
                file.write(";\n")
                skfl = True
            pv_ptt = hs[2]
            file.write(f"{ins_cl}-- {hs[1]}, {hs[2]}\n")

        if pv_hs != hs[0] or skfl:
            if pv_hs != '' and not skfl: file.write(f" UNION ALL\n")
            skfl = False
            pv_hs = hs[0]
            file.write(f"--\t{pv_hs}\n")
        else: file.write(" UNION ALL\n")

        if pv_hs != hs[0]:
            file.write(f"-- {hs[1]}, {hs[2]}, {hs[0]}\n")
            pv_hs = hs[0]
        gts = rng.choice(len(giaytos), replace=False,
                         size=random.randint(ceil(len(giaytos) / 2)) + 1)
        gts.sort()
        for gi, gt in enumerate(gts):
            data = f"\tSELECT '{hs[0]}', '{hs[1]}', '{hs[2]}', {gi + 1}, "
            data += f"'', {gt + 1} FROM DUAL"
            if gi != len(gts) - 1: data += " UNION ALL\n"
            file.write(data)
    file.write(";\n")
    file.close()

def main():
    hsuts = gen_hosoungtuyen(20, 10)
    gen_giaytout(hsuts)

if __name__ == "__main__":
    pop_pttdts()
    main()