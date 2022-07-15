using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class NoteTaker : Form

    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            perviousNotes.DataSource = notes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButtom_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[perviousNotes.CurrentCell.RowIndex].Delete();
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid note");
            }
        }

        private void LoadButtom_Click(object sender, EventArgs e)
        {
            try
            {
            titleBox.Text = notes.Rows[perviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[perviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
            }
            catch
            {
                MessageBox.Show("You don't have any note to load");
            }
        }

        private void NewNoteButtom_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void SaveButtom_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[perviousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[perviousNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

    private void perviousNotes_CellContentClick(object sender, EventArgs e)
        {

        }

        private void perviousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[perviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[perviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
