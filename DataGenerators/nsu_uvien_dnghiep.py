from unidecode import unidecode
from numpy import random, int64
from string import ascii_uppercase
from datetime import datetime, timedelta
import time

dir_path = "dataGenerators"
out_file = "out.txt"

last_names = ["Nguyen", "Tran", "Le", "Pham", "Hoang", "Huynh", "Vu", "Vo",
              "Phan", "Truong", "Bui", "Dang", "Do", "Ngo", "Ho", "Duong",
              "Dinh", "Ly"]
male_names, fe_names = [], []

genders = ['NAM', 'NU']
phone_digit_cnt = 10**9
streets, wards, dists, provs_cities = [], [], [], []

prefix = 'N3'
roles = ['NV', 'LD']
mails = ['gmail', 'yahoo', 'proton', 'yandex', 'outlook']

corps = ['CTY TU NHAN', 'CTY TNHH', 'CTY CP', 'CTY DAU TU', 'NGAN HANG TMCP']
fields = ['XAY DUNG', 'CONG NGHE', 'NHAP KHAU', 'XUAT KHAU', 'DUOC PHAM',
          'PHAT TRIEN HA TANG', 'TAP DOAN', 'NHUA', 'NUOC UONG', 'XI MANG',
          'DICH VU VIEN THONG', 'TRUYEN THONG', 'DIEN TU', 'DAU KHI',
          'BUU CHINH VIEN THONG']

def pop_names(dir, folder="names"):
    file = open(f"{dir}/{folder}/boy.txt", "r", encoding="utf-8")
    for name in file:
        male_names.append(unidecode(name).strip())
    file.close()

    file = open(f"{dir}/{folder}/girl_unsigned.txt", "r", encoding="utf-8")
    for name in file:
        fe_names.append(name.strip())
    file.close()

def pop_addresses(dir, folder="addresses"):
    file = open(f"{dir}/{folder}/districts.txt", "r", encoding="utf-8")
    for st in file:
        streets.append(unidecode(st).strip())
    file.close()

    file = open(f"{dir}/{folder}/wards.txt", "r", encoding="utf-8")
    for wa in file:
        wards.append(unidecode(wa).strip())
    file.close()
    
    file = open(f"{dir}/{folder}/districts.txt", "r", encoding="utf-8")
    for di in file:
        dists.append(unidecode(di).strip())
    file.close()
    
    file = open(f"{dir}/{folder}/provs_cities.txt", "r", encoding="utf-8")
    for pc in file:
        provs_cities.append(unidecode(pc).strip())
    file.close()

def randdate(start, end, time_format='%d/%m/%Y %I:%M%p'):
    if start.find(" ") == -1: start += " 1:00AM"
    if end.find(" ") == -1: end += " 1:00AM"
    stime = time.mktime(time.strptime(start, time_format))
    etime = time.mktime(time.strptime(end, time_format))
    ptime = stime + random.random() * (etime - stime)
    return time.strftime(time_format, time.localtime(ptime))

def randfullname(gender): # 0-male, 1-female
    full_name = last_names[random.randint(len(last_names))]
    if gender: full_name += f" {fe_names[random.randint(len(fe_names))]}"
    else: full_name += f" {male_names[random.randint(len(male_names))]}"
    return full_name

def randaddress():
    addr = f"{random.randint(1, 400)}"
    if random.randint(2):
        addr += f"/{random.randint(1, 50)}"
    if random.randint(2):
        addr += random.choice(list(ascii_uppercase))

    addr += f" duong {streets[random.randint(len(streets))]}, "
    ward = wards[random.randint(len(wards))]
    addr += f"{ward}, " if ward.find("Phuong") != -1 else f"phuong {ward}, "
    
    if random.randint(2):
        dist = dists[random.randint(len(dists))]
        addr += f"{dist}, " if dist.find("Quan") != -1 else f"quan {dist}, "

    addr += f"{provs_cities[random.randint(len(provs_cities))]}"
    return addr

