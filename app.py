from flask import Flask, render_template, flash, redirect, url_for, session, request, logging, jsonify, app
import mysql.connector
from wtforms import Form, StringField, TextAreaField, PasswordField, validators
from passlib.hash import sha256_crypt
from functools import wraps
from datetime import timedelta

app = Flask(__name__)



@app.before_request
def make_session_permanent():
    session.permanent = True
    app.permanent_session_lifetime = timedelta(minutes=5)

# Index
@app.route('/')
def index():
    return render_template('page.html')


# About
@app.route('/about')
def about():
    return render_template('about.html')


@app.route('/cz_turb')
def cz_turb():
    return render_template('cz_turb.html')

@app.route('/cz_temp')
def cz_temp():
    return render_template('cz_temp.html')

@app.route('/cz_wilg')
def cz_wilg():
    return render_template('cz_wilg.html')

@app.route('/cz_zyr')
def cz_zyr():
    return render_template('cz_zyr.html')

	
# Register Form Class
class RegisterForm(Form):
    name = StringField('Name', [validators.Length(min=1, max=50)])
    username = StringField('Username', [validators.Length(min=4, max=25)])
    email = StringField('Email', [validators.Length(min=6, max=50)])
    password = PasswordField('Password', [
        validators.DataRequired(),
        validators.EqualTo('confirm', message='Passwords do not match')
    ])
    confirm = PasswordField('Confirm Password')


# User Register
@app.route('/register', methods=['GET', 'POST'])
def register():
    form = RegisterForm(request.form)
    mySQL = mysql.connector.connect(host="localhost",
				user = "ProjektBazy",
				passwd = "123qwe",
				db = "mydb")

    if request.method == 'POST' and form.validate():
        name = form.name.data
        email = form.email.data
        username = form.username.data
        password = sha256_crypt.encrypt(str(form.password.data))

        # Create cursor
        cur = mySQL.cursor(buffered=True)

        # Execute query
        cur.execute("INSERT INTO user(name, email, username, password) VALUES(%s, %s, %s, %s)", (name, email, username, password))

        # Commit to DB
        mySQL.commit()

        # Close connection

        flash('You are now registered and can log in', 'success')
        mySQL.close()

        return redirect(url_for('login'))
    mySQL.close()
    return render_template('register.html', form=form)

# User login
@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        # Get Form Fields
        username = request.form['username']
        password_candidate = request.form['password']

        mySQL = mysql.connector.connect(host="localhost",
				user = "ProjektBazy",
				passwd = "123qwe",
				db = "mydb")
 
        # Create cursor
        cur = mySQL.cursor(buffered=True)
        
        # Get user by username
        cur.execute("SELECT * FROM user WHERE username = %s", [username])
        data = cur.fetchone()
        print(data)
        if data != None :
            # Get stored hash
            password = data[4]

            # Compare Passwords
            if sha256_crypt.verify(password_candidate, password):
                # Passed
                session['logged_in'] = True
                session['username'] = username
                session['id'] = data[0]
                session['id_urzadzenia'] = data[0]
                #cur.execute("SELECT * FROM Czujnik WHERE Urzadzenia_idUrzadzenia=%s",[session['id_urzadzenia']])
                #cur.execute("SELECT * FROM Czujnik WHERE Urzadzenia_idUrzadzenia=%s",[session['id_urzadzenia']])

                #Czujniki = cur.fetchall()
                #print("Zmienna Czujniki",Czujniki[1][1])
                # session['liczba_czujnikow'] = len(Czujniki)
                #print("Liczba czujników",session['liczba_czujnikow']," !!!!!!!") # test
                #for i in Czujniki:
               	#id_i_rodzaj = ("1=Temperatura","2=Światło","3=Smog")
               	#session['id_i_rodzaj'] = id_i_rodzaj
               	#print("ID_I_RODZAJ",id_i_rodzaj)
                flash('You are now logged in', 'success')
                return redirect(url_for('dashboard'))
            else:
                error = 'Invalid login'
                return render_template('login.html', error=error)
            # Close connection
            mySQL.close()
        else:
            error = 'Username not found'
            return render_template('login.html', error=error)

    return render_template('login.html')

# Check if user logged in
def is_logged_in(f):
    @wraps(f)
    def wrap(*args, **kwargs):
        if 'logged_in' in session:
            return f(*args, **kwargs)
        else:
            flash('Unauthorized, Please login', 'danger')
            return redirect(url_for('login'))
    return wrap

# Logout
@app.route('/logout')
@is_logged_in
def logout():
    session.clear()
    flash('You are now logged out', 'success')
    return redirect(url_for('login'))

# Dashboard
@app.route('/dashboard')
@is_logged_in
def dashboard():
	return render_template('dashboard.html')
