using LambdaShoppingList.Controllers;
using System.Collections.Generic;

namespace LambdaShoppingList.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemToShoppingList(ShoppingListModel shoppingList);
        void RemoveItem(string name);
        void UpdateItem(ShoppingListModel shoppingList);
    }
}