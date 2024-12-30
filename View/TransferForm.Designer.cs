using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem.View
{
    partial class TransferForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxDepositRecipients;
        private System.Windows.Forms.GroupBox groupBoxWithdrawRecipients;
        private System.Windows.Forms.GroupBox groupBoxWithdrawDetails;
        private System.Windows.Forms.GroupBox groupBoxDescriptions;
        private System.Windows.Forms.Label labelAccounFromtId;
        private System.Windows.Forms.Label labelCustomerFromName;
        private System.Windows.Forms.Label labelWithdrawAmount;
        private System.Windows.Forms.Label labelWithdrawPin;
        private System.Windows.Forms.Label labelAccountToId;
        private System.Windows.Forms.Label labelDepositPin;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;
        private System.Windows.Forms.Label labelBranchId;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelFromBalance;
        private System.Windows.Forms.Label labelTransactionId;
        private System.Windows.Forms.TextBox textBoxTransactionId;
        private System.Windows.Forms.TextBox textBoxAccountToId;
        private System.Windows.Forms.TextBox textBoxAccountFromId;
        private System.Windows.Forms.TextBox textBoxBranchId;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxTransferAmount;
        private System.Windows.Forms.TextBox textBoxFromBalance;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCustomerFromName;
        private System.Windows.Forms.TextBox textBoxWithdrawPin;
        private System.Windows.Forms.TextBox textBoxDepositPin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonWithdraw;


        private void InitializeComponent()
        {
            this.groupBoxDepositRecipients = new System.Windows.Forms.GroupBox();
            this.textBoxToBalance = new System.Windows.Forms.TextBox();
            this.textBoxAccountToId = new System.Windows.Forms.TextBox();
            this.labelToBalance = new System.Windows.Forms.Label();
            this.labelAccountToId = new System.Windows.Forms.Label();
            this.labelCustomerToName = new System.Windows.Forms.Label();
            this.textBoxCustomerToName = new System.Windows.Forms.TextBox();
            this.labelDepositPin = new System.Windows.Forms.Label();
            this.textBoxDepositPin = new System.Windows.Forms.TextBox();
            this.textBoxFromBalance = new System.Windows.Forms.TextBox();
            this.labelFromBalance = new System.Windows.Forms.Label();
            this.labelCustomerFromName = new System.Windows.Forms.Label();
            this.textBoxCustomerFromName = new System.Windows.Forms.TextBox();
            this.groupBoxWithdrawRecipients = new System.Windows.Forms.GroupBox();
            this.textBoxAccountFromId = new System.Windows.Forms.TextBox();
            this.labelAccounFromtId = new System.Windows.Forms.Label();
            this.labelWithdrawPin = new System.Windows.Forms.Label();
            this.textBoxWithdrawPin = new System.Windows.Forms.TextBox();
            this.labelWithdrawAmount = new System.Windows.Forms.Label();
            this.textBoxTransferAmount = new System.Windows.Forms.TextBox();
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
            this.groupBoxDepositRecipients.SuspendLayout();
            this.groupBoxWithdrawRecipients.SuspendLayout();
            this.groupBoxWithdrawDetails.SuspendLayout();
            this.groupBoxDescriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDepositRecipients
            // 
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxToBalance);
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxAccountToId);
            this.groupBoxDepositRecipients.Controls.Add(this.labelToBalance);
            this.groupBoxDepositRecipients.Controls.Add(this.labelAccountToId);
            this.groupBoxDepositRecipients.Controls.Add(this.labelCustomerToName);
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxCustomerToName);
            this.groupBoxDepositRecipients.Controls.Add(this.labelDepositPin);
            this.groupBoxDepositRecipients.Controls.Add(this.textBoxDepositPin);
            this.groupBoxDepositRecipients.Location = new System.Drawing.Point(33, 322);
            this.groupBoxDepositRecipients.Name = "groupBoxDepositRecipients";
            this.groupBoxDepositRecipients.Size = new System.Drawing.Size(360, 213);
            this.groupBoxDepositRecipients.TabIndex = 0;
            this.groupBoxDepositRecipients.TabStop = false;
            this.groupBoxDepositRecipients.Text = "Thông tin người nhận";
            // 
            // textBoxToBalance
            // 
            this.textBoxToBalance.Location = new System.Drawing.Point(135, 122);
            this.textBoxToBalance.Name = "textBoxToBalance";
            this.textBoxToBalance.ReadOnly = true;
            this.textBoxToBalance.Size = new System.Drawing.Size(200, 22);
            this.textBoxToBalance.TabIndex = 9;
            // 
            // textBoxAccountToId
            // 
            this.textBoxAccountToId.Location = new System.Drawing.Point(135, 41);
            this.textBoxAccountToId.Name = "textBoxAccountToId";
            this.textBoxAccountToId.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountToId.TabIndex = 1;
            this.textBoxAccountToId.TextChanged += new System.EventHandler(this.textBoxAccountToId_TextChanged);
            // 
            // labelToBalance
            // 
            this.labelToBalance.Location = new System.Drawing.Point(25, 123);
            this.labelToBalance.Name = "labelToBalance";
            this.labelToBalance.Size = new System.Drawing.Size(100, 20);
            this.labelToBalance.TabIndex = 8;
            this.labelToBalance.Text = "Số dư:";
            // 
            // labelAccountToId
            // 
            this.labelAccountToId.Location = new System.Drawing.Point(25, 44);
            this.labelAccountToId.Name = "labelAccountToId";
            this.labelAccountToId.Size = new System.Drawing.Size(100, 20);
            this.labelAccountToId.TabIndex = 0;
            this.labelAccountToId.Text = "Mã tài khoản:";
            // 
            // labelCustomerToName
            // 
            this.labelCustomerToName.Location = new System.Drawing.Point(25, 83);
            this.labelCustomerToName.Name = "labelCustomerToName";
            this.labelCustomerToName.Size = new System.Drawing.Size(100, 20);
            this.labelCustomerToName.TabIndex = 6;
            this.labelCustomerToName.Text = "Tên tài khoản:";
            // 
            // textBoxCustomerToName
            // 
            this.textBoxCustomerToName.Location = new System.Drawing.Point(135, 82);
            this.textBoxCustomerToName.Name = "textBoxCustomerToName";
            this.textBoxCustomerToName.ReadOnly = true;
            this.textBoxCustomerToName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerToName.TabIndex = 7;
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
            this.textBoxDepositPin.ReadOnly = true;
            this.textBoxDepositPin.Size = new System.Drawing.Size(200, 22);
            this.textBoxDepositPin.TabIndex = 5;
            // 
            // textBoxFromBalance
            // 
            this.textBoxFromBalance.Location = new System.Drawing.Point(135, 123);
            this.textBoxFromBalance.Name = "textBoxFromBalance";
            this.textBoxFromBalance.ReadOnly = true;
            this.textBoxFromBalance.Size = new System.Drawing.Size(200, 22);
            this.textBoxFromBalance.TabIndex = 5;
            // 
            // labelFromBalance
            // 
            this.labelFromBalance.Location = new System.Drawing.Point(25, 124);
            this.labelFromBalance.Name = "labelFromBalance";
            this.labelFromBalance.Size = new System.Drawing.Size(100, 20);
            this.labelFromBalance.TabIndex = 4;
            this.labelFromBalance.Text = "Số dư:";
            // 
            // labelCustomerFromName
            // 
            this.labelCustomerFromName.Location = new System.Drawing.Point(25, 84);
            this.labelCustomerFromName.Name = "labelCustomerFromName";
            this.labelCustomerFromName.Size = new System.Drawing.Size(100, 20);
            this.labelCustomerFromName.TabIndex = 2;
            this.labelCustomerFromName.Text = "Tên tài khoản:";
            // 
            // textBoxCustomerFromName
            // 
            this.textBoxCustomerFromName.Location = new System.Drawing.Point(135, 83);
            this.textBoxCustomerFromName.Name = "textBoxCustomerFromName";
            this.textBoxCustomerFromName.ReadOnly = true;
            this.textBoxCustomerFromName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerFromName.TabIndex = 3;
            // 
            // groupBoxWithdrawRecipients
            // 
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxAccountFromId);
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxFromBalance);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelFromBalance);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelAccounFromtId);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelCustomerFromName);
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxCustomerFromName);
            this.groupBoxWithdrawRecipients.Controls.Add(this.labelWithdrawPin);
            this.groupBoxWithdrawRecipients.Controls.Add(this.textBoxWithdrawPin);
            this.groupBoxWithdrawRecipients.Location = new System.Drawing.Point(33, 90);
            this.groupBoxWithdrawRecipients.Name = "groupBoxWithdrawRecipients";
            this.groupBoxWithdrawRecipients.Size = new System.Drawing.Size(360, 213);
            this.groupBoxWithdrawRecipients.TabIndex = 0;
            this.groupBoxWithdrawRecipients.TabStop = false;
            this.groupBoxWithdrawRecipients.Text = "Thông tin người gửi";
            // 
            // textBoxAccountFromId
            // 
            this.textBoxAccountFromId.Location = new System.Drawing.Point(135, 41);
            this.textBoxAccountFromId.Name = "textBoxAccountFromId";
            this.textBoxAccountFromId.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountFromId.TabIndex = 1;
            this.textBoxAccountFromId.TextChanged += new System.EventHandler(this.textBoxAccountFromId_TextChanged);
            // 
            // labelAccounFromtId
            // 
            this.labelAccounFromtId.Location = new System.Drawing.Point(25, 44);
            this.labelAccounFromtId.Name = "labelAccounFromtId";
            this.labelAccounFromtId.Size = new System.Drawing.Size(100, 20);
            this.labelAccounFromtId.TabIndex = 0;
            this.labelAccounFromtId.Text = "Mã tài khoản:";
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
            this.labelWithdrawAmount.Text = "Số tiền chuyển:";
            // 
            // textBoxTransferAmount
            // 
            this.textBoxTransferAmount.Location = new System.Drawing.Point(135, 160);
            this.textBoxTransferAmount.Name = "textBoxTransferAmount";
            this.textBoxTransferAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxTransferAmount.TabIndex = 3;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(280, 569);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(100, 30);
            this.buttonWithdraw.TabIndex = 6;
            this.buttonWithdraw.Text = "Chuyển tiền";
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(430, 569);
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
            this.groupBoxWithdrawDetails.Controls.Add(this.textBoxTransferAmount);
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
            this.groupBoxDescriptions.Location = new System.Drawing.Point(419, 322);
            this.groupBoxDescriptions.Name = "groupBoxDescriptions";
            this.groupBoxDescriptions.Size = new System.Drawing.Size(360, 213);
            this.groupBoxDescriptions.TabIndex = 8;
            this.groupBoxDescriptions.TabStop = false;
            this.groupBoxDescriptions.Text = "Nội dung rút tiền";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(28, 41);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(307, 144);
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
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(811, 620);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxDescriptions);
            this.Controls.Add(this.groupBoxWithdrawDetails);
            this.Controls.Add(this.groupBoxWithdrawRecipients);
            this.Controls.Add(this.groupBoxDepositRecipients);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw Form";
            this.groupBoxDepositRecipients.ResumeLayout(false);
            this.groupBoxDepositRecipients.PerformLayout();
            this.groupBoxWithdrawRecipients.ResumeLayout(false);
            this.groupBoxWithdrawRecipients.PerformLayout();
            this.groupBoxWithdrawDetails.ResumeLayout(false);
            this.groupBoxWithdrawDetails.PerformLayout();
            this.groupBoxDescriptions.ResumeLayout(false);
            this.groupBoxDescriptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxToBalance;
        private Label labelToBalance;
        private Label labelCustomerToName;
        private System.Windows.Forms.TextBox textBoxCustomerToName;
    }
}
