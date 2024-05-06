namespace ComputerSales
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
            categoriesComboBox = new ComboBox();
            productsListBox = new ListBox();
            userCartListBox = new ListBox();
            RemoveItemButton = new Button();
            finishOrderButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            toCartButton = new Button();
            infoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // categoriesComboBox
            // 
            categoriesComboBox.FormattingEnabled = true;
            categoriesComboBox.Location = new Point(12, 12);
            categoriesComboBox.Name = "categoriesComboBox";
            categoriesComboBox.Size = new Size(121, 23);
            categoriesComboBox.TabIndex = 0;
            categoriesComboBox.SelectedIndexChanged += categoriesComboBox_SelectedIndexChanged;
            // 
            // productsListBox
            // 
            productsListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            productsListBox.FormattingEnabled = true;
            productsListBox.HorizontalScrollbar = true;
            productsListBox.ItemHeight = 17;
            productsListBox.Location = new Point(168, 12);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(325, 310);
            productsListBox.TabIndex = 1;
            // 
            // userCartListBox
            // 
            userCartListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userCartListBox.FormattingEnabled = true;
            userCartListBox.HorizontalScrollbar = true;
            userCartListBox.ItemHeight = 17;
            userCartListBox.Location = new Point(550, 37);
            userCartListBox.Name = "userCartListBox";
            userCartListBox.Size = new Size(226, 242);
            userCartListBox.TabIndex = 2;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 255);
            RemoveItemButton.FlatAppearance.BorderSize = 2;
            RemoveItemButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 255);
            RemoveItemButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            RemoveItemButton.FlatStyle = FlatStyle.Flat;
            RemoveItemButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RemoveItemButton.ForeColor = SystemColors.ActiveCaptionText;
            RemoveItemButton.Location = new Point(550, 285);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(115, 37);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Удалить";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            RemoveItemButton.MouseEnter += RemoveItemButton_MouseEnter;
            RemoveItemButton.MouseLeave += RemoveItemButton_MouseLeave;
            // 
            // finishOrderButton
            // 
            finishOrderButton.BackColor = Color.FromArgb(128, 128, 255);
            finishOrderButton.FlatStyle = FlatStyle.Flat;
            finishOrderButton.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            finishOrderButton.ForeColor = Color.White;
            finishOrderButton.Location = new Point(675, 386);
            finishOrderButton.Name = "finishOrderButton";
            finishOrderButton.Size = new Size(101, 52);
            finishOrderButton.TabIndex = 4;
            finishOrderButton.Text = "Завершить покупки";
            finishOrderButton.UseVisualStyleBackColor = false;
            finishOrderButton.Click += finishOrderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(550, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 5;
            label1.Text = "Корзина :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_icon_money_bag_3359187;
            pictureBox1.Location = new Point(610, 388);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // toCartButton
            // 
            toCartButton.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 255);
            toCartButton.FlatAppearance.BorderSize = 2;
            toCartButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 255);
            toCartButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            toCartButton.FlatStyle = FlatStyle.Flat;
            toCartButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toCartButton.ForeColor = SystemColors.ActiveCaptionText;
            toCartButton.Location = new Point(168, 339);
            toCartButton.Name = "toCartButton";
            toCartButton.Size = new Size(115, 37);
            toCartButton.TabIndex = 3;
            toCartButton.Text = "В корзину";
            toCartButton.UseVisualStyleBackColor = true;
            toCartButton.Click += toCartButton_Click;
            toCartButton.MouseEnter += RemoveItemButton_MouseEnter;
            toCartButton.MouseLeave += RemoveItemButton_MouseLeave;
            // 
            // infoButton
            // 
            infoButton.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 255);
            infoButton.FlatAppearance.BorderSize = 2;
            infoButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 255);
            infoButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            infoButton.FlatStyle = FlatStyle.Flat;
            infoButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoButton.ForeColor = SystemColors.ActiveCaptionText;
            infoButton.Location = new Point(378, 339);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(115, 37);
            infoButton.TabIndex = 3;
            infoButton.Text = "Подробнее";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            infoButton.MouseEnter += RemoveItemButton_MouseEnter;
            infoButton.MouseLeave += RemoveItemButton_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(finishOrderButton);
            Controls.Add(infoButton);
            Controls.Add(toCartButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(userCartListBox);
            Controls.Add(productsListBox);
            Controls.Add(categoriesComboBox);
            Name = "Form1";
            Text = "Компьютерные комплектующие";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox categoriesComboBox;
        private ListBox productsListBox;
        private ListBox userCartListBox;
        private Button RemoveItemButton;
        private Button finishOrderButton;
        private Label label1;
        private PictureBox pictureBox1;
        private Button toCartButton;
        private Button infoButton;
    }
}
