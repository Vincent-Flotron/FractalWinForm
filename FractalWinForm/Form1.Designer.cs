
namespace FractalWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btZoom = new System.Windows.Forms.Button();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.tbUp = new System.Windows.Forms.TextBox();
            this.tbDown = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btUnzoom = new System.Windows.Forms.Button();
            this.tbZoomFactor = new System.Windows.Forms.TextBox();
            this.tbMotionFactor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 368);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(229, 439);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(113, 33);
            this.btLeft.TabIndex = 1;
            this.btLeft.Text = "Gauche";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(448, 440);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(113, 33);
            this.btRight.TabIndex = 2;
            this.btRight.Text = "Droite";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(337, 384);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(113, 33);
            this.btUp.TabIndex = 3;
            this.btUp.Text = "Haut";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Location = new System.Drawing.Point(337, 518);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(113, 33);
            this.btDown.TabIndex = 4;
            this.btDown.Text = "Bas";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btZoom
            // 
            this.btZoom.Location = new System.Drawing.Point(363, 423);
            this.btZoom.Name = "btZoom";
            this.btZoom.Size = new System.Drawing.Size(68, 32);
            this.btZoom.TabIndex = 5;
            this.btZoom.Text = "Zoom";
            this.btZoom.UseVisualStyleBackColor = true;
            this.btZoom.Click += new System.EventHandler(this.btZoom_Click);
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(22, 414);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(58, 23);
            this.tbLeft.TabIndex = 6;
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(86, 414);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(58, 23);
            this.tbRight.TabIndex = 7;
            // 
            // tbUp
            // 
            this.tbUp.Location = new System.Drawing.Point(150, 414);
            this.tbUp.Name = "tbUp";
            this.tbUp.Size = new System.Drawing.Size(58, 23);
            this.tbUp.TabIndex = 8;
            // 
            // tbDown
            // 
            this.tbDown.Location = new System.Drawing.Point(214, 414);
            this.tbDown.Name = "tbDown";
            this.tbDown.Size = new System.Drawing.Size(58, 23);
            this.tbDown.TabIndex = 9;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(22, 393);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(27, 15);
            this.lblLeft.TabIndex = 10;
            this.lblLeft.Text = "Left";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(86, 393);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(35, 15);
            this.lblRight.TabIndex = 11;
            this.lblRight.Text = "Right";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(150, 393);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(22, 15);
            this.lblUp.TabIndex = 12;
            this.lblUp.Text = "Up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Down";
            // 
            // btUnzoom
            // 
            this.btUnzoom.Location = new System.Drawing.Point(363, 480);
            this.btUnzoom.Name = "btUnzoom";
            this.btUnzoom.Size = new System.Drawing.Size(68, 32);
            this.btUnzoom.TabIndex = 14;
            this.btUnzoom.Text = "UnZoom";
            this.btUnzoom.UseVisualStyleBackColor = true;
            this.btUnzoom.Click += new System.EventHandler(this.btUnzoom_Click);
            // 
            // tbZoomFactor
            // 
            this.tbZoomFactor.Location = new System.Drawing.Point(368, 456);
            this.tbZoomFactor.Name = "tbZoomFactor";
            this.tbZoomFactor.Size = new System.Drawing.Size(58, 23);
            this.tbZoomFactor.TabIndex = 15;
            this.tbZoomFactor.Text = "1.1";
            // 
            // tbMotionFactor
            // 
            this.tbMotionFactor.Location = new System.Drawing.Point(229, 478);
            this.tbMotionFactor.Name = "tbMotionFactor";
            this.tbMotionFactor.Size = new System.Drawing.Size(58, 23);
            this.tbMotionFactor.TabIndex = 16;
            this.tbMotionFactor.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.tbMotionFactor);
            this.Controls.Add(this.tbZoomFactor);
            this.Controls.Add(this.btUnzoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.tbDown);
            this.Controls.Add(this.tbUp);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.btZoom);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btZoom;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.TextBox tbUp;
        private System.Windows.Forms.TextBox tbDown;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btUnzoom;
        private System.Windows.Forms.TextBox tbZoomFactor;
        private System.Windows.Forms.TextBox tbMotionFactor;
    }
}

