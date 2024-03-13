
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseAPPBig
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            SetCategory();
            DBManager.OnCategoryUpdated += DBManager_OnDbUpdated;
        }

        private int updateExpenseId = 0;

        private void DBManager_OnDbUpdated(object sender, string e)
        {
            SetCategory();
        }

        private void SaveBtClick(object sender, EventArgs e)
        {   
            if(amountTB.Visible){
                errorLabel.Text = "Enter the Amount";
                return;
            }

            if (categoryCB.Text == "Category")
            {
                errorLabel.Text = "Select the category";
                return;
            }
            Expense expense = new Expense
            {
                Date = dateTimePicker.Value,
                Category = categoryCB.Text,
                Name = NameTB.Text,
                Amount = (int)amountNumericUpDown.Value,
                Description = descriptionTB.Text
            };

            if (saveBtn.Text == "Edit")
            {              
                if (DBManager.UpdateExpenseInDB(expense, updateExpenseId))
                  MessageBox.Show($"Your {expense.Category} limit Budget is exceeded");
               
            }
            else
            {
                if (DBManager.AddExpenseInDB(expense))
                {
                    MessageBox.Show($"Your {expense.Category} limit Budget is exceeded");
                }
            }
            Dispose();
        }

        private void OnNameTBClick(object sender, EventArgs e)
        {
            if (NameTB.Text == "Name")
                NameTB.Text = "";
        }

        private void OnAmountTBClick(object sender, EventArgs e)
        {
            amountTB.Visible = false;
            errorLabel.Text = "";
        }

        private void OnDescriptionTBClick(object sender, EventArgs e)
        {
            descriptionTB.Text = "";
        }


        public void SetData(Expense expense)
        {
            updateExpenseId = expense.Id;
            saveBtn.Text = "Edit";
            amountTB.Visible = false;
            dateTimePicker.Value = expense.Date;
            categoryCB.Text = expense.Category;
            NameTB.Text = expense.Name;
            amountNumericUpDown.Value = (decimal)expense.Amount;
            descriptionTB.Text = expense.Description;

        }

        public void SetCategory()
        {
            categoryCB.Items.Clear();

            string query = "SELECT CAT_NAME FROM categories";
            MySqlDataReader reader = DBManager.GetReader(query);
            while (reader.Read())
            {
                if (reader.GetString(0) != "Others")
                    categoryCB.Items.Add(reader.GetString(0));
            }
            reader.Close();
            categoryCB.Items.Add("Others");
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void categoryCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
             errorLabel.Text = "";
        }
    }
}
