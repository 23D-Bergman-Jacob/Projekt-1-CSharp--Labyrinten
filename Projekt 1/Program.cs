Random rnd = new Random();
System.Console.WriteLine("Hej Så Du Har valt Att Utforska Den Gamla Labyrinten Och Leta Efter Guldet Som Är Gömt här");
System.Console.WriteLine("Vad Är Ditt Namn?");
string namn = Console.ReadLine();
while (namn == "")
{  
    // bara så att man inte skriver ingenting som namnet
    System.Console.WriteLine("Det Är Inte Ett Namn");
    System.Console.WriteLine("Skriv Ett Namn");
    namn = Console.ReadLine();
}
System.Console.WriteLine("Hej " + namn + " Lycka Till I Labyrinten");
bool k = false;

int XAxelnr = rnd.Next(1, 6);
int YAxelnr  = rnd.Next(1, 7);
List<int> XAxel = new List<int>();
List<int> YAxel = new List<int>();
while (XAxel.Count < 6)
{
    while (true)
    {

        for (int i = 0; i < XAxel.Count; i++)
        {
            XAxelnr = rnd.Next(1, 6);
            if (XAxelnr == XAxel[i])
            {
                k = false;
                break;
            }
            k = true;
        }
        if (k == true)
        {
            break;
        }
    }
    XAxel.Add(XAxelnr);
}


while (YAxel.Count < 7)
{
    while (true)
    {

        for (int i = 0; i < YAxel.Count; i++)
        {
            YAxelnr = rnd.Next(1, 7);
            if (YAxelnr == YAxel[i])
            {
                k = false;
                break;
            }
            k = true;
        }
        if (k == true)
        {
            break;
        }
    }
    YAxel.Add(YAxelnr);
}
Console.ReadLine();
hej