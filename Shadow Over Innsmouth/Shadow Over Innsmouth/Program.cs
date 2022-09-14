namespace story
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that introducitons are over, lets get some basic info from the reader.
            Console.WriteLine("What is your name? ([first] or [first last])");
            string name = NameFull(Console.ReadLine());

            //Assign Stats
            Console.WriteLine("Alright, now time to assign your stats.");
            Console.WriteLine("You have 18 points to devide between 'Vitality', 'Speed', and 'Smarts'.");
            string[] stats = new string[] { "Vitality", "Speed", "Smarts" };
            int[] statValues = new int[3];
            bool acceptableStats = true;
            int a = 0;
           
            //Check to see if they're acceptable
            while (acceptableStats)
            {
                if (statValues[0] + statValues[1] + statValues[2] != 18)
                {
                    Stats(stats, statValues);
                    StatValueChecker(statValues);
                }
                else
                {
                    acceptableStats = false;
                }
            } 
            
            while (a <= 2)
            {
                Console.WriteLine($"{stats[a]}: {statValues[a]}");
                a++;
            }
            int vitalityValue = statValues[0];
            int speedValue = statValues[1];
            int smartsValue = statValues[2];
            
            string[] description = TraitAssigner(statValues);
            Console.WriteLine($"You are a(n) {description[0]}, {description[1]}, {description[2]} pirate, good luck!");

            Console.WriteLine($"Alrighty {name}, let yer voyage begin.");
            //Skull and bones and intro
            Console.WriteLine(" ");
            Console.WriteLine("            ______");
            Console.WriteLine("           /      \\");
            Console.WriteLine("          | []  [] |");
            Console.WriteLine("      |\\   \\  /\\  /    /|");
            Console.WriteLine("       \\\\   |    |    //");
            Console.WriteLine("         \\\\ ||||||  // ");
            Console.WriteLine("           \\\\     //");
            Console.WriteLine("             \\\\ //");
            Console.WriteLine("            --- ---");
            Console.WriteLine("            //   \\\\");
            Console.WriteLine("           (-)   (-)");
            Console.WriteLine(" PREPARE TO EMBARK ON YER JOURNEY,");
            Console.WriteLine("AND FACE THE TERRORS OF THE 7 SEAS!");


        }
        //This will take the name entered and capitalize the first letter of each name, unless they provide more than two :/
        public static string NameFull(string nameRaw)
        {
            string Fname = "";
            string Lname = "";
            if (nameRaw.Contains(" ") == true)
            {
                string[] names = nameRaw.Split(' ');
                Fname = char.ToUpper(names[0][0]) + names[0].Substring(1);
                Lname = " " + char.ToUpper(names[1][0]) + names[1].Substring(1);
            }
            else
            {
                Fname = char.ToUpper(nameRaw[0]) + nameRaw.Substring(1);
            }
            return Fname + Lname;
        }
        //This will allow the user to assign their stats
        public static void Stats(string[] statName, int[] statValue)
        {
            int x = 0;
            bool validResponse = false;
            foreach (string stat in statName)
            {
                do
                {
                    Console.WriteLine($"Enter your {stat} value.");
                    validResponse = int.TryParse(Console.ReadLine(), out statValue[x]);
                }
                while (validResponse == false);
                x++;
            }

        }

        //Check to see if the stat totals are good or not
        public static void StatValueChecker(int[] statInputValues)
        {
            if (statInputValues[0] + statInputValues[1] + statInputValues[2] == 18)
            {
                Console.WriteLine("Good assignment, yer ready to sail the seas.");
            }
            else if (statInputValues[0] + statInputValues[1] + statInputValues[2] < 18)
            {
                Console.WriteLine("It appears you are missin some stat points.");
            }
            else
            {
                Console.WriteLine("Ye scurvy dog, yer not that special! Ye need to be more realistic.");
            }
        }

        //Give the pirate some personalized traits
        public static string[] TraitAssigner(int[] statValueAccepted)
        {

            string vitalityTrait;
            string speedTrait;
            string smartsTrait;

            switch (statValueAccepted[0])
            {
                case <= 2:
                    vitalityTrait = "Weak";
                    break;
                case <= 4:
                    vitalityTrait = "Skinny";
                    break;
                case <= 6:
                    vitalityTrait = "Muscled";
                    break;
                case <= 8:
                    vitalityTrait = "Burley";
                    break;
                case <= 10:
                    vitalityTrait = "Enormous";
                    break;
                case > 10:
                    vitalityTrait = "Gigantic";
                    break;
                default:
                    break;
            }
            switch (statValueAccepted[1])
            {
                case <= 2:
                    speedTrait = "Sluggish";
                    break;
                case <= 4:
                    speedTrait = "Slow";
                    break;
                case <= 6:
                    speedTrait = "Coordinated";
                    break;
                case <= 8:
                    speedTrait = "Nimble";
                    break;
                case <= 10:
                    speedTrait = "Acrobatic";
                    break;
                case > 10:
                    speedTrait = "Lightning-fast";
                    break;
                default:
                    break;
            }
            switch (statValueAccepted[2])
            {
                case <= 2:
                    smartsTrait = "Rock-Eater";
                    break;
                case <= 4:
                    smartsTrait = "Confused";
                    break;
                case <= 6:
                    smartsTrait = "Intelligent";
                    break;
                case <= 8:
                    smartsTrait = "Genius";
                    break;
                case <= 10:
                    smartsTrait = "Prodogy";
                    break;
                case > 10:
                    smartsTrait = "Accended";
                    break;
                default:
                    break;
            }
            return new string[] {vitalityTrait, speedTrait, smartsTrait};
        }
    }
}
