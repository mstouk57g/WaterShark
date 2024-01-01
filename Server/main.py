
from flask import Flask, request
from getnames import *
from writenames import *

app = Flask(__name__)

@app.route('/toggle',methods=['get','post'])

#def hello_world():
  #  username = request.values.get('name')
   # return getname()
def toggle():
    m = request.values.get('key')
    n = int(request.values.get('value'))
    c = request.values.get('class')
    res = getname(m = m, n = n, c = c)
    return res

@app.route('/gettf',methods=['get','post'])
def args():
    button = request.values.get("button")
    c = request.values.get("class")
    tf = gettoggletf(c = c, button = button)
    return tf

@app.route('/writename',methods=['get','post'])
def writename():
    classes = request.values.get("class")
    time = request.values.get("time")
    names = request.values.get("names")
    if names == None:
        return "没有提交任何数据"
    else:
        writenames(classes = classes, time = time, names = names)
        return "提交成功"
    
@app.route('/writenamelists',methods=['get','post'])
def writenamelists():
    classes = request.values.get("classes")
    lists = getnamelists(classes = classes)
    return lists

@app.route('/writenames',methods=['get','post'])
def writenames():
    classes = request.values.get("classes")
    times = request.values.get("time")
    lists = getnames(classes = classes, time=times)
    return lists

@app.route('/getclasses',methods=['get','post'])
def getclasses():
    a = getclassess()
    return a

if __name__ == '__main__':
    app.run()