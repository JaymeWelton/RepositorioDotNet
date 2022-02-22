using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Knight knight = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
        Ninja ninja = new Ninja("Zack", 24, "Ninja");
        BlackMage blackMage = new BlackMage("Athila", 24, "Black Mage");
        
        WriteLine(knight.Attack(3));
        WriteLine(wizard.Attack(6));
        WriteLine(ninja.Attack(4));
        WriteLine(blackMage.Attack(8));
    }
}