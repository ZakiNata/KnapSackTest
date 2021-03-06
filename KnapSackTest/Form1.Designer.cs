﻿using System;

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
            this.DPItemsBox = new System.Windows.Forms.TextBox();
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
            this.BFbutton = new System.Windows.Forms.Button();
            this.BFRuntimeBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BFBox = new System.Windows.Forms.TextBox();
            this.BFItemsBox = new System.Windows.Forms.TextBox();
            this.LPItemsBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DPItemsBox
            // 
            this.DPItemsBox.Location = new System.Drawing.Point(176, 304);
            this.DPItemsBox.Name = "DPItemsBox";
            this.DPItemsBox.Size = new System.Drawing.Size(171, 20);
            this.DPItemsBox.TabIndex = 29;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(93, 304);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(58, 20);
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
            this.weightBox.Size = new System.Drawing.Size(367, 20);
            this.weightBox.TabIndex = 5;
            this.weightBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insert Weight comma separated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Values";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(79, 170);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(367, 20);
            this.valueBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 12);
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
            this.LPBox.Location = new System.Drawing.Point(93, 345);
            this.LPBox.Name = "LPBox";
            this.LPBox.Size = new System.Drawing.Size(58, 20);
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
            this.label6.Location = new System.Drawing.Point(15, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dynamic P.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Linear P.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Max Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Items Chosen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Runtime (ms , ticks)";
            // 
            // SolveKsButton
            // 
            this.SolveKsButton.Location = new System.Drawing.Point(323, 209);
            this.SolveKsButton.Name = "SolveKsButton";
            this.SolveKsButton.Size = new System.Drawing.Size(123, 23);
            this.SolveKsButton.TabIndex = 21;
            this.SolveKsButton.Text = "Solve Knapsack";
            this.SolveKsButton.UseVisualStyleBackColor = true;
            this.SolveKsButton.Click += new System.EventHandler(this.SolveKsButton_Click);
            // 
            // DPRuntimeBox
            // 
            this.DPRuntimeBox.Location = new System.Drawing.Point(368, 304);
            this.DPRuntimeBox.Multiline = true;
            this.DPRuntimeBox.Name = "DPRuntimeBox";
            this.DPRuntimeBox.Size = new System.Drawing.Size(78, 20);
            this.DPRuntimeBox.TabIndex = 22;
            // 
            // LPRuntimeBox
            // 
            this.LPRuntimeBox.Location = new System.Drawing.Point(368, 345);
            this.LPRuntimeBox.Multiline = true;
            this.LPRuntimeBox.Name = "LPRuntimeBox";
            this.LPRuntimeBox.Size = new System.Drawing.Size(78, 20);
            this.LPRuntimeBox.TabIndex = 23;
            // 
            // BFbutton
            // 
            this.BFbutton.Location = new System.Drawing.Point(176, 377);
            this.BFbutton.Name = "BFbutton";
            this.BFbutton.Size = new System.Drawing.Size(75, 23);
            this.BFbutton.TabIndex = 24;
            this.BFbutton.Text = "Brute Force";
            this.BFbutton.UseVisualStyleBackColor = true;
            this.BFbutton.Visible = false;
            this.BFbutton.Click += new System.EventHandler(this.BFbutton_Click);
            // 
            // BFRuntimeBox
            // 
            this.BFRuntimeBox.Location = new System.Drawing.Point(369, 268);
            this.BFRuntimeBox.Multiline = true;
            this.BFRuntimeBox.Name = "BFRuntimeBox";
            this.BFRuntimeBox.Size = new System.Drawing.Size(78, 20);
            this.BFRuntimeBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Brute Force";
            // 
            // BFBox
            // 
            this.BFBox.Location = new System.Drawing.Point(94, 268);
            this.BFBox.Multiline = true;
            this.BFBox.Name = "BFBox";
            this.BFBox.Size = new System.Drawing.Size(58, 20);
            this.BFBox.TabIndex = 25;
            // 
            // BFItemsBox
            // 
            this.BFItemsBox.Location = new System.Drawing.Point(176, 267);
            this.BFItemsBox.Name = "BFItemsBox";
            this.BFItemsBox.Size = new System.Drawing.Size(171, 20);
            this.BFItemsBox.TabIndex = 28;
            // 
            // LPItemsBox
            // 
            this.LPItemsBox.Location = new System.Drawing.Point(176, 345);
            this.LPItemsBox.Name = "LPItemsBox";
            this.LPItemsBox.Size = new System.Drawing.Size(171, 20);
            this.LPItemsBox.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Sample 4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 412);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LPItemsBox);
            this.Controls.Add(this.DPItemsBox);
            this.Controls.Add(this.BFItemsBox);
            this.Controls.Add(this.BFRuntimeBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BFBox);
            this.Controls.Add(this.BFbutton);
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
        private System.Windows.Forms.Button BFbutton;
        private System.Windows.Forms.TextBox BFRuntimeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BFBox;
        private System.Windows.Forms.TextBox BFItemsBox;
        private System.Windows.Forms.TextBox LPItemsBox;
        private System.Windows.Forms.TextBox DPItemsBox;
        private System.Windows.Forms.Button button3;
    }
}

