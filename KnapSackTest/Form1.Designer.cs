using System;

namespace KnapSackTest
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LPButton = new System.Windows.Forms.Button();
            this.LPBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DynamicButton = new System.Windows.Forms.Button();
            this.Sample3Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SolveKsButton = new System.Windows.Forms.Button();
            this.DPRuntimeBox = new System.Windows.Forms.TextBox();
            this.LPRuntimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(79, 249);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(123, 20);
            this.resultBox.TabIndex = 0;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(305, 377);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(42, 23);
            this.solveButton.TabIndex = 1;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Visible = false;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(79, 69);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(123, 20);
            this.capacityBox.TabIndex = 3;
            this.capacityBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weights";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(79, 112);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(123, 20);
            this.weightBox.TabIndex = 5;
            this.weightBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insert Weight comma separated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Values";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(79, 150);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(123, 20);
            this.valueBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Insert Values comma separated";
            // 
            // LPButton
            // 
            this.LPButton.Location = new System.Drawing.Point(257, 377);
            this.LPButton.Name = "LPButton";
            this.LPButton.Size = new System.Drawing.Size(42, 23);
            this.LPButton.TabIndex = 10;
            this.LPButton.Text = "LP";
            this.LPButton.UseVisualStyleBackColor = true;
            this.LPButton.Visible = false;
            this.LPButton.Click += new System.EventHandler(this.LPButton_Click);
            // 
            // LPBox
            // 
            this.LPBox.Location = new System.Drawing.Point(79, 290);
            this.LPBox.Name = "LPBox";
            this.LPBox.Size = new System.Drawing.Size(123, 20);
            this.LPBox.TabIndex = 11;
            this.LPBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sample 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sample 2 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DynamicButton
            // 
            this.DynamicButton.Location = new System.Drawing.Point(353, 377);
            this.DynamicButton.Name = "DynamicButton";
            this.DynamicButton.Size = new System.Drawing.Size(131, 23);
            this.DynamicButton.TabIndex = 14;
            this.DynamicButton.Text = "Dynamic Programming";
            this.DynamicButton.UseVisualStyleBackColor = true;
            this.DynamicButton.Visible = false;
            this.DynamicButton.Click += new System.EventHandler(this.DynamicButton_Click);
            // 
            // Sample3Button
            // 
            this.Sample3Button.Location = new System.Drawing.Point(176, 26);
            this.Sample3Button.Name = "Sample3Button";
            this.Sample3Button.Size = new System.Drawing.Size(75, 23);
            this.Sample3Button.TabIndex = 15;
            this.Sample3Button.Text = "Sample 3";
            this.Sample3Button.UseVisualStyleBackColor = true;
            this.Sample3Button.Click += new System.EventHandler(this.Sample3Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dynamic P.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Linear P.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Max Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Items Chosen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Runtime";
            // 
            // SolveKsButton
            // 
            this.SolveKsButton.Location = new System.Drawing.Point(79, 181);
            this.SolveKsButton.Name = "SolveKsButton";
            this.SolveKsButton.Size = new System.Drawing.Size(123, 23);
            this.SolveKsButton.TabIndex = 21;
            this.SolveKsButton.Text = "Solve Knapsack";
            this.SolveKsButton.UseVisualStyleBackColor = true;
            this.SolveKsButton.Click += new System.EventHandler(this.SolveKsButton_Click);
            // 
            // DPRuntimeBox
            // 
            this.DPRuntimeBox.Location = new System.Drawing.Point(368, 249);
            this.DPRuntimeBox.Multiline = true;
            this.DPRuntimeBox.Name = "DPRuntimeBox";
            this.DPRuntimeBox.Size = new System.Drawing.Size(78, 20);
            this.DPRuntimeBox.TabIndex = 22;
            // 
            // LPRuntimeBox
            // 
            this.LPRuntimeBox.Location = new System.Drawing.Point(368, 290);
            this.LPRuntimeBox.Multiline = true;
            this.LPRuntimeBox.Name = "LPRuntimeBox";
            this.LPRuntimeBox.Size = new System.Drawing.Size(78, 20);
            this.LPRuntimeBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 412);
            this.Controls.Add(this.LPRuntimeBox);
            this.Controls.Add(this.DPRuntimeBox);
            this.Controls.Add(this.SolveKsButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sample3Button);
            this.Controls.Add(this.DynamicButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LPBox);
            this.Controls.Add(this.LPButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capacityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "Knapsack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LPButton;
        private System.Windows.Forms.TextBox LPBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DynamicButton;
        private System.Windows.Forms.Button Sample3Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SolveKsButton;
        private System.Windows.Forms.TextBox DPRuntimeBox;
        private System.Windows.Forms.TextBox LPRuntimeBox;
    }
}

