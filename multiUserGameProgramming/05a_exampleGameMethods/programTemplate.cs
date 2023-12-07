// Geovanny Moncayo, Program Template, v0.0

using System;
using System.Collections;

namespace Operators
{
    static class Globals
    {
        public static int maxAmount = 10;
    }

    
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
        static int canPickUp(object pickItem, int amount, ArrayList Inventory)
        {
            
            var checkList = new ArrayList (checkInventory(Inventory));
            string item = System.Convert.ToString(pickItem);
            int canPickUp = 0;
            int cantPickUp = 0;
            bool contained = false;
            for(int i = 0; i <= checkList.Count-1; i++)
            {
                
                for (int j = 0; j < amount; j++)
                {
                    if (item == checkList[i])
                    {
                        contained = true;
                        int invItemCount = System.Convert.ToInt32(checkList[i+1]);
                        if (invItemCount == Globals.maxAmount)
                        {
                            cantPickUp++;
                        }
                        else if (invItemCount > Globals.maxAmount)
                        {
                            for(int x = 0; x < invItemCount-Globals.maxAmount; x++)
                            {
                                Inventory.Remove(item);
                                Console.WriteLine(item + " removed");
                            }
                            cantPickUp++;
                        }
                        else if (invItemCount < Globals.maxAmount)
                        {
                            canPickUp++;
                            checkList[i+1] = invItemCount + 1;
                            // Console.WriteLine("can pick up" )
                            // return maxAmount - invItemCount;
                        }
                        else
                        {
                            Console.WriteLine("Error Code: for pickUp");
                        }
                    }
                }
                
            }
            if (contained == false)
            {
                return Globals.maxAmount;
            }
            // Console.WriteLine("You CAN'T pick up " + cantPickUp + " " + pickItem);
            // Console.WriteLine("You CAN pick up " + canPickUp + " " + pickItem);
            return canPickUp;
        }
        
        static void craft(object item, int amount, ArrayList Inventory)
        {
            string itemString = System.Convert.ToString(item);
            int cantPickUp = 0;
            int cantCraft = 0;
            for (int i = 0; i < amount; i++)
            {
                
                if (canCraft(item, Inventory) == true)
                {
                    if (itemString == "Sandwich")
                    {
                        if (canPickUp(item, 1, Inventory) >= 1)
                        {
                            Inventory.Remove("Bread");
                            Inventory.Remove("Bread");
                            Inventory.Remove("Ham");
                            Inventory.Add("Sandwich");
                        } 
                        else if (canPickUp(item, 1, Inventory) < 1)
                        {
                            cantPickUp++;
                        }
                    }
                    else if (itemString == "Sticks")
                    {
                        if (canPickUp(itemString, 2, Inventory) >= 2)
                        {
                            Inventory.Remove("Wood");
                            Inventory.Add("Sticks");
                            Inventory.Add("Sticks");
                        }
                        else if (canPickUp(item, 2, Inventory) < 2)
                        {
                            cantPickUp = cantPickUp + 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error Code: craft");
                    }
                    Console.WriteLine(itemString + " added to your inventory");
                }
                else if (canCraft(item, Inventory) == false)
                {
                    cantCraft++;
                }
            }
            if (cantCraft > 0)
            {
                Console.WriteLine("You can't craft " + cantCraft + " " + itemString + " due to insufficient resources");
            }
            if (cantPickUp > 0)
            {
                Console.WriteLine("You can't craft " + cantPickUp + " " + itemString + " due to insufficient inventory space");
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
            // int cantPickUpInt = num - canPickUp(item, num, Inventory);
            int canPickUpInt = canPickUp(item, num, Inventory);
            
            for (int i = 0; i < canPickUpInt; i++)
            {
                Inventory.Add(item);
            }
            
            // if (canPickUp(item, num, Inventory) > 0)
            // {
            //     Inventory.Add(item);
            // }
            // else if (canPickUp(item, 1, Inventory) == 0)
            // {
            //     amount++;
            // }
            // string itemString = System.Convert.ToString(item);
            
            
            // Console.WriteLine("You CAN'T pick up " + cantPickUpInt + " of the " + itemString);
            // Console.WriteLine("You CAN pick up " + canPickUpInt + " of the " + itemString);
        }





        static void Main(string[] args)
        {
            
            var myInventory = new ArrayList()
            {
                "Wood", "Wood", "Burger", "Stone", "Stone", "x", "x", "Stone", "x", "x", "Sandwich", "Ham", "Bread", "Bread"
            };
            printList(checkInventory(myInventory));
            // craft("Sandwich", myInventory);
            pickUp("Wood", 100, myInventory);
            craft("Sticks", 10, myInventory);
            printList(checkInventory(myInventory));
            
            
            // for (int i = 0; i < myInventory.Count; i++)
            // {
            //     Console.WriteLine("Item " + i);
            // }
            
            
        }
        
    }
}
