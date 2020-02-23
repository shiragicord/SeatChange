using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatChange
{
    public partial class ResultDialog : Form
    {
        private static int randSeed;
        private SheetData data;
        public ResultDialog(SheetData data)
        {
            InitializeComponent();
            this.data = data;

            // とりあえずRowStyleを埋める
            mainTable.RowStyles.Clear();
            while (mainTable.RowStyles.Count < 12)
            {
                mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            }
            // とりあえずColumnStyleを埋める
            mainTable.ColumnStyles.Clear();
            while (mainTable.ColumnStyles.Count < 12)
            {
                mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            }
        }

        private void ResultDialog_Load(object sender, EventArgs e)
        {
            mainTable.RowCount = data.Row;
            mainTable.ColumnCount = data.Column;
            Label label;
            int index = 0;
            for (int i = 0; i < mainTable.ColumnCount; i++)
            {
                for (int j = 0; j < mainTable.RowCount; j++)
                {
                    label = new Label();
                    label.Text = "";

                    // タグとして格納しておき、イベントがあったらそのまま渡す。
                    label.Dock = DockStyle.Fill;
                    Padding margin = label.Margin;
                    margin.All = 2;
                    label.Margin = margin;
                    label.BackColor = SheetData.SheetToColor(data.Sheets[index]);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = new Font(label.Font.OriginalFontName, 30f);
                    mainTable.Controls.Add(label, i, j);
                    index++;
                }
            }
            int[] menArray = CreateRandomArray(1, data.GetMen());
            int[] womenArray = CreateRandomArray(1, data.GetWomen());
            int menCount = 0;
            int womenCount = 0;
            for (int i = 0; i < mainTable.ColumnCount; i++)
            {
                for (int j = 0; j < mainTable.RowCount; j++)
                {
                    label = (Label)mainTable.GetControlFromPosition(i, j);
                    switch (SheetData.ColorToSheet(label.BackColor))
                    {
                        case SheetData.MAN:
                            label.Text = menArray[menCount].ToString();
                            menCount++;
                            break;
                        case SheetData.WOMAN:
                            label.Text = womenArray[womenCount].ToString();
                            womenCount++;
                            break;
                    }
                    mainTable.Controls.Remove(mainTable.GetControlFromPosition(i, j));
                    mainTable.Controls.Add(label, i, j);
                }
            }
        }

        private int[] CreateRandomArray(int start, int length)
        {
            List<int> source = new List<int>();
            for (int i=0;i<length;i++)
            {
                source.Add(i);
            }
            int[] rands = new int[length];
            int t;
            Random random = new System.Random(GetSeed());
            for (int i = 0; i < length; i++)
            {
                t = random.Next(0, source.Count());
                rands[i] = source[t] + start;
                source.RemoveAt(t);
            }
            return rands;
        }

        private int GetSeed()
        {
            DateTime dateTime = DateTime.Now;
            randSeed++;
            return dateTime.Hour * 10000000 + dateTime.Minute * 100000 + dateTime.Second * 1000 + dateTime.Millisecond + randSeed;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
