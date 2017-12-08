namespace League_Of_Legends_Rune_Changer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.league_window_x_textbox = new System.Windows.Forms.TextBox();
            this.league_window_y_textbox = new System.Windows.Forms.TextBox();
            this.win_pos_x = new System.Windows.Forms.Label();
            this.win_pos_y = new System.Windows.Forms.Label();
            this.get_coords_button = new System.Windows.Forms.Button();
            this.league_window_exists_textbox = new System.Windows.Forms.TextBox();
            this.Exists = new System.Windows.Forms.Label();
            this.set_rune_button = new System.Windows.Forms.Button();
            this.select_rune_comboBox = new System.Windows.Forms.ComboBox();
            this.set_rune_from_url_button = new System.Windows.Forms.Button();
            this.runes_listbox = new System.Windows.Forms.ListBox();
            this.add_rune_xml_button = new System.Windows.Forms.Button();
            this.remove_rune_xml_button = new System.Windows.Forms.Button();
            this.apply_rune_xml_button = new System.Windows.Forms.Button();
            this.league_mode_menu_check = new System.Windows.Forms.RadioButton();
            this.league_mode_in_game_check = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // league_window_x_textbox
            // 
            this.league_window_x_textbox.Location = new System.Drawing.Point(61, 34);
            this.league_window_x_textbox.Name = "league_window_x_textbox";
            this.league_window_x_textbox.Size = new System.Drawing.Size(100, 20);
            this.league_window_x_textbox.TabIndex = 0;
            // 
            // league_window_y_textbox
            // 
            this.league_window_y_textbox.Location = new System.Drawing.Point(61, 60);
            this.league_window_y_textbox.Name = "league_window_y_textbox";
            this.league_window_y_textbox.Size = new System.Drawing.Size(100, 20);
            this.league_window_y_textbox.TabIndex = 1;
            // 
            // win_pos_x
            // 
            this.win_pos_x.AutoSize = true;
            this.win_pos_x.Location = new System.Drawing.Point(40, 37);
            this.win_pos_x.Name = "win_pos_x";
            this.win_pos_x.Size = new System.Drawing.Size(15, 13);
            this.win_pos_x.TabIndex = 2;
            this.win_pos_x.Text = "x:";
            // 
            // win_pos_y
            // 
            this.win_pos_y.AutoSize = true;
            this.win_pos_y.Location = new System.Drawing.Point(40, 63);
            this.win_pos_y.Name = "win_pos_y";
            this.win_pos_y.Size = new System.Drawing.Size(15, 13);
            this.win_pos_y.TabIndex = 3;
            this.win_pos_y.Text = "y:";
            // 
            // get_coords_button
            // 
            this.get_coords_button.Location = new System.Drawing.Point(61, 86);
            this.get_coords_button.Name = "get_coords_button";
            this.get_coords_button.Size = new System.Drawing.Size(75, 23);
            this.get_coords_button.TabIndex = 4;
            this.get_coords_button.Text = "Get Coords";
            this.get_coords_button.UseVisualStyleBackColor = true;
            this.get_coords_button.Click += new System.EventHandler(this.get_coords_button_Click);
            // 
            // league_window_exists_textbox
            // 
            this.league_window_exists_textbox.Location = new System.Drawing.Point(61, 8);
            this.league_window_exists_textbox.Name = "league_window_exists_textbox";
            this.league_window_exists_textbox.Size = new System.Drawing.Size(100, 20);
            this.league_window_exists_textbox.TabIndex = 5;
            // 
            // Exists
            // 
            this.Exists.AutoSize = true;
            this.Exists.Location = new System.Drawing.Point(1, 11);
            this.Exists.Name = "Exists";
            this.Exists.Size = new System.Drawing.Size(58, 13);
            this.Exists.TabIndex = 6;
            this.Exists.Text = "Is Running";
            // 
            // set_rune_button
            // 
            this.set_rune_button.Location = new System.Drawing.Point(196, 58);
            this.set_rune_button.Name = "set_rune_button";
            this.set_rune_button.Size = new System.Drawing.Size(75, 23);
            this.set_rune_button.TabIndex = 7;
            this.set_rune_button.Text = "Set Rune";
            this.set_rune_button.UseVisualStyleBackColor = true;
            // 
            // select_rune_comboBox
            // 
            this.select_rune_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_rune_comboBox.FormattingEnabled = true;
            this.select_rune_comboBox.Items.AddRange(new object[] {
            "Lux",
            "Draven"});
            this.select_rune_comboBox.Location = new System.Drawing.Point(175, 31);
            this.select_rune_comboBox.Name = "select_rune_comboBox";
            this.select_rune_comboBox.Size = new System.Drawing.Size(121, 21);
            this.select_rune_comboBox.TabIndex = 8;
            // 
            // set_rune_from_url_button
            // 
            this.set_rune_from_url_button.Location = new System.Drawing.Point(175, 87);
            this.set_rune_from_url_button.Name = "set_rune_from_url_button";
            this.set_rune_from_url_button.Size = new System.Drawing.Size(121, 23);
            this.set_rune_from_url_button.TabIndex = 9;
            this.set_rune_from_url_button.Text = "Set Rune from URL";
            this.set_rune_from_url_button.UseVisualStyleBackColor = true;
            this.set_rune_from_url_button.Click += new System.EventHandler(this.set_rune_from_url_button_Click);
            // 
            // runes_listbox
            // 
            this.runes_listbox.FormattingEnabled = true;
            this.runes_listbox.Location = new System.Drawing.Point(46, 188);
            this.runes_listbox.Name = "runes_listbox";
            this.runes_listbox.Size = new System.Drawing.Size(198, 212);
            this.runes_listbox.TabIndex = 10;
            this.runes_listbox.SelectedIndexChanged += new System.EventHandler(this.runes_listbox_SelectedIndexChanged);
            // 
            // add_rune_xml_button
            // 
            this.add_rune_xml_button.Location = new System.Drawing.Point(56, 159);
            this.add_rune_xml_button.Name = "add_rune_xml_button";
            this.add_rune_xml_button.Size = new System.Drawing.Size(75, 23);
            this.add_rune_xml_button.TabIndex = 12;
            this.add_rune_xml_button.Text = "Add Rune";
            this.add_rune_xml_button.UseVisualStyleBackColor = true;
            this.add_rune_xml_button.Click += new System.EventHandler(this.add_rune_xml_button_Click);
            // 
            // remove_rune_xml_button
            // 
            this.remove_rune_xml_button.Location = new System.Drawing.Point(137, 159);
            this.remove_rune_xml_button.Name = "remove_rune_xml_button";
            this.remove_rune_xml_button.Size = new System.Drawing.Size(89, 23);
            this.remove_rune_xml_button.TabIndex = 13;
            this.remove_rune_xml_button.Text = "Remove Rune";
            this.remove_rune_xml_button.UseVisualStyleBackColor = true;
            this.remove_rune_xml_button.Click += new System.EventHandler(this.remove_rune_xml_button_Click);
            // 
            // apply_rune_xml_button
            // 
            this.apply_rune_xml_button.Location = new System.Drawing.Point(102, 3);
            this.apply_rune_xml_button.Name = "apply_rune_xml_button";
            this.apply_rune_xml_button.Size = new System.Drawing.Size(75, 23);
            this.apply_rune_xml_button.TabIndex = 14;
            this.apply_rune_xml_button.Text = "Apply Rune";
            this.apply_rune_xml_button.UseVisualStyleBackColor = true;
            this.apply_rune_xml_button.Click += new System.EventHandler(this.apply_rune_xml_button_Click);
            // 
            // league_mode_menu_check
            // 
            this.league_mode_menu_check.AutoSize = true;
            this.league_mode_menu_check.Checked = true;
            this.league_mode_menu_check.Location = new System.Drawing.Point(3, 6);
            this.league_mode_menu_check.Name = "league_mode_menu_check";
            this.league_mode_menu_check.Size = new System.Drawing.Size(82, 17);
            this.league_mode_menu_check.TabIndex = 16;
            this.league_mode_menu_check.TabStop = true;
            this.league_mode_menu_check.Text = "Menu Mode";
            this.league_mode_menu_check.UseVisualStyleBackColor = true;
            this.league_mode_menu_check.CheckedChanged += new System.EventHandler(this.league_mode_menu_check_CheckedChanged);
            // 
            // league_mode_in_game_check
            // 
            this.league_mode_in_game_check.AutoSize = true;
            this.league_mode_in_game_check.Location = new System.Drawing.Point(194, 6);
            this.league_mode_in_game_check.Name = "league_mode_in_game_check";
            this.league_mode_in_game_check.Size = new System.Drawing.Size(95, 17);
            this.league_mode_in_game_check.TabIndex = 17;
            this.league_mode_in_game_check.Text = "In Game Mode";
            this.league_mode_in_game_check.UseVisualStyleBackColor = true;
            this.league_mode_in_game_check.CheckedChanged += new System.EventHandler(this.league_mode_in_game_check_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.league_mode_menu_check);
            this.panel1.Controls.Add(this.league_mode_in_game_check);
            this.panel1.Controls.Add(this.apply_rune_xml_button);
            this.panel1.Location = new System.Drawing.Point(4, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 32);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.remove_rune_xml_button);
            this.Controls.Add(this.add_rune_xml_button);
            this.Controls.Add(this.runes_listbox);
            this.Controls.Add(this.set_rune_from_url_button);
            this.Controls.Add(this.select_rune_comboBox);
            this.Controls.Add(this.set_rune_button);
            this.Controls.Add(this.Exists);
            this.Controls.Add(this.league_window_exists_textbox);
            this.Controls.Add(this.get_coords_button);
            this.Controls.Add(this.win_pos_y);
            this.Controls.Add(this.win_pos_x);
            this.Controls.Add(this.league_window_y_textbox);
            this.Controls.Add(this.league_window_x_textbox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LoL Rune Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox league_window_x_textbox;
        private System.Windows.Forms.TextBox league_window_y_textbox;
        private System.Windows.Forms.Label win_pos_x;
        private System.Windows.Forms.Label win_pos_y;
        private System.Windows.Forms.Button get_coords_button;
        private System.Windows.Forms.TextBox league_window_exists_textbox;
        private System.Windows.Forms.Label Exists;
        private System.Windows.Forms.Button set_rune_button;
        private System.Windows.Forms.ComboBox select_rune_comboBox;
        private System.Windows.Forms.Button set_rune_from_url_button;
        private System.Windows.Forms.ListBox runes_listbox;
        private System.Windows.Forms.Button add_rune_xml_button;
        private System.Windows.Forms.Button remove_rune_xml_button;
        private System.Windows.Forms.Button apply_rune_xml_button;
        private System.Windows.Forms.RadioButton league_mode_menu_check;
        private System.Windows.Forms.RadioButton league_mode_in_game_check;
        private System.Windows.Forms.Panel panel1;
    }
}

