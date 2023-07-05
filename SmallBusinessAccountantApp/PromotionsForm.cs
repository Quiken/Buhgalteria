using System;
using System.Windows.Forms;

namespace SmallBusinessAccountantApp
{
    public partial class PromotionsForm : Form
    {
        private int _id;

        public PromotionsForm(int id)
        {
            InitializeComponent();
            _id = id;
            Text = $"Поощрения по счету № {id}";
        }

        private void promotionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < promotionsDataGridView.RowCount; i++)
            {
                promotionsDataGridView[2, i].Value = _id;
            }

            try
            {
                this.Validate();
                this.promotionsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sBADataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PromotionsForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.promotionsTableAdapter.Fill(this.sBADataSet.Promotions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            promotionsBindingSource.Filter = $"AccountId = {_id}";
        }
    }
}