############################################################
#                       Projekt_zespołowy                  #
############################################################
@app.route("/simple_chart")
def chart():

    if 'logged_in' in session:

        mySQL = mysql.connector.connect(host="localhost",
					user = "ProjektBazy",
					passwd = "123qwe",
					db = "mydb")

        cursor = mySQL.cursor(buffered=True)
        cursor.execute("SELECT WartoscPomiaru,GodzPomiaru FROM pomiary ORDER BY id DESC LIMIT 15" )

        value = []
        hour = []

        rows = cursor.fetchall()
        for row in rows:
            value.append(row[0])
            hour.append(str(row[1]))

        hour.reverse()
        value.reverse()
        legend = 'Dane z czujnika temperatury(1)'
        mySQL.close();
        return render_template('chart.html', values=value, labels=hour, legend=legend)
    else:
        return render_template('home.html')
		
@app.route("/czujnik")
def czujnik():

   # if 'logged_in' in session:

        mySQL = mysql.connector.connect(host="localhost",
					user = "ProjektBazy",
					passwd = "123qwe",
					db = "mydb")

        cursor = mySQL.cursor(buffered=True)

        cursor.execute("SELECT * FROM czujnik WHERE idCzujnik = 1")
        data = cursor.fetchone()
        nazwa = data[1]
        cena = data[2]
        id = data[0]
        ilosc = data[3]	
        session['nazwa'] = nazwa
        session['cena'] = cena
        session['id'] = id
        session['ilosc'] = ilosc
        cursor.execute("SELECT * FROM czujnik WHERE idCzujnik = 2")
        data = cursor.fetchone()
        nazwa = data[1]
        cena = data[2]
        id = data[0]
        ilosc = data[3]	
        session['nazwa2'] = nazwa
        session['cena2'] = cena
        session['id2'] = id
        session['ilosc2'] = ilosc
        cursor.execute("SELECT * FROM czujnik WHERE idCzujnik = 3")
        data = cursor.fetchone()
        nazwa = data[1]
        cena = data[2]
        id = data[0]
        ilosc = data[3]	
        session['nazwa3'] = nazwa
        session['cena3'] = cena
        session['id3'] = id
        session['ilosc3'] = ilosc
        cursor.execute("SELECT * FROM czujnik WHERE idCzujnik = 4")
        data = cursor.fetchone()
        nazwa = data[1]
        cena = data[2]
        id = data[0]
        ilosc = data[3]	
        session['nazwa4'] = nazwa
        session['cena4'] = cena
        session['id4'] = id
        session['ilosc4'] = ilosc
        print(nazwa)
        mySQL.close();
        return render_template('czujnik.html')
   # else:
    #    return render_template('home.html')
@app.route('/val')
def val():

    #if 'logged_in' in session:
        tmp_req = request.args.get('inter')
    
        print(tmp_req)

        mySQL = mysql.connector.connect(host="localhost",
				user = "ProjektBazy",
				passwd = "123qwe",
				db = "mydb")

        cursor = mySQL.cursor(buffered=True)
        
        zmienna = "SELECT WartoscPomiaru,GodzPomiaru FROM pomiary ORDER BY id DESC LIMIT " 
        tmp = zmienna+tmp_req
        cursor.execute(tmp)

        value = []
        hour = []

        rows = cursor.fetchall()
        for row in rows:
            value.append(row[0])
            hour.append(str(row[1]))
        value.reverse()
        hour.reverse()
        mySQL.close();
        return jsonify({'value' : value, 'hour' : hour})
    #else:
     #   return render_template('home.html')


@app.route('/req')
def req():
    tmp_req = request.args.get('inter')
    return '''<h1>reQ: {}</h1>'''.format(tmp_req)
	


@app.route("/line_chart")
def test():
	return render_template('line_chart.html')	
	
@app.route("/pracownicy")
def pracownicy():
	user = {'username': 'Jan Kowalski'}
	posts = [
        {
            'author': {'username': 'Paula Langkafel'},
            'body': 'Kierownik'
        },
        {
            'author': {'username': 'Krzysztof Przybyś'},
            'body': 'Pracownik magazynowy'
        }
    ]
	return render_template('pracownicy.html', title='Home', user=user, posts=posts)
	
@app.route("/ho")   
def ho():
    cursor.execute("SELECT WartoscPomiaru,GodzPomiaru FROM Pomiary")

    hour = []

    rows = cursor.fetchall()
    for row in rows:
        hour.append(str(row[1]))
    return jsonify({'hour' : hour})

############################################################
############################################################

if __name__ == '__main__':
    app.secret_key='secret123'
    app.run(debug=True)
