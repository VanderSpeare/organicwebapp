using System.Windows.Forms;

namespace BankSystem.View
{
    partial class CustomerForm
    {
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerEmail;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.Label labelCustomerHouseNo;
        private System.Windows.Forms.Label labelCustomerCity;
        private System.Windows.Forms.Label labelCustomerPin;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.TextBox textBoxCustomerHouseNo;
        private System.Windows.Forms.TextBox textBoxCustomerCity;
        private System.Windows.Forms.TextBox textBoxCustomerPin;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerHouseNo = new System.Windows.Forms.Label();
            this.textBoxCustomerHouseNo = new System.Windows.Forms.TextBox();
            this.labelCustomerCity = new System.Windows.Forms.Label();
            this.textBoxCustomerCity = new System.Windows.Forms.TextBox();
            this.labelCustomerPin = new System.Windows.Forms.Label();
            this.textBoxCustomerPin = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.labelCustomerId);
            this.groupBoxDetails.Controls.Add(this.textBoxCustomerId);
            this.groupBoxDetails.Controls.Add(this.labelCustomerName);
            this.groupBoxDetails.Controls.Add(this.textBoxCustomerName);
            this.groupBoxDetails.Controls.Add(this.labelCustomerEmail);
            this.groupBoxDetails.Controls.Add(this.textBoxCustomerEmail);
            this.groupBoxDetails.Controls.Add(this.labelCustomerPhone);
            this.groupBoxDetails.Controls.Add(this.textBoxCustomerPhone);
            this.groupBoxDetails.Controls.Add(this.labelCustomerHouseNo);
            this.groupBoxDetails.Controls.Add(this.textBoxCustomerHouseNo);
            this.groupBoxDetails.Controls.Add(this.labelCustomerCity);
            this.groupBoxDetails.Controls.Add(this.textBoxCustomerCity);
            this.groupBoxDetails.Controls.Add(this.labelCustomerPin);
            this.groupBoxDetails.Controls.Add(this.textBoxCustomerPin);
            this.groupBoxDetails.Location = new System.Drawing.Point(11, 69);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDetails.Size = new System.Drawing.Size(675, 162);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Thông tin khách hàng";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.Location = new System.Drawing.Point(40, 24);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(89, 18);
            this.labelCustomerId.TabIndex = 0;
            this.labelCustomerId.Text = "ID khách hàng:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(154, 24);
            this.textBoxCustomerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(178, 22);
            this.textBoxCustomerId.TabIndex = 1;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Location = new System.Drawing.Point(40, 56);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(108, 18);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Tên khách hàng:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(154, 56);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(178, 22);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.Location = new System.Drawing.Point(40, 88);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(89, 18);
            this.labelCustomerEmail.TabIndex = 4;
            this.labelCustomerEmail.Text = "Email:";
            // 
            // textBoxCustomerEmail
            // 
            this.textBoxCustomerEmail.Location = new System.Drawing.Point(154, 88);
            this.textBoxCustomerEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            this.textBoxCustomerEmail.Size = new System.Drawing.Size(178, 22);
            this.textBoxCustomerEmail.TabIndex = 5;
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.Location = new System.Drawing.Point(40, 120);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(89, 18);
            this.labelCustomerPhone.TabIndex = 6;
            this.labelCustomerPhone.Text = "Số điện thoại:";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(154, 120);
            this.textBoxCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(178, 22);
            this.textBoxCustomerPhone.TabIndex = 7;
            // 
            // labelCustomerHouseNo
            // 
            this.labelCustomerHouseNo.Location = new System.Drawing.Point(360, 27);
            this.labelCustomerHouseNo.Name = "labelCustomerHouseNo";
            this.labelCustomerHouseNo.Size = new System.Drawing.Size(89, 18);
            this.labelCustomerHouseNo.TabIndex = 8;
            this.labelCustomerHouseNo.Text = "Số nhà:";
            // 
            // textBoxCustomerHouseNo
            // 
            this.textBoxCustomerHouseNo.Location = new System.Drawing.Point(454, 27);
            this.textBoxCustomerHouseNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerHouseNo.Name = "textBoxCustomerHouseNo";
            this.textBoxCustomerHouseNo.Size = new System.Drawing.Size(178, 22);
            this.textBoxCustomerHouseNo.TabIndex = 9;
            // 
            // labelCustomerCity
            // 
            this.labelCustomerCity.Location = new System.Drawing.Point(360, 51);
            this.labelCustomerCity.Name = "labelCustomerCity";
            this.labelCustomerCity.Size = new System.Drawing.Size(89, 18);
            this.labelCustomerCity.TabIndex = 10;
            this.labelCustomerCity.Text = "Thành phố:";
            // 
            // textBoxCustomerCity
            // 
            this.textBoxCustomerCity.Location = new System.Drawing.Point(454, 51);
            this.textBoxCustomerCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerCity.Name = "textBoxCustomerCity";
            this.textBoxCustomerCity.Size = new System.Drawing.Size(178, 22);
            this.textBoxCustomerCity.TabIndex = 11;
            // 
            // labelCustomerPin
            // 
            this.labelCustomerPin.Location = new System.Drawing.Point(360, 75);
            this.labelCustomerPin.Name = "labelCustomerPin";
            this.labelCustomerPin.Size = new System.Drawing.Size(89, 18);
            this.labelCustomerPin.TabIndex = 12;
            this.labelCustomerPin.Text = "Pin:";
            // 
            // textBoxCustomerPin
            // 
            this.textBoxCustomerPin.Location = new System.Drawing.Point(454, 75);
            this.textBoxCustomerPin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomerPin.Name = "textBoxCustomerPin";
            this.textBoxCustomerPin.Size = new System.Drawing.Size(178, 22);
            this.textBoxCustomerPin.TabIndex = 13;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAddCustomer);
            this.panelButtons.Controls.Add(this.buttonUpdateCustomer);
            this.panelButtons.Controls.Add(this.buttonDeleteCustomer);
            this.panelButtons.Location = new System.Drawing.Point(11, 335);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(675, 40);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(18, 8);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(89, 24);
            this.buttonAddCustomer.TabIndex = 0;
            this.buttonAddCustomer.Text = "Thêm";
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(292, 8);
            this.buttonUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(89, 24);
            this.buttonUpdateCustomer.TabIndex = 1;
            this.buttonUpdateCustomer.Text = "Cập nhật";
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(573, 8);
            this.buttonDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(89, 24);
            this.buttonDeleteCustomer.TabIndex = 2;
            this.buttonDeleteCustomer.Text = "Xoá";
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(192, 7);
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
            this.titleSub.Location = new System.Drawing.Point(172, 35);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(358, 22);
            this.titleSub.TabIndex = 1;
            this.titleSub.Text = "AN TÂM ĐẦU TƯ, SINH LỜI BỀN VỮNG";
            this.titleSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 235);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(675, 96);
            this.dataGridViewCustomers.TabIndex = 2;
            this.dataGridViewCustomers.SelectionChanged += new System.EventHandler(this.dataGridViewCustomers_SelectionChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 387);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.groupBoxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
