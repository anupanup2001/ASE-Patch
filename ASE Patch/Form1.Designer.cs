namespace ASE_Patch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblASEStatus = new System.Windows.Forms.Label();
            this.lblIzzdrvStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Enabled = false;
            this.txtLog.Location = new System.Drawing.Point(118, 137);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(346, 182);
            this.txtLog.TabIndex = 0;
            this.txtLog.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIzzdrvStatus);
            this.groupBox1.Controls.Add(this.lblASEStatus);
            this.groupBox1.Location = new System.Drawing.Point(118, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Status";
            // 
            // lblASEStatus
            // 
            this.lblASEStatus.AutoSize = true;
            this.lblASEStatus.Location = new System.Drawing.Point(7, 30);
            this.lblASEStatus.Name = "lblASEStatus";
            this.lblASEStatus.Size = new System.Drawing.Size(35, 13);
            this.lblASEStatus.TabIndex = 0;
            this.lblASEStatus.Text = "label1";
            // 
            // lblIzzdrvStatus
            // 
            this.lblIzzdrvStatus.AutoSize = true;
            this.lblIzzdrvStatus.Location = new System.Drawing.Point(7, 61);
            this.lblIzzdrvStatus.Name = "lblIzzdrvStatus";
            this.lblIzzdrvStatus.Size = new System.Drawing.Size(35, 13);
            this.lblIzzdrvStatus.TabIndex = 1;
            this.lblIzzdrvStatus.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Patch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ASE Trial Patch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIzzdrvStatus;
        private System.Windows.Forms.Label lblASEStatus;
        private System.Windows.Forms.Button button1;
    }
}

