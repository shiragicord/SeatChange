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
    public partial class MainForm : Form
    {
        private List<SheetData> data_list;

        private int _dataIndex;
        private int selectedIndex // 値に変化があったら情報も変化させる。
        {
            get
            {
                return _dataIndex;
            }
            set
            {
                _dataIndex = value;
                if (comboBox.SelectedIndex != value)
                {
                    comboBox.SelectedIndex = value;
                }
                SetValue(data_list[value]);
            }
        }
        private bool _removeFlag;
        private bool removeFlag //  なにかあったら随時変更
        {
            get
            {
                return _removeFlag;
            }
            set
            {
                _removeFlag = value;
                if (value)
                {
                    SaveOrRemoveButton.Text = "削除";
                } else
                {
                    SaveOrRemoveButton.Text = "保存";
                }
            }
        }
        private NameDialog dialog;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            data_list = new List<SheetData>();
            buttonTable.ButtonClick += new ButtonClickEventHandler(ButtonTable_ButtonClick);
        }

        private void columnNumber_ValueChanged(object sender, EventArgs e)
        {
            buttonTable.Column = (int)columnNumber.Value;
            UpdateSexCount();
            removeFlag = false;
        }

        private void rowNumber_ValueChanged(object sender, EventArgs e)
        {
            buttonTable.Row = (int)rowNumber.Value;
            UpdateSexCount();
            removeFlag = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStatus("左側のボタンをクリックすると席の状態が切り替わります。男は青、女は赤、席なしは黒です。");

            LoadSetting();
            UpdateSexCount();
        }

        private void LoadSetting()
        {
            Properties.Settings.Default.Reload();
            String saveData = Properties.Settings.Default.saveData;
            data_list = new List<SheetData>();
            if (saveData == "")
            {
                NewSheet("NewData");
            } else
            {
                String[] data_array = saveData.Split('\n');
                bool first = true;
                int temp = 0;
                foreach (String data in data_array)
                {
                    if (first) // 最初の行はselectedIndexだからこれを参照
                    {
                        temp = int.Parse(data);
                        first = false;
                    }
                    else
                    {
                        SheetData sheet = new SheetData(data);
                        data_list.Add(sheet);
                        comboBox.Items.Add(sheet.name);
                    }
                }
                selectedIndex = temp;
            }
        }

        private void SaveSetting()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(selectedIndex.ToString());
            foreach (SheetData data in data_list)
            {
                builder.Append("\n");
                builder.Append(data.ToString());
            }
            Properties.Settings.Default["saveData"] = builder.ToString();
            Properties.Settings.Default.Save();
        }

        private void SetValue(SheetData value)
        {
            rowNumber.Value = value.Row;
            columnNumber.Value = value.Column;
            buttonTable.Import(value);
            UpdateSexCount();
            removeFlag = true;
        }

        private void SetStatus(String str)
        {
            statusLabel.Text = str;
        }

        private void ButtonTable_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            ButtonTable buttonTable = (ButtonTable)sender;
            Color color = buttonTable.GetButtonColor(e.Column, e.Row);
            if (color.B == 0xFF) // 青なら赤に
            {
                color = SheetData.COLOR_WOMAN;
                
            }
            else if (color.R == 0xFF) // 赤なら黒に
            {
                color = SheetData.COLOR_BLANK;
            }
            else if (color.R == 0x99) // 黒なら灰に
            {
                color = SheetData.COLOR_MAN;
            }
            buttonTable.SetButtonColor(color, e.Column, e.Row);
            UpdateSexCount();
            removeFlag = false;
        }

        private void UpdateSexCount()
        {
            int men = 0;
            int women = 0;
            Color color;
            for (int i=0;i<buttonTable.Column;i++)
            {
                for (int j=0;j<buttonTable.Row;j++)
                {
                    color = buttonTable.GetButtonColor(i, j);
                    switch (SheetData.ColorToSheet(color))
                    {
                        case SheetData.MAN:
                            men += 1;
                            break;
                        case SheetData.WOMAN:
                            women += 1;
                            break;
                    }
                }
            }
            menCountLabel.Text = men.ToString();
            womenCountLabel.Text = women.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            dialog = new NameDialog();
            dialog.OKButtonClick += new EventHandler(Dialog_OKButtonClick);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog(this);
        }

        private void Dialog_OKButtonClick(object sender, EventArgs e)
        {
            NewSheet(dialog.ResultText);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedIndex != comboBox.SelectedIndex)
            {
                selectedIndex = comboBox.SelectedIndex;
            }
        }

        private void SaveOrRemoveButton_Click(object sender, EventArgs e)
        {
            if (removeFlag) // 消去するなら
            {
                data_list.RemoveAt(selectedIndex);
                comboBox.Items.RemoveAt(selectedIndex);
                if (data_list.Count == 0)
                {
                    NewSheet("NewData");
                } else
                {
                    selectedIndex = 0;
                }
                SaveSetting();
            } else // 保存するなら
            {
                Save();
            }
        }

        private void Save()
        {
            if (! removeFlag)
            {
                SheetData data = buttonTable.Export();
                data.name = data_list[selectedIndex].name;
                data_list.RemoveAt(selectedIndex);
                data_list.Insert(selectedIndex, data);
                SaveSetting();
                removeFlag = true;
            }
        }

        /*
         * 新しいシートを生成 
         */
        private void NewSheet(String name)
        {
            SheetData data = new SheetData();
            data.name = name;
            data_list.Add(data);
            comboBox.Items.Add(name);
            selectedIndex = data_list.Count - 1;
            SaveSetting();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // 強制保存
            Save();

            ResultDialog dialog = new ResultDialog(data_list[selectedIndex]);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog(this);
        }
    }
}
