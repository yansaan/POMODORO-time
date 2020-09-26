namespace PomodoroTime
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
      this.StartBtn = new System.Windows.Forms.Button();
      this.MinLbl = new System.Windows.Forms.Label();
      this.SecLbl = new System.Windows.Forms.Label();
      this.TimeLbl = new System.Windows.Forms.Label();
      this.ResetBtn = new System.Windows.Forms.Button();
      this.SettingsBtn = new System.Windows.Forms.Button();
      this.Ambient = new System.Windows.Forms.CheckBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // StartBtn
      // 
      this.StartBtn.Location = new System.Drawing.Point(26, 78);
      this.StartBtn.Name = "StartBtn";
      this.StartBtn.Size = new System.Drawing.Size(46, 23);
      this.StartBtn.TabIndex = 0;
      this.StartBtn.Text = "Start";
      this.StartBtn.UseVisualStyleBackColor = true;
      this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
      // 
      // MinLbl
      // 
      this.MinLbl.AutoSize = true;
      this.MinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MinLbl.Location = new System.Drawing.Point(2, 4);
      this.MinLbl.Name = "MinLbl";
      this.MinLbl.Size = new System.Drawing.Size(106, 73);
      this.MinLbl.TabIndex = 1;
      this.MinLbl.Text = "00";
      // 
      // SecLbl
      // 
      this.SecLbl.AutoSize = true;
      this.SecLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SecLbl.Location = new System.Drawing.Point(91, 9);
      this.SecLbl.Name = "SecLbl";
      this.SecLbl.Size = new System.Drawing.Size(46, 31);
      this.SecLbl.TabIndex = 2;
      this.SecLbl.Text = "00";
      // 
      // TimeLbl
      // 
      this.TimeLbl.AutoSize = true;
      this.TimeLbl.Location = new System.Drawing.Point(168, 52);
      this.TimeLbl.Name = "TimeLbl";
      this.TimeLbl.Size = new System.Drawing.Size(46, 13);
      this.TimeLbl.TabIndex = 3;
      this.TimeLbl.Text = "Pashe 1";
      // 
      // ResetBtn
      // 
      this.ResetBtn.Location = new System.Drawing.Point(89, 78);
      this.ResetBtn.Name = "ResetBtn";
      this.ResetBtn.Size = new System.Drawing.Size(46, 23);
      this.ResetBtn.TabIndex = 4;
      this.ResetBtn.Text = "Reset";
      this.ResetBtn.UseVisualStyleBackColor = true;
      // 
      // SettingsBtn
      // 
      this.SettingsBtn.Location = new System.Drawing.Point(164, 9);
      this.SettingsBtn.Name = "SettingsBtn";
      this.SettingsBtn.Size = new System.Drawing.Size(53, 23);
      this.SettingsBtn.TabIndex = 5;
      this.SettingsBtn.Text = "Settings";
      this.SettingsBtn.UseVisualStyleBackColor = true;
      this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
      // 
      // Ambient
      // 
      this.Ambient.AutoSize = true;
      this.Ambient.Location = new System.Drawing.Point(158, 82);
      this.Ambient.Name = "Ambient";
      this.Ambient.Size = new System.Drawing.Size(64, 17);
      this.Ambient.TabIndex = 7;
      this.Ambient.Text = "Ambient";
      this.Ambient.UseVisualStyleBackColor = true;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // timer2
      // 
      this.timer2.Interval = 1000;
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.BalloonTipText = "Test";
      this.notifyIcon1.BalloonTipTitle = "Test";
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 119);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(231, 147);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Ambient);
      this.Controls.Add(this.ResetBtn);
      this.Controls.Add(this.StartBtn);
      this.Controls.Add(this.SettingsBtn);
      this.Controls.Add(this.TimeLbl);
      this.Controls.Add(this.SecLbl);
      this.Controls.Add(this.MinLbl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button StartBtn;
    private System.Windows.Forms.Label MinLbl;
    private System.Windows.Forms.Label SecLbl;
    private System.Windows.Forms.Label TimeLbl;
    private System.Windows.Forms.Button ResetBtn;
    private System.Windows.Forms.Button SettingsBtn;
    private System.Windows.Forms.CheckBox Ambient;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.Label label1;
  }
}

