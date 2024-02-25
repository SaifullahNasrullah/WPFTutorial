﻿using System;
using System.Windows;
using System.Windows.Input;

namespace WPFTutorial8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(Object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnMinimize_Click(Object sender, RoutedEventArgs e)
        {
           WindowState= WindowState.Minimized;
        }

        private void btnMaximize_Click(Object sender, RoutedEventArgs e)
        {
            if(WindowState== WindowState.Maximized)
                WindowState= WindowState.Normal;
            else WindowState= WindowState.Maximized;
        }

        private void btnClose_Click(Object sender, RoutedEventArgs e)
        {
            Close();
            // Application.Current.Shutdown();
        }
    }
}
