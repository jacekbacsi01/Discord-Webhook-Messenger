namespace COMDROID_DISCORD_WEBHOOK_MANAGER
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butAbout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxCustomUsrNm = new System.Windows.Forms.CheckBox();
            this.butSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsrName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(91, 12);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(295, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(91, 35);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(295, 20);
            this.textBoxMsg.TabIndex = 2;
            this.textBoxMsg.Text = "Helló Világ!";
            // 
            // textBoxResp
            // 
            this.textBoxResp.Location = new System.Drawing.Point(91, 61);
            this.textBoxResp.Multiline = true;
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.ReadOnly = true;
            this.textBoxResp.Size = new System.Drawing.Size(295, 41);
            this.textBoxResp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Üzenet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "JSON Válasz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discord Webhook Messenger v0.2 by Alex Hegedűs(jacekbacsi01)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butAbout);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkBoxCustomUsrNm);
            this.groupBox1.Controls.Add(this.butSend);
            this.groupBox1.Location = new System.Drawing.Point(392, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 159);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciók";
            // 
            // butAbout
            // 
            this.butAbout.Location = new System.Drawing.Point(279, 12);
            this.butAbout.Name = "butAbout";
            this.butAbout.Size = new System.Drawing.Size(25, 23);
            this.butAbout.TabIndex = 11;
            this.butAbout.Text = "?";
            this.butAbout.UseVisualStyleBackColor = true;
            this.butAbout.Click += new System.EventHandler(this.butAbout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Discord logos and products, trademarks owned by Discord Inc.";
            // 
            // checkBoxCustomUsrNm
            // 
            this.checkBoxCustomUsrNm.AutoSize = true;
            this.checkBoxCustomUsrNm.Location = new System.Drawing.Point(6, 16);
            this.checkBoxCustomUsrNm.Name = "checkBoxCustomUsrNm";
            this.checkBoxCustomUsrNm.Size = new System.Drawing.Size(257, 17);
            this.checkBoxCustomUsrNm.TabIndex = 1;
            this.checkBoxCustomUsrNm.Text = "Egyedi felhasználónév használata, URL mentése";
            this.checkBoxCustomUsrNm.UseVisualStyleBackColor = true;
            this.checkBoxCustomUsrNm.CheckedChanged += new System.EventHandler(this.checkBoxCustomUsrNm_CheckedChanged);
            // 
            // butSend
            // 
            this.butSend.BackgroundImage = global::COMDROID_DISCORD_WEBHOOK_MANAGER_BY_ALEXHEGEDUS.Properties.Resources.discord_send_img;
            this.butSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butSend.Location = new System.Drawing.Point(6, 42);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(298, 98);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "Küldés";
            this.butSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Felhasználónév:";
            // 
            // textBoxUsrName
            // 
            this.textBoxUsrName.Location = new System.Drawing.Point(91, 108);
            this.textBoxUsrName.Name = "textBoxUsrName";
            this.textBoxUsrName.ReadOnly = true;
            this.textBoxUsrName.Size = new System.Drawing.Size(295, 20);
            this.textBoxUsrName.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 166);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUsrName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.textBoxURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Discord Webhook Messenger v0.2 by Alex Hegedűs (C# .NET 4.7.2)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.TextBox textBoxResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxCustomUsrNm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsrName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butAbout;
    }
}

