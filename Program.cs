using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string exmp");
            string name1 = "Onur";
            string name2 = "ali";
            string surname = "kopuz";
            string fullname = name1 + " " + name2 + " " + surname;
             
            Console.WriteLine(fullname);

            ///
             Console.WriteLine("int, bool exmp");

             int sayi1 = 5;
             int sayi2 = 6;
             int toplam = sayi1 + sayi2;
             bool cevap = sayi1+sayi2 == 3;

             Console.WriteLine("sayi toplama" +" "+toplam);
             Console.WriteLine("cevap 3 mü" +" "+ cevap);
             


             //
              Console.WriteLine("date exmp");

             string tarih = DateTime.Now.ToString("dd.MM.yyyy");  
            Console.WriteLine(tarih);





        }
    }
}