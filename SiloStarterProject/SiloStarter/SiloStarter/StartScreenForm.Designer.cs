namespace SiloStarter
{
    partial class StartScreenForm
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
            this.loadStatusLabel = new System.Windows.Forms.Label();
            this.updateProgressBar = new System.Windows.Forms.ProgressBar();
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionAppLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.indicationLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.serverLabel = new System.Windows.Forms.Label();
            this.ftpServerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadStatusLabel
            // 
            this.loadStatusLabel.AutoSize = true;
            this.loadStatusLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loadStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.loadStatusLabel.Location = new System.Drawing.Point(35, 194);
            this.loadStatusLabel.Name = "loadStatusLabel";
            this.loadStatusLabel.Size = new System.Drawing.Size(140, 13);
            this.loadStatusLabel.TabIndex = 7;
            this.loadStatusLabel.Text = "Buscando actualizaciones...";
            this.loadStatusLabel.UseWaitCursor = true;
            // 
            // updateProgressBar
            // 
            this.updateProgressBar.Location = new System.Drawing.Point(43, 168);
            this.updateProgressBar.MarqueeAnimationSpeed = 50;
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(113, 23);
            this.updateProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.updateProgressBar.TabIndex = 6;
            this.updateProgressBar.UseWaitCursor = true;
            this.updateProgressBar.Value = 50;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(40, 148);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(116, 17);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Actualizando...";
            this.titleLabel.UseWaitCursor = true;
            // 
            // versionAppLabel
            // 
            this.versionAppLabel.AutoSize = true;
            this.versionAppLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.versionAppLabel.ForeColor = System.Drawing.Color.Black;
            this.versionAppLabel.Location = new System.Drawing.Point(287, -1);
            this.versionAppLabel.Name = "versionAppLabel";
            this.versionAppLabel.Size = new System.Drawing.Size(49, 13);
            this.versionAppLabel.TabIndex = 4;
            this.versionAppLabel.Text = "v 0.1.1.1";
            this.versionAppLabel.UseWaitCursor = true;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Silver;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(8, 98);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(181, 35);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Buscar Actualizaciones";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(79, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(141, 13);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Bienvenido al MB Launcher ";
            this.welcomeLabel.UseWaitCursor = true;
            // 
            // indicationLabel
            // 
            this.indicationLabel.AutoSize = true;
            this.indicationLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.indicationLabel.ForeColor = System.Drawing.Color.Black;
            this.indicationLabel.Location = new System.Drawing.Point(0, 21);
            this.indicationLabel.Name = "indicationLabel";
            this.indicationLabel.Size = new System.Drawing.Size(291, 13);
            this.indicationLabel.TabIndex = 10;
            this.indicationLabel.Text = "Por favor autorice la aplicación para buscar actualizaciones.";
            this.indicationLabel.UseWaitCursor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.BackColor = System.Drawing.Color.White;
            this.serverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.Location = new System.Drawing.Point(12, 46);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(28, 9);
            this.serverLabel.TabIndex = 11;
            this.serverLabel.Text = "Server";
            // 
            // ftpServerLabel
            // 
            this.ftpServerLabel.AutoSize = true;
            this.ftpServerLabel.BackColor = System.Drawing.Color.White;
            this.ftpServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpServerLabel.Location = new System.Drawing.Point(12, 55);
            this.ftpServerLabel.Name = "ftpServerLabel";
            this.ftpServerLabel.Size = new System.Drawing.Size(35, 9);
            this.ftpServerLabel.TabIndex = 12;
            this.ftpServerLabel.Text = "Updating";
            // 
            // StartScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = global::SiloStarter.Properties.Resources.Sin_título_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 216);
            this.Controls.Add(this.ftpServerLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.indicationLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.loadStatusLabel);
            this.Controls.Add(this.updateProgressBar);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.versionAppLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreenForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartScreenForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label loadStatusLabel;
        private System.Windows.Forms.ProgressBar updateProgressBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label versionAppLabel;
        private System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.Label welcomeLabel;
        public System.Windows.Forms.Label indicationLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label ftpServerLabel;
    }
}