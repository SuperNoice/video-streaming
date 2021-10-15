using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace video_streaming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            List<WaveOutCapabilities> sources = new List<WaveOutCapabilities>();
            for (int i = 0; i < WaveOut.DeviceCount; ++i)
            {
                sources.Add(WaveOut.GetCapabilities(i));
            }
            OutputDevicesList.Items.Clear();
            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                OutputDevicesList.Items.Add(item);
            }
        }
    }
}
