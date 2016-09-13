﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CaptchaProcess
{
    /// <summary>
    /// SPsetting.xaml 的交互逻辑
    /// </summary>
    public partial class SPsetting : Window
    {
        //子窗口初始化
        public SPsetting()
        {
            InitializeComponent();
        }
        //参数设置完成后将设置值传递给Sauvola函数用变量
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.m_SauvolaWidth = int.Parse(widthValue.Text);

            MainWindow.m_SauvolaFactor = float.Parse(factorValue.Text);

            MainWindow.m_SpWindow.Hide();
        }


    }
}
