using System;
using System.Threading.Tasks;

class HesapMakinesi
{
    static async Task Main()
    {
        await HesapMakinesiCalistir();
    }

    static async Task HesapMakinesiCalistir()
    {
        do
        {
            await HesapMakinesiIslemleri(); // Hesap makinesi işlemlerini gerçekleştir

            Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
        } while (Console.ReadLine().ToUpper() == "E");
    }

    static async Task HesapMakinesiIslemleri()
    {
        double sayi1, sayi2, sonuc = 0;
        string operatorSecim;

        ClearCalculator(); // Hesap makinesini temizle

        Console.WriteLine("İlk sayıyı girin:");
        sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı girin:");
        sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İşlemi seçin (+, -, *, /):");
        operatorSecim = Console.ReadLine();

        if (operatorSecim == "+")
        {
            sonuc = sayi1 + sayi2;
        }
        else if (operatorSecim == "-")
        {
            sonuc = sayi1 - sayi2;
        }
        else if (operatorSecim == "*")
        {
            sonuc = sayi1 * sayi2;
        }
        else if (operatorSecim == "/")
        {
            if (sayi2 != 0)
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Hata: Sıfıra bölme hatası!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz işlem seçimi!");
            return;
        }

        Console.WriteLine("Sonuç: " + sonuc);
    }

    static void ClearCalculator()
    {
        Console.Clear(); // Ekranı temizle
    }
}
