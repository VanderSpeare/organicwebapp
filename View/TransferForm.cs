using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.View
{
    public partial class TransferForm : Form
    {
        private TransactionController transactionController;
        private AccountController accountController;
        private AccountModel currentAccount;

        public TransferForm()
        {
            InitializeComponent();
            transactionController = new TransactionController(); // Sử dụng TransactionController

            // Tìm mã giao dịch mới nhất có Type là Transfer
            int? latestTransactionId = transactionController.GetLatestTransactionId();
            textBoxTransactionId.Text = (latestTransactionId.HasValue ? latestTransactionId.Value + 1 : 1).ToString(); // +1 cho mã giao dịch mới
        }

        public void SetDataToText(Object item)
        {
            if (item is BankTransactionModel transaction)
            {
                textBoxAccountFromId.Text = transaction.AccountFromId?.ToString();
                textBoxAccountToId.Text = transaction.AccountToId?.ToString();
                textBoxBranchId.Text = transaction.BranchId.ToString();
                textBoxEmployeeId.Text = transaction.EmployeeId.ToString();
                textBoxTransferAmount.Text = transaction.Amount.ToString();
                textBoxDescription.Text = transaction.Description;
            }
        }

        public void GetDataFromText()
        {
            try
            {
                int fromAccountId = int.Parse(textBoxAccountFromId.Text);
                int toAccountId = int.Parse(textBoxAccountToId.Text);
                double transferAmount = double.Parse(textBoxTransferAmount.Text);
                string employeeId = textBoxEmployeeId.Text;
                string branchId = textBoxBranchId.Text;
                string description = textBoxDescription.Text;
                string pin = textBoxWithdrawPin.Text;

                // Kiểm tra điều kiện chuyển tiền
                if (transferAmount <= 0)
                {
                    MessageBox.Show("Số tiền chuyển phải lớn hơn 0.");
                    return;
                }

                bool success = transactionController.Transfer(fromAccountId, toAccountId, transferAmount, employeeId, branchId, description, pin);

                // Gọi phương thức Transfer
                if (success)
                {
                    MessageBox.Show("Chuyển tiền thành công!");
                    ClearToFields();
                    ClearFromFields();

                    int? latestTransactionId = transactionController.GetLatestTransactionId();
                    textBoxTransactionId.Text = (latestTransactionId.HasValue ? latestTransactionId.Value + 1 : 1).ToString(); // +1 cho mã giao dịch mới
                }
                else
                {
                    MessageBox.Show("Chuyển thất bại. Hãy kiểm tra dữ liệu nhập.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường dữ liệu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void textBoxAccountFromId_TextChanged(object sender, EventArgs e)
        {
            int accountId;
            if (int.TryParse(textBoxAccountFromId.Text, out accountId))
            {
                var (customerFromName, fromBalance, pin) = transactionController.GetCustomerInfoByAccountId(accountId);
                if (customerFromName != null)
                {
                    textBoxCustomerFromName.Text = customerFromName;
                    textBoxFromBalance.Text = fromBalance.ToString("N2");
                    textBoxWithdrawPin.Text = pin; // Hiển thị mã PIN cho tài khoản gửi

                    // Thêm mô tả tự động
                    textBoxDescription.Text = $"{customerFromName.ToUpper()} CHUYEN TIEN"; // Viết hoa tên khách hàng
                }
                else
                {
                    ClearFromFields();
                }
            }
            else
            {
                ClearFromFields();
            }
        }

        private void textBoxAccountToId_TextChanged(object sender, EventArgs e)
        {
            int accountId;
            if (int.TryParse(textBoxAccountToId.Text, out accountId))
            {
                var (customerToName, toBalance, pin) = transactionController.GetCustomerInfoByAccountId(accountId);
                if (customerToName != null)
                {
                    textBoxCustomerToName.Text = customerToName;
                    textBoxToBalance.Text = toBalance.ToString("N2");
                    // Ghi đè mã PIN cho tài khoản nhận
                }
                else
                {
                    ClearToFields();
                }
            }
            else
            {
                ClearToFields();
            }
        }

        private void ClearFromFields()
        {
            textBoxCustomerFromName.Clear();
            textBoxFromBalance.Clear();
            textBoxWithdrawPin.Clear(); // Xóa mã PIN nếu không tìm thấy
        }

        private void ClearToFields()
        {
            textBoxCustomerToName.Clear();
            textBoxToBalance.Clear();
            // Xóa mã PIN nếu không tìm thấy
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            GetDataFromText();
        }

        // Xử lý sự kiện nhấn nút Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAccountFromId.Clear();
            textBoxCustomerFromName.Clear();
            textBoxFromBalance.Clear();
            textBoxCustomerToName.Clear();
            textBoxToBalance.Clear();
            textBoxWithdrawPin.Clear();
            textBoxTransferAmount.Clear();
            textBoxEmployeeId.Clear();
            textBoxBranchId.Clear();
            textBoxDescription.Clear();
            textBoxTransactionId.Clear();
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

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxDescription.Text = textBoxDescription.Text.ToUpper(); // Chuyển đổi các ký tự thành chữ hoa
        }
    }
}
