namespace _7._1._16
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outLabel = new System.Windows.Forms.Label();
            this.outBox = new System.Windows.Forms.TextBox();
            this.beforeCheckBox = new System.Windows.Forms.CheckBox();
            this.afterCheckBox = new System.Windows.Forms.CheckBox();
            this.negativeCheckBox = new System.Windows.Forms.CheckBox();
            this.positiveCheckBox = new System.Windows.Forms.CheckBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(0, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(120, 16);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Введите массив :";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(3, 19);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(556, 20);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outLabel.Location = new System.Drawing.Point(0, 42);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(84, 16);
            this.outLabel.TabIndex = 2;
            this.outLabel.Text = "Результат :";
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(3, 61);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(556, 20);
            this.outBox.TabIndex = 3;
            // 
            // beforeCheckBox
            // 
            this.beforeCheckBox.AutoSize = true;
            this.beforeCheckBox.Location = new System.Drawing.Point(4, 87);
            this.beforeCheckBox.Name = "beforeCheckBox";
            this.beforeCheckBox.Size = new System.Drawing.Size(58, 17);
            this.beforeCheckBox.TabIndex = 4;
            this.beforeCheckBox.Text = "Перед";
            this.beforeCheckBox.UseVisualStyleBackColor = true;
            this.beforeCheckBox.CheckedChanged += new System.EventHandler(this.beforeCheckBox_CheckedChanged);
            // 
            // afterCheckBox
            // 
            this.afterCheckBox.AutoSize = true;
            this.afterCheckBox.Location = new System.Drawing.Point(3, 110);
            this.afterCheckBox.Name = "afterCheckBox";
            this.afterCheckBox.Size = new System.Drawing.Size(58, 17);
            this.afterCheckBox.TabIndex = 5;
            this.afterCheckBox.Text = "После";
            this.afterCheckBox.UseVisualStyleBackColor = true;
            this.afterCheckBox.CheckedChanged += new System.EventHandler(this.afterCheckBox_CheckedChanged);
            // 
            // negativeCheckBox
            // 
            this.negativeCheckBox.AutoSize = true;
            this.negativeCheckBox.Location = new System.Drawing.Point(90, 87);
            this.negativeCheckBox.Name = "negativeCheckBox";
            this.negativeCheckBox.Size = new System.Drawing.Size(105, 17);
            this.negativeCheckBox.TabIndex = 6;
            this.negativeCheckBox.Text = "Отрицательных";
            this.negativeCheckBox.UseVisualStyleBackColor = true;
            this.negativeCheckBox.CheckedChanged += new System.EventHandler(this.negativeCheckBox_CheckedChanged);
            // 
            // positiveCheckBox
            // 
            this.positiveCheckBox.AutoSize = true;
            this.positiveCheckBox.Location = new System.Drawing.Point(90, 110);
            this.positiveCheckBox.Name = "positiveCheckBox";
            this.positiveCheckBox.Size = new System.Drawing.Size(108, 17);
            this.positiveCheckBox.TabIndex = 7;
            this.positiveCheckBox.Text = "Положительных";
            this.positiveCheckBox.UseVisualStyleBackColor = true;
            this.positiveCheckBox.CheckedChanged += new System.EventHandler(this.positiveCheckBox_CheckedChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(3, 133);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Выполнить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.positiveCheckBox);
            this.Controls.Add(this.negativeCheckBox);
            this.Controls.Add(this.afterCheckBox);
            this.Controls.Add(this.beforeCheckBox);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.CheckBox beforeCheckBox;
        private System.Windows.Forms.CheckBox afterCheckBox;
        private System.Windows.Forms.CheckBox negativeCheckBox;
        private System.Windows.Forms.CheckBox positiveCheckBox;
        private System.Windows.Forms.Button runButton;
    }
}

