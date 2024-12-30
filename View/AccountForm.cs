using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem.View
{
    public partial class AccountForm : Form, IView
    {
        private AccountController controller;
        private AccountModel currentAccount;

        public AccountForm()
        {
            InitializeComponent();
            controller = new AccountController();
            InitializeDataGridView();
            LoadAccountsFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewAccounts.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn accountIdColumn = new DataGridViewTextBoxColumn();
            accountIdColumn.HeaderText = "Mã tài khoản";
            accountIdColumn.DataPropertyName = "Id";
            accountIdColumn.ReadOnly = true;
            dataGridViewAccounts.Columns.Add(accountIdColumn);

            DataGridViewTextBoxColumn customerIdColumn = new DataGridViewTextBoxColumn();
            customerIdColumn.HeaderText = "Mã khách hàng";
            customerIdColumn.DataPropertyName = "CustomerId";
            customerIdColumn.ReadOnly = true;
            dataGridViewAccounts.Columns.Add(customerIdColumn);

            DataGridViewTextBoxColumn dateOpenedColumn = new DataGridViewTextBoxColumn();
            dateOpenedColumn.HeaderText = "Ngày mở";
            dateOpenedColumn.DataPropertyName = "DateOpened";
            dateOpenedColumn.ReadOnly = true;
            dataGridViewAccounts.Columns.Add(dateOpenedColumn);

            DataGridViewTextBoxColumn balanceColumn = new DataGridViewTextBoxColumn();
            balanceColumn.HeaderText = "Số dư";
            balanceColumn.DataPropertyName = "Balance";
            balanceColumn.ReadOnly = true;
            dataGridViewAccounts.Columns.Add(balanceColumn);
        }

        // Load danh sách tài khoản từ cơ sở dữ liệu
        private void LoadAccountsFromDatabase()
        {
            controller.Load();
            var accounts = controller.Items.Cast<AccountModel>().ToList();
            dataGridViewAccounts.DataSource = accounts;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentAccount == null) currentAccount = new AccountModel();

            currentAccount.Id = int.Parse(textBoxAccountId.Text);
            currentAccount.CustomerId = textBoxCustomerId.Text;
            currentAccount.DateOpened = dateTimePickerDateOpened.Value;
            currentAccount.Balance = float.Parse(textBoxBalance.Text);
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var account = item as AccountModel;
            if (account != null)
            {
                textBoxAccountId.Text = account.Id.ToString();
                textBoxCustomerId.Text = account.CustomerId;
                dateTimePickerDateOpened.Value = account.DateOpened;
                textBoxBalance.Text = account.Balance.ToString();
            }
        }

        // Thêm tài khoản
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAccountId.Text) || string.IsNullOrEmpty(textBoxCustomerId.Text))
            {
                MessageBox.Show("Cần nhập Mã tài khoản và Mã khách hàng.");
                return;
            }

            GetDataFromText();
            if (controller.Create(currentAccount))
            {
                LoadAccountsFromDatabase();
                MessageBox.Show("Đã thêm Tài khoản thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Tài khoản.");
            }
        }

        // Cập nhật khách hàng
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewAccounts.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                GetDataFromText();
                if (controller.Update(currentAccount))
                {
                    LoadAccountsFromDatabase();
                    MessageBox.Show("Cập nhật Tài khoản thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật Tài khoản.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Tài khoản để cập nhật.");
            }
        }

        // Xóa tài khoản
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewAccounts.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                AccountModel account = selectedRow.DataBoundItem as AccountModel;
                if (account != null)
                {
                    if (controller.Delete(account.Id))
                    {
                        ConfirmDelete();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá tài khoản.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn tài khoản để xoá.");
            }
        }

        // Hiển thị xác nhận trước khi xoá
        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadAccountsFromDatabase();
                MessageBox.Show("Đã xoá tài khoản thành công.");
            }
        }

        //// Thêm hoặc cập nhật tài khoản
        //private void buttonSave_Click(object sender, EventArgs e)
        //{
        //    GetDataFromText();
        //    if (controller.IsExist(currentAccount.Id))
        //    {
        //        controller.Update(currentAccount);
        //        MessageBox.Show("Cập nhật tài khoản thành công.");
        //    }
        //    else
        //    {
        //        controller.Create(currentAccount);
        //        MessageBox.Show("Đã thêm tài khoản thành công.");
        //    }
        //    LoadAccountsFromDatabase();
        //    ClearForm();
        //}

        // Hiển thị thông tin tài khoản khi chọn trong DataGridView
        private void dataGridViewAccounts_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewAccounts.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var account = (AccountModel)selectedRow.DataBoundItem;
                SetDataToText(account);
            }
        }

        // Xoá dữ liệu form
        private void ClearForm()
        {
            textBoxAccountId.Clear();
            textBoxCustomerId.Clear();
            dateTimePickerDateOpened.Value = DateTime.Now;
            textBoxBalance.Clear();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
