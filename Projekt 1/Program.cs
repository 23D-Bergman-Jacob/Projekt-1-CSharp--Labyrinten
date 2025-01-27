Random rnd = new Random();
int x = 1;
int y = 1;
int cordinat = 5;
List<string> xAxel = new List<string>();
List<string> yAxel = new List<string>();
xAxel = Cordinater(cordinat);
cordinat = 6; 
yAxel = Cordinater(cordinat);
namn();
logik();



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



void logik()
{
    val();
    spelarVal();

}

void val()
{
    if (x == 1)
    {
        System.Console.WriteLine("Du kan gå höger");
    }
    else if(x == 5)
    {
        System.Console.WriteLine("Du kan gå vänster");
    }
    else
    {
        System.Console.WriteLine("Du kan gå höger, vänster");
    }
    if(y == 1)
    {
        Console.Write("och ner");
    }
    else if (y==6)
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
        if (val.ToLower()=="upp")
        {
            y--;
        }
        if (x == 0 && x==6)
        {
            System.Console.WriteLine("Du kan inte gå dit");
            if(x==0)
            {
                x++;
            }
            else
            {
                x--;
            }
        }
        else if (y == 0 && y==7)
        {
            System.Console.WriteLine("Du kan inte gå dit");
            if (y == 7)
            {
                y--;
            }
            else
            {
                y++;
            }
        }
        else
        {
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
System.Console.WriteLine("skatten är gömd någon stans i rutnätet");
karta();
}

void karta()
{
    for (int i = 1; i<y; i++)
    {
        System.Console.WriteLine("0, 0, 0, 0, 0,");
    }
    for(int i = 1; i<6; i++)
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
    for (int i = 6; i!=y; i--)
    {
        System.Console.WriteLine("0, 0, 0, 0, 0,");
    }
}

// void spelet()
// {
//     string cord = xAxel[x]+ yAxel[y];
//     if (cord == "11")
//     {
//         11();
//     }
//     if (cord == "12")
//     {
//         12();
//     }
//     if (cord == "13")  
//     {
//         13();
//     } 
//     if (cord == "14") 
//     {
//         14();
//     } 
//     if (cord == "15") 
//     {
//         15();
//     }
//     if (cord == "16")
//     {
//         16();
//     }
//     if (cord == "21")
//     {
//         21();
//     }   
//     if (cord == "22")   
//     {
//         22();
//     }
//     if (cord == "23")   
//     {
//         23();
//     }
//     if (cord == "24")
//     {
//         24();
//     }   
//     if (cord == "25")   
//     {
//         25();
//     }
//     if (cord == "26")   
//     {
//         26();
//     }
//     if (cord == "31")   
//     {
//         31();
//     }
//     if (cord == "32")   
//     {
//         32();
//     }
//     if (cord == "33")  
//     {
//         33();
//     } 
//     if (cord == "34")
//     {
//         34();
//     }   
//     if (cord == "35")
//     {
//         35();
//     }
//     if (cord == "36")   
//     {
//         36();
//     }
//     if (cord == "41")   
//     {
//         41();
//     }
//     if (cord == "42")   
//     {
//         42();
//     }
//     if (cord == "43")  
//     {
//         43();
//     } 
//     if (cord == "44")
//     {
//         44();
//     }   
//     if (cord == "45")   
//     {
//         45();
//     }
//     if (cord == "46") 
//     {
//         46();
//     }     
//     if (cord == "51")
//     {
//         51();
//     }   
//     if (cord == "52")   
//     {
//         52();
//     }
//     if (cord == "53")   
//     {
//         53();
//     }
//     if (cord == "54")   
//     {
//         54();
//     }
//     if (cord == "55") 
//     {
//         55();
//     }  
//     if (cord == "56")   
//     {
//         56();
//     }
//     if (cord == "61")
//     {
//         61();
//     }   
//     if (cord == "62") 
//     {
//         62();
//     }  
//     if (cord == "63")   
//     {
//         63();
//     }
//     if (cord == "64")   
//     {
//         64();
//     }
//     if (cord == "65")   
//     {
//         65();
//     }
//     if (cord == "66")  
//     {
//         66();
//     } 
// }

