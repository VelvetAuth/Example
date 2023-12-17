namespace example_1
{
    partial class Form2
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
            this.usernamelb = new Siticone.UI.WinForms.SiticoneLabel();
            this.emaillb = new Siticone.UI.WinForms.SiticoneLabel();
            this.expirylb = new Siticone.UI.WinForms.SiticoneLabel();
            this.levellb = new Siticone.UI.WinForms.SiticoneLabel();
            this.checkbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamelb
            // 
            this.usernamelb.BackColor = System.Drawing.Color.Transparent;
            this.usernamelb.Location = new System.Drawing.Point(34, 30);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(71, 15);
            this.usernamelb.TabIndex = 0;
            this.usernamelb.Text = "siticoneLabel1";
            // 
            // emaillb
            // 
            this.emaillb.BackColor = System.Drawing.Color.Transparent;
            this.emaillb.Location = new System.Drawing.Point(34, 52);
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(71, 15);
            this.emaillb.TabIndex = 1;
            this.emaillb.Text = "siticoneLabel1";
            // 
            // expirylb
            // 
            this.expirylb.BackColor = System.Drawing.Color.Transparent;
            this.expirylb.Location = new System.Drawing.Point(34, 73);
            this.expirylb.Name = "expirylb";
            this.expirylb.Size = new System.Drawing.Size(71, 15);
            this.expirylb.TabIndex = 2;
            this.expirylb.Text = "siticoneLabel1";
            // 
            // levellb
            // 
            this.levellb.BackColor = System.Drawing.Color.Transparent;
            this.levellb.Location = new System.Drawing.Point(34, 94);
            this.levellb.Name = "levellb";
            this.levellb.Size = new System.Drawing.Size(71, 15);
            this.levellb.TabIndex = 3;
            this.levellb.Text = "siticoneLabel1";
            // 
            // checkbtn
            // 
            this.checkbtn.Location = new System.Drawing.Point(34, 131);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(75, 23);
            this.checkbtn.TabIndex = 4;
            this.checkbtn.Text = "check";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 305);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.levellb);
            this.Controls.Add(this.expirylb);
            this.Controls.Add(this.emaillb);
            this.Controls.Add(this.usernamelb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneLabel usernamelb;
        private Siticone.UI.WinForms.SiticoneLabel emaillb;
        private Siticone.UI.WinForms.SiticoneLabel expirylb;
        private Siticone.UI.WinForms.SiticoneLabel levellb;
        private System.Windows.Forms.Button checkbtn;
    }
}