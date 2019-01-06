using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    class Rownanie
    {
        

            public int wynikA { get; set; }
            public int wynikB { get; set; }
            public int wynikC { get; set; }
            public int wynikD { get; set; }
            public int wynikE { get; set; }
            public String rownanko { get; set; }
            public int poziom { get; set; }


            public Rownanie(int liczba1, int liczba2, int poziomy, int znak)
            {
                int poprawnaOdp = 0;
                poprawnaOdp = obliczanie1(liczba1, liczba2, znak); // wywoluje metode obliczjaca wynik
                                                                   //wynikD = poprawnaOdp;// prototyp

                poziom = poziomy;

                // ustawienie rownania
                string sLiczba1 = Convert.ToString(liczba1);
                string sLiczba2 = Convert.ToString(liczba2);
                if (znak == 1)// dodawanie
                {
                    poprawnaOdp = liczba1 + liczba2;
                    rownanko = sLiczba1 + "+" + sLiczba2 + "=";
                }
                else if (znak == 2)// mnozenie
                {
                    poprawnaOdp = liczba1 * liczba2;
                    rownanko = sLiczba1 + "*" + sLiczba2 + "=";
                }
                else // gdy znak = 0 albo zostala podana wartosc spoza zakresu odejmowanie
                {
                    poprawnaOdp = liczba1 - liczba2;
                    rownanko = sLiczba1 + "-" + sLiczba2 + "=";
                }
                // losowanie miejsca dobrej odp
                int miejsceDobrejOdp = miejsceOdp();

                //losowanie zlych wynikow i ustawianie wszystkich odpowiedzi
                int[] wyniki = new int[4]; // zawiera wartosci zlych odpowiedzi
                int[] miejsca = new int[5]; // zawiera uporzadkowane zle i dobra odp
                miejsca[miejsceDobrejOdp] = poprawnaOdp; // przypisanie poprawnej odp do wylosowanego jej miejsca
                Random losuje = new Random();

                for (int i = 0; i < 4; i++) // losowanie wartosci 4 zlych odpowiedzi
                {
                    wyniki[i] = losuje.Next(poprawnaOdp - 20, poprawnaOdp + 20);
                }
                for (int i = 0; i < 4; i++) // przyporzadkowanie liczb do ich miejsc
                {
                    if (i == miejsceDobrejOdp)
                    {
                        miejsca[4] = wyniki[i];
                    }
                    else
                    {
                        miejsca[i] = wyniki[i];
                    }

                }
                wynikA = miejsca[0]; //miejsca[0];
                wynikB = miejsca[1];
                wynikC = miejsca[2];
                wynikD = miejsca[3];
                wynikE = miejsca[4];


            }

            public static int obliczanie1(int liczba1, int liczba2, int znak)// obliczanie poprawnej odpowiedzi
            {
                int wynik = 0;

                if (znak == 1)
                {
                    wynik = liczba1 + liczba2;
                }
                if (znak == 2)
                {
                    wynik = liczba1 * liczba2;
                }
                else
                {
                    wynik = liczba1 - liczba2;
                }
                return wynik;

            }
            public static int miejsceOdp()
            {
                int miejsce = 0;
                Random losuje = new Random();
                miejsce = losuje.Next(1, 5);

                return miejsce;
            }




        
    }
}
