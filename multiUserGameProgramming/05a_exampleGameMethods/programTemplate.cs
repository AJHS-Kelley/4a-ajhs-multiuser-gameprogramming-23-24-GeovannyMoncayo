// Geovanny Moncayo, Program Template, v0.0

using System;
using System.Collections;

namespace Operators
{
    class Program

    {   
        static void checkInventory (ArrayList Inventory)
        {
            var checkList = new ArrayList();
            //cycles through all items in Inventory
            for (int i = 0; i < Inventory.Count; i++)
            {
                //If the checkList doesn't contain the item, for example "Stone", then it would skip it and go onto "Wood"
                if (checkList.Contains(Inventory[i]) == false)
                {
                    // Adds "Stone" to checkList
                    checkList.Add(Inventory[i]);
                    // sets "Stone to object conItem
                    object conItem = Inventory[i];
                    Inventory.Remove(conItem);
                    var amount = 1;
                    foreach(var item in checkList)
                    {
                        Console.WriteLine("first " + item);
                    }
                    for (int x = 0; x < Inventory.Count; x++)
                    {
                        if(Inventory.Contains(conItem))
                        {
                            amount++;
                            Inventory.Remove(x);
                            Console.WriteLine("second " + conItem);
                            Console.WriteLine("second " + amount);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    checkList.Add(amount);
                }
            }
            //Console.WriteLine("You have:" + string.Join(":\n", checkList));
            foreach(var item in checkList)
            {
                Console.WriteLine(item);
            }
        }






        static void Main(string[] args)
        {
            var myInventory = new ArrayList()
            {
                "Wood", "Stone", "Stone", "x", "x", "x", "x"
            };
            checkInventory(myInventory);
            
        }
        
    }
}