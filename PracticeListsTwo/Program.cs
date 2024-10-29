using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeListsTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // String türünde bir liste oluşturuyoruz; bu listeye davetli isimlerini ekleyeceğiz
            List<string> list = new List<string>();
            // Sonsuz bir döngü başlatıyoruz, kullanıcıdan isim almak için
            for (int i = 0; i<5;i++)
            { // Kullanıcıya isim girmesi veya işlemi bitirmesi için talimat veriyoruz
                Console.Write($"Kahve {i} : ");
                // Kullanıcının girdiği ismi "invite" değişkenine atıyoruz
                string coffeName = Console.ReadLine();
                // Kullanıcının girdiği ismi listeye ekliyoruz
                list.Add(coffeName);
            }

            // Davetlilerin listesini ekrana yazdırıyoruz
            Console.WriteLine("\nKahvelerin listesi:");

            // Listedeki her ismi tek tek ekrana yazdırmak için foreach döngüsü kullanıyoruz
            foreach (string coffee in list)
            {
                Console.WriteLine(coffee); // Her davetliyi ekrana yazdır
            }

            // Kullanıcı, ekrana basılan listeyi görebilsin diye programın kapanmasını engelliyoruz
            Console.ReadLine();

        }
    }
}
