﻿/* Copyright (c) 2016 Acrolinx GmbH */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Acrolinx.Sdk.Sidebar.Documents;


namespace Acrolinx.Demo.Sidebar
{
    public partial class Sample : Form
    {
        private int childFormNumber = 0;

        public Sample()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void simpleSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var simple = new SimpleSample();
            simple.MdiParent = this;
            simple.Show();
        }

        private void multiSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var multi = new MultiSample();
            multi.MdiParent = this;
            multi.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                LoadFiles(openFileDialog.FileNames);
            }
        }

        private void LoadFiles(ICollection<string> files)
        {
            foreach (var fileName in files)
            {
                try
                {
                    var simple = new SimpleSample(Format.Auto, fileName, File.ReadAllText(fileName));
                    simple.MdiParent = this;
                    simple.Show();
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, "Failed to load '" + fileName + "':" + Environment.NewLine + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Sample_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            var dropped = ((string[])e.Data.GetData(DataFormats.FileDrop));
            var files = dropped.ToList();
            LoadFiles(files);
        }

        private void Sample_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
