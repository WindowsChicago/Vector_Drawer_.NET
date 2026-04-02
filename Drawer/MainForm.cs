using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Drawer
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm(); // 创建登录界面实例 
            //loginForm.ShowDialog(); // 显示登录界面 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // 更新时间标签
        }

        private void pictureBoxCanvas_MouseMove(object sender, EventArgs e)
        {
            //if (isDrawing) // 判断是否正在绘制 
            {
                Graphics g = panel1.CreateGraphics();
                // g.Clear(Color.White); // 清除背景
                // g.DrawRectangle(Pens.Black, startX, startY, e.X - startX, e.Y - startY); // 绘制矩形 }
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // panel1.DrawToBitmap(new Bitm ap(panel1.Width, panel1.Height), new Rectangle(0, 0, panel1.Width, panel1.Height)); 
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vector Drawer Build 4","关于本程序", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
