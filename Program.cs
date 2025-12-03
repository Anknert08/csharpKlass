
using csharptestare;


Fordon f = new Fordon();
String promt;


void tillverkare()
{
    Console.Write("Ange fordonets tillverkare:");
    f.Tillverkare = Console.ReadLine();
}

void modell()
{
    Console.Write("Ange fordonets modell:");
    f.Modell = Console.ReadLine();  
}

void årsmodell()
{
    Console.Write("Ange fordonets årsmodell:");
    f.Årsmodell = int.Parse(Console.ReadLine());
}

void regnummer()
{
    Console.Write("Ange fordonets registreringsnummer:");
    f.Regnummer = Console.ReadLine();
}

void färg()
{
    Console.Write("Ange fordonets färg:");
    f.Färg = Console.ReadLine();
}


do
{
   Console.Write("skriv promt (exit för att avsluta): ");
    promt = Console.ReadLine();
    promt = promt.ToLower();
    if (promt == "edit info" || promt == "Edit info")
    {
        tillverkare();
        modell();
        årsmodell();
        regnummer();
        färg();
    }
    if (promt == "show info")
    {
        Console.WriteLine("Fordonets tillverkare: " + f.Tillverkare + "\n");
        Console.WriteLine("Fordonets modell: " + f.Modell + "\n");
        Console.WriteLine("Fordonets årsmodell: " + f.Årsmodell + "\n");
        Console.WriteLine("Fordonets registreringsnummer: " + f.Regnummer + "\n");
        Console.WriteLine("Fordonets färg: " + f.Färg + "\n");
    }
    
    if (promt == "help")
    {
        Console.WriteLine("Commands:\nedit info - edit vehicle information\nshow info - show vehicle information\nexit - exit the program\nhelp - show this help message\nedit info [field] - edit a specific field (tillverkare, modell, årsmodell, regnummer, färg)\n");
    }

    if (promt == "edit info tillverkare")
    {
        tillverkare();
    }

    if (promt == "edit info modell")
    {
        modell();
    }

    if (promt == "edit info årsmodell")
    {
        årsmodell();
    }

    if (promt == "edit info regnummer")
    {
        regnummer();
    }

    if (promt == "edit info färg")
    {
        färg();
    }

    if (promt != "edit info" && promt != "show info" && promt != "help" && promt != "exit" && promt != "edit info tillverkare" && promt != "edit info modell" && promt != "edit info årsmodell" && promt != "edit info regnummer" && promt != "edit info färg")
    {
        Console.WriteLine("Unknown command, type 'help' for a list of commands.\n");
    }

    
} while (promt != "exit");








