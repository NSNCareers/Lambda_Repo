using LambdaShoppingList.Models;
using System;
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
            try
            {
                _shoppingListStorage.Add(shoppingList.Name,shoppingList.Quantity);
            }
            catch (Exception e)
            {
                throw(new Exception(e.Message));
            }
        }

        public Dictionary<string,int> GetItemsFromShoppingList()
        {
             try
            {
                return _shoppingListStorage;
            }
            catch (Exception e)
            {
                throw(new Exception(e.Message));
            }
        }

        public void RemoveItem(string name)
        {
              try
            {
                _shoppingListStorage.Remove(name);
            }
            catch (Exception e)
            {
                throw(new Exception(e.Message));
            }
        }

        public void UpdateItem(ShoppingListModel shoppingList)
        {
              try
            {
                _shoppingListStorage[shoppingList.Name] = shoppingList.Quantity;
            }
            catch (Exception e)
            {
                throw(new Exception(e.Message));
            }
        }
    }
}
