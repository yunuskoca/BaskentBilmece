namespace BaskentTextli
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.lbCevap = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbSoru = new System.Windows.Forms.Label();
            this.lbCan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPuan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(519, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 43);
            this.button2.TabIndex = 36;
            this.button2.Text = "KAPAT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCevap
            // 
            this.lbCevap.BackColor = System.Drawing.Color.White;
            this.lbCevap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCevap.ForeColor = System.Drawing.Color.Red;
            this.lbCevap.Location = new System.Drawing.Point(568, 295);
            this.lbCevap.Name = "lbCevap";
            this.lbCevap.Size = new System.Drawing.Size(153, 26);
            this.lbCevap.TabIndex = 33;
            this.lbCevap.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(308, 504);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 43);
            this.btnStart.TabIndex = 32;
            this.btnStart.Text = "BAŞLAT";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbSoru
            // 
            this.lbSoru.BackColor = System.Drawing.Color.White;
            this.lbSoru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSoru.ForeColor = System.Drawing.Color.Blue;
            this.lbSoru.Location = new System.Drawing.Point(344, 278);
            this.lbSoru.Name = "lbSoru";
            this.lbSoru.Size = new System.Drawing.Size(406, 56);
            this.lbSoru.TabIndex = 31;
            this.lbSoru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCan
            // 
            this.lbCan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCan.BackColor = System.Drawing.Color.White;
            this.lbCan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbCan.Location = new System.Drawing.Point(885, 102);
            this.lbCan.Name = "lbCan";
            this.lbCan.Size = new System.Drawing.Size(93, 43);
            this.lbCan.TabIndex = 30;
            this.lbCan.Text = "3";
            this.lbCan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(798, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 32);
            this.label7.TabIndex = 29;
            this.label7.Text = "Can :";
            // 
            // lbPuan
            // 
            this.lbPuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPuan.BackColor = System.Drawing.Color.White;
            this.lbPuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPuan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPuan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbPuan.Location = new System.Drawing.Point(118, 102);
            this.lbPuan.Name = "lbPuan";
            this.lbPuan.Size = new System.Drawing.Size(93, 43);
            this.lbPuan.TabIndex = 28;
            this.lbPuan.Text = "0";
            this.lbPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Puan :";
            // 
            // lbSure
            // 
            this.lbSure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSure.BackColor = System.Drawing.Color.White;
            this.lbSure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSure.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbSure.Location = new System.Drawing.Point(457, 103);
            this.lbSure.Name = "lbSure";
            this.lbSure.Size = new System.Drawing.Size(87, 43);
            this.lbSure.TabIndex = 26;
            this.lbSure.Text = "10";
            this.lbSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(369, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Süre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(248, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Aşağıdaki ülkenin başkenti hangisidir ?";
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnC.FlatAppearance.BorderSize = 4;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnC.Location = new System.Drawing.Point(147, 415);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(357, 55);
            this.btnC.TabIndex = 23;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnD.FlatAppearance.BorderSize = 4;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnD.Location = new System.Drawing.Point(513, 415);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(357, 55);
            this.btnD.TabIndex = 22;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnB.FlatAppearance.BorderSize = 4;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnB.Location = new System.Drawing.Point(513, 355);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(357, 55);
            this.btnB.TabIndex = 21;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnA.FlatAppearance.BorderSize = 4;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnA.Location = new System.Drawing.Point(147, 355);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(357, 55);
            this.btnA.TabIndex = 20;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1017, 84);
            this.label3.TabIndex = 34;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(250, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 56);
            this.label6.TabIndex = 41;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1017, 86);
            this.label4.TabIndex = 42;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Futura Md BT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(160, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(697, 60);
            this.label8.TabIndex = 43;
            this.label8.Text = "BAŞKENT BİLMECE OYUNU";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(714, 504);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(230, 42);
            this.axWindowsMediaPlayer1.TabIndex = 44;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1017, 626);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbCan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbCevap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbSoru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAŞKENT BİLMECE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbCevap;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbSoru;
        private System.Windows.Forms.Label lbCan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

