using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace psm
{
    public partial class frmMain : Form
    {

        private string[] PdfFiles;
        private string PdfFile;

        public frmMain()
        {
            InitializeComponent();
        }
        
        private void CombineFiles(string[] pdfFiles, string newFileName)
        {
            
            PdfDocument outputDocument = new PdfDocument();

            foreach (string file in pdfFiles)
            {
                if (file.IndexOf(".pdf") > 0)
                {
                    PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import);

                    int count = inputDocument.PageCount;

                    for (int idx = 0; idx < count; idx++)
                    {
                        PdfPage page = inputDocument.Pages[idx];
                        outputDocument.AddPage(page);
                    }
                }
            }

            try
            {
                outputDocument.Save(newFileName);

                Process.Start(newFileName);

            }
            catch (InvalidOperationException e)
            {

                MessageBox.Show($"{e.Message}");
            }
        }


        private string[] openFilesButton()
        {
            string[] pdfFiles = { };
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfFiles = openFileDialog.FileNames;
                }
            }

            return pdfFiles;
        }

        private string openFileButton()
        {
            string fileName = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }

            return fileName;
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            PdfFiles = openFilesButton();
            tbFiles2Combine.Text = String.Join("\r\n", PdfFiles);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbSaveFileName.Text = saveFileDialog.FileName;

                    CombineFiles(PdfFiles, tbSaveFileName.Text);

                    MessageBox.Show($"Combined files saved as {tbSaveFileName.Text}");
                }
            }
            
        }

        private void btnToSplit_Click(object sender, EventArgs e)
        {
            PdfFile = openFileButton();
            tbFile2Split.Text = PdfFile;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string targetFileName = "";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    targetFileName = saveFileDialog.FileName;

                    if (PdfFile.IndexOf(".pdf") > 0)
                    {
                        List<string> splittedFiles = SplitFile(PdfFile, targetFileName);
                        if (splittedFiles != null)
                        {
                            tbSplitFiles.Text = string.Join("\r\n", splittedFiles);
                            MessageBox.Show("Complete!");
                        }
                    }
                }
            }

        }


        private List<string> SplitFile(string fileName2split, string newFileName)
        {
            PdfDocument inputDocument = PdfReader.Open(fileName2split, PdfDocumentOpenMode.Import);

            int count = inputDocument.PageCount;

            List<string> outputFiles = new List<string>();

            if (count > 0)
            {
                for (int idx = 0; idx < count; idx++)
                {
                    PdfPage page = inputDocument.Pages[idx];
                    PdfDocument outputDocument = new PdfDocument();
                    outputDocument.AddPage(page);
                    string splitFileName = newFileName.Replace(".pdf", $"-{idx}.pdf");
                    outputFiles.Add(splitFileName);
                    outputDocument.Save(splitFileName);
                }

                return outputFiles;
            }
            else
            {
                MessageBox.Show("There is 0 page in this file to split!");
                return null;
            }
        }

    }

}
    

