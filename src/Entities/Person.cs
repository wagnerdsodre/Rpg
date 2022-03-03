namespace src.Entities
{
    public  abstract class Person
    {
        public string name { get; set; }        

        public int level { get; set; }  
        public string personType { get; set; }

      public Person(string name, int level, string personType)
      {
          this.name  = name;
          this.level = level;
          this.personType = personType;
      }

        public override string ToString()
        {
            return this.name + " "+ this.level + "" + this.personType;
        }

        public virtual string Attack(){
            return "Properties de atack";
        }
     

    }

    
}