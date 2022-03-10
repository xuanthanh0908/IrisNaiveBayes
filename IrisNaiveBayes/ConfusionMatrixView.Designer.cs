
namespace IrisNaiveBayes
{
    partial class ConfusionMatrixView
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
            this.confusionMatrix_dataGridView = new System.Windows.Forms.DataGridView();
            this.predicted_label = new System.Windows.Forms.Label();
            this.actual_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrix_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // confusionMatrix_dataGridView
            // 
            this.confusionMatrix_dataGridView.AllowUserToAddRows = false;
            this.confusionMatrix_dataGridView.AllowUserToDeleteRows = false;
            this.confusionMatrix_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confusionMatrix_dataGridView.Location = new System.Drawing.Point(26, 23);
            this.confusionMatrix_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.confusionMatrix_dataGridView.Name = "confusionMatrix_dataGridView";
            this.confusionMatrix_dataGridView.ReadOnly = true;
            this.confusionMatrix_dataGridView.RowTemplate.Height = 24;
            this.confusionMatrix_dataGridView.Size = new System.Drawing.Size(432, 221);
            this.confusionMatrix_dataGridView.TabIndex = 5;
            // 
            // predicted_label
            // 
            this.predicted_label.AutoSize = true;
            this.predicted_label.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predicted_label.Location = new System.Drawing.Point(9, 23);
            this.predicted_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.predicted_label.Name = "predicted_label";
            this.predicted_label.Size = new System.Drawing.Size(14, 224);
            this.predicted_label.TabIndex = 4;
            this.predicted_label.Text = "P\nr\ne\nd\ni\nc\nt\ne\nd\n \nv\na\nl\nu\ne\ns";
            // 
            // actual_label
            // 
            this.actual_label.AutoSize = true;
            this.actual_label.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actual_label.Location = new System.Drawing.Point(197, 6);
            this.actual_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actual_label.Name = "actual_label";
            this.actual_label.Size = new System.Drawing.Size(98, 14);
            this.actual_label.TabIndex = 3;
            this.actual_label.Text = "Actual values";
            // 
            // ConfusionMatrixView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 259);
            this.Controls.Add(this.confusionMatrix_dataGridView);
            this.Controls.Add(this.predicted_label);
            this.Controls.Add(this.actual_label);
            this.Name = "ConfusionMatrixView";
            this.Text = "ConfusionMatrixView";
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrix_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView confusionMatrix_dataGridView;
        private System.Windows.Forms.Label predicted_label;
        private System.Windows.Forms.Label actual_label;
    }
}