namespace Face_Detection
{
    partial class faceDetectfrm
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
            this.components = new System.ComponentModel.Container();
            this.startBttn = new System.Windows.Forms.Button();
            this.camImageBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.camImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(12, 407);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(75, 23);
            this.startBttn.TabIndex = 3;
            this.startBttn.Text = "Start";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.startBttn_Click);
            // 
            // camImageBox
            // 
            this.camImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camImageBox.Location = new System.Drawing.Point(12, 12);
            this.camImageBox.Name = "camImageBox";
            this.camImageBox.Size = new System.Drawing.Size(774, 389);
            this.camImageBox.TabIndex = 2;
            this.camImageBox.TabStop = false;
            // 
            // faceDetectfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 459);
            this.Controls.Add(this.camImageBox);
            this.Controls.Add(this.startBttn);
            this.Name = "faceDetectfrm";
            this.Text = "Face Detection";
            this.Load += new System.EventHandler(this.faceDetectfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startBttn;
        private Emgu.CV.UI.ImageBox camImageBox;
    }
}

