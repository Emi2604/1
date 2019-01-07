using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    /// <summary>
    /// Klasa zawierajaca metody pomocne w sprawdzeniu czy zostal wybrany wlasciwy wynik
    /// </summary>
    class Liczenie
    {
        /// <summary>
        /// Metoda sprawdzajaca czy przycisk z rownaniem zostal doprowadzony do poprawnej odpowiedzi
        /// </summary>
        /// <param name="lokacja">Wartosc wspolrzednej X przycisu z rownniem, kiedy czas dobiegl konca</param>
        /// <param name="miejsceodp">Numer przycislu z poprawna odpowiedzia, liczac od lewej od 0 do 4</param>
        /// <returns>W przypadku poprawnej odpowiedzi zwraca 1, przy bledzie 0</returns>
        public static int sprawdzenie(int lokacja, int miejsceodp)
        { 
            int odp = 0;
            int wyliczona_lokacja = 0;
            /// <summary>
            /// Zmienna wyliczona lokalizacja to wspolrzedna X danego przycisku z wynikiem
            /// Do niej jest porownana wspolrzedna X przycisku z rownaniem
            /// </summary>
            switch (miejsceodp)
            {
                case 0:
                    wyliczona_lokacja = 17;
                    break;
                case 1:
                    wyliczona_lokacja = 130;
                    break;
                case 2:
                    wyliczona_lokacja = 243;
                    break;
                case 3:
                    wyliczona_lokacja = 356;
                    break;
                case 4:
                    wyliczona_lokacja = 469;
                    break;
            }
            if (wyliczona_lokacja == lokacja)
            {
                odp = 1;
            }
            else
            {
                odp = 0;
            }
            return odp;
        }
        /// <summary>
        /// Metoda oblicza wspolrzedna Y na jakiej powinno konczyc sie opadanie przycisku z rownaniem
        /// Na podstawie maksymalnej wartosci licznika timera, ktora sie zmienia zaleznie od blednych odpowiedzi
        /// </summary>
        /// <param name="czas">Zmienna konieczna do wyliczenia pozycji koncowej przycisku z rownaniem</param>
        /// <returns>Pozycja obliczona przez wymnozenie max licznika timera przez 30 i odjeciu od wyniku 10 </returns>
        public static int pozycjaY(int czas)
        {
            int pozycja = czas*30-10;
            return pozycja;
        }


    }
}
