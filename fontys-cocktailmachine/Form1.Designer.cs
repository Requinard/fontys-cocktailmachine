namespace fontys_cocktailmachine
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNonAlcohol = new System.Windows.Forms.Button();
            this.btnAlcohol = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnSinaasappelsap = new System.Windows.Forms.Button();
            this.btnTonic = new System.Windows.Forms.Button();
            this.btnVodka = new System.Windows.Forms.Button();
            this.btnMartini = new System.Windows.Forms.Button();
            this.btnGin = new System.Windows.Forms.Button();
            this.btnTequilla = new System.Windows.Forms.Button();
            this.btnRum = new System.Windows.Forms.Button();
            this.btnPerzik = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnDone = new System.Windows.Forms.Button();
            this.gbNonAlcohol = new System.Windows.Forms.GroupBox();
            this.gbAlcohol = new System.Windows.Forms.GroupBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.gbNonAlcohol.SuspendLayout();
            this.gbAlcohol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(272, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(283, 111);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Boozelicious";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNonAlcohol
            // 
            this.btnNonAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonAlcohol.Location = new System.Drawing.Point(92, 152);
            this.btnNonAlcohol.Name = "btnNonAlcohol";
            this.btnNonAlcohol.Size = new System.Drawing.Size(174, 88);
            this.btnNonAlcohol.TabIndex = 1;
            this.btnNonAlcohol.Text = "Non-Alcoholic Drinks";
            this.btnNonAlcohol.UseVisualStyleBackColor = true;
            this.btnNonAlcohol.Click += new System.EventHandler(this.btnNonAlcohol_Click);
            // 
            // btnAlcohol
            // 
            this.btnAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlcohol.Location = new System.Drawing.Point(561, 155);
            this.btnAlcohol.Name = "btnAlcohol";
            this.btnAlcohol.Size = new System.Drawing.Size(174, 88);
            this.btnAlcohol.TabIndex = 1;
            this.btnAlcohol.Text = "Alcoholic Drinks";
            this.btnAlcohol.UseVisualStyleBackColor = true;
            this.btnAlcohol.Click += new System.EventHandler(this.btnAlcohol_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(723, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 81);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCola
            // 
            this.btnCola.Location = new System.Drawing.Point(6, 21);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(143, 90);
            this.btnCola.TabIndex = 3;
            this.btnCola.Text = "CocaCola";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnSinaasappelsap
            // 
            this.btnSinaasappelsap.Location = new System.Drawing.Point(155, 21);
            this.btnSinaasappelsap.Name = "btnSinaasappelsap";
            this.btnSinaasappelsap.Size = new System.Drawing.Size(143, 90);
            this.btnSinaasappelsap.TabIndex = 3;
            this.btnSinaasappelsap.Text = "Orange Juice";
            this.btnSinaasappelsap.UseVisualStyleBackColor = true;
            this.btnSinaasappelsap.Click += new System.EventHandler(this.btnSinaasappelsap_Click);
            // 
            // btnTonic
            // 
            this.btnTonic.Location = new System.Drawing.Point(304, 21);
            this.btnTonic.Name = "btnTonic";
            this.btnTonic.Size = new System.Drawing.Size(143, 90);
            this.btnTonic.TabIndex = 3;
            this.btnTonic.Text = "Tonic";
            this.btnTonic.UseVisualStyleBackColor = true;
            this.btnTonic.Click += new System.EventHandler(this.btnTonic_Click);
            // 
            // btnVodka
            // 
            this.btnVodka.Location = new System.Drawing.Point(152, 20);
            this.btnVodka.Name = "btnVodka";
            this.btnVodka.Size = new System.Drawing.Size(143, 90);
            this.btnVodka.TabIndex = 3;
            this.btnVodka.Text = "Vodka";
            this.btnVodka.UseVisualStyleBackColor = true;
            this.btnVodka.Click += new System.EventHandler(this.btnVodka_Click);
            // 
            // btnMartini
            // 
            this.btnMartini.Location = new System.Drawing.Point(152, 116);
            this.btnMartini.Name = "btnMartini";
            this.btnMartini.Size = new System.Drawing.Size(143, 90);
            this.btnMartini.TabIndex = 3;
            this.btnMartini.Text = "Martini";
            this.btnMartini.UseVisualStyleBackColor = true;
            this.btnMartini.Click += new System.EventHandler(this.btnMartini_Click);
            // 
            // btnGin
            // 
            this.btnGin.Location = new System.Drawing.Point(301, 20);
            this.btnGin.Name = "btnGin";
            this.btnGin.Size = new System.Drawing.Size(143, 90);
            this.btnGin.TabIndex = 3;
            this.btnGin.Text = "Gin";
            this.btnGin.UseVisualStyleBackColor = true;
            this.btnGin.Click += new System.EventHandler(this.btnGin_Click);
            // 
            // btnTequilla
            // 
            this.btnTequilla.Location = new System.Drawing.Point(301, 116);
            this.btnTequilla.Name = "btnTequilla";
            this.btnTequilla.Size = new System.Drawing.Size(143, 90);
            this.btnTequilla.TabIndex = 3;
            this.btnTequilla.Text = "Tequilla";
            this.btnTequilla.UseVisualStyleBackColor = true;
            this.btnTequilla.Click += new System.EventHandler(this.btnTequilla_Click);
            // 
            // btnRum
            // 
            this.btnRum.Location = new System.Drawing.Point(3, 20);
            this.btnRum.Name = "btnRum";
            this.btnRum.Size = new System.Drawing.Size(143, 90);
            this.btnRum.TabIndex = 3;
            this.btnRum.Text = "Rum";
            this.btnRum.UseVisualStyleBackColor = true;
            this.btnRum.Click += new System.EventHandler(this.btnRum_Click);
            // 
            // btnPerzik
            // 
            this.btnPerzik.Location = new System.Drawing.Point(3, 116);
            this.btnPerzik.Name = "btnPerzik";
            this.btnPerzik.Size = new System.Drawing.Size(143, 90);
            this.btnPerzik.TabIndex = 3;
            this.btnPerzik.Text = "Peach Liquor ";
            this.btnPerzik.UseVisualStyleBackColor = true;
            this.btnPerzik.Click += new System.EventHandler(this.btnPerzik_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(40, 472);
            this.progressBar.Maximum = 150;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(661, 51);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(723, 288);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(182, 81);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbNonAlcohol
            // 
            this.gbNonAlcohol.Controls.Add(this.btnTonic);
            this.gbNonAlcohol.Controls.Add(this.btnCola);
            this.gbNonAlcohol.Controls.Add(this.btnSinaasappelsap);
            this.gbNonAlcohol.Location = new System.Drawing.Point(203, 252);
            this.gbNonAlcohol.Name = "gbNonAlcohol";
            this.gbNonAlcohol.Size = new System.Drawing.Size(450, 123);
            this.gbNonAlcohol.TabIndex = 5;
            this.gbNonAlcohol.TabStop = false;
            this.gbNonAlcohol.Text = " ";
            // 
            // gbAlcohol
            // 
            this.gbAlcohol.Controls.Add(this.btnGin);
            this.gbAlcohol.Controls.Add(this.btnVodka);
            this.gbAlcohol.Controls.Add(this.btnRum);
            this.gbAlcohol.Controls.Add(this.btnTequilla);
            this.gbAlcohol.Controls.Add(this.btnMartini);
            this.gbAlcohol.Controls.Add(this.btnPerzik);
            this.gbAlcohol.Location = new System.Drawing.Point(203, 249);
            this.gbAlcohol.Name = "gbAlcohol";
            this.gbAlcohol.Size = new System.Drawing.Size(450, 217);
            this.gbAlcohol.TabIndex = 6;
            this.gbAlcohol.TabStop = false;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 535);
            this.Controls.Add(this.gbAlcohol);
            this.Controls.Add(this.gbNonAlcohol);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAlcohol);
            this.Controls.Add(this.btnNonAlcohol);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbNonAlcohol.ResumeLayout(false);
            this.gbAlcohol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNonAlcohol;
        private System.Windows.Forms.Button btnAlcohol;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnSinaasappelsap;
        private System.Windows.Forms.Button btnTonic;
        private System.Windows.Forms.Button btnVodka;
        private System.Windows.Forms.Button btnMartini;
        private System.Windows.Forms.Button btnGin;
        private System.Windows.Forms.Button btnTequilla;
        private System.Windows.Forms.Button btnRum;
        private System.Windows.Forms.Button btnPerzik;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox gbNonAlcohol;
        private System.Windows.Forms.GroupBox gbAlcohol;
        private System.IO.Ports.SerialPort serialPort;
    }
}

