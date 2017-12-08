namespace League_Of_Legends_Rune_Changer {
    partial class PromptRune {
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
            this.add_rune_name_inputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_rune_url_inputbox = new System.Windows.Forms.TextBox();
            this.add_rune_button = new System.Windows.Forms.Button();
            this.cancel_rune_button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_rune_name_inputbox
            // 
            this.add_rune_name_inputbox.Location = new System.Drawing.Point(12, 25);
            this.add_rune_name_inputbox.MaxLength = 24;
            this.add_rune_name_inputbox.Name = "add_rune_name_inputbox";
            this.add_rune_name_inputbox.Size = new System.Drawing.Size(196, 20);
            this.add_rune_name_inputbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rune Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rune Url:";
            // 
            // add_rune_url_inputbox
            // 
            this.add_rune_url_inputbox.Location = new System.Drawing.Point(12, 74);
            this.add_rune_url_inputbox.Name = "add_rune_url_inputbox";
            this.add_rune_url_inputbox.Size = new System.Drawing.Size(260, 20);
            this.add_rune_url_inputbox.TabIndex = 3;
            // 
            // add_rune_button
            // 
            this.add_rune_button.Location = new System.Drawing.Point(12, 158);
            this.add_rune_button.Name = "add_rune_button";
            this.add_rune_button.Size = new System.Drawing.Size(75, 23);
            this.add_rune_button.TabIndex = 4;
            this.add_rune_button.Text = "Add Rune";
            this.add_rune_button.UseVisualStyleBackColor = true;
            this.add_rune_button.Click += new System.EventHandler(this.add_rune_button_Click);
            // 
            // cancel_rune_button
            // 
            this.cancel_rune_button.Location = new System.Drawing.Point(197, 158);
            this.cancel_rune_button.Name = "cancel_rune_button";
            this.cancel_rune_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_rune_button.TabIndex = 5;
            this.cancel_rune_button.Text = "Cancel";
            this.cancel_rune_button.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 24);
            this.linkLabel1.Location = new System.Drawing.Point(12, 101);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(234, 42);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create custom build here, then copy the link \r\nfrom \"Share your build\" using\r\n\"Di" +
    "rect Link\" (last icon bottom right)\r\n";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label3.Location = new System.Drawing.Point(72, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Max. 24 characters)";
            // 
            // PromptRune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cancel_rune_button);
            this.Controls.Add(this.add_rune_button);
            this.Controls.Add(this.add_rune_url_inputbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_rune_name_inputbox);
            this.MaximizeBox = false;
            this.Name = "PromptRune";
            this.Text = "Enter new rune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_rune_name_inputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox add_rune_url_inputbox;
        private System.Windows.Forms.Button add_rune_button;
        private System.Windows.Forms.Button cancel_rune_button;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}