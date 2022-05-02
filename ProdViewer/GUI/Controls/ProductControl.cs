using System.Windows.Forms;
using System.Linq;

namespace ProdViewer.GUI.Controls
{
    public partial class ProductControl : UserControl
    {
        int ID;

        public ProductControl(int id, string name, int price, string info, string manufacture)
        {
            InitializeComponent();
            labelId.Text = $"Айди - {id.ToString()}";
            labelName.Text = $"Название - {name}";
            labelPrice.Text = $"Цена - {price.ToString()} грн.";
            labelInfo.Text = $"Информация - {info}";
            labelManufacture.Text = $"Принадлежность - {manufacture}";
            this.ID = id;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Model1 model = new Model1();
            model.tabletests.Remove(model.tabletests.Find(ID));
            model.SaveChanges();

            
        }
    }
}
