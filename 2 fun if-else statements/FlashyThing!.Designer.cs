namespace _2_fun_if_else_statements
{
    partial class FlashyThing_
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
            this.picGoM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGoM)).BeginInit();
            this.SuspendLayout();
            // 
            // picGoM
            // 
            this.picGoM.Image = global::_2_fun_if_else_statements.Properties.Resources.fotoo;
            this.picGoM.Location = new System.Drawing.Point(87, 48);
            this.picGoM.Name = "picGoM";
            this.picGoM.Size = new System.Drawing.Size(111, 115);
            this.picGoM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoM.TabIndex = 0;
            this.picGoM.TabStop = false;
            this.picGoM.Click += new System.EventHandler(this.picGoM_Click);
            // 
            // FlashyThing_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 233);
            this.Controls.Add(this.picGoM);
            this.MaximizeBox = false;
            this.Name = "FlashyThing_";
            this.Text = "FlashyThing_";
            ((System.ComponentModel.ISupportInitialize)(this.picGoM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGoM;
    }
}