using System.Collections.Generic;

namespace DemoLib.Models
{
    public interface IProductsModel
    {
        List<Product> Load();     // список для метода загрузки товаров
        int GetCountProducts();   // возвращение количества товаров
        List<string> GetAllCategories();
    }
}
