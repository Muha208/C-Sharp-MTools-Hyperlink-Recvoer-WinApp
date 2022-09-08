using excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.CSharp.RuntimeBinder;
using System.Net;
using System;
using Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms.VisualStyles;

namespace Hyperlik_Recover
{
    public partial class Form1 : Form
    {
        excel.Application ex = null;
        Workbook workbook = null;
        Worksheet worksheet = null;
        excel.Range range = null;
        Workbooks wbs = null;
        Hyperlink Hy = null;
        OpenFileDialog ofd;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void dialgBotShow_Click(object sender, EventArgs e)
        {
            int sheetNumber = (int)SheetNoBox.Value;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataGridView2.Columns.Clear();
                string ColNo = "No";
                dataGridView2.Columns.Add(ColNo, ColNo);
                string ColNAme = "Hyperlink Cells";
                dataGridView2.Columns.Add(ColNAme, ColNAme);
                dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ofd.Filter = "Excel Files|*.xls;*.xlsx";
                ofd.Multiselect = false;
                string filName = Path.GetFileName(ofd.FileName);
                string filePath = ofd.FileName;
                textPathPaste.Text = filePath;
                ex = new excel.Application();
                var openE = ex.Workbooks.Open(filePath, ReadOnly: true);
                openE.Activate();
                int WsheetsCount = openE.Worksheets.Count;
                var cb = openE.Sheets;
                for (int i = 1; i <= WsheetsCount; i++)
                {
                    Worksheet stSheet = openE.Worksheets[i];
                    string sheetNAme = stSheet.Name;
                    comboBox1.Items.AddRange(new object[] { sheetNAme });
                }
                int activeIBox = comboBox1.SelectedIndex = 0;
                Worksheet ssSHeet = openE.Worksheets[activeIBox + 1];
                ssSHeet.Activate();
            }
            else
                MessageBox.Show("Please Select Execl File");
        }

        private void textPathPaste_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void columnRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectRange_TextChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //To get an uniq Excel App
                //ex = new excel.Application();
                // to make it visible

                //to open workboot that selected
                // var openE = ex.Workbooks.Open(textPathPaste.Text, ReadOnly: true);
                //to make it an active one
                // openE.Activate();
                //to make the sheet that apear is the active sheet

