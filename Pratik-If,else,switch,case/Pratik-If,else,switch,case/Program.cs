using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Ruya manavina Hos Geldiniz!");
        Console.WriteLine("Elma = 2 TL");
        Console.WriteLine("Armut = 3 TL");
        Console.WriteLine("Cilek = 2 TL");
        Console.WriteLine("Muz = 3 TL");
        Console.WriteLine("Diger butun meyveler = 4 TL");
        Console.Write("Hangi meyveyi satın almak istersiniz? (Elma, Armut, Çilek, Muz veya diger): ");
        string meyve = Console.ReadLine().ToLower();               // Kullanıcının girdisini küçük harfe dönüştürüyoruz

        int fiyat;

        // if karar yapısı
        if (meyve == "elma")
        {
            Console.WriteLine("Elma fiyatı: 2 TL");
        }
        else if (meyve == "armut")
        {
            Console.WriteLine("Armut fiyatı: 3 TL");
        }
        else if (meyve == "cilek")
        {
            Console.WriteLine("Cilek fiyatı: 2 TL");
        }
        else if (meyve == "muz")
        {
            Console.WriteLine("Muz fiyatı: 3 TL");
        }
        else
        {
      
            // switch karar yapısı
            switch (meyve)
            {
                case "elma":
                    fiyat = 2;
                    break;
                case "armut":
                    fiyat = 3;
                    break;
                case "cilek":
                    fiyat = 2;
                    break;
                case "muz":
                    fiyat = 3;
                    break;
                default:
                    fiyat = 4;                                         // Diğer meyveler için varsayılan fiyat
                    break;
            }
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat} TL");
        }
    }
}
// çoklu seçenekli bir karar yapısı olduğu için kodun doğruluğu açısından switch kullanımı daha uygundur.