namespace _2_fun_if_else_statements
{
    partial class FunWith
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
            this.chkCor = new System.Windows.Forms.CheckBox();
            this.lblchenge = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.lblEnable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkCor
            // 
            this.chkCor.AutoSize = true;
            this.chkCor.Location = new System.Drawing.Point(214, 41);
            this.chkCor.Name = "chkCor";
            this.chkCor.Size = new System.Drawing.Size(15, 14);
            this.chkCor.TabIndex = 0;
            this.chkCor.UseVisualStyleBackColor = true;
            this.chkCor.CheckedChanged += new System.EventHandler(this.chkCor_CheckedChanged);
            // 
            // lblchenge
            // 
            this.lblchenge.AutoSize = true;
            this.lblchenge.BackColor = System.Drawing.Color.Red;
            this.lblchenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchenge.Location = new System.Drawing.Point(12, 85);
            this.lblchenge.Name = "lblchenge";
            this.lblchenge.Size = new System.Drawing.Size(298, 20);
            this.lblchenge.TabIndex = 1;
            this.lblchenge.Text = "Press the button to chenge my color";
            this.lblchenge.Click += new System.EventHandler(this.lblchenge_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.Location = new System.Drawing.Point(12, 10);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(184, 72);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Change the color if the box is checked";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnable.Location = new System.Drawing.Point(235, 41);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(151, 15);
            this.lblEnable.TabIndex = 3;
            this.lblEnable.Text = "Enable color changing";
            // 
            // FunWith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 114);
            this.Controls.Add(this.lblEnable);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblchenge);
            this.Controls.Add(this.chkCor);
            this.Name = "FunWith";
            this.Text = "Fun with if/else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCor;
        private System.Windows.Forms.Label lblchenge;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Label lblEnable;
    }
}

