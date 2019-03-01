/* Z1829678 - Christopher Adams
 * Z1805732 - Kevin Lewis 
 *                                      
 * 
 * CSCI 473 - Assignment 3: A LINQ to the Past
 * Form for the Querying System. Allows user see all class types from a single server,
 * see the percentage of each race from a single server, see all role types from a server
 * within a level range, see all guilds of a single type, see all players who could fill
 * a role but presently arent, and see the percentage of max level players
 * */

using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        //Files conataining players and guilds
        public static string PLAYERS_FILE = "players.txt";
        public static string GUILDS_FILE = "guilds.txt";
        //Create Dictionary for Guilds
        public static Dictionary<uint, Guild> dictGuilds = new Dictionary<uint, Guild>();
        //Create Dictionary for Players
        public static Dictionary<uint, Player> dictPlayers = new Dictionary<uint, Player>();
        //Max player level
        public static uint MAX_LEVEL = 60;
        //Races
        public enum Race { Orc, Troll, Tauren, Forsaken };
        //Classes
        public enum Class { Warrior, Mage, Druid, Priest, Warlock, Rogue, Paladin, Hunter, Shaman }
        //Roles
        public enum Role { Tank, Healer, Damage }
        //Server types
        public static string[] arrayType = { "Casual", "Questing", "Mythic+", "Raiding", "PVP" };
        //Servers
        //servers are added when file is read
        public static List<string> listServers = new List<string>();

        //Line for query titles
        public static string LINE = "-------------------------------------------------------------------------------";

        //Players, Guild, Read Players, Read Guilds
        #region
        /*Guild Class
         * creates a guild object with an id and a name
         * */
        public class Guild : IComparable
        {
            //guild vars
            private uint id;
            private string name;
            private string server;
            private uint type;

            //public properties
            #region

            //Free R/W
            public uint Id
            {
                get { return id; }
                set { id = value; }
            }

            //Free R/W
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            //Free R/W
            public string Server
            {
                get { return server; }
                set { server = value; }
            }

            //Free R/W
            public uint Type
            {
                get { return type; }
                private set
                {
                    if (value >= 0 || value <= arrayType.Length - 1)
                        type = value;
                    else
                    {
                        throw new ArgumentException("Not a valid guild type");
                    }
                }
            }

            #endregion

            /*Default constructor 
             * no arguments
             * */
            public Guild() : this(0, 0, "", "")
            {

            }

            /*Default constructor 
             * arguments for id, name, server, and optional type for when file is read
             * */
            public Guild(uint iId, uint iType, string iName, string iServer)
            {
                Id = iId;
                Name = iName;
                Server = iServer;
                Type = iType;
            }

            /* To string
             * Output the guild
             * */
            public override string ToString()
            {
                //Displays the guild id and name
                //string output = String.Format("{0}-{1}", this.Name, this.Server);
                //string output = String.Format("{0, -22}{1, 10}", this.Name, "[" + this.Server + "]");
                string output = String.Format("<{0}>", this.Name);
                return output;
            }

            /*IComparable
            * overrides comparable
            * */
            public int CompareTo(object alpha)
            {
                //Check for null values
                if (alpha == null) return 1;

                //typecast
                Guild rightOp = alpha as Guild;

                //Items are compared by name
                if (rightOp != null)
                    return Name.CompareTo(rightOp.Name);
                else
                    throw new ArgumentException("Guild CompareTo argument is not an item");
            }
        }

        /* Read in Guilds
         * takes the file to get data from
         * put guilds from file into dictionary
         * */
        public static void ReadGuilds(string input)
        {
            //string to read lines into
            string tempLine;
            //try block to catch filenotfound
            try
            {
                using (StreamReader inFile = new StreamReader(input))
                {
                    //priming the read
                    tempLine = inFile.ReadLine();
                    //while there is still data in the file
                    while (tempLine != null)
                    {
                        //get each piece of the guild separated by tab into an array
                        string[] inGuilds = tempLine.Split('\t', '-');
                        //if the correct number of attributes are on the line, create a guild from line
                        if (inGuilds.Length <= 5)
                        {
                            //Create the guild from the array
                            Guild tempGuild = new Guild(Convert.ToUInt32(inGuilds[0]), Convert.ToUInt32(inGuilds[1]), inGuilds[2], inGuilds[3]);
                            //add to dictionary of items
                            dictGuilds.Add(tempGuild.Id, tempGuild);
                            //If a new server is input, add it to the list of servers
                            if (!listServers.Contains(inGuilds[3]))
                            {
                                listServers.Add(inGuilds[3]);
                            }
                        }//end of if length

                        //read next line
                        tempLine = inFile.ReadLine();
                    }//end of while
                }//end of using, items have been read in
            }//end of try
            catch (FileNotFoundException)
            {
                Console.WriteLine(input + "file does not exist");
            }
        }

        /* Players class
         * Player Object has an id, name, race, class, level, exp, guildID
         * */
        public class Player : IComparable
        {
            //attributes of player class
            private uint id;
            private string name;
            private Race playerRace;
            private Class playerClass;
            private Role playerRole;
            private uint level;
            private uint exp;
            private uint guildID;
            //public properties
            #region
            //R only
            public uint Id
            {
                get { return id; }
                private set { id = value; }
            }

            //R only
            public string Name
            {
                get { return name; }
                private set { name = value; }
            }

            //R only, 4 possible races
            public Race PlayerRace
            {
                get { return playerRace; }
                private set
                {
                    if (value >= (Race)0 || value <= (Race)3)
                        playerRace = value;
                    else
                    {
                        throw new ArgumentException(value + " is not a valid race id");
                    }
                }
            }

            //R only, 9 possible classes
            public Class PlayerClass
            {
                get { return playerClass; }
                private set
                {
                    if (value >= (Class)0 || value <= (Class)8)
                        playerClass = value;
                    else
                    {
                        throw new ArgumentException(value + " is not a valid class id");
                    }
                }
            }

            //R only, 3 possible roles
            public Role PlayerRole
            {
                get { return playerRole; }
                private set
                {
                    if (value >= (Role)0 || value <= (Role)2)
                        playerRole = value;
                    else
                    {
                        throw new ArgumentException(value + " is not a valid role id");
                    }
                }
            }

            //Free R/W, [0, MAX_LEVEL]
            public uint Level
            {
                get { return level; }
                set
                {
                    if (value >= 0 || value <= MAX_LEVEL)
                        level = value;
                    else
                    {
                        throw new ArgumentException(value + " is not a valid level");
                    }
                }
            }

            //Normal R access, W acces increments exp and increases level appropriatly
            public uint Exp
            {
                get { return exp; }
                set
                {
                    exp = value;
                }
            }

            //R/W access
            public uint GuildID
            {
                get { return guildID; }
                set { guildID = value; }
            }

            #endregion

            /* Constructor
             * Arguments are id, name, race, class, level, exp, and guildID
             * */
            public Player(uint iID, string iName, Race iPlayerRace, Class iPlayerClass, Role iPlayerRole, uint iLevel, uint iExp, uint iGuildID = 0)
            {
                Id = iID;
                Name = iName;
                PlayerRace = iPlayerRace;
                PlayerClass = iPlayerClass;
                PlayerRole = iPlayerRole;
                Level = iLevel;
                Exp = iExp;
                GuildID = iGuildID;
            }

            /* Default constructor
             * No arguments
             * */
            public Player() : this(0, "", 0, 0, 0, 0, 0)
            {

            }

            /*To String
             * outputs player name, race, class, level, and guild
             * */
            public override string ToString()
            {
                //Displays the player name, race, level, and guild



                //if the player is in a guild it will say which guild, if not then nothing
                string guildString = "";
                if (dictGuilds.ContainsKey(this.guildID))
                {
                    guildString = "" + dictGuilds[this.guildID];
                }

                string output = String.Format("Name: {0,-15}({1,-9}- {2,-6})   Race: {3,-10} Level: {4,-5}{5}",
                    this.Name, (Class)this.PlayerClass, (Role)this.PlayerRole, (Race)this.PlayerRace, this.Level, guildString);

                /*string output = String.Format("Name: {0}({1}-{2})Race: {3}Level: {4}{5}",
                    this.Name.PadRight(20), raceString.PadRight(10), levelString.PadRight(10), guildString);*/

                return output;
            }

            /*To String
             * outputs player name, race, class, level, and guild
             * */
            public string ToOutPutString()
            {
                //Displays the player name, race, level, and guild
                string raceString = "" + (Race)this.PlayerRace;
                string levelString = "" + this.Level;
                //if the player is in a guild it will say which guild, if not then nothing
                string guildString = "";
                if (dictGuilds.ContainsKey(this.guildID))
                {
                    guildString = "Guild: " + dictGuilds[this.guildID];
                }

                string output = String.Format("Name: {0}Race: {1} Level: {2}{3}", this.Name.PadRight(20), raceString.PadRight(10), levelString.PadRight(10), guildString);

                return output;
            }

            /*IComparable
             * overrides comparable
             * */
            public int CompareTo(object alpha)
            {
                //Check for null values
                if (alpha == null) return 1;

                //typecast
                Player rightOp = alpha as Player;

                //Players are compared by name
                if (rightOp != null)
                    return Name.CompareTo(rightOp.Name);
                else
                    throw new ArgumentException("Player CompareTo argument is not an Player");
            }
        }//end of player class

        /* Read in Players
        * takes the file the players are stored in
        * puts the items into the dictionary
        * */
        public static void ReadPlayers(string input)
        {
            //string to read lines into
            string tempLine;
            //try block to catch filenotfound
            try
            {
                using (StreamReader inFile = new StreamReader(input))
                {
                    //priming the read
                    tempLine = inFile.ReadLine();

                    //while there is still data in the file
                    while (tempLine != null)
                    {
                        //get each piece of the player separated by tab into an array
                        string[] inPlayers = tempLine.Split('\t');
                        //if the correct number of attributes are on the line, create a player from line
                        if (inPlayers.Length == 8)
                        {
                            //Create the player from the array, convert string to uints and other attributes when necessary
                            Player tempPlayer = new Player(Convert.ToUInt32(inPlayers[0]), inPlayers[1], (Race)Convert.ToUInt32(inPlayers[2]), (Class)Convert.ToUInt32(inPlayers[3]), (Role)Convert.ToUInt32(inPlayers[4]), Convert.ToUInt32(inPlayers[5]), Convert.ToUInt32(inPlayers[6]), Convert.ToUInt32(inPlayers[7]));

                            //add to dictionary of players
                            dictPlayers.Add(tempPlayer.Id, tempPlayer);
                        }//end of if length

                        //read next line
                        tempLine = inFile.ReadLine();
                    }//end of while
                }//end of using, items have been read in
            }//end of try
            catch (FileNotFoundException)
            {
                Console.WriteLine(input + "file does not exist");
            }
        }//readPlayers

        #endregion//end of Guild, ReadGuilds, Player, ReadPlayers


        public Form1()
        {
            InitializeComponent();
            try
            {
                ReadPlayers(PLAYERS_FILE);
                ReadGuilds(GUILDS_FILE);
            }
            catch (ArgumentException readException)
            {
                TextBox_Output.AppendText("error:" + readException);
            }

            //ComboBox_Guild_Server.DataSource = listServers;
            //ComboBox_Player_Race.DataSource = Enum.GetValues(typeof(Race));
            //fill comboboxes
            ComboBox_Class_ClassType.DataSource = Enum.GetValues(typeof(Class));
            ComboBox_Server_ClassType.DataSource = listServers;
            //Create a new context so that it can be selected independlty of other comboboxes also  using listServers
            ComboBox_Server_PercentRace.BindingContext = new BindingContext();
            ComboBox_Server_PercentRace.DataSource = listServers;
            ComboBox_Role_RoleTypes.DataSource = Enum.GetValues(typeof(Role));
            //Create a new context so that it can be selected independlty of other comboboxes also  using listServers
            ComboBox_Server_RoleTypes.BindingContext = new BindingContext();
            ComboBox_Server_RoleTypes.DataSource = listServers;
            ComboBox_GuildType.DataSource = arrayType;

            //Set start value to be nothing
            ComboBox_Class_ClassType.SelectedIndex = -1;
            ComboBox_Server_ClassType.SelectedIndex = -1;
            ComboBox_Server_PercentRace.SelectedIndex = -1;
            ComboBox_Role_RoleTypes.SelectedIndex = -1;
            ComboBox_Server_RoleTypes.SelectedIndex = -1;
            ComboBox_GuildType.SelectedIndex = -1;
        }

        /*Class Type button
         * On click of class type button, find all players of a user defined class type on a server 
         * selected by the user and display them using LINQ
         * */
        private void Button_ClassType_Click(object sender, EventArgs e)
        {
            if (ComboBox_Class_ClassType.SelectedIndex == -1)
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You must choose a class inorder to search for all classes of that type in a server.");
                return;
            }
            else if (ComboBox_Server_ClassType.SelectedIndex == -1)
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You must choose a server inorder to search for all classes of a class type in a server.");
                return;
            }
            else
            {
                //Gets all players on the server of the selected class
                var ClassTypeQuery =
                    from S in dictGuilds
                    where S.Value.Server == (String)ComboBox_Server_ClassType.SelectedItem
                    from P in dictPlayers
                    where P.Value.PlayerClass == (Class)ComboBox_Class_ClassType.SelectedIndex && P.Value.GuildID == S.Value.Id
                    orderby P.Value.Level
                    select P.Key;

                //Title and line
                TextBox_Output.Clear();
                TextBox_Output.AppendText("All Players of the Class " + ComboBox_Class_ClassType.SelectedItem + " in the " + ComboBox_Server_ClassType.SelectedItem + " Server.\n" + LINE + "\n");

                //Print players
                foreach (uint player in ClassTypeQuery)
                {
                    TextBox_Output.AppendText(dictPlayers[player] + "\n");
                }

                //End line and message
                TextBox_Output.AppendText("\nEND RESULTS\n" + LINE);
            }
        }

        /*Count
         * Calculates and returns the number of races or players on a server
         * */
        private int Count(IEnumerable<KeyValuePair<uint, Player>> player)
        {
            int count = 0;

            foreach (KeyValuePair<uint, Player> p in player)
            {
                count++;
            }

            return count;
        }

        /*Percent Race button
         * On click of percent race button, find the percent of a race selected by the user on the server
         * chosen by the user and display the percentage using LINQ
         * */
        private void Button_PercentRace_Click(object sender, EventArgs e)
        {
            if (ComboBox_Server_PercentRace.SelectedIndex == -1)
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You must choose a server inorder to search for the percentage of races in a server.");
                return;
            }
            else
            {   //Declare variables
                int playerNum = 1;
                int[] raceNum = { 0, 0, 0, 0 };

                //Gets all players on the server
                var PlayerQuery =
                    from S in dictGuilds
                    where S.Value.Server == (String)ComboBox_Server_PercentRace.SelectedItem
                    from P in dictPlayers
                    where P.Value.GuildID == S.Value.Id
                    select P;

                //Gets the number of players
                playerNum = PlayerQuery.Count();

                //Gets the players with race == 0
                var Race0Query =
                    from P in PlayerQuery
                    where P.Value.PlayerRace == (Race)0
                    select P;

                //Gets the number of players with the race
                raceNum[0] = Race0Query.Count();

                //Gets the players with race == 1
                var Race1Query =
                    from P in PlayerQuery
                    where P.Value.PlayerRace == (Race)1
                    select P;

                //Gets the number of players with the race
                raceNum[1] = Race1Query.Count();

                //Gets the players with race == 2
                var Race2Query =
                    from P in PlayerQuery
                    where P.Value.PlayerRace == (Race)2
                    select P;

                //Gets the number of players with the race
                raceNum[2] = Race2Query.Count();

                //Gets the players with race == 3
                var Race3Query =
                    from P in PlayerQuery
                    where P.Value.PlayerRace == (Race)3
                    select P;

                //Gets the number of players with the race
                raceNum[3] = Race3Query.Count();

                //Check for divide by zero error
                if (playerNum == 0)
                {
                    playerNum = 1;
                }

                //Title and line
                TextBox_Output.Clear();
                TextBox_Output.AppendText("Percentage of Races in the " + ComboBox_Server_PercentRace.SelectedItem + " Server.\n" + LINE + "\n");

                //Print players
                for (int r = 0; r < raceNum.Length; r++)
                {
                    //TextBox_Output.AppendText((Race)r + ": " + ((float)raceNum[r] / playerNum * 100) + "%\n");
                    TextBox_Output.AppendText(String.Format("{0,-10} {1,8: 0.00%}\n", (Race)r + ":", ((float)raceNum[r] / playerNum)));

                }

                //End line and message
                TextBox_Output.AppendText("\nEND RESULTS\n" + LINE);
            }
        }

        /*Role Types button
         * On click of role types button, find all players of a user specified race from a user specified 
         * server and display them using LINQ
         * */
        private void Button_RoleTypes_Click(object sender, EventArgs e)
        {
            if (ComboBox_Role_RoleTypes.SelectedIndex == -1)
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You must choose a role inorder to search for all classes of that type in a server.");
                return;
            }
            else if (ComboBox_Server_RoleTypes.SelectedIndex == -1)
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You must choose a server inorder to search for all classes of a class type in a server.");
                return;
            }
            else
            {
                //Gets all players of the selected role on the server
                var RoleQuery =
                    from S in dictGuilds
                    where S.Value.Server == (String)ComboBox_Server_RoleTypes.SelectedItem
                    from P in dictPlayers
                    where P.Value.PlayerRole == (Role)ComboBox_Role_RoleTypes.SelectedIndex && P.Value.GuildID == S.Value.Id

                    select P;

                //Gets all players of the selected role within the selected level
                var LevelQuery =
                    from P in RoleQuery
                    where P.Value.Level >= NumUpDown_Min_RoleTypes.Value && P.Value.Level <= NumUpDown_Max_RoleTypes.Value
                    orderby P.Value.Level
                    select P.Key;

                //Title and line
                TextBox_Output.Clear();
                TextBox_Output.AppendText("All Players with the Role " + ComboBox_Role_RoleTypes.SelectedItem + " in the " + ComboBox_Server_RoleTypes.SelectedItem + " Server.\n" + LINE + "\n");

                if (RoleQuery.Equals(null))
                {
                    TextBox_Output.AppendText("No results for current search.\n");
                }
                else
                {
                    //Print players
                    foreach (uint player in LevelQuery)
                    {
                        TextBox_Output.AppendText(dictPlayers[player] + "\n");
                    }
                }

                //End line and message
                TextBox_Output.AppendText("\nEND RESULTS\n" + LINE);
            }
        }

        /*Min_Max_Changed
         * Whenever the value of the numup down boxes are changed, this method is run.
         * Makes sure that the values never go below 1 or above 60(MAX_LEVEL)
         * */
        private void Min_Max_Changed(object sender, EventArgs e)
        {
            //If lower than 1, loop to max level
            if (NumUpDown_Max_RoleTypes.Value < 1)
            {
                NumUpDown_Max_RoleTypes.Value = MAX_LEVEL;
            }
            if (NumUpDown_Min_RoleTypes.Value < 1)
            {
                NumUpDown_Min_RoleTypes.Value = MAX_LEVEL;
            }

            //If over max level, loop to 1
            if (NumUpDown_Max_RoleTypes.Value > MAX_LEVEL)
            {
                NumUpDown_Max_RoleTypes.Value = 1;
            }
            if (NumUpDown_Min_RoleTypes.Value > MAX_LEVEL)
            {
                NumUpDown_Min_RoleTypes.Value = 1;
            }


            //Max cannot be greater than Min
            if (NumUpDown_Min_RoleTypes.Value > NumUpDown_Max_RoleTypes.Value)
            {

                if (NumUpDown_Max_RoleTypes == sender)
                {
                    NumUpDown_Min_RoleTypes.Value = NumUpDown_Max_RoleTypes.Value;
                }
                else
                {
                    NumUpDown_Max_RoleTypes.Value = NumUpDown_Min_RoleTypes.Value;
                }
            }
        }

        /*Fill Role button
         * On click of fill role button, find players that could fill chosen role but do not and display them using LINQ
         * */
        private void Button_FillRole_Click(object sender, EventArgs e)
        {
            //if no radiobutton have been selected inform user and exit
            if (CheckRadio() == -1)
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You must choose a Role to find out which Role could be filled");
                return;
            }
            else
            {
                //get radio button that was checked
                int radio = CheckRadio();

                //gets all the player not in the selected role
                var NotRoleQuery =
                    from P in dictPlayers
                    where P.Value.PlayerRole != (Role)radio
                    orderby P.Value.Level, P.Value.Name
                    select P;

                //Gets Players that can fill tank role
                var TankQuery =
                    from P in NotRoleQuery
                    where P.Value.PlayerClass == (Class)0 || P.Value.PlayerClass == (Class)2 || P.Value.PlayerClass == (Class)6
                    select P.Key;
                //Gets players that can fill healer role
                var HealerQuery =
                    from P in NotRoleQuery
                    where P.Value.PlayerClass == (Class)2 || P.Value.PlayerClass == (Class)3 || P.Value.PlayerClass == (Class)6 || P.Value.PlayerClass == (Class)8
                    select P.Key;
                //Gets players that can fill damage roll
                var DamageQuery =
                    from P in NotRoleQuery
                    where P.Value.PlayerClass == (Class)0 || P.Value.PlayerClass == (Class)6 || P.Value.PlayerClass == (Class)8
                    select P.Key;

                //Title and line
                TextBox_Output.Clear();
                TextBox_Output.AppendText("All Eligible Players Not Fulfilling the " + (Role)CheckRadio() + " Role\n" + LINE + "\n");

                switch (CheckRadio())
                {
                    case 0://if tank button is selected
                        foreach (uint play in TankQuery)
                        {
                            TextBox_Output.AppendText(dictPlayers[play] + "\n");
                        }
                        break;
                    case 1://if healer button is selected
                        foreach (uint play in HealerQuery)
                        {
                            TextBox_Output.AppendText(dictPlayers[play] + "\n");
                        }
                        break;
                    case 2://if damage button is selected
                        foreach (uint play in DamageQuery)
                        {
                            TextBox_Output.AppendText(dictPlayers[play] + "\n");
                        }
                        break;
                    default:
                        TextBox_Output.AppendText("No Players can currently fill the " + (Role)CheckRadio() + " role");
                        break;
                }
                //End line and message
                TextBox_Output.AppendText("\nEND RESULTS\n" + LINE);
            }

        }

        /*CheckRadio
         * Check if a radio button is clicked and returns the number(Role)
         * returns -1 if no radio button checked
         * */
        private int CheckRadio()
        {
            //if the radio button is Tank is selected
            if (RadioButton_Tank_FillRole.Checked)
            {
                return 0;
            }
            else if (RadioButton_Healer_FillRole.Checked)
            {
                return 1;
            }
            else if (RadioButton_Damage_FillRole.Checked)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        /*MaxLevel Click
         * On click displays the percentage of max level of players in a guild
         * */
        private void Button_MaxLevel_Click(object sender, EventArgs e)
        {
            //title and line
            TextBox_Output.Clear();
            TextBox_Output.AppendText("Percentage of Max Level Players in All Guilds\n" + LINE + "\n");
            //Go through each guild
            foreach (Guild maxGuild in dictGuilds.Values)
            {

                //get all player that are in the guild and are max level
                var PercentQuery =
                    from P in dictPlayers
                    where P.Value.GuildID == maxGuild.Id && P.Value.Level == MAX_LEVEL
                    select P;

                var NumQuery =
                    from P in dictPlayers
                    where P.Value.GuildID == maxGuild.Id
                    select P;

                //Number of max level players out of number of players in guild
                float percent = PercentQuery.Count() / (float)NumQuery.Count();

                //If it is not a number, do not show
                if (!float.IsNaN(percent))
                {

                    TextBox_Output.AppendText(String.Format("{0,-30}{1,8: 0.00%}\n\n", maxGuild, percent));
                }
            }
            //End line and message
            TextBox_Output.AppendText("\nEND RESULTS\n" + LINE);
        }

        private void Button_GuildType_Click(object sender, EventArgs e)
        {
            //If nothing is selected
            if (ComboBox_GuildType.SelectedIndex == -1)
            {
                TextBox_Output.Clear();
                TextBox_Output.AppendText("You must select a Guild type ");
                return;
            }
            else
            {
                //title and line
                TextBox_Output.Clear();
                TextBox_Output.AppendText("All " + arrayType[ComboBox_GuildType.SelectedIndex] + "-Type of Guilds\n" + LINE + "\n");

                //Get guilds grouped by 
                var GuildTypeQuery =
                    from G in dictGuilds
                    where G.Value.Type == ComboBox_GuildType.SelectedIndex
                    group G by G.Value.Server;

                foreach (var server in GuildTypeQuery)
                {
                    TextBox_Output.AppendText(server.Key.ToString() + "\n");
                    foreach (var gYes in server)
                    {
                        TextBox_Output.AppendText("\t" + gYes.Value.ToString() + "\n");
                    }
                }
                //End line and message
                TextBox_Output.AppendText("\nEND RESULTS\n" + LINE);
            }
        }
    }
}