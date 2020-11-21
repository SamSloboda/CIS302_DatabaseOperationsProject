namespace ProductDy
{
    partial class Insert
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
            this.txtProductNo = new System.Windows.Forms.TextBox();
            this.txtProductDes = new System.Windows.Forms.TextBox();
            this.txtProductOH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProductNo
            // 
            this.txtProductNo.Location = new System.Drawing.Point(113, 45);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.Size = new System.Drawing.Size(148, 20);
            this.txtProductNo.TabIndex = 0;
            this.txtProductNo.TextChanged += new System.EventHandler(this.txtProductNo_TextChanged);
            // 
            // txtProductDes
            // 
            this.txtProductDes.Location = new System.Drawing.Point(113, 71);
            this.txtProductDes.Name = "txtProductDes";
            this.txtProductDes.Size = new System.Drawing.Size(148, 20);
            this.txtProductDes.TabIndex = 1;
            this.txtProductDes.TextChanged += new System.EventHandler(this.txtProductDes_TextChanged);
            // 
            // txtProductOH
            // 
            this.txtProductOH.Location = new System.Drawing.Point(113, 97);
            this.txtProductOH.Name = "txtProductOH";
            this.txtProductOH.Size = new System.Drawing.Size(148, 20);
            this.txtProductOH.TabIndex = 2;
            this.txtProductOH.TextChanged += new System.EventHandler(this.txtProductOH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit on hands";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(113, 123);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(148, 20);
            this.txtProductPrice.TabIndex = 7;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductOH);
            this.Controls.Add(this.txtProductDes);
            this.Controls.Add(this.txtProductNo);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductNo;
        private System.Windows.Forms.TextBox txtProductDes;
        private System.Windows.Forms.TextBox txtProductOH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Button button1;
    }
}