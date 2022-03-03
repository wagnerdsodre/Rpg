using src.Entities;

namespace Rpg.src.Entities
{
    public class Elves : Person
    {
           public Elves(string name, int level, string personType) : base(name, level, personType)
        {
        }

         public override string Attack() {
       return this.name +  " " + " Lançou dano de persuasão";
      
  } 

     public virtual string Attack(int dano){
             if(dano >= 7){
                    return this.name +  " " + " Lançou uma dano com poder de persuasão forte " + dano;
               }else{
                 return this.name +  " " + " Lançou uma dano com poder de persuasão fraco " + dano;  
               }

        }





    }
}