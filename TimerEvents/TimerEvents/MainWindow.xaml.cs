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
using System.Windows.Threading;

namespace TimerEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Console.WriteLine($"Current Value is {myProgressBar.Value}");
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            myProgressBar.Value += 10;
           switch(myProgressBar.Value)
            {
                case 50:
                    loadText.Text = "Halfway There";
                    break;
                case 70:
                    loadText.Text = "Getting Close";
                    break;
                case 90:
                    loadText.Text = "Just a few secs";
                    break;
            }


            if (myProgressBar.Value >= 100)
            {
                _timer.Stop();
                loadText.Text = "Done";
                myProgressBar.Cursor = Cursors.Arrow;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += new EventHandler(dispatcherTimer_Tick);
            _timer.Start();
        }
    }
}
