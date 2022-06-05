namespace MyCalculator
{
    partial class Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamber1 = new System.Windows.Forms.NumericUpDown();
            this.txtNamber2 = new System.Windows.Forms.NumericUpDown();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmultiple = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "عدد دوم :";
            // 
            // txtNamber1
            // 
            this.txtNamber1.Location = new System.Drawing.Point(75, 22);
            this.txtNamber1.Name = "txtNamber1";
            this.txtNamber1.Size = new System.Drawing.Size(337, 23);
            this.txtNamber1.TabIndex = 2;
            this.txtNamber1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtNamber2
            // 
            this.txtNamber2.Location = new System.Drawing.Point(75, 68);
            this.txtNamber2.Name = "txtNamber2";
            this.txtNamber2.Size = new System.Drawing.Size(337, 23);
            this.txtNamber2.TabIndex = 3;
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.AliceBlue;
            this.btnplus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnplus.Location = new System.Drawing.Point(331, 112);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(81, 37);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.AliceBlue;
            this.btnminus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnminus.Location = new System.Drawing.Point(244, 112);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(81, 37);
            this.btnminus.TabIndex = 5;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmultiple
            // 
            this.btnmultiple.BackColor = System.Drawing.Color.AliceBlue;
            this.btnmultiple.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnmultiple.Location = new System.Drawing.Point(157, 112);
            this.btnmultiple.Name = "btnmultiple";
            this.btnmultiple.Size = new System.Drawing.Size(81, 37);
            this.btnmultiple.TabIndex = 6;
            this.btnmultiple.Text = "*";
            this.btnmultiple.UseVisualStyleBackColor = false;
            this.btnmultiple.Click += new System.EventHandler(this.btnmultiple_Click);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.AliceBlue;
            this.btndivide.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btndivide.Location = new System.Drawing.Point(70, 112);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(81, 37);
            this.btndivide.TabIndex = 7;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = false;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 171);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmultiple);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtNamber2);
            this.Controls.Add(this.txtNamber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNamber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNamber1;
        private System.Windows.Forms.NumericUpDown txtNamber2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmultiple;
        private System.Windows.Forms.Button btndivide;
    }
}

