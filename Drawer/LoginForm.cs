using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Drawer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //MainForm mainForm = new MainForm(); // 创建主界面实例 
            //mainForm.Show(); // 显示主界面
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textUserName.Text; 
            string password = textPassWD.Text; // 验证用户名和密码 
            string[] lines = File.ReadAllLines("data.bin"); // 读取文件中的用户信息 
            if (lines.Contains(username + " " + password)) 
            { 
              this.Hide(); // 隐藏当前窗体 
            MainForm mainForm = new MainForm(); // 创建主界面实例 
            mainForm.Show(); // 显示主界面
              this.Close(); // 关闭当前窗体
            } 
            else 
            {
                MessageBox.Show("用户名或密码错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
           
        }

    }
}
