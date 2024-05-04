namespace Typograph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.typographButton = new System.Windows.Forms.Button();
            this.textIn = new System.Windows.Forms.TextBox();
            this.labelIn = new System.Windows.Forms.Label();
            this.mainlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typographButton
            // 
            this.typographButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typographButton.Location = new System.Drawing.Point(273, 483);
            this.typographButton.Name = "typographButton";
            this.typographButton.Size = new System.Drawing.Size(159, 58);
            this.typographButton.TabIndex = 0;
            this.typographButton.Text = "Оттипографить";
            this.typographButton.UseVisualStyleBackColor = true;
            this.typographButton.Click += new System.EventHandler(this.DoTypograph);
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(12, 141);
            this.textIn.Multiline = true;
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(680, 336);
            this.textIn.TabIndex = 1;
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIn.Location = new System.Drawing.Point(10, 97);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(339, 24);
            this.labelIn.TabIndex = 3;
            this.labelIn.Text = "Введите текст для редактирования:";
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainlabel.Location = new System.Drawing.Point(188, 15);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(329, 64);
            this.mainlabel.TabIndex = 5;
            this.mainlabel.Text = "- Это \"Типограф\"?\r\n— Нет, это «Типограф»!\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(704, 550);
            this.Controls.Add(this.mainlabel);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.typographButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Типограф";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button typographButton;
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label mainlabel;
    }
}

