namespace FakeData_Aprel14
{
    partial class PersonsInfoForm
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
            this.GeneratePersonsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonsStatisticsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratePersonsButton
            // 
            this.GeneratePersonsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratePersonsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePersonsButton.Location = new System.Drawing.Point(69, 379);
            this.GeneratePersonsButton.Name = "GeneratePersonsButton";
            this.GeneratePersonsButton.Size = new System.Drawing.Size(137, 37);
            this.GeneratePersonsButton.TabIndex = 1;
            this.GeneratePersonsButton.Text = "Generate persons";
            this.GeneratePersonsButton.UseVisualStyleBackColor = true;
            this.GeneratePersonsButton.Click += new System.EventHandler(this.GeneratePersonButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // PersonsStatisticsButton
            // 
            this.PersonsStatisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonsStatisticsButton.Enabled = false;
            this.PersonsStatisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonsStatisticsButton.Location = new System.Drawing.Point(225, 379);
            this.PersonsStatisticsButton.Name = "PersonsStatisticsButton";
            this.PersonsStatisticsButton.Size = new System.Drawing.Size(190, 37);
            this.PersonsStatisticsButton.TabIndex = 3;
            this.PersonsStatisticsButton.Text = "Get Person Statistics";
            this.PersonsStatisticsButton.UseVisualStyleBackColor = true;
            this.PersonsStatisticsButton.Click += new System.EventHandler(this.PersonsStatisticsButton_Click);
            // 
            // PersonsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 423);
            this.Controls.Add(this.PersonsStatisticsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GeneratePersonsButton);
            this.Name = "PersonsInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müştəri məlumatları";
            this.Load += new System.EventHandler(this.PersonsInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GeneratePersonsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PersonsStatisticsButton;
    }
}

