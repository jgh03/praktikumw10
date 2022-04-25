
namespace praktikumw8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIsiStadium = new System.Windows.Forms.Label();
            this.labelIsiCapacity = new System.Windows.Forms.Label();
            this.labelOutputManager1 = new System.Windows.Forms.Label();
            this.labelOutputCaptain1 = new System.Windows.Forms.Label();
            this.labelOutputManager2 = new System.Windows.Forms.Label();
            this.labelOutputCaptain2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelOutputTanggal = new System.Windows.Forms.Label();
            this.labelOutputSkor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Captain:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "VS";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 57);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manager:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Captain:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stadium:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Capacity:";
            // 
            // labelIsiStadium
            // 
            this.labelIsiStadium.AutoSize = true;
            this.labelIsiStadium.Location = new System.Drawing.Point(287, 198);
            this.labelIsiStadium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsiStadium.Name = "labelIsiStadium";
            this.labelIsiStadium.Size = new System.Drawing.Size(0, 13);
            this.labelIsiStadium.TabIndex = 3;
            // 
            // labelIsiCapacity
            // 
            this.labelIsiCapacity.AutoSize = true;
            this.labelIsiCapacity.Location = new System.Drawing.Point(287, 242);
            this.labelIsiCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsiCapacity.Name = "labelIsiCapacity";
            this.labelIsiCapacity.Size = new System.Drawing.Size(0, 13);
            this.labelIsiCapacity.TabIndex = 0;
            // 
            // labelOutputManager1
            // 
            this.labelOutputManager1.AutoSize = true;
            this.labelOutputManager1.Location = new System.Drawing.Point(169, 88);
            this.labelOutputManager1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputManager1.Name = "labelOutputManager1";
            this.labelOutputManager1.Size = new System.Drawing.Size(0, 13);
            this.labelOutputManager1.TabIndex = 0;
            this.labelOutputManager1.Click += new System.EventHandler(this.labelOutputManager1_Click);
            // 
            // labelOutputCaptain1
            // 
            this.labelOutputCaptain1.AutoSize = true;
            this.labelOutputCaptain1.Location = new System.Drawing.Point(169, 131);
            this.labelOutputCaptain1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputCaptain1.Name = "labelOutputCaptain1";
            this.labelOutputCaptain1.Size = new System.Drawing.Size(0, 13);
            this.labelOutputCaptain1.TabIndex = 0;
            // 
            // labelOutputManager2
            // 
            this.labelOutputManager2.AutoSize = true;
            this.labelOutputManager2.Location = new System.Drawing.Point(403, 88);
            this.labelOutputManager2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputManager2.Name = "labelOutputManager2";
            this.labelOutputManager2.Size = new System.Drawing.Size(0, 13);
            this.labelOutputManager2.TabIndex = 0;
            // 
            // labelOutputCaptain2
            // 
            this.labelOutputCaptain2.AutoSize = true;
            this.labelOutputCaptain2.Location = new System.Drawing.Point(403, 131);
            this.labelOutputCaptain2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputCaptain2.Name = "labelOutputCaptain2";
            this.labelOutputCaptain2.Size = new System.Drawing.Size(0, 13);
            this.labelOutputCaptain2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tanggal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 362);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Skor:";
            // 
            // labelOutputTanggal
            // 
            this.labelOutputTanggal.AutoSize = true;
            this.labelOutputTanggal.Location = new System.Drawing.Point(290, 329);
            this.labelOutputTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputTanggal.Name = "labelOutputTanggal";
            this.labelOutputTanggal.Size = new System.Drawing.Size(0, 13);
            this.labelOutputTanggal.TabIndex = 0;
            // 
            // labelOutputSkor
            // 
            this.labelOutputSkor.AutoSize = true;
            this.labelOutputSkor.Location = new System.Drawing.Point(291, 362);
            this.labelOutputSkor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputSkor.Name = "labelOutputSkor";
            this.labelOutputSkor.Size = new System.Drawing.Size(0, 13);
            this.labelOutputSkor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 395);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(466, 162);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelIsiStadium);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelIsiCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOutputSkor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelOutputTanggal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelOutputCaptain1);
            this.Controls.Add(this.labelOutputCaptain2);
            this.Controls.Add(this.labelOutputManager2);
            this.Controls.Add(this.labelOutputManager1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelIsiStadium;
        private System.Windows.Forms.Label labelIsiCapacity;
        private System.Windows.Forms.Label labelOutputManager1;
        private System.Windows.Forms.Label labelOutputCaptain1;
        private System.Windows.Forms.Label labelOutputManager2;
        private System.Windows.Forms.Label labelOutputCaptain2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelOutputTanggal;
        private System.Windows.Forms.Label labelOutputSkor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

