using System.Windows.Forms;

namespace BankSystem.View
{
	partial class MainMenu
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem systemMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem branchMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bankingMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createCustomerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createAccountMenuItem;
		private System.Windows.Forms.ToolStripMenuItem depositMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withdrawMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem balanceMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionLogMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userGuideMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;

        private void InitializeComponent()
		{
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.systemMenuItem,
            this.bankingMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(960, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenuItem,
            this.logoutMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // loginMenuItem
            // 
            this.loginMenuItem.Name = "loginMenuItem";
            this.loginMenuItem.Size = new System.Drawing.Size(139, 26);
            this.loginMenuItem.Text = "Login";
            this.loginMenuItem.Click += new System.EventHandler(this.loginMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutMenuItem.Text = "Logout";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMenuItem,
            this.branchMenuItem});
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.Size = new System.Drawing.Size(70, 24);
            this.systemMenuItem.Text = "System";
            // 
            // employeeMenuItem
            // 
            this.employeeMenuItem.Name = "employeeMenuItem";
            this.employeeMenuItem.Size = new System.Drawing.Size(158, 26);
            this.employeeMenuItem.Text = "Employee";
            this.employeeMenuItem.Click += new System.EventHandler(this.employeeMenuItem_Click);
            // 
            // branchMenuItem
            // 
            this.branchMenuItem.Name = "branchMenuItem";
            this.branchMenuItem.Size = new System.Drawing.Size(158, 26);
            this.branchMenuItem.Text = "Branch";
            this.branchMenuItem.Click += new System.EventHandler(this.branchMenuItem_Click);
            // 
            // bankingMenuItem
            // 
            this.bankingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerMenuItem,
            this.createAccountMenuItem,
            this.depositMenuItem,
            this.withdrawMenuItem,
            this.transactionMenuItem,
            this.balanceMenuItem,
            this.transactionLogMenuItem});
            this.bankingMenuItem.Name = "bankingMenuItem";
            this.bankingMenuItem.Size = new System.Drawing.Size(76, 24);
            this.bankingMenuItem.Text = "Banking";
            // 
            // createCustomerMenuItem
            // 
            this.createCustomerMenuItem.Name = "createCustomerMenuItem";
            this.createCustomerMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createCustomerMenuItem.Text = "Create Customer";
            this.createCustomerMenuItem.Click += new System.EventHandler(this.customerMenuItem_Click);
            // 
            // createAccountMenuItem
            // 
            this.createAccountMenuItem.Name = "createAccountMenuItem";
            this.createAccountMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createAccountMenuItem.Text = "Create Account";
            this.createAccountMenuItem.Click += new System.EventHandler(this.accountMenuItem_Click);
            // 
            // depositMenuItem
            // 
            this.depositMenuItem.Name = "depositMenuItem";
            this.depositMenuItem.Size = new System.Drawing.Size(224, 26);
            this.depositMenuItem.Text = "Deposit Amount";
            this.depositMenuItem.Click += new System.EventHandler(this.depositMenuItem_Click);
            // 
            // withdrawMenuItem
            // 
            this.withdrawMenuItem.Name = "withdrawMenuItem";
            this.withdrawMenuItem.Size = new System.Drawing.Size(224, 26);
            this.withdrawMenuItem.Text = "Withdraw Amount";
            this.withdrawMenuItem.Click += new System.EventHandler(this.withdrawMenuItem_Click);
            // 
            // transactionMenuItem
            // 
            this.transactionMenuItem.Name = "transactionMenuItem";
            this.transactionMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transactionMenuItem.Text = "Transaction Amount";
            this.transactionMenuItem.Click += new System.EventHandler(this.transferMenuItem_Click);
            // 
            // balanceMenuItem
            // 
            this.balanceMenuItem.Name = "balanceMenuItem";
            this.balanceMenuItem.Size = new System.Drawing.Size(224, 26);
            this.balanceMenuItem.Text = "Balance Account";
            this.balanceMenuItem.Click += new System.EventHandler(this.balanceMenuItem_Click);
            // 
            // transactionLogMenuItem
            // 
            this.transactionLogMenuItem.Name = "transactionLogMenuItem";
            this.transactionLogMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transactionLogMenuItem.Text = "Transaction log";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideMenuItem,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpMenuItem.Text = "Help";
            // 
            // userGuideMenuItem
            // 
            this.userGuideMenuItem.Name = "userGuideMenuItem";
            this.userGuideMenuItem.Size = new System.Drawing.Size(164, 26);
            this.userGuideMenuItem.Text = "User Guide";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(164, 26);
            this.aboutMenuItem.Text = "About";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUserLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 618);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(960, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripUserLabel
            // 
            this.toolStripUserLabel.Name = "toolStripUserLabel";
            this.toolStripUserLabel.Size = new System.Drawing.Size(0, 16);
            this.toolStripUserLabel.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripUserLabel;
    }
}