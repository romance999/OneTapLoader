namespace OneTapLoaderTemplate.UI
{
    partial class LoaderFrm
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
            this.topPnl = new System.Windows.Forms.Panel();
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.logo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.subLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uidLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rainbowCheckBox = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.injectBtn = new Siticone.UI.WinForms.SiticoneTileButton();
            this.rainbowTimer = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(98)))));
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(421, 10);
            this.topPnl.TabIndex = 1;
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(3, 13);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(251, 45);
            this.logo.TabIndex = 2;
            this.logo.Text = "loader template";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.subLbl);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.statusLbl);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.uidLbl);
            this.panel4.Controls.Add(this.usernameLbl);
            this.panel4.ForeColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(166, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 130);
            this.panel4.TabIndex = 21;
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.BackColor = System.Drawing.Color.Transparent;
            this.subLbl.ForeColor = System.Drawing.Color.White;
            this.subLbl.Location = new System.Drawing.Point(117, 87);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(27, 13);
            this.subLbl.TabIndex = 25;
            this.subLbl.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Subscription status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Uid:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.BackColor = System.Drawing.Color.Transparent;
            this.statusLbl.ForeColor = System.Drawing.Color.White;
            this.statusLbl.Location = new System.Drawing.Point(117, 58);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(27, 13);
            this.statusLbl.TabIndex = 23;
            this.statusLbl.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Account status:";
            // 
            // uidLbl
            // 
            this.uidLbl.AutoSize = true;
            this.uidLbl.BackColor = System.Drawing.Color.Transparent;
            this.uidLbl.ForeColor = System.Drawing.Color.White;
            this.uidLbl.Location = new System.Drawing.Point(117, 35);
            this.uidLbl.Name = "uidLbl";
            this.uidLbl.Size = new System.Drawing.Size(27, 13);
            this.uidLbl.TabIndex = 22;
            this.uidLbl.Text = "N/A";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(117, 9);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(27, 13);
            this.usernameLbl.TabIndex = 21;
            this.usernameLbl.Text = "N/A";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.rainbowCheckBox);
            this.panel8.ForeColor = System.Drawing.Color.Yellow;
            this.panel8.Location = new System.Drawing.Point(2, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 62);
            this.panel8.TabIndex = 22;
            // 
            // rainbowCheckBox
            // 
            this.rainbowCheckBox.AutoSize = true;
            this.rainbowCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.rainbowCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.rainbowCheckBox.CheckedState.BorderRadius = 0;
            this.rainbowCheckBox.CheckedState.BorderThickness = 0;
            this.rainbowCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.rainbowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rainbowCheckBox.ForeColor = System.Drawing.Color.White;
            this.rainbowCheckBox.Location = new System.Drawing.Point(8, 9);
            this.rainbowCheckBox.Name = "rainbowCheckBox";
            this.rainbowCheckBox.Size = new System.Drawing.Size(68, 17);
            this.rainbowCheckBox.TabIndex = 0;
            this.rainbowCheckBox.Text = "Rainbow";
            this.rainbowCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.rainbowCheckBox.UncheckedState.BorderRadius = 0;
            this.rainbowCheckBox.UncheckedState.BorderThickness = 0;
            this.rainbowCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.rainbowCheckBox.UseVisualStyleBackColor = false;
            this.rainbowCheckBox.CheckedChanged += new System.EventHandler(this.rainbowCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.injectBtn);
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(2, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 62);
            this.panel1.TabIndex = 23;
            // 
            // injectBtn
            // 
            this.injectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.injectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.injectBtn.CheckedState.Parent = this.injectBtn;
            this.injectBtn.CustomImages.Parent = this.injectBtn;
            this.injectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.injectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.injectBtn.ForeColor = System.Drawing.Color.White;
            this.injectBtn.HoveredState.Parent = this.injectBtn;
            this.injectBtn.Location = new System.Drawing.Point(9, 13);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.PressedColor = System.Drawing.Color.White;
            this.injectBtn.ShadowDecoration.Parent = this.injectBtn;
            this.injectBtn.Size = new System.Drawing.Size(136, 29);
            this.injectBtn.TabIndex = 24;
            this.injectBtn.Text = "Inject";
            // 
            // LoaderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(421, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.topPnl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoaderFrm";
            this.Load += new System.EventHandler(this.LoaderFrm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uidLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Panel panel8;
        private Siticone.UI.WinForms.SiticoneCheckBox rainbowCheckBox;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneTileButton injectBtn;
        private System.Windows.Forms.Timer rainbowTimer;
    }
}