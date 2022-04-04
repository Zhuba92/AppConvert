using System;

namespace AppConvert
{
    public class Teacher : Person
    {
        private int Age {get; set;}
        public override string Name {get; set;} = "Chester";
        public Teacher(int age, string name) : base(name){
            this.Age = age;
        }

        public override string Talk(){
            return "Don't forget to do the assigned reading!";
        }

        public override string GetName(){
            return Name;
        }
    }
}