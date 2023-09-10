using System.Collections.Specialized;

namespace HomeWorkRegularCustomer;

public class Customer
{
    private string _name;
    public Customer(string name)
    {
        _name = name;
    }

    public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                Item newItem = e.NewItems[0] as Item;
                Console.WriteLine($"Пользователь {_name} узнал, что в магазин добавлен элемент c названием {newItem.Name} и индентификатором {newItem.Id}");
                break;
            case NotifyCollectionChangedAction.Remove:
                Item deletedItem = e.OldItems[0] as Item;
                Console.WriteLine($"Пользователь {_name} узнал, что в магазине удален элемент {deletedItem.Name}");
                break;
        }
    }
}