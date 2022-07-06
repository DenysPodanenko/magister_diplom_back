namespace FuzzyGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbVarsAndRules = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValues = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbVarsAndRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVarsAndRules
            // 
            this.tbVarsAndRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVarsAndRules.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbVarsAndRules.AutoScrollMinSize = new System.Drawing.Size(762, 392);
            this.tbVarsAndRules.BackBrush = null;
            this.tbVarsAndRules.CharHeight = 14;
            this.tbVarsAndRules.CharWidth = 8;
            this.tbVarsAndRules.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVarsAndRules.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbVarsAndRules.IsReplaceMode = false;
            this.tbVarsAndRules.Location = new System.Drawing.Point(12, 27);
            this.tbVarsAndRules.Name = "tbVarsAndRules";
            this.tbVarsAndRules.Paddings = new System.Windows.Forms.Padding(0);
            this.tbVarsAndRules.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbVarsAndRules.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbVarsAndRules.ServiceColors")));
            this.tbVarsAndRules.ShowLineNumbers = false;
            this.tbVarsAndRules.Size = new System.Drawing.Size(826, 150);
            this.tbVarsAndRules.TabIndex = 0;
            this.tbVarsAndRules.Text = resources.GetString("tbVarsAndRules.Text");
            this.tbVarsAndRules.Zoom = 100;
            this.tbVarsAndRules.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variables and rules";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Values";
            // 
            // tbValues
            // 
            this.tbValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValues.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbValues.AutoScrollMinSize = new System.Drawing.Size(314, 14);
            this.tbValues.BackBrush = null;
            this.tbValues.CharHeight = 14;
            this.tbValues.CharWidth = 8;
            this.tbValues.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbValues.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbValues.IsReplaceMode = false;
            this.tbValues.Location = new System.Drawing.Point(12, 207);
            this.tbValues.Multiline = false;
            this.tbValues.Name = "tbValues";
            this.tbValues.Paddings = new System.Windows.Forms.Padding(0);
            this.tbValues.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbValues.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbValues.ServiceColors")));
            this.tbValues.ShowLineNumbers = false;
            this.tbValues.ShowScrollBars = false;
            this.tbValues.Size = new System.Drawing.Size(808, 20);
            this.tbValues.TabIndex = 2;
            this.tbValues.Text = "X1: -2  X2: 7  X3: -8  X4: 1.75  X5: 17";
            this.tbValues.Zoom = 100;
            this.tbValues.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tb_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbResult.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.tbResult.BackBrush = null;
            this.tbResult.CharHeight = 14;
            this.tbResult.CharWidth = 8;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbResult.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbResult.IsReplaceMode = false;
            this.tbResult.Location = new System.Drawing.Point(12, 301);
            this.tbResult.Name = "tbResult";
            this.tbResult.Paddings = new System.Windows.Forms.Padding(0);
            this.tbResult.ReadOnly = true;
            this.tbResult.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbResult.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbResult.ServiceColors")));
            this.tbResult.ShowLineNumbers = false;
            this.tbResult.Size = new System.Drawing.Size(826, 67);
            this.tbResult.TabIndex = 4;
            this.tbResult.Zoom = 100;
            this.tbResult.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tb_TextChanged);
            // 
            // btCalc
            // 
            this.btCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCalc.Location = new System.Drawing.Point(728, 233);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(92, 33);
            this.btCalc.TabIndex = 6;
            this.btCalc.Text = "Calculate";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 382);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVarsAndRules);
            this.Name = "MainForm";
            this.Text = "Fuzzy calculator";
            ((System.ComponentModel.ISupportInitialize)(this.tbVarsAndRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox tbVarsAndRules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FastColoredTextBoxNS.FastColoredTextBox tbValues;
        private System.Windows.Forms.Label label3;
        private FastColoredTextBoxNS.FastColoredTextBox tbResult;
        private System.Windows.Forms.Button btCalc;
    }
}

