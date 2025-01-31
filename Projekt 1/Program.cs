Random rnd = new Random();
int liv = 3;
int x = 1;
int y = 1;
int cordinat = 5;
// Xaxeln är 5 nummer och 5 bestämmer hur många rader den kommer vara i funktionen
List<string> xAxel = new List<string>();
List<string> yAxel = new List<string>();
List<string> användKordinatLista = new List<string>();

xAxel = Cordinater(cordinat);
cordinat = 6;
// Yaxeln ät 6 nummer och 6 bestämmer hur många rader den kommer vara i funktionen
yAxel = Cordinater(cordinat);
namn();
main();



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
            xAxelNr = rnd.Next(1, cordinat + 1).ToString();
            for (int i = 0; i < xAxel.Count; i++)
            {
                if (xAxel.Count > cordinat - 1)
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



void main()
{
    while (true)
    {
        Console.Clear();
        spelet();
        karta();
        val();
        spelarVal();
    }

}

void val()
{
    if (x == 1)
    {
        System.Console.WriteLine("Du kan gå höger");
    }
    else if (x == 5)
    {
        System.Console.WriteLine("Du kan gå vänster");
    }
    else
    {
        System.Console.WriteLine("Du kan gå höger, vänster");
    }
    if (y == 1)
    {
        Console.Write("och ner");
    }
    else if (y == 6)
    {
        Console.Write("och upp");
    }
    else
    {
        Console.Write(", ner och upp");
    }
}

void spelarVal()
{
    while (true)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Vart vill du gå?");
        string val = Console.ReadLine();
        if (val.ToLower() == "höger")
        {
            x++;
        }
        if (val.ToLower() == "vänster")
        {
            x--;
        }
        if (val.ToLower() == "ner")
        {
            y++;
        }
        if (val.ToLower() == "upp")
        {
            y--;
        }
        if (y == 0)
        {
            System.Console.WriteLine("Du kan inte gå dit");
            y++;
        }
        else if (y == 7)
        {
            System.Console.WriteLine("Du kan inte gå dit");
            y--;
        }
        else if (x == 0)
        {
            System.Console.WriteLine("Du kan inte gå dit");
            x++;
        }
        else if (x == 6)
        {
            System.Console.WriteLine("Du kan inte gå dit");
            x--;
        }
        else
        {
            System.Console.WriteLine();
            break;
        }
    }
}

void namn()
{
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
    Console.ReadLine();
    Console.Clear();
    System.Console.WriteLine("I den här labyrinten finns det en skatt gömd någonstans och för att vinna spelet måste du hitta skatten.");
    System.Console.WriteLine("skatten är gömd någon stans i rutnätet Du har 3 liv.");
    karta();
}

void karta()
{
    for (int i = 1; i < y; i++)
    {
        System.Console.WriteLine("0, 0, 0, 0, 0,");
    }
    for (int i = 1; i < 6; i++)
    {
        if (i != x)
        {
            Console.Write("0, ");
        }
        else
        {
            Console.Write("1, ");
        }
    }
    System.Console.WriteLine();
    for (int i = 6; i != y; i--)
    {
        System.Console.WriteLine("0, 0, 0, 0, 0,");
    }
}

