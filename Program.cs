using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dizi boyutunu giriniz: ");
        int b = Convert.ToInt32(Console.ReadLine());//Dizi boyutu degerinin girildigi kısım
        int[] dizi = new int[b];//Dizi ifadesi tanimlaniyor
        for (int i = 0; i < b; i++)//For dongusu sayesinde sürekli ReadLine yazmamıza gerek kalmıyor
        {
            Console.Write($"Dizinin {i + 1}. elemanını giriniz: " );
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Aranacak elemanı giriniz: ");
        int aranan = Convert.ToInt32(Console.ReadLine());//aranan olarak belirtilen degere bir deger verilmistir
        for (int i = 0; i < b; i++)
        {
            if (dizi[i] == aranan)//Eger dizide aranan deger varsa bu durum gerceklesir
            {
                Console.WriteLine($"Aranan eleman dizinin {i} indeksinde bulundu.");
                return;//return durumu gerceklesirse program biter
            }
        }
        Console.WriteLine("Aranan eleman dizide bulunamadı.");
    }
}

