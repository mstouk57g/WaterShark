
from flask import Flask, request
from getnames import getname

app = Flask(__name__)

@app.route('/toggle',methods=['get','post'])

#def hello_world():
  #  username = request.values.get('name')
   # return getname()
def toggle():
    m = request.values.get('key')
    n = int(request.values.get('value'))
    c = request.values.get('class')
    res = getname(m = m, n = n)
    return res

@app.route('/args',methods=['get','post'])
def args():
    arg = request.values.get("arg")
    print(arg)
    return "200"

if __name__ == '__main__':
    app.run()