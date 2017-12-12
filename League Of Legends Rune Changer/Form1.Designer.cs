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
            this.runes_listbox = new System.Windows.Forms.ListBox();
            this.add_rune_xml_button = new System.Windows.Forms.Button();
            this.remove_rune_xml_button = new System.Windows.Forms.Button();
            this.apply_rune_xml_button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.currentAppVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runes_listbox
            // 
            this.runes_listbox.FormattingEnabled = true;
            this.runes_listbox.Location = new System.Drawing.Point(48, 40);
            this.runes_listbox.Name = "runes_listbox";
            this.runes_listbox.Size = new System.Drawing.Size(198, 212);
            this.runes_listbox.TabIndex = 10;
            this.runes_listbox.SelectedIndexChanged += new System.EventHandler(this.runes_listbox_SelectedIndexChanged);
            // 
            // add_rune_xml_button
            // 
            this.add_rune_xml_button.Location = new System.Drawing.Point(58, 11);
            this.add_rune_xml_button.Name = "add_rune_xml_button";
            this.add_rune_xml_button.Size = new System.Drawing.Size(75, 23);
            this.add_rune_xml_button.TabIndex = 12;
            this.add_rune_xml_button.Text = "Add Rune";
            this.add_rune_xml_button.UseVisualStyleBackColor = true;
            this.add_rune_xml_button.Click += new System.EventHandler(this.add_rune_xml_button_Click);
            // 
            // remove_rune_xml_button
            // 
            this.remove_rune_xml_button.Location = new System.Drawing.Point(139, 11);
            this.remove_rune_xml_button.Name = "remove_rune_xml_button";
            this.remove_rune_xml_button.Size = new System.Drawing.Size(89, 23);
            this.remove_rune_xml_button.TabIndex = 13;
            this.remove_rune_xml_button.Text = "Remove Rune";
            this.remove_rune_xml_button.UseVisualStyleBackColor = true;
            this.remove_rune_xml_button.Click += new System.EventHandler(this.remove_rune_xml_button_Click);
            // 
            // apply_rune_xml_button
            // 
            this.apply_rune_xml_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.apply_rune_xml_button.Location = new System.Drawing.Point(107, 258);
            this.apply_rune_xml_button.Name = "apply_rune_xml_button";
            this.apply_rune_xml_button.Size = new System.Drawing.Size(75, 23);
            this.apply_rune_xml_button.TabIndex = 14;
            this.apply_rune_xml_button.Text = "Apply Rune";
            this.apply_rune_xml_button.UseVisualStyleBackColor = true;
            this.apply_rune_xml_button.Click += new System.EventHandler(this.apply_rune_xml_button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(238, 266);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Donate :)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // currentAppVersion
            // 
            this.currentAppVersion.AutoSize = true;
            this.currentAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentAppVersion.ForeColor = System.Drawing.Color.DimGray;
            this.currentAppVersion.Location = new System.Drawing.Point(7, 266);
            this.currentAppVersion.Name = "currentAppVersion";
            this.currentAppVersion.Size = new System.Drawing.Size(94, 13);
            this.currentAppVersion.TabIndex = 20;
            this.currentAppVersion.Text = "currentAppVersion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 292);
            this.Controls.Add(this.currentAppVersion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.apply_rune_xml_button);
            this.Controls.Add(this.remove_rune_xml_button);
            this.Controls.Add(this.add_rune_xml_button);
            this.Controls.Add(this.runes_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LoL Rune Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox runes_listbox;
        private System.Windows.Forms.Button add_rune_xml_button;
        private System.Windows.Forms.Button remove_rune_xml_button;
        private System.Windows.Forms.Button apply_rune_xml_button;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label currentAppVersion;
    }
}

