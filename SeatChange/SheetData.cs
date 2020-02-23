using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatChange
{
    public class SheetData
    {
        public const int MAN = 0;
        public const int WOMAN = 1;
        public const int BLANK = 2;

        public static readonly Color COLOR_MAN = Color.FromArgb(0x44, 0x44, 0xFF);
        public static readonly Color COLOR_WOMAN = Color.FromArgb(0xFF, 0x44, 0x44);
        public static readonly Color COLOR_BLANK = Color.FromArgb(0x99, 0x99, 0x99);

        public SheetData()
        {
            Sheets = new int[36];
            Row = 6;
            Column = 6;
        }

        public SheetData(String str)
        {
            FromString(str);
        }

        public String name;
        public int Row;
        public int Column;
        public int[] Sheets;

        public static int ColorToSheet(Color color)
        {
            if (color.B == 0xFF) // 色で判別
            {
                return SheetData.MAN;
            }
            else if (color.R == 0xFF)
            {
                return SheetData.WOMAN;
            }
            else if (color.R == 0x99)
            {
                return SheetData.BLANK;
            }
            return 0;
        }

        public static Color SheetToColor(int sheet)
        {
            Color[] colors = new Color[] { SheetData.COLOR_MAN, SheetData.COLOR_WOMAN, SheetData.COLOR_BLANK };
            return colors[sheet];
        }

        public int GetMen()
        {
            int count = 0;
            foreach(int i in Sheets)
            {
                if (i == MAN)
                {
                    count++;
                }
            }
            return count;
        }
        public int GetWomen()
        {
            int count = 0;
            foreach (int i in Sheets)
            {
                if (i == WOMAN)
                {
                    count++;
                }
            }
            return count;
        }

        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(name); // トラブル防止
            builder.Append("\xFFFC");
            builder.Append(Row.ToString());
            builder.Append(",");
            builder.Append(Column.ToString());
            foreach(int sheet in Sheets)
            {
                builder.Append(",");
                builder.Append(sheet.ToString());
            }
            return builder.ToString();
        }

        public void FromString(String str)
        {
            String[] dataStr = str.Split('\xFFFC');
            name = dataStr[0];
            str = dataStr[1];
            dataStr = str.Split(',');
            int[] data = new int[dataStr.Length];
            int len = dataStr.Length;
            for (int i=0;i<len;i++)
            {
                data[i] = int.Parse(dataStr[i]);
            }
            Row = data[0];
            Column = data[1];
            Sheets = new int[data.Length - 2];
            // スライス
            Array.Copy(data, 2, Sheets, 0, Sheets.Length);
        }
    }
}
