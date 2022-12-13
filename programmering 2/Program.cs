using programmering2;
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Kolla in bilen");

Bil Bil1 = new Bil();

Bil1.setFärg("svart");
Bil1.setMotortyp("el-motor");

Console.WriteLine(Bil1.getFärg());

Console.WriteLine(Bil1.getDäck());

Console.WriteLine(Bil1.getMotortyp());



Random random = new Random();
int xKoordinat;
int yKoordinat;

for (int a = 0; a < 10; a++)
{
    xKoordinat = random.Next(-10, 10);
    yKoordinat = random.Next(-10, 10);
    Console.WriteLine("Du befinner dig vid koordinaterna");
    Console.WriteLine("x=" + " " + xKoordinat);
    Console.WriteLine("y=" + " " + yKoordinat);



    Punkter punkt = new Punkter();
    punkt.setX(0);
    punkt.setY(0);

    Punkter[] arrayPunkt = new Punkter[10];

    for (int i = 0; i < arrayPunkt.Length; i++)
    {
        arrayPunkt[i] = new Punkter();
    }
}       
     



 
