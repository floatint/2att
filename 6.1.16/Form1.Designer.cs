namespace _6._1._16
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
            this.runButton = new System.Windows.Forms.Button();
            this.enterBox = new System.Windows.Forms.TextBox();
            this.enterLabel = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.wordList = new System.Windows.Forms.ListBox();
            this.labelNValue = new System.Windows.Forms.Label();
            this.editNValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(6, 206);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(121, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Разобрать на слова";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterBox
            // 
            this.enterBox.Location = new System.Drawing.Point(6, 25);
            this.enterBox.Name = "enterBox";
            this.enterBox.Size = new System.Drawing.Size(277, 20);
            this.enterBox.TabIndex = 1;
            this.enterBox.TextChanged += new System.EventHandler(this.enterBox_TextChanged);
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(3, 9);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(92, 13);
            this.enterLabel.TabIndex = 2;
            this.enterLabel.Text = "Введите строку :";
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(3, 89);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(47, 13);
            this.outLabel.TabIndex = 4;
            this.outLabel.Text = "Слова : ";
            // 
            // wordList
            // 
            this.wordList.FormattingEnabled = true;
            this.wordList.Location = new System.Drawing.Point(6, 105);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(277, 95);
            this.wordList.TabIndex = 5;
            // 
            // labelNValue
            // 
            this.labelNValue.AutoSize = true;
            this.labelNValue.Location = new System.Drawing.Point(3, 48);
            this.labelNValue.Name = "labelNValue";
            this.labelNValue.Size = new System.Drawing.Size(116, 13);
            this.labelNValue.TabIndex = 6;
            this.labelNValue.Text = "Введите значение N :";
            // 
            // editNValue
            // 
            this.editNValue.Location = new System.Drawing.Point(6, 64);
            this.editNValue.Name = "editNValue";
            this.editNValue.Size = new System.Drawing.Size(277, 20);
            this.editNValue.TabIndex = 7;
            this.editNValue.TextChanged += new System.EventHandler(this.editNValue_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 233);
            this.Controls.Add(this.editNValue);
            this.Controls.Add(this.labelNValue);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.enterBox);
            this.Controls.Add(this.runButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox enterBox;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.ListBox wordList;
        private System.Windows.Forms.Label labelNValue;
        private System.Windows.Forms.TextBox editNValue;
    }
}

