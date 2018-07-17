from flask import Flask

application = Flask(__name__)


@application.route('/')
def index():
    return 'Index page reloaded'


if __name__ == '__main__':
    application.run(host='localhost', port=5000, debug=True)
