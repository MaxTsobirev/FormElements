using Microsoft.VisualBasic;
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
        bool t = false;
        CheckBox cb;
        CheckBox cb2;
        RadioButton rb;
        RadioButton rb2;
        TabControl tabC;

        public Form1()
        {
            this.Height = 480;
            this.Width = 760;
            this.Text = "Vorm elementidega";
            Image img = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\g.jpg");
            this.BackgroundImage = img;
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Silt"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Wallpaper"));
            tn.Nodes.Add(new TreeNode("Size"));
            tn.Nodes.Add(new TreeNode("Radio"));
            tn.Nodes.Add(new TreeNode("Radio2"));
            tn.Nodes.Add(new TreeNode("Tekstkast-TextBox"));
            tn.Nodes.Add(new TreeNode("Kaart"));
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

            //checkbox
            cb = new CheckBox();
            cb.CheckedChanged += Cb_CheckedChanged;
            cb.Size = new Size(100, 20);
            cb.Location = new Point(200, 150);
            cb.Text = "Смена фона";
            
            //cb2
            cb2 = new CheckBox();
            cb2.CheckedChanged += Cb2_CheckedChanged;
            cb2.Size = new Size(100, 20);
            cb2.Location = new Point(200, 200);
            cb2.Text = "Изменение размера";
            //rb
            rb = new RadioButton();
            rb.CheckedChanged += Rb_CheckedChanged;
            rb.Size = new Size(100, 20);
            rb.Location = new Point(200, 250);
            rb.Text = "Click";
            //rb2
            rb2 = new RadioButton();
            rb2.CheckedChanged += Rb2_CheckedChanged;
            rb2.Size = new Size(100, 20);
            rb2.Location = new Point(200, 300);
            rb2.Text = "Teema";
            //tab




            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Rb2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            lbl.Text = "1000-7?";
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked)
            {
                Image img = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\g.jpg");
                this.BackgroundImage = img;
            }
            else
            {
                Image img = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\ti10.png");
                this.BackgroundImage = img;
            }
            
        }

        private void Cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (t)
            {
                this.Size = new Size(1200, 650);
                cb2.Text = "Teeme väiksem";
                t = false;
            }
            else
            {
                this.Size = new Size(760, 480);
                cb2.Text = "Suurendame";
                t = true;
            }
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
                case 3:
                    pic.Image = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\d2teamspirit-728x420.png");
                    count=1;
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
            else if (e.Node.Text == "Wallpaper")
            {
                this.Controls.Add(cb);
            }
            else if (e.Node.Text == "Size")
            {
                this.Controls.Add(cb2);
            }
            else if (e.Node.Text == "Radio")
            {
                this.Controls.Add(rb);
            }
            else if (e.Node.Text == "Radio2")
            {
                this.Controls.Add(rb2);
            }
            else if(e.Node.Text=="MessageBox")
            {
                MessageBox.Show("MessageBox", "Kõige lihtsam aken");
                var answer = MessageBox.Show("Хочешь написать послание в будущее?", "Aken koos nupudega",MessageBoxButtons.YesNo);
                if(answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Расскажи что нибудь", "InputBox", "Жили были ....");
                    if(MessageBox.Show("Оно отправиться в будущее","Teksti salvestamine",MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        lbl.Text = "Siis mina lisan oma teksti!";
                        Controls.Add(lbl);
                    }
                }
            }
            else if (e.Node.Text == "Radio2")
            {
                rb.CheckedChanged += new EventHandler(Rb_CheckedChanged);
                rb2.CheckedChanged += Rb2_CheckedChanged1;
            }
            else if (e.Node.Text=="Kaart")
            {
                tabC = new TabControl();
                tabC.Location = new Point(150,150);
                tabC.Size = new Size(300, 200);
                TabPage tabP1 = new TabPage("youtube");
                WebBrowser wb = new WebBrowser();
                wb.Url =new Uri ("https://www.youtube.com");
                tabP1.Controls.Add(wb);
                TabPage tabP2 = new TabPage("qwqw");
                TabPage tabP3 = new TabPage("erer");
                tabP3.DoubleClick += TabP3_DoubleClick;
                tabC.Controls.Add(tabP1);
                tabC.Controls.Add(tabP2);
                tabC.Controls.Add(tabP3);
                tabC.Selected += TabC_Selected;
                this.Controls.Add(tabC);
            }
        }

        private void TabC_Selected(object sender, TabControlEventArgs e)
        {
            this.tabC.TabPages.Clear();
        }

        private void TabP3_DoubleClick(object sender, EventArgs e)
        {
            string title = "tabP" + (tabC.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabC.TabPages.Add(tb);
        }

        private void Rb2_CheckedChanged1(object sender, EventArgs e)
        {
            if(rb2.Checked)
            {
                this.BackColor = Color.Black;
                rb2.ForeColor = Color.White;
                rb.ForeColor = Color.White;

            }
            else if (rb2.Checked)
            {
                this.BackColor = Color.White;
                rb2.ForeColor = Color.Black;
                rb.ForeColor = Color.Black;
            }
        }
    }


}
