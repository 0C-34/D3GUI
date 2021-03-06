﻿namespace D3_Classicube_Gui {
    partial class MiniForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniForm));
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMotd = new System.Windows.Forms.Label();
            this.lblPublic = new System.Windows.Forms.Label();
            this.lblVerify = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblHeartbeat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Server Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOTD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Public Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Verify Names:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Players Online:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Heartbeat:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return to Full Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(93, 9);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "label6";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMotd
            // 
            this.lblMotd.AutoSize = true;
            this.lblMotd.Location = new System.Drawing.Point(93, 22);
            this.lblMotd.Name = "lblMotd";
            this.lblMotd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMotd.Size = new System.Drawing.Size(35, 13);
            this.lblMotd.TabIndex = 8;
            this.lblMotd.Text = "label6";
            this.lblMotd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.Location = new System.Drawing.Point(90, 59);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPublic.Size = new System.Drawing.Size(35, 13);
            this.lblPublic.TabIndex = 9;
            this.lblPublic.Text = "label6";
            this.lblPublic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Location = new System.Drawing.Point(90, 72);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVerify.Size = new System.Drawing.Size(35, 13);
            this.lblVerify.TabIndex = 10;
            this.lblVerify.Text = "label6";
            this.lblVerify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Location = new System.Drawing.Point(90, 85);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOnline.Size = new System.Drawing.Size(35, 13);
            this.lblOnline.TabIndex = 11;
            this.lblOnline.Text = "label6";
            this.lblOnline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeartbeat
            // 
            this.lblHeartbeat.AutoSize = true;
            this.lblHeartbeat.Location = new System.Drawing.Point(90, 98);
            this.lblHeartbeat.Name = "lblHeartbeat";
            this.lblHeartbeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeartbeat.Size = new System.Drawing.Size(35, 13);
            this.lblHeartbeat.TabIndex = 12;
            this.lblHeartbeat.Text = "label6";
            this.lblHeartbeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // miniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 145);
            this.ControlBox = false;
            this.Controls.Add(this.lblHeartbeat);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.lblPublic);
            this.Controls.Add(this.lblMotd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiniForm";
            this.Text = "Minecraft Server";
            this.Load += new System.EventHandler(this.miniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblMotd;
        public System.Windows.Forms.Label lblPublic;
        public System.Windows.Forms.Label lblVerify;
        public System.Windows.Forms.Label lblOnline;
        public System.Windows.Forms.Label lblHeartbeat;
    }
}