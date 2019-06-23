using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Adres
    public class Adres
    {
        #region Member Variables
        protected int _idAdres;
        protected string _Kraj;
        protected string _Miejscowość;
        protected string _Ulica;
        protected int _Nr_domu;
        protected int _Nr_mieszkania;
        protected string _Kod_pocztowy;
        #endregion
        #region Constructors
        public Adres() { }
        public Adres(string Kraj, string Miejscowość, string Ulica, int Nr_domu, int Nr_mieszkania, string Kod_pocztowy)
        {
            this._Kraj=Kraj;
            this._Miejscowość=Miejscowość;
            this._Ulica=Ulica;
            this._Nr_domu=Nr_domu;
            this._Nr_mieszkania=Nr_mieszkania;
            this._Kod_pocztowy=Kod_pocztowy;
        }
        #endregion
        #region Public Properties
        public virtual int IdAdres
        {
            get {return _idAdres;}
            set {_idAdres=value;}
        }
        public virtual string Kraj
        {
            get {return _Kraj;}
            set {_Kraj=value;}
        }
        public virtual string Miejscowość
        {
            get {return _Miejscowość;}
            set {_Miejscowość=value;}
        }
        public virtual string Ulica
        {
            get {return _Ulica;}
            set {_Ulica=value;}
        }
        public virtual int Nr_domu
        {
            get {return _Nr_domu;}
            set {_Nr_domu=value;}
        }
        public virtual int Nr_mieszkania
        {
            get {return _Nr_mieszkania;}
            set {_Nr_mieszkania=value;}
        }
        public virtual string Kod_pocztowy
        {
            get {return _Kod_pocztowy;}
            set {_Kod_pocztowy=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Czujnik
    public class Czujnik
    {
        #region Member Variables
        protected int _idCzujnik;
        protected string _Nazwa;
        protected unknown _Cena;
        protected int _Ilość_w_magazynie;
        protected int _Producent_idProducent;
        #endregion
        #region Constructors
        public Czujnik() { }
        public Czujnik(string Nazwa, unknown Cena, int Ilość_w_magazynie, int Producent_idProducent)
        {
            this._Nazwa=Nazwa;
            this._Cena=Cena;
            this._Ilość_w_magazynie=Ilość_w_magazynie;
            this._Producent_idProducent=Producent_idProducent;
        }
        #endregion
        #region Public Properties
        public virtual int IdCzujnik
        {
            get {return _idCzujnik;}
            set {_idCzujnik=value;}
        }
        public virtual string Nazwa
        {
            get {return _Nazwa;}
            set {_Nazwa=value;}
        }
        public virtual unknown Cena
        {
            get {return _Cena;}
            set {_Cena=value;}
        }
        public virtual int Ilość_w_magazynie
        {
            get {return _Ilość_w_magazynie;}
            set {_Ilość_w_magazynie=value;}
        }
        public virtual int Producent_idProducent
        {
            get {return _Producent_idProducent;}
            set {_Producent_idProducent=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Danekontaktowe
    public class Danekontaktowe
    {
        #region Member Variables
        protected int _idDanekontaktowe;
        protected string _Email;
        protected int _Nr_Telefonu;
        #endregion
        #region Constructors
        public Danekontaktowe() { }
        public Danekontaktowe(string Email, int Nr_Telefonu)
        {
            this._Email=Email;
            this._Nr_Telefonu=Nr_Telefonu;
        }
        #endregion
        #region Public Properties
        public virtual int IdDanekontaktowe
        {
            get {return _idDanekontaktowe;}
            set {_idDanekontaktowe=value;}
        }
        public virtual string Email
        {
            get {return _Email;}
            set {_Email=value;}
        }
        public virtual int Nr_Telefonu
        {
            get {return _Nr_Telefonu;}
            set {_Nr_Telefonu=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Klient
    public class Klient
    {
        #region Member Variables
        protected int _idKlient;
        protected string _Imię;
        protected string _Nazwisko;
        protected unknown _PESEL;
        protected int _Adres_idAdres;
        protected int _Danekontaktowe_idDanekontaktowe;
        #endregion
        #region Constructors
        public Klient() { }
        public Klient(string Imię, string Nazwisko, unknown PESEL, int Adres_idAdres, int Danekontaktowe_idDanekontaktowe)
        {
            this._Imię=Imię;
            this._Nazwisko=Nazwisko;
            this._PESEL=PESEL;
            this._Adres_idAdres=Adres_idAdres;
            this._Danekontaktowe_idDanekontaktowe=Danekontaktowe_idDanekontaktowe;
        }
        #endregion
        #region Public Properties
        public virtual int IdKlient
        {
            get {return _idKlient;}
            set {_idKlient=value;}
        }
        public virtual string Imię
        {
            get {return _Imię;}
            set {_Imię=value;}
        }
        public virtual string Nazwisko
        {
            get {return _Nazwisko;}
            set {_Nazwisko=value;}
        }
        public virtual unknown PESEL
        {
            get {return _PESEL;}
            set {_PESEL=value;}
        }
        public virtual int Adres_idAdres
        {
            get {return _Adres_idAdres;}
            set {_Adres_idAdres=value;}
        }
        public virtual int Danekontaktowe_idDanekontaktowe
        {
            get {return _Danekontaktowe_idDanekontaktowe;}
            set {_Danekontaktowe_idDanekontaktowe=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Koszyk_zamówienie
    public class Koszyk_zamówienie
    {
        #region Member Variables
        protected int _idKoszyk;
        protected int _Czujnik_idCzujnik;
        protected int _Zamówienie_idZamówienie;
        #endregion
        #region Constructors
        public Koszyk_zamówienie() { }
        public Koszyk_zamówienie(int Czujnik_idCzujnik, int Zamówienie_idZamówienie)
        {
            this._Czujnik_idCzujnik=Czujnik_idCzujnik;
            this._Zamówienie_idZamówienie=Zamówienie_idZamówienie;
        }
        #endregion
        #region Public Properties
        public virtual int IdKoszyk
        {
            get {return _idKoszyk;}
            set {_idKoszyk=value;}
        }
        public virtual int Czujnik_idCzujnik
        {
            get {return _Czujnik_idCzujnik;}
            set {_Czujnik_idCzujnik=value;}
        }
        public virtual int Zamówienie_idZamówienie
        {
            get {return _Zamówienie_idZamówienie;}
            set {_Zamówienie_idZamówienie=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Pomiar
    public class Pomiar
    {
        #region Member Variables
        protected int _idPomiar;
        protected unknown _Data_rozpocząecia;
        protected unknown _Data_zakończenia;
        protected string _Lokalizacja;
        protected int _Czujnik_idCzujnik;
        #endregion
        #region Constructors
        public Pomiar() { }
        public Pomiar(unknown Data_rozpocząecia, unknown Data_zakończenia, string Lokalizacja, int Czujnik_idCzujnik)
        {
            this._Data_rozpocząecia=Data_rozpocząecia;
            this._Data_zakończenia=Data_zakończenia;
            this._Lokalizacja=Lokalizacja;
            this._Czujnik_idCzujnik=Czujnik_idCzujnik;
        }
        #endregion
        #region Public Properties
        public virtual int IdPomiar
        {
            get {return _idPomiar;}
            set {_idPomiar=value;}
        }
        public virtual unknown Data_rozpocząecia
        {
            get {return _Data_rozpocząecia;}
            set {_Data_rozpocząecia=value;}
        }
        public virtual unknown Data_zakończenia
        {
            get {return _Data_zakończenia;}
            set {_Data_zakończenia=value;}
        }
        public virtual string Lokalizacja
        {
            get {return _Lokalizacja;}
            set {_Lokalizacja=value;}
        }
        public virtual int Czujnik_idCzujnik
        {
            get {return _Czujnik_idCzujnik;}
            set {_Czujnik_idCzujnik=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Pomiary
    public class Pomiary
    {
        #region Member Variables
        protected int _id;
        protected int _WartoscPomiaru;
        protected unknown _GodzPomiaru;
        #endregion
        #region Constructors
        public Pomiary() { }
        public Pomiary(int WartoscPomiaru, unknown GodzPomiaru)
        {
            this._WartoscPomiaru=WartoscPomiaru;
            this._GodzPomiaru=GodzPomiaru;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual int WartoscPomiaru
        {
            get {return _WartoscPomiaru;}
            set {_WartoscPomiaru=value;}
        }
        public virtual unknown GodzPomiaru
        {
            get {return _GodzPomiaru;}
            set {_GodzPomiaru=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Pracownicy
    public class Pracownicy
    {
        #region Member Variables
        protected int _idPracownicy;
        protected string _Imię;
        protected string _Nazwisko;
        protected string _Nr_konta;
        protected int _Danekontaktowe_idDanekontaktowe;
        protected int _Stanowisko_idStanowisko;
        #endregion
        #region Constructors
        public Pracownicy() { }
        public Pracownicy(string Imię, string Nazwisko, string Nr_konta, int Danekontaktowe_idDanekontaktowe, int Stanowisko_idStanowisko)
        {
            this._Imię=Imię;
            this._Nazwisko=Nazwisko;
            this._Nr_konta=Nr_konta;
            this._Danekontaktowe_idDanekontaktowe=Danekontaktowe_idDanekontaktowe;
            this._Stanowisko_idStanowisko=Stanowisko_idStanowisko;
        }
        #endregion
        #region Public Properties
        public virtual int IdPracownicy
        {
            get {return _idPracownicy;}
            set {_idPracownicy=value;}
        }
        public virtual string Imię
        {
            get {return _Imię;}
            set {_Imię=value;}
        }
        public virtual string Nazwisko
        {
            get {return _Nazwisko;}
            set {_Nazwisko=value;}
        }
        public virtual string Nr_konta
        {
            get {return _Nr_konta;}
            set {_Nr_konta=value;}
        }
        public virtual int Danekontaktowe_idDanekontaktowe
        {
            get {return _Danekontaktowe_idDanekontaktowe;}
            set {_Danekontaktowe_idDanekontaktowe=value;}
        }
        public virtual int Stanowisko_idStanowisko
        {
            get {return _Stanowisko_idStanowisko;}
            set {_Stanowisko_idStanowisko=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Producent
    public class Producent
    {
        #region Member Variables
        protected int _idProducent;
        protected string _Nazwa;
        protected string _Adres_strony;
        #endregion
        #region Constructors
        public Producent() { }
        public Producent(string Nazwa, string Adres_strony)
        {
            this._Nazwa=Nazwa;
            this._Adres_strony=Adres_strony;
        }
        #endregion
        #region Public Properties
        public virtual int IdProducent
        {
            get {return _idProducent;}
            set {_idProducent=value;}
        }
        public virtual string Nazwa
        {
            get {return _Nazwa;}
            set {_Nazwa=value;}
        }
        public virtual string Adres_strony
        {
            get {return _Adres_strony;}
            set {_Adres_strony=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Sposób_dostawy
    public class Sposób_dostawy
    {
        #region Member Variables
        protected int _idSposób_dostawy;
        protected unknown _Kurier;
        protected unknown _Przesyłka_pocztowa;
        protected unknown _Przesyłka_polecona;
        protected unknown _Odbiór_osobisty;
        #endregion
        #region Constructors
        public Sposób_dostawy() { }
        public Sposób_dostawy(unknown Kurier, unknown Przesyłka_pocztowa, unknown Przesyłka_polecona, unknown Odbiór_osobisty)
        {
            this._Kurier=Kurier;
            this._Przesyłka_pocztowa=Przesyłka_pocztowa;
            this._Przesyłka_polecona=Przesyłka_polecona;
            this._Odbiór_osobisty=Odbiór_osobisty;
        }
        #endregion
        #region Public Properties
        public virtual int IdSposób_dostawy
        {
            get {return _idSposób_dostawy;}
            set {_idSposób_dostawy=value;}
        }
        public virtual unknown Kurier
        {
            get {return _Kurier;}
            set {_Kurier=value;}
        }
        public virtual unknown Przesyłka_pocztowa
        {
            get {return _Przesyłka_pocztowa;}
            set {_Przesyłka_pocztowa=value;}
        }
        public virtual unknown Przesyłka_polecona
        {
            get {return _Przesyłka_polecona;}
            set {_Przesyłka_polecona=value;}
        }
        public virtual unknown Odbiór_osobisty
        {
            get {return _Odbiór_osobisty;}
            set {_Odbiór_osobisty=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Sposób_płatności
    public class Sposób_płatności
    {
        #region Member Variables
        protected int _idSposób_płatności;
        protected unknown _Przelew;
        protected unknown _Karta_płatnica;
        #endregion
        #region Constructors
        public Sposób_płatności() { }
        public Sposób_płatności(unknown Przelew, unknown Karta_płatnica)
        {
            this._Przelew=Przelew;
            this._Karta_płatnica=Karta_płatnica;
        }
        #endregion
        #region Public Properties
        public virtual int IdSposób_płatności
        {
            get {return _idSposób_płatności;}
            set {_idSposób_płatności=value;}
        }
        public virtual unknown Przelew
        {
            get {return _Przelew;}
            set {_Przelew=value;}
        }
        public virtual unknown Karta_płatnica
        {
            get {return _Karta_płatnica;}
            set {_Karta_płatnica=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Stanowisko
    public class Stanowisko
    {
        #region Member Variables
        protected int _idStanowisko;
        protected unknown _Kierownik;
        protected unknown _Sprzedawca;
        protected unknown _Magazynier;
        protected unknown _Administrator;
        #endregion
        #region Constructors
        public Stanowisko() { }
        public Stanowisko(unknown Kierownik, unknown Sprzedawca, unknown Magazynier, unknown Administrator)
        {
            this._Kierownik=Kierownik;
            this._Sprzedawca=Sprzedawca;
            this._Magazynier=Magazynier;
            this._Administrator=Administrator;
        }
        #endregion
        #region Public Properties
        public virtual int IdStanowisko
        {
            get {return _idStanowisko;}
            set {_idStanowisko=value;}
        }
        public virtual unknown Kierownik
        {
            get {return _Kierownik;}
            set {_Kierownik=value;}
        }
        public virtual unknown Sprzedawca
        {
            get {return _Sprzedawca;}
            set {_Sprzedawca=value;}
        }
        public virtual unknown Magazynier
        {
            get {return _Magazynier;}
            set {_Magazynier=value;}
        }
        public virtual unknown Administrator
        {
            get {return _Administrator;}
            set {_Administrator=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region User
    public class User
    {
        #region Member Variables
        protected int _id;
        protected string _name;
        protected string _email;
        protected string _username;
        protected string _password;
        #endregion
        #region Constructors
        public User() { }
        public User(string name, string email, string username, string password)
        {
            this._name=name;
            this._email=email;
            this._username=username;
            this._password=password;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Username
        {
            get {return _username;}
            set {_username=value;}
        }
        public virtual string Password
        {
            get {return _password;}
            set {_password=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mydb
{
    #region Zamówienie
    public class Zamówienie
    {
        #region Member Variables
        protected int _idZamówienie;
        protected unknown _Data_złożenia;
        protected unknown _Koszt;
        protected unknown _KosztVAT;
        protected int _Klient_idKlient;
        protected int _Sposób_płatności_idSposób_płatności;
        protected int _Sposób_dostawy_idSposób_dostawy;
        protected int _Adres_idAdres;
        #endregion
        #region Constructors
        public Zamówienie() { }
        public Zamówienie(unknown Data_złożenia, unknown Koszt, unknown KosztVAT, int Klient_idKlient, int Sposób_płatności_idSposób_płatności, int Sposób_dostawy_idSposób_dostawy, int Adres_idAdres)
        {
            this._Data_złożenia=Data_złożenia;
            this._Koszt=Koszt;
            this._KosztVAT=KosztVAT;
            this._Klient_idKlient=Klient_idKlient;
            this._Sposób_płatności_idSposób_płatności=Sposób_płatności_idSposób_płatności;
            this._Sposób_dostawy_idSposób_dostawy=Sposób_dostawy_idSposób_dostawy;
            this._Adres_idAdres=Adres_idAdres;
        }
        #endregion
        #region Public Properties
        public virtual int IdZamówienie
        {
            get {return _idZamówienie;}
            set {_idZamówienie=value;}
        }
        public virtual unknown Data_złożenia
        {
            get {return _Data_złożenia;}
            set {_Data_złożenia=value;}
        }
        public virtual unknown Koszt
        {
            get {return _Koszt;}
            set {_Koszt=value;}
        }
        public virtual unknown KosztVAT
        {
            get {return _KosztVAT;}
            set {_KosztVAT=value;}
        }
        public virtual int Klient_idKlient
        {
            get {return _Klient_idKlient;}
            set {_Klient_idKlient=value;}
        }
        public virtual int Sposób_płatności_idSposób_płatności
        {
            get {return _Sposób_płatności_idSposób_płatności;}
            set {_Sposób_płatności_idSposób_płatności=value;}
        }
        public virtual int Sposób_dostawy_idSposób_dostawy
        {
            get {return _Sposób_dostawy_idSposób_dostawy;}
            set {_Sposób_dostawy_idSposób_dostawy=value;}
        }
        public virtual int Adres_idAdres
        {
            get {return _Adres_idAdres;}
            set {_Adres_idAdres=value;}
        }
        #endregion
    }
    #endregion
}