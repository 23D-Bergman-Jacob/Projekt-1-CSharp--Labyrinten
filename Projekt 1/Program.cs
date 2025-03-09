Random rnd = new Random();
int liv = 3;
int x = 1;
int y = 1;
int cordinat = 5;
int attack = 0;
int självskada = 0;
int motståndarAttack = 0;
int motståndarAttackSkada = 10;
int motståndarLiv = 100;
int livf13 = 100;
string move = Random.Shared.Next(100, 50000).ToString();
// Xaxeln är 5 nummer och 5 bestämmer hur många rader den kommer vara i funktionen
List<string> xAxel = new List<string>();
List<string> yAxel = new List<string>();
List<string> användKordinatLista = new List<string>();

xAxel = Cordinater(cordinat);
cordinat = 6;
// Yaxeln är 6 nummer och 6 bestämmer hur många rader den kommer vara i funktionen
yAxel = Cordinater(cordinat);
namn();
main();



Console.ReadLine();



static List<string> Cordinater(int cordinat)
{
    // lägger in random kordinaterna alltså så att spelen inte är på samma ställe varje gång Alltså genererar denna function det gömda coordinatsystemet
    // Är I string format för att enkelt kunna göra om till kordinater så att 1+1 = 11 istället för 2
    // stringarnas nummer har tiotal mellan 1 och 5 i tiotalet och 1 till 6 i entalen alltså 11, 12, 13, 14, 15, 16, 21 osv.
    Random rnd = new Random();
    bool k = false;
    string xAxelNr = rnd.Next(1, cordinat).ToString();
    List<string> xAxel = new List<string>();
    xAxel.Add("1");
    // ser till så att första talet i listan är 1
    while (xAxel.Count < cordinat)
    {
        // ser till att det blir rätt antal cordinater
        while (true)
        {
            // ser till så att inte samma kordinat upprepas
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
            // om inget upprepas breakas while loopen
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
    // själva spelet ser till så att det inte tar slut från ingen stans
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
    // skriver ut valen vart man kan gå
    // denna använder det regelbundna coordinatsystemet som även används för att rita ut kartan
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
    // Räknar ut vart du vill gå Och går ditåt ser även till så att du inte går dit du inte kan gå
    // samma sätt som den function som skriver ut med att det använder det linjära coordinatsystemet
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
    // bara introt där du skriver in dit namn och beskriver vad spelet är
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
    // ritar ut kartan 
    // skriver först ut tills du kommer till y axeln sedan skriver den ut den y axeln manuellt för att kunna skriva ut ettan där du står efter det skriver den ut hela rader igen
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
    // denna function är logiken som binder ihop dom icke linjära coordinaterna med vart du är på kartan ser även till så att du inte behöver köra samma spel 2 ggr
    bool rutaAnvänd = true;
    string cord = xAxel[x - 1] + yAxel[y - 1];
    for (int r = 0; r < användKordinatLista.Count; r++)
    {
        if (cord == användKordinatLista[r])
        {
            rutaAnvänd = false;
        }
    }
    // koden innan detta är bara så att man inte kan köra sama minispel igen
    if (rutaAnvänd == true)
    {
        // Skrev denna kod med ai
        // Den hittar vilket rumm du är i och kör det spelet
        // Spelet du är i beror på det gömda kordinatsystemet som är random där x axeln är första nummret och Y axeln är andra nummret
        Dictionary<string, Action> functionMap = new Dictionary<string, Action>
        {
            { "11", f11 },
            { "12", f12 },
            { "13", f13 },
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
    // lägger till kordinaten du är på till använd kordinat
    string användKordinatTillägg = xAxel[x - 1] + yAxel[y - 1];
    användKordinatLista.Add(användKordinatTillägg);
}

void livFunction()
{
    // När du förlorar ett liv skriver denna ut vad som händer
    liv--;
    if (liv == 2)
    {
        System.Console.WriteLine("Du känner hur labyrinten skakar och ett stort stenblock faller ner precis bredvid dig (du har 2 liv kvar)");
    }
    if (liv == 1)
    {
        System.Console.WriteLine("Från den bortre väggen skuts det ut en pil som snuddar vid dit öra ( du har 1 liv kvar)");
    }
    if (liv == 0)
    {
        System.Console.WriteLine("Du hör ett gigantiskt muller samtidigt som du ser sprickor börjar formas i väggarna. Plötsligt ryker hela labyrinten ihop och du blir levande begravd.");
        tackFörMig();
    }

}

static void tackFörMig()
{
    // när man förlorar eller vinner spelet och det tar slut
    System.Console.WriteLine("tack för du spelat spelet! hoppas du hade kul");
    Console.ReadLine();
    Environment.Exit(0);
}

void f11()
{
    // Spel nr 1 multiplikation du ska lösa ett matter problem ganska straghit forward
    // kommer alltid vara första rummet eftersom du börjar på coordinaterna 1,1 
    Console.Clear();
    System.Console.WriteLine("välkommer till första rummet!");
    System.Console.WriteLine("på väggen står det en uråldrig text som du lyckas övertyga till");
    int tal1 = rnd.Next(8, 30);
    int tal2 = rnd.Next(8, 30);
    System.Console.WriteLine("Det står " + tal1 + " * " + tal2 + " = X");
    int svar = tal1 * tal2;
    System.Console.WriteLine("Vad är X?");
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
        // ifall du svarar fel förlorar du ett liv
        livFunction();
    }
    else
    {
        System.Console.WriteLine("Snyggt du hade rätt, du kan nu gå vidare till nästa rum");
        // om du hade rätt
    }
    användKordinat();
}

void f12()
{
    // andra rummet i kordinaterna 1,2 som är random Alltså olika ställen i cordinatsystemet varje gång spelet spelas är en simpel gåta spel.
    // återigen ett ganska simpelt spel bara att skriva in svaret
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
        else if (svar.ToLower() == "b" || svar.ToLower() == "c" || svar.ToLower() == "d")
        {
            System.Console.WriteLine("fel svar");
            livFunction();
            break;
        }
        else
        {
            System.Console.WriteLine("Det finns ingen knapp som har det där på sig");
        }
    }
    Console.ReadLine();
    Console.Clear();
    System.Console.WriteLine("Du kan gå vidare");
    användKordinat();
}

void f13()
{
    // spel nr 3 på kordianterna (1,3)
    // blev alldrig helt färdigt
    System.Console.WriteLine("När du kommer in i rummet ser du boxningshanskar på golvet framför dig");
    System.Console.WriteLine("Vill du ta på dig dom? ja eller nej");
    while (true)
    {
        string boxningshanskar = Console.ReadLine();
        if (boxningshanskar.ToLower() == "ja")
        {
            break;
        }
        if (boxningshanskar.ToLower() == "nej")
        {
            attack = 5;
            självskada = 5;
            break;
        }
    }
    System.Console.WriteLine("Plötsligt kommer det ut ett skelett med boxningshanska på ur en hemlig dörr");
    System.Console.WriteLine("När den kommer emot dig  Så inser du att du kan göra 3 grejor (efter att du har gjort ett move kan du inte göra det nästa runda)");

    f13Logik();
    användKordinat();
}

void f13Logik()
{
    // fortsättning på spel nr 3 lite hur det funkar
    // I den här funktionen väljer du ditt spel i detta minispel
    attack = +15;
    string move = "0";

    while (true)
    {
        move = f13Intro();
        System.Console.WriteLine(move);
        int förraAttackMotståndare = Random.Shared.Next(1, 4);
        int motståndarAttack = 0;
        while (förraAttackMotståndare != motståndarAttack)
        {
            motståndarAttack = Random.Shared.Next(1, 4);
        }
        förraAttackMotståndare = motståndarAttack;
        if (move == "1")
        {
            System.Console.WriteLine("1");
            dinAttack1();
        }
        if (move == "2")
        {
            System.Console.WriteLine("2");
            dinAttack2();
        }
        if (move == "3")
        {
            System.Console.WriteLine("3");
            dinAttack3();
        }
        if (livf13 <= 0)
        {
            livFunction();
            break;
        }
        if (motståndarLiv <=0)
        {
            System.Console.WriteLine("Snyggt du vann");
            break;
        }
    }
}

void dinAttack1()
{
    // Beroende på ditt val i spel 13 logik Detta är om du völjer att slå motståndaren
    // svar på en attack du valt
    if (motståndarAttack == 1)
    {
        System.Console.WriteLine("Ni båda slår varandra");
        livf13 = -motståndarAttackSkada + självskada;
        motståndarLiv = -attack;
        System.Console.WriteLine("Du har " + livf13 + "kvar och skelettet har " + motståndarLiv + "kvar");
    }
    if (motståndarAttack == 2)
    {
        System.Console.WriteLine("skeletet blockar din attack och tar 5 skada du tappar balansen och kan inte göra något nästa runda");
        motståndarLiv = -5;
        liv = -självskada;
    }
    if (motståndarAttack == 3)
    {
        System.Console.WriteLine("skeletet dyker undan från din attack och du missar");
    }
    
}

void dinAttack2()
{
    // Beroende på dit val i spel 13 logik
    // samma som förra funktionen

    System.Console.WriteLine("Du kastar dig åt sidan när du ser skelletet komma emot dig.");
    if (motståndarAttack == 1)
    {
        System.Console.WriteLine("När du ligger på marken ser du skeletet slå luften där du nyss stog");
    }
    if (motståndarAttack == 2)
    {
        System.Console.WriteLine("när du slänger dig åt sidan ser du att skelettet gör samma sak åt andra hållet");
    }
    if (motståndarAttack == 3)
    {
        System.Console.WriteLine("När du ligger på marken kollar du upp och ser skeletet blocka din icke komande attack");
    }
}

void dinAttack3()
{
    // Beroende på dit val i spel 13 logik
    // samma som förra funktionen

    System.Console.WriteLine("Du tar upp dina händer för att blocka skelettets slag");
    if (motståndarAttack == 1)
    {
        System.Console.WriteLine("Du blockar skelettets slag och skeletet tappar balansen. Du slår till skelletet snabbt medans det är försvarslöst.");
        livf13 =- självskada;
        motståndarLiv =- attack;
    }
    if (motståndarAttack == 2)
    {
        System.Console.WriteLine("När du tar upp händerna kastar sig skelätet åt sidan och inget händer");
    }
    if (motståndarAttack == 3)
    {
        System.Console.WriteLine("När du tar upp händerna härmar skeletet dig och ingenting händer.");
    }
}

static string f13Intro()
{
    // Vilket move du ska göra i spel (1,3)
    string move = "0";
    string förraAttack = move;
    while (true)
    {
        System.Console.WriteLine("vill du ");
        if (move != "1") { Console.Write("1: Boxa skelettet,"); }
        if (move != "2") { Console.Write(" 2: Dodga,"); }
        if (move != "3") { Console.Write(" 3: Blocka skeletets möjligen kommande slag"); }
        Console.Write("?");
        System.Console.WriteLine();
        move = Console.ReadLine();
        if (förraAttack == move)
        {
            System.Console.WriteLine("Du kan inte köra samma attack 2 gånger i rad.");
        }
        else if (move == "1" || move == "2" || move == "3")
        {
            System.Console.WriteLine("hejsan");
            break;
        }
    }
    System.Console.WriteLine("hejsan 2h");
    return move;
}

