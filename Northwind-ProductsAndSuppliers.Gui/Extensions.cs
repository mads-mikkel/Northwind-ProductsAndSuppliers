﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Northwind_ProductsAndSuppliers.Gui
{
    public static class Extensions
    {
        public static void ReplaceWith<T>(this ObservableCollection<T> observableCollection, IEnumerable<T> collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            observableCollection.Clear();
            foreach (T item in collection)
            {
                observableCollection.Add(item);
            }
        }
    }
}