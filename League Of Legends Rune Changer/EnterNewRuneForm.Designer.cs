﻿namespace League_Of_Legends_Rune_Changer {
    partial class EnterNewRuneForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterNewRuneForm));
            this.add_rune_name_inputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_rune_url_inputbox = new System.Windows.Forms.TextBox();
            this.add_rune_button = new System.Windows.Forms.Button();
            this.cancel_rune_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.createYourCustomBuild = new System.Windows.Forms.LinkLabel();
            this.rune_name_error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rune_name_error)).BeginInit();
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
            this.add_rune_url_inputbox.MaxLength = 84;
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
            this.cancel_rune_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_rune_button.Location = new System.Drawing.Point(197, 158);
            this.cancel_rune_button.Name = "cancel_rune_button";
            this.cancel_rune_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_rune_button.TabIndex = 5;
            this.cancel_rune_button.Text = "Cancel";
            this.cancel_rune_button.UseVisualStyleBackColor = true;
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
            // createYourCustomBuild
            // 
            this.createYourCustomBuild.AutoSize = true;
            this.createYourCustomBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createYourCustomBuild.LinkArea = new System.Windows.Forms.LinkArea(0, 24);
            this.createYourCustomBuild.Location = new System.Drawing.Point(12, 101);
            this.createYourCustomBuild.Name = "createYourCustomBuild";
            this.createYourCustomBuild.Size = new System.Drawing.Size(259, 42);
            this.createYourCustomBuild.TabIndex = 6;
            this.createYourCustomBuild.TabStop = true;
            this.createYourCustomBuild.Text = "Create your custom build here, then copy the link \r\nfrom \"Share your build\" using" +
    "\r\n\"Direct Link\" (last icon bottom right)\r\n";
            this.createYourCustomBuild.UseCompatibleTextRendering = true;
            this.createYourCustomBuild.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createYourCustomBuild_LinkClicked);
            // 
            // rune_name_error
            // 
            this.rune_name_error.ContainerControl = this;
            // 
            // EnterNewRuneForm
            // 
            this.AcceptButton = this.add_rune_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_rune_button;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createYourCustomBuild);
            this.Controls.Add(this.cancel_rune_button);
            this.Controls.Add(this.add_rune_button);
            this.Controls.Add(this.add_rune_url_inputbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_rune_name_inputbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnterNewRuneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter New Rune";
            ((System.ComponentModel.ISupportInitialize)(this.rune_name_error)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel createYourCustomBuild;
        private System.Windows.Forms.ErrorProvider rune_name_error;
    }
}