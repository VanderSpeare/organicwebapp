using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace BankSystem.View
{
    public partial class EmployeeForm : Form, IView
    {
        private EmployeeController controller;
        private EmployeeModel currentEmployee;

        public EmployeeForm()
        {
            InitializeComponent();
            controller = new EmployeeController();
            InitializeDataGridView();
            LoadEmployeesFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewEmployees.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.HeaderText = "Password";
            passwordColumn.DataPropertyName = "Password";
            passwordColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(passwordColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Role";
            roleColumn.DataPropertyName = "Role";
            passwordColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(roleColumn);
        }

        // Load danh sách nhân viên từ CSDL
        private void LoadEmployeesFromDatabase()
        {
            controller.Load();
            var employees = controller.Items.Cast<EmployeeModel>().ToList();
            dataGridViewEmployees.DataSource = employees;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentEmployee == null) currentEmployee = new EmployeeModel();

            currentEmployee.Id = textBoxEmployeeId.Text;
            currentEmployee.Name = textBoxEmployeeName.Text;
            currentEmployee.Password = textBoxEmployeePassword.Text;
            currentEmployee.Role = checkBoxAdmin.Checked ? "Admin" : "User";
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var employee = item as EmployeeModel;
            if (employee != null)
            {
                textBoxEmployeeId.Text = employee.Id;
                textBoxEmployeeName.Text = employee.Name;
                // Disable password editing
                textBoxEmployeePassword.Text = employee.Password;
                textBoxEmployeePassword.ReadOnly = true;
            }
        }

        // Thêm nhân viên
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmployeeId.Text) || string.IsNullOrEmpty(textBoxEmployeePassword.Text))
            {
                MessageBox.Show("Cần nhập ID và Mật khẩu.");
                return;
            }

            GetDataFromText();

            if (controller.Create(currentEmployee))
            {
                LoadEmployeesFromDatabase();
                MessageBox.Show("Đã thêm Nhân viên thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Nhân viên.");
            }
        }

        // Cập nhật nhân viên
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewEmployees.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                if (string.IsNullOrEmpty(textBoxEmployeeName.Text))
                {
                    MessageBox.Show("Tên nhân viên không được để trống.");
                    return;
                }

                GetDataFromText();
                if (controller.Update(currentEmployee))
                {
                    LoadEmployeesFromDatabase();
                    MessageBox.Show("Cập nhật Nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật Nhân viên.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Nhân viên để cập nhật.");
            }
        }

        // Xóa nhân viên
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewEmployees.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                EmployeeModel employee = selectedRow.DataBoundItem as EmployeeModel;
                if (employee != null)
                {
                    if (controller.Delete(employee.Id))
                    {
                        ConfirmDelete();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá Nhân viên.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Nhân viên để xoá.");
            }
        }

        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadEmployeesFromDatabase();
                MessageBox.Show("Đã xoá Nhân viên thành công.");
            }
        }

        // Hiển thị thông tin nhân viên khi chọn trong DataGridView
        private void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewEmployees.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var employee = (EmployeeModel)selectedRow.DataBoundItem;
                SetDataToText(employee);
                if (employee.Role == "Admin")
                {
                    checkBoxAdmin.Checked = true;
                    checkBoxUser.Checked = false;
                }
                else if (employee.Role == "User")
                {
                    checkBoxAdmin.Checked = false;
                    checkBoxUser.Checked = true;
                }
            }
        }
        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                checkBoxUser.Checked = false;
            }
        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUser.Checked)
            {
                checkBoxAdmin.Checked = false;
            }
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