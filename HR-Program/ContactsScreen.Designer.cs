namespace HR_Program
{
    partial class ContactsScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contacts_lstbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_txtbx = new System.Windows.Forms.TextBox();
            this.Address_txtbx = new System.Windows.Forms.TextBox();
            this.Tel_txtbx = new System.Windows.Forms.TextBox();
            this.BirthDate_dtpk = new System.Windows.Forms.DateTimePicker();
            this.Age_txtbx = new System.Windows.Forms.TextBox();
            this.Connections_gb = new System.Windows.Forms.GroupBox();
            this.Info_gb = new System.Windows.Forms.GroupBox();
            this.Summary_txtbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cell_txtbx = new System.Windows.Forms.TextBox();
            this.Status_gb = new System.Windows.Forms.GroupBox();
            this.Experiance_cmbx = new System.Windows.Forms.ComboBox();
            this.Avaiability_cmbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Side_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Filter_multichoice_cmbx = new System.Windows.Forms.ComboBox();
            this.Filter_string_txtbx = new System.Windows.Forms.TextBox();
            this.Filter_search_btn = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Filtering_cmbx = new System.Windows.Forms.ComboBox();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Person_remove_pbtn = new System.Windows.Forms.PictureBox();
            this.Person_update_pbtn = new System.Windows.Forms.PictureBox();
            this.Person_add_pbtn = new System.Windows.Forms.PictureBox();
            this.Top_bar_pctb = new System.Windows.Forms.PictureBox();
            this.Info_gb.SuspendLayout();
            this.Status_gb.SuspendLayout();
            this.Side_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filter_search_btn)).BeginInit();
            this.Main_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Person_remove_pbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person_update_pbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person_add_pbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_bar_pctb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 177);
            this.panel1.TabIndex = 0;
            // 
            // Contacts_lstbx
            // 
            this.Contacts_lstbx.BackColor = System.Drawing.SystemColors.Window;
            this.Contacts_lstbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contacts_lstbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contacts_lstbx.FormattingEnabled = true;
            this.Contacts_lstbx.Location = new System.Drawing.Point(0, 71);
            this.Contacts_lstbx.Name = "Contacts_lstbx";
            this.Contacts_lstbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Contacts_lstbx.Size = new System.Drawing.Size(180, 349);
            this.Contacts_lstbx.TabIndex = 1;
            this.Contacts_lstbx.SelectedIndexChanged += new System.EventHandler(this.Contacts_lstbx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(300, 20);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "שם מלא:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(259, 105);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "כתובת מגורים:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(280, 50);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "תאריך לידה:";
            // 
            // Name_txtbx
            // 
            this.Name_txtbx.Location = new System.Drawing.Point(151, 15);
            this.Name_txtbx.Name = "Name_txtbx";
            this.Name_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Name_txtbx.Size = new System.Drawing.Size(142, 20);
            this.Name_txtbx.TabIndex = 5;
            // 
            // Address_txtbx
            // 
            this.Address_txtbx.Location = new System.Drawing.Point(6, 125);
            this.Address_txtbx.Name = "Address_txtbx";
            this.Address_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Address_txtbx.Size = new System.Drawing.Size(341, 20);
            this.Address_txtbx.TabIndex = 5;
            // 
            // Tel_txtbx
            // 
            this.Tel_txtbx.Location = new System.Drawing.Point(200, 75);
            this.Tel_txtbx.Name = "Tel_txtbx";
            this.Tel_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tel_txtbx.Size = new System.Drawing.Size(75, 20);
            this.Tel_txtbx.TabIndex = 5;
            // 
            // BirthDate_dtpk
            // 
            this.BirthDate_dtpk.CustomFormat = "";
            this.BirthDate_dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate_dtpk.Location = new System.Drawing.Point(170, 45);
            this.BirthDate_dtpk.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.BirthDate_dtpk.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDate_dtpk.Name = "BirthDate_dtpk";
            this.BirthDate_dtpk.Size = new System.Drawing.Size(104, 20);
            this.BirthDate_dtpk.TabIndex = 7;
            this.BirthDate_dtpk.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Age_txtbx
            // 
            this.Age_txtbx.Location = new System.Drawing.Point(110, 45);
            this.Age_txtbx.Name = "Age_txtbx";
            this.Age_txtbx.ReadOnly = true;
            this.Age_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Age_txtbx.Size = new System.Drawing.Size(53, 20);
            this.Age_txtbx.TabIndex = 5;
            this.Age_txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Connections_gb
            // 
            this.Connections_gb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Connections_gb.Location = new System.Drawing.Point(0, 313);
            this.Connections_gb.Name = "Connections_gb";
            this.Connections_gb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Connections_gb.Size = new System.Drawing.Size(520, 107);
            this.Connections_gb.TabIndex = 8;
            this.Connections_gb.TabStop = false;
            this.Connections_gb.Text = "קשרים";
            // 
            // Info_gb
            // 
            this.Info_gb.Controls.Add(this.Summary_txtbx);
            this.Info_gb.Controls.Add(this.label9);
            this.Info_gb.Controls.Add(this.Address_txtbx);
            this.Info_gb.Controls.Add(this.label4);
            this.Info_gb.Controls.Add(this.label7);
            this.Info_gb.Controls.Add(this.label1);
            this.Info_gb.Controls.Add(this.label5);
            this.Info_gb.Controls.Add(this.BirthDate_dtpk);
            this.Info_gb.Controls.Add(this.Cell_txtbx);
            this.Info_gb.Controls.Add(this.Age_txtbx);
            this.Info_gb.Controls.Add(this.Tel_txtbx);
            this.Info_gb.Controls.Add(this.Name_txtbx);
            this.Info_gb.Controls.Add(this.label3);
            this.Info_gb.Dock = System.Windows.Forms.DockStyle.Right;
            this.Info_gb.Location = new System.Drawing.Point(162, 30);
            this.Info_gb.Name = "Info_gb";
            this.Info_gb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Info_gb.Size = new System.Drawing.Size(358, 283);
            this.Info_gb.TabIndex = 9;
            this.Info_gb.TabStop = false;
            this.Info_gb.Text = "פרטים אישיים";
            // 
            // Summary_txtbx
            // 
            this.Summary_txtbx.Location = new System.Drawing.Point(6, 169);
            this.Summary_txtbx.Multiline = true;
            this.Summary_txtbx.Name = "Summary_txtbx";
            this.Summary_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Summary_txtbx.Size = new System.Drawing.Size(341, 46);
            this.Summary_txtbx.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(300, 150);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "תקציר:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(130, 80);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "טלפון נייד:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(280, 80);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "טלפון בבית:";
            // 
            // Cell_txtbx
            // 
            this.Cell_txtbx.Location = new System.Drawing.Point(55, 75);
            this.Cell_txtbx.Name = "Cell_txtbx";
            this.Cell_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cell_txtbx.Size = new System.Drawing.Size(75, 20);
            this.Cell_txtbx.TabIndex = 5;
            // 
            // Status_gb
            // 
            this.Status_gb.Controls.Add(this.Experiance_cmbx);
            this.Status_gb.Controls.Add(this.Avaiability_cmbx);
            this.Status_gb.Controls.Add(this.label6);
            this.Status_gb.Controls.Add(this.label2);
            this.Status_gb.Location = new System.Drawing.Point(12, 219);
            this.Status_gb.Name = "Status_gb";
            this.Status_gb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Status_gb.Size = new System.Drawing.Size(138, 88);
            this.Status_gb.TabIndex = 10;
            this.Status_gb.TabStop = false;
            this.Status_gb.Text = "סטטוס";
            // 
            // Experiance_cmbx
            // 
            this.Experiance_cmbx.FormattingEnabled = true;
            this.Experiance_cmbx.Location = new System.Drawing.Point(10, 22);
            this.Experiance_cmbx.Name = "Experiance_cmbx";
            this.Experiance_cmbx.Size = new System.Drawing.Size(72, 21);
            this.Experiance_cmbx.TabIndex = 3;
            // 
            // Avaiability_cmbx
            // 
            this.Avaiability_cmbx.FormattingEnabled = true;
            this.Avaiability_cmbx.Items.AddRange(new object[] {
            "כן",
            "לא"});
            this.Avaiability_cmbx.Location = new System.Drawing.Point(10, 56);
            this.Avaiability_cmbx.Name = "Avaiability_cmbx";
            this.Avaiability_cmbx.Size = new System.Drawing.Size(72, 21);
            this.Avaiability_cmbx.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "פנוי/ה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ניסיון:";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(670, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(30, 30);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "X";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Side_panel
            // 
            this.Side_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Side_panel.Controls.Add(this.Contacts_lstbx);
            this.Side_panel.Controls.Add(this.panel3);
            this.Side_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Side_panel.Location = new System.Drawing.Point(520, 30);
            this.Side_panel.Name = "Side_panel";
            this.Side_panel.Size = new System.Drawing.Size(180, 420);
            this.Side_panel.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.Filter_multichoice_cmbx);
            this.panel3.Controls.Add(this.Filter_string_txtbx);
            this.panel3.Controls.Add(this.Filter_search_btn);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.Filtering_cmbx);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 71);
            this.panel3.TabIndex = 3;
            // 
            // Filter_multichoice_cmbx
            // 
            this.Filter_multichoice_cmbx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Filter_multichoice_cmbx.FormattingEnabled = true;
            this.Filter_multichoice_cmbx.Location = new System.Drawing.Point(40, 44);
            this.Filter_multichoice_cmbx.Name = "Filter_multichoice_cmbx";
            this.Filter_multichoice_cmbx.Size = new System.Drawing.Size(126, 24);
            this.Filter_multichoice_cmbx.TabIndex = 4;
            this.Filter_multichoice_cmbx.Visible = false;
            // 
            // Filter_string_txtbx
            // 
            this.Filter_string_txtbx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Filter_string_txtbx.Location = new System.Drawing.Point(40, 45);
            this.Filter_string_txtbx.Name = "Filter_string_txtbx";
            this.Filter_string_txtbx.Size = new System.Drawing.Size(126, 22);
            this.Filter_string_txtbx.TabIndex = 15;
            this.Filter_string_txtbx.Visible = false;
            // 
            // Filter_search_btn
            // 
            this.Filter_search_btn.BackgroundImage = global::HR_Program.Properties.Resources.mag1_x48;
            this.Filter_search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Filter_search_btn.Location = new System.Drawing.Point(4, 40);
            this.Filter_search_btn.Name = "Filter_search_btn";
            this.Filter_search_btn.Size = new System.Drawing.Size(30, 30);
            this.Filter_search_btn.TabIndex = 14;
            this.Filter_search_btn.TabStop = false;
            this.Filter_search_btn.Click += new System.EventHandler(this.Filter_search_btn_Click);
            this.Filter_search_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.Filter_search_btn.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.Filter_search_btn.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.Filter_search_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(110, 8);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "סינון עפ\"י:";
            // 
            // Filtering_cmbx
            // 
            this.Filtering_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtering_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtering_cmbx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Filtering_cmbx.FormattingEnabled = true;
            this.Filtering_cmbx.Items.AddRange(new object[] {
            "ניסיון",
            "גיל",
            "שם"});
            this.Filtering_cmbx.Location = new System.Drawing.Point(4, 7);
            this.Filtering_cmbx.Name = "Filtering_cmbx";
            this.Filtering_cmbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Filtering_cmbx.Size = new System.Drawing.Size(100, 24);
            this.Filtering_cmbx.TabIndex = 2;
            this.Filtering_cmbx.SelectedIndexChanged += new System.EventHandler(this.Filtering_cmbx_SelectedIndexChanged);
            // 
            // Main_panel
            // 
            this.Main_panel.Controls.Add(this.Info_gb);
            this.Main_panel.Controls.Add(this.panel2);
            this.Main_panel.Controls.Add(this.Connections_gb);
            this.Main_panel.Controls.Add(this.Status_gb);
            this.Main_panel.Controls.Add(this.panel1);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Main_panel.Location = new System.Drawing.Point(0, 30);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(520, 420);
            this.Main_panel.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.Person_remove_pbtn);
            this.panel2.Controls.Add(this.Person_update_pbtn);
            this.panel2.Controls.Add(this.Person_add_pbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 30);
            this.panel2.TabIndex = 12;
            // 
            // Person_remove_pbtn
            // 
            this.Person_remove_pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.Person_remove_pbtn.BackgroundImage = global::HR_Program.Properties.Resources.person_remove_x48;
            this.Person_remove_pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Person_remove_pbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Person_remove_pbtn.Location = new System.Drawing.Point(379, 0);
            this.Person_remove_pbtn.Name = "Person_remove_pbtn";
            this.Person_remove_pbtn.Size = new System.Drawing.Size(47, 30);
            this.Person_remove_pbtn.TabIndex = 14;
            this.Person_remove_pbtn.TabStop = false;
            this.Person_remove_pbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Person_remove_pbtn_MouseDown);
            this.Person_remove_pbtn.MouseEnter += new System.EventHandler(this.Person_remove_pbtn_MouseEnter);
            this.Person_remove_pbtn.MouseLeave += new System.EventHandler(this.Person_remove_pbtn_MouseLeave);
            // 
            // Person_update_pbtn
            // 
            this.Person_update_pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.Person_update_pbtn.BackgroundImage = global::HR_Program.Properties.Resources.person_update_x48;
            this.Person_update_pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Person_update_pbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Person_update_pbtn.Location = new System.Drawing.Point(426, 0);
            this.Person_update_pbtn.Name = "Person_update_pbtn";
            this.Person_update_pbtn.Size = new System.Drawing.Size(47, 30);
            this.Person_update_pbtn.TabIndex = 14;
            this.Person_update_pbtn.TabStop = false;
            this.Person_update_pbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Person_update_pbtn_MouseDown);
            this.Person_update_pbtn.MouseEnter += new System.EventHandler(this.Person_update_pbtn_MouseEnter);
            this.Person_update_pbtn.MouseLeave += new System.EventHandler(this.Person_update_pbtn_MouseLeave);
            // 
            // Person_add_pbtn
            // 
            this.Person_add_pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(141)))), ((int)(((byte)(178)))));
            this.Person_add_pbtn.BackgroundImage = global::HR_Program.Properties.Resources.person_add_x48;
            this.Person_add_pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Person_add_pbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Person_add_pbtn.Location = new System.Drawing.Point(473, 0);
            this.Person_add_pbtn.Name = "Person_add_pbtn";
            this.Person_add_pbtn.Size = new System.Drawing.Size(47, 30);
            this.Person_add_pbtn.TabIndex = 14;
            this.Person_add_pbtn.TabStop = false;
            this.Person_add_pbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Person_add_pbtn_MouseDown_1);
            this.Person_add_pbtn.MouseEnter += new System.EventHandler(this.Person_add_pbtn_MouseEnter_1);
            this.Person_add_pbtn.MouseLeave += new System.EventHandler(this.Person_add_pbtn_MouseLeave_1);
            // 
            // Top_bar_pctb
            // 
            this.Top_bar_pctb.BackColor = System.Drawing.Color.SteelBlue;
            this.Top_bar_pctb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_bar_pctb.Location = new System.Drawing.Point(0, 0);
            this.Top_bar_pctb.Name = "Top_bar_pctb";
            this.Top_bar_pctb.Size = new System.Drawing.Size(700, 30);
            this.Top_bar_pctb.TabIndex = 12;
            this.Top_bar_pctb.TabStop = false;
            this.Top_bar_pctb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_bar_pctb_MouseDown);
            // 
            // ContactsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.Side_panel);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Top_bar_pctb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactsScreen";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "ContactsScreen";
            this.Info_gb.ResumeLayout(false);
            this.Info_gb.PerformLayout();
            this.Status_gb.ResumeLayout(false);
            this.Status_gb.PerformLayout();
            this.Side_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filter_search_btn)).EndInit();
            this.Main_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Person_remove_pbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person_update_pbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person_add_pbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_bar_pctb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Contacts_lstbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_txtbx;
        private System.Windows.Forms.TextBox Address_txtbx;
        private System.Windows.Forms.TextBox Tel_txtbx;
        private System.Windows.Forms.DateTimePicker BirthDate_dtpk;
        private System.Windows.Forms.TextBox Age_txtbx;
        private System.Windows.Forms.GroupBox Connections_gb;
        private System.Windows.Forms.GroupBox Info_gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Status_gb;
        private System.Windows.Forms.ComboBox Avaiability_cmbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Cell_txtbx;
        private System.Windows.Forms.ComboBox Experiance_cmbx;
        private System.Windows.Forms.TextBox Summary_txtbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Top_bar_pctb;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Panel Side_panel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Filtering_cmbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Filter_search_btn;
        private System.Windows.Forms.TextBox Filter_string_txtbx;
        private System.Windows.Forms.ComboBox Filter_multichoice_cmbx;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.PictureBox Person_remove_pbtn;
        private System.Windows.Forms.PictureBox Person_update_pbtn;
        private System.Windows.Forms.PictureBox Person_add_pbtn;
        private System.Windows.Forms.Panel panel2;
    }
}

