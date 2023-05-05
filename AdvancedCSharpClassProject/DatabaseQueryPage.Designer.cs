namespace AdvancedCSharpClassProject
{
    partial class DatabaseQueryPage
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
            this.AddAnimalToDbLabel = new System.Windows.Forms.Label();
            this.AddToDbNameLabel = new System.Windows.Forms.Label();
            this.AddToDbNameTextBox = new System.Windows.Forms.TextBox();
            this.AddToDbAgeLabel = new System.Windows.Forms.Label();
            this.AddToDbColorLabel = new System.Windows.Forms.Label();
            this.AddToDbNotesForSitterLabel = new System.Windows.Forms.Label();
            this.AddToDbTypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToDbSubmitButton = new System.Windows.Forms.Button();
            this.AddToDbColorTextBox = new System.Windows.Forms.TextBox();
            this.AddToDbNotesTextBox = new System.Windows.Forms.TextBox();
            this.AddAgeToDbNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddToDbTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchByNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchDbTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.ownerIdLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddAgeToDbNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerIdUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAnimalToDbLabel
            // 
            this.AddAnimalToDbLabel.AutoSize = true;
            this.AddAnimalToDbLabel.Location = new System.Drawing.Point(24, 159);
            this.AddAnimalToDbLabel.Name = "AddAnimalToDbLabel";
            this.AddAnimalToDbLabel.Size = new System.Drawing.Size(192, 15);
            this.AddAnimalToDbLabel.TabIndex = 3;
            this.AddAnimalToDbLabel.Text = "Request Sitting Services For Animal";
            this.AddAnimalToDbLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddToDbNameLabel
            // 
            this.AddToDbNameLabel.AutoSize = true;
            this.AddToDbNameLabel.Location = new System.Drawing.Point(58, 214);
            this.AddToDbNameLabel.Name = "AddToDbNameLabel";
            this.AddToDbNameLabel.Size = new System.Drawing.Size(47, 15);
            this.AddToDbNameLabel.TabIndex = 4;
            this.AddToDbNameLabel.Text = "*Name:";
            // 
            // AddToDbNameTextBox
            // 
            this.AddToDbNameTextBox.Location = new System.Drawing.Point(106, 211);
            this.AddToDbNameTextBox.Name = "AddToDbNameTextBox";
            this.AddToDbNameTextBox.Size = new System.Drawing.Size(110, 23);
            this.AddToDbNameTextBox.TabIndex = 5;
            // 
            // AddToDbAgeLabel
            // 
            this.AddToDbAgeLabel.AutoSize = true;
            this.AddToDbAgeLabel.Location = new System.Drawing.Point(58, 252);
            this.AddToDbAgeLabel.Name = "AddToDbAgeLabel";
            this.AddToDbAgeLabel.Size = new System.Drawing.Size(36, 15);
            this.AddToDbAgeLabel.TabIndex = 6;
            this.AddToDbAgeLabel.Text = "*Age:";
            // 
            // AddToDbColorLabel
            // 
            this.AddToDbColorLabel.AutoSize = true;
            this.AddToDbColorLabel.Location = new System.Drawing.Point(58, 297);
            this.AddToDbColorLabel.Name = "AddToDbColorLabel";
            this.AddToDbColorLabel.Size = new System.Drawing.Size(44, 15);
            this.AddToDbColorLabel.TabIndex = 7;
            this.AddToDbColorLabel.Text = "*Color:";
            // 
            // AddToDbNotesForSitterLabel
            // 
            this.AddToDbNotesForSitterLabel.AutoSize = true;
            this.AddToDbNotesForSitterLabel.Location = new System.Drawing.Point(415, 275);
            this.AddToDbNotesForSitterLabel.Name = "AddToDbNotesForSitterLabel";
            this.AddToDbNotesForSitterLabel.Size = new System.Drawing.Size(96, 15);
            this.AddToDbNotesForSitterLabel.TabIndex = 8;
            this.AddToDbNotesForSitterLabel.Text = "*Notes For Sitter:";
            this.AddToDbNotesForSitterLabel.Click += new System.EventHandler(this.AddToDbNotesForSitterLabel_Click);
            // 
            // AddToDbTypeLabel
            // 
            this.AddToDbTypeLabel.AutoSize = true;
            this.AddToDbTypeLabel.Location = new System.Drawing.Point(415, 214);
            this.AddToDbTypeLabel.Name = "AddToDbTypeLabel";
            this.AddToDbTypeLabel.Size = new System.Drawing.Size(157, 15);
            this.AddToDbTypeLabel.TabIndex = 9;
            this.AddToDbTypeLabel.Text = "*Type(Aqautic/Land Animal)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Boxes Labeled with * are required";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddToDbSubmitButton
            // 
            this.AddToDbSubmitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddToDbSubmitButton.Location = new System.Drawing.Point(578, 376);
            this.AddToDbSubmitButton.Name = "AddToDbSubmitButton";
            this.AddToDbSubmitButton.Size = new System.Drawing.Size(110, 23);
            this.AddToDbSubmitButton.TabIndex = 11;
            this.AddToDbSubmitButton.Text = "Request";
            this.AddToDbSubmitButton.UseVisualStyleBackColor = false;
            this.AddToDbSubmitButton.Click += new System.EventHandler(this.AddToDbSubmitButton_Click);
            // 
            // AddToDbColorTextBox
            // 
            this.AddToDbColorTextBox.Location = new System.Drawing.Point(106, 294);
            this.AddToDbColorTextBox.Name = "AddToDbColorTextBox";
            this.AddToDbColorTextBox.Size = new System.Drawing.Size(110, 23);
            this.AddToDbColorTextBox.TabIndex = 13;
            // 
            // AddToDbNotesTextBox
            // 
            this.AddToDbNotesTextBox.Location = new System.Drawing.Point(533, 272);
            this.AddToDbNotesTextBox.Multiline = true;
            this.AddToDbNotesTextBox.Name = "AddToDbNotesTextBox";
            this.AddToDbNotesTextBox.Size = new System.Drawing.Size(155, 88);
            this.AddToDbNotesTextBox.TabIndex = 15;
            // 
            // AddAgeToDbNumberUpDown
            // 
            this.AddAgeToDbNumberUpDown.Location = new System.Drawing.Point(106, 252);
            this.AddAgeToDbNumberUpDown.Name = "AddAgeToDbNumberUpDown";
            this.AddAgeToDbNumberUpDown.Size = new System.Drawing.Size(110, 23);
            this.AddAgeToDbNumberUpDown.TabIndex = 16;
            // 
            // AddToDbTypeComboBox
            // 
            this.AddToDbTypeComboBox.FormattingEnabled = true;
            this.AddToDbTypeComboBox.Location = new System.Drawing.Point(578, 211);
            this.AddToDbTypeComboBox.Name = "AddToDbTypeComboBox";
            this.AddToDbTypeComboBox.Size = new System.Drawing.Size(110, 23);
            this.AddToDbTypeComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "*Type(Aqautic/Land Animal)";
            // 
            // SearchByNameTextBox
            // 
            this.SearchByNameTextBox.Location = new System.Drawing.Point(165, 20);
            this.SearchByNameTextBox.Name = "SearchByNameTextBox";
            this.SearchByNameTextBox.Size = new System.Drawing.Size(436, 23);
            this.SearchByNameTextBox.TabIndex = 1;
            // 
            // SearchDbTypeComboBox
            // 
            this.SearchDbTypeComboBox.FormattingEnabled = true;
            this.SearchDbTypeComboBox.Location = new System.Drawing.Point(327, 63);
            this.SearchDbTypeComboBox.Name = "SearchDbTypeComboBox";
            this.SearchDbTypeComboBox.Size = new System.Drawing.Size(110, 23);
            this.SearchDbTypeComboBox.TabIndex = 19;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchButton.Location = new System.Drawing.Point(634, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(132, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(17, 345);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(85, 15);
            this.ownerNameLabel.TabIndex = 20;
            this.ownerNameLabel.Text = "*Owner Name:";
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(106, 342);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(110, 23);
            this.ownerNameTextBox.TabIndex = 21;
            // 
            // ownerIdUpDown
            // 
            this.ownerIdUpDown.Location = new System.Drawing.Point(106, 402);
            this.ownerIdUpDown.Name = "ownerIdUpDown";
            this.ownerIdUpDown.Size = new System.Drawing.Size(110, 23);
            this.ownerIdUpDown.TabIndex = 22;
            // 
            // ownerIdLabel
            // 
            this.ownerIdLabel.AutoSize = true;
            this.ownerIdLabel.Location = new System.Drawing.Point(17, 384);
            this.ownerIdLabel.Name = "ownerIdLabel";
            this.ownerIdLabel.Size = new System.Drawing.Size(142, 15);
            this.ownerIdLabel.TabIndex = 23;
            this.ownerIdLabel.Text = "*Id(If returning customer)";
            this.ownerIdLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(58, 369);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(23, 15);
            this.orLabel.TabIndex = 24;
            this.orLabel.Text = "OR";
            // 
            // DatabaseQueryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.ownerIdLabel);
            this.Controls.Add(this.ownerIdUpDown);
            this.Controls.Add(this.ownerNameTextBox);
            this.Controls.Add(this.ownerNameLabel);
            this.Controls.Add(this.SearchDbTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddToDbTypeComboBox);
            this.Controls.Add(this.AddAgeToDbNumberUpDown);
            this.Controls.Add(this.AddToDbNotesTextBox);
            this.Controls.Add(this.AddToDbColorTextBox);
            this.Controls.Add(this.AddToDbSubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddToDbTypeLabel);
            this.Controls.Add(this.AddToDbNotesForSitterLabel);
            this.Controls.Add(this.AddToDbColorLabel);
            this.Controls.Add(this.AddToDbAgeLabel);
            this.Controls.Add(this.AddToDbNameTextBox);
            this.Controls.Add(this.AddToDbNameLabel);
            this.Controls.Add(this.AddAnimalToDbLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchByNameTextBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "DatabaseQueryPage";
            this.Text = "DatabaseQueryPage";
            ((System.ComponentModel.ISupportInitialize)(this.AddAgeToDbNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerIdUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label AddAnimalToDbLabel;
        private Label AddToDbNameLabel;
        private TextBox AddToDbNameTextBox;
        private Label AddToDbAgeLabel;
        private Label AddToDbColorLabel;
        private Label AddToDbNotesForSitterLabel;
        private Label AddToDbTypeLabel;
        private Label label3;
        private Button AddToDbSubmitButton;
        private TextBox AddToDbColorTextBox;
        private TextBox AddToDbNotesTextBox;
        private NumericUpDown AddAgeToDbNumberUpDown;
        private ComboBox AddToDbTypeComboBox;
        private Label label1;
        private Label label2;
        private TextBox SearchByNameTextBox;
        private ComboBox SearchDbTypeComboBox;
        private Button SearchButton;
        private Label ownerNameLabel;
        private TextBox ownerNameTextBox;
        private NumericUpDown ownerIdUpDown;
        private Label ownerIdLabel;
        private Label orLabel;
    }
}