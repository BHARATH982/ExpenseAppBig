
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpenseAPPBig
{
    public static class DBManager
    {
        private static readonly string server = "192.168.3.71";
        private static readonly string database = "expenseappdb";
        private static readonly string user = "bharath";
        private static readonly string password = "bharath";
        private static readonly string connectionString = $"server={server};user={user};password={password};database={database}";
        public static MySqlConnection Connection = null;

        public static event EventHandler<string> OnDatabaseUpdated;
        public static event EventHandler<string> OnCategoryDatabaseUpdated;
        public static event EventHandler<string> OnCategoryUpdated;

        private static String insertQuery;
        private static String updateQuery;
        private static String deleteQuery;

        public static Dictionary<int, string> KeyMonthNoDict = new Dictionary<int, string>
        {
            {1, "January"},
            {2, "February"},
            {3, "March"},
            {4, "April"},
            {5, "May"},
            {6, "June"},
            {7, "July"},
            {8, "August"},
            {9, "September"},
            {10, "October"},
            {11, "November"},
            {12, "December"}
        };

        public static Dictionary<string, int> KeyMonthNameDict = new Dictionary<string, int>
        {
            {"January", 1},
            {"February", 2},
            {"March", 3},
            {"April", 4},
            {"May", 5},
            {"June", 6},
            {"July", 7},
            {"August", 8},
            {"September", 9},
            {"October", 10},
            {"November", 11},
            {"December", 12}
        };

        public static void GetConnection()
        {
            Connection = new MySqlConnection(connectionString);
            Connection.Open();
        }

        #region Add, Update , Delete 

        public static Boolean AddExpenseInDB(Expense expense)
        {
            insertQuery = $"insert into expenses(DATE,CATEGORY,NAME,AMOUNT,DESCRIPTION) values ('{expense.Date.ToString("yyyy-MM-dd")}', '{expense.Category}','{expense.Name}',{expense.Amount},'{expense.Description}')";
            MySqlCommand cmd = new MySqlCommand(insertQuery, Connection);
            int rowsAffected = cmd.ExecuteNonQuery();

            MySqlDataReader reader = GetReader($"select CAT_BUDGET , CUR_BUDGET from categories where CAT_NAME ='{expense.Category}'");
            int currentBudget = 0, totalBudget = 0;

            while (reader.Read())
            {
                totalBudget = int.Parse(reader.GetString(0));
                currentBudget = int.Parse(reader.GetString(1));
            }
            reader.Close();

            updateQuery = $"update categories set CUR_BUDGET = CUR_BUDGET + {expense.Amount} where CAT_NAME = '{expense.Category}'";
            cmd = new MySqlCommand(updateQuery, Connection);
            rowsAffected = cmd.ExecuteNonQuery();

          
            OnDatabaseUpdated?.Invoke(null, "SELECT * FROM expenses");
            OnCategoryDatabaseUpdated?.Invoke(null, "SELECT * FROM CATEGORIES");
            if (expense.Amount + currentBudget > totalBudget)
                return true;          
            return false;
        }

        public static Boolean UpdateExpenseInDB(Expense expense, int id)
        {         
            int currentAmount = 0;
            using (MySqlDataReader reader1 = GetReader($"select amount from expenses where expense_id = {id}"))
            {
                while (reader1.Read())
                    currentAmount = int.Parse(reader1.GetString(0));              
            }
            updateQuery = $"Update expenses set DATE='{expense.Date.ToString("yyyy-MM-dd")}', CATEGORY='{expense.Category}',NAME ='{expense.Name}',AMOUNT ='{expense.Amount}',DESCRIPTION ='{expense.Description}' where EXPENSE_ID ={id}";
            MySqlCommand cmd = new MySqlCommand(updateQuery, Connection);
            int rowsAffected = cmd.ExecuteNonQuery();

            updateQuery = $"update categories set CUR_BUDGET = CUR_BUDGET - {currentAmount} +{expense.Amount} where CAT_NAME  = '{expense.Category}'";
            cmd = new MySqlCommand(updateQuery, Connection);
            rowsAffected = cmd.ExecuteNonQuery();

            MySqlDataReader reader = GetReader($"SELECT CAT_BUDGET, CUR_BUDGET FROM categories WHERE CAT_NAME = '{expense.Category}'");
            int curBudget = 0, totalBudget = 0;

            while (reader.Read())
            {
                totalBudget = reader.GetInt32(0); 
                curBudget = reader.GetInt32(1);   
            }
            reader.Close();

            OnDatabaseUpdated?.Invoke(null, "SELECT * FROM expenses");
            OnCategoryDatabaseUpdated?.Invoke(null, "SELECT * FROM CATEGORIES");
            if (curBudget > totalBudget)
                return true;                
            return false;
        }

        public static void DeleteExpense(Expense expense)
        {         
            deleteQuery = $"DELETE FROM expenses WHERE EXPENSE_ID = {expense.Id}";
            MySqlCommand cmd = new MySqlCommand(deleteQuery, Connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            updateQuery = $"update categories set CUR_BUDGET = CUR_BUDGET - {expense.Amount} where CAT_NAME = '{expense.Category}'";
            cmd = new MySqlCommand(updateQuery, Connection);
            rowsAffected = cmd.ExecuteNonQuery();         
            OnDatabaseUpdated?.Invoke(null, "SELECT * FROM expenses");
            OnCategoryDatabaseUpdated?.Invoke(null, "SELECT * FROM CATEGORIES");

        }
        #endregion

 
        public static void ModifyMonthBudget(int month, int budget)
        {
            updateQuery = $"update months set monthly_budget = {budget} where month_id = {month}";
            MySqlCommand cmd = new MySqlCommand(updateQuery, Connection);
            int rowsAffected = cmd.ExecuteNonQuery();

        }

        #region Add , edit and Delete Category

        public static void AddNewCategory(string category, int month, int budget)
        {
            insertQuery = $"insert into categories(CAT_NAME,MONTH_ID,CAT_BUDGET,CUR_BUDGET) values('{category}',{month},{budget},0)";
            MySqlCommand cmd = new MySqlCommand(insertQuery, Connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            OnCategoryUpdated?.Invoke(null, "set category in expense input form");
            OnCategoryDatabaseUpdated?.Invoke(null, "SELECT * FROM CATEGORIES");
        }

        public static void UpdateExistingCategory(string oldCategory, string newCategory, int budget)
        {
            updateQuery = $"update categories set CAT_NAME = '{newCategory}', CAT_BUDGET = {budget} where CAT_NAME = '{oldCategory}'";
            MySqlCommand cmd = new MySqlCommand(updateQuery, Connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            updateQuery = $"update expenses set CATEGORY = '{newCategory}' where CATEGORY = '{oldCategory}' ";
            cmd = new MySqlCommand(updateQuery, Connection);
            rowsAffected = cmd.ExecuteNonQuery();
            OnDatabaseUpdated?.Invoke(null, "SELECT * FROM expenses");
            OnCategoryDatabaseUpdated?.Invoke(null, "SELECT * FROM CATEGORIES");
        }

        public static void DeleteCategory(string category)
        {
            deleteQuery = $"DELETE FROM CATEGORIES WHERE CAT_NAME ='{category}'";
            MySqlCommand cmd = new MySqlCommand(deleteQuery, DBManager.Connection);
            int rowsAffected = cmd.ExecuteNonQuery();
        }

        #endregion

        #region  Functions 

        public static MySqlDataReader GetReader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static int GetMonthNumber(string monthName)
        {
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1).ToLower();
            if (KeyMonthNameDict.ContainsKey(monthName))
                return KeyMonthNameDict[monthName];          
            else          
                throw new ArgumentException("Invalid month name");         
        }

        public static string GetMonthName(int monthNumber)
        {
            if (KeyMonthNoDict.ContainsKey(monthNumber))
            {
                return KeyMonthNoDict[monthNumber];
            }
            else
            {
                throw new ArgumentException("Invalid month number");
            }
        }


        #endregion


    }
}
