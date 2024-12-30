using System.Windows.Forms;

namespace BankSystem.View
{
    partial class EmployeeForm
    {
        private System.Windows.Forms.GroupBox groupBoxEmployeeDetails;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelEmployeePassword;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelEmployeeRole;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.CheckBox checkBoxUser;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.labelEmployeePassword = new System.Windows.Forms.Label();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.labelEmployeeRole = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.groupBoxEmployeeDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeDetails
            // 
            this.groupBoxEmployeeDetails.Controls.Add(this.checkBoxAdmin);
            this.groupBoxEmployeeDetails.Controls.Add(this.checkBoxUser);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelEmployeeId);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxEmployeeId);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelEmployeeName);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxEmployeeName);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelEmployeePassword);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxEmployeePassword);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelEmployeeRole);
            this.groupBoxEmployeeDetails.Location = new System.Drawing.Point(12, 75);
            this.groupBoxEmployeeDetails.Name = "groupBoxEmployeeDetails";
            this.groupBoxEmployeeDetails.Size = new System.Drawing.Size(441, 170);
            this.groupBoxEmployeeDetails.TabIndex = 0;
            this.groupBoxEmployeeDetails.TabStop = false;
            this.groupBoxEmployeeDetails.Text = "Thông tin nhân viên";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.Location = new System.Drawing.Point(180, 127);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(80, 24);
            this.checkBoxAdmin.TabIndex = 7;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.Location = new System.Drawing.Point(260, 127);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(100, 24);
            this.checkBoxUser.TabIndex = 8;
            this.checkBoxUser.Text = "User";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            this.checkBoxUser.CheckedChanged += new System.EventHandler(this.checkBoxUser_CheckedChanged);
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.Location = new System.Drawing.Point(75, 42);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(100, 23);
            this.labelEmployeeId.TabIndex = 0;
            this.labelEmployeeId.Text = "ID:";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(180, 39);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.Location = new System.Drawing.Point(75, 67);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(100, 23);
            this.labelEmployeeName.TabIndex = 2;
            this.labelEmployeeName.Text = "Tài khoản:";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(180, 69);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // labelEmployeePassword
            // 
            this.labelEmployeePassword.Location = new System.Drawing.Point(75, 97);
            this.labelEmployeePassword.Name = "labelEmployeePassword";
            this.labelEmployeePassword.Size = new System.Drawing.Size(100, 23);
            this.labelEmployeePassword.TabIndex = 4;
            this.labelEmployeePassword.Text = "Mật khẩu:";
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(180, 97);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmployeePassword.TabIndex = 5;
            // 
            // labelEmployeeRole
            // 
            this.labelEmployeeRole.Location = new System.Drawing.Point(75, 127);
            this.labelEmployeeRole.Name = "labelEmployeeRole";
            this.labelEmployeeRole.Size = new System.Drawing.Size(100, 23);
            this.labelEmployeeRole.TabIndex = 6;
            this.labelEmployeeRole.Text = "Vai trò:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Location = new System.Drawing.Point(12, 408);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(441, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(171, 10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Cập nhật";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(326, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 251);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewEmployees.TabIndex = 2;
            this.dataGridViewEmployees.SelectionChanged += new System.EventHandler(this.dataGridViewEmployees_SelectionChanged);
            // 
            // EmployeeForm
            // 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(464, 470);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxEmployeeDetails);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "EmployeeForm";
            this.Text = "Quản lý nhân viên";
            this.groupBoxEmployeeDetails.ResumeLayout(false);
            this.groupBoxEmployeeDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}