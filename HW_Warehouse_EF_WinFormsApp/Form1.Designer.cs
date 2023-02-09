namespace HW_Warehouse_EF_WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tbpGoods = new System.Windows.Forms.TabPage();
            this.gridGoods = new System.Windows.Forms.DataGridView();
            this.tbpDelivery = new System.Windows.Forms.TabPage();
            this.gridDeliveres = new System.Windows.Forms.DataGridView();
            this.tbpSuppliers = new System.Windows.Forms.TabPage();
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            this.tbpGoodsTypes = new System.Windows.Forms.TabPage();
            this.gridGoodsTypes = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tbpGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).BeginInit();
            this.tbpDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveres)).BeginInit();
            this.tbpSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.tbpGoodsTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoodsTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tbpGoods);
            this.mainTabControl.Controls.Add(this.tbpDelivery);
            this.mainTabControl.Controls.Add(this.tbpSuppliers);
            this.mainTabControl.Controls.Add(this.tbpGoodsTypes);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(776, 368);
            this.mainTabControl.TabIndex = 0;
            // 
            // tbpGoods
            // 
            this.tbpGoods.Controls.Add(this.gridGoods);
            this.tbpGoods.Location = new System.Drawing.Point(4, 22);
            this.tbpGoods.Name = "tbpGoods";
            this.tbpGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGoods.Size = new System.Drawing.Size(768, 342);
            this.tbpGoods.TabIndex = 0;
            this.tbpGoods.Text = "Goods";
            this.tbpGoods.UseVisualStyleBackColor = true;
            // 
            // gridGoods
            // 
            this.gridGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGoods.Location = new System.Drawing.Point(6, 6);
            this.gridGoods.Name = "gridGoods";
            this.gridGoods.RowTemplate.Height = 23;
            this.gridGoods.Size = new System.Drawing.Size(630, 330);
            this.gridGoods.TabIndex = 0;
            // 
            // tbpDelivery
            // 
            this.tbpDelivery.Controls.Add(this.gridDeliveres);
            this.tbpDelivery.Location = new System.Drawing.Point(4, 22);
            this.tbpDelivery.Name = "tbpDelivery";
            this.tbpDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDelivery.Size = new System.Drawing.Size(768, 342);
            this.tbpDelivery.TabIndex = 1;
            this.tbpDelivery.Text = "Delieveres";
            this.tbpDelivery.UseVisualStyleBackColor = true;
            // 
            // gridDeliveres
            // 
            this.gridDeliveres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeliveres.Location = new System.Drawing.Point(6, 6);
            this.gridDeliveres.Name = "gridDeliveres";
            this.gridDeliveres.RowTemplate.Height = 23;
            this.gridDeliveres.Size = new System.Drawing.Size(630, 330);
            this.gridDeliveres.TabIndex = 0;
            // 
            // tbpSuppliers
            // 
            this.tbpSuppliers.Controls.Add(this.gridSuppliers);
            this.tbpSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tbpSuppliers.Name = "tbpSuppliers";
            this.tbpSuppliers.Size = new System.Drawing.Size(768, 342);
            this.tbpSuppliers.TabIndex = 2;
            this.tbpSuppliers.Text = "Suppliers";
            this.tbpSuppliers.UseVisualStyleBackColor = true;
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.Location = new System.Drawing.Point(6, 6);
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.RowTemplate.Height = 23;
            this.gridSuppliers.Size = new System.Drawing.Size(630, 330);
            this.gridSuppliers.TabIndex = 1;
            // 
            // tbpGoodsTypes
            // 
            this.tbpGoodsTypes.Controls.Add(this.gridGoodsTypes);
            this.tbpGoodsTypes.Location = new System.Drawing.Point(4, 22);
            this.tbpGoodsTypes.Name = "tbpGoodsTypes";
            this.tbpGoodsTypes.Size = new System.Drawing.Size(768, 342);
            this.tbpGoodsTypes.TabIndex = 3;
            this.tbpGoodsTypes.Text = "GoodsTypes";
            this.tbpGoodsTypes.UseVisualStyleBackColor = true;
            // 
            // gridGoodsTypes
            // 
            this.gridGoodsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGoodsTypes.Location = new System.Drawing.Point(6, 6);
            this.gridGoodsTypes.Name = "gridGoodsTypes";
            this.gridGoodsTypes.RowTemplate.Height = 23;
            this.gridGoodsTypes.Size = new System.Drawing.Size(630, 330);
            this.gridGoodsTypes.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.tbpGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).EndInit();
            this.tbpDelivery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveres)).EndInit();
            this.tbpSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.tbpGoodsTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGoodsTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tbpGoods;
        private TabPage tbpDelivery;
        private DataGridView gridGoods;
        private DataGridView gridDeliveres;
        private TabPage tbpSuppliers;
        private TabPage tbpGoodsTypes;
        private DataGridView gridSuppliers;
        private DataGridView gridGoodsTypes;
        private Button btnSave;
    }
}