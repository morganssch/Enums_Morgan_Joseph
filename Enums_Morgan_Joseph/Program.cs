using System.Runtime.InteropServices.ComTypes;
using System.IO;


enum Months
{
    Jan =1,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
}

class Program
{
    static void Main(string[] args)
    {
        int myBirhtMonth = (int)Months.Jun;
        int myBirthDay = 30;
        int myBirthYear = 2009;

        string myBirthDate = $"My birthday is {myBirhtMonth}/{myBirthDay}/{myBirthYear}";

        File.WriteAllText("myFile.txt", "This is my text file!\n");
        Console.WriteLine(File.ReadAllText("myFile.txt"));

        File.AppendAllText("myFile.txt", "I added more text unc!\n");
        Console.WriteLine(File.ReadAllText("myFile.txt"));

        if(!File.Exists("newFile.txt"))
        {
            File.Copy("myFile.txt", "newFile.txt");

        }
        else
        {
            File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
        }

        File.AppendAllText("newFile.txt", myBirthDate);
        Console.WriteLine(File.ReadAllText("newFile.txt"));

    }
}