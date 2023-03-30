using System;

class Program
{
    static void Main(string[] args)
    {
        Character playerCharacter;
        List<Gear> equipment = new List<Gear>();
        Combat fight;
        RecordHub records = new RecordHub();

        Console.WriteLine("Welcome to D&D Character and Combat Manager!");

        bool endLoop = false;
        string playerChoice;

        string characterName = "";
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;

        //Character Creation and Loading options and processes
        do
        {
            Console.WriteLine("Would you like to load or make a new Character? ");
            Console.Write("Enter 'L' for load or 'N' for new: ");
            playerChoice = Console.ReadLine();

            //Loads a previously made Character
            if(playerChoice.ToUpper() == "L")
            {
                Console.Write("Enter the character's name: ");
                characterName = Console.ReadLine();
                records.LoadCharacter(characterName);

                endLoop = true;
            }

            else if(playerChoice.ToUpper() == "N")
            {
                Console.Write("What is your new character's name? ");
                characterName = Console.ReadLine();

                Console.WriteLine("Would you like to roll for stats or manually enter them?");
                Console.Write("Enter 'R' for rolled (suggested) or 'M' for manual: ");
                playerChoice = Console.ReadLine();

                while(playerChoice != "R" || playerChoice != "M")
                {
                    //Roll for Stats option
                    if(playerChoice.ToUpper() == "R")
                    {
                        playerCharacter = new Character(characterName);
                    }

                    //Manual entry for Stats option
                    else if(playerChoice.ToUpper() == "M")
                    {
                        Console.WriteLine("Strength is your ability to crush a tomato.");
                        Console.Write("Enter your strength (min 1 - max 20):");
                        playerChoice = Console.ReadLine();
                        strength = int.Parse(playerChoice);

                        Console.WriteLine("Dexterity is your ability to dodge a thrown tomato.");
                        Console.Write("Enter your dexterity (min 1 - max 20):");
                        playerChoice = Console.ReadLine();
                        dexterity = int.Parse(playerChoice);

                        Console.WriteLine("Constitution is your ability to eat a rotten tomato.");
                        Console.Write("Enter your constitution (min 1 - max 20):");
                        playerChoice = Console.ReadLine();
                        constitution = int.Parse(playerChoice);

                        Console.WriteLine("Intelligence is knowing that a tomato is a fruit.");
                        Console.Write("Enter your intelligence (min 1 - max 20):");
                        playerChoice = Console.ReadLine();
                        intelligence = int.Parse(playerChoice);

                        Console.WriteLine("Wisdom is knowing not to put a tomato in a fruit salad.");
                        Console.Write("Enter your wisdom (min 1 - max 20):");
                        playerChoice = Console.ReadLine();
                        wisdom = int.Parse(playerChoice);

                        Console.WriteLine("Charisma is your ability to sell a tomato based fruit salad.");
                        Console.Write("Enter your charisma (min 1 - max 20):");
                        playerChoice = Console.ReadLine();
                        charisma = int.Parse(playerChoice);

                        playerCharacter = new Character(characterName, strength, dexterity, constitution, intelligence, wisdom, charisma);
                    }

                    //For User Error
                    else
                    {
                        Console.Write("Enter 'R' for rolled (suggested) or 'M' for manual: ");
                        playerChoice = Console.ReadLine();
                    }
                }
                endLoop = true;
            }

            //For User Error
            else Console.WriteLine("Please enter in either 'L' or 'N'.");

        }while(endLoop);
        endLoop = false;
        Console.Clear();

        //Character equipment, combat, and saving options and processes
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1. Add Adventure Gear");
            Console.WriteLine(" 2. Change Equipment");
            Console.WriteLine(" 3. Combat");
            Console.WriteLine(" 4. Save Character");
            Console.WriteLine(" 5. Quit");
            Console.Write("Enter your number: ");
            playerChoice = Console.ReadLine();

            //Adds Equipment to a Character with Gear
            if(playerChoice == "1")
            {
                string playerEquiptChoice;
                do
                {
                    Console.WriteLine("Choose what you would like to add:");
                    Console.WriteLine(" 1. A Melee Weaopn");
                    Console.WriteLine(" 2. A Ranged Weapon");
                    Console.WriteLine(" 3. Armor");
                    Console.WriteLine(" 4. All Three");
                    Console.Write("Enter your number: ");
                    playerEquiptChoice = Console.ReadLine();

                    //New Melee Weapon
                    if(playerEquiptChoice == "1")
                    {
                        equipment.Add(new MeleeWeapons());
                    }

                    //New Ranged Weapon
                    else if(playerEquiptChoice == "2")
                    {
                        equipment.Add(new RangedWeapons());
                    }

                    //New Armor
                    else if(playerEquiptChoice == "3")
                    {
                        equipment.Add(new Armors());
                    }

                    //New Melee Weapon, Ranged Weapon, and Armor
                    else if(playerEquiptChoice == "4")
                    {
                        equipment.Add(new MeleeWeapons());
                        equipment.Add(new RangedWeapons());
                        equipment.Add(new Armors());
                    }

                    else Console.WriteLine("please enter a number from the menu.");
                }while(playerEquiptChoice != "1" || playerEquiptChoice != "2" ||playerEquiptChoice != "3" ||playerEquiptChoice != "4");
            }

            //Allows User to Change Equipped Gear
            else if(playerChoice == "2")
            {

            }

            //Both Melee and Ranged Combat options
            else if(playerChoice == "3")
            {

            }

            //Save Character and it's Equippment
            else if(playerChoice == "4")
            {
                records.SaveCharacter(characterName);
            }

            //Quit
            else if(playerChoice == "5")
            {
                Console.WriteLine("Thank You, plese come again!");
                endLoop = true;
            }

            //For User Error
            else 
            {
                Console.WriteLine("Please enter a number from the Menu.");
                Thread.Sleep(1000);
            }

            Console.Clear();
        }while(endLoop);
    }
}