using System;
using System.Reflection;
using Tsepelevits_iseseisev;

class Program
{
    static void Main()
    {
        //Ülesanne 1

        Console.Write("Sisestage rida: ");
        string str = Console.ReadLine();

        Console.Write("Sisestage otsingu sümbol: ");
        char ch = Console.ReadKey().KeyChar;

        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ch)
            {
                count++;
            }
        }

        double percent = (double)count / str.Length * 100;
        Console.WriteLine($"\nMärgi esinemise protsent {ch} reana {str} võrdne {percent}%");

        //Ülessane 2

        //double[,] array = new double[10, 10];

        //Random rnd = new Random();
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        array[i, j] = rnd.NextDouble();
        //    }
        //}
        //Console.WriteLine("Array:");
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        Console.Write($"{array[i, j],8:F2} ");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 0; i < 10; i++)
        //{
        //    double sum = 0;
        //    for (int j = 0; j < 10; j++)
        //    {
        //        sum += array[i, j];
        //    }
        //    Console.WriteLine($"Rea elementide summa {i + 1} on võrdne {Math.Round(sum)}");
        //    Thread.Sleep(200);
        //}
        //for (int j = 0; j < 10; j++)
        //{
        //    double product = 1;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        product *= array[i, j];
        //    }
        //    Console.WriteLine($"Veergude elementide korrutis {j + 1} võrdub {Math.Round(product)}");
        //    Thread.Sleep(200);
        //}
        //double max = double.MinValue;
        //for (int i = 0; i < 10; i++)
        //{
        //    if (array[i, i] > max)
        //    {
        //        max = array[i, i];
        //    }
        //}
        //Console.WriteLine($"Põhidiagonaali maksimaalne element on {Math.Round(max)}");
        //Thread.Sleep(200);

        //Ülesanne 3

        Student[] students = new Student[6];

        students[0] = new Student("Ivanov", "Ivan", "1", new int[] { 5, 4, 3, 4 });
        students[1] = new Student("Fedorov", "Sanja", "2", new int[] { 4, 4, 4, 4 });
        students[2] = new Student("Kemppi", "Martin", "3", new int[] { 3, 3, 4, 3 });
        students[3] = new Student("Lukashnko", "Nadja", "4", new int[] { 5, 4, 5, 4 });
        students[4] = new Student("Fedorov", "Yarik", "5", new int[] { 4, 4, 4,5 });
        students[5] = new Student("Gluhhov", "Luca", "6", new int[] { 5, 5, 4, 4 });

        Console.WriteLine("Stipendiumitellimusega hõlmatud õpilased:");
        foreach (Student student in students)
        {
            if (student.HasScholarship())
            {
                Console.WriteLine($"{student.LastName} {student.FirstName} rühmana {student.GroupCode}");
            }
        }
    }
}

