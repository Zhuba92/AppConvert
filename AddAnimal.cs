using System;
using System.Collections;
using System.IO;

namespace AppConvert
{
    public class AddAnimal
    {
        public int choice;
        public ArrayList CreateAnimal(){
    
            Console.WriteLine("Which thing would you like to create? \n1.Cat \n2.Dog");
            choice = Convert.ToInt32(Console.ReadLine());
            var animals = new ArrayList();
            
            switch(choice){
                case 1:
                    Console.Write("How old: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the cat's name: ");
                    string catName = Console.ReadLine();
                    animals.Add(new Cat(age, catName));
                    break;
                case 2:
                    bool isfriendly = true;
                    Console.Write("Is the dog friendly....1 for yes or 2 for no: ");
                    int friendly = Convert.ToInt32(Console.ReadLine());
                    if(friendly == 1){
                        isfriendly = true;
                    }
                    if(friendly == 2){
                        isfriendly = false;
                    }
                    Console.WriteLine("What is the dog's name: ");
                    string dogName = Console.ReadLine();
                    animals.Add(new Dog(isfriendly, dogName));
                    break;
                default:
                    animals.Add(new Cat(10, "Chester"));
                    break;
            }
            return animals;
        }
    }
}