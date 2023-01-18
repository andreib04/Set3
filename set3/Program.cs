using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace set3
{
    internal class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Scrieti numarul problemei: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) P01();
            if (n == 2) P02();
            if (n == 3) P03();
            if (n == 4) P04();
            if (n == 5) P05();
            if (n == 6) P06();
            if (n == 7) P07();
            if (n == 8) P08();
            if (n == 9) P09();
            if (n == 10) P10();
            if (n == 11) P11();
            if (n == 12) P12();
            if (n == 13) P13();
            if (n == 14) P14();
            if (n == 15) P15();
            if (n == 16) P16();
            if (n == 17) P17();
            if (n == 18) P18();
            if (n == 19) P19();
            if (n == 20) P20();
            if (n == 21) P21();
            if (n == 22) P22();
            if (n == 23) P23();
            if (n == 25) P25();
            if (n == 28) P28();
            if (n == 29) P29();

        }

        private static void P01()
        {
            Console.WriteLine("Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului pe aceeasi linie, separate printr-un spatiu!");
            int[] v = new int[n];

            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                suma += v[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este = {suma}");
        }

        private static void P02()
        {
            Console.WriteLine("Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. ");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului pe aceeasi linie, separate printr-un spatiu!");
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Introduceti numarul din vector caruia doriti sa-i aflati pozitia = ");
            int k = int.Parse(Console.ReadLine());
            int pos = 0;
            for (int i = 0; i < n; i++)
            {
                if (k == v[i])
                    pos = i;
            }
            if (pos == 0)
                Console.WriteLine("-1 (numarul nu se afla in vector)");
            else
                Console.WriteLine($"Numarul {k} este pe pozitia {pos}!");

        }

        private static void P03()
        {
            Console.WriteLine("Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). ");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului pe aceeasi linie, separate printr-un spatiu!");
            int[] v = new int[n];


            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int max = v[0];
            int min = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] > max)
                    max = v[i];
                if (v[i] < min)
                    min = v[i];
            }
            int posMin = 0;
            int posMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (max == v[i])
                    posMax = i;
                if (min == v[i])
                    posMin = i;
            }
            Console.WriteLine($"Cel mai mare element din vector este pe pozitia {posMax}, " +
                $"cel mai mic element din vector este pe pozitia {posMin}");

        }

        private static void P04()
        {
            Console.WriteLine("Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ");
            Console.Write("Cate elemete doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului, fiecare element pe alt rand: " +
                "");
            int[] v = new int[n];

            int c1 = 1;
            int c2 = 1;
            v[0] = int.Parse(Console.ReadLine());
            int max = v[0];
            int min = v[0];
            int i;
            for (i = 1; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] < min)
                {
                    min = v[i];
                    c1 = 1;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    c2 = 1;
                }
                if (v[i] == min)
                    c1++;
                if (v[i] == max)
                    c2++;
            }
            if (v[0] == max)
                c2++;
            if (v[0] == min)
                c1++;
            Console.WriteLine($"Cea mai mare valoare este {max} si apare de {c2 - 1} ori, cea mai mica este {min} si apare de {c1 - 1} ori!");
        }

        private static void P05()
        {
            Console.WriteLine("Se da un vector cu n elemente, o valoare e si o pozitie din vector k.Se cere sa se insereze valoarea e in vector pe pozitia k.Primul element al vectorului se considera pe pozitia zero. ");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului, fiecare pe alt rand: ");
            int[] v = new int[n + 1];
            int val, k;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti valoarea pe care doriti sa o inserati = ");
            val = int.Parse(Console.ReadLine());
            Console.Write("Introduceti pozitia pe care sa se insereze = ");
            k = int.Parse(Console.ReadLine());

            for (int i = n; i >= k; i--)
            {
                v[i] = v[i - 1];
            }

            v[k] = val;
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void P06()
        {
            Console.WriteLine("Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. ");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului, fiecare pe alt rand: ");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Dati pozitia = ");
            int k = int.Parse(Console.ReadLine());

            for (int i = k; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        private static void P07()
        {
            Console.WriteLine("Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele, fiecare pe alt rand: ");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int aux = 0;

            for (int i = 0; i < n / 2; i++)
            {
                aux = v[i];
                v[i] = v[n - 1 - i];
                v[n - 1 - i] = aux;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();

        }

        private static void P08()
        {
            Console.WriteLine("Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele, fiecare pe alt rand: ");
            int[] v = new int[n];

            int aux = 0;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            aux = v[0];
            for (int i = 0; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            v[n - 1] = aux;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{v[i]} ");
            }
            Console.WriteLine();

        }

        private static void P09()
        {
            Console.WriteLine("Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. ");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele, fiecare pe alt rand: ");
            int[] v = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Dati k = ");
            int k = int.Parse(Console.ReadLine());
            int aux = 0;
            for (int j = 0; j < k; j++)
            {
                aux = v[0];
                for (i = 0; i < n - 1; i++)
                {
                    v[i] = v[i + 1];
                }
                v[n - 1] = aux;
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void P10()
        {
            Console.WriteLine("Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ");
            Console.Write("Cate elemente doriti sa aiba vectorul = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele, fiecare pe alt rand: ");
            int[] v = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Introduceti k = ");
            int k = int.Parse(Console.ReadLine());
            int pos = binarysearch(v, k);
            if (pos != -1)
                Console.WriteLine($"Elementul {k} este pe pozitia {pos}");
            else
                Console.WriteLine("-1(elementul nu este in vector)");


        }

        private static int binarysearch(int[] v, int k)
        {
            int stg, dr, mij;
            stg = 0;
            dr = v.Length - 1;
            while (stg <= dr)
            {
                mij = (stg + dr) / 2;
                if (v[mij] < k)
                    stg = mij + 1;
                else if (v[mij] > k)
                    dr = mij - 1;
                else
                    return mij;
            }
            return -1;
        }

        private static void P11()
        {
            Console.WriteLine("Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ");
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            bool[] v = new bool[n];

            int index = 2;
            Console.Write("2" + " ");
            do
            {
                int k = 1;
                while (index * k < n)
                {
                    v[index * k] = true;
                    k++;
                }
                while (v[index]) index++;
                Console.Write(index + " ");
            }
            while (index < n - 1);
        }

        private static void P12()
        {
            Console.WriteLine("Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. ");
            Console.Write("Cat de lung sa fie vectorul = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int k = 0, aux = 0;

            Console.WriteLine("Introduceti elementele vectorului, fiecare pe alt rand: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectorul sortat: ");

            for (int i = 0; i < v.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[j] < v[k])
                        k = j;
                }
                aux = v[i]; v[i] = v[k]; v[k] = aux;
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void P13()
        {
            Console.WriteLine("Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. ");
            Console.Write("Cat de lung sa fie vectorul = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului, fiecare pe alt rand: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            insertionSort(v);
            Console.WriteLine("Vectorul sortat: ");
            print(v);
        }

        public static void print(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        public static void insertionSort(int[] v)
        {
            int aux;
            for (int i = 1; i < v.Length; i++)
            {
                for (int k = i; k > 0 && v[k] < v[k - 1]; k--)
                {
                    aux = v[k]; v[k] = v[k - 1]; v[k - 1] = aux;
                }
            }

        }

        private static void P14()
        {
            Console.Write("Cat de lung sa fie vectorul = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];


            Console.WriteLine("Introduceti elementele vectorului, fiecare pe alt rand: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < n; i++)
                if (v[i] != 0)
                    v[count++] = v[i];

            while (count < n)
                v[count++] = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        private static void P15()
        {
            Console.WriteLine("Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");
            Console.Write("Cat de lung sa fie vectorul = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);

            int k = n - 1;
            for (int i = 1; i <= k; i++)
            {
                bool ok = false;
                for (int j = 0; j <= k; j++)
                {
                    if (v[i] == v[j])
                    {
                        ok = true;
                        break;
                    }
                }
                if (ok)
                {
                    int aux = v[i];
                    v[i] = v[k];
                    v[k] = aux;
                    k--;
                    i--;
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void P16()
        {
            Console.WriteLine("Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
            Console.Write("Cat de lung sa fie vectorul = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int cmmdc = v[1];
            for (int i = 1; i < n; i++)
            {
                int vcopy = v[i];
                while (vcopy != cmmdc)
                {
                    if (vcopy > cmmdc)
                        vcopy = vcopy - cmmdc;
                    else
                        cmmdc = cmmdc - vcopy;
                }
            }
            Console.WriteLine(cmmdc);
        }

        private static void P17()
        {
            Console.WriteLine("Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
            Console.WriteLine("Introduceti numarul in baza 10!");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Baza in care se converteste = ");
            int baza = int.Parse(Console.ReadLine());

            int conv = 0;
            string rez = "";

            while (n >= baza)
            {
                conv = n % baza;
                n = n / baza;

                if (conv < 10)
                    rez = conv.ToString() + rez;
                else
                    rez = Convert.ToChar(conv + 55).ToString() + rez;
            }

            if (n < 10)
                rez = n.ToString() + rez;
            else
                rez = Convert.ToChar(n + 55).ToString() + rez;

            Console.WriteLine(rez);
        }

        private static void P18()
        {
            Console.WriteLine("Se da un polinom de grad n ai carui coeficienti sunt stocati intr - un vector.Cel mai putin semnificativ coeficient este pe pozitia zero in vector.Se cere valoarea polinomului intr - un punct x.");
            Console.Write("Dati n = ");
            int n = int.Parse(Console.ReadLine());
            double[] p = new double[n];
            string[] t = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                p[i] = double.Parse(t[i]);

            Console.Write("Dati punctul x = ");
            double x = double.Parse(Console.ReadLine());

            Console.Write(val(p, x).ToString());
            Console.WriteLine();
        }

        public static double val(double[] p, double x)
        {
            double tor = 0;
            for (int i = 0; i < p.Length; i++)
                tor += p[i] * Math.Pow(x, i);
            return tor;
        }

        private static void P19()
        {
            Console.WriteLine("Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).");
            Console.WriteLine("Dimensiunea primului vector: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti primul vector, toate numerele pe acelasi rand");
            int[] v1 = new int[n];
            string[] t1 = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(t1[i]);
            }

            Console.WriteLine("Dimensiunea vectorului al doilea: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea vector, toate numerele pe acelasi rand");
            int[] v2 = new int[m];
            string[] t2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < m; i++)
            {
                v2[i] = int.Parse(t2[i]);
            }

            int count = 0;
            bool ok = false;
            for (int i = 0; i < v1.Length - v2.Length + 1; i++)
            {
                if (v1[i] == v2[0])
                {
                    ok = true;
                    for (int j = 1; j < v2.Length; j++)
                        if (v2[j] != v1[i + j])
                            ok = false;
                    if (ok)
                        count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void P20()
        {
            Console.WriteLine("Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. ");
            Console.WriteLine("Dimensiunea primului vector: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti primul vector, toate numerele pe acelasi rand");
            int[] v1 = new int[n];
            string[] t1 = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                v1[i] = int.Parse(t1[i]);

            Console.WriteLine("Dimensiunea vectorului al doilea: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea vector, toate numerele pe acelasi rand");
            int[] v2 = new int[m];
            string[] t2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < m; i++)
                v2[i] = int.Parse(t2[i]);

            int max = 0;
            int suma;
            for (int i = 0; i < v1.Length; i++)
            {
                suma = 0;
                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[(i + j) % v1.Length] == v2[j])
                        suma++;
                }
                if (suma > max)
                    max = suma;
            }
            Console.WriteLine(max);
        }

        private static void P21()
        {
            Console.WriteLine("Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). ");
            Console.WriteLine("Dimensiunea primului vector");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti primul vector, toate numerele pe acelasi rand");
            int[] v1 = new int[n];
            string[] t1 = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                v1[i] = int.Parse(t1[i]);

            Console.WriteLine("Dimensiunea vectorului al doilea: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea vector, toate numerele pe acelasi rand");
            int[] v2 = new int[m];
            string[] t2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < m; i++)
                v2[i] = int.Parse(t2[i]);

            Console.WriteLine(check(v1, v2));
        }

        static int check(int[] v1, int[] v2)
        {
            int min = v1.Length;
            if (v2.Length < min)
                min = v2.Length;
            for (int i = 0; i < min; i++)
            {
                if (v1[i] != v2[i])
                {
                    if (v1[i] > v2[i])
                        return 1;
                    else
                        return -1;
                }
            }
            if (v1.Length == min && v2.Length == min)
                return 0;
            if (v1.Length == min)
                return -1;
            if (v2.Length == min)
                return 1;
            return 0;
        }

        private static void P22()
        {
            Console.WriteLine("Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. ");
            Console.WriteLine("Dimensiunea primului vector: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului 1, toate pe acelasi rand");
            int[] v = new int[n];
            string[] t1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t1[i]);

            Console.WriteLine("Dimensiunea celui de-al doilea vector: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului 2, toate pe acelasi rand");
            int[] v2 = new int[m];
            string[] t2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
                v2[j] = int.Parse(t2[j]);

            ///intersectia 
            int[] inter = new int[1001];
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (v[i] == v2[j])
                    {
                        inter[x] = v[i];
                        x++;
                        break;
                    }

                }
            }
            Console.Write("Intersectia = {");
            for (int i = 0; i < x; i++)
                Console.Write($"{inter[i]}, ");
            Console.WriteLine("}");

            ///diferenta v1-v2
            int[] dif = new int[1001];
            int x1 = 0;

            for (int i = 0; i < n; i++)
            {
                bool ok1 = true;
                for (int j = 0; j < m; j++)
                {
                    if (v[i] == v2[j])
                    {
                        ok1 = false;
                    }
                }
                if (ok1 == true)
                {
                    dif[x1] = v[i];
                    x1++;
                }
            }

            Console.Write("Diferenta = {");
            for (int i = 0; i < x1; i++)
                Console.Write(dif[i] + " ");
            Console.WriteLine("}");
            ///diferenta v2-v1
            int[] dif2 = new int[1001];
            int x2 = 0;

            for (int i = 0; i < n; i++)
            {
                bool ok2 = true;
                for (int j = 0; j < m; j++)
                {
                    if (v2[j] == v[i])
                    {
                        ok2 = false;
                    }
                    if (ok2 == true)
                    {
                        dif[x2] = v2[j];
                        x2++;
                    }
                }

            }

            Console.Write("Diferenta 2 = {");
            for (int i = 0; i < x2; i++)
                Console.Write(dif2[i] + " ");
            Console.WriteLine("}");

            ///reuniunea
            int[] reu = new int[1001];
            int x3 = 0;
            for (int i = 0; i < n; i++)
            {
                dif[x3] = v[i];
                x3++;
            }

            for (int i = 0; i < n; i++)
            {
                bool ok3 = false;
                for (int j = 0; j < m; j++)
                {
                    if (v[i] == v2[j])
                    {
                        ok3 = true;
                        break;
                    }
                }
                if (ok3 == false)
                {
                    reu[x3] = v[i];
                    x3++;
                }
            }
            Console.Write("Reuniunea = {");
            for (int i = 0; i < x3; i++)
                Console.Write(reu[i] + " ");
            Console.WriteLine("}");

            Console.ReadKey();
        }

        private static void P23()
        {
            Console.WriteLine("Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. ");
            Console.WriteLine("Dimensiunea primului vector: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului 1, toate pe acelasi rand");
            int[] v = new int[n];
            string[] t1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t1[i]);

            Console.WriteLine("Dimensiunea celui de-al doilea vector: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului 2, toate pe acelasi rand");
            int[] v2 = new int[m];
            string[] t2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
                v2[j] = int.Parse(t2[j]);

            ///intersectia 
            int[] inter = new int[1001];
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (v[i] == v2[j])
                    {
                        inter[x] = v[i];
                        x++;
                        break;
                    }

                }
            }
            Console.Write("Intersectia = {");
            for (int i = 0; i < x; i++)
                Console.Write($"{inter[i]}, ");
            Console.WriteLine("}");

            ///diferenta v1-v2
            int[] dif = new int[1001];
            int x1 = 0;

            for (int i = 0; i < n; i++)
            {
                bool ok1 = true;
                for (int j = 0; j < m; j++)
                {
                    if (v[i] == v2[j])
                    {
                        ok1 = false;
                    }
                }
                if (ok1 == true)
                {
                    dif[x1] = v[i];
                    x1++;
                }
            }

            Console.Write("Diferenta = {");
            for (int i = 0; i < x1; i++)
                Console.Write(dif[i] + " ");
            Console.WriteLine("}");
            ///diferenta v2-v1
            int[] dif2 = new int[1001];
            int x2 = 0;

            for (int i = 0; i < n; i++)
            {
                bool ok2 = true;
                for (int j = 0; j < m; j++)
                {
                    if (v2[j] == v[i])
                    {
                        ok2 = false;
                    }
                    if (ok2 == true)
                    {
                        dif[x2] = v2[j];
                        x2++;
                    }
                }

            }

            Console.Write("Diferenta 2 = {");
            for (int i = 0; i < x2; i++)
                Console.Write(dif2[i] + " ");
            Console.WriteLine("}");

            ///reuniunea
            int[] reu = new int[1001];
            int x3 = 0;
            for (int i = 0; i < n; i++)
            {
                dif[x3] = v[i];
                x3++;
            }

            for (int i = 0; i < n; i++)
            {
                bool ok3 = false;
                for (int j = 0; j < m; j++)
                {
                    if (v[i] == v2[j])
                    {
                        ok3 = true;
                        break;
                    }
                }
                if (ok3 == false)
                {
                    reu[x3] = v[i];
                    x3++;
                }
            }
            Console.Write("Reuniunea = {");
            for (int i = 0; i < x3; i++)
                Console.Write(reu[i] + " ");
            Console.WriteLine("}");

            Console.ReadKey();
        }

        private static void P25()
        {
            Console.WriteLine("(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.");
            Console.WriteLine("Dimensiunea primului vector = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului, toate pe acelasi rand:");
            int[] v1 = new int[n];
            string[] t1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Dimensiunea celui de-al doilea vector = ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului, toate pe acelasi rand:");
            int[] v2 = new int[m];
            string[] t2 = Console.ReadLine().Split(' ');

            int i = 0, j = 0;

            for (i = 0; i < n; i++)
                v1[i] = int.Parse(t1[i]);
            for (j = 0; j < m; j++)
                v2[j] = int.Parse(t2[j]);


            int[] T = new int[n * m];
            int x = 0;
            while (i < n && j < m)
            {
                if (v1[i] < v2[j])
                {
                    T[x] = v1[i];
                    x++;
                    i++;
                }
                else
                {
                    T[x] = v2[j];
                    x++;
                    j++;
                }
            }

            if (i <= n)
            {
                for (int k = i; k < n; k++)
                {
                    T[x] = v1[k];
                    x++;
                }
            }
            if (j <= m)
            {
                for (int k = j; k < m; k++)
                {
                    T[x] = v2[k];
                    x++;
                }
            }

            for (int k = 0; k < x; k++)
                Console.Write(T[k] + " ");
        }

        private static void P28()
        {
            Console.WriteLine("QuickSort. Sortati un vector folosind QuickSort");
            Console.WriteLine("Dimensiunea vectorului ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului, fiecare pe alt rand");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            QuickSort(v);
            print(v);
        }

        private static void QuickSort(int[] v)
        {
            QuickSort(v, 0, v.Length - 1);
        }
        private static void QuickSort(int[] v, int lo, int hi)
        {
            if (lo < hi)
            {
                int index;
                index = rnd.Next(lo, hi + 1);
                (v[lo], v[index]) = (v[index], v[lo]);
                int k = lo;
                for (int i = lo + 1; i <= hi; i++)
                    if (v[i] < v[lo])
                    {
                        k++;
                        (v[k], v[i]) = (v[i], v[k]);
                    }
                (v[lo], v[k]) = (v[k], v[lo]);

                QuickSort(v, lo, k - 1);
                QuickSort(v, k + 1, hi);
            }
        }

        private static void P29()
        {
            Console.WriteLine("MergeSort. Sortati un vector folosind metoda MergeSort.");
            Console.WriteLine("Dimensiunea vectorului ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului, fiecare pe alt rand");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            MergeSort(v);
            print(v);
        }

        private static void MergeSort(int[] v)
        {
            MergeSort(v, 0, v.Length - 1);
        }
        private static void MergeSort(int[] v, int lo, int hi)
        {
            if (lo < hi)
            {
                int mid;
                mid = lo + (hi - lo) / 2;

                MergeSort(v, lo, mid);
                MergeSort(v, mid + 1, hi);

                int[] left = new int[mid - lo + 1];
                int i;
                for (i = lo; i <= mid; i++)
                {
                    left[i - lo] = v[i];
                }
                int[] right = new int[hi - mid];
                for (i = mid + 1; i <= hi; i++)
                {
                    right[i - (mid + 1)] = v[i];
                }

                int j = 0, k = lo;
                i = 0;
                while (i < left.Length && j < right.Length)
                {
                    if (left[i] < right[j])
                        v[k++] = left[i++];
                    else
                        v[k++] = right[j++];
                }
                while (i < left.Length)
                {
                    v[k++] = left[i++];
                }
                while (j < right.Length)
                {
                    v[k++] = right[j++];
                }
            }
        }
    }
     
}
