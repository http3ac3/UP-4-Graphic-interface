namespace UP_4_Graphic_interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.AValueBox = new System.Windows.Forms.TextBox();
            this.BValueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetNodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число а > 0:";
            // 
            // AValueBox
            // 
            this.AValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AValueBox.Location = new System.Drawing.Point(165, 10);
            this.AValueBox.Name = "AValueBox";
            this.AValueBox.Size = new System.Drawing.Size(100, 23);
            this.AValueBox.TabIndex = 1;
            // 
            // BValueBox
            // 
            this.BValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BValueBox.Location = new System.Drawing.Point(165, 39);
            this.BValueBox.Name = "BValueBox";
            this.BValueBox.Size = new System.Drawing.Size(100, 23);
            this.BValueBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите число b > 0:";
            // 
            // GetNodButton
            // 
            this.GetNodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetNodButton.Location = new System.Drawing.Point(271, 13);
            this.GetNodButton.Name = "GetNodButton";
            this.GetNodButton.Size = new System.Drawing.Size(137, 46);
            this.GetNodButton.TabIndex = 4;
            this.GetNodButton.Text = "Узнать НОД а и b";
            this.GetNodButton.UseVisualStyleBackColor = true;
            this.GetNodButton.Click += new System.EventHandler(this.GetNodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 82);
            this.Controls.Add(this.GetNodButton);
            this.Controls.Add(this.BValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AValueBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "4.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AValueBox;
        private System.Windows.Forms.TextBox BValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetNodButton;
    }
}

