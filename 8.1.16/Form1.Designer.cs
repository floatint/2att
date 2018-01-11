namespace _8._1._16
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstInput = new System.Windows.Forms.TextBox();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.outLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(6, 32);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(367, 26);
            this.firstInput.TabIndex = 11;
            this.firstInput.TextChanged += new System.EventHandler(this.firstInput_TextChanged);
            // 
            // secondInput
            // 
            this.secondInput.Location = new System.Drawing.Point(6, 84);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(367, 26);
            this.secondInput.TabIndex = 10;
            this.secondInput.TextChanged += new System.EventHandler(this.secondInput_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(14, 147);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(82, 29);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Создать";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(102, 151);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(51, 20);
            this.outLabel.TabIndex = 8;
            this.outLabel.Text = "label3";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(2, 61);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(128, 20);
            this.secondLabel.TabIndex = 7;
            this.secondLabel.Text = "Второй список :";
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(2, 9);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(131, 20);
            this.firstLabel.TabIndex = 6;
            this.firstLabel.Text = "Первый список :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 244);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label firstLabel;
    }
}

