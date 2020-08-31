﻿using Northwind_ProductsAndSuppliers.Gui.ViewModels;

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Northwind_ProductsAndSuppliers.Gui
{
    /// <summary>
    /// Interaction logic for ProductsControl.xaml
    /// </summary>
    public partial class ProductsControl : UserControl
    {
        ProductsViewModel productsViewModel;

        public ProductsControl()
        {
            InitializeComponent();
            productsViewModel = this.DataContext as ProductsViewModel;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            productsViewModel.Initialize();
        }
    }
}
