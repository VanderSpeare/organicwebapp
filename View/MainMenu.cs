using System;
using System.Windows.Forms;
using BankSystem.Controller;

namespace BankSystem.View
{
    public partial class MainMenu : Form
    {
        private LoginController loginController;
        private string currentUserRole;
        private string currentUserId;

        public MainMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.KeyPreview = true;

            // Ẩn các mục menu khi chưa đăng nhập
            HideMenuItems();

            // Thêm event xử lý khi đóng form để yêu cầu xác nhận
            this.FormClosing += MainMenu_FormClosing;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            OpenLoginForm();
        }

        private void HideMenuItems()
        {
            systemMenuItem.Visible = false;
            bankingMenuItem.Visible = false;
            helpMenuItem.Visible = false;
            logoutMenuItem.Visible = false;
        }

        private void ShowMenuItems(string role)
        {
            systemMenuItem.Visible = true;
            bankingMenuItem.Visible = true;
            helpMenuItem.Visible = true;
            logoutMenuItem.Visible = true;

            employeeMenuItem.Visible = role == "Admin";
        }

        private void OpenLoginForm()
        {
            Login loginForm = new Login();
            loginForm.StartPosition = FormStartPosition.CenterScreen;

            loginForm.ShowDialog();

            if (loginForm.IsAuthenticated)
            {
                currentUserId = loginForm.AuthenticatedUserId;
                currentUserRole = loginForm.AuthenticatedUserRole;
                ShowMenuItems(currentUserRole);

                toolStripUserLabel.Text = $"Chào: {currentUserId}";
                toolStripUserLabel.Visible = true;
                loginMenuItem.Visible = false;
            }
            else
            {
                Application.Exit();
            }
        }

        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            currentUserId = null;
            currentUserRole = null;
            toolStripUserLabel.Visible = false;
            loginMenuItem.Visible = true;
            HideMenuItems();

            MessageBox.Show("Bạn đã đăng xuất thành công!", "Đăng xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenLoginForm();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && currentUserId != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Logout();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void employeeMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            OpenChildForm(employeeForm);
        }

        private void branchMenuItem_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm();
            OpenChildForm(branchForm);
        }

        private void customerMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            OpenChildForm(customerForm);
        }

        private void accountMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            OpenChildForm(accountForm);
        }

        private void depositMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            OpenChildForm(depositForm);
        }

        private void withdrawMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm();
            OpenChildForm(withdrawForm);
        }

        private void transferMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            OpenChildForm(transferForm);
        }

        private void balanceMenuItem_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm = new BalanceForm();
            OpenChildForm(balanceForm);
        }

        // Xác nhận khi người dùng đóng MainMenu
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy đóng form nếu người dùng chọn No
            }
        }
    }
}
