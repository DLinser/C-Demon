namespace StartWithBootServices
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.UninstallServiceBtn = new System.Windows.Forms.Button();
            this.StopServiceBtn = new System.Windows.Forms.Button();
            this.StartServiceBtn = new System.Windows.Forms.Button();
            this.RegisterServiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UninstallServiceBtn
            // 
            this.UninstallServiceBtn.BackgroundImage = global::StartWithBootServices.Properties.Resources.button1;
            this.UninstallServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UninstallServiceBtn.Location = new System.Drawing.Point(379, 237);
            this.UninstallServiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UninstallServiceBtn.Name = "UninstallServiceBtn";
            this.UninstallServiceBtn.Size = new System.Drawing.Size(133, 41);
            this.UninstallServiceBtn.TabIndex = 11;
            this.UninstallServiceBtn.Text = "卸载服务";
            this.UninstallServiceBtn.UseVisualStyleBackColor = true;
            this.UninstallServiceBtn.Click += new System.EventHandler(this.UninstallServiceBtn_Click);
            // 
            // StopServiceBtn
            // 
            this.StopServiceBtn.BackgroundImage = global::StartWithBootServices.Properties.Resources.button2;
            this.StopServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopServiceBtn.Location = new System.Drawing.Point(134, 237);
            this.StopServiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StopServiceBtn.Name = "StopServiceBtn";
            this.StopServiceBtn.Size = new System.Drawing.Size(133, 41);
            this.StopServiceBtn.TabIndex = 10;
            this.StopServiceBtn.Text = "暂停服务";
            this.StopServiceBtn.UseVisualStyleBackColor = true;
            this.StopServiceBtn.Click += new System.EventHandler(this.StopServiceBtn_Click);
            // 
            // StartServiceBtn
            // 
            this.StartServiceBtn.BackgroundImage = global::StartWithBootServices.Properties.Resources.button2;
            this.StartServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartServiceBtn.Location = new System.Drawing.Point(379, 123);
            this.StartServiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartServiceBtn.Name = "StartServiceBtn";
            this.StartServiceBtn.Size = new System.Drawing.Size(133, 41);
            this.StartServiceBtn.TabIndex = 9;
            this.StartServiceBtn.Text = "启动服务";
            this.StartServiceBtn.UseVisualStyleBackColor = true;
            this.StartServiceBtn.Click += new System.EventHandler(this.StartServiceBtn_Click);
            // 
            // RegisterServiceBtn
            // 
            this.RegisterServiceBtn.BackgroundImage = global::StartWithBootServices.Properties.Resources.button1;
            this.RegisterServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterServiceBtn.Location = new System.Drawing.Point(134, 123);
            this.RegisterServiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterServiceBtn.Name = "RegisterServiceBtn";
            this.RegisterServiceBtn.Size = new System.Drawing.Size(133, 41);
            this.RegisterServiceBtn.TabIndex = 8;
            this.RegisterServiceBtn.Text = "注册服务";
            this.RegisterServiceBtn.UseVisualStyleBackColor = true;
            this.RegisterServiceBtn.Click += new System.EventHandler(this.RegisterServiceBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StartWithBootServices.Properties.Resources.show;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 359);
            this.Controls.Add(this.UninstallServiceBtn);
            this.Controls.Add(this.StopServiceBtn);
            this.Controls.Add(this.StartServiceBtn);
            this.Controls.Add(this.RegisterServiceBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "开机自启服务";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UninstallServiceBtn;
        private System.Windows.Forms.Button StopServiceBtn;
        private System.Windows.Forms.Button StartServiceBtn;
        private System.Windows.Forms.Button RegisterServiceBtn;
    }
}