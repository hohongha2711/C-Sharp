import requests
from bs4 import BeautifulSoup
import csv
import pandas as pd
import urllib.request
#work_data = pd.DataFrame(columns = ['TenCongViec','TenCongTy','DiaChi','MucLuong','MoTa','YeuCau','TenLienHe','SDT','Mail','DiaChiLienHe','Note'])

def download_image(url, name):
    #name = random.randrange(1,100)
    fullname = str(name)+".png"
    urllib.request.urlretrieve(url,fullname)


data = pd.read_csv('D:\ADMIN\Documents\congty.csv')
#print(data)

dt = []
dt = data["Logo"]
dtc = data["TenCongTy"]
i = 1
for d in dt:
  
    print(i)
#url = 'https://www.careerlink.vn/tim-viec-lam/lap-trinh-vien-sap-senior-staff/2400219?area_code=HCM&source=site'
    download_image(d,i)
    i = i+1