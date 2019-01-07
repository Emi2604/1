using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT
{
    public partial class Form1 : Form
    {
        public int modp;            // zmienna zawierająca cyfre odpowiadajaca miejscu z dobra odpowiedzia
        public int poziom=0;          // zmienna okreslajaca aktualny poziom, wartosci od 1 do 30
        private int licznik;        // zmienna okreslajaca jak dlugo ma trwac opadanie rownania
        int flaga=0;
        int poprawnosc=1;         // zmienna, ktora w przypadku wykrycia pomylki przyjmuje wartosc 0
        int ilosc_zlych_odp;        // licznik pomylek
        int maxY;                   // zmienna okreslajaca wspolrzedne Y maksymalnego oddalenia rownania
        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Przebieg gry, inicjalizacja losowania rownania, tworzenie obiektu rownanie i 
        /// przypisanie jego wlasciwosci do wslasciwosci kontrolek, zliczanie zlych i dobrych odpowiedzi
        /// </summary>
        public void gra()
        {
            
            if(poziom==0)
            {
                poziom = 1; // poziom od 1 do 30
            }
            
            int liczba1 = 0;// pierwsza liczba rownania
            int liczba2 = 0;// druga liczba rownania
            int znak = 0; // okresla typ rownania: 0-dodawanie 1-odejmowanie 2- mnozenie
            int min = 0; // minimalna wartosc liczb w dodawaniu i odejmowaniu
            int max = 0; // maksymalna wartosc liczb w dodawaniu i odejmowaniu
            int mMax = 0; // maksymalna wartość liczb rownania w przypadku mnozenia
            int zakres = 0; // okresla jakie sa mozliwe typy rownan: 1 - dodawanie i odejmowanie 2 - dodatkowo monzenie
            
          
                    
                    if (poziom <= 10)// w przypadku najnizszego poziomu
                    {
                        min = 0;
                        max = 50;
                        zakres = 1;
                    }
                    else if (poziom > 10 && poziom <= 20) // w przypadku drugiego poziomu trudnosci
                    {
                        min = 0;
                        max = 150;
                        mMax = 20;
                        zakres = 2;
                    }
                    else // w przypadku najwyzszego poziomu trudnosci
                    {
                        min = 0;
                        max = 200;
                        mMax = 30;
                        zakres = 2;
                    }
                    Random losuje = new Random();
                    znak = losuje.Next(0, zakres + 1); // losuje typ rownania: dodawanie odejmowanie lub mnozenie

                    if (znak == 2)
                    {
                        liczba1 = losuje.Next(min, mMax); // losuje pierwsza liczbe z zakresu dla mnozenia
                        liczba2 = losuje.Next(min, mMax); // losuje druga liczbe z zakresu dla mnozenia
                    }
                    else
                    {
                        liczba1 = losuje.Next(min, max); // losuje pierwsza liczbe z zakresu 
                        liczba2 = losuje.Next(min, max); // losuje druga liczbe z zakresu 
                    }

            // tworzony jest obiekt klasy Rownanie z wylosowanymi liczbami
            Rownanie liczba = new Rownanie(liczba1, liczba2, poziom, znak);
            // przypasowanie odpowiednich wlasciwosci obiektu do zawartosci kontrolek
                    modp = liczba.mOdp;
                    button1.Text = liczba.rownanko;
                    button11.Text = liczba.wynikA.ToString();
                    button10.Text = liczba.wynikB.ToString();
                    button9.Text = liczba.wynikC.ToString();
                    button8.Text = liczba.wynikD.ToString();
                    button7.Text = liczba.wynikE.ToString();
                    button5.Text = liczba.poziom.ToString();

            sprawdzenie();
           
        }
        /// <summary>
        /// Inkrenentacja licznika zlych i dobrych odpowiedzi
        /// </summary>
        private void sprawdzenie()
        {
            button5.Text = poziom.ToString();
            if (poprawnosc == 1)
            {
                poziom++;
            }
            else
            {
                ilosc_zlych_odp++;
                blad();
            }
            if (poziom == 31)
            {
                timer1.Stop();
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
            }
            button16.Text = ilosc_zlych_odp.ToString();
            
        }

        /// <summary>
        /// Rozpoczecie gry
        /// </summary>
        /// <param name="sender">Wydarzenie przycisku START</param>
        /// <param name="e">Wydarzenie zwiazane z kliknieciem mysza na przycisk</param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Start
            if(flaga==0)
            {
                rozpoczecie();
                flaga = 1;
            }
        }

        private void rozpoczecie()
        {
            ilosc_zlych_odp = 0;
            poprawnosc = 1;
            poziom = 0;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            InitializeTimer(1000);
            gra();
        }
        
        /// <summary>
        /// Zamkniecie programu
        /// </summary>
        /// <param name="sender">Wydarzenie przycisku ZAKONCZ</param>
        /// <param name="e">Wydarzenie zwiazane z kliknieciem mysza na przycisk</param>
        private void button6_Click(object sender, EventArgs e)
        {
            // Zakoncz
            Environment.Exit(1);
        }

        /// <summary>
        /// Sterowanie przyciskiem A w lewo i przyciskiem D w prawo
        /// </summary>
        /// <param name="sender">Reakcja na wcisniecie klawiszy A,S,D</param>
        /// <param name="e">Wydarzenie dotyczace przycisku z rownaniem</param>
        private void cos(object sender, KeyEventArgs e)
        { // reakcja na wcisniecie klawiszy A,S,D
            int lokacjax = button1.Location.X;
            int lokacjay = button1.Location.Y;
            if (e.KeyCode == Keys.D && button1.Location.X<400 && button1.Location.Y < 320)
            {
                 this.button1.Location = new Point(lokacjax + 113, lokacjay);
            }
            if (e.KeyCode == Keys.A && button1.Location.X >120 && button1.Location.Y < 320)
            {
                this.button1.Location = new Point(lokacjax - 113, lokacjay );
            }
            if (e.KeyCode == Keys.S && button1.Location.Y < 320)
            {
                this.button1.Location = new Point(lokacjax, Liczenie.pozycjaY(maxY));
               
                
            }

        }
        /// <summary>
        /// Metoda zmieniajaca polozenie przycisku z rownaniem
        /// Przesuniecie o 30 wzdluz osi Y, w dol, co wyznaczony przez timer czas
        /// </summary>
        public void opadanie() 
        { 
            if (button1.Location.Y < Liczenie.pozycjaY(maxY))
            {
                this.button1.Location = new Point(button1.Location.X, button1.Location.Y + 30);
            }
        }
        /// <summary>
        /// Inicjalizacja timera
        /// </summary>
        /// <param name="czas">Wartosc interwalu</param>
        private void InitializeTimer(int czas)
        { // inicjalizacja timera, ustawieie opoznienia
            maxY = 11;
            timer1.Interval = czas;
            timer1.Enabled = true;
            timer1.Start();
            button1.Location = new Point(243, 0);
        }
        /// <summary>
        /// Zawiera operacje ktore sa wykonywane po kazdym odmierzeniu czasu przez timer
        /// </summary>
        /// <param name="sender">Timer</param>
        /// <param name="e">Wydarzenie zwiazane z timerem</param>
        private void timer1_Tick(object sender, EventArgs e)
        { 
            licznik++;
            opadanie();
            
            if (licznik==maxY)
            {
                // wywolanie metody ktora sprawdza czy rownianie znalazlo sie przy poprawnej odpowiedzi
                poprawnosc = Liczenie.sprawdzenie(button1.Location.X,modp);
                
                button1.Location = new Point(243, 0);
                licznik = 0;
                gra(); 
            }

        }
        /// <summary>
        /// Klikniecie przycisku RESET powoduje uruchomienie gry od nowa
        /// </summary>
        /// <param name="sender">Wydarzenie dotyczy przycisku RESET</param>
        /// <param name="e">Wydarzenie dotyczy klikniecia mysza</param>
        private void button3_Click(object sender, EventArgs e)
        {
            rozpoczecie();
        }
        /// <summary>
        /// Metoda za pojawienie sie przyciskow ograniczajacych czas na rozwiazanie rownania
        /// </summary>
        public void blad()
        {
            switch (ilosc_zlych_odp)
            {
                case 1:
                    button12.Visible = true;
                    maxY = 8;
                    break;
                case 2:
                    button13.Visible = true;
                    maxY = 6;
                    break;
                case 3:
                    button14.Visible = true;
                    maxY = 4;
                    break;
                default:
                    break;

            }
        }
        /// <summary>
        /// Niewykorzystane wydarzenie ktorego nie mozna usunac z kodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void klik(object sender, MouseEventArgs e)
        {      }
        /// <summary>
        /// Niewykorzystane wydarzenie ktorego nie mozna usunac z kodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strzalki(object sender, KeyEventArgs e)
        {}
    }
}
