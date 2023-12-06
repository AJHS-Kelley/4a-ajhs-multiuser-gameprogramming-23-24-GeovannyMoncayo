// Geovanny Moncayo, Program Template, v0.0

using System;
using System.Collections;

namespace Operators
{
    class Program

    {   
        static bool canCraft (object item, ArrayList InventoryList)
        {
            var itemString = System.Convert.ToString(item);
            var Inventory = new ArrayList(InventoryList);
            if (itemString == "Sandwich")
            {
                int breadCount = 0;
                int hamCount = 0;
                foreach (object thing in Inventory)
                {
                    if (System.Convert.ToString(thing) == "Bread")
                    {
                        breadCount = breadCount + 1;
                    }
                }
                foreach (object thing in Inventory)
                {
                    if (System.Convert.ToString(thing) == "Ham")
                    {
                        hamCount = hamCount + 1;
                    }
                }
                if (breadCount >= 2 && hamCount >= 1)
                {
                    return true;
                }
                else if (breadCount < 2 && hamCount < 1)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Error Code: Sandwich canCraft count");
                    return false;
                }
            }
            else if (itemString == "Sticks")
            {
                // if (canPickUp("Sticks", Inventory) == false)
                // {
                //     return false;
                //     Console.WriteLine("You can't craft sticks, you have too many");
                // }
                int woodCount = 0;
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (System.Convert.ToString(Inventory[i]) == "Wood")
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
                    Console.WriteLine("Error Code: Sticks canCraft count");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Error Code: canCraft");
                return false;
            }
            

        }
        static bool canPickUp(object pickItem, ArrayList Inventory)
        {
            
            var checkList = new ArrayList (checkInventory(Inventory));
            string item = System.Convert.ToString(pickItem);
            int maxAmount = 10;
            
            for(int i = 0; i <= checkList.Count-1; i++)
            {
                
                if (item == checkList[i])
                {
                    int itemCount = System.Convert.ToInt32(checkList[i+1]);
                    if (itemCount == maxAmount)
                    {
                        return false;
                    }
                    else if (itemCount > maxAmount)
                    {
                        for(int x = 0; x < itemCount-maxAmount; x++)
                        {
                            Inventory.Remove(item);
                            Console.WriteLine("Items removed");
                        }
                        return false;
                    }
                    else if (itemCount < maxAmount)
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
        
        static void craft(object item, int amount, ArrayList Inventory)
        {
            string itemString = System.Convert.ToString(item);
            for (int i = 0; i < amount; i++)
            {
                
            
                if (canPickUp(item, Inventory) == false)
                {
                    Console.WriteLine("You can't craft " + itemString + " because you have too much");
                }
                if (canCraft(item, Inventory) == true)
                {
                    if (itemString == "Sandwich")
                    {
                        Inventory.Remove("Bread");
                        Inventory.Remove("Bread");
                        Inventory.Remove("Ham");
                        Inventory.Add("Sandwich");
                    }
                    else if (itemString == "Sticks")
                    {
                        Inventory.Remove("Wood");
                        Inventory.Add("Sticks");
                    }
                    else
                    {
                        Console.WriteLine("Error Code: craft");
                    }
                    Console.WriteLine(itemString + " added to your inventory");
                }
                else if (canCraft(item, Inventory) == false)
                {
                    Console.WriteLine("You can't craft: " + itemString);
                }
            }
        }
        
        static ArrayList checkInventory (ArrayList InventoryList)
        {
            var checkList = new ArrayList();
            //cycles through all items in Inventory
            var Inventory = new ArrayList(InventoryList);
            
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
        static void pickUp (object item, int num, ArrayList Inventory)
        {
            int amount = 0;
            for (int i = 0; i < num; i++)
            {
                if (canPickUp(item, Inventory))
                {
                    Inventory.Add(item);
                }
                else if (canPickUp(item, Inventory) == false)
                {
                    amount++;
                }
            }
            if (amount != 0)
            {
                string itemString = System.Convert.ToString(item);
                Console.WriteLine("You can't pick up " + amount + " of the " + itemString);
            }
        }





        static void Main(string[] args)
        {
            
            var myInventory = new ArrayList()
            {
                "Wood", "Wood", "Burger", "Stone", "Stone", "x", "x", "Stone", "x", "x", "Sandwich", "Ham", "Bread", "Bread"
            };
            printList(checkInventory(myInventory));
            // craft("Sandwich", myInventory);
            craft("Sandwich", 1 , myInventory);
            printList(checkInventory(myInventory));
            
            
            // for (int i = 0; i < myInventory.Count; i++)
            // {
            //     Console.WriteLine("Item " + i);
            // }
            
            
        }
        
    }
}
