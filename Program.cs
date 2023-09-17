using static System.Net.Mime.MediaTypeNames;

namespace KidsFair 
{
    class pet 
    {
        private string petName; // It is a string variable for pet's name
        private int petAge; // It is an int variable for pet's age
        private bool petIsFemale;   // It is a boolean variable for pet's gender

        public void start()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Greeting to my pets class!\n");
            ReadAndSavePetData();
            DisplayData();
        }

        public void ReadAndSavePetData() // This method is for getting all needed data from the users
        {
            ReadNam();
            ReadAge();
            ReadGender();
        }
        public void ReadNam()  // This method get the name from user
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("what is the name of your pet? ");
            petName = Console.ReadLine();
        }
        public void ReadAge() // This method get the age from user
        {
            Console.Write("How old is " + petName + "? ");
            petAge = int.Parse(Console.ReadLine());
        }
        public void ReadGender() // This method get the gender from user
        {
            Console.Write("Is your pet, " + petName + " a female (Y/N)? ");
            string answer = Console.ReadLine();
            if ((answer[0] == 'y') || (answer[0] == 'Y'))
            {
                petIsFemale = true;
            }
            else
            {
                petIsFemale = false;
            }
        }
        public void DisplayData() // This method shows all needed data on the screen
        {
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("********************************");
            Console.WriteLine("Name: " + petName + " Age: " + petAge);
            if (petIsFemale)
            {
                Console.WriteLine(petName + " is a good girl!");
            }
            else
            {
                Console.WriteLine(petName + " is a good boy!");
            }
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Album
    {
        private string albumName;
        private string artistName;
        private int numberOfTracks;
        public void albumstart()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Starting the Album program!");
            ReadAndSaveAlbumData();
            DisplayAlbumData();
        }

        public void ReadAndSaveAlbumData() // This method is for getting all needed data from the users
        {
            ReadAlbumNam();
            ReadAlbumArist();
            ReadNumberOfTrucks();
        }
        public void ReadAlbumNam()  // This method get the album's name from user
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("what is the name of your favourit music Album?");
            albumName = Console.ReadLine();
        }
        public void ReadAlbumArist() // This method get the artist's name from user
        {
            Console.WriteLine("What is the name of the artist or band for " + albumName + "?");
            artistName = Console.ReadLine();
        }
        public void ReadNumberOfTrucks() // This method get the gender from user
        {
            Console.WriteLine("how many tracks does " + albumName + " have?");
            numberOfTracks = int.Parse(Console.ReadLine());
        }
        public void DisplayAlbumData() // This method shows all needed data on the screen
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Artist/Band: " + artistName);
            Console.WriteLine("Number of tracks: " + numberOfTracks);
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("Enjoy listening!");
        }

    }
    public class TicketSeller
    {
        private string ticketHoldersname;
        private double ticketPrice = 99;
        private int ticketAdultsCount;
        private int ticketKidsCount;
        private double AmountToPay;
        public void TicketSellerStart()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wellcome to KID'S FAIR!\n Children get 75% discount!\n");
            ReadAndSaveTicketData();
            DisplayTicketData();
        }

        public void ReadAndSaveTicketData() // This method is for getting all needed data from the users
        {
            ReadTicketHolderNam();
            ReadTicketCounts();
        }
        public void ReadTicketHolderNam()  // This method get the album's name from user
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("what is your name please:");
            ticketHoldersname = Console.ReadLine();
        }
        public void ReadTicketCounts() // This method get the artist's name from user
        {
            Console.WriteLine("Number of aduslts:");
            ticketAdultsCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of children:");
            ticketKidsCount = int.Parse(Console.ReadLine());
        }
        private double calculating() // This method get the gender from user
        {
            AmountToPay = (ticketAdultsCount * 99) + (ticketKidsCount * 99 * 0.75);
            return AmountToPay;
        }
        public void DisplayTicketData() // This method shows all needed data on the screen
        {
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine(" +++ Your reciept +++");
            Console.WriteLine("+++ Amount to pay = " + calculating());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Thank you " + ticketHoldersname);
        }

    }
    class program 
    {
        static void Main(string[] args) 
        {
            PreparationConsolLook();
            pet petObj = new pet(); 
            petObj.start();
            Console.WriteLine("Press Enter to start nextpart!");
            Console.ReadLine();
            Album album = new Album();
            album.albumstart();
            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.TicketSellerStart();
        }
        static void PreparationConsolLook() 
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Kids' FAIR";
        }
    }
    
}
