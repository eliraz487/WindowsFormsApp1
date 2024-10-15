namespace WindowsFormsApp1
{
    partial class DDoSAttack
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
            this.txtNumBrowsers = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.labe1 = new System.Windows.Forms.Label();
            this.leabe21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "start DDos Atack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNumBrowsers
            // 
            this.txtNumBrowsers.Location = new System.Drawing.Point(141, 24);
            this.txtNumBrowsers.Name = "txtNumBrowsers";
            this.txtNumBrowsers.Size = new System.Drawing.Size(41, 26);
            this.txtNumBrowsers.TabIndex = 1;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(141, 63);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(258, 26);
            this.txtUrl.TabIndex = 2;
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(36, 27);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(87, 20);
            this.labe1.TabIndex = 3;
            this.labe1.Text = "Attack with";
            this.labe1.Click += new System.EventHandler(this.labe1_Click);
            // 
            // leabe21
            // 
            this.leabe21.AutoSize = true;
            this.leabe21.Location = new System.Drawing.Point(36, 66);
            this.leabe21.Name = "leabe21";
            this.leabe21.Size = new System.Drawing.Size(86, 20);
            this.leabe21.TabIndex = 4;
            this.leabe21.Text = "Target URl";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(359, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "browsers";
            // 
            // DDoSAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.leabe21);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtNumBrowsers);
            this.Controls.Add(this.button1);
            this.Name = "DDoSAttack";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumBrowsers;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label leabe21;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

