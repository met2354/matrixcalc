namespace Matrix
{
    partial class FMain
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
            this.bAmount = new System.Windows.Forms.Button();
            this.bDifference = new System.Windows.Forms.Button();
            this.bProduct = new System.Windows.Forms.Button();
            this.bDet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAmount
            // 
            this.bAmount.Location = new System.Drawing.Point(28, 12);
            this.bAmount.Name = "bAmount";
            this.bAmount.Size = new System.Drawing.Size(254, 52);
            this.bAmount.TabIndex = 0;
            this.bAmount.Text = "A + B";
            this.bAmount.UseVisualStyleBackColor = true;
            this.bAmount.Click += new System.EventHandler(this.BAmount_Click);
            // 
            // bDifference
            // 
            this.bDifference.Location = new System.Drawing.Point(28, 70);
            this.bDifference.Name = "bDifference";
            this.bDifference.Size = new System.Drawing.Size(254, 52);
            this.bDifference.TabIndex = 1;
            this.bDifference.Text = "A - B";
            this.bDifference.UseVisualStyleBackColor = true;
            this.bDifference.Click += new System.EventHandler(this.BDifference_Click);
            // 
            // bProduct
            // 
            this.bProduct.Location = new System.Drawing.Point(28, 128);
            this.bProduct.Name = "bProduct";
            this.bProduct.Size = new System.Drawing.Size(254, 52);
            this.bProduct.TabIndex = 2;
            this.bProduct.Text = "A * B";
            this.bProduct.UseVisualStyleBackColor = true;
            this.bProduct.Click += new System.EventHandler(this.BProduct_Click);
            // 
            // bDet
            // 
            this.bDet.Location = new System.Drawing.Point(28, 186);
            this.bDet.Name = "bDet";
            this.bDet.Size = new System.Drawing.Size(254, 52);
            this.bDet.TabIndex = 3;
            this.bDet.Text = "det |A|";
            this.bDet.UseVisualStyleBackColor = true;
            this.bDet.Click += new System.EventHandler(this.bDet_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.bDet);
            this.Controls.Add(this.bProduct);
            this.Controls.Add(this.bDifference);
            this.Controls.Add(this.bAmount);
            this.Name = "FMain";
            this.Text = "Калькулятор матриц";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAmount;
        private System.Windows.Forms.Button bDifference;
        private System.Windows.Forms.Button bProduct;
        private System.Windows.Forms.Button bDet;
    }
}

