using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Diagnostics;

using Microsoft.VisualBasic;

using System.Text.RegularExpressions;
using System.Threading;

using System.Xml;




namespace League_Of_Legends_Rune_Changer {

    public partial class Form1 : Form {

        //Initialise
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            addCoordsToRuneDict();
            LoadRunesXML();
            addDictionaries();
        }


        //Variables
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public bool league_window_exists;
        public int league_window_x;
        public int league_window_y;

        XmlDocument xmlDoc = new XmlDocument();

        public string currentRuneXML;

        //HWND Handle
        IntPtr hwnd;



        //Variables X & Y for Runes
        List<Dictionary<string, string>> allDictionaries = new List<Dictionary<string, string>>();

        Dictionary<string, string> rune_edit_page_name = new Dictionary<string, string>();
        Dictionary<string, string> rune_grid_style_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_path_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_path_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_path_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_path_4 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_path_5 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_1_keystone_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_1_keystone_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_1_keystone_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_2_keystone_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_2_keystone_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_2_keystone_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_3_keystone_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_3_keystone_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_3_keystone_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_4_keystone_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_4_keystone_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_1_row_4_keystone_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_path_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_path_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_path_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_path_4 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_1_keystone_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_1_keystone_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_1_keystone_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_2_keystone_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_2_keystone_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_2_keystone_3 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_3_keystone_1 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_3_keystone_2 = new Dictionary<string, string>();
        Dictionary<string, string> rune_col_2_row_3_keystone_3 = new Dictionary<string, string>();

        //Add Coords to Runes Dict
        public void addCoordsToRuneDict() {

            //Edit page name
                rune_edit_page_name.Add("x", "50");
                rune_edit_page_name.Add("y", "127");

            //GRID
                rune_grid_style_2.Add("x", "75");
                rune_grid_style_2.Add("y", "675");

            //Paths Collumn 1
                rune_col_1_path_1.Add("x", "131");
                rune_col_1_path_1.Add("y", "212");

                rune_col_1_path_2.Add("x", "171");
                rune_col_1_path_2.Add("y", "212");

                rune_col_1_path_3.Add("x", "211");
                rune_col_1_path_3.Add("y", "212");

                rune_col_1_path_4.Add("x", "251");
                rune_col_1_path_4.Add("y", "212");

                rune_col_1_path_5.Add("x", "291");
                rune_col_1_path_5.Add("y", "212");

                //Keystones Collumn 1

                    //Row 1
                        rune_col_1_row_1_keystone_1.Add("x", "144");
                        rune_col_1_row_1_keystone_1.Add("y", "332");

                        rune_col_1_row_1_keystone_2.Add("x", "210");
                        rune_col_1_row_1_keystone_2.Add("y", "332");

                        rune_col_1_row_1_keystone_3.Add("x", "276");
                        rune_col_1_row_1_keystone_3.Add("y", "332");

                    //Row 2
                        rune_col_1_row_2_keystone_1.Add("x", "144");
                        rune_col_1_row_2_keystone_1.Add("y", "430");

                        rune_col_1_row_2_keystone_2.Add("x", "210");
                        rune_col_1_row_2_keystone_2.Add("y", "430");

                        rune_col_1_row_2_keystone_3.Add("x", "276");
                        rune_col_1_row_2_keystone_3.Add("y", "430");


                    //Row 3
                        rune_col_1_row_3_keystone_1.Add("x", "144");
                        rune_col_1_row_3_keystone_1.Add("y", "518");

                        rune_col_1_row_3_keystone_2.Add("x", "210");
                        rune_col_1_row_3_keystone_2.Add("y", "518");

                        rune_col_1_row_3_keystone_3.Add("x", "276");
                        rune_col_1_row_3_keystone_3.Add("y", "518");

                    //Row 4
                        rune_col_1_row_4_keystone_1.Add("x", "144");
                        rune_col_1_row_4_keystone_1.Add("y", "605");

                        rune_col_1_row_4_keystone_2.Add("x", "210");
                        rune_col_1_row_4_keystone_2.Add("y", "605");

                        rune_col_1_row_4_keystone_3.Add("x", "276");
                        rune_col_1_row_4_keystone_3.Add("y", "605");

            //Paths Collumn 2
                rune_col_2_path_1.Add("x", "461");
                rune_col_2_path_1.Add("y", "212");

                rune_col_2_path_2.Add("x", "511");
                rune_col_2_path_2.Add("y", "212");

                rune_col_2_path_3.Add("x", "561");
                rune_col_2_path_3.Add("y", "212");

                rune_col_2_path_4.Add("x", "611");
                rune_col_2_path_4.Add("y", "212");

                //Keystones Collumn 2

                    //Row 1
                        rune_col_2_row_1_keystone_1.Add("x", "470");
                        rune_col_2_row_1_keystone_1.Add("y", "302");

                        rune_col_2_row_1_keystone_2.Add("x", "537");
                        rune_col_2_row_1_keystone_2.Add("y", "302");

                        rune_col_2_row_1_keystone_3.Add("x", "602");
                        rune_col_2_row_1_keystone_3.Add("y", "302");

                    //Row 2
                        rune_col_2_row_2_keystone_1.Add("x", "470");
                        rune_col_2_row_2_keystone_1.Add("y", "380");

                        rune_col_2_row_2_keystone_2.Add("x", "537");
                        rune_col_2_row_2_keystone_2.Add("y", "380");

                        rune_col_2_row_2_keystone_3.Add("x", "602");
                        rune_col_2_row_2_keystone_3.Add("y", "380");


                    //Row 3
                        rune_col_2_row_3_keystone_1.Add("x", "470");
                        rune_col_2_row_3_keystone_1.Add("y", "459");

                        rune_col_2_row_3_keystone_2.Add("x", "537");
                        rune_col_2_row_3_keystone_2.Add("y", "459");

                        rune_col_2_row_3_keystone_3.Add("x", "602");
                        rune_col_2_row_3_keystone_3.Add("y", "459");

        }

