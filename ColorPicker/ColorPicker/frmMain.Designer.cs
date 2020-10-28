namespace ColorPicker
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.chkColor1 = new System.Windows.Forms.CheckBox();
            this.chkColor3 = new System.Windows.Forms.CheckBox();
            this.chkColor2 = new System.Windows.Forms.CheckBox();
            this.chkColor4 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtColorName = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(881, 442);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.Red;
            this.txtRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.ForeColor = System.Drawing.Color.White;
            this.txtRed.Location = new System.Drawing.Point(13, 8);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(37, 20);
            this.txtRed.TabIndex = 0;
            this.txtRed.Text = "255";
            this.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RedBar
            // 
            this.RedBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.RedBar.Location = new System.Drawing.Point(17, -3);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RedBar.Size = new System.Drawing.Size(45, 404);
            this.RedBar.TabIndex = 0;
            this.RedBar.TickFrequency = 10;
            this.RedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedBar.Value = 255;
            this.RedBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Gray;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtBlue);
            this.splitContainer2.Panel1.Controls.Add(this.txtGreen);
            this.splitContainer2.Panel1.Controls.Add(this.txtRed);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.BlueBar);
            this.splitContainer2.Panel2.Controls.Add(this.GreenBar);
            this.splitContainer2.Panel2.Controls.Add(this.RedBar);
            this.splitContainer2.Size = new System.Drawing.Size(153, 438);
            this.splitContainer2.SplitterDistance = 30;
            this.splitContainer2.TabIndex = 0;
            // 
            // GreenBar
            // 
            this.GreenBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.GreenBar.Location = new System.Drawing.Point(63, -3);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GreenBar.Size = new System.Drawing.Size(45, 404);
            this.GreenBar.TabIndex = 1;
            this.GreenBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenBar.Value = 255;
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.BlueBar.Location = new System.Drawing.Point(109, -3);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BlueBar.Size = new System.Drawing.Size(45, 404);
            this.BlueBar.TabIndex = 2;
            this.BlueBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueBar.Value = 255;
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.Color.Green;
            this.txtGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreen.ForeColor = System.Drawing.Color.White;
            this.txtGreen.Location = new System.Drawing.Point(56, 8);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(37, 20);
            this.txtGreen.TabIndex = 1;
            this.txtGreen.Text = "255";
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.Color.Blue;
            this.txtBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlue.ForeColor = System.Drawing.Color.White;
            this.txtBlue.Location = new System.Drawing.Point(99, 8);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(37, 20);
            this.txtBlue.TabIndex = 1;
            this.txtBlue.Text = "255";
            this.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(716, 438);
            this.splitContainer3.SplitterDistance = 349;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.TabStop = false;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.White;
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.chkColor1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.chkColor3);
            this.splitContainer4.Size = new System.Drawing.Size(349, 438);
            this.splitContainer4.SplitterDistance = 208;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.TabStop = false;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BackColor = System.Drawing.Color.White;
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.chkColor2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer5.Panel2.Controls.Add(this.chkColor4);
            this.splitContainer5.Size = new System.Drawing.Size(363, 438);
            this.splitContainer5.SplitterDistance = 209;
            this.splitContainer5.TabIndex = 0;
            this.splitContainer5.TabStop = false;
            // 
            // chkColor1
            // 
            this.chkColor1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkColor1.Checked = true;
            this.chkColor1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColor1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkColor1.Location = new System.Drawing.Point(0, 187);
            this.chkColor1.Name = "chkColor1";
            this.chkColor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkColor1.Size = new System.Drawing.Size(345, 17);
            this.chkColor1.TabIndex = 0;
            this.chkColor1.TabStop = false;
            this.chkColor1.UseVisualStyleBackColor = false;
            // 
            // chkColor3
            // 
            this.chkColor3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkColor3.Checked = true;
            this.chkColor3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColor3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkColor3.Location = new System.Drawing.Point(0, 205);
            this.chkColor3.Name = "chkColor3";
            this.chkColor3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkColor3.Size = new System.Drawing.Size(345, 17);
            this.chkColor3.TabIndex = 1;
            this.chkColor3.TabStop = false;
            this.chkColor3.UseVisualStyleBackColor = false;
            // 
            // chkColor2
            // 
            this.chkColor2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkColor2.Checked = true;
            this.chkColor2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColor2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkColor2.Location = new System.Drawing.Point(0, 188);
            this.chkColor2.Name = "chkColor2";
            this.chkColor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkColor2.Size = new System.Drawing.Size(359, 17);
            this.chkColor2.TabIndex = 1;
            this.chkColor2.TabStop = false;
            this.chkColor2.UseVisualStyleBackColor = false;
            // 
            // chkColor4
            // 
            this.chkColor4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkColor4.Checked = true;
            this.chkColor4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColor4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkColor4.Location = new System.Drawing.Point(0, 204);
            this.chkColor4.Name = "chkColor4";
            this.chkColor4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkColor4.Size = new System.Drawing.Size(359, 17);
            this.chkColor4.TabIndex = 1;
            this.chkColor4.TabStop = false;
            this.chkColor4.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtColorName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(153, 22);
            this.toolStripLabel1.Text = "Enter Color Name (i.e. red) :";
            // 
            // txtColorName
            // 
            this.txtColorName.BackColor = System.Drawing.Color.White;
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(100, 25);
            this.txtColorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorName_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 442);
            this.panel1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.CheckBox chkColor1;
        private System.Windows.Forms.CheckBox chkColor3;
        private System.Windows.Forms.CheckBox chkColor2;
        private System.Windows.Forms.CheckBox chkColor4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtColorName;
        private System.Windows.Forms.Panel panel1;
    }
}

