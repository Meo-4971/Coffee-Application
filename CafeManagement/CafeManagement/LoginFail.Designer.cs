
namespace CafeManagement
{
    partial class LoginFail
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
            this.pgbHanCho = new System.Windows.Forms.ProgressBar();
            this.lblDemLui = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbHanCho
            // 
            this.pgbHanCho.BackColor = System.Drawing.Color.Linen;
            this.pgbHanCho.Location = new System.Drawing.Point(56, 19);
            this.pgbHanCho.Name = "pgbHanCho";
            this.pgbHanCho.Size = new System.Drawing.Size(206, 20);
            this.pgbHanCho.TabIndex = 0;
            // 
            // lblDemLui
            // 
            this.lblDemLui.AutoSize = true;
            this.lblDemLui.Location = new System.Drawing.Point(22, 55);
            this.lblDemLui.Name = "lblDemLui";
            this.lblDemLui.Size = new System.Drawing.Size(0, 17);
            this.lblDemLui.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(321, 110);
            this.Controls.Add(this.lblDemLui);
            this.Controls.Add(this.pgbHanCho);
            this.Name = "LoginFail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hạn chờ";
            this.Load += new System.EventHandler(this.LoginFail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbHanCho;
        private System.Windows.Forms.Label lblDemLui;
        private System.Windows.Forms.Timer timer1;
    }
}