        //Add All Dictionaries to only one
        public void addDictionaries() {
            allDictionaries.Add(rune_edit_page_name);
            allDictionaries.Add(rune_grid_style_2);
            allDictionaries.Add(rune_col_1_path_1);
            allDictionaries.Add(rune_col_1_path_2);
            allDictionaries.Add(rune_col_1_path_3);
            allDictionaries.Add(rune_col_1_path_4);
            allDictionaries.Add(rune_col_1_path_5);
            allDictionaries.Add(rune_col_1_row_1_keystone_1);
            allDictionaries.Add(rune_col_1_row_1_keystone_2);
            allDictionaries.Add(rune_col_1_row_1_keystone_3);
            allDictionaries.Add(rune_col_1_row_2_keystone_1);
            allDictionaries.Add(rune_col_1_row_2_keystone_2);
            allDictionaries.Add(rune_col_1_row_2_keystone_3);
            allDictionaries.Add(rune_col_1_row_3_keystone_1);
            allDictionaries.Add(rune_col_1_row_3_keystone_2);
            allDictionaries.Add(rune_col_1_row_3_keystone_3);
            allDictionaries.Add(rune_col_1_row_4_keystone_1);
            allDictionaries.Add(rune_col_1_row_4_keystone_2);
            allDictionaries.Add(rune_col_1_row_4_keystone_3);
            allDictionaries.Add(rune_col_2_path_1);
            allDictionaries.Add(rune_col_2_path_2);
            allDictionaries.Add(rune_col_2_path_3);
            allDictionaries.Add(rune_col_2_path_4);
            allDictionaries.Add(rune_col_2_row_1_keystone_1);
            allDictionaries.Add(rune_col_2_row_1_keystone_2);
            allDictionaries.Add(rune_col_2_row_1_keystone_3);
            allDictionaries.Add(rune_col_2_row_2_keystone_1);
            allDictionaries.Add(rune_col_2_row_2_keystone_2);
            allDictionaries.Add(rune_col_2_row_2_keystone_3);
            allDictionaries.Add(rune_col_2_row_3_keystone_1);
            allDictionaries.Add(rune_col_2_row_3_keystone_2);
            allDictionaries.Add(rune_col_2_row_3_keystone_3);
        }


