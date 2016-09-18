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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.wowhead_cbSite = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wowhead_cbParseSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wowhead_nudID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.wowhead_tbBonuses = new System.Windows.Forms.TextBox();
            this.buttonGetXML = new System.Windows.Forms.Button();
            this.wowhead_textboxOutput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.wowdb_cbSite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wowdb_nudID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.wowdb_tbBonuses = new System.Windows.Forms.TextBox();
            this.buttonGetJSON = new System.Windows.Forms.Button();
            this.wowdb_textboxOutput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wowhead_nudID)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wowdb_nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 424);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.wowhead_cbSite);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.wowhead_cbParseSource);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.wowhead_nudID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.wowhead_tbBonuses);
            this.tabPage1.Controls.Add(this.buttonGetXML);
            this.tabPage1.Controls.Add(this.wowhead_textboxOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wowhead";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Site";
            // 
            // wowhead_cbSite
            // 
            this.wowhead_cbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wowhead_cbSite.FormattingEnabled = true;
            this.wowhead_cbSite.Items.AddRange(new object[] {
            "Live",
            "PTR",
            "Beta",
            "Legion"});
            this.wowhead_cbSite.Location = new System.Drawing.Point(9, 124);
            this.wowhead_cbSite.Name = "wowhead_cbSite";
            this.wowhead_cbSite.Size = new System.Drawing.Size(84, 21);
            this.wowhead_cbSite.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parse Source";
            // 
            // wowhead_cbParseSource
            // 
            this.wowhead_cbParseSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wowhead_cbParseSource.FormattingEnabled = true;
            this.wowhead_cbParseSource.Items.AddRange(new object[] {
            "Tooltip",
            "JSON",
            "Both"});
            this.wowhead_cbParseSource.Location = new System.Drawing.Point(9, 173);
            this.wowhead_cbParseSource.Name = "wowhead_cbParseSource";
            this.wowhead_cbParseSource.Size = new System.Drawing.Size(84, 21);
            this.wowhead_cbParseSource.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bonuses";
            // 
            // wowhead_nudID
            // 
            this.wowhead_nudID.Location = new System.Drawing.Point(9, 25);
            this.wowhead_nudID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.wowhead_nudID.Name = "wowhead_nudID";
            this.wowhead_nudID.Size = new System.Drawing.Size(84, 20);
            this.wowhead_nudID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Item ID";
            // 
            // wowhead_tbBonuses
            // 
            this.wowhead_tbBonuses.Location = new System.Drawing.Point(9, 74);
            this.wowhead_tbBonuses.Name = "wowhead_tbBonuses";
            this.wowhead_tbBonuses.Size = new System.Drawing.Size(84, 20);
            this.wowhead_tbBonuses.TabIndex = 11;
            this.wowhead_tbBonuses.WordWrap = false;
            // 
            // buttonGetXML
            // 
            this.buttonGetXML.Location = new System.Drawing.Point(9, 209);
            this.buttonGetXML.Name = "buttonGetXML";
            this.buttonGetXML.Size = new System.Drawing.Size(75, 23);
            this.buttonGetXML.TabIndex = 16;
            this.buttonGetXML.Text = "Get XML";
            this.buttonGetXML.UseVisualStyleBackColor = true;
            this.buttonGetXML.Click += new System.EventHandler(this.buttonGetXML_Click);
            // 
            // wowhead_textboxOutput
            // 
            this.wowhead_textboxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wowhead_textboxOutput.Location = new System.Drawing.Point(111, 6);
            this.wowhead_textboxOutput.MaxLength = 1000000;
            this.wowhead_textboxOutput.Multiline = true;
            this.wowhead_textboxOutput.Name = "wowhead_textboxOutput";
            this.wowhead_textboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wowhead_textboxOutput.Size = new System.Drawing.Size(510, 389);
            this.wowhead_textboxOutput.TabIndex = 1;
            this.wowhead_textboxOutput.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.wowdb_cbSite);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.wowdb_nudID);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.wowdb_tbBonuses);
            this.tabPage2.Controls.Add(this.buttonGetJSON);
            this.tabPage2.Controls.Add(this.wowdb_textboxOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WoW DB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Site";
            // 
            // wowdb_cbSite
            // 
            this.wowdb_cbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wowdb_cbSite.FormattingEnabled = true;
            this.wowdb_cbSite.Items.AddRange(new object[] {
            "Live",
            "PTR",
            "Beta",
            "Legion"});
            this.wowdb_cbSite.Location = new System.Drawing.Point(9, 123);
            this.wowdb_cbSite.Name = "wowdb_cbSite";
            this.wowdb_cbSite.Size = new System.Drawing.Size(84, 21);
            this.wowdb_cbSite.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bonuses";
            // 
            // wowdb_nudID
            // 
            this.wowdb_nudID.Location = new System.Drawing.Point(9, 24);
            this.wowdb_nudID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.wowdb_nudID.Name = "wowdb_nudID";
            this.wowdb_nudID.Size = new System.Drawing.Size(84, 20);
            this.wowdb_nudID.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Item ID";
            // 
            // wowdb_tbBonuses
            // 
            this.wowdb_tbBonuses.Location = new System.Drawing.Point(9, 73);
            this.wowdb_tbBonuses.Name = "wowdb_tbBonuses";
            this.wowdb_tbBonuses.Size = new System.Drawing.Size(84, 20);
            this.wowdb_tbBonuses.TabIndex = 21;
            this.wowdb_tbBonuses.WordWrap = false;
            // 
            // buttonGetJSON
            // 
            this.buttonGetJSON.Location = new System.Drawing.Point(9, 208);
            this.buttonGetJSON.Name = "buttonGetJSON";
            this.buttonGetJSON.Size = new System.Drawing.Size(75, 23);
            this.buttonGetJSON.TabIndex = 26;
            this.buttonGetJSON.Text = "Get JSON";
            this.buttonGetJSON.UseVisualStyleBackColor = true;
            this.buttonGetJSON.Click += new System.EventHandler(this.buttonGetJSON_Click);
            // 
            // wowdb_textboxOutput
            // 
            this.wowdb_textboxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wowdb_textboxOutput.Location = new System.Drawing.Point(111, 5);
            this.wowdb_textboxOutput.MaxLength = 1000000;
            this.wowdb_textboxOutput.Multiline = true;
            this.wowdb_textboxOutput.Name = "wowdb_textboxOutput";
            this.wowdb_textboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wowdb_textboxOutput.Size = new System.Drawing.Size(510, 389);
            this.wowdb_textboxOutput.TabIndex = 19;
            this.wowdb_textboxOutput.TabStop = false;
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExampleForm";
            this.Text = "WoW Database Sites API Item Importer Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wowhead_nudID)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wowdb_nudID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wowhead_cbSite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox wowhead_cbParseSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown wowhead_nudID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wowhead_tbBonuses;
        private System.Windows.Forms.Button buttonGetXML;
        private System.Windows.Forms.TextBox wowhead_textboxOutput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wowdb_cbSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown wowdb_nudID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wowdb_tbBonuses;
        private System.Windows.Forms.Button buttonGetJSON;
        private System.Windows.Forms.TextBox wowdb_textboxOutput;

    }
}

