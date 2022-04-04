using System;
using System.Collections;
using System.IO;

namespace AppConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();
            AddAnimal animal = new AddAnimal();

            try{
                using (StreamReader sr = new StreamReader("animals.txt")){
                    string line;
                    while ((line = sr.ReadLine()) != null){
                        Console.WriteLine(line);
                    }
                }
                } catch (Exception e){
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

            using (StreamWriter sw = new StreamWriter("animals2.txt")){
                foreach (Talkable thing in zoo){
                    sw.WriteLine(thing.GetName() + " | " + thing.Talk());
                }
            }

            zoo.Add(animal.CreateAnimal());

            foreach(Talkable item in zoo){
                Console.WriteLine(item.GetName());
            }
        }
    }

}