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

using System.Drawing.Imaging;
using System.IO;
using System.Web.UI.WebControls;

using AutoUpdaterDotNET;




namespace League_Of_Legends_Rune_Changer {

    public partial class MainForm : Form {

        //Initialise
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            AutoUpdater.OpenDownloadPage = true;
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Start("https://raw.githubusercontent.com/pinguluk/League-Of-Legends-Runes-Reforged-Changer/master/checkUpdate.xml");

            bool fileExists = (System.IO.File.Exists("runes_list.xml") ? true : false);

            //Debug.WriteLine(fileExists);

            if (!fileExists) {
                MessageBox.Show("Can't find the rune list (runes_list.xml). A new file will be created.", "Error");
                // Create a file to write to.
                using (var sw = new StreamWriter(
                    new FileStream("runes_list.xml", FileMode.Create, FileAccess.ReadWrite),Encoding.UTF8)) {
                            sw.WriteLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
                            sw.WriteLine("<root>");
                            sw.WriteLine("</root>");
                            sw.Close();
                        }
            }

            addCoordsToRuneDict();
            LoadRunesXML();
            addDictionaries();
            currentAppVersion.Text = "Version: " + Application.ProductVersion;
        }


        //Variables
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public bool league_window_exists;
        public int league_window_x;
        public int league_window_y;
        public Size league_window_size;

        XmlDocument xmlDoc = new XmlDocument();

        public string currentRuneXML;

        //HWND Handle
        IntPtr hwnd;

        //Variables X & Y for Runes
        List<Dictionary<string, string>> allDictionaries = new List<Dictionary<string, string>>();

        Dictionary<string, string> rune_edit_page_name = new Dictionary<string, string>();
        Dictionary<string, string> rune_save_button = new Dictionary<string, string>();
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

            //Rune save button
            rune_save_button.Add("x", "400");
            rune_save_button.Add("y", "127");

