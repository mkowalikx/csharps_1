using System;

class Program {

    static void Maain(String[] args)
    {

        string data = Console.ReadLine();
        string[] multiString = data.Split(' ');
        int age = int.Parse(multiString[1]);
        int retirementAge = int.Parse(multiString[2]);
        // int age = int.Parse(Console.ReadLine() ?? string.Empty);
        // int retirementAge = int.Parse(Console.ReadLine() ?? string.Empty);
        int result = retirementAge - age;
        
        if (age < 0 || retirementAge < 0)
        {
            Console.WriteLine("Wiek nie może być ujemny!");
        }
        else if (result <= 0)
        {
            Console.WriteLine($"Witaj emerycie {multiString[0]}!");
        }
        else
        {
            if (result == 1)
            {
                // ReSharper disable once HeapView.BoxingAllocation
                Console.WriteLine($"Witaj {multiString[0]}! Do emerytury brakuje Ci {result} rok!");    
            }
            else if ((result % 10 == 2 && result != 12) || (result % 10 == 3 && result!=13) || (result % 10 == 4 && result != 14))
            {
                // ReSharper disable once HeapView.BoxingAllocation
                Console.WriteLine($"Witaj {multiString[0]}! Do emerytury brakuje Ci {result} lata!");  
            }
            else
            {
                // ReSharper disable once HeapView.BoxingAllocation
                Console.WriteLine($"Witaj {multiString[0]}! Do emerytury brakuje Ci {result} lat!");  
            }
        }
    }
}