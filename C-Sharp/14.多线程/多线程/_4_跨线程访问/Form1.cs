using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _4_跨线程访问
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //回调委托
        private delegate void DelCallback(string str);
        DelCallback call;

        /// <summary>
        /// 改变控件值方法
        /// </summary>
        /// <param name="str"></param>
        private void Change(string str)
        {
            this.lbl_val.Text = str;
        }

        /// <summary>
        /// 新线程方法
        /// </summary>
        private void Test()
        {
            int i = 0;
            while (true)
            {
                i++;
                //使用回调委托跨线程改变值
                this.lbl_val.Invoke(call, i.ToString());
                //线程延时
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 开始变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chgVal_Click(object sender, EventArgs e)
        {
            call = new DelCallback(Change); //实现回调委托
            //启动后台线程改变数据
            Thread th=new Thread(new ThreadStart(Test));
            th.IsBackground = true; //设置为后台线程
            th.Start();//启动线程

            this.btn_chgVal.Enabled = false;
        }


    }
}
