namespace Matrix
{
    partial class FCalc
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
            this.bResult = new System.Windows.Forms.Button();
            this.cBLine = new System.Windows.Forms.ComboBox();
            this.cBColumn = new System.Windows.Forms.ComboBox();
            this.lLine = new System.Windows.Forms.Label();
            this.lColumn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bResult
            // 
            this.bResult.Location = new System.Drawing.Point(9, 54);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(75, 23);
            this.bResult.TabIndex = 0;
            this.bResult.Text = "Результат";
            this.bResult.UseVisualStyleBackColor = true;
            this.bResult.Click += new System.EventHandler(this.BResult_Click);
            // 
            // cBLine
            // 
            this.cBLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBLine.FormattingEnabled = true;
            this.cBLine.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cBLine.Location = new System.Drawing.Point(128, 6);
            this.cBLine.Name = "cBLine";
            this.cBLine.Size = new System.Drawing.Size(121, 21);
            this.cBLine.TabIndex = 1;
            this.cBLine.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // cBColumn
            // 
            this.cBColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBColumn.FormattingEnabled = true;
            this.cBColumn.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cBColumn.Location = new System.Drawing.Point(128, 33);
            this.cBColumn.Name = "cBColumn";
            this.cBColumn.Size = new System.Drawing.Size(121, 21);
            this.cBColumn.TabIndex = 2;
            this.cBColumn.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // lLine
            // 
            this.lLine.AutoSize = true;
            this.lLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLine.Location = new System.Drawing.Point(6, 9);
            this.lLine.Name = "lLine";
            this.lLine.Size = new System.Drawing.Size(101, 13);
            this.lLine.TabIndex = 3;
            this.lLine.Text = "Количество строк:";
            // 
            // lColumn
            // 
            this.lColumn.AutoSize = true;
            this.lColumn.Location = new System.Drawing.Point(6, 38);
            this.lColumn.Name = "lColumn";
            this.lColumn.Size = new System.Drawing.Size(119, 13);
            this.lColumn.TabIndex = 4;
            this.lColumn.Text = "Количество столбцов:";
            // 
            // FCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lColumn);
            this.Controls.Add(this.lLine);
            this.Controls.Add(this.cBColumn);
            this.Controls.Add(this.cBLine);
            this.Controls.Add(this.bResult);
            this.Name = "FCalc";
            this.Text = "FCalc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCalc_FormClosed);
            this.Shown += new System.EventHandler(this.FCalc_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FCalc_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.ComboBox cBLine;
        private System.Windows.Forms.ComboBox cBColumn;
        private System.Windows.Forms.Label lLine;
        private System.Windows.Forms.Label lColumn;
    }
}