namespace Pro_Arena_Checker_ver._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSide = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconbtnProverka = new FontAwesome.Sharp.IconButton();
            this.iconbtnTools = new FontAwesome.Sharp.IconButton();
            this.iconbtnPrograms = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.panelSide.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(100)))), ((int)(((byte)(197)))));
            this.panelSide.Controls.Add(this.iconButton3);
            this.panelSide.Controls.Add(this.iconButton1);
            this.panelSide.Controls.Add(this.iconButton8);
            this.panelSide.Controls.Add(this.iconbtnProverka);
            this.panelSide.Controls.Add(this.iconbtnTools);
            this.panelSide.Controls.Add(this.iconbtnPrograms);
            this.panelSide.Controls.Add(this.panelTitle);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(316, 553);
            this.panelSide.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 299);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(316, 52);
            this.iconButton3.TabIndex = 11;
            this.iconButton3.Tag = "Информация";
            this.iconButton3.Text = "    Информация";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconbtnInfo_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 247);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(316, 52);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Tag = "Аккаунты";
            this.iconButton1.Text = "    Аккаунты";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton8.ForeColor = System.Drawing.Color.White;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton8.IconColor = System.Drawing.Color.White;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(0, 501);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 8);
            this.iconButton8.Size = new System.Drawing.Size(316, 52);
            this.iconButton8.TabIndex = 7;
            this.iconButton8.Tag = "Выход";
            this.iconButton8.Text = "    Выход";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconbtnProverka
            // 
            this.iconbtnProverka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnProverka.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnProverka.FlatAppearance.BorderSize = 0;
            this.iconbtnProverka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnProverka.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold);
            this.iconbtnProverka.ForeColor = System.Drawing.Color.White;
            this.iconbtnProverka.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconbtnProverka.IconColor = System.Drawing.Color.White;
            this.iconbtnProverka.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnProverka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnProverka.Location = new System.Drawing.Point(0, 195);
            this.iconbtnProverka.Name = "iconbtnProverka";
            this.iconbtnProverka.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnProverka.Size = new System.Drawing.Size(316, 52);
            this.iconbtnProverka.TabIndex = 2;
            this.iconbtnProverka.Tag = "Папки";
            this.iconbtnProverka.Text = "    Папки";
            this.iconbtnProverka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnProverka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnProverka.UseVisualStyleBackColor = true;
            this.iconbtnProverka.Click += new System.EventHandler(this.iconbtnProverka_Click);
            // 
            // iconbtnTools
            // 
            this.iconbtnTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnTools.FlatAppearance.BorderSize = 0;
            this.iconbtnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnTools.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconbtnTools.ForeColor = System.Drawing.Color.White;
            this.iconbtnTools.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconbtnTools.IconColor = System.Drawing.Color.White;
            this.iconbtnTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnTools.Location = new System.Drawing.Point(0, 143);
            this.iconbtnTools.Name = "iconbtnTools";
            this.iconbtnTools.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnTools.Size = new System.Drawing.Size(316, 52);
            this.iconbtnTools.TabIndex = 5;
            this.iconbtnTools.Tag = "DLL Checker";
            this.iconbtnTools.Text = "   DLL Checker";
            this.iconbtnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnTools.UseVisualStyleBackColor = true;
            this.iconbtnTools.Click += new System.EventHandler(this.iconbtnTools_Click);
            // 
            // iconbtnPrograms
            // 
            this.iconbtnPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnPrograms.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconbtnPrograms.FlatAppearance.BorderSize = 0;
            this.iconbtnPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnPrograms.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnPrograms.ForeColor = System.Drawing.Color.White;
            this.iconbtnPrograms.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.iconbtnPrograms.IconColor = System.Drawing.Color.White;
            this.iconbtnPrograms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnPrograms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnPrograms.Location = new System.Drawing.Point(0, 91);
            this.iconbtnPrograms.Name = "iconbtnPrograms";
            this.iconbtnPrograms.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconbtnPrograms.Size = new System.Drawing.Size(316, 52);
            this.iconbtnPrograms.TabIndex = 3;
            this.iconbtnPrograms.Tag = "Программы";
            this.iconbtnPrograms.Text = "    Программы";
            this.iconbtnPrograms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnPrograms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnPrograms.UseVisualStyleBackColor = true;
            this.iconbtnPrograms.Click += new System.EventHandler(this.iconbtnPrograms_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.btnMenu);
            this.panelTitle.Controls.Add(this.pictureTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(316, 91);
            this.panelTitle.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(100)))), ((int)(((byte)(197)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(256, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureTitle
            // 
            this.pictureTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(100)))), ((int)(((byte)(197)))));
            this.pictureTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureTitle.Image")));
            this.pictureTitle.Location = new System.Drawing.Point(0, 0);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(316, 90);
            this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureTitle.TabIndex = 0;
            this.pictureTitle.TabStop = false;
            this.pictureTitle.Click += new System.EventHandler(this.pictureTitle_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(870, 48);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(45, 15);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(87, 24);
            this.lblTitleChildForm.TabIndex = 6;
            this.lblTitleChildForm.Text = "Главная";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 7);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 5;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMin.IconSize = 20;
            this.btnMin.Location = new System.Drawing.Point(780, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnMin.Size = new System.Drawing.Size(45, 25);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(825, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(141)))), ((int)(((byte)(247)))));
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Controls.Add(this.pictureHome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(316, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(870, 553);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureHome
            // 
            this.pictureHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(214, 206);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(473, 189);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHome.TabIndex = 2;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1186, 553);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSide.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconbtnTools;
        private FontAwesome.Sharp.IconButton iconbtnPrograms;
        private FontAwesome.Sharp.IconButton iconbtnProverka;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMin;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox pictureHome;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}

