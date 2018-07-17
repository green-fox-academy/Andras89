from flask import Flask, render_template
from data import all_articles

application = Flask(__name__)


@application.route('/')
def index():
    return render_template('Home.html')


@application.route('/about')
def about():
    return render_template('About.html')


@application.route('/articles')
def articles():
    return render_template('Articles.html', articles=all_articles())


if __name__ == '__main__':
    application.run(host='localhost', port=5000, debug=True)
