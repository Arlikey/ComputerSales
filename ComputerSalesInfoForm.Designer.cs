namespace ComputerSales
{
    partial class ComputerSalesInfoForm
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
            productsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // productsDataGridView
            // 
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Dock = DockStyle.Fill;
            productsDataGridView.Location = new Point(0, 0);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.Size = new Size(584, 311);
            productsDataGridView.TabIndex = 0;
            // 
            // ComputerSalesInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(productsDataGridView);
            Name = "ComputerSalesInfoForm";
            Text = "ComputerSalesInfoForm";
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productsDataGridView;
    }
}