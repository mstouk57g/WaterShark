import json
import os


def getname(m, n, c):
    namejson = "./datas/class/" + c + "/getnames.json"
    temf = open(namejson, encoding="utf-8")
    jsonfile = json.load(temf)
    temf.close()
    
    data = dict(jsonfile)
    key_list = list(data.keys())
    
    dic = key_list[n]
    coser = data[dic]
    offline = coser[m]
    return offline

def getclassess():
    filedir = "./datas/class/"
    minison = os.listdir(filedir)
    return minison

def gettoggletf(c, button):
    namejson = "./datas/class/" + c + "/getnames.json"
    temf = open(namejson, encoding="utf-8")
    jsonfile = json.load(temf)
    temf.close()
    data = dict(jsonfile)
    
    a = data[button]
    b = str(a["enable"])
    return b
    