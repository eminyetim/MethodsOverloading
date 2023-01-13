using System;

namespace MethodsOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi , out outSayi);

            if(!sonuc)
                System.Console.WriteLine("true");
            else
                System.Console.WriteLine("false");

            Methodlar obj = new Methodlar();
            obj.Topla(2 , 3 , out int top);
            System.Console.WriteLine("Toplam :"+top);


            int a = 4;
            string b = "ar";

            Methodlar mt = new Methodlar();
            mt.EkranaYazdir(a);
            mt.EkranaYazdir(b);
            
            string x = "merhaba";
            string y = "dünya";

            mt.EkranaYazdir(a,b);
        }
    }

    class Methodlar
    {
        public void Topla(int a , int b , out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string a)
        {
            System.Console.WriteLine("String :"+a);
        }

        public void EkranaYazdir(int a)
        {
            System.Console.WriteLine("Int :"+a);
        }

        public void EkranaYazdir(string a , string b)
        {
            System.Console.WriteLine(a + b);
        }
    }
}