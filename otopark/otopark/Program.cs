using System;
using System.Runtime.ConstrainedExecution;

namespace otopark
{
    class Program
    {

       /* Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Araç türünü girin (Otomobil: 1, Kamyon: 2, İş Makinesi: 3):");
            int aracTuru = int.Parse(Console.ReadLine());

            Console.WriteLine("Kaldığınız süreyi saat cinsinden girin:");
            double kullanimSuresi = Convert.ToDouble(Console.ReadLine());

            double ucret;

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
                        int tamGun = (int)kullanimSuresi / 24; // Tam gün
                        double kalanSaat = kullanimSuresi % 24; // 24 saat mi
                        ucret = (tamGun * 13) + 5 + (kalanSaat - 2) * 1; // 2saat 5 tl 8saat 8tl topla sabıt ucret 13
                    }               //gun varsa sabıt ucretle carp  dogal olarak dıger gunun 2 saat ucretını ekle
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
                        int tamGun = (int)kullanimSuresi / 24;
                        double kalanSaat = kullanimSuresi % 24;
                        ucret = (tamGun * 20) + 8 + (kalanSaat - 2) * 2; // 2saat ıcın 8 6 saat ıcın 12
                    } //20 sabıt ucret
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
                        int tamGun = (int)kullanimSuresi / 24;
                        double kalanSaat = kullanimSuresi % 24;
                        ucret = (tamGun * 30) + 12 + (kalanSaat - 2) * 3; // 2 saat ıcın 12 6saat ıcın 18
                    }           //sabit ucret 30
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
