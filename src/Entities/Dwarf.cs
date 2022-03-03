using src.Entities;

namespace Rpg.src.Entities
{
    public class Dwarf : Person
    {
           public Dwarf(string name, int level, string personType) : base(name, level, personType)
        {
        }

         public override string Attack() {
       return this.name +  " " + " Lançou dano de machado";
      
  } 

     public virtual string Attack(int dano){
             if(dano >= 7){
                    return this.name +  " " + " Lançou uma dano machado forte " + dano;
               }else{
                 return this.name +  " " + " Lançou uma dano machado fraco " + dano;  
               }

        }





    }
}