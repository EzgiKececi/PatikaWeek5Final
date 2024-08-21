using Week5Final;

public class Program
{
    public static void Main()
    {
        List<Car> cars = new List<Car>(); // Araba nesnelerinin tutulacağı liste oluşturma

        bool production = false; // production değeri true olunyaca kadar döngüyü çalıştırmak için atanan boolean değişkeni 

        while (!production)
        {
            Console.WriteLine("Araba oluşturmak ister misiniz?: ");
            string userResponse = Console.ReadLine().ToLower().Trim();

            if (userResponse == "h") // Hayır cevabı verildiğinde programı sonlandırma
            {
                Console.WriteLine("Programdan çıkıyorsunuz.\n");
                production = true; // Döngüyü bitirme
            }


            else if (userResponse == "e") // Evet cevabı verildiğinde araba nesnelerini oluşturma 
            {
                Car car = new Car(); // Yeni araba nesnesi 


                // Kullanıcıdan konsol üzerinden bilgiler alma
                Console.Write("Seri Numarası: ");
                car.SerialNumber = Console.ReadLine();

                Console.Write("Marka: ");
                car.Brand = Console.ReadLine();

                Console.Write("Model: ");
                car.Model = Console.ReadLine();

                Console.Write("Renk: ");
                car.Colour = Console.ReadLine();

                car.ProductTime();  // Araba sınıfındaki ilgili metodu kullanma

            Ask: Console.Write("Kapı sayısı: ");

                // Kapı sayısı girişinde veri hatası varsa try catch ile ekrana uyarı gönderme
                try
                {
                    string input = Console.ReadLine();
                    int numberOfDoor = Convert.ToInt32(input);
                    car.NumberOfDoor = numberOfDoor; // Hata yoksa girilen değeri değişkene atama

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Yanlış bir veri girdiniz. Tekrar deneyiniz: ");
                    goto Ask; // Tekrar giriş yapması için ilgili kod satırına dönme
                }


                cars.Add(car); // Oluşturulan araba nesnelerini, arabalar listesine ekleme
            }

            else
            {
                Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyiniz.");
                continue; // Döngü içinde en başa dönme
            }

        }

        foreach (Car car in cars)  // Liste içindeki nesnelerin bilgilerini konsola yazdırma 
        {
            car.PrintCarInfo(); // Araba sınıfındaki ilgili metodu kullanma
            Console.WriteLine();
        }


    }
}