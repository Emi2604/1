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
        private int licznik;
        public int lokalizacja;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        public void gra()
        {
            InitializeTimer(700);

            int poziom = 1; // poziom od 1 do 30
            int liczba1 = 0;// pierwsza liczba rownania
            int liczba2 = 0;// druga liczba rownania
            int znak = 0; // okresla typ rownania: 0-dodawanie 1-odejmowanie 2- mnozenie
            int min = 0; // minimalna wartosc liczb w dodawaniu i odejmowaniu
            int max = 0; // maksymalna wartosc liczb w dodawaniu i odejmowaniu
            int mMax = 0; // maksymalna wartość mnożnej i mnożnika
            int zakres = 0; // okresla jakie sa mozliwe typy rownan: 1 - dodawanie i odejmowanie 2 - dodatkowo monzenie
                            //do
                            //{
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



            Rownanie liczba = new Rownanie(liczba1, liczba2, poziom, znak); // tworzony jest obiekt klasy Rownanie z wylosowanymi liczbami
            button1.Text = liczba;
            odpD.DataContext = liczba;
            odpC.DataContext = liczba;
            odpB.DataContext = liczba;
            odpA.DataContext = liczba;

            nrPoziomu.DataContext = liczba;
            //} while (poziom <= 30); // gra trwa az do uzyskania 30 poprawnych odp
        }

        private void klik(object sender, MouseEventArgs e)
        {
           // rownanie

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start
            gra();
            

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            // Zakoncz
            Environment.Exit(1);
        }

        private void strzalki(object sender, KeyEventArgs e)
        {
 
        }

        private void cos(object sender, KeyEventArgs e)
        {
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
                this.button1.Location = new Point(lokacjax, 329);
            }

        }

        public void opadanie()
        {
            if (button1.Location.Y < 320)
            {
                this.button1.Location = new Point(button1.Location.X, button1.Location.Y + 30);
            }
        }

        private void InitializeTimer(int czas)
        {
            timer1.Interval = czas;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            licznik++;
            opadanie();
            if(licznik==11)
            {
                timer1.Stop();
            }

        }
    }
}
