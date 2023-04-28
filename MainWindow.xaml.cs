using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Practical_Work__4
{
    
    public partial class MainWindow : Window
    {
        private finance_dbEntities _Finance;
        public MainWindow()
        {
            InitializeComponent();
            _Finance = new finance_dbEntities();
        }
        public void ShowTablesAndUpdate()
        {
            if (comboBox.SelectedIndex == 0)
            {
                FinanceDataGrid.ItemsSource = _Finance.accounts.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 1)
            {
                FinanceDataGrid.ItemsSource = _Finance.budget_items.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 2)
            {
                FinanceDataGrid.ItemsSource = _Finance.expenses.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 3)
            {
                FinanceDataGrid.ItemsSource = _Finance.income.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 4)
            {
                FinanceDataGrid.ItemsSource = _Finance.tax_rates.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 5)
            {
                FinanceDataGrid.ItemsSource = _Finance.tax_reporting.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 6)
            {
                FinanceDataGrid.ItemsSource = _Finance.transactions.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
        }
        public void ShowTables()
        {
            if (comboBox.SelectedIndex == 0)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 1)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 2)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 3)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 4)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 5)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 6)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTablesAndUpdate();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputText = textBox.Text.ToLower();
            if (comboBox.SelectedIndex == 0 && textBox.Text != "")
            {
                List<accounts> list_accounts = _Finance.accounts.ToList();
                var account = list_accounts.Where(
                l => l.account_id.ToString().ToLower().Contains(inputText) ||
                l.account_name.ToString().ToLower().Contains(inputText) ||
                l.account_type.ToString().ToLower().Contains(inputText) ||
                l.account_balance.ToString().ToLower().Contains(inputText) ||
                l.account_description.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = account.ToList();
            }
            else if (comboBox.SelectedIndex == 0 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 1 && textBox.Text != "")
            {
                List<budget_items> list_budget_items = _Finance.budget_items.ToList();
                var budget_item = list_budget_items.Where(
                l => l.budget_id.ToString().ToLower().Contains(inputText) ||
                l.budget_name.ToString().ToLower().Contains(inputText) ||
                l.budget_amount.ToString().ToLower().Contains(inputText) ||
                l.budget_category.ToString().ToLower().Contains(inputText) ||
                l.budget_month.ToString().ToLower().Contains(inputText) ||
                l.budget_description.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = budget_item.ToList();
            }
            else if (comboBox.SelectedIndex == 1 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 2 && textBox.Text != "")
            {
                List<expenses> list_expenses = _Finance.expenses.ToList();
                var expense = list_expenses.Where(
                l => l.expense_id.ToString().ToLower().Contains(inputText) ||
                l.expense_name.ToString().ToLower().Contains(inputText) ||
                l.expense_amount.ToString().ToLower().Contains(inputText) ||
                l.expense_date.ToString().ToLower().Contains(inputText) ||
                l.expense_category.ToString().ToLower().Contains(inputText) ||
                l.expense_description.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = expense.ToList();
            }
            else if (comboBox.SelectedIndex == 2 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 3 && textBox.Text != "")
            {
                List<income> list_income = _Finance.income.ToList();
                var income = list_income.Where(
                l => l.income_id.ToString().ToLower().Contains(inputText) ||
                l.income_name.ToString().ToLower().Contains(inputText) ||
                l.income_amount.ToString().ToLower().Contains(inputText) ||
                l.income_date.ToString().ToLower().Contains(inputText) ||
                l.income_category.ToString().ToLower().Contains(inputText) ||
                l.income_description.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = income.ToList();
            }
            else if (comboBox.SelectedIndex == 3 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 4 && textBox.Text != "")
            {
                List<tax_rates> list_tax_rates = _Finance.tax_rates.ToList();
                var tax_rate = list_tax_rates.Where(
                l => l.tax_id.ToString().ToLower().Contains(inputText) ||
                l.tax_name.ToString().ToLower().Contains(inputText) ||
                l.tax_rate.ToString().ToLower().Contains(inputText) ||
                l.tax_description.ToString().ToLower().Contains(inputText) ||
                l.tax_reporting.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = tax_rate.ToList();
            }
            else if (comboBox.SelectedIndex == 4 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 5 && textBox.Text != "")
            {
                List<tax_reporting> list_tax_reporting = _Finance.tax_reporting.ToList();
                var tax_report = list_tax_reporting.Where(
                l => l.tax_report_id.ToString().ToLower().Contains(inputText) ||
                l.tax_report_name.ToString().ToLower().Contains(inputText) ||
                l.tax_report_date.ToString().ToLower().Contains(inputText) ||
                l.tax_report_amount.ToString().ToLower().Contains(inputText) ||
                l.tax_id.ToString().ToLower().Contains(inputText) ||
                l.tax_rates.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = tax_report.ToList();
            }
            else if (comboBox.SelectedIndex == 5 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 6 && textBox.Text != "")
            {
                List<transactions> list_transactions = _Finance.transactions.ToList();
                var transaction = list_transactions.Where(
                l => l.transaction_id.ToString().ToLower().Contains(inputText) ||
                l.transaction_date.ToString().ToLower().Contains(inputText) ||
                l.transaction_amount.ToString().ToLower().Contains(inputText) ||
                l.transaction_type.ToString().ToLower().Contains(inputText) ||
                l.transaction_description.ToString().ToLower().Contains(inputText) ||
                l.account_id.ToString().ToLower().Contains(inputText) ||
                l.accounts.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = transaction.ToList();
            }
            else if (comboBox.SelectedIndex == 6 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            ShowTables();
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                accounts account = new accounts();
                account.account_name = null;
                account.account_type = null;
                account.account_description = null;
                account.transactions = null;
                _Finance.accounts.Add(account);
                _Finance.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 1)
            {
                budget_items budget_item = new budget_items();
                budget_item.budget_name = null;
                budget_item.budget_category = null;
                budget_item.budget_description = null;
                _Finance.budget_items.Add(budget_item);
                _Finance.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 2)
            {
                expenses expense = new expenses();
                expense.expense_name = null;
                expense.expense_category = null;
                expense.expense_description = null;
                _Finance.expenses.Add(expense);
                _Finance.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 3)
            {
                income incom = new income();
                incom.income_name = null;
                incom.income_category = null;
                incom.income_description = null;
                _Finance.income.Add(incom);
                _Finance.SaveChanges();
                ShowTablesAndUpdate();

            }
            if (comboBox.SelectedIndex == 4)
            {
                tax_rates tax_rate = new tax_rates();
                tax_rate.tax_name = null;
                tax_rate.tax_description = null;
                tax_rate.tax_reporting = null;
                _Finance.tax_rates.Add(tax_rate);
                _Finance.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 5)
            {
                tax_reporting tax_report = new tax_reporting();
                tax_report.tax_report_name = null;
                tax_report.tax_rates = null;
                _Finance.tax_reporting.Add(tax_report);
                _Finance.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 6)
            {
                transactions transaction = new transactions();
                transaction.transaction_type = null;
                transaction.transaction_description = null;
                transaction.accounts = null;
                _Finance.transactions.Add(transaction);
                _Finance.SaveChanges();
                ShowTablesAndUpdate();
            }
        }
        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                accounts account = FinanceDataGrid.SelectedItem as accounts;
                _Finance.accounts.Remove(account);
                _Finance.SaveChanges();
                FinanceDataGrid.ItemsSource = _Finance.accounts.ToList();
                ShowTables();
            }
            if (comboBox.SelectedIndex == 1)
            {
                budget_items budget_item = FinanceDataGrid.SelectedItem as budget_items;
                _Finance.budget_items.Remove(budget_item);
                _Finance.SaveChanges();
                FinanceDataGrid.ItemsSource = _Finance.budget_items.ToList();
                ShowTables();
            }
            if (comboBox.SelectedIndex == 2)
            {
                expenses expense = FinanceDataGrid.SelectedItem as expenses;
                _Finance.expenses.Remove(expense);
                _Finance.SaveChanges();
                FinanceDataGrid.ItemsSource = _Finance.expenses.ToList();
                ShowTables();
            }
            if (comboBox.SelectedIndex == 3)
            {
                income incom = FinanceDataGrid.SelectedItem as income;
                _Finance.income.Remove(incom);
                _Finance.SaveChanges();
                FinanceDataGrid.ItemsSource = _Finance.income.ToList();
                ShowTables();
            }
            if (comboBox.SelectedIndex == 4)
            {
                tax_rates tax_rate = FinanceDataGrid.SelectedItem as tax_rates;
                _Finance.tax_rates.Remove(tax_rate);
                _Finance.SaveChanges();
                FinanceDataGrid.ItemsSource = _Finance.tax_rates.ToList();
                ShowTables();
            }
            if (comboBox.SelectedIndex == 5)
            {
                tax_reporting tax_report = FinanceDataGrid.SelectedItem as tax_reporting;
                _Finance.tax_reporting.Remove(tax_report);
                _Finance.SaveChanges();
                FinanceDataGrid.ItemsSource = _Finance.tax_reporting.ToList();
                ShowTables();
            }
            if (comboBox.SelectedIndex == 6)
            {
                transactions transaction = FinanceDataGrid.SelectedItem as transactions;
                _Finance.transactions.Remove(transaction);
                _Finance.SaveChanges();
                FinanceDataGrid.ItemsSource = _Finance.transactions.ToList();
                ShowTables();
            }
        }
        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            ShowTablesAndUpdate();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                _Finance.SaveChanges();
                ShowTablesAndUpdate();
            }
        }
    }
}
