import json
from sqlite3 import DatabaseError

namejson = "C:/Test/python.json"
temf = open(namejson, encoding="utf-8")
jsonfile = json.load(temf)
temf.close()
data = list(jsonfile)

def getname(m, n):
    dic = data[n]
    offline = dic[m]
    return offline
    