namespace TestApp
{
    partial class Form1
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
            this.btnAddFile = new System.Windows.Forms.Button();
            this.tboxDeviceFile = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dtPickerScannedAfter = new System.Windows.Forms.DateTimePicker();
            this.dtPickerScannedBefore = new System.Windows.Forms.DateTimePicker();
            this.lblScannedAfter = new System.Windows.Forms.Label();
            this.lblScannedBefore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(12, 14);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // tboxDeviceFile
            // 
            this.tboxDeviceFile.Location = new System.Drawing.Point(93, 16);
            this.tboxDeviceFile.Name = "tboxDeviceFile";
            this.tboxDeviceFile.Size = new System.Drawing.Size(372, 20);
            this.tboxDeviceFile.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(197, 96);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(95, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process Devices";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // dtPickerScannedAfter
            // 
            this.dtPickerScannedAfter.Location = new System.Drawing.Point(180, 44);
            this.dtPickerScannedAfter.Name = "dtPickerScannedAfter";
            this.dtPickerScannedAfter.Size = new System.Drawing.Size(200, 20);
            this.dtPickerScannedAfter.TabIndex = 3;
            this.dtPickerScannedAfter.ValueChanged += new System.EventHandler(this.dtPickerScannedAfter_ValueChanged);
            // 
            // dtPickerScannedBefore
            // 
            this.dtPickerScannedBefore.Location = new System.Drawing.Point(180, 70);
            this.dtPickerScannedBefore.Name = "dtPickerScannedBefore";
            this.dtPickerScannedBefore.Size = new System.Drawing.Size(200, 20);
            this.dtPickerScannedBefore.TabIndex = 4;
            this.dtPickerScannedBefore.ValueChanged += new System.EventHandler(this.dtPickerScannedBefore_ValueChanged);
            // 
            // lblScannedAfter
            // 
            this.lblScannedAfter.AutoSize = true;
            this.lblScannedAfter.Location = new System.Drawing.Point(90, 49);
            this.lblScannedAfter.Name = "lblScannedAfter";
            this.lblScannedAfter.Size = new System.Drawing.Size(75, 13);
            this.lblScannedAfter.TabIndex = 5;
            this.lblScannedAfter.Text = "Scanned After";
            // 
            // lblScannedBefore
            // 
            this.lblScannedBefore.AutoSize = true;
            this.lblScannedBefore.Location = new System.Drawing.Point(90, 74);
            this.lblScannedBefore.Name = "lblScannedBefore";
            this.lblScannedBefore.Size = new System.Drawing.Size(84, 13);
            this.lblScannedBefore.TabIndex = 6;
            this.lblScannedBefore.Text = "Scanned Before";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 123);
            this.Controls.Add(this.lblScannedBefore);
            this.Controls.Add(this.lblScannedAfter);
            this.Controls.Add(this.dtPickerScannedBefore);
            this.Controls.Add(this.dtPickerScannedAfter);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tboxDeviceFile);
            this.Controls.Add(this.btnAddFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.TextBox tboxDeviceFile;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DateTimePicker dtPickerScannedAfter;
        private System.Windows.Forms.DateTimePicker dtPickerScannedBefore;
        private System.Windows.Forms.Label lblScannedAfter;
        private System.Windows.Forms.Label lblScannedBefore;
    }
}

