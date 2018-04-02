namespace HR_Program
{
    partial class HubScreen
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
            this.Top_bar_pctb = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Calander_form_btn = new System.Windows.Forms.Button();
            this.Contacts_form_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Top_bar_pctb)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_bar_pctb
            // 
            this.Top_bar_pctb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Top_bar_pctb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_bar_pctb.Location = new System.Drawing.Point(0, 0);
            this.Top_bar_pctb.Name = "Top_bar_pctb";
            this.Top_bar_pctb.Size = new System.Drawing.Size(300, 30);
            this.Top_bar_pctb.TabIndex = 0;
            this.Top_bar_pctb.TabStop = false;
            this.Top_bar_pctb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_Bar_pctb_MouseDown);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(270, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(30, 30);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "X";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Calander_form_btn
            // 
            this.Calander_form_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Calander_form_btn.FlatAppearance.BorderSize = 0;
            this.Calander_form_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calander_form_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Calander_form_btn.ForeColor = System.Drawing.Color.White;
            this.Calander_form_btn.Location = new System.Drawing.Point(30, 80);
            this.Calander_form_btn.Name = "Calander_form_btn";
            this.Calander_form_btn.Size = new System.Drawing.Size(100, 50);
            this.Calander_form_btn.TabIndex = 3;
            this.Calander_form_btn.Text = "לוח זמנים";
            this.Calander_form_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Calander_form_btn.UseVisualStyleBackColor = false;
            this.Calander_form_btn.Click += new System.EventHandler(this.Calander_form_btn_Click);
            // 
            // Contacts_form_btn
            // 
            this.Contacts_form_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Contacts_form_btn.FlatAppearance.BorderSize = 0;
            this.Contacts_form_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contacts_form_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Contacts_form_btn.ForeColor = System.Drawing.Color.White;
            this.Contacts_form_btn.Location = new System.Drawing.Point(170, 80);
            this.Contacts_form_btn.Name = "Contacts_form_btn";
            this.Contacts_form_btn.Size = new System.Drawing.Size(100, 50);
            this.Contacts_form_btn.TabIndex = 3;
            this.Contacts_form_btn.Text = "רשימת אנשים";
            this.Contacts_form_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Contacts_form_btn.UseVisualStyleBackColor = false;
            this.Contacts_form_btn.Click += new System.EventHandler(this.Contacts_form_btn_Click);
            // 
            // HubScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.Contacts_form_btn);
            this.Controls.Add(this.Calander_form_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Top_bar_pctb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HubScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HubScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Top_bar_pctb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Top_bar_pctb;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Calander_form_btn;
        private System.Windows.Forms.Button Contacts_form_btn;
    }
}