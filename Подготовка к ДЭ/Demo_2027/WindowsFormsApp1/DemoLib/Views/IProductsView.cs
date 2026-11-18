namespace DemoLib.Views
{
    public interface IProductsView
    {
        void Show(Product product);       // отображение информации о товаре
        void SetVisible(bool visible);   // управление видимости карточек
        Product GetProduct();
    }
}
