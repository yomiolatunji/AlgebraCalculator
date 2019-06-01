namespace AdvanCalculator
{
    partial class CalculatorGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorGui));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpQuadratic = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculateQuadratic = new System.Windows.Forms.Button();
            this.txtQuadraticC = new System.Windows.Forms.TextBox();
            this.txtQuadraticB = new System.Windows.Forms.TextBox();
            this.txtQuadraticA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInverseA = new System.Windows.Forms.TextBox();
            this.txtInverseB = new System.Windows.Forms.TextBox();
            this.txtInverseC = new System.Windows.Forms.TextBox();
            this.txtInverseD = new System.Windows.Forms.TextBox();
            this.btnCalculateInverse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultA = new System.Windows.Forms.Label();
            this.lblResultB = new System.Windows.Forms.Label();
            this.lblResultD = new System.Windows.Forms.Label();
            this.lblResultC = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpQuadratic.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbpQuadratic);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpQuadratic
            // 
            this.tbpQuadratic.Controls.Add(this.panel2);
            this.tbpQuadratic.Controls.Add(this.btnCalculateQuadratic);
            this.tbpQuadratic.Controls.Add(this.txtQuadraticC);
            this.tbpQuadratic.Controls.Add(this.txtQuadraticB);
            this.tbpQuadratic.Controls.Add(this.txtQuadraticA);
            this.tbpQuadratic.Controls.Add(this.label3);
            this.tbpQuadratic.Controls.Add(this.label2);
            this.tbpQuadratic.Controls.Add(this.label1);
            this.tbpQuadratic.Controls.Add(this.panel1);
            this.tbpQuadratic.Location = new System.Drawing.Point(4, 25);
            this.tbpQuadratic.Name = "tbpQuadratic";
            this.tbpQuadratic.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQuadratic.Size = new System.Drawing.Size(792, 421);
            this.tbpQuadratic.TabIndex = 0;
            this.tbpQuadratic.Text = "Quadratic Equation";
            this.tbpQuadratic.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.lblX2);
            this.panel2.Controls.Add(this.lblX1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(538, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 147);
            this.panel2.TabIndex = 4;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(97, 98);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(13, 20);
            this.lblX2.TabIndex = 1;
            this.lblX2.Text = ".";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.Location = new System.Drawing.Point(97, 35);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(13, 20);
            this.lblX1.TabIndex = 1;
            this.lblX1.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "x2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "x1 :";
            // 
            // btnCalculateQuadratic
            // 
            this.btnCalculateQuadratic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculateQuadratic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateQuadratic.Location = new System.Drawing.Point(389, 329);
            this.btnCalculateQuadratic.Name = "btnCalculateQuadratic";
            this.btnCalculateQuadratic.Size = new System.Drawing.Size(98, 34);
            this.btnCalculateQuadratic.TabIndex = 3;
            this.btnCalculateQuadratic.Text = "Calculate";
            this.btnCalculateQuadratic.UseVisualStyleBackColor = true;
            this.btnCalculateQuadratic.Click += new System.EventHandler(this.btnCalculateQuadratic_Click);
            // 
            // txtQuadraticC
            // 
            this.txtQuadraticC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuadraticC.Location = new System.Drawing.Point(191, 282);
            this.txtQuadraticC.Name = "txtQuadraticC";
            this.txtQuadraticC.Size = new System.Drawing.Size(296, 20);
            this.txtQuadraticC.TabIndex = 2;
            // 
            // txtQuadraticB
            // 
            this.txtQuadraticB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuadraticB.Location = new System.Drawing.Point(191, 224);
            this.txtQuadraticB.Name = "txtQuadraticB";
            this.txtQuadraticB.Size = new System.Drawing.Size(296, 20);
            this.txtQuadraticB.TabIndex = 2;
            // 
            // txtQuadraticA
            // 
            this.txtQuadraticA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuadraticA.Location = new System.Drawing.Point(191, 168);
            this.txtQuadraticA.Name = "txtQuadraticA";
            this.txtQuadraticA.Size = new System.Drawing.Size(296, 20);
            this.txtQuadraticA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "c :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "b :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "a :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(160, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 97);
            this.panel1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnCalculateInverse);
            this.tabPage1.Controls.Add(this.txtInverseD);
            this.tabPage1.Controls.Add(this.txtInverseC);
            this.tabPage1.Controls.Add(this.txtInverseB);
            this.tabPage1.Controls.Add(this.txtInverseA);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inverse of a Matrix";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(299, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 100);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "a :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "b :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "c :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "d :";
            // 
            // txtInverseA
            // 
            this.txtInverseA.Location = new System.Drawing.Point(182, 148);
            this.txtInverseA.Name = "txtInverseA";
            this.txtInverseA.Size = new System.Drawing.Size(244, 20);
            this.txtInverseA.TabIndex = 2;
            // 
            // txtInverseB
            // 
            this.txtInverseB.Location = new System.Drawing.Point(182, 188);
            this.txtInverseB.Name = "txtInverseB";
            this.txtInverseB.Size = new System.Drawing.Size(244, 20);
            this.txtInverseB.TabIndex = 2;
            // 
            // txtInverseC
            // 
            this.txtInverseC.Location = new System.Drawing.Point(182, 233);
            this.txtInverseC.Name = "txtInverseC";
            this.txtInverseC.Size = new System.Drawing.Size(244, 20);
            this.txtInverseC.TabIndex = 2;
            // 
            // txtInverseD
            // 
            this.txtInverseD.Location = new System.Drawing.Point(182, 278);
            this.txtInverseD.Name = "txtInverseD";
            this.txtInverseD.Size = new System.Drawing.Size(244, 20);
            this.txtInverseD.TabIndex = 2;
            // 
            // btnCalculateInverse
            // 
            this.btnCalculateInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateInverse.Location = new System.Drawing.Point(332, 317);
            this.btnCalculateInverse.Name = "btnCalculateInverse";
            this.btnCalculateInverse.Size = new System.Drawing.Size(93, 36);
            this.btnCalculateInverse.TabIndex = 3;
            this.btnCalculateInverse.Text = "Calculate";
            this.btnCalculateInverse.UseVisualStyleBackColor = true;
            this.btnCalculateInverse.Click += new System.EventHandler(this.btnCalculateInverse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultC);
            this.groupBox1.Controls.Add(this.lblResultD);
            this.groupBox1.Controls.Add(this.lblResultB);
            this.groupBox1.Controls.Add(this.lblResultA);
            this.groupBox1.Location = new System.Drawing.Point(560, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lblResultA
            // 
            this.lblResultA.AutoSize = true;
            this.lblResultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultA.Location = new System.Drawing.Point(68, 34);
            this.lblResultA.Name = "lblResultA";
            this.lblResultA.Size = new System.Drawing.Size(13, 20);
            this.lblResultA.TabIndex = 0;
            this.lblResultA.Text = ".";
            // 
            // lblResultB
            // 
            this.lblResultB.AutoSize = true;
            this.lblResultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultB.Location = new System.Drawing.Point(127, 34);
            this.lblResultB.Name = "lblResultB";
            this.lblResultB.Size = new System.Drawing.Size(13, 20);
            this.lblResultB.TabIndex = 0;
            this.lblResultB.Text = ".";
            // 
            // lblResultD
            // 
            this.lblResultD.AutoSize = true;
            this.lblResultD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultD.Location = new System.Drawing.Point(127, 88);
            this.lblResultD.Name = "lblResultD";
            this.lblResultD.Size = new System.Drawing.Size(13, 20);
            this.lblResultD.TabIndex = 0;
            this.lblResultD.Text = ".";
            // 
            // lblResultC
            // 
            this.lblResultC.AutoSize = true;
            this.lblResultC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultC.Location = new System.Drawing.Point(68, 88);
            this.lblResultC.Name = "lblResultC";
            this.lblResultC.Size = new System.Drawing.Size(13, 20);
            this.lblResultC.TabIndex = 0;
            this.lblResultC.Text = ".";
            // 
            // CalculatorGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CalculatorGui";
            this.Text = "AdvanCalculator";
            this.tabControl1.ResumeLayout(false);
            this.tbpQuadratic.ResumeLayout(false);
            this.tbpQuadratic.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpQuadratic;
        private System.Windows.Forms.Button btnCalculateQuadratic;
        private System.Windows.Forms.TextBox txtQuadraticC;
        private System.Windows.Forms.TextBox txtQuadraticB;
        private System.Windows.Forms.TextBox txtQuadraticA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCalculateInverse;
        private System.Windows.Forms.TextBox txtInverseD;
        private System.Windows.Forms.TextBox txtInverseC;
        private System.Windows.Forms.TextBox txtInverseB;
        private System.Windows.Forms.TextBox txtInverseA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultC;
        private System.Windows.Forms.Label lblResultD;
        private System.Windows.Forms.Label lblResultB;
        private System.Windows.Forms.Label lblResultA;
    }
}

