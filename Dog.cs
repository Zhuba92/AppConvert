using System;

namespace AppConvert
{
    public class Dog : Pet
    {
        public bool Friendly;
        public override string Name {get; set;} = "Chester";
        public Dog(bool friendly, string name) :base(name){
            this.Friendly = friendly;
        }

        public bool isfriendly(){
            return Friendly;
        }

        public override string Talk(){
            return "bark";
        }

        public override string GetName(){
            return Name;
        }
    }
}