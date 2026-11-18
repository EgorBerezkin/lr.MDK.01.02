using System;
using System.Collections.Generic;
using System.Linq;
using DemoLib.Models;
using DemoLib.Views;

namespace DemoLib.Presenters
{
    public class ProductsPresenter
    {
        private IProductsModel model_;
        private List<IProductsView> views_ = new List<IProductsView>();
        private List<Product> allProducts_;

        public ProductsPresenter(IProductsModel model)
        {
            model_ = model;
            allProducts_ = model.Load();
        }

        public void AddView(IProductsView view)
        {
            views_.Add(view);
        }

        public void SortByPrice(SortOrder sortingOrder)
        {
            List<Product> allProducts = new List<Product>(allProducts_);

            if (sortingOrder == SortOrder.Ascending)
            {
                allProducts.Sort(delegate (Product x, Product y)
                {
                    if (x.Price < y.Price) return -1;
                    if (x.Price > y.Price) return 1;
                    return 0;
                });
            }
            else
            {
                allProducts.Sort(delegate (Product x, Product y)
                {
                    if (x.Price < y.Price) return 1;
                    if (x.Price > y.Price) return -1;
                    return 0;
                });
            }
            Update(allProducts);
        }

        public void Update(List<Product> products)
        {
            for (int i = 0; i < views_.Count; i++)
            {
                if (i < products.Count)
                {
                    views_[i].Show(products[i]);  // передача товара в карточку
                    views_[i].SetVisible(true);   // делаем карточку видимой    
                }
                else
                {
                    views_[i].SetVisible(false);
                }
            }
        }
        public void Filter(FilterParametr filterPeremetr)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (Product product in allProducts_)
            {
                bool isVisibleView = true;

                if (filterPeremetr.SearchText != "" && filterPeremetr.SearchText != null)
                {
                    isVisibleView = product.Name.ToLower().Contains(filterPeremetr.SearchText.ToLower())
                        || product.Parts.ToLower().Contains(filterPeremetr.SearchText.ToLower());
                }

                if (filterPeremetr.Category != null && filterPeremetr.Category != "Все товары")
                {
                    isVisibleView = isVisibleView && product.Category == filterPeremetr.Category;
                }

                if (isVisibleView)
                {
                    filteredProducts.Add(product);
                }
            }

            Update(filteredProducts);
        }
        public List<Product> FindProductsByCategory(string category)
        {
            List<Product> allProduct = model_.Load();
            List<Product> categoryProduct = new List<Product>();
            if (category == "Все товары")
            {
                return allProduct;
            }
            foreach(Product p in allProduct)
            {
                if (p.Category.ToLower() == category.ToLower())
                {
                    categoryProduct.Add(p);
                }
            }
            return categoryProduct;
        }
    }
}
