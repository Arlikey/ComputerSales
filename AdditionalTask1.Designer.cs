namespace ComputerSales
{
    partial class AdditionalTask1
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
            textBox1 = new TextBox();
            loadFileButton = new Button();
            editButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(800, 357);
            textBox1.TabIndex = 0;
            // 
            // loadFileButton
            // 
            loadFileButton.FlatStyle = FlatStyle.Flat;
            loadFileButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loadFileButton.Location = new Point(212, 382);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(138, 38);
            loadFileButton.TabIndex = 1;
            loadFileButton.Text = "Загрузить файл";
            loadFileButton.UseVisualStyleBackColor = true;
            loadFileButton.Click += loadFileButton_Click;
            // 
            // editButton
            // 
            editButton.Enabled = false;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.Location = new Point(471, 382);
            editButton.Name = "editButton";
            editButton.Size = new Size(138, 38);
            editButton.TabIndex = 1;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // AdditionalTask1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editButton);
            Controls.Add(loadFileButton);
            Controls.Add(textBox1);
            Name = "AdditionalTask1";
            Text = "AdditionalTask1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button loadFileButton;
        private Button editButton;
    }
}