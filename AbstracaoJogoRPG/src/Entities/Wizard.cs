public class Wizard : Hero
{
    public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    public override string Attack(int numero)
    {
        if(numero >= 6)
        {
            return $"{this.Name} lançou magia super efetiva";
        }else
        {
            return $"{this.Name} lançou magia";
        }
        
    }
}