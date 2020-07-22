namespace ISAD157_Coursework
{
	partial class FormMain
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
			if(disposing && (components != null))
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonGetTables = new System.Windows.Forms.Button();
			this.listTables = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonSelectTable = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.inputSearch = new System.Windows.Forms.TextBox();
			this.buttonFilter = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panelSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1255, 50);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1113, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 43);
			this.label2.TabIndex = 2;
			this.label2.Text = "DB Tool";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 43);
			this.label1.TabIndex = 1;
			this.label1.Text = "facebook";
			// 
			// buttonGetTables
			// 
			this.buttonGetTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
			this.buttonGetTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGetTables.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGetTables.ForeColor = System.Drawing.Color.White;
			this.buttonGetTables.Location = new System.Drawing.Point(284, 625);
			this.buttonGetTables.Name = "buttonGetTables";
			this.buttonGetTables.Size = new System.Drawing.Size(200, 50);
			this.buttonGetTables.TabIndex = 2;
			this.buttonGetTables.Text = "Get Tables";
			this.buttonGetTables.UseVisualStyleBackColor = false;
			this.buttonGetTables.Click += new System.EventHandler(this.ButtonGetTables_Click);
			// 
			// listTables
			// 
			this.listTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.listTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listTables.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.listTables.FormattingEnabled = true;
			this.listTables.IntegralHeight = false;
			this.listTables.ItemHeight = 21;
			this.listTables.Location = new System.Drawing.Point(12, 13);
			this.listTables.Name = "listTables";
			this.listTables.Size = new System.Drawing.Size(240, 640);
			this.listTables.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.panel2.Controls.Add(this.listTables);
			this.panel2.Location = new System.Drawing.Point(12, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(266, 668);
			this.panel2.TabIndex = 4;
			// 
			// buttonSelectTable
			// 
			this.buttonSelectTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
			this.buttonSelectTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSelectTable.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSelectTable.ForeColor = System.Drawing.Color.White;
			this.buttonSelectTable.Location = new System.Drawing.Point(284, 681);
			this.buttonSelectTable.Name = "buttonSelectTable";
			this.buttonSelectTable.Size = new System.Drawing.Size(200, 50);
			this.buttonSelectTable.TabIndex = 5;
			this.buttonSelectTable.Text = "View Table";
			this.buttonSelectTable.UseVisualStyleBackColor = false;
			this.buttonSelectTable.Click += new System.EventHandler(this.ButtonSelectTable_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(284, 62);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.Size = new System.Drawing.Size(961, 557);
			this.dataGridView.TabIndex = 6;
			// 
			// panelSearch
			// 
			this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.panelSearch.Controls.Add(this.inputSearch);
			this.panelSearch.Location = new System.Drawing.Point(1045, 625);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(200, 50);
			this.panelSearch.TabIndex = 7;
			this.panelSearch.Click += new System.EventHandler(this.PanelSearch_Click);
			// 
			// inputSearch
			// 
			this.inputSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.inputSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.inputSearch.Location = new System.Drawing.Point(10, 14);
			this.inputSearch.Name = "inputSearch";
			this.inputSearch.Size = new System.Drawing.Size(180, 22);
			this.inputSearch.TabIndex = 8;
			this.inputSearch.Text = "UserID Filter...";
			this.inputSearch.Enter += new System.EventHandler(this.InputSearch_Enter);
			this.inputSearch.Leave += new System.EventHandler(this.InputSearch_Leave);
			// 
			// buttonFilter
			// 
			this.buttonFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
			this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFilter.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFilter.ForeColor = System.Drawing.Color.White;
			this.buttonFilter.Location = new System.Drawing.Point(1045, 680);
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Size = new System.Drawing.Size(200, 50);
			this.buttonFilter.TabIndex = 8;
			this.buttonFilter.Text = "Apply Filter";
			this.buttonFilter.UseVisualStyleBackColor = false;
			this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1255, 742);
			this.Controls.Add(this.buttonFilter);
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.buttonSelectTable);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.buttonGetTables);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonGetTables;
		private System.Windows.Forms.ListBox listTables;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonSelectTable;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.TextBox inputSearch;
		private System.Windows.Forms.Button buttonFilter;
	}
}

