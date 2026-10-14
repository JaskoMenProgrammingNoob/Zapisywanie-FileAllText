using System.IO;
class Program
{




    static void Main(string[] args)
    {
        string kwadrat = "";
        for (int i = 0; i < 10; i++)
        {
            
            for (int j = 0; j < 10; j++)
            {


                kwadrat += "X ";



            }
            kwadrat += "\n";
        }



        File.WriteAllText("Kwadrat.txt", kwadrat);
        string odczytanie;
        odczytanie = File.ReadAllText("Kwadrat.txt");
        Console.WriteLine(odczytanie);
    }
}