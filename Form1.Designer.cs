namespace LiveRecognition
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEstadisticas = new System.Windows.Forms.TextBox();
            this.lblPerCara = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFaceAnalysis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 524);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(888, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(888, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEstadisticas
            // 
            this.txtEstadisticas.Location = new System.Drawing.Point(700, 70);
            this.txtEstadisticas.Multiline = true;
            this.txtEstadisticas.Name = "txtEstadisticas";
            this.txtEstadisticas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstadisticas.Size = new System.Drawing.Size(263, 466);
            this.txtEstadisticas.TabIndex = 5;
            // 
            // lblPerCara
            // 
            this.lblPerCara.AutoSize = true;
            this.lblPerCara.Location = new System.Drawing.Point(697, 54);
            this.lblPerCara.Name = "lblPerCara";
            this.lblPerCara.Size = new System.Drawing.Size(94, 13);
            this.lblPerCara.TabIndex = 6;
            this.lblPerCara.Text = "Perimetro de Cara:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(700, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnFaceAnalysis
            // 
            this.btnFaceAnalysis.Location = new System.Drawing.Point(794, 12);
            this.btnFaceAnalysis.Name = "btnFaceAnalysis";
            this.btnFaceAnalysis.Size = new System.Drawing.Size(88, 23);
            this.btnFaceAnalysis.TabIndex = 8;
            this.btnFaceAnalysis.Text = "FaceAnalysis";
            this.btnFaceAnalysis.UseVisualStyleBackColor = true;
            this.btnFaceAnalysis.Click += new System.EventHandler(this.btnFaceAnalysis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 566);
            this.Controls.Add(this.btnFaceAnalysis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPerCara);
            this.Controls.Add(this.txtEstadisticas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Live Facial Features";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEstadisticas;
        private System.Windows.Forms.Label lblPerCara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFaceAnalysis;
    }
}