            //Grid
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
            allDictionaries.Add(rune_save_button);
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
            hwnd = FindWindow(null, "League of Legends");
            //hwnd = WinGetHandle("Form1");
            //Debug.WriteLine(hwnd);
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
            league_window_size.Width = rct.Right - rct.Left;
            league_window_size.Height = rct.Bottom - rct.Top;
        }

        //Unminimize & Bring "League of Legends" on front
        public void focusLeagueWindow() {
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

        //cursor
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public static IntPtr FindWindow(string caption) {
            return FindWindow(String.Empty, caption);
        }


        [StructLayout(LayoutKind.Sequential)]
        struct POINT {
            public Int32 x;
            public Int32 y;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO {
            public Int32 cbSize;        // Specifies the size, in bytes, of the structure. 
                                        // The caller must set this to Marshal.SizeOf(typeof(CURSORINFO)).
            public Int32 flags;         // Specifies the cursor state. This parameter can be one of the following values:
                                        //    0             The cursor is hidden.
                                        //    CURSOR_SHOWING    The cursor is showing.
            public IntPtr hCursor;          // Handle to the cursor. 
            public POINT ptScreenPos;       // A POINT structure that receives the screen coordinates of the cursor. 
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO pci);



        //Check Cursor Hover Rune Name Button
        private bool CheckHoverCursor() {

            //wait a bit in case if rune description box appear during that time
            Thread.Sleep(150);

            IntPtr league_hover = new IntPtr(65567); //LoL has custom hover/hand cursor icon
            CURSORINFO pci;
            pci.cbSize = Marshal.SizeOf(typeof(CURSORINFO));
            GetCursorInfo(out pci);

            bool isCursorHover = pci.hCursor == league_hover;
            //Debug.WriteLine("Is hovering: " + isCursorHover);
            return isCursorHover;
        }


        //Check Rune Mode
        public bool checkAndSetRuneMode() {

            //move cursor, if is on hover => in menu
            SetCursorPos(
                Int32.Parse(rune_edit_page_name["x"]) + league_window_x,
                Int32.Parse(rune_edit_page_name["y"]) + league_window_y
            );

            //Menu Mode
            if (CheckHoverCursor()) {
                Debug.WriteLine("Menu Mode");
                if (Int32.Parse(allDictionaries[0]["x"]) > 50) {
                    foreach (var currentDict in allDictionaries) {
                        currentDict["x"] = (Int32.Parse(currentDict["x"]) - 110).ToString();
                    }
                }
              //In Champion Select 
            } else if (!CheckHoverCursor()) {
                ///move cursor over "edit page name" button correspondent to the "in champion select"
                SetCursorPos(
                    Int32.Parse(rune_edit_page_name["x"]) + league_window_x + 110,
                    Int32.Parse(rune_edit_page_name["y"]) + league_window_y
                );
                //check again if it's on hover, if true => in champion select, if not => neither in menu mode nor in champion select
                if (CheckHoverCursor()) {
                    Debug.WriteLine("In Champion Select Mode");
                    if (Int32.Parse(allDictionaries[0]["x"]) < 160) {
                        foreach (var currentDict in allDictionaries) {
                            currentDict["x"] = (Int32.Parse(currentDict["x"]) + 110).ToString();
                        }
                    }
                } else {
                    //neither in menu mode nor in champion select
                    return false;
                }
            }

            return true;

        }


        //Left Mouse Click Function
        public void LeftMouseClick(Dictionary<string, string> runeDict) {
            int xpos = Int32.Parse(runeDict["x"]) + league_window_x;
            int ypos = Int32.Parse(runeDict["y"]) + league_window_y;
            SetCursorPos(xpos, ypos);
            //Debug.WriteLine("xpos:" + xpos + "\n" + "ypos: " + ypos + "\n");
            //Thread.Sleep(500);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }


        //Parse Rune from URL
        public void parse_rune_url(string currentRuneXML) {

            getLeagueCoords();

            //check league
            if (league_window_exists == false) {
                MessageBox.Show("Please start League Of Legends first and enter on a Rune Page", "Error");
                return;
            }

            //check resolution
            if (league_window_size != new Size(1280, 720)) {
                MessageBox.Show(new Form { TopMost = true }, "Set League Client resolution to 1280 x 720 first.", "Error");
                return;
            }

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

            //Debug.WriteLine(league_window_x);
            //Debug.WriteLine(league_window_y);

            if (checkAndSetRuneMode() == true) {

                //edit name
                LeftMouseClick(rune_edit_page_name);
                SendKeys.Send("^a");
                var rune_name_selected = ((Runes_List)runes_listbox.SelectedItem).Name;
                SendKeys.Send(rune_name_selected);
                SendKeys.Send("{ENTER}");

                //wait for name to save
                Thread.Sleep(100);

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

                //click save button
                LeftMouseClick(rune_save_button);

                //set cursor to original pos
                SetCursorPos(cursor_x, cursor_y);
            } else {
                MessageBox.Show(new Form { TopMost = true }, "Go to a Rune Page and try again.", "Error");
            }
        }

        private void set_rune_from_url_button_Click(object sender, EventArgs e) {
            string rune_url = Interaction.InputBox("Enter Rune URL", "URL Parser", "", -1, -1);
            //string rune_url = "http://na.leagueoflegends.com/en/featured/preseason-update/8000-8008?build=01102258";

            if (!String.IsNullOrEmpty(rune_url) || !String.IsNullOrWhiteSpace(rune_url)) {
                parse_rune_url(rune_url);

            }

        }


        //Load XML Runes File
        private void LoadRunesXML() {
            xmlDoc.Load("runes_list.xml");

            foreach (XmlNode node in xmlDoc.DocumentElement) {
                string name = node.Attributes["name"].Value;
                string url = node["Url"].InnerText;
                runes_listbox.Items.Add(new Runes_List(name, url));
            }

        }

        private void runes_listbox_SelectedIndexChanged(object sender, EventArgs e) {

            if (runes_listbox.SelectedIndex != -1) {
                currentRuneXML = ((Runes_List)runes_listbox.SelectedItem).Url;
            }

        }

        private void apply_rune_xml_button_Click(object sender, EventArgs e) {

            if (runes_listbox.SelectedIndex != -1) {
                parse_rune_url(currentRuneXML);
            }
            else {
                MessageBox.Show("Select a rune first!");
            }

        }

        private void add_rune_xml_button_Click(object sender, EventArgs e) {

            //string promptValue = Prompt.ShowDialog("Enter Rune Name", "Add New Rune");

            DialogResult promptReturn = EnterNewRuneForm.Show("Enter New Rune", "OK", "CANCEL");

            if (promptReturn == DialogResult.Yes) {

                XmlNode root = xmlDoc.DocumentElement;

                //rune name
                XmlElement newElement = xmlDoc.CreateElement("Rune");
                newElement.SetAttribute("name", EnterNewRuneForm.add_rune_name);

                //rune url
                XmlElement newElementUrl = xmlDoc.CreateElement("Url");
                newElementUrl.InnerText = EnterNewRuneForm.add_rune_url;

                //append
                newElement.AppendChild(newElementUrl);

                root.AppendChild(newElement);

                //add to list
                runes_listbox.Items.Add(new Runes_List(EnterNewRuneForm.add_rune_name, EnterNewRuneForm.add_rune_url));

                xmlDoc.Save("runes_list.xml");

            }


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

            }
            else {
                MessageBox.Show("Select a rune first!", "Info");
            }

        }


        private void donateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://www.paypal.me/pinguluk");
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/pinguluk/League-Of-Legends-Runes-Reforged-Changer");
        }

        private void creditsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://www.facebook.com/pinguluk");
        }
    }


}
