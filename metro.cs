using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MUD
{
 
    public class Room
    {
 
        // Instance variables
        int number;
        string name;
        string description;
        string exits;
        string pexits;
 
        // Constructor declaration of class
        public Room(int number, string name, string description, string exits, string pexits)
        {
            this.number = number;
            this.name = name;
            this.description = description;
            this.exits = exits;
            this.pexits = pexits;
        }
 
        //method 1
        public int getNumber()
        {
            return number;
        }
 
        //method 2
        public string getName()
        {
            return name;
        }
 
        //method 3
        public string getDescription()
        {
            return description;
        }
 
        //method 4
        public string getExits()
        {
            return exits;
        }
 
        //method 5
        public string getPexits()
        {
            return pexits;
        }
 
        public string toString()
        {
            return ("You are in room number: " + this.getNumber() +
            ".\nYou see: " + this.getDescription() +
            ".\nThe name is: " + this.getName() +
            ".\nYou can go to: " + this.getPexits());
        }
 
        public string toStringRoomNumber()
        {
            return ("You are in room number: " + this.getNumber());
        }
 
        public string toStringRoomName()
        {
            return ("You are here: " + this.getName());
        }
 
        public string toStringRoomDescription()
        {
            return ("You see: " + this.getDescription());
        }
 
        public string toStringRoomExits()
        {
            return ("Possible exits: " + this.getPexits());
        }
 
        public static void Main(string[] args)
        {
            int i = 0;
            string newRoom;
            string move;
            List<Room> myList = new List<Room>();
            myList.Add(new Room(1, "Plain", "A green plain.", "E2S4", "E,S"));
            myList.Add(new Room(2, "Hill", "A small hill.", "E3W1", "E,W"));
            myList.Add(new Room(3, "Forest", "A dark and dense forest.", "S6W2", "S,W"));
            myList.Add(new Room(4, "Light forest", "A light forest with some small animals moving around.", "E5S7", "E,S"));
            myList.Add(new Room(5, "Small hill", "A small hill. You can see a big tree in the South.", "N2S8", "N,S"));
            myList.Add(new Room(6, "Small river", "You hear the gurgeling sound of the water.", "N3W5", "N,W"));
            myList.Add(new Room(7, "Lake", "A calm lake with dark water.", "E8", "E"));
            myList.Add(new Room(8, "Clearing", "A clearing. You can see the sky from here.", "N5E9W7", "N,E,W"));
            myList.Add(new Room(9, "Dosh", "A clearing where the ground and some trees are covered by dosh.", "W8S10", "S,W"));
            myList.Add(new Room(10, "Teleporter", "You are standing on a clearing and see a light blue shimmering kind of a portal.", "N9T11", "N,T"));
            myList.Add(new Room(11, "Teleporter", "You are standing on the tower of a castle and see a light blue shimmering kind of a portal.", "T10", "T"));
            //Console.WriteLine(Nummer3.toString() + ".\n");
 
            Console.WriteLine(".\n___*** WELCOME TO KYBORG MUD EARLY ALPHA***___");
            Console.WriteLine(".\nType x end the game..\n");
            while (true)
            {
                //Console.WriteLine(myList[i].toStringRoomNumber());
                Console.WriteLine(myList[i].toStringRoomName());
                Console.WriteLine(myList[i].toStringRoomDescription());
                Console.WriteLine(myList[i].toStringRoomExits());
                string possibleExits = (myList[i].getExits());
                Console.Write(".\nWhere do you want to go? ");
                move = Console.ReadLine().ToUpper();
                if (move == "X")
                    break;
 
                Console.WriteLine(".\nYou entered {0}", move);
                //Check move
                int index = possibleExits.IndexOf(move);
                if (index >= 0)
                {
                    newRoom = "";
                    int lastIndex = possibleExits.Length - 1;
                    int offset = 1;
                    while (index + offset <= lastIndex)
                    {
                        char c = possibleExits[index + offset];
                        if (c >= '0' && c <= '9')
                            newRoom += c;
                        else
                            break;
 
                        offset++;
                    }
 
                    int newRoomNumber = 0;
                    if (Int32.TryParse(newRoom, out newRoomNumber) == true)
                    {
                        //Console.WriteLine("New room = {0}", newRoomNumber);
                        i = newRoomNumber - 1;
 
                        //Console.WriteLine("You can go into this direction!");
                    }
                }
                else
                {
                    Console.WriteLine(".\nYou can't go into this direction");
                }
            }
        }
 
    }

    }

