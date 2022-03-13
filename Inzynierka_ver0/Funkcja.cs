using System;
using System.IO;
namespace Inzynierka_ver0
{
    public enum Wybor
    {
        index,
        wartosc
    }
    public enum WyborRegresja
    {
        b,
        a
    }
    public enum WyborOsi
    {
        osX,
        osY
    }

    public static class Funkcja
    {
        static readonly double zamianaMpaNaPa = 1000000;
        static readonly double zamianaPaNaMpa = 0.000001;
        public static double[] ZamianaTablicyPaNaMPa(double[] tablicaWsadowa)
        {
            double[] tablicaWyjsciowa = new double[tablicaWsadowa.Length];
            for (int i = 0; i < tablicaWsadowa.Length; i++)
            {
                tablicaWyjsciowa[i] = tablicaWsadowa[i] * zamianaPaNaMpa;
            }
            return tablicaWyjsciowa;
        }

        public static double Maximum(double[] w1)
        {
            double[] Wartosc = new double[w1.Length];
            Wartosc = w1;
            double max = 0;
            for (int i = 0; i < Wartosc.Length; i++)
            {
                if (Wartosc[i] > max)
                {
                    max = Wartosc[i];
                }
            }
            return max;
        }

        public static double LiczCalkeMetodaProstokatow(int granicaCalkowaniaDolna, 
            int granicaCalkowaniaGorna, double[] daneOsiX, double[] daneOsiY)
        {
            double WartoscCalki = 0;
           
            for (int i = granicaCalkowaniaDolna; i < granicaCalkowaniaGorna; i++)
            {
                WartoscCalki += daneOsiY[i] * (daneOsiX[i + 1] - daneOsiX[i]);   
                
            }
            return WartoscCalki;
        }

        public static void ZapiszDaneDoPliku(string sciezka, double[] dane)
        {
            using (StreamWriter streamW = new StreamWriter(sciezka))
            {
                foreach (var wiersz in dane)
                    streamW.WriteLine(wiersz);
            }
        }

        public static double[] WczytajDane(string sciezkaPliku, int numerWierszaOdKtoregoDane)
        {
            string[] daneZPliku = File.ReadAllLines(sciezkaPliku);
            string zamiana;
            int numerWiersza = numerWierszaOdKtoregoDane;
            double[] wczytaneDane = new double[daneZPliku.Length - numerWiersza];

            for (int i = numerWiersza; i < wczytaneDane.Length + numerWiersza; i++)
            {
                zamiana = daneZPliku[i];
                zamiana = zamiana.Replace(".", ",");
                daneZPliku[i] = zamiana;
            }
            for (int i = numerWiersza; i < wczytaneDane.Length + numerWiersza; i++)
            {
                zamiana = daneZPliku[i];
                zamiana = zamiana.Replace(" ", "");
                daneZPliku[i] = zamiana;
            }
            for (int i = numerWiersza; i < wczytaneDane.Length + numerWiersza; i++)
            {
                wczytaneDane[i - numerWiersza] = Convert.ToDouble(daneZPliku[i]) * zamianaMpaNaPa;
            }
           
            return wczytaneDane;
        }
        public static double[] ObrobkaDanych(double[] daneWsadowe, int indexPunktZaplonu,double wartoscPunktZaplonu )
        {
            int index80 = Convert.ToInt32(PunktK(Wybor.index, daneWsadowe));
            
            double[] obrobioneDane = new double[daneWsadowe.Length - indexPunktZaplonu- (daneWsadowe.Length - index80)];
            for (int i = indexPunktZaplonu; i < daneWsadowe.Length- (daneWsadowe.Length - index80); i++)
            {
                obrobioneDane[i - indexPunktZaplonu] = daneWsadowe[i];
            }
            for (int i = 0; i < obrobioneDane.Length; i++)
            {
                obrobioneDane[i] = obrobioneDane[i] - wartoscPunktZaplonu;
            }
            
            return obrobioneDane;
        }

        public static double[] osX(double[] zbiorWartosci, double okresProbkowania)
        {

            double[] zbiorArgumentow = new double[zbiorWartosci.Length];
            for (int i = 0; i < zbiorWartosci.Length; i++)
            {
                zbiorArgumentow[i] = i * okresProbkowania;
            }
            return zbiorArgumentow;
        }

        public static double PunktZaplonu(Wybor indexCzyWartosc, double[] tablicaWsadowa,double cisnienieZaplonu)
        {
            cisnienieZaplonu *= 1000000;
            int indexPunkZaplonu = 0;
            double wartoscPunktZapłonu = 0;
            for (int i = 0; i < tablicaWsadowa.Length; i++)
            {
                if (tablicaWsadowa[i] >= cisnienieZaplonu)
                {
                    wartoscPunktZapłonu = tablicaWsadowa[i];
                    indexPunkZaplonu = Array.IndexOf(tablicaWsadowa, tablicaWsadowa[i]);
                    break;
                }
            }
            if (indexCzyWartosc == Wybor.index)
                return indexPunkZaplonu;
            else
                return wartoscPunktZapłonu;
        }

        public static double PunktK(Wybor indexCzyWartosc, double[] tablicaWsadowa)
        {
           
            int indexMax, index80Max = 0;
            indexMax = Array.IndexOf(tablicaWsadowa, Funkcja.Maximum(tablicaWsadowa));
            double punkt80maxWyliczeniowy;
            punkt80maxWyliczeniowy = 0.8 * Funkcja.Maximum(tablicaWsadowa);
            double punkt80Max = 0;
            for (int i = indexMax; i < tablicaWsadowa.Length; i++)
            {
                if (tablicaWsadowa[i] >= punkt80maxWyliczeniowy)
                {
                    index80Max = Array.IndexOf(tablicaWsadowa, tablicaWsadowa[i]);
                    punkt80Max = tablicaWsadowa[i];
                }
            }
            if (indexCzyWartosc == Wybor.index)
                return index80Max;
            else
                return punkt80Max;
        }

