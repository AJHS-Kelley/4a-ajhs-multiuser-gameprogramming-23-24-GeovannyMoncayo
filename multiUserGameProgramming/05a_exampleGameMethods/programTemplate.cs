// Geovanny Moncayo, Program Template, v0.0

using System;
using System.Collections;

namespace Operators
{
    class Program

    {   
        static bool canCraft (object item = "none")
        {
            if (item = "none")
            {
                Console.WriteLine("Please input an item to craft")
                return false;
            }
            else if (item = "sandwich")
            {
                int breadCount = 0;
                int hamCount = 0;
                foreach (object thing in Inventory)
                {
                    if (System.ToString(thing) == "bread")
                    {
                        breadCount = breadCount + 1;
                    }
                }
                foreach (object thing in Inventory)
                {
                    if (System.ToString(thing) == "ham")
                    {
                        hamCount = hamCount + 1;
                    }
                }
                if (breadCount >= 2 && hamCount >= 1)
                {
                    return true;
                }
                else if (breadCount > 2 && hamCount > 1)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Error Code: sandwich canCraft count");
                    return false;
                }
            }
            else if (item = "sticks")
            {
                int woodCount = 0;
                foreach (object thing in Inventory)
                {
                    if (System.ToString(thing) == "bread")
                    {
                        woodCount = woodCount + 1;
                    }
                }
                if (woodCount >= 1)
                {
                    return true;
                }
                else if (woodCount < 1)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Error Code: stick canCraft count");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Error Code: canCraft");
            }
            

        }
        static bool pickUp(object item = "none")
        {
            if (item = "none")
            {
                Console.WriteLine("Please input an item to pickUp");
                return false;
            }
            var checkList = checkInventory(Inventory);
            for(int i = 0; int <= checkList; i++)
            {
                
                int itemCount = System.ToInt32(checkList[i+1]);
                
                if (item == checkList[i])
                {
                    if (itemCount == 10)
                    {
                        return false;
                    }
                    else if (itemCount > 10)
                    {
                        for(int x = 0; x <= itemCount-10; x++)
                        {
                            Inventory.Remove(item);
                            Console.WriteLine("Items removed");
                        }
                        return false;
                    }
                    else if (itemCount < 10)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error Code: for pickUp");
                    }
                }
            }
            Console.WriteLine("Error Code: pickUp");
            return false;
        }
        static void craft(object item = "none")
        {
            string itemString = System.ToString(item)
            if (item = "none")
            {
                Console.WriteLine("Please input an item to craft");
                return false;
            }
            if (canCraft(item) == true)
            {
                if (itemString == "sandwich")
                {
                    Inventory.Remove("bread");
                    Inventory.Remove("bread");
                    Inventory.Remove("ham");
                    Inventory.Add("sandwich");
                }
                else if (item string == "sticks")
                {
                    Inventory.Remove("wood");
                    Inventory.Add("sticks");
                }
                else
                {
                    Console.WriteLine("Error Code: craft");
                }
                Console.WriteLine(itemString + " added to your inventory");
            }
            else if (canCraft(item) == false)
            {
                Console.WriteLine("You can't craft this");
            }
        }
        static ArrayList checkInventory (ArrayList Inventory)
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
                    //foreach(var item in checkList)
                    //{
                    //    Console.WriteLine("first " + item);
                    //}
                    for (int x = 0; x < Inventory.Count; x++)
                    {
                        if(Inventory.Contains(conItem))
                        {
                            amount++;
                            Inventory.Remove(x);
                            //Console.WriteLine("second " + conItem);
                            //Console.WriteLine("second " + amount);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    checkList.Add(amount);
                }
            }
            
            
            // Goes through each item in the Inventory List
            
            
            /*
            foreach (var item in inventory)
            {
                // Goes through each item in the Check List
                var totalItem = checkList.Count(s => s == item);
                if (totalItem == 0)
                {
                    checkList.Add(item);
                    checkList.Add(inventory.Count(y => y == item));
                }
                
                
                for(int y = 0; y < checkList.Count; y++)
                {
                    Console.WriteLine("Hello");
                    // Checks if Inventory item is in checkList
                    
                    
                    
                    if(inventory[x] != checkList[y])
                    {
                        // If inventory item is not in checkList, it is added to the list and a default number 1 is added
                        checkList.Add(inventory[x]);
                        checkList.Add(1);
                    }
                    else
                    {
                        // If inventory item is in the checkList
                        for(int i = 0; i < inventory.Count-1; i++)
                        {
                            if (inventory[x] == inventory[i])
                            {
                                Console.WriteLine(inventory[i]);
                                inventory[i+1] = Convert.ToInt32(inventory[i+1]);
                            }
                        }
                    }
                    
                    
                }
                
                
            }
            */
            //Console.WriteLine("You have:" + string.Join(":\n", checkList));
            for(int z = 0; z < checkList.Count-1; z++)
            {
                Console.WriteLine(checkList[z]);
            }
            return checkList;
        }






        static void Main(string[] args)
        {
            var myInventory = new ArrayList()
            {
                "Wood", "Wood", "Stone", "Stone", "x", "x", "x", "x"
            };
            checkInventory(myInventory);
            
        }
        
    }
}



/*
var myInventory = new ArrayList()
{
    "Burger", "Wood", "Stone", "Burger", "Burger", "Stone", "Burger"
};

var checkList = new ArrayList()
{
    "Wood", 1, "Stone", 3, "Burger", 4
}
*/

// Code Review by Xavier Oliver