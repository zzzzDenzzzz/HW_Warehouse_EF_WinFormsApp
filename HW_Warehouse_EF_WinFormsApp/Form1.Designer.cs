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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpGoods = new System.Windows.Forms.TabPage();
            this.gridGoods = new System.Windows.Forms.DataGridView();
            this.TbpDelivery = new System.Windows.Forms.TabPage();
            this.gridDeliveres = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbpGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).BeginInit();
            this.TbpDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveres)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpGoods);
            this.tabControl1.Controls.Add(this.TbpDelivery);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 408);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TbpDeliveryShow);
            // 
            // tbpGoods
            // 
            this.tbpGoods.Controls.Add(this.gridGoods);
            this.tbpGoods.Location = new System.Drawing.Point(4, 22);
            this.tbpGoods.Name = "tbpGoods";
            this.tbpGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGoods.Size = new System.Drawing.Size(768, 382);
            this.tbpGoods.TabIndex = 0;
            this.tbpGoods.Text = "Товары";
            this.tbpGoods.UseVisualStyleBackColor = true;
            // 
            // gridGoods
            // 
            this.gridGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGoods.Location = new System.Drawing.Point(6, 6);
            this.gridGoods.Name = "gridGoods";
            this.gridGoods.RowTemplate.Height = 23;
            this.gridGoods.Size = new System.Drawing.Size(634, 370);
            this.gridGoods.TabIndex = 0;
            // 
            // TbpDelivery
            // 
            this.TbpDelivery.Controls.Add(this.gridDeliveres);
            this.TbpDelivery.Location = new System.Drawing.Point(4, 22);
            this.TbpDelivery.Name = "TbpDelivery";
            this.TbpDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.TbpDelivery.Size = new System.Drawing.Size(768, 382);
            this.TbpDelivery.TabIndex = 1;
            this.TbpDelivery.Text = "Доставка";
            this.TbpDelivery.UseVisualStyleBackColor = true;
            // 
            // gridDeliveres
            // 
            this.gridDeliveres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeliveres.Location = new System.Drawing.Point(6, 6);
            this.gridDeliveres.Name = "gridDeliveres";
            this.gridDeliveres.RowTemplate.Height = 23;
            this.gridDeliveres.Size = new System.Drawing.Size(645, 370);
            this.gridDeliveres.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadFormShowGoods);
            this.tabControl1.ResumeLayout(false);
            this.tbpGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).EndInit();
            this.TbpDelivery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpGoods;
        private TabPage TbpDelivery;
        private DataGridView gridGoods;
        private DataGridView gridDeliveres;
    }
}