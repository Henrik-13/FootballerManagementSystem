using System.Windows.Forms;

namespace FootballerManagementSystem
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
            this.tbNames = new System.Windows.Forms.TextBox();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.bt_filter = new System.Windows.Forms.Button();
            this.dgvFootballers = new System.Windows.Forms.DataGridView();
            this.footballerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footballerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_modosit = new System.Windows.Forms.Button();
            this.lbGoals = new System.Windows.Forms.Label();
            this.tbGoals = new System.Windows.Forms.TextBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.lbNew = new System.Windows.Forms.Label();
            this.lbActual = new System.Windows.Forms.Label();
            this.lbOld = new System.Windows.Forms.Label();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbActual = new System.Windows.Forms.RadioButton();
            this.rbOld = new System.Windows.Forms.RadioButton();
            this.lbRole = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFootballers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNames
            // 
            this.tbNames.Location = new System.Drawing.Point(83, 58);
            this.tbNames.Name = "tbNames";
            this.tbNames.Size = new System.Drawing.Size(100, 22);
            this.tbNames.TabIndex = 0;
            this.tbNames.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(221, 56);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(121, 24);
            this.cbCountries.TabIndex = 1;
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
            // 
            // bt_filter
            // 
            this.bt_filter.Location = new System.Drawing.Point(454, 44);
            this.bt_filter.Name = "bt_filter";
            this.bt_filter.Size = new System.Drawing.Size(75, 23);
            this.bt_filter.TabIndex = 2;
            this.bt_filter.Text = "Szures";
            this.bt_filter.UseVisualStyleBackColor = true;
            this.bt_filter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // dgvFootballers
            // 
            this.dgvFootballers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFootballers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.footballerID,
            this.footballerName,
            this.countryID,
            this.countryName,
            this.goals,
            this.assists,
            this.age,
            this.currentValue});
            this.dgvFootballers.Location = new System.Drawing.Point(12, 95);
            this.dgvFootballers.Name = "dgvFootballers";
            this.dgvFootballers.ReadOnly = true;
            this.dgvFootballers.RowHeadersWidth = 51;
            this.dgvFootballers.RowTemplate.Height = 24;
            this.dgvFootballers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFootballers.Size = new System.Drawing.Size(748, 263);
            this.dgvFootballers.TabIndex = 26;
            this.dgvFootballers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFootballers_CellContentClick);
            // 
            // footballerID
            // 
            this.footballerID.HeaderText = "ID";
            this.footballerID.MinimumWidth = 6;
            this.footballerID.Name = "footballerID";
            this.footballerID.ReadOnly = true;
            this.footballerID.Visible = false;
            this.footballerID.Width = 125;
            // 
            // footballerName
            // 
            this.footballerName.HeaderText = "Nev";
            this.footballerName.MinimumWidth = 6;
            this.footballerName.Name = "footballerName";
            this.footballerName.ReadOnly = true;
            this.footballerName.Width = 125;
            // 
            // countryID
            // 
            this.countryID.HeaderText = "OrszagID";
            this.countryID.MinimumWidth = 6;
            this.countryID.Name = "countryID";
            this.countryID.ReadOnly = true;
            this.countryID.Visible = false;
            this.countryID.Width = 125;
            // 
            // countryName
            // 
            this.countryName.HeaderText = "Orszag";
            this.countryName.MinimumWidth = 6;
            this.countryName.Name = "countryName";
            this.countryName.ReadOnly = true;
            this.countryName.Width = 125;
            // 
            // goals
            // 
            this.goals.HeaderText = "Golok";
            this.goals.MinimumWidth = 6;
            this.goals.Name = "goals";
            this.goals.ReadOnly = true;
            this.goals.Width = 125;
            // 
            // assists
            // 
            this.assists.HeaderText = "Golpasszok";
            this.assists.MinimumWidth = 6;
            this.assists.Name = "assists";
            this.assists.ReadOnly = true;
            this.assists.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Eletkor";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 125;
            // 
            // currentValue
            // 
            this.currentValue.HeaderText = "Ertek";
            this.currentValue.MinimumWidth = 6;
            this.currentValue.Name = "currentValue";
            this.currentValue.ReadOnly = true;
            this.currentValue.Width = 125;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(218, 39);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(83, 16);
            this.lbCountry.TabIndex = 27;
            this.lbCountry.Text = "Orszag neve";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(80, 39);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(88, 16);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Jatekos neve";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(645, 382);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 29;
            this.bt_exit.Text = "Kilep";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.módosításToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(454, 44);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 31;
            this.bt_delete.Text = "Torol";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // bt_modosit
            // 
            this.bt_modosit.Location = new System.Drawing.Point(454, 44);
            this.bt_modosit.Name = "bt_modosit";
            this.bt_modosit.Size = new System.Drawing.Size(75, 23);
            this.bt_modosit.TabIndex = 32;
            this.bt_modosit.Text = "Modosit";
            this.bt_modosit.UseVisualStyleBackColor = true;
            this.bt_modosit.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // lbGoals
            // 
            this.lbGoals.AutoSize = true;
            this.lbGoals.Location = new System.Drawing.Point(80, 39);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.Size = new System.Drawing.Size(89, 16);
            this.lbGoals.TabIndex = 33;
            this.lbGoals.Text = "Golok szama:";
            // 
            // tbGoals
            // 
            this.tbGoals.Location = new System.Drawing.Point(83, 58);
            this.tbGoals.Name = "tbGoals";
            this.tbGoals.Size = new System.Drawing.Size(100, 22);
            this.tbGoals.TabIndex = 34;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.lbNew);
            this.gbUpdate.Controls.Add(this.lbActual);
            this.gbUpdate.Controls.Add(this.lbOld);
            this.gbUpdate.Controls.Add(this.rbNew);
            this.gbUpdate.Controls.Add(this.rbActual);
            this.gbUpdate.Controls.Add(this.rbOld);
            this.gbUpdate.Location = new System.Drawing.Point(268, 0);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(180, 89);
            this.gbUpdate.TabIndex = 35;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Konkurencia problema";
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Location = new System.Drawing.Point(130, 71);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(20, 16);
            this.lbNew.TabIndex = 40;
            this.lbNew.Text = "Uj";
            // 
            // lbActual
            // 
            this.lbActual.AutoSize = true;
            this.lbActual.Location = new System.Drawing.Point(130, 45);
            this.lbActual.Name = "lbActual";
            this.lbActual.Size = new System.Drawing.Size(54, 16);
            this.lbActual.TabIndex = 39;
            this.lbActual.Text = "Aktualis";
            // 
            // lbOld
            // 
            this.lbOld.AutoSize = true;
            this.lbOld.Location = new System.Drawing.Point(130, 23);
            this.lbOld.Name = "lbOld";
            this.lbOld.Size = new System.Drawing.Size(36, 16);
            this.lbOld.TabIndex = 36;
            this.lbOld.Text = "Regi";
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(6, 69);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(103, 20);
            this.rbNew.TabIndex = 38;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "radioButton3";
            this.rbNew.UseVisualStyleBackColor = true;
            // 
            // rbActual
            // 
            this.rbActual.AutoSize = true;
            this.rbActual.Location = new System.Drawing.Point(6, 45);
            this.rbActual.Name = "rbActual";
            this.rbActual.Size = new System.Drawing.Size(103, 20);
            this.rbActual.TabIndex = 37;
            this.rbActual.TabStop = true;
            this.rbActual.Text = "radioButton2";
            this.rbActual.UseVisualStyleBackColor = true;
            // 
            // rbOld
            // 
            this.rbOld.AutoSize = true;
            this.rbOld.Location = new System.Drawing.Point(6, 21);
            this.rbOld.Name = "rbOld";
            this.rbOld.Size = new System.Drawing.Size(103, 20);
            this.rbOld.TabIndex = 36;
            this.rbOld.TabStop = true;
            this.rbOld.Text = "radioButton1";
            this.rbOld.UseVisualStyleBackColor = true;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(661, 47);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(80, 16);
            this.lbRole.TabIndex = 36;
            this.lbRole.Text = "Felhasznalo";
            this.lbRole.UseWaitCursor = true;
            this.lbRole.Click += new System.EventHandler(this.label1_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(54, 382);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 37;
            this.btBack.Text = "Vissza";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.tbGoals);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.bt_modosit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.dgvFootballers);
            this.Controls.Add(this.bt_filter);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.tbNames);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFootballers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNames;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Button bt_filter;
        private System.Windows.Forms.DataGridView dgvFootballers;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn footballerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn footballerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn assists;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentValue;
        private Button bt_exit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem keresésToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem módosításToolStripMenuItem;
        private Button bt_delete;
        private Button bt_modosit;
        private Label lbGoals;
        private TextBox tbGoals;
        private GroupBox gbUpdate;
        private RadioButton rbNew;
        private RadioButton rbActual;
        private RadioButton rbOld;
        private Label lbNew;
        private Label lbActual;
        private Label lbOld;
        private Label lbRole;
        private Button btBack;
    }
}

