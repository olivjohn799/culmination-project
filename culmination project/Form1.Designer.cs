namespace culmination_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.grimaceshakeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bigmacInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lgfriesInput = new System.Windows.Forms.TextBox();
            this.calculatetotalButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Grimace Shakes";
            // 
            // grimaceshakeInput
            // 
            this.grimaceshakeInput.Location = new System.Drawing.Point(215, 43);
            this.grimaceshakeInput.Name = "grimaceshakeInput";
            this.grimaceshakeInput.Size = new System.Drawing.Size(40, 20);
            this.grimaceshakeInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of BigMacs";
            // 
            // bigmacInput
            // 
            this.bigmacInput.Location = new System.Drawing.Point(215, 73);
            this.bigmacInput.Name = "bigmacInput";
            this.bigmacInput.Size = new System.Drawing.Size(40, 20);
            this.bigmacInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Lg Fries";
            // 
            // lgfriesInput
            // 
            this.lgfriesInput.Location = new System.Drawing.Point(215, 100);
            this.lgfriesInput.Name = "lgfriesInput";
            this.lgfriesInput.Size = new System.Drawing.Size(40, 20);
            this.lgfriesInput.TabIndex = 5;
            // 
            // calculatetotalButton
            // 
            this.calculatetotalButton.Location = new System.Drawing.Point(80, 139);
            this.calculatetotalButton.Name = "calculatetotalButton";
            this.calculatetotalButton.Size = new System.Drawing.Size(127, 26);
            this.calculatetotalButton.TabIndex = 6;
            this.calculatetotalButton.Text = "Calculate Totals";
            this.calculatetotalButton.UseVisualStyleBackColor = true;
            this.calculatetotalButton.Click += new System.EventHandler(this.calculatetotalButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(156, 192);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 13);
            this.subtotalOutput.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tax";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(156, 215);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 13);
            this.taxOutput.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(156, 237);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 13);
            this.totalOutput.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(138, 289);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(54, 20);
            this.tenderedInput.TabIndex = 14;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(80, 327);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(133, 26);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(58, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 10);
            this.label11.TabIndex = 16;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(159, 371);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 13);
            this.changeOutput.TabIndex = 18;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(80, 398);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(133, 25);
            this.receiptButton.TabIndex = 19;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.Location = new System.Drawing.Point(308, 43);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(269, 341);
            this.receiptOutput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculatetotalButton);
            this.Controls.Add(this.lgfriesInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bigmacInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grimaceshakeInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grimaceshakeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bigmacInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lgfriesInput;
        private System.Windows.Forms.Button calculatetotalButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptOutput;
    }
}

