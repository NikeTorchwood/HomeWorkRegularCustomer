using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace HomeWorkRegularCustomer;

public class Shop
{
    private ObservableCollection<Item> _items;

    public Shop()
    {
        _items = new ObservableCollection<Item>();
    }
    public void Add()
    {
        var item = new Item(_items.Count+1, $"Товар от {DateTime.Now}");
        _items.Add(item);
    }

    public void Remove(int itemId)
    {
        _items.Remove(_items[itemId - 1]);
    }

    public void SubscribeUser(Customer customer)
    {
        _items.CollectionChanged += new NotifyCollectionChangedEventHandler(customer.OnItemChanged);
    }
    public void ShowItems()
    {
        Console.WriteLine();
        foreach (var item in _items)
        {
            Console.WriteLine($"|Id: {item.Id} | Name {item.Name} |");
        }
    }
}