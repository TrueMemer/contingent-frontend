﻿using AKITE.Contingent.Client.Services;
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
using AKITE.Contingent.Client.Utilities;
using AKITE.Contingent.Models;

namespace AKITE.Contingent.Client.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для FastTransferDialog.xaml
    /// </summary>
    public partial class FastTransferDialog : CustomDialog
    {
        public Student Student;

        public IEnumerable<Group> Groups => _dataCoordinator.GroupDataService.Groups;

        public int SelectedGroupIndex { get; set; }

        private readonly DataCoordinator _dataCoordinator;

        public FastTransferDialog(Student student, DataCoordinator dataCoordinator)
        {
            this.Student = student;
            this._dataCoordinator = dataCoordinator;
            InitializeComponent();

            DataContext = this;

            SelectedGroupIndex = student.GroupIndex;
        }

        private RelayCommand transferStudent;
        public RelayCommand TransferStudent => transferStudent ??
            (transferStudent = new RelayCommand(obj =>
            {
                this.Student.GroupIndex = SelectedGroupIndex;
            }));
    }
}
