namespace Grapher
{
    partial class Mainform
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
            this.graph1 = new EquationGrapher.Graph();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // graph1
            // 
            this.graph1.Location = new System.Drawing.Point(12, 12);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(453, 363);
            this.graph1.TabIndex = 0;
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(76, 381);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(267, 20);
            this.txtEquation.TabIndex = 1;
            this.txtEquation.Text = "x*x + x + 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equation";
            // 
            // butCalc
            // 
            this.butCalc.Location = new System.Drawing.Point(352, 382);
            this.butCalc.Name = "butCalc";
            this.butCalc.Size = new System.Drawing.Size(87, 27);
            this.butCalc.TabIndex = 3;
            this.butCalc.Text = "&Calculate";
            this.butCalc.UseVisualStyleBackColor = true;
            this.butCalc.Click += new System.EventHandler(this.butCalc_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 483);
            this.Controls.Add(this.butCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.graph1);
            this.Name = "Mainform";
            this.Text = "Grapher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EquationGrapher.Graph graph1;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCalc;
    }
}

