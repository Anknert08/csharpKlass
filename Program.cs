
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
    if (promt == "ändra info")
    {
        tillverkare();
        modell();
        årsmodell();
        regnummer();
        färg();
    }
    if (promt == "visa info")
    {
        Console.WriteLine("Fordonets tillverkare: " + f.GetTillverkare());
        Console.WriteLine("Fordonets modell: " + f.GetModell());
        Console.WriteLine("Fordonets årsmodell: " + f.GetÅrsmodell());
        Console.WriteLine("Fordonets registreringsnummer: " + f.GetRegnummer());
        Console.WriteLine("Fordonets färg: " + f.GetFärg());
    }

} while (promt != "exit");








