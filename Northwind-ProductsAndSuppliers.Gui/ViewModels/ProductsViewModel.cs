﻿using Northwind_ProductsAndSuppliers.DataAccess;
using Northwind_ProductsAndSuppliers.Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Northwind_ProductsAndSuppliers.Gui.ViewModels
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Product selectedProduct;

        public ProductsViewModel()
        {
            Products = new ObservableCollection<Product>();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ObservableCollection<Product> Products { get; set; }
        public Product SelectedProduct 
        { 
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public void Initialize()
        {
            LoadAllProducts();
        }

        private void LoadAllProducts()
        {
            ProductRepository productRepository = new ProductRepository();
            IEnumerable<Product> products = productRepository.GetAll();
            Products.ReplaceWith(products);
        }
    }
}
