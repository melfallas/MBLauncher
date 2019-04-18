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
            this.loadStatusLabel = new System.Windows.Forms.Label();
            this.updateProgressBar = new System.Windows.Forms.ProgressBar();
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionAppLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.indicationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadStatusLabel
            // 
            this.loadStatusLabel.AutoSize = true;
            this.loadStatusLabel.ForeColor = System.Drawing.Color.White;
            this.loadStatusLabel.Location = new System.Drawing.Point(103, 165);
            this.loadStatusLabel.Name = "loadStatusLabel";
            this.loadStatusLabel.Size = new System.Drawing.Size(140, 13);
            this.loadStatusLabel.TabIndex = 7;
            this.loadStatusLabel.Text = "Buscando actualizaciones...";
            this.loadStatusLabel.UseWaitCursor = true;
            // 
            // updateProgressBar
            // 
            this.updateProgressBar.Location = new System.Drawing.Point(116, 139);
            this.updateProgressBar.MarqueeAnimationSpeed = 50;
            this.updateProgressBar.Name = "updateProgressBar";
            this.updateProgressBar.Size = new System.Drawing.Size(104, 23);
            this.updateProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.updateProgressBar.TabIndex = 6;
            this.updateProgressBar.UseWaitCursor = true;
            this.updateProgressBar.Value = 10;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(96, 111);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(155, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Actualizando...";
            this.titleLabel.UseWaitCursor = true;
            // 
            // versionAppLabel
            // 
            this.versionAppLabel.AutoSize = true;
            this.versionAppLabel.ForeColor = System.Drawing.Color.White;
            this.versionAppLabel.Location = new System.Drawing.Point(262, 9);
            this.versionAppLabel.Name = "versionAppLabel";
            this.versionAppLabel.Size = new System.Drawing.Size(55, 13);
            this.versionAppLabel.TabIndex = 4;
            this.versionAppLabel.Text = "v 0.1.1.10";
            this.versionAppLabel.UseWaitCursor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(116, 46);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 39);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Buscar Actualizaciones";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(101, 88);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(141, 13);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Bienvenido al MB Launcher ";
            this.welcomeLabel.UseWaitCursor = true;
            // 
            // indicationLabel
            // 
            this.indicationLabel.AutoSize = true;
            this.indicationLabel.ForeColor = System.Drawing.Color.White;
            this.indicationLabel.Location = new System.Drawing.Point(20, 101);
            this.indicationLabel.Name = "indicationLabel";
            this.indicationLabel.Size = new System.Drawing.Size(291, 13);
            this.indicationLabel.TabIndex = 10;
            this.indicationLabel.Text = "Por favor autorice la aplicación para buscar actualizaciones.";
            this.indicationLabel.UseWaitCursor = true;
            // 
            // StartScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(336, 216);
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
    }
}