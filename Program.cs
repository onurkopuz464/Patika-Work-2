using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
          Works works = new Works();
            Console.WriteLine("Çalışmayı seçiniz ;");
            string type = Console.ReadLine();
            if(type == "1")
            { 
            works.WorkOne();
            
            }
            else if (type == "2")
            {
                works.WorkTwo();
            }
            else if(type == "3")
            {
                works.WorkThree();
            }



        }
       
        

    }
    class Works
    {
        public static UInt32 intRead()
        {

            UInt32 result = 0;
            while (result == 0)
            {


                if (!UInt32.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                }
            }

            return result;

        }
        public void WorkOne()
        {
            Console.WriteLine("Gireceğiniz sayı miktarını giriniz");
            ArrayList Asal = new ArrayList();
            ArrayList NotAsal = new ArrayList();
            UInt32 input = 0;
            UInt32 reply = intRead();
            for (int i = 0; i < reply; i++)
            {
                Console.WriteLine("Lütfen " + i + ". Sayıyı Giriniz");
                input = intRead();

                if (input % 2 == 0)
                { NotAsal.Add(input); }
                else
                { Asal.Add(input); }


            }
            Asal.Sort(); Asal.Reverse(); NotAsal.Sort(); NotAsal.Reverse();
            Console.WriteLine(Asal.Count + " Tane Asal sayı girdiniz.");
            Console.WriteLine("Asal girdiğiniz sayılar;");

            int ortalama = 0;
            for (int i = 0; i < Asal.Count; i++)
            {
                Console.Write(Asal[i] + " ");
                ortalama += Convert.ToInt32(Asal[i]);

            }
            Console.WriteLine("Asal girdiğiniz sayıların ortalaması ; " + (ortalama / Asal.Count));
            ortalama = 0;
            Console.WriteLine();

            Console.WriteLine(NotAsal.Count + " Tane Asal olmayan sayı girdiniz.");
            Console.WriteLine("Asal girmediğiniz sayılar;");
            for (int i = 0; i < NotAsal.Count; i++)
            {
                Console.Write(NotAsal[i] + " ");
                ortalama += Convert.ToInt32(NotAsal[i]);

            }
            Console.WriteLine("Asal olmayan girdiğiniz sayıların ortalaması ; " + (ortalama / NotAsal.Count));
            Console.ReadLine();
        }
        public void WorkTwo()
        {
            
            UInt32 input = 0;
            ArrayList liste = new ArrayList();
            ArrayList listeTwo = new ArrayList();

            Console.WriteLine("Lütfen 20 Adet Sayı Giriniz.");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Lütfen " + i + ". Sayıyı Giriniz ");
                input = intRead();
                liste.Add(input);
                listeTwo.Add(input);

            }
            liste.Sort();liste.Reverse();
            listeTwo.Sort();
            int ortalama = 0;
            for (int i = 0; i < 3; i++)
            {
                ortalama += Convert.ToInt32(liste[i]);
            }
            Console.WriteLine("Büyükten küçüğe sayıların ortalaması ; " + (ortalama / 3));
            int ortalamaTwo = 0;
            for (int i = 0; i < 3; i++)
            {
                ortalamaTwo += Convert.ToInt32(listeTwo[i]);
            }
            Console.WriteLine("Küçükten büyüğe sayıların ortalaması ; " + (ortalamaTwo / 3));
            Console.WriteLine("ortalamaların toplamı ; "+(ortalama / 3) + (ortalamaTwo / 3));
            Console.ReadLine();

        }
        public void WorkThree()
        {
            Console.Write("Bir cümle giriniz; ");
            string value = Console.ReadLine();
            string item = "aeıioöuü";

            int sayac = 0;
            for (int i = 0; i < value.Length; i++)
            {
                
                if (item.Contains(value[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine(value);
            Console.WriteLine("Sesli harf sayısı ; "+ sayac);
            Console.ReadLine();
        }

    }
    
}