void spelet()
{
    bool rutaAnvänd= true;
    string cord = xAxel[x-1] + yAxel[y-1];
    for(int r = 0; r<användKordinatLista.Count; r++)
    {
        if(cord == användKordinatLista[r])
        {
            rutaAnvänd = false;
        }
    }
    if (rutaAnvänd == true)
    {
        // Skrev denna kod med ai
            Dictionary<string, Action> functionMap = new Dictionary<string, Action>
        {
            { "11", f11 },
            { "12", f12 },
            // { "13", f13 },
            // { "14", f14 },
            // { "15", f15 },
            // { "16", f16 },
            // { "21", f21 },
            // { "22", f22 },
            // { "23", f23 },
            // { "24", f24 },
            // { "25", f25 },
            // { "26", f26 },
            // { "31", f31 },
            // { "32", f32 },
            // { "33", f33 },
            // { "34", f34 },
            // { "35", f35 },
            // { "36", f36 },
            // { "41", f41 },
            // { "42", f42 },
            // { "43", f43 },
            // { "44", f44 },
            // { "45", f45 },
            // { "46", f46 },
            // { "51", f51 },
            // { "52", f52 },
            // { "53", f53 },
            // { "54", f54 },
            // { "55", f55 },
            // { "56", f56 }
        };
            if (functionMap.TryGetValue(cord, out Action action))
        {
            action();
        }
    }
    else
    {
        System.Console.WriteLine("Du har redan varit här och känner att du vill dra härifrån snarst möjligt.");
    }
}

void användKordinat()
{
    string användKordinatTillägg = xAxel[x-1] + yAxel[y-1];
    användKordinatLista.Add(användKordinatTillägg);
}

void f11()
{
    Console.Clear();
    System.Console.WriteLine("välkommer till första rummet!");
    System.Console.WriteLine("på väggen står det en uråldrig text som du lyckas övertyga till");
    int tal1 = rnd.Next(8, 30);
    int tal2 = rnd.Next(8, 30);
    System.Console.WriteLine("Det står " + tal1 + " * " + tal2 + " = X");
    int svar = tal1 * tal2;
    System.Console.WriteLine("Vad är svaret?");
    string spelarVal = Console.ReadLine();
    int nrVal = 0;
    bool k = false;
    while (k == false)
    {

        k = int.TryParse(spelarVal, out nrVal);
        if (k == false)
        {
            System.Console.WriteLine("Finns bara nummer knappar");
            spelarVal = Console.ReadLine();
        }
    }
    if (svar != nrVal)
    {
        liv--;
        System.Console.WriteLine("Oj, du hade fel det ramlar ner stenar från taken som hamnar 10 centimeter till vänster om dig (du har 2 liv kvar)");
    }
    else
    {
        System.Console.WriteLine("Snyggt du hade rätt, du kan nu gå vidare till nästa rum");
    }
    användKordinat();
}
void f12()
{
    // andra rummet i kordinaterna 1,2 som är random är ett simpelt gåt spel.
    System.Console.WriteLine("Du kommer in i ytterligare ett rum, det här rummet är unket och du känner doften av ruttnande kött. På väggen står det en Gåta och under finns fyra svarsalternativ");
    System.Console.WriteLine("Vill du läsa Gåtan?");
    System.Console.WriteLine("ja eller nej?");
    string svar = Console.ReadLine();
    if (svar != "ja")
    {
        System.Console.WriteLine("Fel svar, du går fram och läser gåtan mot din vilja");
    }
    System.Console.WriteLine("Gåtan lyder: 10 guldfiskar är i en skål");
    System.Console.WriteLine("2 drunknar "); 
    System.Console.WriteLine("3 simmar iväg");
    System.Console.WriteLine(" 4 dör plötsligt");
    System.Console.WriteLine("Hur många är kvar i skålen?");
    System.Console.WriteLine("Vad är svaret?");
    System.Console.WriteLine("a: 10 fiskar, b: 1 fiskar, c: 7 fiskar, d: 6 fiskar");
    while (true)
    {
        svar = Console.ReadLine();
        if (svar == "a")
        {
            System.Console.WriteLine("rätt svar snyggt");
            break;
        }
        else if (svar.ToLower() == "b" || svar.ToLower() == "c" || svar.ToLower() == "d" )
        {
            System.Console.WriteLine("fel svar");
            liv--;
            break;
        }
        else
        {
            System.Console.WriteLine("Det finns ingen knapp som har det där på sig");
        }
    }
    Console.Clear();
    System.Console.WriteLine("Du kan gå vidare");
}