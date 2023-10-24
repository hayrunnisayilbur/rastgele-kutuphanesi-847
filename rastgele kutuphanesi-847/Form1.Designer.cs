namespace rastgele_kutuphanesi_847
{
    partial class Form1
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
            this.btnUret = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(84, 97);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(75, 23);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(185, 97);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(120, 225);
            this.lbNotlar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(421, 373);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.btnUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.ListBox lbNotlar;
    }
}

