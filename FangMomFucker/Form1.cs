using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;

namespace FangMomFucker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestLib.thrs = (int)numericUpDownThrs.Value;
            TestLib.times = (int)numericUpDownTimes.Value;
            TestLib.timeOut = (int)numericUpDownTimeOut.Value;
            timer1.Start();
        }

        private void updateCount()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }
        private void 换行分隔TXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectIpToFile("\r\n","换行");
        }

        private void 换行分隔剪切板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectIpToClipBorad("\r\n");
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectIpToClipBorad("|");
        }

        private void buttonAddIPS_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "从剪切板导入多个IP或IP段\r\n支持 210.242.0.0/16\r\n或    210.242.0-255.0-255格式\r\n也可以拖拽多个文件添加IP");
        }

        private void buttonAddIP_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "在下框中输入单个IP或IP段\r\n支持 210.242.0.0/16\r\n或    210.242.0-255.0-255格式");
        }

        private void buttonRandTest_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "乱序测试IP池中的IP\r\n有效IP会添加到列表中\r\n每个ip只测试一次");
        }

        private void buttonStandardTest_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "把列表中的IP测试指定次数\r\n");
        }

        private void buttonBandTest_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "测试列表中IP的带宽\r\n测试线程始终为1\r\nGVS无法测速");
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            updateCount();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TestLib.stopped)
            {
                groupBox1.Enabled = true;
            }
            Monitor.Enter(TestLib.cache);
            while (TestLib.cache.Count > 0)
                dataGridView1.Rows.Add(TestLib.cache.Pop());
            Monitor.Exit(TestLib.cache);
            updateCount();
            labelRemainder.Text = "剩余" + TestLib.remainder.ToString().PadLeft(7, ' ');
            labelCount.Text = "有效" + dataGridView1.RowCount.ToString().PadLeft(7,' ');
        }

        private void buttonAddIPS_Click(object sender, EventArgs e)
        {
            TestLib.AddIPS(Clipboard.GetText());
        }

        private void buttonAddIP_Click(object sender, EventArgs e)
        {
            TestLib.AddIPS(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonStandardTest_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            TestLib.stdPool.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TestLib.stdPool.Add(new object[]{
                    row.Cells[0].Value,
                     row.Cells[1].Value,
                      row.Cells[2].Value,
                       row.Cells[3].Value,
                        row.Cells[4].Value,
                        row.Cells[5].Value,
                         row.Cells[6].Value});
            }
            dataGridView1.Rows.Clear();
            TestLib.StdTest();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "清空待测试IP池，要清空列表请右键移除");
        }

        private void buttonClearPool_Click(object sender, EventArgs e)
        {
            TestLib.randPool.Clear();
            TestLib.remainder = TestLib.randPool.Count;
        }

        private void comboBoxIpPools_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "加载自定义IP池");
        }

        private void comboBoxIpPools_DropDown(object sender, EventArgs e)
        {
            comboBoxIPPools.Items.Clear();
            comboBoxIPPools.Items.Add(new IPPool() { name = "自带好ip", ipStr = Properties.Resources.自带好ip });
            comboBoxIPPools.Items.Add(new IPPool() { name = "谷歌官方", ipStr = Properties.Resources.谷歌官方 });
            comboBoxIPPools.Items.Add(new IPPool() { name = "GWS[已阵亡]", ipStr = Properties.Resources.GWS });
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string path in files)
            {
                if (Path.GetExtension(path) == ".txt")
                {
                    try
                    {
                        comboBoxIPPools.Items.Add(new IPPool() { name = Path.GetFileNameWithoutExtension(path), ipStr = File.ReadAllText(path) });
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void AddIPS_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void AddIPS_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            string temp;
            foreach (string path in paths)
            {
                try
                {
                    temp = Path.GetExtension(path);
                    if (temp == ".txt" || temp == ".ini")
                        TestLib.AddIPS(File.ReadAllText(path));
                }
                catch (Exception)
                {
                }
            }
        }

        private void labelRemainder_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "出于性能考虑，导入ip时不会移除重复ip\r\n开始测试时会自动移除重复ip");
        }

        private void buttonRandTest_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            TestLib.RandTest();
        }

        private void numericUpDownTimes_ValueChanged(object sender, EventArgs e)
        {
            TestLib.times = (int)numericUpDownTimes.Value;
        }

        private void numericUpDownThrs_ValueChanged(object sender, EventArgs e)
        {
            TestLib.thrs = (int)numericUpDownThrs.Value;
        }

        private void buttonBandTest_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            TestLib.stdPool.Clear();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                TestLib.stdPool.Add(new object[]{
                    row.Cells[0].Value,
                        row.Cells[1].Value,
                        row.Cells[2].Value,
                        row.Cells[3].Value,
                        row.Cells[4].Value,
                        row.Cells[5].Value,
                        row.Cells[6].Value});
            }
            dataGridView1.Rows.Clear();
            TestLib.BandTest();
        }

        private void buttonStopTest_Click(object sender, EventArgs e)
        {
            TestLib.running = false;
            TestLib.remainder = 0;
        }

        private void 空格分隔剪切板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectIpToClipBorad(" ");
        }

        private void 空格分隔TXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectIpToFile(" ","空格");
        }

        private void 移除选中ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                dataGridView1.Rows.Remove(row);
        }

        private void 去重ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<object[]> tempList = new List<object[]>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tempList.Add(new object[]{
                    row.Cells[0].Value,
                     row.Cells[1].Value,
                      row.Cells[2].Value,
                       row.Cells[3].Value,
                        row.Cells[4].Value,
                         row.Cells[5].Value,
                          row.Cells[6].Value});
            }
            dataGridView1.Rows.Clear();
            tempList = tempList.Distinct<object[]>(new TestLib.fuck()).ToList<object[]>();
            foreach (object[] obj in tempList)
                dataGridView1.Rows.Add(obj);
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void ToINIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            try
            {
                StringBuilder sb = new StringBuilder();
                var tempIps = dataGridView1.SelectedRows;
                for (int i = tempIps.Count - 1; i >= 0; i--)
                {
                    sb.Append(tempIps[i].Cells[0].Value);
                    sb.Append('|');
                }
                string ips = sb.ToString();
                ips = ips.Substring(0, ips.Length - 1);
                string fileName = "proxy.user.ini";
                if (!File.Exists(fileName))
                    File.WriteAllText(fileName, "[iplist]\r\ngoogle_hk = " + ips + "\r\n");
                else
                {
                    string temp = File.ReadAllText(fileName);
                    string[] tempStrs = temp.Split("\r\n".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                    string mathStr = "google_hk =";
                    StringBuilder sb2 = new StringBuilder();
                    for (int i = 0; i < tempStrs.Length; i++)
                    {
                        if (tempStrs[i].Length >= mathStr.Length && tempStrs[i].Substring(0, mathStr.Length) == mathStr)
                        {
                            tempStrs[i] = "google_hk = " + ips;
                        }
                        sb2.Append(tempStrs[i]);
                        sb2.Append("\r\n");
                        if (i + 1 < tempStrs.Length && tempStrs[i + 1][0] == '[')
                            sb2.Append("\r\n");
                    }
                    sb2.Append("\r\n");
                    File.WriteAllText(fileName, sb2.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void ToIPSEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            List<string> tempList = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                tempList.Add(ToCIDR16IP(row.Cells[0].Value.ToString()));
            tempList = tempList.Distinct<string>().ToList<string>();
            tempList.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (string str in tempList)
            {
                sb.Append(str);
                sb.Append("\r\n");
            }
            try
            {
                File.WriteAllText(DateTime.Now.ToLongDateString() + "-" + "IP段" + "-" + tempList.Count + ".txt", sb.ToString());
            }
            catch (Exception)
            {
            }
        }

        private string ToCIDR16IP(string str)
        {
            string[] tempStrs = str.Split('.');
            StringBuilder sb = new StringBuilder();
            sb.Append(tempStrs[0]);
            sb.Append(".");
            sb.Append(tempStrs[1]);
            sb.Append(".");
            sb.Append(tempStrs[2]);
            sb.Append(".");
            sb.Append("0/24");
            return sb.ToString();
        }

        private void comboBoxIPPools_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TestLib.randPool.Clear();
            TestLib.AddIPS(((IPPool)comboBoxIPPools.SelectedItem).ipStr);
        }
        class IPPool
        {
            public string ipStr; 
            public string name;
            public override string ToString()
            {
                return name;
            }
        }
        private void labelCount_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((Control)sender, "经测试有效的IP总数");
        }

        private void numericUpDownTimeOut_ValueChanged(object sender, EventArgs e)
        {
            TestLib.timeOut = (int)numericUpDownTimeOut.Value;
        }
        private void selectIpToClipBorad(string split)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            StringBuilder sb = new StringBuilder();
            var tempIps = dataGridView1.SelectedRows;
            for (int i = tempIps.Count - 1; i >= 0; i--)
            {
                sb.Append(tempIps[i].Cells[0].Value);
                sb.Append(split);
            }
            string tempStr = sb.ToString();
            if (split != "\r\n")
            {
                tempStr = tempStr.Substring(0, tempStr.Length - 1);
            }
            Clipboard.SetText(tempStr);
        }
        private void selectIpToFile(string split,string typeName)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            StringBuilder sb = new StringBuilder();
            var tempIps = dataGridView1.SelectedRows;
            for (int i = tempIps.Count - 1; i >= 0; i--)
            {
                sb.Append(tempIps[i].Cells[0].Value);
                sb.Append(split);
            }
            string tempStr = sb.ToString();
            if (split != "\r\n")
            {
                tempStr = tempStr.Substring(0, tempStr.Length - 1);
            }
            string fileName = DateTime.Now.ToLongDateString() + "-" +  typeName + "-" + tempIps.Count + ".txt";
            try
            {
                File.WriteAllText(fileName, tempStr);
            }
            catch (Exception)
            {
            }
        }
    }
}
