namespace project
{
    partial class Apply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apply));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_FileName = new System.Windows.Forms.TextBox();
            this.FormApply_bt_SendCV = new System.Windows.Forms.Button();
            this.FormApply_bt_ChooseFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TenCongViec = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_FileName);
            this.panel1.Controls.Add(this.FormApply_bt_SendCV);
            this.panel1.Controls.Add(this.FormApply_bt_ChooseFile);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_TenCongViec);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 294);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(193, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 6;
            // 
            // lb_FileName
            // 
            this.lb_FileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_FileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FileName.Location = new System.Drawing.Point(163, 191);
            this.lb_FileName.Multiline = true;
            this.lb_FileName.Name = "lb_FileName";
            this.lb_FileName.Size = new System.Drawing.Size(319, 20);
            this.lb_FileName.TabIndex = 5;
            this.lb_FileName.Text = "No file chosen";
            // 
            // FormApply_bt_SendCV
            // 
            this.FormApply_bt_SendCV.BackColor = System.Drawing.Color.Firebrick;
            this.FormApply_bt_SendCV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormApply_bt_SendCV.Location = new System.Drawing.Point(39, 233);
            this.FormApply_bt_SendCV.Name = "FormApply_bt_SendCV";
            this.FormApply_bt_SendCV.Size = new System.Drawing.Size(567, 44);
            this.FormApply_bt_SendCV.TabIndex = 4;
            this.FormApply_bt_SendCV.Text = "Apply";
            this.FormApply_bt_SendCV.UseVisualStyleBackColor = false;
            this.FormApply_bt_SendCV.Click += new System.EventHandler(this.FormApply_bt_SendCV_Click);
            // 
            // FormApply_bt_ChooseFile
            // 
            this.FormApply_bt_ChooseFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormApply_bt_ChooseFile.Location = new System.Drawing.Point(163, 155);
            this.FormApply_bt_ChooseFile.Name = "FormApply_bt_ChooseFile";
            this.FormApply_bt_ChooseFile.Size = new System.Drawing.Size(162, 30);
            this.FormApply_bt_ChooseFile.TabIndex = 4;
            this.FormApply_bt_ChooseFile.Text = "Choose File(*.pdf)";
            this.FormApply_bt_ChooseFile.UseVisualStyleBackColor = true;
            this.FormApply_bt_ChooseFile.Click += new System.EventHandler(this.FormApply_bt_ChooseFile_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Location = new System.Drawing.Point(163, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 33);
            this.panel3.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(15, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(421, 22);
            this.txt_email.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_Name);
            this.panel2.Location = new System.Drawing.Point(163, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 33);
            this.panel2.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(15, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(421, 22);
            this.txt_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Your CV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your name:";
            // 
            // lb_TenCongViec
            // 
            this.lb_TenCongViec.AutoSize = true;
            this.lb_TenCongViec.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenCongViec.Location = new System.Drawing.Point(34, 6);
            this.lb_TenCongViec.Margin = new System.Windows.Forms.Padding(6);
            this.lb_TenCongViec.Name = "lb_TenCongViec";
            this.lb_TenCongViec.Size = new System.Drawing.Size(546, 30);
            this.lb_TenCongViec.TabIndex = 0;
            this.lb_TenCongViec.Text = "Senior Backend Developer (Java) at One Mount Group";
            this.lb_TenCongViec.Click += new System.EventHandler(this.lb_TenCongViec_Click);
            // 
            // Apply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 313);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply";
            this.Load += new System.EventHandler(this.Apply_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FormApply_bt_SendCV;
        private System.Windows.Forms.Button FormApply_bt_ChooseFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_TenCongViec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lb_FileName;
    }
}