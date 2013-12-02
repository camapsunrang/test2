namespace DongHo
{
    partial class ucDongHo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbPhut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.lbGiay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhut.Location = new System.Drawing.Point(54, 9);
            this.lbPhut.Margin = new System.Windows.Forms.Padding(0);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Size = new System.Drawing.Size(36, 25);
            this.lbPhut.TabIndex = 5;
            this.lbPhut.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.Location = new System.Drawing.Point(11, 9);
            this.lbGio.Margin = new System.Windows.Forms.Padding(0);
            this.lbGio.Name = "lbGio";
            this.lbGio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbGio.Size = new System.Drawing.Size(36, 25);
            this.lbGio.TabIndex = 3;
            this.lbGio.Text = "00";
            // 
            // lbGiay
            // 
            this.lbGiay.AutoSize = true;
            this.lbGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiay.Location = new System.Drawing.Point(98, 9);
            this.lbGiay.Margin = new System.Windows.Forms.Padding(0);
            this.lbGiay.Name = "lbGiay";
            this.lbGiay.Size = new System.Drawing.Size(36, 25);
            this.lbGiay.TabIndex = 7;
            this.lbGiay.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbGiay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPhut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGio);
            this.Name = "ucDongHo";
            this.Size = new System.Drawing.Size(141, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbPhut;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lbGio;
        internal System.Windows.Forms.Label lbGiay;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;

    }
}
