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
    public partial class CategoryModifyForm : Form
    {
        public CategoryModifyForm()
        {
            InitializeComponent();
            SetUpdateBox();
        }


        private void AddCategoryBtClick(object sender, EventArgs e)
        {
            ClearPanel();
            addCategoryPanel.Visible = true;
        }

        private void UpdateCategoryBtClick(object sender, EventArgs e)
        {
            ClearPanel();
            updateCategoryPanel.Visible = true;     
        }

        private void DeleteCategoryBtnClick(object sender, EventArgs e)
        {
            ClearPanel();
            deleteCategoryPanel.Visible = true;
        }


        private void AddBtClick(object sender, EventArgs e)
        {
            try
            {
                DBManager.AddNewCategory(newCategoryTB.Text , DateTime.Now.Month , (int)catBudgetTB.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category already existed   " + ex);
            }
            SetUpdateBox();
            ResetTBS();
        }

        private void UpdateBtClick(object sender, EventArgs e)
        {
            DBManager.UpdateExistingCategory(existingCategoryCB.Text, updatedCategoryTB.Text, (int)newBudgetCB.Value);
            SetUpdateBox();
            ResetTBS();
        }

        private void DeleteBtClick(object sender, EventArgs e)
        {
            DBManager.DeleteCategory(deleteCategoryCB.Text);
            SetUpdateBox();
            ResetTBS();
        }


        private void SetUpdateBox()
        {
            existingCategoryCB.Items.Clear();
            deleteCategoryCB.Items.Clear();

            string query = "SELECT CAT_NAME FROM categories";
            MySqlDataReader reader = DBManager.GetReader(query);
            while (reader.Read())
            {
                if (reader.GetString(0) != "Others")
                {
                    existingCategoryCB.Items.Add(reader.GetString(0));
                    deleteCategoryCB.Items.Add(reader.GetString(0));
                };
            }
            reader.Close();
        }


        private void ResetTBS()
        { 
            existingCategoryCB.Text = updatedCategoryTB.Text = deleteCategoryCB.Text = newCategoryTB.Text = "";
        }


        private void ClearPanel()
        {
            updateCategoryPanel.Visible = false;
            deleteCategoryPanel.Visible = false;
            addCategoryPanel.Visible = false;
            Height = 380;
        }

        private void CloseBtClick(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
