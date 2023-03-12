using System;

namespace ConsoleApp4
{
    class Program
    {

        static int diziSonArtma()
        {

            int eleman;
            Console.WriteLine("Enter the number of array elements:");
            eleman = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[eleman];
            Console.WriteLine("Enter the number of array elements: ");

            for (int i = 0; i < eleman; i++)
            {

                A[i] = Convert.ToInt32(Console.ReadLine());

            }
            A[A.Length - 1] += 1;
            for (int i = 0; i < eleman; i++)
            {
                Console.Write("{0} ",A[i]);
            }

            Console.WriteLine("\n\n");
            return 0;
        }
        static int polinomKontrol()
        {
            int n, r, sum = 0, temp;
            Console.Write(" ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.Write("This number is Palindrom"); 
            }
            else 
            { 
                Console.Write("This number is not Palindrom");
            }
            return 0;
            
        }

        public virtual int sonKelime(string a)
        {
            int len = 0;

            string x = a.Trim();

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                {
                    len = 0;
                }
                else
                {
                    len++;
                }
            }

            return len;

        }

        


        static void Main(string[] args)
        {

            kisaSinav1:
            Console.WriteLine("1,2,3 islemler arasindaki seciniz :");
            Console.WriteLine("Soru (1)");
            Console.WriteLine("Soru (2)");
            Console.WriteLine("Soru (3)");

            string input = Console.ReadLine();
            Console.WriteLine(" ");
            switch (input)
            {
                
                case "1":
                    Console.WriteLine("1. Dizi Eleman Artirma\n");
                    diziSonArtma();
                    goto kisaSinav1;
                    break;
                case "2":
                    Console.WriteLine("2. Polinom Kontrol Etmek\n");
                    polinomKontrol();
                    Console.WriteLine(" \n\n\n");
                    goto kisaSinav1;
                    break;
                case "3":
                    Console.WriteLine("3. Son Kelime hesaplamak\n\nBi Kelime ya da bi string karakterle giriniz :");
                    string nama = Console.ReadLine();
                    Program coba = new Program();
                    Console.WriteLine("Son kelime " + coba.sonKelime(nama) + " tane var.\n");
                    goto kisaSinav1;
                    break;
                default:
                    Console.WriteLine("Maalesef, sadece 1, 2 veya 3 numarayı seçebilirsiniz. Bi daha deneyin\n\n");
                    goto kisaSinav1;
                    break;
            }
            
           
           
           
        }
    }
}

