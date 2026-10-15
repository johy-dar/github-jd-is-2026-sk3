// toto je jednořádkový kometář

/* toto je
víceřádkový
komentář */




string again = "a";


while(again.ToLower() == "a")
{



// Dotaz směrem k uživateli na opakování
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
Console.WriteLine("Jakoukoliv jinou klávesou program ukončíte.");
Console.WriteLine();

Console.Write("Chcete program spustit znovu? ");
again = Console.ReadLine() ?? "";
}





