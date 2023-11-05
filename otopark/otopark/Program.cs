using System;

namespace otopark
{
    class Program
    {
        static void Main(string[] args)
        {


            // Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
            // Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
            // İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit
            Console.WriteLine("Araç türünü girin (Otomobil: 1, Kamyon: 2, İş Makinesi: 3):");
            int aracTuru = int.Parse(Console.ReadLine());

            Console.WriteLine("Kaldığınız süreyi saat cinsinden girin:");
            double kullanimSuresi = Convert.ToDouble(Console.ReadLine());

            double ucret = 0;

            switch (aracTuru)
            {
                case 1:
                    if (kullanimSuresi <= 2)
                    {
                        ucret = 5;
                    }
                    else if (kullanimSuresi <= 10)
                    {
                        ucret = 5 + (kullanimSuresi - 2) * 1;
                    }
                    else
                    {
                        int gun = (int)kullanimSuresi / 24; // tam gün
                        double kalanSaat = kullanimSuresi % 24; // 24 saatten fazla saati hesapla
                        ucret = 5 + 8 * gun + kalanSaat; //gunluk ucret 2 saat 5tl 8saat 8 tl kısacası sabıt ucret
                    }
                    break;

                case 2:
                    if (kullanimSuresi <= 2)
                    {
                        ucret = 8;
                    }
                    else if (kullanimSuresi <= 10)
                    {
                        ucret = 8 + (kullanimSuresi - 2) * 2;
                    }
                    else
                    {
                        int gun = (int)kullanimSuresi / 24; 
                        double kalanSaat = kullanimSuresi % 24; //dikkat 8saat sonra sabıt ucret ve saat bası 2tl
                        ucret = 8 + 12 * gun + kalanSaat; // 2 saati 8tl  6saati 12tl 
                    }
                    break;

                case 3:
                    if (kullanimSuresi <= 2)
                    {
                        ucret = 12;
                    }
                    else if (kullanimSuresi <= 10)
                    {
                        ucret = 12 + (kullanimSuresi - 2) * 3;
                    }
                    else
                    {
                        int gun = (int)kullanimSuresi / 24; 
                        double kalanSaat = kullanimSuresi % 24; //8saat sonra sabıt ucret 3tl
                        ucret = 12 + 18 * gun + kalanSaat; //2 saat 12 tl 6 saat 18
                    }
                    break;

                default:
                    Console.Write("Hatalı değer girdiniz.");
                    return;
            }

            Console.Write("Ücretiniz: " + ucret + " TL");
            Console.ReadKey();
        }
    }
}
