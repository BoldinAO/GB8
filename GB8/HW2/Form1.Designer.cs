namespace HW2
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
            this.TbAnswer = new System.Windows.Forms.TextBox();
            this.BtGiveAnswer = new System.Windows.Forms.Button();
            this.LbQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbAnswer
            // 
            this.TbAnswer.Location = new System.Drawing.Point(99, 49);
            this.TbAnswer.Name = "TbAnswer";
            this.TbAnswer.Size = new System.Drawing.Size(263, 22);
            this.TbAnswer.TabIndex = 0;
            // 
            // BtGiveAnswer
            // 
            this.BtGiveAnswer.Location = new System.Drawing.Point(142, 92);
            this.BtGiveAnswer.Name = "BtGiveAnswer";
            this.BtGiveAnswer.Size = new System.Drawing.Size(171, 23);
            this.BtGiveAnswer.TabIndex = 1;
            this.BtGiveAnswer.Text = "Ответить";
            this.BtGiveAnswer.UseVisualStyleBackColor = true;
            this.BtGiveAnswer.Click += new System.EventHandler(this.BtGiveAnswer_Click);
            // 
            // LbQuestion
            // 
            this.LbQuestion.AutoSize = true;
            this.LbQuestion.Location = new System.Drawing.Point(96, 9);
            this.LbQuestion.Name = "LbQuestion";
            this.LbQuestion.Size = new System.Drawing.Size(46, 17);
            this.LbQuestion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 171);
            this.Controls.Add(this.LbQuestion);
            this.Controls.Add(this.BtGiveAnswer);
            this.Controls.Add(this.TbAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbAnswer;
        private System.Windows.Forms.Button BtGiveAnswer;
        private System.Windows.Forms.Label LbQuestion;
    }
}

