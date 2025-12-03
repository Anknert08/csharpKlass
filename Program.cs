
using csharptestare;


Fordon f = new Fordon();
String promt;


void tillverkare()
{
    Console.Write("Ange fordonets tillverkare:");
    f.SetTillverkare(Console.ReadLine());
}

void modell()
{
    Console.Write("Ange fordonets modell:");
    f.SetModell(Console.ReadLine());  
}

void årsmodell()
{
    Console.Write("Ange fordonets årsmodell:");
    f.SetÅrsmodell(int.Parse(Console.ReadLine()));
}

void regnummer()
{
    Console.Write("Ange fordonets registreringsnummer:");
    f.SetRegnummer(Console.ReadLine());
}

void färg()
{
    Console.Write("Ange fordonets färg:");
    f.SetFärg(Console.ReadLine());
}


do
{
   Console.Write("skriv promt (exit för att avsluta): ");
    promt = Console.ReadLine();
    if (promt == "edit info" || promt == "Edit info")
    {
        tillverkare();
        modell();
        årsmodell();
        regnummer();
        färg();
    }
    if (promt == "show info" || promt == "Show info")
    {
        Console.WriteLine("Fordonets tillverkare: " + f.GetTillverkare() + "\n");
        Console.WriteLine("Fordonets modell: " + f.GetModell() + "\n");
        Console.WriteLine("Fordonets årsmodell: " + f.GetÅrsmodell() + "\n");
        Console.WriteLine("Fordonets registreringsnummer: " + f.GetRegnummer() + "\n");
        Console.WriteLine("Fordonets färg: " + f.GetFärg() + "\n");
    }
    
    if (promt == "Help" || promt == "help")
    {
        Console.WriteLine("Commands:\nedit info - edit vehicle information\nshow info - show vehicle information\nexit - exit the program\nhelp - show this help message\n");
    }

    
} while (promt != "exit" && promt != "Exit");








