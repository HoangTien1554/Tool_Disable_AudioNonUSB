namespace Tool_Disable_AudioNonUSB
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
            this.btn_Apply = new System.Windows.Forms.Button();
            this.chk_Audio = new System.Windows.Forms.CheckBox();
            this.chk_MaxVolume = new System.Windows.Forms.CheckBox();
            this.lab_SecureBoot = new System.Windows.Forms.Label();
            this.lab_TPM = new System.Windows.Forms.Label();
            this.lab_HVCI = new System.Windows.Forms.Label();
            this.btn_HDSecureboot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Apply
            // 
            this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.82178F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apply.Location = new System.Drawing.Point(137, 358);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(187, 50);
            this.btn_Apply.TabIndex = 1;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // chk_Audio
            // 
            this.chk_Audio.AutoSize = true;
            this.chk_Audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Audio.Location = new System.Drawing.Point(88, 63);
            this.chk_Audio.Name = "chk_Audio";
            this.chk_Audio.Size = new System.Drawing.Size(164, 29);
            this.chk_Audio.TabIndex = 2;
            this.chk_Audio.Text = "Disable Audio";
            this.chk_Audio.UseVisualStyleBackColor = true;
            this.chk_Audio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_MaxVolume
            // 
            this.chk_MaxVolume.AutoSize = true;
            this.chk_MaxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_MaxVolume.Location = new System.Drawing.Point(88, 101);
            this.chk_MaxVolume.Name = "chk_MaxVolume";
            this.chk_MaxVolume.Size = new System.Drawing.Size(150, 29);
            this.chk_MaxVolume.TabIndex = 2;
            this.chk_MaxVolume.Text = "Max Volume";
            this.chk_MaxVolume.UseVisualStyleBackColor = true;
            // 
            // lab_SecureBoot
            // 
            this.lab_SecureBoot.AutoSize = true;
            this.lab_SecureBoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SecureBoot.Location = new System.Drawing.Point(88, 142);
            this.lab_SecureBoot.Name = "lab_SecureBoot";
            this.lab_SecureBoot.Size = new System.Drawing.Size(136, 25);
            this.lab_SecureBoot.TabIndex = 3;
            this.lab_SecureBoot.Text = "SecureBoot: ";
            this.lab_SecureBoot.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_TPM
            // 
            this.lab_TPM.AutoSize = true;
            this.lab_TPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TPM.Location = new System.Drawing.Point(88, 180);
            this.lab_TPM.Name = "lab_TPM";
            this.lab_TPM.Size = new System.Drawing.Size(69, 25);
            this.lab_TPM.TabIndex = 3;
            this.lab_TPM.Text = "TPM: ";
            this.lab_TPM.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_HVCI
            // 
            this.lab_HVCI.AutoSize = true;
            this.lab_HVCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_HVCI.Location = new System.Drawing.Point(88, 222);
            this.lab_HVCI.Name = "lab_HVCI";
            this.lab_HVCI.Size = new System.Drawing.Size(73, 25);
            this.lab_HVCI.TabIndex = 3;
            this.lab_HVCI.Text = "HVCI: ";
            this.lab_HVCI.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_HDSecureboot
            // 
            this.btn_HDSecureboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HDSecureboot.Location = new System.Drawing.Point(305, 149);
            this.btn_HDSecureboot.Name = "btn_HDSecureboot";
            this.btn_HDSecureboot.Size = new System.Drawing.Size(115, 90);
            this.btn_HDSecureboot.TabIndex = 4;
            this.btn_HDSecureboot.Text = "Hướng dẫn bật, tắt";
            this.btn_HDSecureboot.UseVisualStyleBackColor = true;
            this.btn_HDSecureboot.Click += new System.EventHandler(this.btn_HDSecureboot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btn_HDSecureboot);
            this.Controls.Add(this.lab_HVCI);
            this.Controls.Add(this.lab_TPM);
            this.Controls.Add(this.lab_SecureBoot);
            this.Controls.Add(this.chk_MaxVolume);
            this.Controls.Add(this.chk_Audio);
            this.Controls.Add(this.btn_Apply);
            this.Name = "Form1";
            this.Text = "lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.CheckBox chk_Audio;
        private System.Windows.Forms.CheckBox chk_MaxVolume;
        private System.Windows.Forms.Label lab_SecureBoot;
        private System.Windows.Forms.Label lab_TPM;
        private System.Windows.Forms.Label lab_HVCI;
        private System.Windows.Forms.Button btn_HDSecureboot;
    }
}

