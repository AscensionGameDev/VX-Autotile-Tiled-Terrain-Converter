namespace Multi_Purpose_Graphic_Splitter
{
    partial class frmMain
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.inverseBox = new System.Windows.Forms.CheckBox();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSampleImg = new System.Windows.Forms.Panel();
            this.grpStep1.SuspendLayout();
            this.grpStep2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(86, 58);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(871, 26);
            this.txtSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the source tileset here that contains your autotile(s).";
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseSource.Location = new System.Drawing.Point(968, 55);
            this.btnChooseSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(104, 35);
            this.btnChooseSource.TabIndex = 2;
            this.btnChooseSource.Text = "Browse";
            this.btnChooseSource.UseVisualStyleBackColor = true;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source:";
            // 
            // grpStep1
            // 
            this.grpStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStep1.Controls.Add(this.inverseBox);
            this.grpStep1.Controls.Add(this.label1);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.txtSource);
            this.grpStep1.Controls.Add(this.btnChooseSource);
            this.grpStep1.Location = new System.Drawing.Point(18, 18);
            this.grpStep1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStep1.Size = new System.Drawing.Size(1080, 103);
            this.grpStep1.TabIndex = 4;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "Step 1";
            // 
            // inverseBox
            // 
            this.inverseBox.AutoSize = true;
            this.inverseBox.Location = new System.Drawing.Point(984, 23);
            this.inverseBox.Name = "inverseBox";
            this.inverseBox.Size = new System.Drawing.Size(87, 24);
            this.inverseBox.TabIndex = 4;
            this.inverseBox.Text = "Inverse";
            this.inverseBox.UseVisualStyleBackColor = true;
            // 
            // grpStep2
            // 
            this.grpStep2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStep2.Controls.Add(this.label3);
            this.grpStep2.Controls.Add(this.panel1);
            this.grpStep2.Location = new System.Drawing.Point(18, 131);
            this.grpStep2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStep2.Size = new System.Drawing.Size(1080, 658);
            this.grpStep2.TabIndex = 5;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "Step 2";
            this.grpStep2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1062, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Double click on the top-left most part of the autotile you want to convert.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnlSampleImg);
            this.panel1.Location = new System.Drawing.Point(14, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 574);
            this.panel1.TabIndex = 3;
            // 
            // pnlSampleImg
            // 
            this.pnlSampleImg.AutoScroll = true;
            this.pnlSampleImg.Location = new System.Drawing.Point(0, 0);
            this.pnlSampleImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSampleImg.Name = "pnlSampleImg";
            this.pnlSampleImg.Size = new System.Drawing.Size(518, 358);
            this.pnlSampleImg.TabIndex = 2;
            this.pnlSampleImg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlSampleImg_MouseDoubleClick);
            this.pnlSampleImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSampleImg_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 802);
            this.Controls.Add(this.grpStep2);
            this.Controls.Add(this.grpStep1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(586, 607);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ascension Game Dev VX Autotile to Tiled Terrain Converter (and back!)";
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.grpStep2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.Panel pnlSampleImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox inverseBox;
    }
}

