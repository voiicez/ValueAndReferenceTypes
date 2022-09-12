namespace ReferenceParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Mars!");
            Console.WriteLine(SayiTopla(23.5,123));
            double carpim = 0;
            double toplam = ToplaVeCarp(4, 5, ref carpim);
            Console.WriteLine(carpim);

            Console.WriteLine("Sayı: ");
            string sayi = Console.ReadLine();
            int donusturelecek;
            bool donusturmeSonucu = int.TryParse(sayi, out donusturelecek);
            if (donusturmeSonucu)
                Console.WriteLine("Başarılı: " + donusturelecek);
            else
                Console.WriteLine("Başarısız");

        }
        static double SayiTopla(double sayi1,double sayi2)
        {
            return sayi1 + sayi2;
        }
        static double ToplaVeCarp(double sayi1,double sayi2,ref double carpim)
        {
            carpim = sayi1 * sayi2;
            return sayi1 + sayi2;
        }
        static double CikartVeBol(double sayi1,double sayi2,out double bolum)
        {
            bolum = sayi1 / sayi2;
            return sayi1 - sayi2;
        }
    }
}