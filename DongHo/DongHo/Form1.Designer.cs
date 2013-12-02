namespace DongHo
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
            this.btnSet = new System.Windows.Forms.Button();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.txtPhut = new System.Windows.Forms.TextBox();
            this.txtGiay = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucDongHo1 = new DongHo.ucDongHo();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(177, 91);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(12, 93);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(46, 20);
            this.txtGio.TabIndex = 2;
            this.txtGio.Text = "0";
            this.txtGio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGio_KeyPress);
            // 
            // txtPhut
            // 
            this.txtPhut.Location = new System.Drawing.Point(64, 93);
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(46, 20);
            this.txtPhut.TabIndex = 2;
            this.txtPhut.Text = "0";
            this.txtPhut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhut_KeyPress);
            // 
            // txtGiay
            // 
            this.txtGiay.Location = new System.Drawing.Point(116, 93);
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(46, 20);
            this.txtGiay.TabIndex = 2;
            this.txtGiay.Text = "0";
            this.txtGiay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiay_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(174, 135);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giây";
            // 
            // ucDongHo1
            // 
            this.ucDongHo1.Giay = 0;
            this.ucDongHo1.Gio = 0;
            this.ucDongHo1.Location = new System.Drawing.Point(59, 12);
            this.ucDongHo1.Name = "ucDongHo1";
            this.ucDongHo1.Phut = 0;
            this.ucDongHo1.Size = new System.Drawing.Size(141, 44);
            this.ucDongHo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.ucDongHo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucDongHo ucDongHo1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.TextBox txtPhut;
        private System.Windows.Forms.TextBox txtGiay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