        //"League of Legends" Window Handle
        public IntPtr getLeagueWindowHandle() {
            hwnd = WinGetHandle("League of Legends");
            return hwnd;
        }

        //Get "League of Legends" Window Coords
        public void getLeagueCoords() {
            getLeagueWindowHandle();
            focusLeagueWindow();
            RECT rct = new RECT();
            league_window_exists = GetWindowRect(hwnd, ref rct);
            league_window_x = rct.Left;
            league_window_y = rct.Top;
        }

        //Unminimize & Bring "League of Legends" on front
        public void focusLeagueWindow() {
            getLeagueWindowHandle();
            ShowWindow(new HandleRef(null, hwnd), SW_RESTORE);
            SetForegroundWindow(hwnd);
        }


        //IDK
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(HandleRef hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr WindowHandle);
        public const int SW_RESTORE = 9;

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public static IntPtr WinGetHandle(string wName) {
            foreach (Process pList in Process.GetProcesses())
                if (pList.MainWindowTitle.Contains(wName))
                    return pList.MainWindowHandle;

            return IntPtr.Zero;
        }

    
        //"Get Coords" Click
        private void get_coords_button_Click(object sender, EventArgs e) {
            getLeagueCoords();
            league_window_exists_textbox.Text = league_window_exists.ToString();
            league_window_x_textbox.Text = league_window_x.ToString();
            league_window_y_textbox.Text = league_window_y.ToString();
        }

        //Left Mouse Click Function
        public void LeftMouseClick(Dictionary<string, string> runeDict) {
            int xpos = Int32.Parse(runeDict["x"]) + league_window_x;
            int ypos = Int32.Parse(runeDict["y"]) + league_window_y;
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }


        //Lux Rune
        public void setLuxRune() {
            LeftMouseClick(rune_grid_style_2);

            LeftMouseClick(rune_col_1_path_2);

            LeftMouseClick(rune_col_1_row_1_keystone_1);
            LeftMouseClick(rune_col_1_row_2_keystone_1);
            LeftMouseClick(rune_col_1_row_3_keystone_3);
            LeftMouseClick(rune_col_1_row_4_keystone_1);

            LeftMouseClick(rune_col_2_path_2);

            LeftMouseClick(rune_col_2_row_1_keystone_3);
            LeftMouseClick(rune_col_2_row_2_keystone_3);
        }

        //Draven Rune
        public void setDravenRune() {
            LeftMouseClick(rune_grid_style_2);

            LeftMouseClick(rune_col_1_path_1);

            LeftMouseClick(rune_col_1_row_1_keystone_1);
            LeftMouseClick(rune_col_1_row_2_keystone_2);
            LeftMouseClick(rune_col_1_row_3_keystone_3);
            LeftMouseClick(rune_col_1_row_4_keystone_1);

            LeftMouseClick(rune_col_2_path_2);

            LeftMouseClick(rune_col_2_row_2_keystone_2);
            LeftMouseClick(rune_col_2_row_3_keystone_3);
        }


        //"Set Rune" Click
        private void set_rune_button_Click(object sender, EventArgs e) {
            getLeagueCoords();
            if (select_rune_comboBox.SelectedIndex > -1) {
                if (select_rune_comboBox.SelectedItem.ToString() == "Draven") {
                    setDravenRune();
                }
                if (select_rune_comboBox.SelectedItem.ToString() == "Lux") {
                    setLuxRune();
                }
            } else {
                MessageBox.Show("Select a rune first!", "Info");
            }
        }

