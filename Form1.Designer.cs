namespace KeyLooger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.hidebutton = new System.Windows.Forms.Button();
            this.keylooger_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            textbox_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startbutton.Location = new System.Drawing.Point(12, 226);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbutton.Location = new System.Drawing.Point(197, 226);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 1;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // hidebutton
            // 
            this.hidebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidebutton.Location = new System.Drawing.Point(105, 226);
            this.hidebutton.Name = "hidebutton";
            this.hidebutton.Size = new System.Drawing.Size(75, 23);
            this.hidebutton.TabIndex = 2;
            this.hidebutton.Text = "Hide";
            this.hidebutton.UseVisualStyleBackColor = true;
            this.hidebutton.Click += new System.EventHandler(this.hidebutton_Click);
            // 
            // keylooger_notifyIcon
            // 
            this.keylooger_notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.keylooger_notifyIcon.BalloonTipText = "KeyLooger Still Working";
            this.keylooger_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("keylooger_notifyIcon.Icon")));
            this.keylooger_notifyIcon.Text = "KeyLooger";
            this.keylooger_notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.keylooger_notifyIcon_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To KeyLogger";
            // 
            // textbox_log
            // 
            textbox_log.Location = new System.Drawing.Point(13, 37);
            textbox_log.Multiline = true;
            textbox_log.Name = "textbox_log";
            textbox_log.ReadOnly = true;
            textbox_log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textbox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textbox_log.Size = new System.Drawing.Size(259, 183);
            textbox_log.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(textbox_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hidebutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "KeyLooger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button hidebutton;
        private System.Windows.Forms.NotifyIcon keylooger_notifyIcon;
        private System.Windows.Forms.Label label1;
        public static System.Windows.Forms.TextBox textbox_log;
    }
}

