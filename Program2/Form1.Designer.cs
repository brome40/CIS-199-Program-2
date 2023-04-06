namespace Program2
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
            this.weightLbl = new System.Windows.Forms.Label();
            this.weightInputTxt = new System.Windows.Forms.TextBox();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.distanceInputTxt = new System.Windows.Forms.TextBox();
            this.deldaysLbl = new System.Windows.Forms.Label();
            this.deldaysInputTxt = new System.Windows.Forms.TextBox();
            this.calulateBtn = new System.Windows.Forms.Button();
            this.costsBox = new System.Windows.Forms.GroupBox();
            this.companyaLbl = new System.Windows.Forms.Label();
            this.companybLbl = new System.Windows.Forms.Label();
            this.companycLbl = new System.Windows.Forms.Label();
            this.companyaOutputLbl = new System.Windows.Forms.Label();
            this.companybOutputLbl = new System.Windows.Forms.Label();
            this.companycOutputLbl = new System.Windows.Forms.Label();
            this.lowestCostOutputLbl = new System.Windows.Forms.Label();
            this.costsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(68, 98);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(87, 13);
            this.weightLbl.TabIndex = 0;
            this.weightLbl.Text = "Package Weight";
            // 
            // weightInputTxt
            // 
            this.weightInputTxt.Location = new System.Drawing.Point(175, 90);
            this.weightInputTxt.Name = "weightInputTxt";
            this.weightInputTxt.Size = new System.Drawing.Size(100, 20);
            this.weightInputTxt.TabIndex = 1;
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Location = new System.Drawing.Point(71, 160);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(82, 13);
            this.distanceLbl.TabIndex = 2;
            this.distanceLbl.Text = "Distance (Miles)";
            // 
            // distanceInputTxt
            // 
            this.distanceInputTxt.Location = new System.Drawing.Point(175, 160);
            this.distanceInputTxt.Name = "distanceInputTxt";
            this.distanceInputTxt.Size = new System.Drawing.Size(100, 20);
            this.distanceInputTxt.TabIndex = 3;
            // 
            // deldaysLbl
            // 
            this.deldaysLbl.AutoSize = true;
            this.deldaysLbl.Location = new System.Drawing.Point(71, 228);
            this.deldaysLbl.Name = "deldaysLbl";
            this.deldaysLbl.Size = new System.Drawing.Size(72, 13);
            this.deldaysLbl.TabIndex = 4;
            this.deldaysLbl.Text = "Delivery Days";
            // 
            // deldaysInputTxt
            // 
            this.deldaysInputTxt.Location = new System.Drawing.Point(175, 220);
            this.deldaysInputTxt.Name = "deldaysInputTxt";
            this.deldaysInputTxt.Size = new System.Drawing.Size(100, 20);
            this.deldaysInputTxt.TabIndex = 5;
            // 
            // calulateBtn
            // 
            this.calulateBtn.Location = new System.Drawing.Point(133, 277);
            this.calulateBtn.Name = "calulateBtn";
            this.calulateBtn.Size = new System.Drawing.Size(94, 31);
            this.calulateBtn.TabIndex = 6;
            this.calulateBtn.Text = "Calculate Cost";
            this.calulateBtn.UseVisualStyleBackColor = true;
            this.calulateBtn.Click += new System.EventHandler(this.calulateBtn_Click);
            // 
            // costsBox
            // 
            this.costsBox.Controls.Add(this.lowestCostOutputLbl);
            this.costsBox.Controls.Add(this.companycOutputLbl);
            this.costsBox.Controls.Add(this.companybOutputLbl);
            this.costsBox.Controls.Add(this.companyaOutputLbl);
            this.costsBox.Controls.Add(this.companycLbl);
            this.costsBox.Controls.Add(this.companybLbl);
            this.costsBox.Controls.Add(this.companyaLbl);
            this.costsBox.Location = new System.Drawing.Point(330, 28);
            this.costsBox.Name = "costsBox";
            this.costsBox.Size = new System.Drawing.Size(355, 312);
            this.costsBox.TabIndex = 7;
            this.costsBox.TabStop = false;
            this.costsBox.Text = "Results";
            // 
            // companyaLbl
            // 
            this.companyaLbl.AutoSize = true;
            this.companyaLbl.Location = new System.Drawing.Point(42, 62);
            this.companyaLbl.Name = "companyaLbl";
            this.companyaLbl.Size = new System.Drawing.Size(85, 13);
            this.companyaLbl.TabIndex = 0;
            this.companyaLbl.Text = "Company A Cost";
            // 
            // companybLbl
            // 
            this.companybLbl.AutoSize = true;
            this.companybLbl.Location = new System.Drawing.Point(45, 132);
            this.companybLbl.Name = "companybLbl";
            this.companybLbl.Size = new System.Drawing.Size(85, 13);
            this.companybLbl.TabIndex = 1;
            this.companybLbl.Text = "Company B Cost";
            // 
            // companycLbl
            // 
            this.companycLbl.AutoSize = true;
            this.companycLbl.Location = new System.Drawing.Point(45, 192);
            this.companycLbl.Name = "companycLbl";
            this.companycLbl.Size = new System.Drawing.Size(85, 13);
            this.companycLbl.TabIndex = 2;
            this.companycLbl.Text = "Company C Cost";
            // 
            // companyaOutputLbl
            // 
            this.companyaOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyaOutputLbl.Location = new System.Drawing.Point(148, 61);
            this.companyaOutputLbl.Name = "companyaOutputLbl";
            this.companyaOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.companyaOutputLbl.TabIndex = 3;
            // 
            // companybOutputLbl
            // 
            this.companybOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companybOutputLbl.Location = new System.Drawing.Point(148, 129);
            this.companybOutputLbl.Name = "companybOutputLbl";
            this.companybOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.companybOutputLbl.TabIndex = 4;
            // 
            // companycOutputLbl
            // 
            this.companycOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companycOutputLbl.Location = new System.Drawing.Point(148, 189);
            this.companycOutputLbl.Name = "companycOutputLbl";
            this.companycOutputLbl.Size = new System.Drawing.Size(100, 23);
            this.companycOutputLbl.TabIndex = 5;
            // 
            // lowestCostOutputLbl
            // 
            this.lowestCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCostOutputLbl.Location = new System.Drawing.Point(45, 257);
            this.lowestCostOutputLbl.Name = "lowestCostOutputLbl";
            this.lowestCostOutputLbl.Size = new System.Drawing.Size(203, 23);
            this.lowestCostOutputLbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.calulateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costsBox);
            this.Controls.Add(this.calulateBtn);
            this.Controls.Add(this.deldaysInputTxt);
            this.Controls.Add(this.deldaysLbl);
            this.Controls.Add(this.distanceInputTxt);
            this.Controls.Add(this.distanceLbl);
            this.Controls.Add(this.weightInputTxt);
            this.Controls.Add(this.weightLbl);
            this.Name = "Form1";
            this.Text = "Package Cost Calculation";
            this.costsBox.ResumeLayout(false);
            this.costsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.TextBox weightInputTxt;
        private System.Windows.Forms.Label distanceLbl;
        private System.Windows.Forms.TextBox distanceInputTxt;
        private System.Windows.Forms.Label deldaysLbl;
        private System.Windows.Forms.TextBox deldaysInputTxt;
        private System.Windows.Forms.Button calulateBtn;
        private System.Windows.Forms.GroupBox costsBox;
        private System.Windows.Forms.Label lowestCostOutputLbl;
        private System.Windows.Forms.Label companycOutputLbl;
        private System.Windows.Forms.Label companybOutputLbl;
        private System.Windows.Forms.Label companyaOutputLbl;
        private System.Windows.Forms.Label companycLbl;
        private System.Windows.Forms.Label companybLbl;
        private System.Windows.Forms.Label companyaLbl;
    }
}

