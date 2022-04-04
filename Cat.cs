using System;

namespace AppConvert
{
    public class Cat : Pet
    {
        public int MousesKilled {get; set;}
        public override string Name {get; set;} = "Chester";
        public Cat(int age, string name) : base(name){
            MousesKilled = MousesKilled;
        }

        public int mousesKilled(){
            return MousesKilled;
        }

        public override string Talk(){
            return "Meow";
        }

        public override string GetName(){
            return Name;
        }
    }
}