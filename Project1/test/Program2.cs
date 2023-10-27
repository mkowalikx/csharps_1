using System;
using System.Globalization;


namespace Project1 
{
    public class Program2 {
        
        static void Main(String[] args) {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            string data = Console.ReadLine();
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            string[] dataList = data.Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
        
            // Console.WriteLine(dataList.Length);
            // Console.WriteLine(dataList[0]);
            // Console.WriteLine(dataList[1]);
            // Console.WriteLine(dataList[2]);
            double a = double.Parse(dataList[0]);
            double b = double.Parse(dataList[1]);
            double c = double.Parse(dataList[2]);
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            if (a <= 0 || b <= 0 || c <= 0) {
                Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                return;
            }
            
            if (a + b >= c) {
                double circuit = a + b + c;
                double p = circuit / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                //Console.WriteLine($"{Math.Round(circuit, 2)}, {Math.Round(area, 2)}");
                string type;
                if ((a * a) + (b * b) == (c * c)) {
                    type = "prostokątny";
                }
                else if (b * b + c * c > a * a && a * a + c * c > b * b && a * a + b * b > c * c) {
                    type = "ostrokątny";
                }
                else {
                    type = "rozwartokątny";
                }
                
                Console.WriteLine($"obwód = {circuit.ToString("0.00")}");
                Console.WriteLine($"pole = {area.ToString("0.00")}");            
                // Console.WriteLine($"obwód = {Math.Round(circuit, 2)}");
                // Console.WriteLine($"pole = {Math.Round(area, 2)}");
                Console.WriteLine($"trójkąt jest {type}");
                if (a == b && b == c && c == a) {
                    Console.WriteLine("trójkąt równoboczny");
                }
                else if (a == b || b == c || c == a) {
                    Console.WriteLine("trójkąt równoramienny");
                }
                
            }
            else {
                Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
            }
        }
    }
}