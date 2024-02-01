// Chemball

int hp = 3;
// Hp Amount
int shield = 2;
// Shield amount
string intro1 = "Hello, Welcome To The World Of Chemnull";
string intro2 = "As the name suggests, our world has been lacking chemistry lately";
string intro3 = "Because of this, you'll be controlling Chemball, a ball that can absorb and use elements";
string intro4 = "With this cool power, you will bring chemistry to our boring world, and restore it's glory";
string intro5 = "WASD to move, and press space to jump! Walk over an element to absorb it";
// Intro in strings cuz I need strings

Console.WriteLine(intro1);
Console.WriteLine(intro2);
Console.WriteLine(intro3);
Console.WriteLine(intro4);
Console.WriteLine(intro5);

while (hp == 0)
{
    Console.WriteLine("Game Over");
}
// Game over

public int Add(int hp, int shield)
{
    int TotalHp = hp + shield;
    return TotalHp;
}
// Total Hp
public int hp;
public int shield;
private string catSecret "Why Cats Are Better Than Dogs";
// Secret cuz I need private access

List<string> Elements = new List<string>();
// Element list

Elements.Add("Sodium");
Elements.Add("Helium");
Elements.Add("Iron");

for (int i = 0; i < Elements.Count; i++)
{
    Console.WriteLine(friends[i]);
}
