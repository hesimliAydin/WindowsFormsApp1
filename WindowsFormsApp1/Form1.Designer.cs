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
            this.titleLbl = new System.Windows.Forms.Label();
            this.clickBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(22, 24);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(581, 99);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Welcome to App";
            this.titleLbl.Click += new System.EventHandler(this.label1_Click);
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseDown);
            this.titleLbl.MouseEnter += new System.EventHandler(this.titleLbl_MouseEnter);
            this.titleLbl.MouseLeave += new System.EventHandler(this.titleLbl_MouseLeave);
            this.titleLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseUp);
            // 
            // clickBtn
            // 
            this.clickBtn.BackColor = System.Drawing.Color.IndianRed;
            this.clickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickBtn.Location = new System.Drawing.Point(555, 340);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(149, 52);
            this.clickBtn.TabIndex = 1;
            this.clickBtn.Text = "Click Me";
            this.clickBtn.UseVisualStyleBackColor = false;
            this.clickBtn.Click += new System.EventHandler(this.clickBtn_Click);
            this.clickBtn.MouseEnter += new System.EventHandler(this.clickBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.clickBtn);
            this.Controls.Add(this.titleLbl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My App";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button clickBtn;
    }
}

