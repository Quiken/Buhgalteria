using System;
using System.Windows.Forms;

namespace SmallBusinessAccountantApp
{
    public partial class PenaltiesForm : Form
    {
        private int _id;

        public PenaltiesForm(int id)
        {
            InitializeComponent();
            _id = id;
            Text = $"Взыскания по счету № {id}";
        }

        private void penaltiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < penaltiesDataGridView.RowCount; i++)
            {
                penaltiesDataGridView[2, i].Value = _id;
            }

            try
            {
                this.Validate();
                this.penaltiesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sBADataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            penaltiesBindingSource.Filter = $"AccountId = {_id}";
        }

        private void PenaltiesForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.penaltiesTableAdapter.Fill(this.sBADataSet.Penalties);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}