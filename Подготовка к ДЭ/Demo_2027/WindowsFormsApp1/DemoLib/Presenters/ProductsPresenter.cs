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
            List<Product> allProducts = new List<Product>(allProducts_); // создание копии списка, для тго чтобы не изменять исходный список
            // сортировка по возрастанию
            if (sortingOrder == SortOrder.Ascending)
            {
                allProducts.Sort(delegate (Product x, Product y)
                {
                    if (x.Price < y.Price) return -1;
                    if (x.Price > y.Price) return 1;
                    return 0;
                });
            }
            // иначе по убыванию
            else
            {
                allProducts.Sort(delegate (Product x, Product y)
                {
                    if (x.Price < y.Price) return 1;
                    if (x.Price > y.Price) return -1;
                    return 0;
                });
            }
            Update(allProducts); // список передается передается карточкам товаров
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
            // перебор всех товаров
            foreach (IProductsView view in views_)
            {
                Product product = view.GetProduct();
                // проверка видимости товаров
                bool isVisibleView = true;
                // проверка поискового текста
                if (filterPeremetr.SearchText != "" && filterPeremetr.SearchText != null) // поисковая строка не пустая, и не равна нулю
                {
                    isVisibleView = product.Name.ToLower().Contains(filterPeremetr.SearchText.ToLower()) // перевод названия товара в нижний регистр
                        || product.Parts.ToLower().Contains(filterPeremetr.SearchText.ToLower());
                }
                // проверка категории
                if (filterPeremetr.Category != null && filterPeremetr.Category != "Все товары") // категория указана и выбрана не общая категория
                {
                    // проверка двух условий: товар прошел проверку поиска, категория товара совпадает с выбранной категорией
                    isVisibleView &= (product.Category == filterPeremetr.Category);
                }
                view.SetVisible(isVisibleView);
            }
        }
    }
}
