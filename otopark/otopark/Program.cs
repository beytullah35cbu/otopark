using System;

namespace otopark
{
    // Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
    // Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
    // İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("araba turu gır otomobil kamyon iş makınesı (1/2/3)");
            int aracturu = int.Parse(Console.ReadLine());


            Console.WriteLine("ne kadar kalcn");
            double kullanımsuresı = Convert.ToDouble(Console.ReadLine());



            double ucret;

            switch (aracturu)
            {
                case 1:
                    if (kullanımsuresı <=2)
                    {
                        ucret = 5;

                    }
                    else if (kullanımsuresı<=10)
                    {
                        ucret = 5 + (kullanımsuresı - 2) * 1; 

                    }
                    else
                    {
                        ucret = 5 + 8; //10saat sonrası sabıt ucret dıyor yanı 2 saat 5se 8saat 8tl
                    }

                    break;

                case 2:
                    if (kullanımsuresı <= 2)
                    {
                        ucret = 8;

                    }
                    else if (kullanımsuresı <= 10)
                    {
                        ucret = 8 + (kullanımsuresı - 2) * 2;

                    }
                    else
                    {                   //dıkkat sabıt ucret saat bası 2tl
                        ucret = 8 + 12; //8saat sonrası sabıt ucret dıyor yanı 2 saat 8se 6saat 12 yapar 
                    }

                    break;


                case 3:
                    if (kullanımsuresı <= 2)
                    {
                        ucret = 12;

                    }
                    else if (kullanımsuresı <= 10)
                    {
                        ucret = 12 + (kullanımsuresı - 2) * 3;

                    }   
                    else
                    {               //dıkkat saat bası 3tl
                        ucret = 12 + 18; //hemen matematık *_*
                                          //2 saat 12 ise 8 saat soruyor 6 * 3 = 18 olur
                    }

                    break;

                default:
                    Console.Write("hatalı deger gırdın");

                    return;


            }



            Console.Write("ucretiniz  " + ucret);

            Console.ReadKey();           
        }
    }
}
