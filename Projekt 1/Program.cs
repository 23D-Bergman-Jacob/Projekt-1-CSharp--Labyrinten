Random rnd = new Random();
System.Console.WriteLine("Hej, Så Du Har valt Att Utforska Den Gamla Labyrinten Och Leta Efter Guldet Som Är Gömt här");
System.Console.WriteLine("Vad Är Ditt Namn Eller Smeknamn?");
string namn = Console.ReadLine();
while (namn == "")
{
    // bara så att man inte skriver ingenting som namnet
    System.Console.WriteLine("Det Är Inte Ett Namn");
    System.Console.WriteLine("Skriv Ett Namn");
    namn = Console.ReadLine();
}
System.Console.WriteLine("Hej " + namn + " Lycka Till I Labyrinten");
int cordinat = 5;
List<string> xAxel = new List<string>();
List<string> yAxel = new List<string>();
xAxel = Cordinater(cordinat);
cordinat = 6; 
yAxel = Cordinater(cordinat);




Console.ReadLine();

static List<string> Cordinater(int cordinat)
{
    Random rnd = new Random();
    bool k = false;
    string xAxelNr = rnd.Next(1, cordinat).ToString();
    List<string> xAxel = new List<string>();
    xAxel.Add("1");
    while (xAxel.Count < cordinat)
    {
        while (true)
        {
            xAxelNr = rnd.Next(1, cordinat+1).ToString();
            for (int i = 0; i < xAxel.Count; i++)
            {
                if (xAxel.Count > cordinat-1)
                {
                    k = true;
                    break;
                }
                k = true;
                if (xAxelNr == xAxel[i])
                {
                    k = false;
                    break;
                }
            }
            if (k == true)
            {
                break;
            }
        }
        xAxel.Add(xAxelNr);
    }
    return xAxel;
}

void val()
{
    if (x = xAxel[1])
    {
        System.Console.WriteLine("Du kan gå höger,");
    }
    else if( x = xAxel[5])
    {
        System.Console.WriteLine("Du kan gå vänster,");
    }
}