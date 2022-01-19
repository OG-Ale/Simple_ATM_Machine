

//  Den Titel von der Konsole umbennen 
using System.Text;

Console.Title = "ATM Machine";

Console.ForegroundColor = ConsoleColor.White; // Verändert die Textfarbe von der Konsole

Console.WriteLine("Bitte geben Sie ihren 4-Stelligen Pin ein ");

string pin = ReqPin();

 static string ReqPin()
{
    StringBuilder sb = new StringBuilder();
    ConsoleKeyInfo keyinfo;

    do
    {
        keyinfo = Console.ReadKey(true);

        if (!char.IsControl(keyinfo.KeyChar))
        {
            sb.Append(keyinfo.KeyChar);
            Console.Write("*");
        }
    } while (keyinfo.Key != ConsoleKey.Enter);
    {
        return sb.ToString();
    }
}

// erst mit Console.ReadKey wird der Titel von der Konsole geändert zu ATM Machine
Console.ReadKey();

