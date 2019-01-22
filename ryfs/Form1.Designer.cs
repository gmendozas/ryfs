namespace ryfs
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
            this.runInstructionsLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.scriptsListBox = new System.Windows.Forms.ListBox();
            this.favoriteLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.addScriptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runInstructionsLabel
            // 
            this.runInstructionsLabel.AutoSize = true;
            this.runInstructionsLabel.Location = new System.Drawing.Point(13, 51);
            this.runInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runInstructionsLabel.Name = "runInstructionsLabel";
            this.runInstructionsLabel.Size = new System.Drawing.Size(138, 13);
            this.runInstructionsLabel.TabIndex = 1;
            this.runInstructionsLabel.Text = "Select your script and run it!";
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(326, 43);
            this.runButton.Margin = new System.Windows.Forms.Padding(2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(97, 28);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run it!";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(262, 26);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Run Your Favorite Scripts";
            // 
            // scriptsListBox
            // 
            this.scriptsListBox.FormattingEnabled = true;
            this.scriptsListBox.Location = new System.Drawing.Point(16, 100);
            this.scriptsListBox.Name = "scriptsListBox";
            this.scriptsListBox.Size = new System.Drawing.Size(120, 329);
            this.scriptsListBox.TabIndex = 4;
            this.scriptsListBox.SelectedIndexChanged += new System.EventHandler(this.scriptsListBox_SelectedIndexChanged);
            this.scriptsListBox.DoubleClick += new System.EventHandler(this.scriptsListBox_DoubleClick);
            // 
            // favoriteLabel
            // 
            this.favoriteLabel.AutoSize = true;
            this.favoriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoriteLabel.Location = new System.Drawing.Point(13, 84);
            this.favoriteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.favoriteLabel.Name = "favoriteLabel";
            this.favoriteLabel.Size = new System.Drawing.Size(63, 13);
            this.favoriteLabel.TabIndex = 5;
            this.favoriteLabel.Text = "Favorites:";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(162, 100);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(359, 329);
            this.logTextBox.TabIndex = 6;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(159, 84);
            this.logLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(32, 13);
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "Log:";
            // 
            // addScriptButton
            // 
            this.addScriptButton.Location = new System.Drawing.Point(425, 43);
            this.addScriptButton.Margin = new System.Windows.Forms.Padding(2);
            this.addScriptButton.Name = "addScriptButton";
            this.addScriptButton.Size = new System.Drawing.Size(97, 28);
            this.addScriptButton.TabIndex = 8;
            this.addScriptButton.Text = "Add Script";
            this.addScriptButton.UseVisualStyleBackColor = true;
            this.addScriptButton.Click += new System.EventHandler(this.addScriptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 441);
            this.Controls.Add(this.addScriptButton);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.favoriteLabel);
            this.Controls.Add(this.scriptsListBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.runInstructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RYFS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label runInstructionsLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox scriptsListBox;
        private System.Windows.Forms.Label favoriteLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button addScriptButton;
    }
}

