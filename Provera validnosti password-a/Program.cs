using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite password: ");
        string password = Console.ReadLine();

        if (ValidirajPassword(password))
        {
            Console.WriteLine("Password je validan.");
        }
        else
        {
            Console.WriteLine("Password nije validan. Mora imati najmanje 7 znakova i sadržavati barem jedan '!' ili '?'.");
        }
    }

    static bool ValidirajPassword(string password)
    {
        if (password.Length < 7)
            return false;

        if (!password.Contains("!") && !password.Contains("?"))
            return false;

        return true;
    }
}

