namespace MySQL_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnadd = new MetroFramework.Controls.MetroButton();
            this.txtauthour = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtage = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(320, 193);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseSelectable = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtauthour
            // 
            // 
            // 
            // 
            this.txtauthour.CustomButton.Image = null;
            this.txtauthour.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtauthour.CustomButton.Name = "";
            this.txtauthour.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtauthour.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtauthour.CustomButton.TabIndex = 1;
            this.txtauthour.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtauthour.CustomButton.UseSelectable = true;
            this.txtauthour.CustomButton.Visible = false;
            this.txtauthour.Lines = new string[0];
            this.txtauthour.Location = new System.Drawing.Point(140, 106);
            this.txtauthour.MaxLength = 32767;
            this.txtauthour.Name = "txtauthour";
            this.txtauthour.PasswordChar = '\0';
            this.txtauthour.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtauthour.SelectedText = "";
            this.txtauthour.SelectionLength = 0;
            this.txtauthour.SelectionStart = 0;
            this.txtauthour.ShortcutsEnabled = true;
            this.txtauthour.Size = new System.Drawing.Size(285, 23);
            this.txtauthour.TabIndex = 2;
            this.txtauthour.UseSelectable = true;
            this.txtauthour.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtauthour.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(45, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(24, 106);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(69, 23);
            this.htmlLabel2.TabIndex = 5;
            this.htmlLabel2.Text = "Author:";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(42, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(24, 135);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(69, 23);
            this.htmlLabel3.TabIndex = 7;
            this.htmlLabel3.Text = "Name:";
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(140, 135);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(285, 23);
            this.txtname.TabIndex = 6;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(32, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(24, 164);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(69, 23);
            this.htmlLabel5.TabIndex = 11;
            this.htmlLabel5.Text = "Age:";
            // 
            // txtage
            // 
            // 
            // 
            // 
            this.txtage.CustomButton.Image = null;
            this.txtage.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtage.CustomButton.Name = "";
            this.txtage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtage.CustomButton.TabIndex = 1;
            this.txtage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtage.CustomButton.UseSelectable = true;
            this.txtage.CustomButton.Visible = false;
            this.txtage.Lines = new string[0];
            this.txtage.Location = new System.Drawing.Point(140, 164);
            this.txtage.MaxLength = 32767;
            this.txtage.Name = "txtage";
            this.txtage.PasswordChar = '\0';
            this.txtage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtage.SelectedText = "";
            this.txtage.SelectionLength = 0;
            this.txtage.SelectionStart = 0;
            this.txtage.ShortcutsEnabled = true;
            this.txtage.Size = new System.Drawing.Size(285, 23);
            this.txtage.TabIndex = 10;
            this.txtage.UseSelectable = true;
            this.txtage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(370, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(23, 63);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(385, 26);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "If you got a warning, stop doing whatever you\'re doing and wait for the fix.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 265);
            this.Controls.Add(this.htmlLabel5);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.txtauthour);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Insert Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnadd;
        private MetroFramework.Controls.MetroTextBox txtauthour;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Controls.MetroTextBox txtage;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
    }
}

