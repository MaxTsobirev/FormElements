using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pic;
        public int count = 1;

        public Form1()
        {
            this.Height = 600;
            this.Width = 900;
            this.Text = "Vorm elementidega";
            Image img = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\ti10.png");
            this.BackgroundImage = img;
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Silt"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Märkeruut-Check Box"));
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));
            tn.Nodes.Add(new TreeNode("Tekstkast-TextBox"));
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));

            //button
            btn = new Button();
            btn.Text = "Выйди отсюда!";
            btn.Location = new Point(120, 20);
            btn.Height = 60;
            btn.Width = 150;
            btn.Click += Btn_Click;
            //pealkiri
            lbl = new Label();
            lbl.Text = "Elementide liimite c# abil";
            lbl.Size = new Size(150,20);
            lbl.Location = new Point(120, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            //picturebox
            pic = new PictureBox();
            pic.Size = new Size(100, 80);
            pic.Location = new Point(270, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\d2teamspirit-728x420.png");
            //carusel 3-4
            pic.DoubleClick += Pic_DoubleClick;
            




            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Pic_DoubleClick(object sender, EventArgs e)
        {
            switch(count)
            {
                case 1:
                    pic.Image = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\38b590e59031edd4cb9b2146a6.jpg");
                    count++;
                    break;
                case 2:
                    pic.Image = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\Horn_Toss_icon.png");
                    count++;
                    break;


            }
            
            
            



        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(200, 20, 30);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text=="Silt")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text== "PictureBox")
            {
                this.Controls.Add(pic);
            }
        }
    }
}
