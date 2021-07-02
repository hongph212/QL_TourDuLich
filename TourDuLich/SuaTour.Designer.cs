namespace TourDuLich
{
    partial class SuaTour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txtND = new System.Windows.Forms.DateTimePicker();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.txtND);
            this.panel1.Controls.Add(this.txtTG);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 232);
            this.panel1.TabIndex = 3;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Gold;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(276, 163);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(186, 61);
            this.btn_Reset.TabIndex = 43;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Gold;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(9, 163);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(196, 61);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Update";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txtND
            // 
            this.txtND.CustomFormat = "dd/MM/yyyy";
            this.txtND.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtND.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtND.Location = new System.Drawing.Point(159, 105);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(305, 34);
            this.txtND.TabIndex = 38;
            // 
            // txtTG
            // 
            this.txtTG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.Location = new System.Drawing.Point(159, 65);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(305, 34);
            this.txtTG.TabIndex = 35;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(159, 25);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(305, 34);
            this.txtGia.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 27);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ngày đi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Thời gian:";
            // 
            // SuaTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 234);
            this.Controls.Add(this.panel1);
            this.Name = "SuaTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DateTimePicker txtND;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}