        //Parse Rune from URL
        public void parse_rune_url(string currentRuneXML) {

            getLeagueCoords();

            Regex rgx = new Regex(@"\d{8}$");
            Match match = rgx.Match(currentRuneXML);

            string build_rune_number = match.ToString();

            char[] characters = build_rune_number.ToCharArray();

            List<Dictionary<string, string>> clickOrderRune = new List<Dictionary<string, string>>();

            //Char 1 (0-4)
            if (characters[0].Equals('0')) {
                clickOrderRune.Add(rune_col_1_path_1);
                //Debug.WriteLine(rune_col_1_path_1);
            }

            if (characters[0].Equals('1')) {
                clickOrderRune.Add(rune_col_1_path_2);
                //Debug.WriteLine(rune_col_1_path_2);
            }

            if (characters[0].Equals('2')) {
                clickOrderRune.Add(rune_col_1_path_3);
                //Debug.WriteLine(rune_col_1_path_3);
            }

            if (characters[0].Equals('3')) {
                clickOrderRune.Add(rune_col_1_path_4);
                //Debug.WriteLine(rune_col_1_path_4);
            }

            if (characters[0].Equals('4')) {
                clickOrderRune.Add(rune_col_1_path_5);
                //Debug.WriteLine(rune_col_1_path_5);
            }

            //Char 2 (0-2)
            if (characters[1].Equals('0')) {
                clickOrderRune.Add(rune_col_1_row_1_keystone_1);
                //Debug.WriteLine(rune_col_1_row_1_keystone_1);
            }

            if (characters[1].Equals('1')) {
                clickOrderRune.Add(rune_col_1_row_1_keystone_2);
                //Debug.WriteLine(rune_col_1_row_1_keystone_2);
            }

            if (characters[1].Equals('2')) {
                clickOrderRune.Add(rune_col_1_row_1_keystone_3);
                //Debug.WriteLine(rune_col_1_row_1_keystone_3);
            }

            //Char 3 (0-2)
            if (characters[2].Equals('0')) {
                clickOrderRune.Add(rune_col_1_row_2_keystone_1);
                //Debug.WriteLine(rune_col_1_row_2_keystone_1);
            }

            if (characters[2].Equals('1')) {
                clickOrderRune.Add(rune_col_1_row_2_keystone_2);
                //Debug.WriteLine(rune_col_1_row_2_keystone_2);
            }

            if (characters[2].Equals('2')) {
                clickOrderRune.Add(rune_col_1_row_2_keystone_3);
                //Debug.WriteLine(rune_col_1_row_2_keystone_3);
            }

            //Char 4 (0-2)
            if (characters[3].Equals('0')) {
                clickOrderRune.Add(rune_col_1_row_3_keystone_1);
                //Debug.WriteLine(rune_col_1_row_3_keystone_1);
            }

            if (characters[3].Equals('1')) {
                clickOrderRune.Add(rune_col_1_row_3_keystone_2);
                //Debug.WriteLine(rune_col_1_row_3_keystone_2);
            }

            if (characters[3].Equals('2')) {
                clickOrderRune.Add(rune_col_1_row_3_keystone_3);
                //Debug.WriteLine(rune_col_1_row_3_keystone_3);
            }

            //Char 5 (0-2)
            if (characters[4].Equals('0')) {
                clickOrderRune.Add(rune_col_1_row_4_keystone_1);
                //Debug.WriteLine(rune_col_1_row_4_keystone_1);
            }

            if (characters[4].Equals('1')) {
                clickOrderRune.Add(rune_col_1_row_4_keystone_2);
                //Debug.WriteLine(rune_col_1_row_4_keystone_2);
            }

            if (characters[4].Equals('2')) {
                clickOrderRune.Add(rune_col_1_row_4_keystone_3);
                //Debug.WriteLine(rune_col_1_row_4_keystone_3);
            }

            //Char 6 (0-3)
            if (characters[5].Equals('0')) {
                clickOrderRune.Add(rune_col_2_path_1);
                //Debug.WriteLine(rune_col_2_path_1);
            }

            if (characters[5].Equals('1')) {
                clickOrderRune.Add(rune_col_2_path_2);
                //Debug.WriteLine(rune_col_2_path_2);
            }

            if (characters[5].Equals('2')) {
                clickOrderRune.Add(rune_col_2_path_3);
                //Debug.WriteLine(rune_col_2_path_3);
            }

            if (characters[5].Equals('3')) {
                clickOrderRune.Add(rune_col_2_path_4);
                //Debug.WriteLine(rune_col_2_path_4);
            }

            //Char 7 (0-8)
            if (characters[6].Equals('0')) {
                clickOrderRune.Add(rune_col_2_row_1_keystone_1);
                //Debug.WriteLine(rune_col_2_row_1_keystone_1);
            }

            if (characters[6].Equals('1')) {
                clickOrderRune.Add(rune_col_2_row_1_keystone_2);
                //Debug.WriteLine(rune_col_2_row_1_keystone_2);
            }

            if (characters[6].Equals('2')) {
                clickOrderRune.Add(rune_col_2_row_1_keystone_3);
                //Debug.WriteLine(rune_col_2_row_1_keystone_3);
            }

            if (characters[6].Equals('3')) {
                clickOrderRune.Add(rune_col_2_row_2_keystone_1);
                //Debug.WriteLine(rune_col_2_row_2_keystone_1);
            }

            if (characters[6].Equals('4')) {
                clickOrderRune.Add(rune_col_2_row_2_keystone_2);
                //Debug.WriteLine(rune_col_2_row_2_keystone_2);
            }

            if (characters[6].Equals('5')) {
                clickOrderRune.Add(rune_col_2_row_2_keystone_3);
                //Debug.WriteLine(rune_col_2_row_2_keystone_3);
            }

            if (characters[6].Equals('6')) {
                clickOrderRune.Add(rune_col_2_row_3_keystone_1);
                //Debug.WriteLine(rune_col_2_row_3_keystone_1);
            }

            if (characters[6].Equals('7')) {
                clickOrderRune.Add(rune_col_2_row_3_keystone_2);
                //Debug.WriteLine(rune_col_2_row_3_keystone_2);
            }

            if (characters[6].Equals('8')) {
                clickOrderRune.Add(rune_col_2_row_3_keystone_3);
                //Debug.WriteLine(rune_col_2_row_3_keystone_3);
            }

            //Char 8 (0-8)
            if (characters[7].Equals('0')) {
                clickOrderRune.Add(rune_col_2_row_1_keystone_1);
                //Debug.WriteLine(rune_col_2_row_1_keystone_1);
            }

            if (characters[7].Equals('1')) {
                clickOrderRune.Add(rune_col_2_row_1_keystone_2);
                //Debug.WriteLine(rune_col_2_row_1_keystone_2);
            }

            if (characters[7].Equals('2')) {
                clickOrderRune.Add(rune_col_2_row_1_keystone_3);
                //Debug.WriteLine(rune_col_2_row_1_keystone_3);
            }

            if (characters[7].Equals('3')) {
                clickOrderRune.Add(rune_col_2_row_2_keystone_1);
                //Debug.WriteLine(rune_col_2_row_2_keystone_1);
            }

            if (characters[7].Equals('4')) {
                clickOrderRune.Add(rune_col_2_row_2_keystone_2);
                //Debug.WriteLine(rune_col_2_row_2_keystone_2);
            }

            if (characters[7].Equals('5')) {
                clickOrderRune.Add(rune_col_2_row_2_keystone_3);
                //Debug.WriteLine(rune_col_2_row_2_keystone_3);
            }

            if (characters[7].Equals('6')) {
                clickOrderRune.Add(rune_col_2_row_3_keystone_1);
                //Debug.WriteLine(rune_col_2_row_3_keystone_1);
            }

            if (characters[7].Equals('7')) {
                clickOrderRune.Add(rune_col_2_row_3_keystone_2);
                //Debug.WriteLine(rune_col_2_row_3_keystone_2);
            }

            if (characters[7].Equals('8')) {
                clickOrderRune.Add(rune_col_2_row_3_keystone_3);
                //Debug.WriteLine(rune_col_2_row_3_keystone_3);
            }


            //initial cursor pos
            int cursor_x = Cursor.Position.X;
            int cursor_y = Cursor.Position.Y;

            //edit name
            LeftMouseClick(rune_edit_page_name);
            SendKeys.Send("^a");
            var rune_name_selected = ((Runes_List)runes_listbox.SelectedItem).Name;
            SendKeys.Send(rune_name_selected);
            SendKeys.Send("{ENTER}");

            //select grid
            LeftMouseClick(rune_grid_style_2);

            //click runes
            foreach (var currentRuneClick in clickOrderRune) {
                //Debug.WriteLine(currentRuneClick["x"]);
                //Debug.WriteLine(currentRuneClick["y"]);
                //Debug.WriteLine("");
               LeftMouseClick(currentRuneClick);
                //Thread.Sleep(1000);
            }

            //set cursor to original pos
            Cursor.Position = new Point(cursor_x, cursor_y);


        }

