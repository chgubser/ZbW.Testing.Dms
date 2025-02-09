﻿using System;
using System.Windows.Controls;

using ZbW.Testing.Dms.Client.ViewModels;

namespace ZbW.Testing.Dms.Client.Views
{


    /// <summary>
    /// Interaction logic for NewDocumentView.xaml
    /// </summary>
    public partial class DocumentDetailView : UserControl
    {
        public DocumentDetailView(string benutzer, Action navigateBack)
        {
            InitializeComponent();
            DataContext = new DocumentDetailViewModel(benutzer, navigateBack);
        }
    }
}