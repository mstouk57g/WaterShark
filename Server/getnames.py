import json



def getname(m, n):
    namejson = "./datas/getnames.json"
    temf = open(namejson, encoding="utf-8")
    jsonfile = json.load(temf)
    temf.close()
    
    data = dict(jsonfile)
    key_list = list(data.keys())
    
    dic = key_list[n]
    coser = data[dic]
    offline = coser[m]
    return offline
    