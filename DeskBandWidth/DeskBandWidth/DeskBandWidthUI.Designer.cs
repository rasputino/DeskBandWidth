namespace DeskBandWidth
{
    partial class DeskBandWidthUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUp = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.picGraph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(3, 0);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(18, 13);
            this.lblUp.TabIndex = 0;
            this.lblUp.Text = "U:";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(3, 15);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(18, 13);
            this.lblDown.TabIndex = 1;
            this.lblDown.Text = "D:";
            // 
            // picGraph
            // 
            this.picGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGraph.Location = new System.Drawing.Point(0, 0);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(200, 28);
            this.picGraph.TabIndex = 2;
            this.picGraph.TabStop = false;
            // 
            // DeskBandWidthUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblUp);
            this.Name = "DeskBandWidthUI";
            this.Size = new System.Drawing.Size(200, 28);
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.PictureBox picGraph;
    }
}
