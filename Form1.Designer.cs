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
            this.btnFaceAnalysis = new System.Windows.Forms.Button();
            this.lblCalibradoA = new System.Windows.Forms.Label();
            this.txtCalibrada = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSorpresa = new System.Windows.Forms.Label();
            this.lblSonriza = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbVerRefs = new System.Windows.Forms.CheckBox();
            this.btnRecalibrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(700, 12);
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
            this.label1.Location = new System.Drawing.Point(557, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(781, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEstadisticas
            // 
            this.txtEstadisticas.Location = new System.Drawing.Point(936, 263);
            this.txtEstadisticas.Multiline = true;
            this.txtEstadisticas.Name = "txtEstadisticas";
            this.txtEstadisticas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstadisticas.Size = new System.Drawing.Size(240, 273);
            this.txtEstadisticas.TabIndex = 5;
            // 
            // lblPerCara
            // 
            this.lblPerCara.AutoSize = true;
            this.lblPerCara.Location = new System.Drawing.Point(6, 16);
            this.lblPerCara.Name = "lblPerCara";
            this.lblPerCara.Size = new System.Drawing.Size(94, 13);
            this.lblPerCara.TabIndex = 6;
            this.lblPerCara.Text = "Perimetro de Cara:";
            // 
            // btnFaceAnalysis
            // 
            this.btnFaceAnalysis.Location = new System.Drawing.Point(1001, 239);
            this.btnFaceAnalysis.Name = "btnFaceAnalysis";
            this.btnFaceAnalysis.Size = new System.Drawing.Size(88, 23);
            this.btnFaceAnalysis.TabIndex = 8;
            this.btnFaceAnalysis.Text = "Informacion";
            this.btnFaceAnalysis.UseVisualStyleBackColor = true;
            this.btnFaceAnalysis.Click += new System.EventHandler(this.btnFaceAnalysis_Click);
            // 
            // lblCalibradoA
            // 
            this.lblCalibradoA.AutoSize = true;
            this.lblCalibradoA.Location = new System.Drawing.Point(933, 80);
            this.lblCalibradoA.Name = "lblCalibradoA";
            this.lblCalibradoA.Size = new System.Drawing.Size(63, 13);
            this.lblCalibradoA.TabIndex = 10;
            this.lblCalibradoA.Text = "Calibrado a:";
            // 
            // txtCalibrada
            // 
            this.txtCalibrada.Location = new System.Drawing.Point(936, 96);
            this.txtCalibrada.Multiline = true;
            this.txtCalibrada.Name = "txtCalibrada";
            this.txtCalibrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCalibrada.Size = new System.Drawing.Size(243, 138);
            this.txtCalibrada.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSorpresa);
            this.groupBox1.Controls.Add(this.lblSonriza);
            this.groupBox1.Location = new System.Drawing.Point(700, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expresiones faciales";
            // 
            // lblSorpresa
            // 
            this.lblSorpresa.AutoSize = true;
            this.lblSorpresa.Location = new System.Drawing.Point(6, 34);
            this.lblSorpresa.Name = "lblSorpresa";
            this.lblSorpresa.Size = new System.Drawing.Size(55, 13);
            this.lblSorpresa.TabIndex = 8;
            this.lblSorpresa.Text = "Sorpresa: ";
            // 
            // lblSonriza
            // 
            this.lblSonriza.AutoSize = true;
            this.lblSonriza.Location = new System.Drawing.Point(6, 16);
            this.lblSonriza.Name = "lblSonriza";
            this.lblSonriza.Size = new System.Drawing.Size(48, 13);
            this.lblSonriza.TabIndex = 0;
            this.lblSonriza.Text = "Sonriza: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblPerCara);
            this.groupBox2.Location = new System.Drawing.Point(700, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(933, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Infomacion:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbVerRefs);
            this.groupBox3.Location = new System.Drawing.Point(700, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // cbVerRefs
            // 
            this.cbVerRefs.AutoSize = true;
            this.cbVerRefs.Location = new System.Drawing.Point(9, 19);
            this.cbVerRefs.Name = "cbVerRefs";
            this.cbVerRefs.Size = new System.Drawing.Size(67, 17);
            this.cbVerRefs.TabIndex = 0;
            this.cbVerRefs.Text = "Ver Refs";
            this.cbVerRefs.UseVisualStyleBackColor = true;
            this.cbVerRefs.CheckedChanged += new System.EventHandler(this.cbVerRefs_CheckedChanged);
            // 
            // btnRecalibrar
            // 
            this.btnRecalibrar.Location = new System.Drawing.Point(700, 42);
            this.btnRecalibrar.Name = "btnRecalibrar";
            this.btnRecalibrar.Size = new System.Drawing.Size(75, 23);
            this.btnRecalibrar.TabIndex = 19;
            this.btnRecalibrar.Text = "Recalibrar";
            this.btnRecalibrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 566);
            this.Controls.Add(this.btnRecalibrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCalibrada);
            this.Controls.Add(this.lblCalibradoA);
            this.Controls.Add(this.btnFaceAnalysis);
            this.Controls.Add(this.txtEstadisticas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Expresiones Faciales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnFaceAnalysis;
        private System.Windows.Forms.Label lblCalibradoA;
        private System.Windows.Forms.TextBox txtCalibrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSonriza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSorpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbVerRefs;
        private System.Windows.Forms.Button btnRecalibrar;
    }
}

