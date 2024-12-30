using System.Windows.Forms;

namespace BankSystem.View
{
    partial class AccountForm
    {
        private System.Windows.Forms.GroupBox groupBoxAccountDetails;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelDateOpened;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox textBoxAccountId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOpened;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Button buttonUpdateAccount;
        private System.Windows.Forms.Button buttonDeleteAccount;

        private void InitializeComponent()
        {
            this.groupBoxAccountDetails = new System.Windows.Forms.GroupBox();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.textBoxAccountId = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelDateOpened = new System.Windows.Forms.Label();
            this.dateTimePickerDateOpened = new System.Windows.Forms.DateTimePicker();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.buttonUpdateAccount = new System.Windows.Forms.Button();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.groupBoxAccountDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAccountDetails
            // 
            this.groupBoxAccountDetails.Controls.Add(this.labelAccountId);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxAccountId);
            this.groupBoxAccountDetails.Controls.Add(this.labelCustomerId);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxCustomerId);
            this.groupBoxAccountDetails.Controls.Add(this.labelDateOpened);
            this.groupBoxAccountDetails.Controls.Add(this.dateTimePickerDateOpened);
            this.groupBoxAccountDetails.Controls.Add(this.labelBalance);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxBalance);
            this.groupBoxAccountDetails.Location = new System.Drawing.Point(12, 75);
            this.groupBoxAccountDetails.Name = "groupBoxAccountDetails";
            this.groupBoxAccountDetails.Size = new System.Drawing.Size(441, 170);
            this.groupBoxAccountDetails.TabIndex = 0;
            this.groupBoxAccountDetails.TabStop = false;
            this.groupBoxAccountDetails.Text = "Thông tin tài khoản";
            // 
            // labelAccountId
            // 
            this.labelAccountId.Location = new System.Drawing.Point(70, 33);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(104, 23);
            this.labelAccountId.TabIndex = 0;
            this.labelAccountId.Text = "Mã tài khoản:";
            // 
            // textBoxAccountId
            // 
            this.textBoxAccountId.Location = new System.Drawing.Point(180, 33);
            this.textBoxAccountId.Name = "textBoxAccountId";
            this.textBoxAccountId.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountId.TabIndex = 1;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.Location = new System.Drawing.Point(70, 63);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(104, 23);
            this.labelCustomerId.TabIndex = 2;
            this.labelCustomerId.Text = "Mã khách hàng:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(180, 63);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerId.TabIndex = 3;
            // 
            // labelDateOpened
            // 
            this.labelDateOpened.Location = new System.Drawing.Point(70, 93);
            this.labelDateOpened.Name = "labelDateOpened";
            this.labelDateOpened.Size = new System.Drawing.Size(104, 23);
            this.labelDateOpened.TabIndex = 4;
            this.labelDateOpened.Text = "Ngày mở:";
            // 
            // dateTimePickerDateOpened
            // 
            this.dateTimePickerDateOpened.Location = new System.Drawing.Point(180, 93);
            this.dateTimePickerDateOpened.Name = "dateTimePickerDateOpened";
            this.dateTimePickerDateOpened.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateOpened.TabIndex = 5;
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(70, 123);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(104, 23);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "Số dư:";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(180, 123);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(200, 22);
            this.textBoxBalance.TabIndex = 7;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAddAccount);
            this.panelButtons.Controls.Add(this.buttonUpdateAccount);
            this.panelButtons.Controls.Add(this.buttonDeleteAccount);
            this.panelButtons.Location = new System.Drawing.Point(12, 408);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(441, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Location = new System.Drawing.Point(15, 10);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(100, 30);
            this.buttonAddAccount.TabIndex = 0;
            this.buttonAddAccount.Text = "Thêm";
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdateAccount
            // 
            this.buttonUpdateAccount.Location = new System.Drawing.Point(170, 10);
            this.buttonUpdateAccount.Name = "buttonUpdateAccount";
            this.buttonUpdateAccount.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdateAccount.TabIndex = 0;
            this.buttonUpdateAccount.Text = "Cập nhật";
            this.buttonUpdateAccount.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Location = new System.Drawing.Point(326, 10);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteAccount.TabIndex = 2;
            this.buttonDeleteAccount.Text = "Xoá";
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(87, 9);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(291, 35);
            this.titleMain.TabIndex = 0;
            this.titleMain.Text = "ANTAMTAICHINH™";
            this.titleMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleSub
            // 
            this.titleSub.AutoSize = true;
            this.titleSub.Font = new System.Drawing.Font("Arial", 11F);
            this.titleSub.ForeColor = System.Drawing.Color.Black;
            this.titleSub.Location = new System.Drawing.Point(64, 44);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(358, 22);
            this.titleSub.TabIndex = 1;
            this.titleSub.Text = "AN TÂM ĐẦU TƯ, SINH LỜI BỀN VỮNG";
            this.titleSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(12, 251);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.RowHeadersWidth = 51;
            this.dataGridViewAccounts.RowTemplate.Height = 24;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewAccounts.TabIndex = 2;
            this.dataGridViewAccounts.SelectionChanged += new System.EventHandler(this.dataGridViewAccounts_SelectionChanged);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(463, 470);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.groupBoxAccountDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.groupBoxAccountDetails.ResumeLayout(false);
            this.groupBoxAccountDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
