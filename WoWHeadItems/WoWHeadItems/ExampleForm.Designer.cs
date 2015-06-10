namespace WoWHeadItems
{
    partial class ExampleForm
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
            this.textboxOutput = new System.Windows.Forms.TextBox();
            this.buttonGetXML = new System.Windows.Forms.Button();
            this.tbBonuses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParseSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxOutput
            // 
            this.textboxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxOutput.Location = new System.Drawing.Point(105, 0);
            this.textboxOutput.MaxLength = 1000000;
            this.textboxOutput.Multiline = true;
            this.textboxOutput.Name = "textboxOutput";
            this.textboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textboxOutput.Size = new System.Drawing.Size(554, 448);
            this.textboxOutput.TabIndex = 0;
            this.textboxOutput.TabStop = false;
            // 
            // buttonGetXML
            // 
            this.buttonGetXML.Location = new System.Drawing.Point(15, 213);
            this.buttonGetXML.Name = "buttonGetXML";
            this.buttonGetXML.Size = new System.Drawing.Size(75, 23);
            this.buttonGetXML.TabIndex = 5;
            this.buttonGetXML.Text = "Get XML";
            this.buttonGetXML.UseVisualStyleBackColor = true;
            this.buttonGetXML.Click += new System.EventHandler(this.buttonGetXML_Click);
            // 
            // tbBonuses
            // 
            this.tbBonuses.Location = new System.Drawing.Point(15, 78);
            this.tbBonuses.Name = "tbBonuses";
            this.tbBonuses.Size = new System.Drawing.Size(84, 20);
            this.tbBonuses.TabIndex = 2;
            this.tbBonuses.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item ID";
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(15, 29);
            this.nudID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(84, 20);
            this.nudID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bonuses";
            // 
            // cbParseSource
            // 
            this.cbParseSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParseSource.FormattingEnabled = true;
            this.cbParseSource.Items.AddRange(new object[] {
            "Tooltip",
            "JSON",
            "Both"});
            this.cbParseSource.Location = new System.Drawing.Point(15, 177);
            this.cbParseSource.Name = "cbParseSource";
            this.cbParseSource.Size = new System.Drawing.Size(84, 21);
            this.cbParseSource.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parse Source";
            // 
            // cbSite
            // 
            this.cbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Items.AddRange(new object[] {
            "Live",
            "PTR",
            "Beta"});
            this.cbSite.Location = new System.Drawing.Point(15, 128);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(84, 21);
            this.cbSite.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Site";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbParseSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBonuses);
            this.Controls.Add(this.buttonGetXML);
            this.Controls.Add(this.textboxOutput);
            this.Name = "Form1";
            this.Text = "WoWHead Item XML Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxOutput;
        private System.Windows.Forms.Button buttonGetXML;
        private System.Windows.Forms.TextBox tbBonuses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParseSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label label4;
    }
}

