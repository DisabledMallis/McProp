using McProp.Objects;
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
        }

        internal void populate()
        {
            Console.WriteLine("Mapping client...");
            ClientInstance instance = new ClientInstance(ciPtr);
            Console.WriteLine("Populating tree...");
            this.objectList.Nodes.Add(instance.toNode());
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.objectList.Nodes.Clear();
            populate();
        }
    }
}
