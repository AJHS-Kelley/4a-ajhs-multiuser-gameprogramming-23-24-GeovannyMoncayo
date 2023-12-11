// Geovanny Moncayo, Program Template, v0.0

using System;
using System.Collections;

namespace Operators
{
    static class Globals
    {
        public static int maxAmount = 100;
        
        public static object response = "";
    }

    
    class Program

    {   
        static int canCraft (object item, int amount, ArrayList InventoryList)
        {
            var itemString = System.Convert.ToString(item);
            var Inventory = new ArrayList(InventoryList);
            int craftable = 0;
            int unCraftable = 0;
            int setSize = 0;
            for (int q = 0; q < amount; q++)
            {
                if (itemString == "Sandwich")
                {
                    setSize = 1;
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
                        craftable = craftable + setSize;
                    }
                    else if (breadCount < 2 && hamCount < 1)
                    {
                        unCraftable = unCraftable + setSize;
                    }
                    else
                    {
                        Console.WriteLine("Error Code: Sandwich canCraft count");
                    }
                }
                else if (itemString == "Sticks")
                {
                    // if (canPickUp("Sticks", Inventory) == false)
                    // {
                    //     return false;
                    //     Console.WriteLine("You can't craft sticks, you have too many");
                    // }
                    setSize = 2;
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
                        Inventory.Remove("Sticks");
                        Inventory.Remove("Sticks");
                        craftable = craftable + setSize;
                    }
                    else if (woodCount < 1)
                    {
                        unCraftable = unCraftable + setSize;
                        // return 0;
                    }
                    else
                    {
                        Console.WriteLine("Error Code: Sticks canCraft count");
                        // return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Error Code: canCraft // may be caused because item does not exist");
                    // return 0;
                }
            }
            
            // if (setSize > 1 && craftable > 0)
            // {
            //     Console.WriteLine("You can craft " + craftable/setSize + " sets of " + setSize + " of " + item + " // " + craftable + " " + item);
            // }
            // else if (setSize == 0)
            // {
            //     Console.WriteLine("You can craft " + craftable + " " + item);
            // }
            // else if (craftable == 0)
            // {
            //     ;
            // }
            // else
            // {
            //     Console.WriteLine("Error Code: canCraft; craftable OR setSize variable");
            // }
            
            
            // if (unCraftable > 1)
            // {
            //     Console.WriteLine("You can craft " + craftable + " sets of " + setSize + " of " + item + " OR " + craftable/setSize + " " + item);
            // }
            // else if (unCraftable == 0)
            // {
            //     ;
            // }
            // else
            // {
            //     Console.WriteLine("Error Code: canCraft; unCraftable variable");
            // }
            return craftable;
            

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
                    if (item == System.Convert.ToString(checkList[i]))
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
                return amount;
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
            int crafted = 0;
            
