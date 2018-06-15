/* Copyright (c) 2016 Acrolinx GmbH */

using Acrolinx.Sdk.Sidebar;
using Acrolinx.Sdk.Sidebar.Documents;
using Acrolinx.Sdk.Sidebar.Util.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acrolinx.Demo.Sidebar
{
    /// <summary>
    /// This example shows the minimal effort for a POC.The select and replace functionallity will fail if the text is changed.
    /// Please see the properties, events and functions of the <see cref="AcrolinxSidebar"/> control.
    /// See: <see cref="MultiSample"/> for examples of how to deal with changes and multiple input fields.
    /// </summary>
    public partial class SimpleSample : Form
    {
        public SimpleSample() : this( Format.Auto, "your_file_name.htm", "<body>" +Environment.NewLine + "   <h1> This is a header without dot </h1>" + Environment.NewLine + "    <div>This is an simple sample tesst</div>" + Environment.NewLine + "</body>")
        {
            
        }

        public SimpleSample(Format format, string documentReference, string text)
        {
            InitializeComponent();

            FillFormatList();

            formatComboBox.SelectedItem = format;
            this.documentReferenceTextBox.Text = documentReference;
            this.textBox.Text = text;
            this.Text += " - " + documentReference;

            acrolinxSidebar.Start();
        }

        private void FillFormatList()
        {
            foreach (Format f in Enum.GetValues(typeof(Format)))
            {
                formatComboBox.Items.Add(f);
            }
        }

        private void acrolinxSidebar_RequestCheck(object sender, CheckRequestedEventArgs e)
        {
            Logger.AcroLog.Info("acrolinxSidebar_RequestCheck");

            var document = new Document();
            document.Content = textBox.Text;
            document.Format = (Format)formatComboBox.SelectedItem;
            document.Reference = documentReferenceTextBox.Text;

            if (e.Options.Selection)
            {
                document.Selections = GetSelection();
            }

            acrolinxSidebar.Check(document);
        }

        private IReadOnlyList<IRange> GetSelection()
        {
            var selections = new List<IRange>();
            selections.Add(new Range(textBox.SelectionStart, textBox.SelectionStart + textBox.SelectionLength));
            return selections;
        }

        private void acrolinxSidebar_InitFinished(object sender, EventArgs e)
        {
            Logger.AcroLog.Info("acrolinxSidebar_InitFinished");
        }

        private void acrolinxSidebar_Checked(object sender, Sdk.Sidebar.CheckedEventArgs e)
        {
            Logger.AcroLog.Info("acrolinxSidebar_Checked");
        }

        private void acrolinxSidebar_SidebarSourceNotReachable(object sender, EventArgs e)
        {
            Logger.AcroLog.Info("acrolinxSidebar_SidebarSourceNotReachable");

            acrolinxSidebar.Start(); //retry
        }

        private void acrolinxSidebar_SelectRanges(object sender, Sdk.Sidebar.MatchesEventArgs e)
        {
            Logger.AcroLog.Info("acrolinxSidebar_SelectRanges");

            SelectWholeRange(e.CheckId, e.Matches);
        }

        private void SelectWholeRange(string checkId, IReadOnlyList<Match> matches)
        {
            try
            {
                var range = new Range(matches[0].Range.Start, matches[matches.Count - 1].Range.End);
                textBox.Select(range.Start, range.Length);
                textBox.ScrollToCaret();
                textBox.Focus();
                if (!(textBox.SelectedText.StartsWith(matches[0].Content) && textBox.SelectedText.EndsWith(matches[matches.Count - 1].Content)))
                {
                    acrolinxSidebar.InvalidateRanges(checkId, matches);
                    textBox.Select(textBox.SelectionStart, 0);
                }
            }
            catch (Exception)
            {
                acrolinxSidebar.InvalidateRanges(checkId, matches);
            }
        }

        private void acrolinxSidebar_ReplaceRanges(object sender, Sdk.Sidebar.MatchesWithReplacementEventArgs e)
        {
            Logger.AcroLog.Info("acrolinxSidebar_ReplaceRanges");

            SelectWholeRange(e.CheckId, e.Matches);
            if (textBox.SelectionLength > 0)
            {
                textBox.SelectedText = string.Join("", e.Matches.Select(m => m.Replacement));
            }
        }
    }
}
