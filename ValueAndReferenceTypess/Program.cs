namespace ValueAndReferenceTypess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int,bool,double,char,enum,datetime -> değer tip
            //string,array,class,interface,abstract -> referans tip

            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number1 + "-" + number2);
            SayiyiGuncelle(number1);
            Console.WriteLine(number1);

            string[] cities1 = { "Ankara", "Adana", "Afyon" };
            string[] cities2 = { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities1; //Ankara,Adana,Afyon
            cities1[0] = "İstanbul";
            Console.WriteLine($"{cities1[0]}-{cities2[0]}");
            
            
             Sehir sehir = new Sehir(34, "İstanbul");

            SehriGuncelle(sehir);
            Console.WriteLine(sehir.Adi);
        }
        
        static void SayiyiGuncelle(int sayi)
        {
            sayi = 17;
        }

        static void SehriGuncelle(Sehir sehir)
        {
            sehir.PlakaNo = 67;
            sehir.Adi = "Zonguldaq";
        }
        class Sehir
        {
            public int PlakaNo { get; set; }
            public string Adi { get; set; }

            public Sehir(int plakaNo, string adi)
            {
                PlakaNo = plakaNo;
                Adi = adi;
            }
        }
    }
}