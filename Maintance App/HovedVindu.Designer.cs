﻿namespace Maintance_App
{
    partial class HovedVindu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            addOrDeleteButton = new Button();
            editStatusButton = new Button();
            tasksGridView = new DataGridView();
            refresh = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)tasksGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Add or Delete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 25);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "Change Status";
            // 
            // addOrDeleteButton
            // 
            addOrDeleteButton.Location = new Point(24, 77);
            addOrDeleteButton.Name = "addOrDeleteButton";
            addOrDeleteButton.Size = new Size(142, 34);
            addOrDeleteButton.TabIndex = 2;
            addOrDeleteButton.Text = "Add or delete";
            addOrDeleteButton.UseVisualStyleBackColor = true;
            addOrDeleteButton.Click += addOrDelete_Click;
            // 
            // editStatusButton
            // 
            editStatusButton.Location = new Point(178, 77);
            editStatusButton.Name = "editStatusButton";
            editStatusButton.Size = new Size(112, 34);
            editStatusButton.TabIndex = 3;
            editStatusButton.Text = "Edit Status";
            editStatusButton.UseVisualStyleBackColor = true;
            editStatusButton.Click += editStatusButton_Click;
            // 
            // tasksGridView
            // 
            tasksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksGridView.Location = new Point(12, 131);
            tasksGridView.Name = "tasksGridView";
            tasksGridView.RowHeadersWidth = 62;
            tasksGridView.RowTemplate.Height = 33;
            tasksGridView.Size = new Size(595, 307);
            tasksGridView.TabIndex = 4;
            tasksGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // refresh
            // 
            refresh.Location = new Point(307, 77);
            refresh.Name = "refresh";
            refresh.Size = new Size(112, 34);
            refresh.TabIndex = 5;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 27);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 6;
            label3.Text = "Refresh";
            // 
            // HovedVindu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(refresh);
            Controls.Add(tasksGridView);
            Controls.Add(editStatusButton);
            Controls.Add(addOrDeleteButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HovedVindu";
            Text = "Form1";
            Load += HovedVindu_Load;
            SizeChanged += hovedVindu_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)tasksGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button addOrDeleteButton;
        private Button editStatusButton;
        private DataGridView tasksGridView;
        private Button refresh;
        private Label label3;
    }
}