namespace ScrollBar_Demo
{
    partial class ScrollBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrollBar));
            this.tbHor = new System.Windows.Forms.TextBox();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.picEric = new System.Windows.Forms.PictureBox();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.tbVert = new System.Windows.Forms.TextBox();
            this.picEric2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEric2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHor
            // 
            this.tbHor.Location = new System.Drawing.Point(209, 264);
            this.tbHor.Name = "tbHor";
            this.tbHor.Size = new System.Drawing.Size(28, 20);
            this.tbHor.TabIndex = 1;
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(9, 287);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(431, 24);
            this.hScrollBar.TabIndex = 2;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll_1);
            // 
            // picEric
            // 
            this.picEric.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEric.BackgroundImage")));
            this.picEric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEric.Location = new System.Drawing.Point(272, 87);
            this.picEric.Name = "picEric";
            this.picEric.Size = new System.Drawing.Size(165, 132);
            this.picEric.TabIndex = 3;
            this.picEric.TabStop = false;
            this.picEric.Visible = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(9, 3);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(28, 284);
            this.vScrollBar.TabIndex = 4;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // tbVert
            // 
            this.tbVert.Location = new System.Drawing.Point(40, 134);
            this.tbVert.Name = "tbVert";
            this.tbVert.Size = new System.Drawing.Size(29, 20);
            this.tbVert.TabIndex = 1;
            this.tbVert.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // picEric2
            // 
            this.picEric2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEric2.BackgroundImage")));
            this.picEric2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEric2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEric2.Location = new System.Drawing.Point(110, 3);
            this.picEric2.Name = "picEric2";
            this.picEric2.Size = new System.Drawing.Size(156, 136);
            this.picEric2.TabIndex = 5;
            this.picEric2.TabStop = false;
            this.picEric2.Visible = false;
            // 
            // ScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 320);
            this.Controls.Add(this.picEric2);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.picEric);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.tbVert);
            this.Controls.Add(this.tbHor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ScrollBar";
            this.Text = "Scroll Bar Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbHor;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.PictureBox picEric;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.TextBox tbVert;
        private System.Windows.Forms.PictureBox picEric2;
    }
}

