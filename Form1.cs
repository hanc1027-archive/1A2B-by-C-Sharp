//
//  Form1.cs
//  遊戲選單
//
//  Created by Nelson on 2018/01/01
//  Copyright © 2017年 HanC. All rights reserved.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "1A2B";

           

            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            string guessnumICO_Path = dir.Parent.Parent.FullName + "\\Pictures\\";
            this.Icon = Icon.ExtractAssociatedIcon(guessnumICO_Path + "1A2B.ico");
            this.BackgroundImage = Image.FromFile(guessnumICO_Path + "01.jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; //讓背景圖片大小符合視窗大小


            label1.BackColor = Color.Transparent; label2.BackColor = Color.Transparent; label3.BackColor = Color.Transparent; label4.BackColor = Color.Transparent;
            label1.ForeColor = Color.Wheat; label2.ForeColor = Color.DarkViolet; label3.ForeColor = Color.DarkViolet; label4.ForeColor = Color.Red;
            //label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            


            string Music_Path = dir.Parent.Parent.FullName + "\\Music\\";

            axWindowsMediaPlayer1.URL = @Music_Path+"Menu.mp3";
            axWindowsMediaPlayer1.settings.volume = 50; //WMP音量預設值為50
            axWindowsMediaPlayer1.Visible = false; //隱藏撥放器
            axWindowsMediaPlayer1.settings.autoStart = true;	//預設自動播放

            picB_Mute.Image = imgls_Mute.Images[0];
            picB_Mute.BackColor = Color.Transparent;

            

        }     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int count = 1;
        private void picB_Mute_Click(object sender, EventArgs e)
        {

            if(count%2==1)
            {  
                picB_Mute.Image = imgls_Mute.Images[1];
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                count++;
            }

            else if(count%2==0)
            {
                picB_Mute.Image = imgls_Mute.Images[0];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                count++;
            }
        }
        
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.LightBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkViolet;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            Form frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.LightBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkViolet;
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            Form frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();//此行需再多探討
        }
    }
}