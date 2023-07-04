using System;
using System.Windows.Forms;

namespace INI
{
    partial class Main_form
    {
        public Form Modify_f;
        public Form Create_f;

        #region
        public void InitializeComponent()
        {
            Program.NewINI_btn = new System.Windows.Forms.Button();
            Program.OpenINI_btn = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // NewINI_btn
            // 
            Program.NewINI_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Program.NewINI_btn.Location = new System.Drawing.Point(175, 158);
            Program.NewINI_btn.Name = "CreateINI_btn";
            Program.NewINI_btn.Size = new System.Drawing.Size(210, 90);
            Program.NewINI_btn.Text = "Create New INI";
            Program.NewINI_btn.UseVisualStyleBackColor = true;
            Program.NewINI_btn.Click += new System.EventHandler(this.buttonNewINI_Click);
            // 
            // OpenINI_btn
            // 
            Program.OpenINI_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Program.OpenINI_btn.Location = new System.Drawing.Point(407, 158);
            Program.OpenINI_btn.Name = "OpenINI_btn";
            Program.OpenINI_btn.Size = new System.Drawing.Size(210, 90);
            Program.OpenINI_btn.Text = "Open INI File";
            Program.OpenINI_btn.UseVisualStyleBackColor = true;
            Program.OpenINI_btn.Click += new System.EventHandler(this.buttonOpenINI_Click);
            // 
            // Main_form
            // 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Program.NewINI_btn);
            this.Controls.Add(Program.OpenINI_btn);
            this.Name = "Main_form";
            this.Text = "Main Form";
            this.ResumeLayout(false);
        }
        public void buttonNewINI_Click(object sender, EventArgs e)
        {
            if (Create_f == null)
                Create_f = new Create_form();
            Hide();
            Create_f.Show();
        }
        public void buttonOpenINI_Click(object sender, EventArgs e)
        {
            if (Modify_f == null)
                Modify_f = new Modify_form();
            Hide();
            Modify_f.Show();
        }
        #endregion
    }
}