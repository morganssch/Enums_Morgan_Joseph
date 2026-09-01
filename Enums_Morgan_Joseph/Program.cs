using System.Runtime.InteropServices.ComTypes;
using System.IO;


enum Months //labeled months and gave them a number
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
        int myBirhtMonth = (int)Months.Jun; //made the month a number using the enum
        int myBirthDay = 30; //made the day a number
        int myBirthYear = 2009; //made the year a number

        string myBirthDate = $"My birthday is {myBirhtMonth}/{myBirthDay}/{myBirthYear}"; //made the birthday a string using the numbers

        File.WriteAllText("myFile.txt", "This is my text file!\n"); //write a text file with the text "This is my text file!"
        Console.WriteLine(File.ReadAllText("myFile.txt")); //read the text file and print it to the console

        File.AppendAllText("myFile.txt", "I added more text unc!\n"); //append more text to the text file
        Console.WriteLine(File.ReadAllText("myFile.txt")); //read the text file and print it to the console

        if (!File.Exists("newFile.txt")) //made a new file called newFile.txt if it doesn't exist
        {
            File.Copy("myFile.txt", "newFile.txt"); //copied the myFile.txt to a new file called newFile.txt

        }
        else
        {
            File.Replace("newFile.txt", "myFile.txt", "backupFile.txt"); //replace the new file with the myFile.txt and make a backup of the new file
        }

        File.AppendAllText("newFile.txt", myBirthDate); //put the birthday in the new file
        Console.WriteLine(File.ReadAllText("newFile.txt")); //wrote the new file with the birthday and printed it to the console

    }
}