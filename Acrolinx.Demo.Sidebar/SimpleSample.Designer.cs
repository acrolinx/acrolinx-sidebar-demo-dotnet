/* Copyright (c) 2016 Acrolinx GmbH */

namespace Acrolinx.Demo.Sidebar
{
    partial class SimpleSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleSample));
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showMessage = new System.Windows.Forms.Button();
            this.documentReferenceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.acrolinxSidebar = new Acrolinx.Sdk.Sidebar.AcrolinxSidebar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.MaxLength = 0;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(824, 459);
            this.textBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showMessage);
            this.panel1.Controls.Add(this.documentReferenceTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelWarning);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.formatComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 84);
            this.panel1.TabIndex = 3;
            // 
            // showMessage
            // 
            this.showMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showMessage.Location = new System.Drawing.Point(829, 41);
            this.showMessage.Name = "showMessage";
            this.showMessage.Size = new System.Drawing.Size(195, 32);
            this.showMessage.TabIndex = 9;
            this.showMessage.Text = "Show Message Demo";
            this.showMessage.UseVisualStyleBackColor = true;
            this.showMessage.Click += new System.EventHandler(this.showMessage_Click);
            // 
            // documentReferenceTextBox
            // 
            this.documentReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentReferenceTextBox.Location = new System.Drawing.Point(427, 4);
            this.documentReferenceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.documentReferenceTextBox.Name = "documentReferenceTextBox";
            this.documentReferenceTextBox.Size = new System.Drawing.Size(767, 22);
            this.documentReferenceTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Document Reference:";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(16, 41);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(39, 16);
            this.labelWarning.TabIndex = 6;
            this.labelWarning.Text = "Note:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMessage.Location = new System.Drawing.Point(76, 41);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(676, 32);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = resources.GetString("labelMessage.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Format:";
            // 
            // formatComboBox
            // 
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(80, 4);
            this.formatComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(180, 24);
            this.formatComboBox.TabIndex = 3;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 84);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.textBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.acrolinxSidebar);
            this.splitContainer.Size = new System.Drawing.Size(1211, 459);
            this.splitContainer.SplitterDistance = 824;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 7;
            // 
            // acrolinxSidebar
            // 
            this.acrolinxSidebar.ClientLocale = "";
            this.acrolinxSidebar.ClientSignature = "SW50ZWdyYXRpb25EZXZlbG9wbWVudERlbW9Pbmx5";
            this.acrolinxSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acrolinxSidebar.Location = new System.Drawing.Point(0, 0);
            this.acrolinxSidebar.Margin = new System.Windows.Forms.Padding(5);
            this.acrolinxSidebar.Name = "acrolinxSidebar";
            this.acrolinxSidebar.Size = new System.Drawing.Size(382, 459);
            this.acrolinxSidebar.SupportCheckSelection = true;
            this.acrolinxSidebar.TabIndex = 0;
            this.acrolinxSidebar.InitFinished += new Acrolinx.Sdk.Sidebar.SidebarInitFinishedEventHandler(this.acrolinxSidebar_InitFinished);
            this.acrolinxSidebar.SidebarSourceNotReachable += new Acrolinx.Sdk.Sidebar.SidebarSourceNotReachableEventHandler(this.acrolinxSidebar_SidebarSourceNotReachable);
            this.acrolinxSidebar.Checked += new Acrolinx.Sdk.Sidebar.SidebarCheckedEventHandler(this.acrolinxSidebar_Checked);
            this.acrolinxSidebar.RequestCheck += new Acrolinx.Sdk.Sidebar.SidebarCheckRequestedEventHandler(this.acrolinxSidebar_RequestCheck);
            this.acrolinxSidebar.SelectRanges += new Acrolinx.Sdk.Sidebar.SidebarSelectRangesEventHandler(this.acrolinxSidebar_SelectRanges);
            this.acrolinxSidebar.ReplaceRanges += new Acrolinx.Sdk.Sidebar.SidebarReplaceRangesEventHandler(this.acrolinxSidebar_ReplaceRanges);
            // 
            // SimpleSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 543);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimpleSample";
            this.Text = "Acrolinx Sidebar .NET Simple";
            this.Load += new System.EventHandler(this.SimpleSample_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sdk.Sidebar.AcrolinxSidebar acrolinxSidebar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documentReferenceTextBox;
        private System.Windows.Forms.Button showMessage;
    }
}