using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeExample
{
    public partial class Form1 : Form
    {
       public Person onePerson;
       public Person secondPerson;
       public Person thirdPerson;
       
        public Form1()
        {
            InitializeComponent();
            onePerson = new Person();
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open Image";
                dlg.Filter = "img files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    
                    onePerson.Head = new Bitmap (pictureBox1.Image);
                }
                dlg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            
        }

        private void btnBody_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open Image";
                dlg.Filter = "img files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Image = new Bitmap(dlg.FileName);
                    
                    onePerson.Body = new Bitmap(pictureBox2.Image);
                }
                dlg.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnFeet_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open Image";
                dlg.Filter = "img files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Image = new Bitmap(dlg.FileName);
                    onePerson.Feet = new Bitmap(pictureBox3.Image);
                }
                dlg.Dispose();
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeep_Click(object sender, EventArgs e)
        {
            //the deepclone method is used to make a deep copy of the object
            thirdPerson = (Person)onePerson.DeepClone();
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = thirdPerson.Head;
            pictureBox8.Image = thirdPerson.Body;
            pictureBox9.Image = thirdPerson.Feet;
                 
        }

        private void btnShallow_Click(object sender, EventArgs e)
        {
            try
            {
                //simple clone method is used to make a shallow copy
                secondPerson = (Person)onePerson.Clone();
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Image = secondPerson.Head;
                pictureBox5.Image = secondPerson.Body;
                pictureBox6.Image = secondPerson.Feet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
       
       
    }
}
