from numpy import random, ceil
from datetime import datetime, timedelta
import time

dir_path = "dataGenerators"
out_file = "out.txt"

prefix = 'N3'
jobs = ['KI SU', 'DUOC SI', 'QUAN LY KHO', 'VAN HANH', 'CONG NHAN',
        'BAN THOI GIAN', 'KE TOAN', 'KIEM TOAN', 'BAO VE', 'THU KY',
        'GIAM DOC', 'VAN TAI', 'DIEU PHOI', 'DEVOPS', 'THIET KE']
job_reqs = ['THONG MINH', 'TU DUY LOGIC', 'CONG NGHE ABC', 'CHU DONG',
        'LINH HOAT', 'GAN BO', 'TRINH DO DAI HOC', 'CHUNG CHI NGOAI NGU',
        'UNG DUNG CBA', 'KY THUAT QWE', 'QUY TRINH XYZ']

htdangtuyens = ['DANG TUYEN TREN BAO GIAY', 'DANG BANNER QUANG CAO',
               'DANG TREN CAC TRANG MANG']

def randdate(start, end, time_format='%d/%m/%Y %I:%M%p'):
    if start.find(" ") == -1: start += " 1:00AM"
    if end.find(" ") == -1: end += " 1:00AM"
    stime = time.mktime(time.strptime(start, time_format))
    etime = time.mktime(time.strptime(end, time_format))
    ptime = stime + random.random() * (etime - stime)
    return time.strftime(time_format, time.localtime(ptime))

def randreqs():
    rng = random.default_rng()
    reqs = rng.choice(job_reqs, random.randint(1, ceil(len(job_reqs) / 2)), False)
    return ", ".join(reqs)

def diff_days(st_date, ed_date, time_format='%d/%m/%Y'):
    st_date = datetime.strptime(st_date, time_format)
    ed_date = datetime.strptime(ed_date, time_format)
    return (ed_date - st_date).days

def inc_days(date, days, time_format='%d/%m/%Y'):
    date = datetime.strptime(date, time_format) + timedelta(days)
    return date.strftime(time_format)

def gen_pttdangtuyen(dn_size, nvien_size, p_per_dn=2, fmode="w"):
    file = open(f"{dir_path}/{out_file}", fmode, encoding="utf-8")
    ptt_size, time_format = p_per_dn, '%d/%m/%Y'
    pttdts = []
    file.write("INSERT INTO PTTDANGTUYEN\n")
    for madn in range(dn_size):
        file.write(f"-- {prefix}DN{madn + 1:04}\n")
        if p_per_dn < 1: ptt_size = random.randint(1, 11)
        for maph in range(ptt_size):
            dn, ph = f"{prefix}DN{madn + 1:04}", f"{prefix}PH{maph + 1:04}"
            data = f"\tSELECT '{dn}', '{ph}', "
            data += f"'{jobs[random.randint(len(jobs))]}', {random.randint(1, 31)}, "
            
            st_date = f"{randdate('01/01/2023', '20/03/2024').split(' ')[0]}"
            data += f"TO_DATE('{st_date}', 'DD/MM/YYYY'), "
            ed_date = f"{randdate(inc_days(st_date, 15), '01/05/2024').split(' ')[0]}"
            data += f"TO_DATE('{ed_date}', 'DD/MM/YYYY'), "

            total, method = random.randint(500, 5000), 1
            if diff_days(st_date, ed_date) > 30: method = random.randint(2) + 1
            data += f"'{randreqs()}', {total}, {total}, {method}, "

            data += f"'{prefix}NV{random.randint(1, nvien_size + 1):04}' "
            data += "FROM DUAL"
            if madn == dn_size - 1 and maph == p_per_dn - 1: data += ";\n"
            else: data += " UNION ALL\n"

            pttdts.append(f"{dn}, {ph}, {st_date}, {ed_date}, ")
            pttdts[madn * ptt_size + maph] += f"{total}, {method}"
            file.write(data)
    file.close()
    return pttdts

def gen_pdkquangcao(pttds:list[str], fmode="a"):
    file = open(f"{dir_path}/{out_file}", fmode, encoding="utf-8")
    file.write("INSERT INTO PDKQUANGCAO\n")
    rng, prev_ptt = random.default_rng(), ''
    for i, ptt in enumerate(pttds):
        ptt = ptt.split(", ")
        if prev_ptt != ptt[0]:
            file.write(f"-- {ptt[0]}\n")
            prev_ptt = ptt[0]
        htdts = rng.choice(len(htdangtuyens), random.randint(len(htdangtuyens)) + 1, False)
        htdts.sort()
        for j, ht in enumerate(htdts):
            data = f"\tSELECT '{ptt[0]}', '{ptt[1]}', {ht + 1}, "
            date = f"{randdate(ptt[2], ptt[3]).split(' ')[0]}"
            data += f"TO_DATE('{date}', 'DD/MM/YYYY'), "
            date = f"{randdate(inc_days(date, 1), ptt[3]).split(' ')[0]}"
            data += f"TO_DATE('{date}', 'DD/MM/YYYY') FROM DUAL"

            if i == len(pttds) - 1 and j == len(htdts) - 1: data += ";\n"
            else: data += " UNION ALL\n"
            file.write(data)
    file.close()

def gen_cthoadon(pttds:list[str], fmode="a"):
    file = open(f"{dir_path}/{out_file}", fmode, encoding="utf-8")
    file.write("INSERT INTO CTHOADON\n")
    prev_ptt = ''
    for i, ptt in enumerate(pttds):
        ptt = ptt.split(", ")
        if prev_ptt != ptt[0]:
            file.write(f"-- {ptt[0]}\n")
            prev_ptt = ptt[0]
        
        if ptt[-1] == '1':
            data = f"\tSELECT '{ptt[0]}', '{ptt[1]}', 1, {ptt[-2]}, "
            data += f"TO_DATE('{ptt[2]}', 'DD/MM/YYYY'), "
            data += f"{random.randint(2) + 1} FROM DUAL"
            data += " UNION ALL\n" if i != len(pttds) - 1 else ";\n"
            file.write(data)
            continue

        cnt, remain, date = 1, int(ptt[-2]), ptt[2]
        while remain > 0:
            pay = random.randint(int(ptt[-2]) * 30/100, int(ptt[-2]))
            date = f"{randdate(date, inc_days(date, 5)).split(' ')[0]}"
            while diff_days(ptt[2], date) > 10:
                date = f"{randdate(date, inc_days(date, 5)).split(' ')[0]}"
            if diff_days(ptt[2], date) == 10 or remain - pay < 0:
                pay = remain
            data = f"\tSELECT '{ptt[0]}', '{ptt[1]}', {cnt}, {pay}, "
            data += f"TO_DATE('{date}', 'DD/MM/YYYY'), "
            data += f"{random.randint(2) + 1} FROM DUAL"

            if i == len(pttds) - 1 and remain - pay <= 0: data += ";\n"
            else: data += " UNION ALL\n"
            file.write(data)
            cnt, remain = cnt + 1, remain - pay
    file.close()

def main():
    pttdts = gen_pttdangtuyen(20, 10)
    gen_pdkquangcao(pttdts)
    gen_cthoadon(pttdts)

if __name__ == "__main__":
    main()