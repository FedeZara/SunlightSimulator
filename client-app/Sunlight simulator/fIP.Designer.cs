namespace Simulatore_luce_solare
{
    partial class fIP
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
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveIP = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.Control;
            this.panel18.Controls.Add(this.btnCancel);
            this.panel18.Controls.Add(this.label13);
            this.panel18.Controls.Add(this.btnSaveIP);
            this.panel18.Controls.Add(this.tbIP);
            this.panel18.Controls.Add(this.label8);
            this.panel18.Controls.Add(this.label24);
            this.panel18.Location = new System.Drawing.Point(1, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(248, 146);
            this.panel18.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(59, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "IP Configuration";
            // 
            // btnSaveIP
            // 
            this.btnSaveIP.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveIP.Location = new System.Drawing.Point(140, 96);
            this.btnSaveIP.Name = "btnSaveIP";
            this.btnSaveIP.Size = new System.Drawing.Size(75, 25);
            this.btnSaveIP.TabIndex = 13;
            this.btnSaveIP.Text = "Apply";
            this.btnSaveIP.UseVisualStyleBackColor = true;
            this.btnSaveIP.Click += new System.EventHandler(this.btnSaveIP_Click);
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(119, 57);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(105, 22);
            this.tbIP.TabIndex = 12;
            this.tbIP.Text = "192.168.107.179";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Raspberry IP: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(139, 333);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 13);
            this.label24.TabIndex = 3;
            // 
            // fIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 136);
            this.Controls.Add(this.panel18);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fIP";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveIP;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnCancel;
    }
}