﻿using AKITE.Contingent.Client.ViewModels;
using MahApps.Metro.Controls.Dialogs;
using System;
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
using AKITE.Contingent.Client.Services;
using AKITE.Contingent.Client.Utilities;

namespace AKITE.Contingent.Client.Pages
{
    /// <summary>
    /// Логика взаимодействия для StudentListing.xaml
    /// </summary>
    public partial class StudentListing : Page
    {
        public StudentListing(DataCoordinator dataCoordinator, Navigator navigator)
        {
            DataContext = new StudentListingViewModel(DialogCoordinator.Instance, dataCoordinator, navigator);

            InitializeComponent();
        }
    }
}
