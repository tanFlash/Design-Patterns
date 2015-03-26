using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethodExample
{
    public partial class Form1 : Form
    {
        static string ComputerName;
        static string Characteristics;
        static string Description;
        static double Price;
        static ComputerItem computer;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ComputerName = txbName.Text;
            Characteristics = txbChar.Text;
            Description = txbDescrip.Text;
            Price = Convert.ToDouble(txbPrice.Text);
            computer = new ComputerItem(ComputerName, Characteristics, Description, Price);
            MessageBox.Show(computer.ToString());

        }

        private void btnJson_Click(object sender, EventArgs e)
        {
           ISerializer  ser = SerializationFactory.GetSerialization(1);
           MessageBox.Show(ser.SerializeMyObject(computer));


        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            ISerializer ser = SerializationFactory.GetSerialization(2);
            MessageBox.Show(ser.SerializeMyObject(computer));
        }
    }
}
