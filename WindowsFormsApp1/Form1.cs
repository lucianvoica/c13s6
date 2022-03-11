using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Shop pizzaShop;
        public Form1()
        {
            pizzaShop = new Shop();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("ati dat click",
                "Atentie", 
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if(rezultat == DialogResult.Yes)
            {
                label1.Text = "ati dat click pe yes";
            } 
            else if(rezultat == DialogResult.No)
            {
                label1.Text = "ati dat click pe nu";
            }
            else if(rezultat ==DialogResult.Cancel)
            {
                label1.Text = "ati dat click pe cancel";
            }
            else
            {
                label1.Text = "asdasdasl";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CategorieDialog popup = new CategorieDialog();
            
            DialogResult dialogResult = popup.ShowDialog();

            if(dialogResult == DialogResult.Cancel)
            {
                label1.Text = "nu ati adaugat nimic";
            } 
            else if(dialogResult == DialogResult.OK)
            {
                pizzaShop.Categories.Add(popup.Category);
            }

            AfiseazaCategorii();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] a = new string[4] { "Ana", "are", "mere", "verzi" };

            //textBox1.Text = a[0] + " " + a[1] + " " + a[2] + " " + a[3];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    textBox1.Text += a[i] + " ";
            //}

            //foreach (string item in a)
            //{
            //    textBox1.Text += item + " ";
            //}

            List<string> lista = new List<string>() { "Ana", "are", "mere", "asdia", "saeiasda" };
            lista.Add("asd");
            lista.Add("asd");

            //for(int i = 0; i < lista.Count; i++)
            //{
            //    textBox1.Text += lista[i] + " ";
            //}
            
            foreach (string item in lista)
            {
                textBox1.Text += item + " ";
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adaugam 3 categorii
            Category category1 = new Category("Pizza", "Pizza italiana");
            Category category2 = new Category("Paste", "Paste al forno");
            Category category3 = new Category("Salate", "Salate sanatoase");

            pizzaShop.Categories.Add(category1);
            pizzaShop.Categories.Add(category2);
            pizzaShop.Categories.Add(category3);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AfiseazaCategorii();
        }

        private void AfiseazaCategorii()
        {
            categoriesLabel.Text = "";
            foreach (Category category in pizzaShop.Categories)
            {
                categoriesLabel.Text += category.Name + " ";
            }
        }
    }
}
