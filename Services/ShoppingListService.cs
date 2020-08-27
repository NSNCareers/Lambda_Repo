using LambdaShoppingList.Controllers;
using System.Collections.Generic;

namespace LambdaShoppingList.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();

        public ShoppingListService()
        {
           
        }

        public void AddItemToShoppingList(ShoppingListModel shoppingList)
        {

            _shoppingListStorage.Add(shoppingList.Name,shoppingList.Quantity);
        }

        public Dictionary<string,int> GetItemsFromShoppingList()
        {

            return _shoppingListStorage;
        }

        public void RemoveItem(string name)
        {

            _shoppingListStorage.Remove(name);
        }

        public void UpdateItem(ShoppingListModel shoppingList)
        {
            _shoppingListStorage[shoppingList.Name] = shoppingList.Quantity;
        }
    }
}
