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

namespace DataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person PersonOne { get; set; }
        public Person PersonTwo { get; set; }
        public Person PersonThree { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PersonOne = new Person { FirstName = "Domnik", LastName = "Swatek", Age = 34 };
            PersonTwo = new Person { FirstName = "Jan", LastName = "Nowak", Age = 29 }; 
            PersonThree = new Person { FirstName = "Adam", LastName = "Małysz", Age = 40 };
            this.DataContext = this;

        }
    }
}
