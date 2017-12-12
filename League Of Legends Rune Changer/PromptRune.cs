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

using System.Text.RegularExpressions;

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

            bool goNext = true;

            if ((String.IsNullOrEmpty(add_rune_name) || String.IsNullOrWhiteSpace(add_rune_name))) {
                MessageBox.Show("Please enter a name for the Rune.", "Error");
                goNext = false;
            }

            if ((String.IsNullOrEmpty(add_rune_url) || String.IsNullOrWhiteSpace(add_rune_url))) {
                MessageBox.Show("Please enter the URL for the Rune build.", "Error");
                goNext = false;
            } else {
                string url_pattern = @"(http:\/\/na.leagueoflegends.com\/en\/featured\/preseason-update\/)\d{4}-\d{4}\?build=\d{8}";
                Regex r = new Regex(url_pattern);

                Match m = r.Match(add_rune_url);

                if (m.Success) {
                    //Debug.WriteLine(m);
                }
                else {
                    MessageBox.Show("Please enter a valid URL for the Rune build.", "Error");
                    goNext = false;
                }
            }

            if (goNext == true) {
                result = DialogResult.Yes;
                MsgBox.Close();
            }
        }

    }
}