def randemail(fullname, phone):
    email = f"{''.join(fullname.split(' ')[1:]).lower()}"
    email += f"{phone[-2:]}@"
    email += f"{mails[random.randint(len(mails))]}.com"
    return email

def inc_days(date, days, time_format='%d/%m/%Y'):
    date = datetime.strptime(date, time_format) + timedelta(days)
    return date.strftime(time_format)

def gen_nhansu(rl, size, start=0, fmode="w"):
    file = open(f"{dir_path}/{out_file}", fmode, encoding="utf-8")
    rl, size = rl - 1, start + size
    file.write("INSERT INTO NHANSU\n")
    for i in range(start, size):
        data = f"\tSELECT '{prefix}{roles[rl]}{i+1:04}', "
        fullname = randfullname(random.randint(len(genders)))
        data += f"'{fullname}', '{randaddress()}', "

        phone = f"09{random.randint(phone_digit_cnt, dtype=int64):09}"
        data += f"'{phone}', '{randemail(fullname, phone)}', "
        data += f"{rl + 1} FROM DUAL"
        data += " UNION ALL\n" if i != size - 1 else ";\n"
        file.write(data)
    file.close()

def gen_ungvien(nvien_size, size, start=0, fmode="w"):
    file = open(f"{dir_path}/{out_file}", fmode, encoding="utf-8")
    size = start + size
    file.write("INSERT INTO UNGVIEN\n")
    for i in range(start, size):
        data = f"\tSELECT '{prefix}UV{i+1:04}', "
        fullname = randfullname(random.randint(len(genders)))
        data += f"'{fullname}', '{randaddress()}', "

        phone = f"09{random.randint(phone_digit_cnt, dtype=int64):09}"
        data += f"'{phone}', '{randemail(fullname, phone)}', "
        data += f"'{prefix}NV{random.randint(1, nvien_size + 1):04}' "
        data += "FROM DUAL"
        data += " UNION ALL\n" if i != size - 1 else ";\n"
        file.write(data)
    file.close()

def gen_doanhnghiep(nvien_size, size, start=0, fmode="w"):
    file = open(f"{dir_path}/out.txt", fmode, encoding="utf-8")
    size = start + size
    file.write("INSERT INTO DOANHNGHIEP\n")
    for i in range(start, size):
        data = f"\tSELECT '{prefix}DN{i+1:04}', "
        fullname = randfullname(random.randint(len(genders)))
        name = f"{corps[random.randint(len(corps))]} "
        name += f"{fields[random.randint(len(fields))]} "
        data += f"'{name}{' '.join(fullname.split(' ')[1:]).upper()}', "

        tax_num = f"{random.randint(100):02}{random.randint(10**7):07}"
        tax_num += f"{random.randint(10)}-{random.randint(1000):03}"
        data += f"'{tax_num}', '{fullname}', '{randaddress()}', "

        phone = f"09{random.randint(phone_digit_cnt, dtype=int64):09}"
        data += f"'{randemail(fullname, phone)}', "

        date = f"{randdate('01/01/2024', '20/03/2024').split(' ')[0]}"
        data += f"TO_DATE('{date}', 'DD/MM/YYYY'), "
        date = f"{randdate(inc_days(date, 1), '01/05/2024').split(' ')[0]}"
        data += f"TO_DATE('{date}', 'DD/MM/YYYY'), "

        data += f"'{prefix}NV{random.randint(1, nvien_size + 1):04}' "
        data += "FROM DUAL"
        data += " UNION ALL\n" if i != size - 1 else ";\n"
        file.write(data)
    file.close()

def main():
    gen_nhansu(1, 10)
    gen_nhansu(2, 10, fmode="a")
    gen_ungvien(10, 20, fmode="a")
    gen_doanhnghiep(10, 20, fmode="a")

if __name__ == "__main__":
    pop_names(dir_path)
    pop_addresses(dir_path)
    main()