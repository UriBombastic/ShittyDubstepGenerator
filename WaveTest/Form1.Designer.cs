﻿namespace WaveTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBitRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSamplesPS = new System.Windows.Forms.TextBox();
            this.txtBitsPerSample = new System.Windows.Forms.TextBox();
            this.txtTracks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "From File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Static";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File";
            // 
            // txtBitRate
            // 
            this.txtBitRate.Location = new System.Drawing.Point(623, 276);
            this.txtBitRate.Name = "txtBitRate";
            this.txtBitRate.Size = new System.Drawing.Size(153, 20);
            this.txtBitRate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BitRate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SamplesPerSecond";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "BitsPerSample";
            // 
            // txtSamplesPS
            // 
            this.txtSamplesPS.Location = new System.Drawing.Point(620, 169);
            this.txtSamplesPS.Name = "txtSamplesPS";
            this.txtSamplesPS.Size = new System.Drawing.Size(156, 20);
            this.txtSamplesPS.TabIndex = 10;
            this.txtSamplesPS.Text = "44100";
            // 
            // txtBitsPerSample
            // 
            this.txtBitsPerSample.Location = new System.Drawing.Point(623, 223);
            this.txtBitsPerSample.Name = "txtBitsPerSample";
            this.txtBitsPerSample.Size = new System.Drawing.Size(153, 20);
            this.txtBitsPerSample.TabIndex = 11;
            this.txtBitsPerSample.Text = "16";
            // 
            // txtTracks
            // 
            this.txtTracks.Location = new System.Drawing.Point(620, 117);
            this.txtTracks.Name = "txtTracks";
            this.txtTracks.Size = new System.Drawing.Size(156, 20);
            this.txtTracks.TabIndex = 12;
            this.txtTracks.Text = "2";
    
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tracks";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // chkOverride
            // 
            this.chkOverride.AutoSize = true;
            this.chkOverride.Location = new System.Drawing.Point(545, 276);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(72, 17);
            this.chkOverride.TabIndex = 14;
            this.chkOverride.Text = "Override?";
            this.chkOverride.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkOverride);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTracks);
            this.Controls.Add(this.txtBitsPerSample);
            this.Controls.Add(this.txtSamplesPS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBitRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();


            //Text Changed
            this.txtTracks.TextChanged += new System.EventHandler(this.TextChanged);
            this.txtSamplesPS.TextChanged += new System.EventHandler(this.TextChanged);
            this.txtBitsPerSample.TextChanged += new System.EventHandler(this.TextChanged);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBitRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSamplesPS;
        private System.Windows.Forms.TextBox txtBitsPerSample;
        private System.Windows.Forms.TextBox txtTracks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkOverride;
    }
}

