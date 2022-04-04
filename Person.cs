using System;

namespace AppConvert
{
    public abstract class Person : Talkable
    {
        public abstract string Name {get; set;}
        public abstract string Talk();
        public abstract string GetName();

        public Person(string name){
            this.Name = name;
        }

        public string showName(){
            return Name;
        }
    }
}