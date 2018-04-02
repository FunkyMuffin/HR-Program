namespace HR_Program
{
    partial class SchedulesScreen
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
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Top_bar_pctb = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.Top_bar_pctb)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(686, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(30, 30);
            this.Exit_btn.TabIndex = 13;
            this.Exit_btn.Text = "X";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Top_bar_pctb
            // 
            this.Top_bar_pctb.BackColor = System.Drawing.Color.SteelBlue;
            this.Top_bar_pctb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_bar_pctb.Location = new System.Drawing.Point(0, 0);
            this.Top_bar_pctb.Name = "Top_bar_pctb";
            this.Top_bar_pctb.Size = new System.Drawing.Size(716, 30);
            this.Top_bar_pctb.TabIndex = 14;
            this.Top_bar_pctb.TabStop = false;
            this.Top_bar_pctb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_bar_pctb_MouseDown);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 30);
            this.monthCalendar1.MinDate = new System.DateTime(1948, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 15;
            // 
            // SchedulesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(716, 379);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Top_bar_pctb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchedulesScreen";
            this.Text = "SchedulesScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Top_bar_pctb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.PictureBox Top_bar_pctb;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}