        public static double LiczTr(double Id, double pmax, double pk)
        {
            return Id / (pmax - pk);
        }

        public static double RegresjaLiniowa(WyborRegresja ahCzyTq, double[] tr, double[] delta)
        {
            double ah = 0;

            //liczenie srednich
            //liczenie x
            double jedenPrzezDeltaSrednia = 0;
            for (int i = 0; i < delta.Length; i++)
            {
                jedenPrzezDeltaSrednia += (1 / delta[i]);
            }
            jedenPrzezDeltaSrednia = jedenPrzezDeltaSrednia / delta.Length;
            //liczenie y
            double jedenPrzezTrSrednia = 0;
            for (int i = 0; i < tr.Length; i++)
            {
                jedenPrzezTrSrednia += (1 / tr[i]);
            }
            jedenPrzezTrSrednia = jedenPrzezTrSrednia / tr.Length;


            //liczenie ah(a)
            double licznik = 0;
            for (int i = 0; i < delta.Length; i++)
            {
                licznik += (((1 / delta[i]) - jedenPrzezDeltaSrednia) * ((1 / tr[i]) - jedenPrzezTrSrednia));
            }
            double mianownik = 0;
            for (int i = 0; i < delta.Length; i++)
            {
                mianownik += (Math.Pow((1 / delta[i]) - jedenPrzezDeltaSrednia, 2));
            }
            ah = licznik / mianownik;

            //liczenie 1/tq (b)
            double jedenPrzezTq = jedenPrzezTrSrednia - (ah * jedenPrzezDeltaSrednia);
            //liczenie tq
            double tq = 1 / jedenPrzezTq;
            if (ahCzyTq == WyborRegresja.a)
                return ah;
            else
                return tq;
        }
        public static double LiczTh(double delta, double ah)
        {
            return delta / ah;
        }
        public static double[] ZmianaWartosciDoWykresu(WyborOsi osXczyOsY, double[] tablicaDanych)
        {
            if (osXczyOsY == WyborOsi.osX)
            {
                double[] wyjscioweDaneOsX = new double[tablicaDanych.Length];
                for (int i = 0; i < tablicaDanych.Length; i++)
                {
                    wyjscioweDaneOsX[i] = tablicaDanych[i] * 1000;
                }
                return wyjscioweDaneOsX;
            }
            else
            {
                double[] wyjscioweDaneOsY = new double[tablicaDanych.Length];
                for (int i = 0; i < tablicaDanych.Length; i++)
                {
                    wyjscioweDaneOsY[i] = tablicaDanych[i] * zamianaPaNaMpa;
                }
                return wyjscioweDaneOsY;
            }

        }
        public static double[] KorekcjaKrzywejCisnienia(double[] wartoscCisnienia, double[] okresProbkowania, double tr)
        {
            double[] skorygowanaWartoscCisnienia = new double[wartoscCisnienia.Length];
            for (int i = 0; i < wartoscCisnienia.Length; i++)
            {
                double calka = LiczCalkeMetodaProstokatow(0, i, okresProbkowania, wartoscCisnienia);
                skorygowanaWartoscCisnienia[i] = ((1/tr) * calka);

                skorygowanaWartoscCisnienia[i] += wartoscCisnienia[i];
            }

            return skorygowanaWartoscCisnienia;
        }
        public static double RegresjaLiniowa2(WyborRegresja aCzyB, double[] pmPrzezDelta, double[] x)
        {
            double alfa = 0;

            //liczenie srednich
            //liczenie x
            double pmSrednia = 0;
            for (int i = 0; i < x.Length; i++)
            {
                pmSrednia += x[i];
            }
            pmSrednia = pmSrednia / x.Length;
            //liczenie y
            double pmPrzezDeltaSrednia = 0;
            for (int i = 0; i < pmPrzezDelta.Length; i++)
            {
                pmPrzezDeltaSrednia += pmPrzezDelta[i];
            }
            pmPrzezDeltaSrednia = pmPrzezDeltaSrednia / pmPrzezDelta.Length;

            //liczenie alfa (a)
            double licznik = 0;
            for (int i = 0; i < x.Length; i++)
            {
                licznik += ((x[i]) - pmSrednia) * (pmPrzezDelta[i] - pmPrzezDeltaSrednia);
            }
            double mianownik = 0;
            for (int i = 0; i < x.Length; i++)
            {
               mianownik += (Math.Pow((x[i]) - pmSrednia, 2));
            }
            alfa = licznik / mianownik;

            //liczenie f (b)
            double f = pmPrzezDeltaSrednia - (alfa * pmSrednia);

            if (aCzyB == WyborRegresja.a)
                return alfa;
            else
                return f;
        }
        public static double LiczU1(double[] daneWsadowe, double[] osX, double e1)
        {
            int indexMax= Array.IndexOf(daneWsadowe, Funkcja.Maximum(daneWsadowe));
            double calka = LiczCalkeMetodaProstokatow(0, indexMax, osX, daneWsadowe);
            double u1=e1/calka;
            
            return u1;
        }
        public static double SredniaU1(double[] tablicaU1)
        {
            double u1Srednia = 0;
            for (int i = 0; i < tablicaU1.Length; i++)
            {
                u1Srednia += tablicaU1[i];
            }
            return u1Srednia = u1Srednia / tablicaU1.Length;
        }
    }
}
