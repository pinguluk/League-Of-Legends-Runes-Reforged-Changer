using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace League_Of_Legends_Rune_Changer {
    public partial class PromptRune : Form {

        public PromptRune() {
            InitializeComponent();
        }

        static PromptRune MsgBox; static DialogResult result = DialogResult.No;

        public static string add_rune_name;
        public static string add_rune_url;

        public static DialogResult Show(string Text, string btnOK, string btnCancel) {
            MsgBox = new PromptRune();
            //MsgBox.label1.Text = Text;
            //MsgBox.button1.Text = btnOK;
            //MsgBox.button2.Text = btnCancel;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://na.leagueoflegends.com/en/featured/preseason-update#builder");
        }

        private void add_rune_button_Click(object sender, EventArgs e) {
            add_rune_name = add_rune_name_inputbox.Text;
            add_rune_url = add_rune_url_inputbox.Text;
            MsgBox.Close();
        }

    }
}
