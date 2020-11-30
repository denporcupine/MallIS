
namespace MallIS
{
    partial class FormUserManagerC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserManagerC));
            this.dataGridViewMalls = new System.Windows.Forms.DataGridView();
            this.mallidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mallnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavilionsquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedvalueratioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pavilionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxFilterStatus = new System.Windows.Forms.TextBox();
            this.textBoxFilterCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelForm
            // 
            resources.ApplyResources(this.LabelForm, "LabelForm");
            // 
            // dataGridViewMalls
            // 
            this.dataGridViewMalls.AutoGenerateColumns = false;
            this.dataGridViewMalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mallidDataGridViewTextBoxColumn,
            this.mallnameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.pavilionsquantityDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.addedvalueratioDataGridViewTextBoxColumn,
            this.floorsDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.pavilionsDataGridViewTextBoxColumn,
            this.rentsDataGridViewTextBoxColumn});
            this.dataGridViewMalls.DataSource = this.mallBindingSource;
            resources.ApplyResources(this.dataGridViewMalls, "dataGridViewMalls");
            this.dataGridViewMalls.Name = "dataGridViewMalls";
            // 
            // mallidDataGridViewTextBoxColumn
            // 
            this.mallidDataGridViewTextBoxColumn.DataPropertyName = "Mall_id";
            resources.ApplyResources(this.mallidDataGridViewTextBoxColumn, "mallidDataGridViewTextBoxColumn");
            this.mallidDataGridViewTextBoxColumn.Name = "mallidDataGridViewTextBoxColumn";
            // 
            // mallnameDataGridViewTextBoxColumn
            // 
            this.mallnameDataGridViewTextBoxColumn.DataPropertyName = "Mall_name";
            resources.ApplyResources(this.mallnameDataGridViewTextBoxColumn, "mallnameDataGridViewTextBoxColumn");
            this.mallnameDataGridViewTextBoxColumn.Name = "mallnameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // pavilionsquantityDataGridViewTextBoxColumn
            // 
            this.pavilionsquantityDataGridViewTextBoxColumn.DataPropertyName = "Pavilions_quantity";
            resources.ApplyResources(this.pavilionsquantityDataGridViewTextBoxColumn, "pavilionsquantityDataGridViewTextBoxColumn");
            this.pavilionsquantityDataGridViewTextBoxColumn.Name = "pavilionsquantityDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            resources.ApplyResources(this.cityDataGridViewTextBoxColumn, "cityDataGridViewTextBoxColumn");
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            resources.ApplyResources(this.priceDataGridViewTextBoxColumn, "priceDataGridViewTextBoxColumn");
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // addedvalueratioDataGridViewTextBoxColumn
            // 
            this.addedvalueratioDataGridViewTextBoxColumn.DataPropertyName = "Added_value_ratio";
            resources.ApplyResources(this.addedvalueratioDataGridViewTextBoxColumn, "addedvalueratioDataGridViewTextBoxColumn");
            this.addedvalueratioDataGridViewTextBoxColumn.Name = "addedvalueratioDataGridViewTextBoxColumn";
            // 
            // floorsDataGridViewTextBoxColumn
            // 
            this.floorsDataGridViewTextBoxColumn.DataPropertyName = "Floors";
            resources.ApplyResources(this.floorsDataGridViewTextBoxColumn, "floorsDataGridViewTextBoxColumn");
            this.floorsDataGridViewTextBoxColumn.Name = "floorsDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            resources.ApplyResources(this.photoDataGridViewImageColumn, "photoDataGridViewImageColumn");
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // pavilionsDataGridViewTextBoxColumn
            // 
            this.pavilionsDataGridViewTextBoxColumn.DataPropertyName = "Pavilions";
            resources.ApplyResources(this.pavilionsDataGridViewTextBoxColumn, "pavilionsDataGridViewTextBoxColumn");
            this.pavilionsDataGridViewTextBoxColumn.Name = "pavilionsDataGridViewTextBoxColumn";
            // 
            // rentsDataGridViewTextBoxColumn
            // 
            this.rentsDataGridViewTextBoxColumn.DataPropertyName = "Rents";
            resources.ApplyResources(this.rentsDataGridViewTextBoxColumn, "rentsDataGridViewTextBoxColumn");
            this.rentsDataGridViewTextBoxColumn.Name = "rentsDataGridViewTextBoxColumn";
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataSource = typeof(MallIS.Mall);
            // 
            // textBoxFilterStatus
            // 
            resources.ApplyResources(this.textBoxFilterStatus, "textBoxFilterStatus");
            this.textBoxFilterStatus.Name = "textBoxFilterStatus";
            this.textBoxFilterStatus.TextChanged += new System.EventHandler(this.textBoxFilterStatus_TextChanged);
            // 
            // textBoxFilterCity
            // 
            resources.ApplyResources(this.textBoxFilterCity, "textBoxFilterCity");
            this.textBoxFilterCity.Name = "textBoxFilterCity";
            this.textBoxFilterCity.TextChanged += new System.EventHandler(this.textBoxFilterCity_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // FormUserManagerC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilterCity);
            this.Controls.Add(this.textBoxFilterStatus);
            this.Controls.Add(this.dataGridViewMalls);
            this.Name = "FormUserManagerC";
            this.Load += new System.EventHandler(this.FormUserManagerC_Load);
            this.Controls.SetChildIndex(this.dataGridViewMalls, 0);
            this.Controls.SetChildIndex(this.textBoxFilterStatus, 0);
            this.Controls.SetChildIndex(this.textBoxFilterCity, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn mallidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mallnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavilionsquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedvalueratioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavilionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mallBindingSource;
        private System.Windows.Forms.TextBox textBoxFilterStatus;
        private System.Windows.Forms.TextBox textBoxFilterCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}