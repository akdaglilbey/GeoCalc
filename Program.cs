using System;
using System.Text;
using static System.Math;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string girdi;
        double olcum1;
        double olcum2;
        string kpn = @"
Program kapanıyor.";
        string eky = @"
Eksik veya yanlış tuşladınız.";

        Console.WriteLine(@"Bu program şekillerin çevrelerini, alanlarını, yüzey alanlarını veya hacimlerini
şekille ilgili bildiğiniz bazı özelliklerden yola çıkarak hesaplar. 
Seçmek istediğiniz seçeneğin başındaki numarayı tuşlayın.
Programın her aşamasında 0'ı tuşlayarak çıkabilirsiniz.
00'ı tuşlayarak önceki seçeneklere dönebilirsiniz.
Ondalık sayıları ifade etmek için virgül kullanın.
İlbey AKDAĞLI, 2026

3 Boyutlu Şekiller     2 Boyutlu Şekiller
==================     ==================
1 - Küp                5 - Üçgen  
2 - Silindir           6 - Kare 
3 - Koni               7 - Dikdörtgen 
4 - Küre               8 - Daire");

        while (true)
        {
            Console.Write(@"
>>> ");
            girdi = Console.ReadLine();
            if (girdi == "0")
            {
                Console.WriteLine(kpn);
                Environment.Exit(0);
            }
            else if (girdi == "00")
            {
            }
            else if (girdi == "1")
            {
                while (true)
                {
                    Console.Write(@"
Küpün bir kenarı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if (Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        Console.WriteLine("Küpün yüzey alanı = " + (Pow(olcum1, 2) * 6));
                        Console.WriteLine("Küpün hacmi = " + Pow(olcum1, 3));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                }

            }
            else if (girdi == "2")
            {
                while (true)
                {
                    Console.Write(@"
Silindirin yarıçapı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if (Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        while (true)
                        {
                            Console.Write("Silindirin yüksekliği = ");
                            girdi = Console.ReadLine();
                            if (girdi == "0")
                            {
                                Console.WriteLine(kpn);
                                Environment.Exit(0);
                            }
                            else if (girdi == "00")
                            {
                                break;
                            }
                            else if (Double.TryParse(girdi, out olcum2) && olcum2 > 0)
                            {
                                Console.WriteLine("Silindirin yüzey alanı = " + (2 * PI * Pow(olcum1, 2) + 2 * PI * olcum1 * olcum2));
                                Console.WriteLine("Silindirin hacmi = " + (PI * Pow(olcum1, 2) * olcum2));
                                break;
                            }
                            else
                            {
                                Console.WriteLine(eky + @"

Silindirin yarıçapı = " + olcum1);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                    if (girdi == "00" || !Double.TryParse(girdi, out olcum1) || olcum1 < 0)
                    {
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (girdi == "3")
            {
                while (true)
                {
                    Console.Write(@"
Koninin yarıçapı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if (Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        while (true)
                        {
                            Console.Write("Koninin yüksekliği = ");
                            girdi = Console.ReadLine();
                            if (girdi == "0")
                            {
                                Console.WriteLine(kpn);
                                Environment.Exit(0);
                            }
                            else if (girdi == "00")
                            {
                                break;
                            }
                            else if (Double.TryParse(girdi, out olcum2) && olcum2 > 0)
                            {
                                Console.WriteLine("Koninin yüzey alanı = " + (PI * olcum1 * (olcum1 + Sqrt(Pow(olcum1, 2) + Pow(olcum2, 2)))));
                                Console.WriteLine("Koninin hacmi = " + (PI * Pow(olcum1, 2) * olcum2 / 3));
                                break;
                            }
                            else
                            {
                                Console.WriteLine(eky + @"

Koninin yarıçapı = " + olcum1);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                    if (girdi == "00" || !Double.TryParse(girdi, out olcum1) || olcum1 < 0)
                    {
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (girdi == "4")
            {
                while (true)
                {
                    Console.Write(@"
Kürenin yarıçapı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if (Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        Console.WriteLine("Kürenin yüzey alanı = " + (4 * PI * Pow(olcum1, 2)));
                        Console.WriteLine("Kürenin hacmi = " + (PI * 4/3 * Pow(olcum1, 3)));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                }

            }
            else if (girdi == "5")
            {
                while (true)
                {
                    Console.Write(@"
Üçgenin tabanı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if (Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        while (true)
                        {
                            Console.Write("Üçgenin yüksekliği = ");
                            girdi = Console.ReadLine();
                            if (girdi == "0")
                            {
                                Console.WriteLine(kpn);
                                Environment.Exit(0);
                            }
                            else if (girdi == "00")
                            {
                                break;
                            }
                            else if (Double.TryParse(girdi, out olcum2) && olcum2 > 0)
                            {
                                Console.WriteLine("Üçgenin alanı = " + (olcum1 * olcum2 / 2));
                                break;
                            }
                            else
                            {
                                Console.WriteLine(eky + @"

Üçgenin tabanı = " + olcum1);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                    if (girdi == "00" || !Double.TryParse(girdi, out olcum1) || olcum1 < 0)
                    {
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (girdi == "6")
            {
                while (true)
                {
                    Console.Write(@"
Karenin bir kenarı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if(Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        Console.WriteLine("Karenin çevresi = " + (olcum1 * 4));
                        Console.WriteLine("Karenin alanı = " + Pow(olcum1, 2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                }

            }
            else if (girdi == "7")
            {
                while (true)
                {
                    Console.Write(@"
Dikdörtgenin bir kenarı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if (Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        while (true)
                        {
                            Console.Write("Dikdörtgenin diğer kenarı = ");
                            girdi = Console.ReadLine();
                            if (girdi == "0")
                            {
                                Console.WriteLine(kpn);
                                Environment.Exit(0);
                            }
                            else if (girdi == "00")
                            {
                                break;
                            }
                            else if (Double.TryParse(girdi, out olcum2) && olcum2 > 0)
                            {
                                Console.WriteLine("Dikdörtgenin çevresi = " + (olcum1 * 2 + olcum2 * 2));
                                Console.WriteLine("Dikdörtgenin alanı = " + olcum1 * olcum2);
                                break;
                            }
                            else
                            {
                                Console.WriteLine(eky + @"

Dikdörtgenin bir kenarı = " + olcum1);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                    if (girdi == "00" || !Double.TryParse(girdi, out olcum1) || olcum1 < 0)
                    {
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (girdi == "8")
            {
                while (true)
                {
                    Console.Write(@"
Dairenin yarıçapı = ");
                    girdi = Console.ReadLine();
                    if (girdi == "0")
                    {
                        Console.WriteLine(kpn);
                        Environment.Exit(0);
                    }
                    else if (girdi == "00")
                    {
                        break;
                    }
                    else if (Double.TryParse(girdi, out olcum1) && olcum1 > 0)
                    {
                        Console.WriteLine("Dairenin çevresi = " + (2 * PI * olcum1));
                        Console.WriteLine("Dairenin alanı = " + (PI * Pow(olcum1, 2)));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(eky);
                    }
                }

            }
            else
            {
                Console.WriteLine(eky);
            }
        }
    }
}