RAW Paste Data
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUD
{

    public class Room
    {

        // Instance variables
        int number;
        string name;
        string description;
        string exits;
        string pexits;

        // Constructor declaration of class
        public Room(int number, string name, string description, string exits, string pexits)
        {
            this.number = number;
            this.name = name;
            this.description = description;
            this.exits = exits;
            this.pexits = pexits;
        }

        //method 1
        public int getNumber()
        {
            return number;
        }

        //method 2
        public string getName()
        {
            return name;
        }

        //method 3
        public string getDescription()
        {
            return description;
        }

        //method 4
        public string getExits()
        {
            return exits;
        }

        //method 5
        public string getPexits()
        {
            return pexits;
        }

        public string toString()
        {
            return ("You are in room number: " + this.getNumber() +
            ".\nYou see: " + this.getDescription() +
            ".\nThe name is: " + this.getName() +
            ".\nYou can go to: " + this.getPexits());
        }

        public string toStringRoomNumber()
        {
            return ("You are in room number: " + this.getNumber());
        }

        public string toStringRoomName()
        {
            return ("You are here: " + this.getName());
        }

        public string toStringRoomDescription()
        {
            return ("You see: " + this.getDescription());
        }

        public string toStringRoomExits()
        {
            return ("Possible exits: " + this.getPexits());
        }

        public static void Main(string[] args)
        {
            int i = 0;
            string newRoom;
            string move;
            List<Room> myList = new List<Room>();
            myList.Add(new Room(1, "Plain", "A green plain.", "E2S4", "E,S"));
            myList.Add(new Room(2, "Hill", "A small hill.", "E3W1", "E,W"));
            myList.Add(new Room(3, "Forest", "A dark and dense forest.", "S6W2", "S,W"));
            myList.Add(new Room(4, "Light forest", "A light forest with some small animals moving around.", "E5S7", "E,S"));
            myList.Add(new Room(5, "Small hill", "A small hill. You can see a big tree in the South.", "N2S8", "N,S"));
            myList.Add(new Room(6, "Small river", "You hear the gurgeling sound of the water.", "N3W5", "N,W"));
            myList.Add(new Room(7, "Lake", "A calm lake with dark water.", "E8", "E"));
            myList.Add(new Room(8, "Clearing", "A clearing. You can see the sky from here.", "N5E9W7", "N,E,W"));
            myList.Add(new Room(9, "Dosh", "A clearing where the ground and some trees are covered by dosh.", "W8S10", "S,W"));
            myList.Add(new Room(10, "Teleporter", "You are standing on a clearing and see a light blue shimmering kind of a portal.", "N9T11", "N,T"));
            myList.Add(new Room(11, "Teleporter", "You are standing on the tower of a castle and see a light blue shimmering kind of a portal.", "T10", "T"));
            //Console.WriteLine(Nummer3.toString() + ".\n");

            Console.WriteLine(".\n___*** WELCOME TO KYBORG MUD EARLY ALPHA***___");
            Console.WriteLine(".\nType x end the game..\n");
            while (true)
            {
                //Console.WriteLine(myList[i].toStringRoomNumber());
                Console.WriteLine(myList[i].toStringRoomName());
                Console.WriteLine(myList[i].toStringRoomDescription());
                Console.WriteLine(myList[i].toStringRoomExits());
                string possibleExits = (myList[i].getExits());
                Console.Write(".\nWhere do you want to go? ");
                move = Console.ReadLine().ToUpper();
                if (move == "X")
                    break;

                Console.WriteLine(".\nYou entered {0}", move);
                //Check move
                int index = possibleExits.IndexOf(move);
                if (index >= 0)
                {
                    newRoom = "";
                    int lastIndex = possibleExits.Length - 1;
                    int offset = 1;
                    while (index + offset <= lastIndex)
                    {
                        char c = possibleExits[index + offset];
                        if (c >= '0' && c <= '9')
                            newRoom += c;
                        else
                            break;

                        offset++;
                    }

                    int newRoomNumber = 0;
                    if (Int32.TryParse(newRoom, out newRoomNumber) == true)
                    {
                        //Console.WriteLine("New room = {0}", newRoomNumber);
                        i = newRoomNumber - 1;

                        //Console.WriteLine("You can go into this direction!");
                    }
                }
                else
                {
                    Console.WriteLine(".\nYou can't go into this direction");
                }
            }
        }

    }
}