                //Get the name of column from user
                if (textPathPaste.Text != "Excel file's path ")
                {

                    if (ex.ActiveWorkbook == null)
                    {
                        string filePath = textPathPaste.Text;
                        ex = new excel.Application();
                        var openE1 = ex.Workbooks.Open(filePath, ReadOnly: true);
                        openE1.Activate();
                    }
                    var openE = ex.ActiveWorkbook;
                    worksheet = openE.ActiveSheet;
                    string cHa = columnRange.Text;
                    int rHa = (int)numericUpDown1.Value;
                    int n;
                    n = 0;
                    //convert the letter to index number
                    if (cHa == "A" || cHa == "a") { n = 1; }
                    else if (cHa == "B" || cHa == "b") { n = 2; }
                    else if (cHa == "C" || cHa == "c") { n = 3; }
                    else if (cHa == "D" || cHa == "d") { n = 4; }
                    else if (cHa == "E" || cHa == "e") { n = 5; }
                    else if (cHa == "F" || cHa == "f") { n = 6; }
                    else if (cHa == "G" || cHa == "g") { n = 7; }
                    else if (cHa == "H" || cHa == "h") { n = 8; }
                    else if (cHa == "I" || cHa == "i") { n = 9; }
                    else if (cHa == "J" || cHa == "j") { n = 10; }
                    else if (cHa == "K" || cHa == "k") { n = 11; }
                    else if (cHa == "L" || cHa == "l") { n = 12; }
                    else if (cHa == "M" || cHa == "m") { n = 13; }
                    else if (cHa == "N" || cHa == "n") { n = 14; }
                    else if (cHa == "O" || cHa == "o") { n = 15; }
                    else if (cHa == "P" || cHa == "p") { n = 16; }
                    else { MessageBox.Show("Out Of Range"); }

                    //the Old range

                    int startRow = rHa + 1;
                    object cellStart;
                    object cellEnd;
                    range = worksheet.Columns[n];
                    range.Select();
                    range.AutoFit();
                    ex.Visible = true;
                    object[,] rValue = range.Value[XlRangeValueDataType.xlRangeValueDefault];
                    int rangeCount = rValue.Length;
                    int rangeC = 0;
                    for (int i = 1; i <= rangeCount; i++)
                    {

                        if (rValue.GetValue(i, 1) != null)
                        {
                            rangeC = rangeC + 1;

                        }
                        else
                            rangeC = rangeC + 0;
                    }
                    if (rangeC != 0)
                    {

                        cellStart = $"{cHa}{startRow}";
                        cellEnd = $"{cHa}{rangeC + rHa}";
                        range = worksheet.Range[cellStart, cellEnd];
                        range.Select();
                        selectRangeBox.Text = $"{cellStart}:{cellEnd}";
                        dataGridView2.Rows.Clear();
                        ex.Visible = true;
                        for (int i = 0; i < (rangeC); i++)
                        {
                            cellStart = $"{cHa}{startRow+i}";
                            range = worksheet.Range[cellStart, cellStart];
                            object valueOfCell = range.Cells.Value[XlRangeValueDataType.xlRangeValueDefault];
                            dataGridView2.Rows.Add();
                            dataGridView2.Rows[i].Cells[0].ValueType.ToString();
                            dataGridView2.Rows[i].Cells[0].Value = ($"{i+1}");
                            object cD = dataGridView2.Columns;

                            dataGridView2.Rows[i].Cells[1].ValueType.ToString();
                            dataGridView2.Rows[i].Cells[1].Value = valueOfCell;

                        }
                        
                        ex.Visible = false;

                    }
                    else
                    {
                        
                        MessageBox.Show("The is no value (Empty Cells)");
                    }
                }
                else
                {
                    MessageBox.Show("There is no file selected");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void replaceHY_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPathPaste.Text != "Excel file's path ")
                {

                    if (ex.ActiveWorkbook == null)
                    {
                        string filePath = textPathPaste.Text;
                        ex = new excel.Application();
                        var openE1 = ex.Workbooks.Open(filePath, ReadOnly: true);
                        openE1.Activate();
                    }
                    var openE = ex.ActiveWorkbook;
                    //to make the sheet that apear is the active sheet
                    worksheet = openE.ActiveSheet;
                    //Get the name of column from user
                    string cHa = columnRange.Text;
                    int rHa = (int)numericUpDown1.Value;
                    int n;
                    n = 0;
                    //convert the letter to index number
                    if (cHa == "A" || cHa == "a") { n = 1; }
                    else if (cHa == "B" || cHa == "b") { n = 2; }
                    else if (cHa == "C" || cHa == "c") { n = 3; }
                    else if (cHa == "D" || cHa == "d") { n = 4; }
                    else if (cHa == "E" || cHa == "e") { n = 5; }
                    else if (cHa == "F" || cHa == "f") { n = 6; }
                    else if (cHa == "G" || cHa == "g") { n = 7; }
                    else if (cHa == "H" || cHa == "h") { n = 8; }
                    else if (cHa == "I" || cHa == "i") { n = 9; }
                    else if (cHa == "J" || cHa == "j") { n = 10; }
                    else if (cHa == "K" || cHa == "k") { n = 11; }
                    else if (cHa == "L" || cHa == "l") { n = 12; }
                    else if (cHa == "M" || cHa == "m") { n = 13; }
                    else if (cHa == "N" || cHa == "n") { n = 14; }
                    else if (cHa == "O" || cHa == "o") { n = 15; }
                    else if (cHa == "P" || cHa == "p") { n = 16; }
                    else { MessageBox.Show("Wrong Value"); }

                    //the Old range
                    int startRow = rHa + 1;
                    object cellStart;
                    object cellEnd;
                    range = worksheet.UsedRange;
                    range = worksheet.Columns[n];
                    range.Select();
                    range.AutoFit();
                    ex.Visible = false;
                    ex.Visible = true;
                    object[,] rValue = range.Value[XlRangeValueDataType.xlRangeValueDefault];
                    int rangeCount = rValue.Length;
                    int rangeC = 0;
                    for (int i = 1; i <= rangeCount; i++)
                    {

                        if (rValue.GetValue(i, 1) != null)
                        {
                            rangeC = rangeC + 1;
                        }
                        else
                            rangeC = rangeC + 0;
                    }
                    if (rangeC != 0)
                    {
                        cellStart = $"{cHa}{startRow}";
                        cellEnd = $"{cHa}{rangeC + rHa}";
                        range = worksheet.Range[cellStart, cellEnd];
                        range.Select();
                        selectRangeBox.Text = $"{cellStart}:{cellEnd}";
                        ex.Visible = true;
                        for (int i = 0; i < (rangeC); i++)
                        {
                            cellStart = $"{cHa}{startRow + i}";
                            range = worksheet.Range[cellStart];
                            var valueOfCell = range.Value[XlRangeValueDataType.xlRangeValueDefault];
                            range.Hyperlinks.Add(range, valueOfCell);

                        }
                        ex.Visible = false;
                    }
                    else
                    {
                        ex.Visible = true;
                        MessageBox.Show("The is no value (Empty Cells)");
                    }
                }
                else
                {
                    MessageBox.Show("There is no file selected");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                throw;
            }

        }


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ex.ActiveWorkbook != null)
            {
            }
            else
            {
                string filePath = textPathPaste.Text;
                ex = new excel.Application();
                var openE1 = ex.Workbooks.Open(filePath, ReadOnly: true);
                openE1.Activate();
            }

            var openE = ex.ActiveWorkbook;
            int activeIBox = comboBox1.SelectedIndex;
            Worksheet ssSHeet = openE.Worksheets[activeIBox + 1];
            ssSHeet.Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KeyHolde(object sender, KeyEventArgs e)
        {


        }

        private void KeyHolde1(object sender, MouseEventArgs e)
        {
            Form1.ActiveForm.Enabled = true;
            Cursor cursor = Cursors.Cross;
            var Xmouse = MousePosition.X;
            var Ymouse = MousePosition.Y;
            var XFrom = Form1.ActiveForm.Location.X;
            var YFrom = Form1.ActiveForm.Location.Y;
            XFrom = Xmouse;
            YFrom = Ymouse;

        }

        private void MtoolsIcon_Click(object sender, EventArgs e)
        {
            Uri = "";
            uri
        }
    }
}