            for (int i = 0; i < amount; i++)
            {
                
                if (canCraft(item, 1, Inventory) >= 1)
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
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error Code: craft");
                    }
                    crafted++;
                    
                }
                else if (canCraft(item, 1, Inventory) == 0)
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
            if (crafted > 0)
            {
                Console.WriteLine(crafted + " " + itemString + " added to your inventory");
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
            int cantPickUpInt = num - canPickUp(item, num, Inventory);
            int canPickUpInt = canPickUp(item, num, Inventory);
            
            
            
            for (int i = 0; i < canPickUpInt; i++)
            {
                Inventory.Add(item);
            }
            if (cantPickUpInt > 0)
            {
                Console.WriteLine("Can't pick up " + cantPickUpInt + " " + item);
            }
            if (canPickUpInt > 0)
            {
                Console.WriteLine("You picked up " + canPickUpInt + " " + item);
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
        
        static void playerInput(string type, string consoleMessage)
        {
            
            
            if (type.Equals("yon"))
            {
                string response = "";
                while (response.Equals("YES") != true && response.Equals("NO") != true && response.Equals("Y") != true && response.Equals("N") != true)
                {
                    Console.WriteLine(consoleMessage);
                    response = Console.ReadLine();
                    response = response.ToUpper();
                }
                Globals.response = response;
            }
            else if (type.Equals("num"))
            {
                int value = 0;
                string response = "";
                while (int.TryParse(response, out value) != true)
                {
                    Console.WriteLine(consoleMessage);
                    response = Console.ReadLine();
                }
                Globals.response = System.Convert.ToInt32(response);
            }
            else if (type.Equals("ok"))
            {
                string response = "";
                while (response.Equals("ok") != true && response.Equals("NO") != true && response.Equals("K") != true && response.Equals("N") != true)
                {
                    Console.WriteLine(consoleMessage);
                    response = Console.ReadLine();
                    response = response.ToUpper();
                }
                Globals.response = response;
            }
            else
            {
                return;
            }
            
        }
        
        static bool yon(string type)
        {
            if (type == "yon")
            {
                if (Globals.response.Equals("YES") || Globals.response.Equals("Y"))
                {
                    return true;
                }
                else if (Globals.response.Equals("NO") || Globals.response.Equals("N"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Error Code: yon('yon')");
                    theEnd();
                    return false;
                }
            }
            else if (type == "ok")
            {
                if (Globals.response.Equals("OK") || Globals.response.Equals("K"))
                {
                    return true;
                }
                else if (Globals.response.Equals("NO") || Globals.response.Equals("N"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Error Code: yon('ok')");
                    theEnd();
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Error Code: yon()");
                return false;
                theEnd();
            }
        }
        
        static void theEnd()
        {
            Console.WriteLine("\nWell, what now?\n");
            Console.WriteLine("THE END");
            System.Environment.Exit(0);
        }


        static void Main(string[] args)
        {
            
            // var myInventory = new ArrayList()
            // {
            //     "Wood", "Wood", "Burger", "Stone", "Stone", "x", "x", "Stone", "x", "x", "Sandwich", "Ham", "Bread", "Bread"
            // };
            string yourPath = "";
            var yourInventory = new ArrayList();
            
            // playerInput("yon", "You see a tree, do you want to chop it down? YES OR NO???");
            
            
            
            
            // if (yon() == true)
            // {
            //     Console.WriteLine("Tree chopped");
            //     pickUp("Wood", 5, yourInventory);
            //     yourPath = "treePath";
            // }
            // else if (yon() == false)
            // {
            //     theEnd();
            // }
            // else
            // {
            //     Console.WriteLine("Error Code: treePath Error");
            //     return;
            // }
            
            
            
            
            
            // if(yourPath.Equals("treePath"))
            // {
            //     playerInput("yon", "Do you want to craft some sticks?");
                
            //     if (yon() == true)
            //     {
            //         yourPath = "stickPath";
            //     }
            //     else if (yon() == false)
            //     {
            //         theEnd();
            //     }
            //     else
            //     {
            //         Console.WriteLine("Error Code: stickPath Error");
            //         return;
            //     }
            
                
                
            // }
            // if(yourPath.Equals("stickPath"))
            // {
            //     playerInput("num", "How many?");
            //     craft("Sticks", System.Convert.ToInt32(Globals.response), yourInventory);   
            // }
            
            playerInput("yon", "Do you want to make a Sandwich?");
            if (yon("yon") == true)
            {
                pickUp("Bread", 2, yourInventory);
                pickUp("Ham", 1, yourInventory); 
            }
            else if (yon("yon") == false)
            {
                Console.WriteLine("No Sandwich for you");
                theEnd();
            }
            
            
            playerInput("ok", "Now, craft it");
            if (yon("ok") == true)
            {
                craft("Sandwich", 1, yourInventory);
            }
            else if (yon("ok") == false)
            {
                Console.WriteLine("No Sandwich for you");
                theEnd();
            }
            theEnd();
            
            
            /*
            KEY
            
            canCraft(item, amount, Inventory) [checks if an item is craftable, returns int amount]
            
            canPickUp(item, amount, Inventory) [checks if an item can be picked up, returns int amount]
            
            craft(item, amount, Inventory) [crafts item based on amount, doesn't exceed max amount, voids]
            
            checkInventory(Inventory) [returns converted Inventory Array List as one with each item with corresponding numbers (e.g.; Box, 4, Wood, 3...), returns Array List]
            
            printList(Inventory) [print a list in one line, voids]
            
            pickUp(item, amount, Inventory) [picks up an item with amount, doesn't exceed max inventory, voids]
            
            playerInput(type, consoleMessage) [collects player response based on type (yes or no / integer), voids]
            
            yon() [checks if response in caps version is "YES", "Y", "NO", or "YES" returns bool accordingly]
            
            theEnd() [ends game, voids]
            */
            
            
            // TESTS
            
            // printList(checkInventory(myInventory));
            // craft("Sandwich", myInventory);
            // pickUp("Wood", 1000, myInventory);
            // craft("Sticks", 10, myInventory);
            // printList(checkInventory(myInventory));
            
            
            // for (int i = 0; i < myInventory.Count; i++)
            // {
            //     Console.WriteLine("Item " + i);
            // }
            
            
        }
        
    }
}
