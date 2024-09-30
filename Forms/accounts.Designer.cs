namespace Pro_Arena_Checker_ver._2.Forms
{
    partial class accounts
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
            this.btnAcc = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // btnAcc
            // 
            this.btnAcc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAcc.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAcc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAcc.BorderRadius = 50;
            this.btnAcc.BorderSize = 0;
            this.btnAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcc.FlatAppearance.BorderSize = 0;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.ForeColor = System.Drawing.Color.White;
            this.btnAcc.Location = new System.Drawing.Point(127, 94);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(575, 259);
            this.btnAcc.TabIndex = 19;
            this.btnAcc.Text = "Аккаунты";
            this.btnAcc.TextColor = System.Drawing.Color.White;
            this.btnAcc.UseVisualStyleBackColor = false;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.btnAcc);
            this.Name = "accounts";
            this.Text = "accounts";
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnAcc;
    }
}