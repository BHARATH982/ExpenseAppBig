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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DBManager.GetConnection(); // to establish connection between sql and program while loading the form.....
            FillDataGridView(this, "select * from expenses");
            FillCategoryDateGridView(this, "select * from categories");
            SetTotalLabel(this, "select sum(amount) from expenses");
            SetBudgetLabel(this, $"select monthly_budget from months where month_id = {DateTime.Now.Month}");
            DBManager.OnDatabaseUpdated += FillDataGridView;
            DBManager.OnCategoryDatabaseUpdated += FillCategoryDateGridView;
        }

        private int row;
        private bool minAndMaxDate = true , isFromAndToClicked = false;
       

        private void ShowInputForm(object sender, EventArgs e)
        {
            InputForm f = new InputForm();
            f.Show();
            f.Location = addPanel.PointToScreen(new Point(0,0));
        }

        private void ShowFilterPanel(object sender, EventArgs e)
        {
            filterItemPanel.Visible = true;
            SetFilterDate();
            SetFilterCategory();
            SetFilterMonth();
        }

        private void ShowCategoryForm(object sender, EventArgs e)
        {
            CategoryModifyForm c = new CategoryModifyForm();
            c.Show();
        }

        private void ShowBudgetPanel(object sender, EventArgs e)
        {
            monthbudgetPanel.Visible = true;
            monthCB.Text = DateTime.Now.Month.ToString();

            string query = $"select monthly_budget from months where month_id = {DateTime.Now.Month}";
            MySqlDataReader reader = DBManager.GetReader(query);

            while (reader.Read())
            {
                budgetNU.Value = int.Parse(reader.GetString(0));
            }
            reader.Close();
        }



        #region FilterEvents

        private void FilterCategoryCBSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = filterCategoryCB.Text ,query = "";
            if (isFromAndToClicked)
            {
                FilterDateValueChanged(null, EventArgs.Empty);            
            }
            else
            {   
                if(filterDayCB.Text != "PICK" && filterDayCB.Text != "PICK MONTH")
                {
                    int selectedDay = int.Parse(filterDayCB.Text);
                    int selectedMonth = DBManager.GetMonthNumber(filterMonthCB.Text);

                    if(selectedCategory == "SELECT ALL")
                        query = $"select * from expenses where DAY(date) = {selectedDay} and MONTH(date) = {selectedMonth} ";                   
                    else
                        query = $"select * from expenses where DAY(date) = {selectedDay} and MONTH(date) = {selectedMonth} and category = '{selectedCategory}' ";
                    FillDataGridView(null, query);
                }

                else if (filterMonthCB.Text != "PICK")
                {
                    int selectedMonth = DBManager.GetMonthNumber(filterMonthCB.Text);
                    if (selectedCategory == "SELECT ALL")
                        query = $"select * from expenses where MONTH(date) = {selectedMonth}  ";
                    else
                        query = $"select * from expenses where MONTH(date) = {selectedMonth} and category = '{selectedCategory}' ";

                    FillDataGridView(null, query);
                }

                else if (selectedCategory == "SELECT ALL")
                    query = $"select * from expenses";

                else
                    query = $"select * from expenses where category = '{selectedCategory}' ";
                FillDataGridView(null, query);
            }

           
        }
      
        private void FilterDateValueChanged(object sender, EventArgs e)
        {
            isFromAndToClicked = true;

            if (minAndMaxDate)
            {
                string FromDate = filterFromDTP.Value.ToString("yyyy-MM-dd");
                string ToDate = filterToDTP.Value.ToString("yyyy-MM-dd");
                string selectedCategory = filterCategoryCB.Text;
                string query = "";

                if(selectedCategory == "SELECT ALL")
                    query = $"select * from expenses where Date between '{FromDate}' and '{ToDate}' ";
                else
                    query = $"select * from expenses where Date between '{FromDate}' and '{ToDate}' and category = '{selectedCategory}' ";

                FillDataGridView(null, query);
            }

            filterMonthCB.Text = "PICK";
            filterDayCB.Text = "PICK MONTH";
            filterDayCB.Items.Clear();
        }

        private void FilterMonthCBSelectedIndexChanged(object sender, EventArgs e)
        {
            isFromAndToClicked = false;
            int selectedMonth = DBManager.GetMonthNumber(filterMonthCB.Text);
            string query = $"select * from expenses where MONTH(date) = {selectedMonth} ";
            FillDataGridView(null, query);
            filterDayCB.Text = "PICK";
            SetFilterDay();
        }


        private void FilterDayCBSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = filterCategoryCB.Text;
            int day = int.Parse(filterDayCB.Text);
            string query = "";

            if (selectedCategory == "SELECT ALL") 
             query = $"select * from expenses where Day(Date) = {day} ";
            else
             query = $"select * from expenses where Day(Date) = {day} and category = '{selectedCategory}' ";

            FillDataGridView(null, query);
        }

        private void FilterCancelClick(object sender, EventArgs e)
        {
            filterItemPanel.Visible = false;
            string query = $"select * from expenses";
            filterDayCB.Text = "PICK MONTH";
            filterMonthCB.Text = "PICK";
            filterDayCB.Items.Clear();
            FillDataGridView(null, query);
        }

        #endregion

        #region row edit and delete click

        private void EditBtClick(object sender, EventArgs e)
        {

            Expense expense = new Expense()
            {
                
                Id = (int)dataGridView.Rows[row].Cells[0].Value,
                Date = DateTime.Parse(dataGridView.Rows[row].Cells[1].Value.ToString()),
                Category = dataGridView.Rows[row].Cells[2].Value.ToString(),
                Name = dataGridView.Rows[row].Cells[3].Value.ToString(),
                Amount = int.Parse(dataGridView.Rows[row].Cells[4].Value.ToString()),
                Description = dataGridView.Rows[row].Cells[5].Value.ToString()

            };

            InputForm inputForm  = new InputForm();
            inputForm.SetData(expense);
            inputForm.Location = Cursor.Position;
            inputForm.ShowDialog();

        }

       

        private void DeletBtClick(object sender, EventArgs e)
        {
            Expense expense = new Expense()
            {             
                Id = (int)dataGridView.Rows[row].Cells[0].Value,
                Date = DateTime.Parse(dataGridView.Rows[row].Cells[1].Value.ToString()),
                Category = dataGridView.Rows[row].Cells[2].Value.ToString(),
                Name = dataGridView.Rows[row].Cells[3].Value.ToString(),
                Amount = int.Parse(dataGridView.Rows[row].Cells[4].Value.ToString()),
                Description = dataGridView.Rows[row].Cells[5].Value.ToString()
            };
            DBManager.DeleteExpense(expense);
            rowUpdatePanel.Visible = false;
        }

        #endregion

        #region DataGrid Mouse Events

        private void DataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {         
              rowUpdatePanel.Visible = true;
              if (row == 0)
                  rowUpdatePanel.Location = new Point(0, 25);
              else
                  rowUpdatePanel.Location = new Point(0, (row + 1) * 21);         
        }

        private void DataGridViewCellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        #endregion

        private void FillDataGridView(object sender, string query)
        {
            try
            {
                MySqlDataReader reader = DBManager.GetReader(query);
                
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                dataGridView.Columns[0].Visible = false;
                dataGridView.ClearSelection();               
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occurs when filling in Expense Data Grid View: " + ex.Message);
            }

        }

        private void FillCategoryDateGridView(object sender , string query)
        {
            try
            {
                MySqlDataReader reader = DBManager.GetReader(query);
             
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                categoryDataGridView.DataSource = dataTable;
                categoryDataGridView.Columns[0].Visible = false;
                categoryDataGridView.Columns[2].Visible = false;
                categoryDataGridView.ClearSelection();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs when filling in Category Data Grid View:" + ex.Message);
            }
        }

        private void SetTotalLabel(object sender, string query)
        {
            MySqlDataReader reader = DBManager.GetReader(query);
            while (reader.Read())
            {
                if (reader != null) ;
                  totalLabel.Text = reader.GetString(0);
            }
            reader.Close();
        }

        private void SetBudgetLabel(object sender, string query)
        {
            MySqlDataReader reader = DBManager.GetReader(query);
            while (reader.Read())
            {
                budgetLabel.Text = reader.GetString(0);
            }
            reader.Close();
        }

        private void SetFilterCategory()
        {
            filterCategoryCB.Items.Clear();
            try
            {
                string query = "SELECT CAT_NAME FROM categories";
                MySqlDataReader reader = DBManager.GetReader(query);

                while (reader.Read())
                {
                    if (reader.GetString(0) != "Others")
                        filterCategoryCB.Items.Add(reader.GetString(0));
                }
                reader.Close();
                filterCategoryCB.Items.Add("Others");
                filterCategoryCB.Items.Add("SELECT ALL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in category filter section: " + ex.Message);
            }
            
        }

        private void SetFilterDate()
        {
            minAndMaxDate = false;
            string query = "SELECT MIN(DATE) FROM expenses";
            MySqlDataReader reader = DBManager.GetReader(query);

            while (reader.Read())
            {
                filterFromDTP.MinDate = DateTime.Parse(reader.GetString(0));
                filterToDTP.MinDate = DateTime.Parse(reader.GetString(0));
                filterFromDTP.Value = filterFromDTP.MinDate;
            }

            reader.Close();

            query = "SELECT MAX(DATE) FROM expenses";
            MySqlDataReader maxReader = DBManager.GetReader(query);
            while (maxReader.Read())
            {
                  filterFromDTP.MaxDate = DateTime.Parse(maxReader.GetString(0));
                  filterToDTP.MaxDate = DateTime.Parse(maxReader.GetString(0));
                  filterToDTP.Value = filterToDTP.MaxDate;
            }
            
            maxReader.Close();
            minAndMaxDate = true;

        }

        private void SetFilterMonth()
        {
            filterMonthCB.Items.Clear();

            for (int i = filterFromDTP.MinDate.Month; i <= filterToDTP.MaxDate.Month; i++)
            {
                filterMonthCB.Items.Add(DBManager.GetMonthName(i));
            }

        }

        private void SetFilterDay()
        {
            filterDayCB.Items.Clear();
            int month = DBManager.KeyMonthNameDict[filterMonthCB.Text];
            string query = $"SELECT Distinct(DAY(date)) as date FROM expenses where MONTH(date) ={month} order by date";
            MySqlDataReader reader = DBManager.GetReader(query);

            while (reader.Read())
            {
                filterDayCB.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"select monthly_budget from months where month_id = {int.Parse(monthCB.Text)}";
            MySqlDataReader reader = DBManager.GetReader(query);

            while (reader.Read())
            {
                budgetNU.Value = int.Parse(reader.GetString(0));
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
