using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan secim al. taskağıtmakas dizisinden rastgele bir değer al ve karşılaştır. Sonuca göre puanla. 3 olan kazansın. do whie kullan.
            string[] tasKagitMakas = new string[3] {"tas","kagit","makas"};
            string secim;
            int skorKullanici=0, skorPc=0,i;
            Random rastgele = new Random();


            Console.WriteLine("Taş kağıt makas oyununa hosgeldiniz!");
            

            do
            {
                Console.Write("Bir secim yapiniz:");
                secim = Console.ReadLine();
                i = rastgele.Next(0, 3);
                Console.WriteLine("Kullanicinin tercihi: {0}",secim);
                Console.WriteLine($"Bilgisayarin tercihi:{tasKagitMakas[i]}");


                if (secim == tasKagitMakas[i])
                {
                    Console.WriteLine("Ayni tercihi yaptiniz.\n");
                    
                }
                else if (secim=="tas" && tasKagitMakas[i]=="kagit")
                {
                    Console.WriteLine("Bilgisayar kazandi!");
                    skorPc++;
                    Console.WriteLine($"SKOR: KULLANICI:{skorKullanici} vs BILGISAYAR:{skorPc}\n");
                }
                else if (secim == "tas" && tasKagitMakas[i] == "makas")
                {
                    Console.WriteLine("Kullanici kazandi!");
                    skorKullanici++;
                    Console.WriteLine($"SKOR: KULLANICI:{skorKullanici} vs BILGISAYAR:{skorPc}\n");
                }
                else if (secim == "kagit" && tasKagitMakas[i] == "makas")
                {
                    Console.WriteLine("Bilgisayar kazandi!");
                    skorPc++;
                    Console.WriteLine($"SKOR: KULLANICI:{skorKullanici} vs BILGISAYAR:{skorPc}\n");
                }
                else if (secim == "kagit" && tasKagitMakas[i] == "tas")
                {
                    Console.WriteLine("Kullanici kazandi!");
                    skorKullanici++;
                    Console.WriteLine($"SKOR: KULLANICI:{skorKullanici} vs BILGISAYAR:{skorPc}\n");
                }
                else if (secim == "makas" && tasKagitMakas[i] == "kagit")
                {
                    Console.WriteLine("Kullanici kazandi!");
                    skorKullanici++;
                    Console.WriteLine($"SKOR: KULLANICI:{skorKullanici} vs BILGISAYAR:{skorPc}\n");
                }
                else if (secim == "makas" && tasKagitMakas[i] == "tas")
                {
                    Console.WriteLine("Bilgisayar kazandi!");
                    skorPc++;
                    Console.WriteLine($"SKOR: KULLANICI:{skorKullanici} vs BILGISAYAR:{skorPc}\n");
                }
                if (skorPc==3)
                {
                    Console.WriteLine($"Tebrikler bilgisayar {skorPc} kazandi!");
                    break;
                }
                else if (skorKullanici==3)
                {
                    Console.WriteLine($"Tebrikler kullanici {skorKullanici} kazandi!");
                    break;
                }

            } while (true);

            Console.ReadLine();
        }
    }
}
