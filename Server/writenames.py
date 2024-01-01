import json
from getnames import getname
namejson = "./datas/writenamelist.json"


def writenames(classes, time, names):
    temf = open(namejson, encoding="utf-8")
    jsonfile = json.load(temf)
    temf.close()
    data = dict(jsonfile)
    
    name = names.split(",")
    dic = {"time":time,
            "class":classes,
            "names":name}
    data[time] = dic
    finish = json.dumps(data)
    
    with open(namejson, 'w') as f:
        f.write(finish)

def getnamelists(classes):
    temf = open(namejson, encoding="utf-8")
    jsonfile = json.load(temf)
    temf.close()
    data = dict(jsonfile)
    key_list = list(data.keys())
    return key_list

def getnames(classes, time):
    time = time[:-1]
    time = time[1:]
    
    temf = open(namejson, encoding="utf-8")
    jsonfile = json.load(temf)
    temf.close()
    data = dict(jsonfile)
    
    names = data[time]
    name = names["names"]
    
    listnumber = len(name)
    lists = []
    for i in range(listnumber):
        co = getname(m = "name", n = i)
        lists.append(co)
    return lists