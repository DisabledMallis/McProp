using McProp.Objects;
using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McProp
{
    public partial class Explorer : Form
    {
        //Client instance pointer
        private ulong ciPtr;
        public Explorer(ulong ciPtr)
        {
            this.ciPtr = ciPtr;
            InitializeComponent();

            Timer liveUpdateWorker = new Timer();
            liveUpdateWorker.Tick += Timer_Tick;
            liveUpdateWorker.Interval = 10;
            liveUpdateWorker.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TreeNode selected = objectList.SelectedNode;
            if (selected == null)
                return;
            if (!(selected is GameProp))
                return;
            GameProp prop = selected as GameProp;
            propNameLabel.Text = "Property name: " + prop.getName();
            propNameLabel.Refresh();
            valueBox.Text = prop.getValueString();
        }

        internal void populate()
        {
            Console.WriteLine("Mapping client...");
            ClientInstance instance = new ClientInstance(ciPtr);
            Console.WriteLine("Populating tree...");
            this.objectList.Nodes.Add(instance);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.objectList.Nodes.Clear();
            populate();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            TreeNode selected = objectList.SelectedNode;
            if (selected == null)
                return;
            if (!(selected is GameProp))
                return;
            GameProp prop = selected as GameProp;
            Mem memLib = Program.getMem();
            ulong address = prop.getAddress();
            memLib.WriteMemory(address.ToString("X"), prop.getType(), valueInputBox.Text);
        }
    }
}
