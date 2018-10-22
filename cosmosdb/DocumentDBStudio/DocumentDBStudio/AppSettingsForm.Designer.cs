﻿namespace Microsoft.Azure.DocumentDBStudio
{
    partial class AppSettingsForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbExpandJson = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDocumentTreeCount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(362, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbExpandJson
            // 
            this.cbExpandJson.AutoSize = true;
            this.cbExpandJson.Location = new System.Drawing.Point(12, 12);
            this.cbExpandJson.Name = "cbExpandJson";
            this.cbExpandJson.Size = new System.Drawing.Size(212, 17);
            this.cbExpandJson.TabIndex = 12;
            this.cbExpandJson.Text = "Automatically expand pretty printed json";
            this.cbExpandJson.UseVisualStyleBackColor = true;
            this.cbExpandJson.CheckedChanged += new System.EventHandler(this.cbExpandJson_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Max number of documents in treeview";
            // 
            // cbDocumentTreeCount
            // 
            this.cbDocumentTreeCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentTreeCount.FormattingEnabled = true;
            this.cbDocumentTreeCount.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbDocumentTreeCount.Location = new System.Drawing.Point(201, 38);
            this.cbDocumentTreeCount.Name = "cbDocumentTreeCount";
            this.cbDocumentTreeCount.Size = new System.Drawing.Size(236, 21);
            this.cbDocumentTreeCount.TabIndex = 14;
            // 
            // AppSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 103);
            this.ControlBox = false;
            this.Controls.Add(this.cbDocumentTreeCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbExpandJson);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppSettingsForm";
            this.Text = "Application settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbExpandJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDocumentTreeCount;
    }
}