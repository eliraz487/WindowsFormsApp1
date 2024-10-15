namespace WindowsFormsApp1
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
            this.txtNumBrowsers = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.labe1 = new System.Windows.Forms.Label();
            this.leabe21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNumBrowsers
            // 
            this.txtNumBrowsers.Location = new System.Drawing.Point(265, 91);
            this.txtNumBrowsers.Name = "txtNumBrowsers";
            this.txtNumBrowsers.Size = new System.Drawing.Size(225, 26);
            this.txtNumBrowsers.TabIndex = 1;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(265, 164);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(258, 26);
            this.txtUrl.TabIndex = 2;
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(142, 91);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(108, 20);
            this.labe1.TabIndex = 3;
            this.labe1.Text = "num browsers";
            // 
            // leabe21
            // 
            this.leabe21.AutoSize = true;
            this.leabe21.Location = new System.Drawing.Point(182, 167);
            this.leabe21.Name = "leabe21";
            this.leabe21.Size = new System.Drawing.Size(26, 20);
            this.leabe21.TabIndex = 4;
            this.leabe21.Text = "url";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.leabe21);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtNumBrowsers);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
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
    }
}

