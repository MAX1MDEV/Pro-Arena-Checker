namespace Pro_Arena_Checker_ver._2.Forms
{
    partial class tools
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
            this.TopTitle = new System.Windows.Forms.Button();
            this.desktop = new System.Windows.Forms.Panel();
            this.tablicaProcessId = new System.Windows.Forms.DataGridView();
            this.desktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablicaProcessId)).BeginInit();
            this.SuspendLayout();
            // 
            // TopTitle
            // 
            this.TopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.TopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTitle.FlatAppearance.BorderSize = 0;
            this.TopTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopTitle.ForeColor = System.Drawing.Color.White;
            this.TopTitle.Location = new System.Drawing.Point(0, 0);
            this.TopTitle.Name = "TopTitle";
            this.TopTitle.Size = new System.Drawing.Size(800, 45);
            this.TopTitle.TabIndex = 0;
            this.TopTitle.Text = "Заинжекченные DLL в процесс игры";
            this.TopTitle.UseVisualStyleBackColor = false;
            // 
            // desktop
            // 
            this.desktop.Controls.Add(this.tablicaProcessId);
            this.desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktop.Location = new System.Drawing.Point(0, 45);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(800, 405);
            this.desktop.TabIndex = 1;
            // 
            // tablicaProcessId
            // 
            this.tablicaProcessId.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.tablicaProcessId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablicaProcessId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablicaProcessId.Location = new System.Drawing.Point(0, 0);
            this.tablicaProcessId.Name = "tablicaProcessId";
            this.tablicaProcessId.RowHeadersWidth = 51;
            this.tablicaProcessId.RowTemplate.Height = 24;
            this.tablicaProcessId.Size = new System.Drawing.Size(800, 405);
            this.tablicaProcessId.TabIndex = 0;
            // 
            // tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desktop);
            this.Controls.Add(this.TopTitle);
            this.Name = "tools";
            this.Text = "toolscs";
            this.Load += new System.EventHandler(this.tools_Load);
            this.desktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablicaProcessId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TopTitle;
        private System.Windows.Forms.Panel desktop;
        private System.Windows.Forms.DataGridView tablicaProcessId;
    }
}