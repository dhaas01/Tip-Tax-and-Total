namespace Tip_Tax_and_total__2_
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.amountTipLabel = new System.Windows.Forms.Label();
            this.amountSalesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.foodChargeAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculatedTipAmountLabel = new System.Windows.Forms.Label();
            this.calculatedSalesTaxLabel = new System.Windows.Forms.Label();
            this.calculatedTotalLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(30, 52);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(212, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter the food charge for your meal:";
            // 
            // amountTipLabel
            // 
            this.amountTipLabel.AutoSize = true;
            this.amountTipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTipLabel.Location = new System.Drawing.Point(151, 77);
            this.amountTipLabel.Name = "amountTipLabel";
            this.amountTipLabel.Size = new System.Drawing.Size(91, 13);
            this.amountTipLabel.TabIndex = 1;
            this.amountTipLabel.Text = "The 15% tip is:";
            // 
            // amountSalesTaxLabel
            // 
            this.amountSalesTaxLabel.AutoSize = true;
            this.amountSalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountSalesTaxLabel.Location = new System.Drawing.Point(122, 102);
            this.amountSalesTaxLabel.Name = "amountSalesTaxLabel";
            this.amountSalesTaxLabel.Size = new System.Drawing.Size(120, 13);
            this.amountSalesTaxLabel.TabIndex = 2;
            this.amountSalesTaxLabel.Text = "The 7% sales tax is:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(167, 128);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "The total is:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(54, 162);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(273, 162);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // foodChargeAmountTextBox
            // 
            this.foodChargeAmountTextBox.Location = new System.Drawing.Point(248, 49);
            this.foodChargeAmountTextBox.Name = "foodChargeAmountTextBox";
            this.foodChargeAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodChargeAmountTextBox.TabIndex = 7;
            // 
            // calculatedTipAmountLabel
            // 
            this.calculatedTipAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedTipAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedTipAmountLabel.Location = new System.Drawing.Point(248, 72);
            this.calculatedTipAmountLabel.Name = "calculatedTipAmountLabel";
            this.calculatedTipAmountLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedTipAmountLabel.TabIndex = 9;
            this.calculatedTipAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedSalesTaxLabel
            // 
            this.calculatedSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedSalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedSalesTaxLabel.Location = new System.Drawing.Point(248, 97);
            this.calculatedSalesTaxLabel.Name = "calculatedSalesTaxLabel";
            this.calculatedSalesTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedSalesTaxLabel.TabIndex = 11;
            this.calculatedSalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedTotalLabel
            // 
            this.calculatedTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedTotalLabel.Location = new System.Drawing.Point(248, 123);
            this.calculatedTotalLabel.Name = "calculatedTotalLabel";
            this.calculatedTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.calculatedTotalLabel.TabIndex = 12;
            this.calculatedTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(167, 162);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 230);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculatedTotalLabel);
            this.Controls.Add(this.calculatedSalesTaxLabel);
            this.Controls.Add(this.calculatedTipAmountLabel);
            this.Controls.Add(this.foodChargeAmountTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.amountSalesTaxLabel);
            this.Controls.Add(this.amountTipLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Tip Tax and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label amountTipLabel;
        private System.Windows.Forms.Label amountSalesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox foodChargeAmountTextBox;
        private System.Windows.Forms.Label calculatedTipAmountLabel;
        private System.Windows.Forms.Label calculatedSalesTaxLabel;
        private System.Windows.Forms.Label calculatedTotalLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

