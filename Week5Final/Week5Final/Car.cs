using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week5Final
{
    public class Car // Araba sınıfı oluşturma
    {

        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public DateTime ProductDate { get; set; }      
        public int NumberOfDoor {  get; set; }

        

        public void ProductTime() // Nesne oluşturulduğu anda tarih ve saatin işlenceği metot
        {
            ProductDate = DateTime.Now; 
        }
        public void PrintCarInfo()  // Üretilen araba ile ilgili bilgilerin verileceği metot
        {
            Console.WriteLine($"{SerialNumber} seri numaralı araba ile ilgili bilgiler:\nMarka-Model-Renk : {Brand}-{Model}-{Colour}");
            Console.WriteLine($"Üretim Tarihi : {ProductDate}");        
        }
    }
}