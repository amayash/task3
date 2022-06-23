namespace WindowsFormsApp1
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
            this.firstArrayButton = new System.Windows.Forms.Button();
            this.secondArrayButton = new System.Windows.Forms.Button();
            this.odnom = new System.Windows.Forms.TextBox();
            this.dvumj = new System.Windows.Forms.TextBox();
            this.dvumi = new System.Windows.Forms.TextBox();
            this.original = new System.Windows.Forms.Label();
            this.firstTask = new System.Windows.Forms.Label();
            this.secondTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstArrayButton
            // 
            this.firstArrayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.firstArrayButton.Location = new System.Drawing.Point(406, 439);
            this.firstArrayButton.Margin = new System.Windows.Forms.Padding(5);
            this.firstArrayButton.Name = "firstArrayButton";
            this.firstArrayButton.Size = new System.Drawing.Size(125, 41);
            this.firstArrayButton.TabIndex = 0;
            this.firstArrayButton.Text = "1мерный";
            this.firstArrayButton.UseVisualStyleBackColor = true;
            this.firstArrayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondArrayButton
            // 
            this.secondArrayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.secondArrayButton.Location = new System.Drawing.Point(406, 490);
            this.secondArrayButton.Margin = new System.Windows.Forms.Padding(5);
            this.secondArrayButton.Name = "secondArrayButton";
            this.secondArrayButton.Size = new System.Drawing.Size(125, 41);
            this.secondArrayButton.TabIndex = 1;
            this.secondArrayButton.Text = "2мерный";
            this.secondArrayButton.UseVisualStyleBackColor = true;
            this.secondArrayButton.Click += new System.EventHandler(this.secondArrayButton_Click);
            // 
            // odnom
            // 
            this.odnom.Location = new System.Drawing.Point(315, 445);
            this.odnom.Margin = new System.Windows.Forms.Padding(5);
            this.odnom.Name = "odnom";
            this.odnom.Size = new System.Drawing.Size(80, 30);
            this.odnom.TabIndex = 2;
            this.odnom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dvumj
            // 
            this.dvumj.Location = new System.Drawing.Point(316, 496);
            this.dvumj.Margin = new System.Windows.Forms.Padding(5);
            this.dvumj.Name = "dvumj";
            this.dvumj.Size = new System.Drawing.Size(79, 30);
            this.dvumj.TabIndex = 3;
            // 
            // dvumi
            // 
            this.dvumi.Location = new System.Drawing.Point(226, 496);
            this.dvumi.Margin = new System.Windows.Forms.Padding(5);
            this.dvumi.Name = "dvumi";
            this.dvumi.Size = new System.Drawing.Size(79, 30);
            this.dvumi.TabIndex = 4;
            this.dvumi.TextChanged += new System.EventHandler(this.dvumi_TextChanged);
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.original.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.original.Location = new System.Drawing.Point(3, 9);
            this.original.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(214, 23);
            this.original.TabIndex = 5;
            this.original.Text = "Оригинальный массив - ";
            this.original.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstTask
            // 
            this.firstTask.AutoSize = true;
            this.firstTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstTask.Location = new System.Drawing.Point(3, 235);
            this.firstTask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstTask.Name = "firstTask";
            this.firstTask.Size = new System.Drawing.Size(17, 23);
            this.firstTask.TabIndex = 6;
            this.firstTask.Text = " ";
            // 
            // secondTask
            // 
            this.secondTask.AutoSize = true;
            this.secondTask.Location = new System.Drawing.Point(376, 235);
            this.secondTask.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.secondTask.Name = "secondTask";
            this.secondTask.Size = new System.Drawing.Size(17, 23);
            this.secondTask.TabIndex = 7;
            this.secondTask.Text = " ";
            this.secondTask.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(892, 547);
            this.Controls.Add(this.secondTask);
            this.Controls.Add(this.firstTask);
            this.Controls.Add(this.original);
            this.Controls.Add(this.dvumi);
            this.Controls.Add(this.dvumj);
            this.Controls.Add(this.odnom);
            this.Controls.Add(this.secondArrayButton);
            this.Controls.Add(this.firstArrayButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstArrayButton;
        private System.Windows.Forms.Button secondArrayButton;
        private System.Windows.Forms.TextBox odnom;
        private System.Windows.Forms.TextBox dvumj;
        private System.Windows.Forms.TextBox dvumi;
        private System.Windows.Forms.Label original;
        private System.Windows.Forms.Label firstTask;
        private System.Windows.Forms.Label secondTask;
    }
}

