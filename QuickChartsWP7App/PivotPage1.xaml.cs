﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Collections.ObjectModel;
using QuickChartsWPApp;

namespace QuickChartsWP7App
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
        }

        public ObservableCollection<PData> Data = new ObservableCollection<PData>()
        {
            new PData() { title = "slice #1", value = 30 },
            new PData() { title = "slice #2", value = 60 },
            new PData() { title = "slice #3", value = 40 },
            new PData() { title = "slice #4", value = 10 },
        };

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            pie1.DataSource = Data;
        }
    }
}