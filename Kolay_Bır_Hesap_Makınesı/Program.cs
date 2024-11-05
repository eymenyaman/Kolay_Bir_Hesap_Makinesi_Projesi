namespace Kolay_Bır_Hesap_Makınesı
{
    internal class Program
    {
        static void Main(string[] args)
        {


        ANAMENU:
            Console.WriteLine("1 Sayıyı Giriniz");
            double sayı1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 Sayıyı Giriniz");
            double sayı2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin +,-,*");
            string ifadeler = Console.ReadLine();

            double sonuc;


            switch (ifadeler)
            {
                case "+":
                    Console.WriteLine("İşlem Sonu Sonuç");
                    Console.WriteLine(sayı1 + sayı2);
                    Console.WriteLine("0 Tıklarsan Eğer Ana Menüye Atıcak");
                    Console.WriteLine("1 Tıklarsan Çıkış Yapılacak");
                    int çıkışartı = Convert.ToInt32(Console.ReadLine());



                    if (çıkışartı == 0)
                    {

                        Console.WriteLine("3 Saniye Sonrası Sizi Ana Menüye Atacak");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto ANAMENU;
                    }
                    else if (çıkışartı == 1)
                    {
                        Console.WriteLine("Çıkış Başarılı 3 Saniye Sonra Çıkış Yapılacak");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("İyi Günler :)");
                    }
                    break;


                case "-":
                    Console.WriteLine("İşlem Sonu Sonuç");
                    Console.WriteLine(sayı1 - sayı2);
                    Console.WriteLine("0 Tıklarsan Eğer Ana Menüye Atıcak");
                    Console.WriteLine("1 Tıklarsan Çıkış Yapılacak");
                    int çıkışeksi = Convert.ToInt32(Console.ReadLine());

                    if (çıkışeksi == 0)
                    {
                        Console.WriteLine("3 Saniye Sonrası Sizi Ana Menüye Atacak");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto ANAMENU;
                    }
                    else if (çıkışeksi == 1)
                    {
                        Console.WriteLine("Çıkış Başarılı 3 Saniye Sonra Çıkış Yapılacak");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("İyi Günler :)");
                    }
                    break;


                case "*":
                    Console.WriteLine("İşlem Sonu Sonuç");
                    Console.WriteLine(sayı1 * sayı2);
                    Console.WriteLine("0 Tıklarsan Eğer Ana Menüye Atıcak");
                    Console.WriteLine("1 Tıklarsan Çıkış Yapılacak");
                    int çıkışçarpma = Convert.ToInt32(Console.ReadLine());

                    if (çıkışçarpma == 0)
                    {
                        Console.WriteLine("3 Saniye Sonrası Sizi Ana Menüye Atacak");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto ANAMENU;
                    }
                    else if (çıkışçarpma == 1)
                    {
                        Console.WriteLine("Çıkış Başarılı 3 Saniye Sonra Çıkış Yapılacak");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("İyi Günler :)");
                    }
                    break;



                default:
                    Console.WriteLine("Geçersiz İşlem");
                    break;






            }


        }
    }
}
