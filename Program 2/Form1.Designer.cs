
namespace Program_2
{
    partial class Program2
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
            this.peopleLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.delieryDaysLabel = new System.Windows.Forms.Label();
            this.companyACostLabel = new System.Windows.Forms.Label();
            this.companyBLabel = new System.Windows.Forms.Label();
            this.companyCLabel = new System.Windows.Forms.Label();
            this.companyACostOutputLabel = new System.Windows.Forms.Label();
            this.companyBCostOutputLabel = new System.Windows.Forms.Label();
            this.companyCCostOutputLabel = new System.Windows.Forms.Label();
            this.peopleInputTextBox = new System.Windows.Forms.TextBox();
            this.distanceInputTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDaysInputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.lowestCompanyCostLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(51, 115);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(52, 17);
            this.peopleLabel.TabIndex = 0;
            this.peopleLabel.Text = "People";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(51, 170);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(109, 17);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // delieryDaysLabel
            // 
            this.delieryDaysLabel.AutoSize = true;
            this.delieryDaysLabel.Location = new System.Drawing.Point(51, 227);
            this.delieryDaysLabel.Name = "delieryDaysLabel";
            this.delieryDaysLabel.Size = new System.Drawing.Size(95, 17);
            this.delieryDaysLabel.TabIndex = 2;
            this.delieryDaysLabel.Text = "Delivery Days";
            // 
            // companyACostLabel
            // 
            this.companyACostLabel.AutoSize = true;
            this.companyACostLabel.Location = new System.Drawing.Point(33, 64);
            this.companyACostLabel.Name = "companyACostLabel";
            this.companyACostLabel.Size = new System.Drawing.Size(112, 17);
            this.companyACostLabel.TabIndex = 4;
            this.companyACostLabel.Text = "Company A Cost";
            // 
            // companyBLabel
            // 
            this.companyBLabel.AutoSize = true;
            this.companyBLabel.Location = new System.Drawing.Point(33, 114);
            this.companyBLabel.Name = "companyBLabel";
            this.companyBLabel.Size = new System.Drawing.Size(112, 17);
            this.companyBLabel.TabIndex = 5;
            this.companyBLabel.Text = "Company B Cost";
            // 
            // companyCLabel
            // 
            this.companyCLabel.AutoSize = true;
            this.companyCLabel.Location = new System.Drawing.Point(33, 163);
            this.companyCLabel.Name = "companyCLabel";
            this.companyCLabel.Size = new System.Drawing.Size(112, 17);
            this.companyCLabel.TabIndex = 6;
            this.companyCLabel.Text = "Company C Cost";
            // 
            // companyACostOutputLabel
            // 
            this.companyACostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyACostOutputLabel.Location = new System.Drawing.Point(238, 63);
            this.companyACostOutputLabel.Name = "companyACostOutputLabel";
            this.companyACostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.companyACostOutputLabel.TabIndex = 7;
            this.companyACostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyBCostOutputLabel
            // 
            this.companyBCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBCostOutputLabel.Location = new System.Drawing.Point(238, 114);
            this.companyBCostOutputLabel.Name = "companyBCostOutputLabel";
            this.companyBCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.companyBCostOutputLabel.TabIndex = 8;
            this.companyBCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // companyCCostOutputLabel
            // 
            this.companyCCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyCCostOutputLabel.Location = new System.Drawing.Point(238, 163);
            this.companyCCostOutputLabel.Name = "companyCCostOutputLabel";
            this.companyCCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.companyCCostOutputLabel.TabIndex = 9;
            this.companyCCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peopleInputTextBox
            // 
            this.peopleInputTextBox.Location = new System.Drawing.Point(226, 112);
            this.peopleInputTextBox.Name = "peopleInputTextBox";
            this.peopleInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.peopleInputTextBox.TabIndex = 10;
            // 
            // distanceInputTextBox
            // 
            this.distanceInputTextBox.Location = new System.Drawing.Point(226, 167);
            this.distanceInputTextBox.Name = "distanceInputTextBox";
            this.distanceInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.distanceInputTextBox.TabIndex = 11;
            // 
            // deliveryDaysInputTextBox
            // 
            this.deliveryDaysInputTextBox.Location = new System.Drawing.Point(226, 224);
            this.deliveryDaysInputTextBox.Name = "deliveryDaysInputTextBox";
            this.deliveryDaysInputTextBox.Size = new System.Drawing.Size(100, 22);
            this.deliveryDaysInputTextBox.TabIndex = 12;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(102, 290);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 31);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.lowestCompanyCostLabel);
            this.resultsGroupBox.Controls.Add(this.companyCCostOutputLabel);
            this.resultsGroupBox.Controls.Add(this.companyBCostOutputLabel);
            this.resultsGroupBox.Controls.Add(this.companyACostOutputLabel);
            this.resultsGroupBox.Controls.Add(this.companyCLabel);
            this.resultsGroupBox.Controls.Add(this.companyBLabel);
            this.resultsGroupBox.Controls.Add(this.companyACostLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(385, 53);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(369, 304);
            this.resultsGroupBox.TabIndex = 14;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // lowestCompanyCostLabel
            // 
            this.lowestCompanyCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCompanyCostLabel.Location = new System.Drawing.Point(36, 237);
            this.lowestCompanyCostLabel.Name = "lowestCompanyCostLabel";
            this.lowestCompanyCostLabel.Size = new System.Drawing.Size(302, 23);
            this.lowestCompanyCostLabel.TabIndex = 10;
            this.lowestCompanyCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Program2
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.deliveryDaysInputTextBox);
            this.Controls.Add(this.distanceInputTextBox);
            this.Controls.Add(this.peopleInputTextBox);
            this.Controls.Add(this.delieryDaysLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.peopleLabel);
            this.Name = "Program2";
            this.Text = "Food Delivery Cost Application";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label delieryDaysLabel;
        private System.Windows.Forms.Label companyACostLabel;
        private System.Windows.Forms.Label companyBLabel;
        private System.Windows.Forms.Label companyCLabel;
        private System.Windows.Forms.Label companyACostOutputLabel;
        private System.Windows.Forms.Label companyBCostOutputLabel;
        private System.Windows.Forms.Label companyCCostOutputLabel;
        private System.Windows.Forms.TextBox peopleInputTextBox;
        private System.Windows.Forms.TextBox distanceInputTextBox;
        private System.Windows.Forms.TextBox deliveryDaysInputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Label lowestCompanyCostLabel;
    }
}

