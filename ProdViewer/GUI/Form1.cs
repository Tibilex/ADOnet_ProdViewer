using ProdViewer.GUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdViewer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.Height = 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            Model1 model = new Model1();
            foreach (var item in model.tabletests)
            {
                this.Controls.Add(new ProductControl(item.id, item.Name, item.Price, item.Info, item.Manufacture) { Location = new Point(x, y) });
                x += 200;
                if(x / 200 >= 4)
                {
                    y += 170;
                    x = 0;
                }
            }
        }
    }
}
