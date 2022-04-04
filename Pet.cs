using System;

namespace AppConvert
{
    public abstract class Pet : Talkable
    {
        public abstract string Name {get; set;}
        public abstract string Talk();
        public abstract string GetName();

        public Pet(string name){
            this.Name = name;
        }
    }
}