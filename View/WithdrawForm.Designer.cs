using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem.View
{
    partial class WithdrawForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxWithdrawRecipients;
        private System.Windows.Forms.GroupBox groupBoxWithdrawDetails;
        private System.Windows.Forms.GroupBox groupBoxDescriptions;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelWithdrawAmount;
        private System.Windows.Forms.Label labelWithdrawPin;
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
        private System.Windows.Forms.TextBox textBoxWithdrawAmount;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxWithdrawPin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonWithdraw;


        private void InitializeComponent()
        {
            this.groupBoxWithdrawRecipients = new System.Windows.Forms.GroupBox();
            this.textBoxAccountId = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelWithdrawPin = new System.Windows.Forms.Label();
            this.textBoxWithdrawPin = new System.Windows.Forms.TextBox();
            this.labelWithdrawAmount = new System.Windows.Forms.Label();
            this.textBoxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxWithdrawDetails = new System.Windows.Forms.GroupBox();
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
            this.groupBoxWithdrawRecipients.SuspendLayout();
            this.groupBoxWithdrawDetails.SuspendLayout();
            this.groupBoxDescriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWithdrawRecipients
            // 
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxAccountId);
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxBalance);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelBalance);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelAccountId);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelCustomerName);
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxCustomerName);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelWithdrawPin);
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxWithdrawPin);
            this.groupBoxWithdrawRecipients.Location = new System.Drawing.Point(33, 90);
            this.groupBoxWithdrawRecipients.Name = "groupBoxWithdrawRecipients";
            this.groupBoxWithdrawRecipients.Size = new System.Drawing.Size(360, 213);
            this.groupBoxWithdrawRecipients.TabIndex = 0;
            this.groupBoxWithdrawRecipients.TabStop = false;
            this.groupBoxWithdrawRecipients.Text = "Thông tin người nhận";
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
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(200, 22);
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
            this.textBoxCustomerName.ReadOnly = true;
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // labelWithdrawPin
            // 
            this.labelWithdrawPin.Location = new System.Drawing.Point(25, 163);
            this.labelWithdrawPin.Name = "labelWithdrawPin";
            this.labelWithdrawPin.Size = new System.Drawing.Size(100, 20);
            this.labelWithdrawPin.TabIndex = 4;
            this.labelWithdrawPin.Text = "Mã PIN:";
            // 
            // textBoxWithdrawPin
            // 
            this.textBoxWithdrawPin.Location = new System.Drawing.Point(135, 163);
            this.textBoxWithdrawPin.Name = "textBoxWithdrawPin";
            this.textBoxWithdrawPin.ReadOnly = true;
            this.textBoxWithdrawPin.Size = new System.Drawing.Size(200, 22);
            this.textBoxWithdrawPin.TabIndex = 5;
            // 
            // labelWithdrawAmount
            // 
            this.labelWithdrawAmount.Location = new System.Drawing.Point(25, 160);
            this.labelWithdrawAmount.Name = "labelWithdrawAmount";
            this.labelWithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.labelWithdrawAmount.TabIndex = 2;
            this.labelWithdrawAmount.Text = "Số tiền rút:";
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(135, 160);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxWithdrawAmount.TabIndex = 3;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(280, 453);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(100, 30);
            this.buttonWithdraw.TabIndex = 6;
            this.buttonWithdraw.Text = "Rút tiền";
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
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
            // groupBoxWithdrawDetails
            // 
            this.groupBoxWithdrawDetails.Controls.Add(this.labelTransactionId);
            this.groupBoxWithdrawDetails.Controls.Add(this.textBoxBranchId);
            this.groupBoxWithdrawDetails.Controls.Add(this.textBoxTransactionId);
            this.groupBoxWithdrawDetails.Controls.Add(this.textBoxEmployeeId);
            this.groupBoxWithdrawDetails.Controls.Add(this.labelBranchId);
            this.groupBoxWithdrawDetails.Controls.Add(this.labelWithdrawAmount);
            this.groupBoxWithdrawDetails.Controls.Add(this.textBoxWithdrawAmount);
            this.groupBoxWithdrawDetails.Controls.Add(this.labelEmployeeId);
            this.groupBoxWithdrawDetails.Location = new System.Drawing.Point(419, 90);
            this.groupBoxWithdrawDetails.Name = "groupBoxWithdrawDetails";
            this.groupBoxWithdrawDetails.Size = new System.Drawing.Size(360, 213);
            this.groupBoxWithdrawDetails.TabIndex = 7;
            this.groupBoxWithdrawDetails.TabStop = false;
            this.groupBoxWithdrawDetails.Text = "Thông tin rút tiền";
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
            this.textBoxTransactionId.ReadOnly = true;
            this.textBoxTransactionId.Size = new System.Drawing.Size(200, 22);
            this.textBoxTransactionId.TabIndex = 1;
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
            this.groupBoxDescriptions.Text = "Nội dung rút tiền";
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
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(811, 501);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxDescriptions);
            this.Controls.Add(this.groupBoxWithdrawDetails);
            this.Controls.Add(this.groupBoxWithdrawRecipients);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WithdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw Form";
            this.groupBoxWithdrawRecipients.ResumeLayout(false);
            this.groupBoxWithdrawRecipients.PerformLayout();
            this.groupBoxWithdrawDetails.ResumeLayout(false);
            this.groupBoxWithdrawDetails.PerformLayout();
            this.groupBoxDescriptions.ResumeLayout(false);
            this.groupBoxDescriptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
