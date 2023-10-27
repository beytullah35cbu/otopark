using System;

namespace otoparkodev
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Araç türünü seçin: (1: Otomobil, 2: Kamyon, 3: İş Makinası)");
            int aracTuru = int.Parse(Console.ReadLine());

            Console.Write("Araç kaç saat boyunca kullanılacak? ");
            double kullanmaSuresi = Convert.ToDouble(Console.ReadLine());

            double ucret;
            switch (aracTuru)
            {
                case 1: // Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
                    if (kullanmaSuresi <= 2)
                    {
                        ucret = 5;
                    }
                    else if (kullanmaSuresi <= 10)
                    {
                        ucret = 5 + (kullanmaSuresi - 2) * 1;
                    }
                    else
                    {
                        ucret = 5 + 8; // 10 saatten sonra sabit ücret
                    }
                    break;

                case 2: // Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
                    if (kullanmaSuresi <= 2)
                    {
                        ucret = 8;
                    }
                    else if (kullanmaSuresi <= 8)
                    {
                        ucret = 8 + (kullanmaSuresi - 2) * 2;
                    }
                    else
                    {
                        ucret = 8 + 12; // 8 saatten sonra sabit ücret
                    }
                    break;

                case 3: // İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit
                    if (kullanmaSuresi <= 2)
                    {
                        ucret = 12;
                    }
                    else if (kullanmaSuresi <= 8)
                    {
                        ucret = 12 + (kullanmaSuresi - 2) * 3;
                    }
                    else
                    {
                        ucret = 12 + 18 ; // 8 saatten sonra sabit ücret
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz araç türü!");
                    return;
            }

            Console.WriteLine($"Seçilen araç türü için saatlik ücret: {ucret} TL");
            Console.ReadKey(); // Programın kapanmasını engellemek için
        }
    }
}
