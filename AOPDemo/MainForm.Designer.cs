
namespace AOPDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userName_tsLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.permisson_tsLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.logIn_tsbtn = new System.Windows.Forms.ToolStripSplitButton();
            this.func_btn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.userName_tsLab,
            this.toolStripStatusLabel3,
            this.permisson_tsLab,
            this.logIn_tsbtn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(831, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 18);
            this.toolStripStatusLabel1.Text = "用户名：";
            // 
            // userName_tsLab
            // 
            this.userName_tsLab.Name = "userName_tsLab";
            this.userName_tsLab.Size = new System.Drawing.Size(104, 18);
            this.userName_tsLab.Text = "                        ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 18);
            this.toolStripStatusLabel3.Text = "权限：";
            // 
            // permisson_tsLab
            // 
            this.permisson_tsLab.Name = "permisson_tsLab";
            this.permisson_tsLab.Size = new System.Drawing.Size(84, 18);
            this.permisson_tsLab.Text = "                   ";
            // 
            // logIn_tsbtn
            // 
            this.logIn_tsbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.logIn_tsbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logIn_tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("logIn_tsbtn.Image")));
            this.logIn_tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logIn_tsbtn.Name = "logIn_tsbtn";
            this.logIn_tsbtn.Size = new System.Drawing.Size(48, 21);
            this.logIn_tsbtn.Text = "登录";
            this.logIn_tsbtn.Click += new System.EventHandler(this.LogIn);
            // 
            // func_btn
            // 
            this.func_btn.Location = new System.Drawing.Point(329, 130);
            this.func_btn.Name = "func_btn";
            this.func_btn.Size = new System.Drawing.Size(75, 23);
            this.func_btn.TabIndex = 1;
            this.func_btn.Text = "关键功能";
            this.func_btn.UseVisualStyleBackColor = true;
            this.func_btn.Click += new System.EventHandler(this.Func_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 520);
            this.Controls.Add(this.func_btn);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "用户管理功能测试AOP框架";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel userName_tsLab;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel permisson_tsLab;
        private System.Windows.Forms.ToolStripSplitButton logIn_tsbtn;
        private System.Windows.Forms.Button func_btn;
    }
}

