namespace FakeData_Aprel14
{
    partial class PersonStatisticsForm
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
            this.CountriesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countPersonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountriesComboBox
            // 
            this.CountriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountriesComboBox.FormattingEnabled = true;
            this.CountriesComboBox.Location = new System.Drawing.Point(17, 14);
            this.CountriesComboBox.Name = "CountriesComboBox";
            this.CountriesComboBox.Size = new System.Drawing.Size(224, 24);
            this.CountriesComboBox.TabIndex = 0;
            this.CountriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CountriesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İnsan sayı:";
            // 
            // countPersonLabel
            // 
            this.countPersonLabel.AutoSize = true;
            this.countPersonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countPersonLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.countPersonLabel.Location = new System.Drawing.Point(116, 55);
            this.countPersonLabel.Name = "countPersonLabel";
            this.countPersonLabel.Size = new System.Drawing.Size(0, 17);
            this.countPersonLabel.TabIndex = 2;
            // 
            // PersonStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 165);
            this.Controls.Add(this.countPersonLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountriesComboBox);
            this.Name = "PersonStatisticsForm";
            this.Text = "Persons Statistics";
            this.Load += new System.EventHandler(this.PersonStatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountriesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countPersonLabel;
    }
}