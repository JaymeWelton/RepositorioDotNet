public class Knight : Hero
{
    public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    public override string Attack(int numero)
    {
        if(numero >= 6)
        {
            return $"{this.Name} atacou com a espada super efetivo";
        }else
        {
            return $"{this.Name} atacou com a espada";
        }
        
    }
}