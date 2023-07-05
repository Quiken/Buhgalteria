using System;
using System.Data;
using System.Windows.Forms;

namespace SmallBusinessAccountantApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.Fill(this.sBADataSet.Employees);
                this.contractsTableAdapter.Fill(this.sBADataSet.Contracts);
                this.accountsTableAdapter.Fill(this.sBADataSet.Accounts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sBADataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.contractsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sBADataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.accountsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sBADataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (accountsDataGridView.SelectedRows.Count > 0)
            {
                var account = (accountsDataGridView.SelectedRows[0].DataBoundItem as DataRowView).Row as SBADataSet.AccountsRow;
                new PromotionsForm(account.Id).Show();
            }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            if (accountsDataGridView.SelectedRows.Count > 0)
            {
                var account = (accountsDataGridView.SelectedRows[0].DataBoundItem as DataRowView).Row as SBADataSet.AccountsRow;
                new PenaltiesForm(account.Id).Show();
            }
        }
    }
}