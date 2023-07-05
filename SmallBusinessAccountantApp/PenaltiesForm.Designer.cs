
namespace SmallBusinessAccountantApp
{
    partial class PenaltiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenaltiesForm));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label amountLabel;
            this.sBADataSet = new SmallBusinessAccountantApp.SBADataSet();
            this.penaltiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penaltiesTableAdapter = new SmallBusinessAccountantApp.SBADataSetTableAdapters.PenaltiesTableAdapter();
            this.tableAdapterManager = new SmallBusinessAccountantApp.SBADataSetTableAdapters.TableAdapterManager();
            this.penaltiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.penaltiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.penaltiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            nameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingNavigator)).BeginInit();
            this.penaltiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sBADataSet
            // 
            this.sBADataSet.DataSetName = "SBADataSet";
            this.sBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penaltiesBindingSource
            // 
            this.penaltiesBindingSource.DataMember = "Penalties";
            this.penaltiesBindingSource.DataSource = this.sBADataSet;
            // 
            // penaltiesTableAdapter
            // 
            this.penaltiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PenaltiesTableAdapter = this.penaltiesTableAdapter;
            this.tableAdapterManager.PromotionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SmallBusinessAccountantApp.SBADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // penaltiesBindingNavigator
            // 
            this.penaltiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.penaltiesBindingNavigator.BindingSource = this.penaltiesBindingSource;
            this.penaltiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.penaltiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.penaltiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.penaltiesBindingNavigatorSaveItem});
            this.penaltiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.penaltiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.penaltiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.penaltiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.penaltiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.penaltiesBindingNavigator.Name = "penaltiesBindingNavigator";
            this.penaltiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.penaltiesBindingNavigator.Size = new System.Drawing.Size(1135, 25);
            this.penaltiesBindingNavigator.TabIndex = 0;
            this.penaltiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // penaltiesBindingNavigatorSaveItem
            // 
            this.penaltiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penaltiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("penaltiesBindingNavigatorSaveItem.Image")));
            this.penaltiesBindingNavigatorSaveItem.Name = "penaltiesBindingNavigatorSaveItem";
            this.penaltiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.penaltiesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.penaltiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.penaltiesBindingNavigatorSaveItem_Click);
            // 
            // penaltiesDataGridView
            // 
            this.penaltiesDataGridView.AllowUserToAddRows = false;
            this.penaltiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penaltiesDataGridView.AutoGenerateColumns = false;
            this.penaltiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.penaltiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.penaltiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.penaltiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.penaltiesDataGridView.DataSource = this.penaltiesBindingSource;
            this.penaltiesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.penaltiesDataGridView.MultiSelect = false;
            this.penaltiesDataGridView.Name = "penaltiesDataGridView";
            this.penaltiesDataGridView.ReadOnly = true;
            this.penaltiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.penaltiesDataGridView.Size = new System.Drawing.Size(735, 457);
            this.penaltiesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание взыскания";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сумма, руб.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AccountId";
            this.dataGridViewTextBoxColumn4.HeaderText = "AccountId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(760, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(119, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Описание взыскания:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penaltiesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(885, 36);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(238, 67);
            this.nameTextBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(760, 112);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(70, 13);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Сумма, руб.:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.penaltiesBindingSource, "Amount", true));
            this.amountNumericUpDown.DecimalPlaces = 2;
            this.amountNumericUpDown.Location = new System.Drawing.Point(885, 109);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(238, 20);
            this.amountNumericUpDown.TabIndex = 5;
            // 
            // PenaltiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 497);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.penaltiesDataGridView);
            this.Controls.Add(this.penaltiesBindingNavigator);
            this.Name = "PenaltiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Взыскания по счету № ";
            this.Load += new System.EventHandler(this.PenaltiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingNavigator)).EndInit();
            this.penaltiesBindingNavigator.ResumeLayout(false);
            this.penaltiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SBADataSet sBADataSet;
        private System.Windows.Forms.BindingSource penaltiesBindingSource;
        private SBADataSetTableAdapters.PenaltiesTableAdapter penaltiesTableAdapter;
        private SBADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator penaltiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton penaltiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView penaltiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}