from numpy import random, floor
from datetime import datetime, timedelta
import time

dir_path = "dataGenerators"
out_file = "out.txt"

prefix = 'N3'

def randdate(start, end, time_format='%d/%m/%Y %I:%M%p'):
    if start.find(" ") == -1: start += " 1:00AM"
    if end.find(" ") == -1: end += " 1:00AM"
    stime = time.mktime(time.strptime(start, time_format))
    etime = time.mktime(time.strptime(end, time_format))
    ptime = stime + random.random() * (etime - stime)
    return time.strftime(time_format, time.localtime(ptime))

def inc_days(date, days, time_format='%d/%m/%Y'):
    date = datetime.strptime(date, time_format) + timedelta(days)
    return date.strftime(time_format)

def gen_dntiemnang(dn_size, ld_size, ld_per_dn=0, fmode="w"):
    file = open(f"{dir_path}/out.txt", fmode, encoding="utf-8")
    rng, ld_per_dn = random.default_rng(), min(ld_per_dn, ld_size)
    file.write("INSERT INTO DNTIEMNANG\n")
    ld_num = ld_per_dn
    for dn in range(dn_size):
        file.write(f"-- {prefix}DN{dn + 1:04}\n")
        if ld_per_dn <= 0: ld_num = random.randint(ld_size) + 1
        lds = rng.choice(ld_size, ld_num, False)
        lds.sort()
        for i, ld in enumerate(lds):
            data = f"\tSELECT '{prefix}DN{dn + 1:04}', '{prefix}LD{ld + 1:04}', "
            data += f"{random.randint(10) + 1}, '', "
            date = f"{randdate('01/01/2023', '20/03/2024').split(' ')[0]}"
            data += f"TO_DATE('{date}', 'DD/MM/YYYY') FROM DUAL"

            if dn == dn_size - 1 and i == len(lds) - 1: data += ";\n"
            else: data += " UNION ALL\n"
            file.write(data)
    file.close()

def gen_clapdung(dn_size, cl_size, cl_per_dn=0, fmode="w"):
    file = open(f"{dir_path}/out.txt", fmode, encoding="utf-8")
    rng, cl_per_dn = random.default_rng(), min(cl_per_dn, cl_size)
    file.write("INSERT INTO CLAPDUNG\n")
    cl_num = cl_per_dn
    dns = rng.choice(dn_size, random.randint(dn_size) + 1, False)
    dns.sort()
    for i, dn in enumerate(dns):
        file.write(f"-- {prefix}DN{dn + 1:04}\n")
        if cl_per_dn <= 0: cl_num = random.randint(floor(cl_size / 2)) + 1
        cls = rng.choice(cl_size, cl_num, False)
        cls.sort()
        for j, cl in enumerate(cls):
            data = f"\tSELECT '{prefix}DN{dn + 1:04}', '{prefix}CL{cl + 1:04}', "
            date = f"{randdate('01/01/2023', '20/03/2024').split(' ')[0]}"
            data += f"TO_DATE('{date}', 'DD/MM/YYYY'), "
            date = f"{randdate(inc_days(date, 1), inc_days(date, 365)).split(' ')[0]}"
            data += f"TO_DATE('{date}', 'DD/MM/YYYY') FROM DUAL"

            if i == len(dns) - 1 and j == len(cls) - 1: data += ";\n"
            else: data += " UNION ALL\n"
            file.write(data)
    file.close()

def main():
    gen_dntiemnang(20, 10)
    gen_clapdung(20, 10, fmode="a")

if __name__ == "__main__":
    main()