        private void set_rune_from_url_button_Click(object sender, EventArgs e) {
            string rune_url = Microsoft.VisualBasic.Interaction.InputBox("Enter Rune URL", "URL Parser", "", -1, -1);
            //string rune_url = "http://na.leagueoflegends.com/en/featured/preseason-update/8000-8008?build=01102258";

            if (!String.IsNullOrEmpty(rune_url) || !String.IsNullOrWhiteSpace(rune_url)) {
                parse_rune_url(rune_url);

            }

        }


        //Load XML Runes File
        private void LoadRunesXML() {
            xmlDoc.Load("runes_list.xml");

            foreach(XmlNode node in xmlDoc.DocumentElement) {
                string name = node.Attributes["name"].Value;
                string url = node["Url"].InnerText;
                runes_listbox.Items.Add(new Runes_List(name, url));
                //Debug.WriteLine();
            }

        }

        private void runes_listbox_SelectedIndexChanged(object sender, EventArgs e) {

             if( runes_listbox.SelectedIndex != -1 ) {
                currentRuneXML = ((Runes_List)runes_listbox.SelectedItem).Url;
            }

        }

        private void apply_rune_xml_button_Click(object sender, EventArgs e) {

            if (runes_listbox.SelectedIndex != -1) {
                parse_rune_url(currentRuneXML);
            } else {
                MessageBox.Show("Select a rune first!");
            }

        }

