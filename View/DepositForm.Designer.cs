using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem.View
{
    partial class DepositForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxDepositRecipients;
        private System.Windows.Forms.GroupBox groupBoxDepositDetails;
        private System.Windows.Forms.GroupBox groupBoxDescriptions;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelDepositAmount;
        private System.Windows.Forms.Label labelDepositPin;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;
        private System.Windows.Forms.Label labelBranchId;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelTransactionId;
        private System.Windows.Forms.TextBox textBoxTransactionId;
        private System.Windows.Forms.TextBox textBoxAccountId;
        private System.Windows.Forms.TextBox textBoxBranchId;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxDepositPin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDeposit;


        private void InitializeComponent()
        {
            this.groupBoxDepositRecipients = new System.Windows.Forms.GroupBox();
            this.textBoxAccountId = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelDepositPin = new System.Windows.Forms.Label();
            this.textBoxDepositPin = new System.Windows.Forms.TextBox();
            this.labelDepositAmount = new System.Windows.Forms.Label();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxDepositDetails = new System.Windows.Forms.GroupBox();
            this.labelTransactionId = new System.Windows.Forms.Label();
            this.textBoxBranchId = new System.Windows.Forms.TextBox();
            this.textBoxTransactionId = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.labelBranchId = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.groupBoxDescriptions = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.groupBoxDepositRecipients.SuspendLayout();
            this.groupBoxDepositDetails.SuspendLayout();
            this.groupBoxDescriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDepositRecipients
            // 
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxAccountId);
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxBalance);
            this.groupBoxDepositRecipients.Controls.Add(this.labelBalance);
            this.groupBoxDepositRecipients.Controls.Add(this.labelAccountId);
            this.groupBoxDepositRecipients.Controls.Add(this.labelCustomerName);
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxCustomerName);
            this.groupBoxDepositRecipients.Controls.Add(this.labelDepositPin);
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxDepositPin);
            this.groupBoxDepositRecipients.Location = new System.Drawing.Point(33, 90);
            this.groupBoxDepositRecipients.Name = "groupBoxDepositRecipients";
            this.groupBoxDepositRecipients.Size = new System.Drawing.Size(360, 213);
            this.groupBoxDepositRecipients.TabIndex = 0;
            this.groupBoxDepositRecipients.TabStop = false;
            this.groupBoxDepositRecipients.Text = "Thông tin người nhận";
            // 
            // textBoxAccountId
            // 
            this.textBoxAccountId.Location = new System.Drawing.Point(135, 41);
            this.textBoxAccountId.Name = "textBoxAccountId";
            this.textBoxAccountId.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountId.TabIndex = 1;
            this.textBoxAccountId.TextChanged += new System.EventHandler(this.textBoxAccountId_TextChanged);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(135, 123);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(200, 22);
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.TabIndex = 5;
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(25, 124);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(100, 20);
            this.labelBalance.TabIndex = 4;
            this.labelBalance.Text = "Số dư:";
            // 
            // labelAccountId
            // 
            this.labelAccountId.Location = new System.Drawing.Point(25, 44);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(100, 20);
            this.labelAccountId.TabIndex = 0;
            this.labelAccountId.Text = "Mã tài khoản:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Location = new System.Drawing.Point(25, 84);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(100, 20);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Tên tài khoản:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(135, 83);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerName.TabIndex = 3;
            this.textBoxCustomerName.ReadOnly = true;
            // 
            // labelDepositPin
            // 
            this.labelDepositPin.Location = new System.Drawing.Point(25, 163);
            this.labelDepositPin.Name = "labelDepositPin";
            this.labelDepositPin.Size = new System.Drawing.Size(100, 20);
            this.labelDepositPin.TabIndex = 4;
            this.labelDepositPin.Text = "Mã PIN:";
            // 
            // textBoxDepositPin
            // 
            this.textBoxDepositPin.Location = new System.Drawing.Point(135, 163);
            this.textBoxDepositPin.Name = "textBoxDepositPin";
            this.textBoxDepositPin.Size = new System.Drawing.Size(200, 22);
            this.textBoxDepositPin.TabIndex = 5;
            this.textBoxDepositPin.ReadOnly = true;
            // 
            // labelDepositAmount
            // 
            this.labelDepositAmount.Location = new System.Drawing.Point(25, 160);
            this.labelDepositAmount.Name = "labelDepositAmount";
            this.labelDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.labelDepositAmount.TabIndex = 2;
            this.labelDepositAmount.Text = "Số tiền gửi:";
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(135, 160);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxDepositAmount.TabIndex = 3;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(280, 453);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(100, 30);
            this.buttonDeposit.TabIndex = 6;
            this.buttonDeposit.Text = "Nạp tiền";
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(430, 453);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Xoá";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxDepositDetails
            // 
            this.groupBoxDepositDetails.Controls.Add(this.labelTransactionId);
            this.groupBoxDepositDetails.Controls.Add(this.textBoxBranchId);
            this.groupBoxDepositDetails.Controls.Add(this.textBoxTransactionId);
            this.groupBoxDepositDetails.Controls.Add(this.textBoxEmployeeId);
            this.groupBoxDepositDetails.Controls.Add(this.labelBranchId);
            this.groupBoxDepositDetails.Controls.Add(this.labelDepositAmount);
            this.groupBoxDepositDetails.Controls.Add(this.textBoxDepositAmount);
            this.groupBoxDepositDetails.Controls.Add(this.labelEmployeeId);
            this.groupBoxDepositDetails.Location = new System.Drawing.Point(419, 90);
            this.groupBoxDepositDetails.Name = "groupBoxDepositDetails";
            this.groupBoxDepositDetails.Size = new System.Drawing.Size(360, 213);
            this.groupBoxDepositDetails.TabIndex = 7;
            this.groupBoxDepositDetails.TabStop = false;
            this.groupBoxDepositDetails.Text = "Thông tin gửi tiền";
            // 
            // labelTransactionId
            // 
            this.labelTransactionId.Location = new System.Drawing.Point(25, 41);
            this.labelTransactionId.Name = "labelTransactionId";
            this.labelTransactionId.Size = new System.Drawing.Size(100, 20);
            this.labelTransactionId.TabIndex = 0;
            this.labelTransactionId.Text = "Mã giao dịch:";
            // 
            // textBoxBranchId
            // 
            this.textBoxBranchId.Location = new System.Drawing.Point(135, 80);
            this.textBoxBranchId.Name = "textBoxBranchId";
            this.textBoxBranchId.Size = new System.Drawing.Size(200, 22);
            this.textBoxBranchId.TabIndex = 3;
            // 
            // textBoxTransactionId
            // 
            this.textBoxTransactionId.Location = new System.Drawing.Point(135, 40);
            this.textBoxTransactionId.Name = "textBoxTransactionId";
            this.textBoxTransactionId.Size = new System.Drawing.Size(200, 22);
            this.textBoxTransactionId.TabIndex = 1;
            this.textBoxTransactionId.ReadOnly = true;
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(135, 120);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmployeeId.TabIndex = 3;
            // 
            // labelBranchId
            // 
            this.labelBranchId.Location = new System.Drawing.Point(25, 80);
            this.labelBranchId.Name = "labelBranchId";
            this.labelBranchId.Size = new System.Drawing.Size(100, 20);
            this.labelBranchId.TabIndex = 2;
            this.labelBranchId.Text = "Mã chi nhánh:";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelEmployeeId.Location = new System.Drawing.Point(25, 123);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.labelEmployeeId.TabIndex = 2;
            this.labelEmployeeId.Text = "Mã nhân viên:";
            // 
            // groupBoxDescriptions
            // 
            this.groupBoxDescriptions.Controls.Add(this.textBoxDescription);
            this.groupBoxDescriptions.Location = new System.Drawing.Point(33, 315);
            this.groupBoxDescriptions.Name = "groupBoxDescriptions";
            this.groupBoxDescriptions.Size = new System.Drawing.Size(746, 124);
            this.groupBoxDescriptions.TabIndex = 8;
            this.groupBoxDescriptions.TabStop = false;
            this.groupBoxDescriptions.Text = "Nội dung gửi tiền";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(28, 25);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(693, 82);
            this.textBoxDescription.TabIndex = 1;
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(257, 9);
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
            this.titleSub.Location = new System.Drawing.Point(234, 44);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(358, 22);
            this.titleSub.TabIndex = 1;
            this.titleSub.Text = "AN TÂM ĐẦU TƯ, SINH LỜI BỀN VỮNG";
            this.titleSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(811, 501);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxDescriptions);
            this.Controls.Add(this.groupBoxDepositDetails);
            this.Controls.Add(this.groupBoxDepositRecipients);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Form";
            this.groupBoxDepositRecipients.ResumeLayout(false);
            this.groupBoxDepositRecipients.PerformLayout();
            this.groupBoxDepositDetails.ResumeLayout(false);
            this.groupBoxDepositDetails.PerformLayout();
            this.groupBoxDescriptions.ResumeLayout(false);
            this.groupBoxDescriptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
