namespace AdvancedCSharpClassProject
{
    partial class HomePage
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
            this.readFileBtn = new System.Windows.Forms.Button();
            this.writeToFileBtn = new System.Windows.Forms.Button();
            this.openDbQueryPageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(523, 81);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(265, 115);
            this.readFileBtn.TabIndex = 1;
            this.readFileBtn.Text = "Read File";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // writeToFileBtn
            // 
            this.writeToFileBtn.Location = new System.Drawing.Point(523, 202);
            this.writeToFileBtn.Name = "writeToFileBtn";
            this.writeToFileBtn.Size = new System.Drawing.Size(265, 115);
            this.writeToFileBtn.TabIndex = 2;
            this.writeToFileBtn.Text = "Write To File";
            this.writeToFileBtn.UseVisualStyleBackColor = true;
            this.writeToFileBtn.Click += new System.EventHandler(this.WriteToFileBtn_Click);
            // 
            // openDbQueryPageButton
            // 
            this.openDbQueryPageButton.Location = new System.Drawing.Point(523, 323);
            this.openDbQueryPageButton.Name = "openDbQueryPageButton";
            this.openDbQueryPageButton.Size = new System.Drawing.Size(265, 115);
            this.openDbQueryPageButton.TabIndex = 3;
            this.openDbQueryPageButton.Text = "Open Database Page";
            this.openDbQueryPageButton.UseVisualStyleBackColor = true;
            this.openDbQueryPageButton.Click += new System.EventHandler(this.openDbQueryPageButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 443);
            this.Controls.Add(this.openDbQueryPageButton);
            this.Controls.Add(this.writeToFileBtn);
            this.Controls.Add(this.readFileBtn);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button readFileBtn;
        private Button writeToFileBtn;
        private Button openDbQueryPageButton;
    }
}