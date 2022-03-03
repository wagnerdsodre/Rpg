namespace src.Entities
{
    public class Mago : Person
    {
        public Mago(string name, int level, string personType) : base(name, level, personType)
        {
        }

        public override string Attack()
        {
            return this.name + " " + " Lançou uma magia de dano";

        }

        public virtual string Attack(int dano)
        {
            if (dano >= 7)
            {
                return this.name + " " + " Lançou uma magia de dano forte " + dano;
            }
            else
            {
                return this.name + " " + " Lançou uma magia de dano forte " + dano;
            }

        }



    }
}