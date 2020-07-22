using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD157_Coursework
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void ButtonGetTables_Click(object sender, EventArgs e)
		{
			List<String> tables = Utils.GetTables();
			listTables.Items.Clear();
			for(int i = 0; i < tables.Count; i++)
			{
				listTables.Items.Add(tables[i]);
			}
		}

		private void ButtonSelectTable_Click(object sender, EventArgs e)
		{
			if(listTables.SelectedIndices.Count > 0)
			{
				int selected = listTables.SelectedIndex;
				String filter = inputSearch.Text.Trim();
				if(filter != "" && filter != "UserID Filter...")
				{
					dataGridView.DataSource = Utils.GetTableContentByID(listTables.Items[selected].ToString(), filter);
				}
				else
				{
					dataGridView.DataSource = Utils.GetTableContent(listTables.Items[selected].ToString());
				}
			}
			else
			{
				MessageBox.Show("Please select a table from the list first.", "Error");
			}
		}

		private void PanelSearch_Click(object sender, EventArgs e)
		{
			inputSearch.Focus();
		}

		private void InputSearch_Enter(object sender, EventArgs e)
		{
			if(inputSearch.Text.Trim() == "" || inputSearch.Text.Trim() == "UserID Filter...")
			{
				inputSearch.Text = "";
			}
		}

		private void InputSearch_Leave(object sender, EventArgs e)
		{
			if(inputSearch.Text.Trim() == "" || inputSearch.Text.Trim() == "UserID Filter...")
			{
				inputSearch.Text = "UserID Filter...";
			}
		}

		private void ButtonFilter_Click(object sender, EventArgs e)
		{
			if(listTables.SelectedIndices.Count > 0)
			{
				int selected = listTables.SelectedIndex;
				String filter = inputSearch.Text.Trim();
				if(filter != "" && filter != "UserID Filter...")
				{
					dataGridView.DataSource = Utils.GetTableContentByID(listTables.Items[selected].ToString(), filter);
				}
				else
				{
					MessageBox.Show("Invalid filter.", "Error");
				}
			}
			else
			{
				MessageBox.Show("Please select a table from the list first.", "Error");
			}
		}
	}
}