        private void add_rune_xml_button_Click(object sender, EventArgs e) {

            //string promptValue = Prompt.ShowDialog("Enter Rune Name", "Add New Rune");
            PromptRune.Show("Enter New Rune", "OK", "CANCEL");

            XmlNode root = xmlDoc.DocumentElement;

            //rune name
            XmlElement newElement = xmlDoc.CreateElement("Rune");
            newElement.SetAttribute("name", PromptRune.add_rune_name);

            //rune url
            XmlElement newElementUrl = xmlDoc.CreateElement("Url");
            newElementUrl.InnerText = PromptRune.add_rune_url;

            //append
            newElement.AppendChild(newElementUrl);

            root.AppendChild(newElement);

            //add to list
            runes_listbox.Items.Add(new Runes_List(PromptRune.add_rune_name, PromptRune.add_rune_url));

            xmlDoc.Save("runes_list.xml");


        }


        //remove rune from list and xml file
        private void remove_rune_xml_button_Click(object sender, EventArgs e) {

            if (runes_listbox.SelectedIndex != -1) {

                var current_selected_item = runes_listbox.Items[runes_listbox.SelectedIndex];
                var current_selected_item_index = runes_listbox.SelectedIndex;

                Debug.WriteLine(current_selected_item_index);

                XmlNodeList runesList = xmlDoc.GetElementsByTagName("Rune");

                var parent = runesList[current_selected_item_index];

                parent.ParentNode.RemoveChild(parent);

                runes_listbox.Items.Remove(current_selected_item);

                xmlDoc.Save("runes_list.xml");

            } else {
                MessageBox.Show("Select a rune first!", "Info");
            }

        }

        private void league_mode_menu_check_CheckedChanged(object sender, EventArgs e) {
            if (league_mode_menu_check.Checked == true) {
                Debug.WriteLine("Menu Mode");

                if (Int32.Parse(allDictionaries[0]["x"]) > 75) {
                    foreach ( var currentDict in allDictionaries ) {
                        currentDict["x"] = (Int32.Parse(currentDict["x"]) - 110).ToString();
                    }
                }

            }
        }

        private void league_mode_in_game_check_CheckedChanged(object sender, EventArgs e) {
            if (league_mode_in_game_check.Checked == true) {
                Debug.WriteLine("In Game Mode");

                foreach( var currentDict in allDictionaries ) {
                    currentDict["x"] = (Int32.Parse(currentDict["x"]) + 110).ToString();
                }

            }
        }


    }


}
