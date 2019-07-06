namespace Simulatore_luce_solare
{
    partial class ucSlider
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudSlider = new System.Windows.Forms.NumericUpDown();
            this.tbSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSlider
            // 
            this.nudSlider.AutoSize = true;
            this.nudSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSlider.Location = new System.Drawing.Point(10, 258);
            this.nudSlider.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSlider.Name = "nudSlider";
            this.nudSlider.Size = new System.Drawing.Size(52, 22);
            this.nudSlider.TabIndex = 15;
            this.nudSlider.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSlider.ValueChanged += new System.EventHandler(this.nudSlider_ValueChanged);
            // 
            // tbSlider
            // 
            this.tbSlider.Location = new System.Drawing.Point(14, 3);
            this.tbSlider.Maximum = 255;
            this.tbSlider.Name = "tbSlider";
            this.tbSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSlider.Size = new System.Drawing.Size(45, 249);
            this.tbSlider.TabIndex = 14;
            this.tbSlider.TickFrequency = 17;
            this.tbSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbSlider.Scroll += new System.EventHandler(this.tbSlider_Scroll);
            // 
            // ucSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudSlider);
            this.Controls.Add(this.tbSlider);
            this.Name = "ucSlider";
            this.Size = new System.Drawing.Size(73, 292);
            ((System.ComponentModel.ISupportInitialize)(this.nudSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSlider;
        private System.Windows.Forms.TrackBar tbSlider;
    }
}
