namespace Matrix
{
    partial class FDet
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
            this.lsize = new System.Windows.Forms.Label();
            this.cBsize = new System.Windows.Forms.ComboBox();
            this.bdet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsize
            // 
            this.lsize.AutoSize = true;
            this.lsize.Location = new System.Drawing.Point(14, 16);
            this.lsize.Name = "lsize";
            this.lsize.Size = new System.Drawing.Size(49, 13);
            this.lsize.TabIndex = 0;
            this.lsize.Text = "Размер:";
            // 
            // cBsize
            // 
            this.cBsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBsize.FormattingEnabled = true;
            this.cBsize.Items.AddRange(new object[] {
            "2 x 2",
            "3 x 3",
            "4 x 4",
            "5 x 5"});
            this.cBsize.Location = new System.Drawing.Point(69, 13);
            this.cBsize.Name = "cBsize";
            this.cBsize.Size = new System.Drawing.Size(121, 21);
            this.cBsize.TabIndex = 1;
            this.cBsize.SelectedIndexChanged += new System.EventHandler(this.CBsize_SelectedIndexChanged);
            // 
            // bdet
            // 
            this.bdet.Location = new System.Drawing.Point(17, 55);
            this.bdet.Name = "bdet";
            this.bdet.Size = new System.Drawing.Size(119, 23);
            this.bdet.TabIndex = 2;
            this.bdet.Text = "Определитель";
            this.bdet.UseVisualStyleBackColor = true;
            this.bdet.Click += new System.EventHandler(this.Bdet_Click);
            // 
            // FDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdet);
            this.Controls.Add(this.cBsize);
            this.Controls.Add(this.lsize);
            this.Name = "FDet";
            this.Text = "FDet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FDet_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lsize;
        private System.Windows.Forms.ComboBox cBsize;
        private System.Windows.Forms.Button bdet;
    }
}