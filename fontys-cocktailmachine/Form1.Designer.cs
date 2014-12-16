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
            this.btnBack = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnDone = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.lbDrinks = new System.Windows.Forms.ListBox();
            this.lbIngr = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(272, 89);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(212, 90);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Boozelicious";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnBack.Location = new System.Drawing.Point(549, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 66);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(9, 262);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Maximum = 150;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(496, 0);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(549, 210);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(130, 66);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // lbDrinks
            // 
            this.lbDrinks.BackColor = System.Drawing.SystemColors.Window;
            this.lbDrinks.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrinks.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDrinks.FormattingEnabled = true;
            this.lbDrinks.ItemHeight = 44;
            this.lbDrinks.Items.AddRange(new object[] {
            "[drank 1]",
            "[drank 2]",
            "[drank 3]",
            "[drank 4]",
            "[drank 5]",
            "[drank 6]"});
            this.lbDrinks.Location = new System.Drawing.Point(41, 11);
            this.lbDrinks.Margin = new System.Windows.Forms.Padding(2);
            this.lbDrinks.Name = "lbDrinks";
            this.lbDrinks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDrinks.ScrollAlwaysVisible = true;
            this.lbDrinks.Size = new System.Drawing.Size(270, 224);
            this.lbDrinks.TabIndex = 5;
            this.lbDrinks.SelectedIndexChanged += new System.EventHandler(this.lbDrinks_SelectedIndexChanged);
            // 
            // lbIngr
            // 
            this.lbIngr.BackColor = System.Drawing.SystemColors.Window;
            this.lbIngr.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbIngr.FormattingEnabled = true;
            this.lbIngr.ItemHeight = 44;
            this.lbIngr.Items.AddRange(new object[] {
            "[ingediënt 1]",
            "[ingediënt 2]",
            "[ingediënt 3]",
            "[ingediënt 4]",
            "[ingediënt 5]",
            "[ingediënt 6]"});
            this.lbIngr.Location = new System.Drawing.Point(292, 10);
            this.lbIngr.Margin = new System.Windows.Forms.Padding(2);
            this.lbIngr.Name = "lbIngr";
            this.lbIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIngr.ScrollAlwaysVisible = true;
            this.lbIngr.Size = new System.Drawing.Size(253, 224);
            this.lbIngr.TabIndex = 5;
            this.lbIngr.SelectedIndexChanged += new System.EventHandler(this.lbIngr_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(551, 82);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(134, 71);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 311);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbIngr);
            this.Controls.Add(this.lbDrinks);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnDone;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ListBox lbDrinks;
        private System.Windows.Forms.ListBox lbIngr;
        private System.Windows.Forms.Button btnSend;
    }
}

