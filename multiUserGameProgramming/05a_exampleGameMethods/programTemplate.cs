// Geovanny Moncayo, Program Template, v0.0

using System;
using System.Collections;

namespace Operators
{
    class Program

    {   
        static bool canCraft (object item, ArrayList Inventory)
        {
            var itemString = System.Convert.ToString(item);
            if (itemString == "sandwich")
            {
                int breadCount = 0;
                int hamCount = 0;
                foreach (object thing in Inventory)
                {
                    if (System.Convert.ToString(thing) == "bread")
                    {
                        breadCount = breadCount + 1;
                    }
                }
                foreach (object thing in Inventory)
                {
                    if (System.Convert.ToString(thing) == "ham")
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
            else if (itemString == "sticks")
            {
                int woodCount = 0;
                foreach (object thing in Inventory)
                {
                    if (System.Convert.ToString(thing) == "bread")
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
                return false;
            }
            

        }
        static bool pickUp(object item, ArrayList Inventory)
        {
            
            var checkList = checkInventory(Inventory);
            for(int i = 0; i <= checkList.Count; i++)
            {
                
                int itemCount = System.Convert.ToInt32(checkList[i+1]);
                
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
        static void craft(object item, ArrayList Inventory)
        {
            string itemString = System.Convert.ToString(item);
            if (canCraft(item, Inventory) == true)
            {
                if (itemString == "sandwich")
                {
                    Inventory.Remove("bread");
                    Inventory.Remove("bread");
                    Inventory.Remove("ham");
                    Inventory.Add("sandwich");
                }
                else if (itemString == "sticks")
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
            else if (canCraft(item, Inventory) == false)
            {
                Console.WriteLine("You can't craft this");
            }
        }
        static ArrayList checkInventory (ArrayList InventoryList)
        {
            var checkList = new ArrayList();
            //cycles through all items in Inventory
            var Inventory = InventoryList;
            // for (int i = 0; i < Inventory.Count; i++)
            int i = 0;
            while (true)
            {
                string checkedItem = System.Convert.ToString(Inventory[i]);
                if (i < Inventory.Count)
                {
                //If the checkList doesn't contain the item, for example "Stone", then it would skip it and go onto "Wood"
                    if (checkList.Contains(checkedItem) == false)
                    {
                        // Adds "Stone" to checkList
                        // checkList.Add(checkedItem);
                        // sets "Stone to object conItem
                        string conItem = checkedItem;
                        // Inventory.Remove(conItem);
                        // Console.WriteLine(conItem + " Removed");
                        var amount = 1;
                        //foreach(var item in checkList)
                        //{
                        //    Console.WriteLine("first " + item);
                        //}
                        
                        //for (int x = 0; x < Inventory.Count-1; x++)
                        int x = 0;
                        while (true)
                        {
                            
                            if (x >= Inventory.Count-1)
                            {
                                break;
                            }
                            else if (x < Inventory.Count-1)
                            {
                                if(Inventory.Contains(conItem) == true)
                                {
                                    amount++;
                                    Inventory.Remove(conItem);
                                    Console.WriteLine(conItem + " Removed");
                                    
                                    
                                    //Console.WriteLine("second " + conItem);
                                    //Console.WriteLine("second " + amount);
                                    
                                }
                                // else if (Inventory.Contains(conItem) == false)
                                // {
                                //     Console.WriteLine("rep");
                                //     continue;
                                    
                                // }
                            }
                            x++;
                            
                        }
                        checkList.Add(amount);
                        Console.WriteLine(amount);
                    }
                }
                else if (i >= Inventory.Count)
                {
                    break;
                }
                i++;
                Console.WriteLine("cl beg");
                foreach (object thingy in Inventory)
                {
                    Console.WriteLine(thingy);
                }
                Console.WriteLine("cl end");
                
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
            
            for(int z = 0; z < checkList.Count; z++)
            {
                Console.WriteLine(checkList[z]);
            }
            return checkList;
        }






        static void Main(string[] args)
        {
            var myInventory = new ArrayList()
            {
                "Wood", "Wood", "Stone", "Stone", "x", "x", "Stone", "x", "x"
            };
            checkInventory(myInventory);
            
            // for (int i = 0; i < myInventory.Count; i++)
            // {
            //     Console.WriteLine("Item " + i);
            // }
            
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
    "Wood", 1, "Stone", 2, "Burger", 4
}
*/
