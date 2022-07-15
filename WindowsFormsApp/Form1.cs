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
            titleBox.Text = notes.Rows[perviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[perviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void NewNoteButtom_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void SaveButtom_Click(object sender, EventArgs e)
        {

        }
    }
}
