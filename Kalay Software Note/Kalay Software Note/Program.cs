using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("|   Welcome to Kalay Note Program    |");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine(" ");

        Console.Write("Please enter the extension of the file in which you will keep your notes:\n");
        string extension = Console.ReadLine();

        Console.WriteLine(" ");

        string action;

        while(true)
        {
            Console.WriteLine("1-Create a note\n2-Read a note\n");
            Console.Write("Select the action you want to take: ");
            action = Console.ReadLine();
            

            if (action == "1")
            {
                createNote(extension);
            }
            else if(action == "2")
            {
                readNote(extension);
            }
        }
    }

    static void createNote(string ex)
    {
        Console.Write("Please enter the name of the note you will create: ");
        string fileName = Console.ReadLine();

        StreamWriter wrt = new StreamWriter(@$"{ex}\{fileName}.txt");

        Console.WriteLine("Your file has been created...\n Press enter to continue...");
        Console.ReadLine();

        Console.WriteLine(" ");

        Console.Write("Please write the note you want to write: ");
        string note = Console.ReadLine();

        wrt.WriteLine(note);
        Console.WriteLine("Your note has been saved succesfully...\n Press enter to continue...");
        Console.ReadLine();
        wrt.Close();
    }

    static void readNote (string ex)
    {
        Console.Write("Please enter the name of the next you want to read: ");
        string fileName = Console.ReadLine();
        string line;

        StreamReader rdr = new StreamReader(@$"{ex}\{fileName}.txt");

        line = rdr.ReadLine();
        while (line != null) 
        {
            Console.WriteLine(line);
            line = rdr.ReadLine();
        }

        rdr.Close();
        Console.ReadLine();
    }
}