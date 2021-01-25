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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    private void L_KeyUp(object sender, KeyEventArgs e)
    {
        if (Keyboard.IsKeyUp(Key.A))
        {
            l.Margintest.Margin = new Thickness(-2, 0, 0, 0);
        }
        if (Keyboard.IsKeyUp(Key.D))
        {
            l.Margintest.Margin = new Thickness(+2, 0, 0, 0);
        }
        if (Keyboard.IsKeyUp(Key.Space))
        {
            //прыжок
        }
        if (Keyboard.IsKeyUp(Key.A) && Keyboard.IsKeyUp(Key.W))
        {
            //прыжок
        }
        if (Keyboard.IsKeyUp(Key.D) && Keyboard.IsKeyUp(Key.W))
        {
            //прыжок
        }

    }
}
