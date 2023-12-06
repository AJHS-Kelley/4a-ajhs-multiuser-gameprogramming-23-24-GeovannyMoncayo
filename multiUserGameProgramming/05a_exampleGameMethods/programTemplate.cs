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
            
            for (int i = 0; Inventory.Count != 0; i++)
            {
                string conItem = System.Convert.ToString(Inventory[0]);
                
                // Console.WriteLine("index: " + i);
                //If the checkList doesn't contain the item, for example "Stone", then it would skip it and go onto "Wood"
                if (checkList.Contains(conItem) == false)
                {
                    
                    
                    var amount = 0;
                    
                    checkList.Add(conItem);
                    
                    for (int j = 0; Inventory.Contains(conItem); j++)
                    {
                        // Console.WriteLine("j: " + j);
                        
                        amount++;
                        Inventory.Remove(conItem);
                        // Console.WriteLine(conItem + " Removed");
                    }
                    
                    checkList.Add(amount);
                    // Console.WriteLine(amount);
                }
                
                
                // Console.WriteLine("cl beg");
                // foreach (object thingy in Inventory)
                // {
                //     Console.WriteLine(thingy);
                // }
                // Console.WriteLine("cl end");
            }

            
            printList(checkList);
            return checkList;
            
        }
        
        static void printList(ArrayList printedList)
        {
            string printedString = "Printed List: ";
            for (int i = 0; i < printedList.Count; i++)
            {
                if (i == 0)
                {
                    printedString = printedString + System.Convert.ToString(printedList[i]);
                }
                else if (i % 2 == 1)
                {
                    printedString = printedString + ": " + System.Convert.ToString(printedList[i]);
                }
                else if (i % 2 == 0)
                {
                    printedString = printedString + ", " + System.Convert.ToString(printedList[i]);
                }
                
            }
            Console.WriteLine(printedString);
        }






        static void Main(string[] args)
        {
            var myInventory = new ArrayList()
            {
                "Wood", "Wood", "Burger", "Stone", "Stone", "x", "x", "Stone", "x", "x", "axe"
            };
            checkInventory(myInventory);
            
            // for (int i = 0; i < myInventory.Count; i++)
            // {
            //     Console.WriteLine("Item " + i);
            // }
            
        }
        
    }
}
