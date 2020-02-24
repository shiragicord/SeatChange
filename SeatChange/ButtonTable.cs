using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatChange
{
    public partial class ButtonTable : UserControl
    {
        public ButtonTable()
        {
            InitializeComponent();

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

            RefreshTable();
        }

        public event ButtonClickEventHandler ButtonClick;

        public int Row
        {
            get
            {
                return mainTable.RowCount;
            }
            set
            {
                mainTable.RowCount = value;
                RefreshTable();
            }
        }

        public int Column
        {
            get
            {
                return mainTable.ColumnCount;
            }
            set
            {
                mainTable.ColumnCount = value;
                RefreshTable();
            }
        }

        public void RefreshTable()
        {
            mainTable.Controls.Clear(); // 最初にすべてを削除
            int i = 0;

            Button button;
            for (i=0; i<mainTable.ColumnCount;i++)
            {
                for (int j=0; j<mainTable.RowCount;j++)
                {
                    button = new Button();
                    button.Text = "";

                    // タグとして格納しておき、イベントがあったらそのまま渡す。
                    button.Tag = new ButtonClickEventArgs(i, j);
                    button.Dock = DockStyle.Fill;
                    Padding margin = button.Margin;
                    margin.All = 0;
                    button.Margin = margin;
                    button.BackColor = SheetData.COLOR_MAN;
                    button.Click += new EventHandler(Button_Click);
                    mainTable.Controls.Add(button, i, j);
                }
            } 
        }

        public Button GetButton(int column, int row)
        {
            return (Button) mainTable.GetControlFromPosition(column, row);
        }

        public void SetButton(Button button, int column, int row)
        {
            // タグとして格納しておき、イベントがあったらそのまま渡す。
            button.Tag = new ButtonClickEventArgs(column, row);

            // 一度消去して追加
            mainTable.Controls.Remove(mainTable.GetControlFromPosition(column, row));
            mainTable.Controls.Add(button, column, row);
        }

        public Color GetButtonColor(int column, int row)
        {
            return GetButton(column, row).BackColor;
        }

        public void SetButtonColor(Color color, int column, int row)
        {
            Button button = GetButton(column, row);
            button.BackColor = color;
            SetButton(button, column, row);
        }

        public void SetButtonText(String str, int column, int row)
        {
            Button button = GetButton(column, row);
            button.Text = str;
            SetButton(button, column, row);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ButtonClick.Invoke(this, (ButtonClickEventArgs) button.Tag);
        }

        public void Import(SheetData data)
        {
            Row = data.Row;
            Column = data.Column;

            int index = 0;
            for (int i = 0; i < Column; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    // 一次元配列を二次元配列にして色を設定
                    SetButtonColor(SheetData.SheetToColor(data.Sheets[index]), i, j);
                    index++;
                }
            }
        }

        public SheetData Export()
        {
            SheetData data = new SheetData();
            data.Row = Row;
            data.Column = Column;
            data.Sheets = new int[Row * Column];
            int index = 0;
            Color color;
            for (int i = 0; i < Column; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    // 二次元配列を一次元配列にする。
                    color = GetButtonColor(i, j);
                    data.Sheets[index] = SheetData.ColorToSheet(color);
                    index++;
                }
            }
            return data;
        }
    }
    
    public delegate void ButtonClickEventHandler(object sender, ButtonClickEventArgs e);

    public class ButtonClickEventArgs
    {
        public ButtonClickEventArgs(int column, int row)
        {
            Row = row;
            Column = column;
        }
        public int Row { get; }
        public int Column { get; }
    }
}
