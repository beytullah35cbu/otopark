using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
 

Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit


*/
namespace Otopark_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Araç türünü seçin (1: Otomobil, 2: Kamyon, 3: İş Makinası):");
        int aracTuru = int.Parse(Console.ReadLine());

        Console.WriteLine("Kaç saat kiralamak istersiniz?");
        int kiralamaSuresi = int.Parse(Console.ReadLine());

        double toplamUcret = 0;

        switch (aracTuru)
        {
            case 1: // Otomobil
                    //Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret
                    if (kiralamaSuresi <= 2)
                {
                    toplamUcret = 5;
                }
                else if (kiralamaSuresi <= 10)
                {
                    toplamUcret = 5 + (kiralamaSuresi - 2);
                }
                else
                {
                    toplamUcret = 5 + 8 + (kiralamaSuresi - 10);
                }
                break;

            case 2: // Kamyon
                    //Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
                    if (kiralamaSuresi <= 2)
                {
                    toplamUcret = 8;
                }
                else if (kiralamaSuresi <= 8)
                {
                    toplamUcret = 8 + 2 * (kiralamaSuresi - 2);
                }
                else
                {
                    toplamUcret = 8 + 2 * 6 + (kiralamaSuresi - 8);
                }
                break;

            case 3: // İş Makinası
                    //İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit
                    if (kiralamaSuresi <= 2)
                {
                    toplamUcret = 12;
                }
                else if (kiralamaSuresi <= 8)
                {
                    toplamUcret = 12 + 3 * (kiralamaSuresi - 2);
                }
                else
                {
                    toplamUcret = 12 + 3 * 6 + (kiralamaSuresi - 8);
                }
                break;

            default:
                Console.WriteLine("Geçersiz araç türü seçildi.");
                return;
        }

        Console.WriteLine($"Toplam kira ücreti: {toplamUcret} TL");
            Console.ReadKey();
        }
    }
}