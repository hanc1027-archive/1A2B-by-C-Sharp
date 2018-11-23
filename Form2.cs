//
//  Form2.cs
//  自訂題目模式
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
using System.Media;

namespace _1A2B
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "1A2B 自訂題目模式";
            lbl_input.BackColor = Color.Transparent;    
            lbl_output.BackColor = Color.Transparent;
            lbl_errormsg.BackColor = Color.Transparent;
            lbl_back.BackColor = Color.Transparent;

            lbl_input.ForeColor = Color.Wheat; 
            lbl_output.ForeColor = Color.Wheat;
            lbl_back.ForeColor = Color.Red;

            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            string guessnumICO_Path = dir.Parent.Parent.FullName + "\\Pictures\\";
            this.Icon = Icon.ExtractAssociatedIcon(guessnumICO_Path + "1A2B.ico");
            this.BackgroundImage = Image.FromFile(guessnumICO_Path + "02.jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; //讓背景圖片大小符合視窗大小



            string Music_Path = dir.Parent.Parent.FullName + "\\Music\\";

            axWindowsMediaPlayer1.URL = @Music_Path + "Play.mp3";
            axWindowsMediaPlayer1.settings.volume = 50; //WMP音量預設值為50
            axWindowsMediaPlayer1.Visible = false; //隱藏撥放器
            axWindowsMediaPlayer1.settings.autoStart = true;	//預設自動播放

            picB_Mute.Image = imgls_Mute.Images[0];
            picB_Mute.BackColor = Color.Transparent;

            lbl_output.Visible = false;
            txtB_output.Visible = false;
            btn_output.Visible = false;

            txtB_input.MaxLength = 4;
            txtB_output.MaxLength = 4;

            
            lbl_outcome.Text = "遊戲說明:\r\n"+
                               "1.請先輸入自訂的題目，應為4位數數字\r\n"+
                               "2.數碼0不可置於最前面\r\n"+
                               "3.題目輸入完畢後，按下確定鍵即可開始猜數字\r\n"+
                               "4.當使用者輸入的數字&位置與答案相符時，便會顯示A\r\n"+
                               "5.當使用者輸入的數字與答案相符，但位置不符時，便顯示B\r\n"+
                               "6.例如，答案為8417 ，使用者輸入1495，提示框則會輸出1A1B\r\n";
            
        }


        int count;
        private void picB_Mute_Click(object sender, EventArgs e)
        {

            if (count % 2 == 1)
            {
                picB_Mute.Image = imgls_Mute.Images[1];
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                count++;
            }

            else if (count % 2 == 0)
            {
                picB_Mute.Image = imgls_Mute.Images[0];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                count++;
            }
        }

        int ans;
        
        private void btn_intput_Click(object sender, EventArgs e)
        {
            if (txtB_input.TextLength < 4)
            {
                txtB_input.Text = string.Empty;
                lbl_errormsg.Text = "請輸入正確位數!";
                lbl_errormsg.Font = new Font("微軟正黑體", 15);
                lbl_errormsg.ForeColor = Color.Red;

            }

            else if(txtB_input.TextLength == 4)
            {
                ans = Convert.ToInt32(txtB_input.Text);

                int[] confirminput = new int[4];
                  confirminput[0] = (ans / 1000) % 10;//取答案千位的數字
                  confirminput[1] = (ans / 100) % 10;//取答案百位的數字
                  confirminput[2] = (ans / 10) % 10;//取答案十位的數字
                  confirminput[3] = ans % 10;//取答案個位的數字

                  int i, j;
                  for (i = 0; i < 4; i++)
                  {
                      for (j = i + 1; j < 4; j++)
                      {
                          if (confirminput[i] == confirminput[j])
                          {
                              txtB_input.Text = string.Empty;
                              lbl_errormsg.Text = "數字重複!";
                              lbl_errormsg.ForeColor = Color.Red;
                            return;
                          }
                      }
                  }

                
                lbl_input.Visible = false;
                txtB_input.Visible = false;
                btn_input.Visible = false;

                lbl_output.Visible = true;
                txtB_output.Visible = true;
                btn_output.Visible = true;
                txtB_output.Focus();

                lbl_errormsg.Text = "題目已儲存";
                lbl_errormsg.ForeColor = Color.AliceBlue;
            }
        }

        int user_ans;
        private static int cc = 0;
        string outcome = string.Empty;
        string all_outome = string.Empty;
        private void btn_output_Click(object sender, EventArgs e)
        {
            if (txtB_output.TextLength < 4)
            {
                txtB_output.Clear();
                lbl_errormsg.Text = "請輸入正確位數!";
                lbl_errormsg.Font = new Font("微軟正黑體", 15);
                lbl_errormsg.ForeColor = Color.Red;

            }

            else if(txtB_output.TextLength == 4)
            {
                user_ans = Convert.ToInt32(txtB_output.Text);
                int[] a = new int[4];
                int[] b = new int[4];
                outcome = txtB_output.Text;
                a[0] = (ans / 1000) % 10;//取答案千位的數字
                a[1] = (ans / 100) % 10;//取答案百位的數字
                a[2] = (ans / 10) % 10;//取答案十位的數字
                a[3] = ans % 10;//取答案個位的數字

                b[0] = (user_ans / 1000) % 10;//取輸入千位的數字
                b[1] = (user_ans / 100) % 10;//取輸入百位的數字
                b[2] = (user_ans / 10) % 10;//取輸入十位的數字
                b[3] = user_ans % 10;//取輸入個位的數字


                int i, j;
                for (i = 0; i < 4; i++)
                {
                    for (j = i + 1; j < 4; j++)
                    {
                        if (b[i] == b[j])
                        {
                            txtB_output.Text = string.Empty;
                            lbl_errormsg.Text = "數字重複!";
                            lbl_errormsg.ForeColor = Color.Red;
                            return;
                        }
                    }
                }

                int u = 0;
                for (i = 0; i < 4; i++)
                {//判斷有幾A
                    if (a[i] == b[i])
                    {
                        u++;
                    }
                }

                if (u == 4)
                {
                    txtB_output.Clear();
                    DialogResult result;
                    result = MessageBox.Show("恭喜過關!\r\n答案為   "+txtB_input.Text, "成功破解1A2B", MessageBoxButtons.OK);
                    if(DialogResult.OK == result)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        Form frm1 = new Form1();
                        frm1.Show();
                        this.Hide();
                    }
                }

                else if (u != 4)
                {
                    int u1 = 0;
                    for (i = 0; i < 4; i++)
                    {//判斷有幾B
                        for (j = 0; j < 4; j++)
                        {
                            if (a[i] == b[j])
                            {
                                u1++;
                            }
                        }
                    }

                    lbl_outcome.Text = string.Empty;
                    cc++;
                    all_outome = all_outome + "您第" + Convert.ToString(cc) + "次輸入" + outcome + "      " + Convert.ToString(u) + 'A' + Convert.ToString(u1 - u) + 'B' + "\r\n";
                    lbl_outcome.Text = all_outome;
                    txtB_output.Clear();
                }
                
            }
        }
//輸入數字判斷是否符合要求
        private void txtB_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_intput_Click(sender, e);
            }

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != '\b' && e.KeyChar !=13 )
                {
                    e.Handled = true;
                    lbl_errormsg.Text = "請輸入數字!";
                    lbl_errormsg.ForeColor = Color.Red;  
                }  
            }

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                lbl_errormsg.Text = string.Empty;
            }   

        }

        private void txtB_output_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_output_Click(sender, e);
            }

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != '\b' && e.KeyChar != 13)
                {
                    e.Handled = true;
                    lbl_errormsg.Text = "請輸入數字!";
                    lbl_errormsg.ForeColor = Color.Red;
                }
            }

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                lbl_errormsg.Text = string.Empty;
            }
        }
//輸入數字判斷是否符合要求 結束

        private void lbl_back_MouseEnter(object sender, EventArgs e)
        {
            lbl_back.ForeColor = Color.Gray;
        }

        private void lbl_back_MouseLeave(object sender, EventArgs e)
        {
            lbl_back.ForeColor = Color.Red;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Form frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Form frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
