namespace HR_Program
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contacts_lstbx = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Filter_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.Filter_opt_cmbx = new System.Windows.Forms.ComboBox();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.Filter_Values_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_txtbx = new System.Windows.Forms.TextBox();
            this.Address_txtbx = new System.Windows.Forms.TextBox();
            this.Tel_txtbx = new System.Windows.Forms.TextBox();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.BirthDate_dtpk = new System.Windows.Forms.DateTimePicker();
            this.Age_txtbx = new System.Windows.Forms.TextBox();
            this.Connections_gb = new System.Windows.Forms.GroupBox();
            this.Info_gb = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cell_txtbx = new System.Windows.Forms.TextBox();
            this.Status_gb = new System.Windows.Forms.GroupBox();
            this.Experiance_cmbx = new System.Windows.Forms.ComboBox();
            this.Avaiability_cmbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.קובץToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.שמירהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אישקשרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוסףחדשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקנוכחיToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עדכןנוכחיToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.Filter_tlp.SuspendLayout();
            this.Info_gb.SuspendLayout();
            this.Status_gb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 177);
            this.panel1.TabIndex = 0;
            // 
            // Contacts_lstbx
            // 
            this.Contacts_lstbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contacts_lstbx.FormattingEnabled = true;
            this.Contacts_lstbx.Location = new System.Drawing.Point(3, 65);
            this.Contacts_lstbx.Name = "Contacts_lstbx";
            this.Contacts_lstbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Contacts_lstbx.Size = new System.Drawing.Size(160, 304);
            this.Contacts_lstbx.TabIndex = 1;
            this.Contacts_lstbx.SelectedIndexChanged += new System.EventHandler(this.Contacts_lstbx_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Contacts_lstbx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Filter_tlp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(518, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(166, 372);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Filter_tlp
            // 
            this.Filter_tlp.ColumnCount = 2;
            this.Filter_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Filter_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Filter_tlp.Controls.Add(this.label8, 0, 0);
            this.Filter_tlp.Controls.Add(this.Filter_opt_cmbx, 1, 0);
            this.Filter_tlp.Controls.Add(this.Filter_btn, 1, 1);
            this.Filter_tlp.Controls.Add(this.Filter_Values_tlp, 0, 1);
            this.Filter_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filter_tlp.Location = new System.Drawing.Point(3, 3);
            this.Filter_tlp.Name = "Filter_tlp";
            this.Filter_tlp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Filter_tlp.RowCount = 2;
            this.Filter_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            this.Filter_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.Filter_tlp.Size = new System.Drawing.Size(160, 56);
            this.Filter_tlp.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 6);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "סנן לפי:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Filter_opt_cmbx
            // 
            this.Filter_opt_cmbx.FormattingEnabled = true;
            this.Filter_opt_cmbx.Items.AddRange(new object[] {
            "ניסיון",
            "גיל",
            "שם"});
            this.Filter_opt_cmbx.Location = new System.Drawing.Point(3, 3);
            this.Filter_opt_cmbx.Name = "Filter_opt_cmbx";
            this.Filter_opt_cmbx.Size = new System.Drawing.Size(74, 21);
            this.Filter_opt_cmbx.TabIndex = 2;
            this.Filter_opt_cmbx.SelectedIndexChanged += new System.EventHandler(this.Filter_opt_cmbx_SelectedIndexChanged);
            // 
            // Filter_btn
            // 
            this.Filter_btn.Location = new System.Drawing.Point(3, 29);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(74, 23);
            this.Filter_btn.TabIndex = 3;
            this.Filter_btn.Text = "סנן";
            this.Filter_btn.UseVisualStyleBackColor = true;
            this.Filter_btn.Click += new System.EventHandler(this.Filter_btn_Click);
            // 
            // Filter_Values_tlp
            // 
            this.Filter_Values_tlp.ColumnCount = 1;
            this.Filter_Values_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Filter_Values_tlp.Location = new System.Drawing.Point(83, 29);
            this.Filter_Values_tlp.Name = "Filter_Values_tlp";
            this.Filter_Values_tlp.RowCount = 1;
            this.Filter_Values_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Filter_Values_tlp.Size = new System.Drawing.Size(74, 24);
            this.Filter_Values_tlp.TabIndex = 4;
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
            this.label4.Location = new System.Drawing.Point(259, 155);
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
            this.label5.Location = new System.Drawing.Point(278, 50);
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
            this.Address_txtbx.Location = new System.Drawing.Point(6, 174);
            this.Address_txtbx.Multiline = true;
            this.Address_txtbx.Name = "Address_txtbx";
            this.Address_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Address_txtbx.Size = new System.Drawing.Size(341, 36);
            this.Address_txtbx.TabIndex = 5;
            // 
            // Tel_txtbx
            // 
            this.Tel_txtbx.Location = new System.Drawing.Point(167, 74);
            this.Tel_txtbx.Name = "Tel_txtbx";
            this.Tel_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tel_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Tel_txtbx.TabIndex = 5;
            // 
            // Title_lbl
            // 
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title_lbl.Location = new System.Drawing.Point(3, 0);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(353, 45);
            this.Title_lbl.TabIndex = 7;
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
            this.BirthDate_dtpk.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.Connections_gb.Location = new System.Drawing.Point(0, 307);
            this.Connections_gb.Name = "Connections_gb";
            this.Connections_gb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Connections_gb.Size = new System.Drawing.Size(518, 89);
            this.Connections_gb.TabIndex = 8;
            this.Connections_gb.TabStop = false;
            this.Connections_gb.Text = "קשרים";
            // 
            // Info_gb
            // 
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
            this.Info_gb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info_gb.Location = new System.Drawing.Point(3, 53);
            this.Info_gb.Name = "Info_gb";
            this.Info_gb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Info_gb.Size = new System.Drawing.Size(353, 221);
            this.Info_gb.TabIndex = 9;
            this.Info_gb.TabStop = false;
            this.Info_gb.Text = "פרטים אישיים";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(280, 111);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "טלפון נייד:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(273, 78);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "טלפון בבית:";
            // 
            // Cell_txtbx
            // 
            this.Cell_txtbx.Location = new System.Drawing.Point(168, 107);
            this.Cell_txtbx.Name = "Cell_txtbx";
            this.Cell_txtbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cell_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Cell_txtbx.TabIndex = 5;
            // 
            // Status_gb
            // 
            this.Status_gb.Controls.Add(this.Experiance_cmbx);
            this.Status_gb.Controls.Add(this.Avaiability_cmbx);
            this.Status_gb.Controls.Add(this.label6);
            this.Status_gb.Controls.Add(this.label2);
            this.Status_gb.Location = new System.Drawing.Point(3, 186);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.קובץToolStripMenuItem,
            this.אישקשרToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // קובץToolStripMenuItem
            // 
            this.קובץToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.שמירהToolStripMenuItem});
            this.קובץToolStripMenuItem.Name = "קובץToolStripMenuItem";
            this.קובץToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.קובץToolStripMenuItem.Text = "קובץ";
            // 
            // שמירהToolStripMenuItem
            // 
            this.שמירהToolStripMenuItem.Name = "שמירהToolStripMenuItem";
            this.שמירהToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.שמירהToolStripMenuItem.Text = "שמירה";
            // 
            // אישקשרToolStripMenuItem
            // 
            this.אישקשרToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוסףחדשToolStripMenuItem,
            this.מחקנוכחיToolStripMenuItem,
            this.עדכןנוכחיToolStripMenuItem});
            this.אישקשרToolStripMenuItem.Name = "אישקשרToolStripMenuItem";
            this.אישקשרToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.אישקשרToolStripMenuItem.Text = "איש קשר";
            // 
            // הוסףחדשToolStripMenuItem
            // 
            this.הוסףחדשToolStripMenuItem.Name = "הוסףחדשToolStripMenuItem";
            this.הוסףחדשToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.הוסףחדשToolStripMenuItem.Text = "הוסף חדש";
            // 
            // מחקנוכחיToolStripMenuItem
            // 
            this.מחקנוכחיToolStripMenuItem.Name = "מחקנוכחיToolStripMenuItem";
            this.מחקנוכחיToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.מחקנוכחיToolStripMenuItem.Text = "מחק נוכחי";
            // 
            // עדכןנוכחיToolStripMenuItem
            // 
            this.עדכןנוכחיToolStripMenuItem.Name = "עדכןנוכחיToolStripMenuItem";
            this.עדכןנוכחיToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.עדכןנוכחיToolStripMenuItem.Text = "עדכן נוכחי";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(518, 283);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Status_gb, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(147, 277);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Info_gb, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Title_lbl, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(156, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24549F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.75451F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(359, 277);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 396);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.Connections_gb);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Filter_tlp.ResumeLayout(false);
            this.Filter_tlp.PerformLayout();
            this.Info_gb.ResumeLayout(false);
            this.Info_gb.PerformLayout();
            this.Status_gb.ResumeLayout(false);
            this.Status_gb.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Contacts_lstbx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_txtbx;
        private System.Windows.Forms.TextBox Address_txtbx;
        private System.Windows.Forms.TextBox Tel_txtbx;
        private System.Windows.Forms.Label Title_lbl;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ToolStripMenuItem קובץToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem שמירהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אישקשרToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הוסףחדשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחקנוכחיToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עדכןנוכחיToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel Filter_tlp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Filter_opt_cmbx;
        private System.Windows.Forms.Button Filter_btn;
        private System.Windows.Forms.TableLayoutPanel Filter_Values_tlp;
        private System.Windows.Forms.ComboBox Experiance_cmbx;
    }
}

