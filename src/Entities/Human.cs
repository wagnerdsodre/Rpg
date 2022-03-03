using src.Entities;

namespace Rpg.src.Entities
{
    public class Human : Person
    {
           public Human(string name, int level, string personType) : base(name, level, personType)
        {
        }

         public override string Attack() {
       return this.name +  " " + " Lançou dano de espada";
      
  } 

     public virtual string Attack(int dano){
             if(dano >= 7){
                    return this.name +  " " + " Lançou uma dano de espada forte " + dano;
               }else{
                 return this.name +  " " + " Lançou uma dano de espada fraco " + dano;  
               }

        }





    }
}