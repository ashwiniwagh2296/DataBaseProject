﻿namespace DataBaseProject
{
    partial class CommandBuildForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_PerformOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_PerformOperation
            // 
            this.btn_PerformOperation.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PerformOperation.Location = new System.Drawing.Point(71, 324);
            this.btn_PerformOperation.Name = "btn_PerformOperation";
            this.btn_PerformOperation.Size = new System.Drawing.Size(422, 43);
            this.btn_PerformOperation.TabIndex = 1;
            this.btn_PerformOperation.Text = "Perform Operation";
            this.btn_PerformOperation.UseVisualStyleBackColor = true;
            this.btn_PerformOperation.Click += new System.EventHandler(this.btn_PerformOperation_Click);
            // 
            // CommandBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 379);
            this.Controls.Add(this.btn_PerformOperation);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CommandBuildForm";
            this.Text = "CommandBuildForm";
            this.Load += new System.EventHandler(this.CommandBuildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_PerformOperation;
    }
}