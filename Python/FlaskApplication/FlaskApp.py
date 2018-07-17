from flask import Flask, render_template

application = Flask(__name__)


@application.route('/')
def index():
    return render_template('Home.html')


if __name__ == '__main__':
    application.run(host='localhost', port=5000, debug=True)
