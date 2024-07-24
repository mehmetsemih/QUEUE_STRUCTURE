using System.ComponentModel;
using System.Xml.Schema;

namespace QUEUE_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sesli_harfler = new List<char>()
            {
                'A','E','I','İ','O','Ü','U','Ö'
            };
            ConsoleKeyInfo secim;

            var kuyruk=new Queue<char>();

            foreach (char k in sesli_harfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5} ifadesi kuyruğa eklensin mi?(E/H)");
                secim=Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                   Console.WriteLine($"\n{k,-5} değeri kuyruğa eklenmiştir..");
                    Console.WriteLine("KUYRUKTAKI ELEMAN SAYISI: "+kuyruk.Count());
                    Console.WriteLine();
                }


            }

            Console.WriteLine("ikinci kısma geçmek için lütfen escape tuşuna basınız....");
            secim = Console.ReadKey();

            if (secim.Key == ConsoleKey.Escape)
            {
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek()} ifadesi kuyruktan çıkarıtlacaktır");
                    Console.WriteLine($"{kuyruk.Dequeue()} ifadesi kuyruktan çıkartıldı...");
                    Console.WriteLine($"KUYRUKTAKİ ELEMAN SAYISI: {kuyruk.Count}");
                }
            }
           

            Console.ReadLine();
        }

        private static void QUEUE_TEMELLERİ()
        {
            //QUEUE DESCRIBING
            var karakter_kuyruğu = new Queue<char>();

            //ADDING 
            karakter_kuyruğu.Enqueue('A');
            karakter_kuyruğu.Enqueue('E');

            //QUEUE CAPACITY
            Console.WriteLine($"KAPASİTE: {karakter_kuyruğu.Count()}");

            //EXTRACTION
            Console.WriteLine($"KUYRUĞUN BAŞINDAAKİ ELEMAN:{karakter_kuyruğu.Peek()}");
            Console.WriteLine($"{karakter_kuyruğu.Dequeue()}+ İFADESİ KUYRUKTAN ÇIKARTILDI....");
            karakter_kuyruğu.Dequeue();
            Console.WriteLine($"ELEMAN SAYISI: {karakter_kuyruğu.Count()}");
            Console.WriteLine($"KUYRUĞUN BAŞINDAKİ ELEMAN: {karakter_kuyruğu.Peek()}");
        }
    }
}
