﻿namespace postaOtomasyon
{
    partial class frmBilgiGuncelle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(254, 168);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 25;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(254, 202);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 22);
            this.txtTel.TabIndex = 24;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(254, 278);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 23;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(254, 241);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 22);
            this.txtEposta.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "E posta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "TC";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(254, 135);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(93, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(27, 19);
            this.label.TabIndex = 28;
            this.label.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(254, 97);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(889, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 45);
            this.button2.TabIndex = 32;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 619);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBilgiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme İşlemleri";
            this.Load += new System.EventHandler(this.frmBilgiGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button2;
    }
}