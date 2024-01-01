import json
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