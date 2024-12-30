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
    public partial class BranchForm : Form, IView
    {
        private BranchController controller;
        private BranchModel currentBranch;

        public BranchForm()
        {
            InitializeComponent();
            controller = new BranchController();
            InitializeDataGridView();
            LoadBranchesFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewBranches.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn branchIdColumn = new DataGridViewTextBoxColumn();
            branchIdColumn.HeaderText = "Mã chi nhánh";
            branchIdColumn.DataPropertyName = "Id";
            branchIdColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(branchIdColumn);

            DataGridViewTextBoxColumn branchNameColumn = new DataGridViewTextBoxColumn();
            branchNameColumn.HeaderText = "Chi nhánh";
            branchNameColumn.DataPropertyName = "Name";
            branchNameColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(branchNameColumn);

            DataGridViewTextBoxColumn houseNoColumn = new DataGridViewTextBoxColumn();
            houseNoColumn.HeaderText = "Số nhà";
            houseNoColumn.DataPropertyName = "HouseNo";
            houseNoColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(houseNoColumn);

            DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn();
            cityColumn.HeaderText = "Thành phố";
            cityColumn.DataPropertyName = "City";
            cityColumn.ReadOnly = true;
            dataGridViewBranches.Columns.Add(cityColumn);
        }

        // Load danh sách chi nhánh từ cơ sở dữ liệu
        private void LoadBranchesFromDatabase()
        {
            controller.Load();
            var branchs = controller.Items.Cast<BranchModel>().ToList();
            dataGridViewBranches.DataSource = branchs;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentBranch == null) currentBranch = new BranchModel();

            currentBranch.Id = textBoxBranchId.Text;
            currentBranch.Name = textBoxBranchName.Text;
            currentBranch.HouseNo = textBoxBranchHouseNo.Text;
            currentBranch.City = textBoxBranchCity.Text;
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var branch = item as BranchModel;
            if (branch != null)
            {
                textBoxBranchId.Text = branch.Id;
                textBoxBranchName.Text = branch.Name;
                textBoxBranchHouseNo.Text = branch.HouseNo;
                textBoxBranchCity.Text = branch.City;
            }
        }

        // Thêm chi nhánh
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBranchId.Text) || string.IsNullOrEmpty(textBoxBranchName.Text))
            {
                MessageBox.Show("Cần nhập Mã chi nhánh và Tên chi nhánh.");
                return;
            }

            GetDataFromText();
            if (controller.Create(currentBranch))
            {
                LoadBranchesFromDatabase();
                MessageBox.Show("Đã thêm Chi nhánh thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Chi nhánh.");
            }
        }

        // Cập nhật khách hàng
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewBranches.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                GetDataFromText();
                if (controller.Update(currentBranch))
                {
                    LoadBranchesFromDatabase();
                    MessageBox.Show("Cập nhật Chi nhánh thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật Chi nhánh.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Chi nhánh để cập nhật.");
            }
        }

        // Xóa chi nhánh
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewBranches.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                BranchModel branch = selectedRow.DataBoundItem as BranchModel;

                if (controller.Delete(branch.Id))
                {
                    ConfirmDelete();
                }
                else
                {
                    MessageBox.Show("Không thể xoá chi nhánh.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn chi nhánh để xoá.");
            }
        }

        // Hiển thị xác nhận trước khi xoá
        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá chi nhánh?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadBranchesFromDatabase();
                MessageBox.Show("Đã xoá chi nhánh thành công.");
            }
        }

        //// Thêm hoặc cập nhật chi nhánh
        //private void buttonSave_Click(object sender, EventArgs e)
        //{
        //    GetDataFromText();
        //    if (controller.IsExist(currentBranch.Id))
        //    {
        //        controller.Update(currentBranch);
        //        MessageBox.Show("Cập nhật chi nhánh thành công.");
        //    }
        //    else
        //    {
        //        controller.Create(currentBranch);
        //        MessageBox.Show("Đã thêm chi nhánh thành công.");
        //    }
        //    LoadBranchesFromDatabase();
        //    ClearForm();
        //}

        // Hiển thị thông tin chi nhánh khi chọn trong DataGridView
        private void dataGridViewBranches_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewBranches.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var branch = (BranchModel)selectedRow.DataBoundItem;
                SetDataToText(branch);
            }
        }

        // Xoá dữ liệu form
        private void ClearForm()
        {
            textBoxBranchId.Clear();
            textBoxBranchName.Clear();
            textBoxBranchHouseNo.Clear();
            textBoxBranchCity.Clear();
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
