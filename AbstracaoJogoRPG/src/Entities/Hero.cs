using static System.Console;
public abstract class Hero
{
    public string Name;
    public int Level;
    public string HeroType;
    public Hero(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }
    public abstract string Attack(int numero);

    public override string ToString()
    {
        return $"O personagem {this.Name} de classe {this.HeroType} tem level {this.Level}";
    }
}
