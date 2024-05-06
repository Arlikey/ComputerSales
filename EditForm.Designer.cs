namespace ComputerSales
{
    partial class EditForm
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
            cancelButton = new Button();
            saveButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(471, 397);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(138, 38);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(212, 397);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(138, 38);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 357);
            textBox1.TabIndex = 2;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(textBox1);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private TextBox textBox1;
    }
}