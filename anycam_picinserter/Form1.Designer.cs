
namespace anycam_picinserter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_loaddump = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfilepath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.offsetdec = new System.Windows.Forms.Button();
            this.offsetadd = new System.Windows.Forms.Button();
            this.textBoxTextSize = new System.Windows.Forms.TextBox();
            this.textBoxBMHeight = new System.Windows.Forms.TextBox();
            this.textBoxBMWidth = new System.Windows.Forms.TextBox();
            this.textBoxOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_patchdump = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button3 = new System.Windows.Forms.Button();
            this.bSaveBitmap = new System.Windows.Forms.Button();
            this.bLoadBitmap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_loaddump
            // 
            this.button_loaddump.Location = new System.Drawing.Point(6, 42);
            this.button_loaddump.Name = "button_loaddump";
            this.button_loaddump.Size = new System.Drawing.Size(75, 23);
            this.button_loaddump.TabIndex = 0;
            this.button_loaddump.Text = "Load Dump";
            this.button_loaddump.UseVisualStyleBackColor = true;
            this.button_loaddump.Click += new System.EventHandler(this.button_loaddump_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filepath:";
            // 
            // textBoxfilepath
            // 
            this.textBoxfilepath.Location = new System.Drawing.Point(60, 16);
            this.textBoxfilepath.Name = "textBoxfilepath";
            this.textBoxfilepath.Size = new System.Drawing.Size(116, 20);
            this.textBoxfilepath.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.offsetdec);
            this.groupBox1.Controls.Add(this.offsetadd);
            this.groupBox1.Controls.Add(this.textBoxTextSize);
            this.groupBox1.Controls.Add(this.textBoxBMHeight);
            this.groupBox1.Controls.Add(this.textBoxBMWidth);
            this.groupBox1.Controls.Add(this.textBoxOffset);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitmap Settings";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "WR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // offsetdec
            // 
            this.offsetdec.Location = new System.Drawing.Point(220, 11);
            this.offsetdec.Name = "offsetdec";
            this.offsetdec.Size = new System.Drawing.Size(24, 24);
            this.offsetdec.TabIndex = 9;
            this.offsetdec.Text = "-";
            this.offsetdec.UseVisualStyleBackColor = true;
            this.offsetdec.Click += new System.EventHandler(this.offsetdec_Click);
            // 
            // offsetadd
            // 
            this.offsetadd.Location = new System.Drawing.Point(190, 11);
            this.offsetadd.Name = "offsetadd";
            this.offsetadd.Size = new System.Drawing.Size(24, 24);
            this.offsetadd.TabIndex = 8;
            this.offsetadd.Text = "+";
            this.offsetadd.UseVisualStyleBackColor = true;
            this.offsetadd.Click += new System.EventHandler(this.offsetadd_Click);
            // 
            // textBoxTextSize
            // 
            this.textBoxTextSize.Location = new System.Drawing.Point(84, 85);
            this.textBoxTextSize.Name = "textBoxTextSize";
            this.textBoxTextSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxTextSize.TabIndex = 7;
            this.textBoxTextSize.Text = "1";
            // 
            // textBoxBMHeight
            // 
            this.textBoxBMHeight.Location = new System.Drawing.Point(84, 61);
            this.textBoxBMHeight.Name = "textBoxBMHeight";
            this.textBoxBMHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxBMHeight.TabIndex = 6;
            this.textBoxBMHeight.Text = "17";
            // 
            // textBoxBMWidth
            // 
            this.textBoxBMWidth.Location = new System.Drawing.Point(84, 35);
            this.textBoxBMWidth.Name = "textBoxBMWidth";
            this.textBoxBMWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxBMWidth.TabIndex = 5;
            this.textBoxBMWidth.Text = "12";
            // 
            // textBoxOffset
            // 
            this.textBoxOffset.Location = new System.Drawing.Point(84, 11);
            this.textBoxOffset.Name = "textBoxOffset";
            this.textBoxOffset.Size = new System.Drawing.Size(100, 20);
            this.textBoxOffset.TabIndex = 4;
            this.textBoxOffset.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Text size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "BM Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "BM Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Offset:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_patchdump);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxfilepath);
            this.groupBox2.Controls.Add(this.button_loaddump);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Operations";
            // 
            // button_patchdump
            // 
            this.button_patchdump.Location = new System.Drawing.Point(6, 72);
            this.button_patchdump.Name = "button_patchdump";
            this.button_patchdump.Size = new System.Drawing.Size(75, 23);
            this.button_patchdump.TabIndex = 3;
            this.button_patchdump.Text = "Patch Dump";
            this.button_patchdump.UseVisualStyleBackColor = true;
            this.button_patchdump.Click += new System.EventHandler(this.button_patchdump_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 210);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image from Dump";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(392, 118);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 115);
            this.vScrollBar1.SmallChange = 10;
            this.vScrollBar1.TabIndex = 7;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bSaveBitmap
            // 
            this.bSaveBitmap.Location = new System.Drawing.Point(283, 118);
            this.bSaveBitmap.Name = "bSaveBitmap";
            this.bSaveBitmap.Size = new System.Drawing.Size(75, 23);
            this.bSaveBitmap.TabIndex = 9;
            this.bSaveBitmap.Text = "Save Bitmap";
            this.bSaveBitmap.UseVisualStyleBackColor = true;
            this.bSaveBitmap.Click += new System.EventHandler(this.bSaveBitmap_Click);
            // 
            // bLoadBitmap
            // 
            this.bLoadBitmap.Location = new System.Drawing.Point(283, 147);
            this.bLoadBitmap.Name = "bLoadBitmap";
            this.bLoadBitmap.Size = new System.Drawing.Size(75, 23);
            this.bLoadBitmap.TabIndex = 10;
            this.bLoadBitmap.Text = "Load Bitmap";
            this.bLoadBitmap.UseVisualStyleBackColor = true;
            this.bLoadBitmap.Click += new System.EventHandler(this.bLoadBitmap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLoadBitmap);
            this.Controls.Add(this.bSaveBitmap);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_loaddump;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxfilepath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button offsetdec;
        private System.Windows.Forms.Button offsetadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_patchdump;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBoxTextSize;
        public System.Windows.Forms.TextBox textBoxBMHeight;
        public System.Windows.Forms.TextBox textBoxBMWidth;
        public System.Windows.Forms.TextBox textBoxOffset;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bSaveBitmap;
        private System.Windows.Forms.Button bLoadBitmap;
    }
}

