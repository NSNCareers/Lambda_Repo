using LambdaShoppingList.Services;
using LambdaShoppingList.Models;
using Microsoft.AspNetCore.Mvc;

namespace LambdaShoppingList.Controllers
{
    [Route("v1aws/shoppingList")]
    public class ShoppingListController : Controller
    {
        public readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }


        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var results = _shoppingListService.GetItemsFromShoppingList();
            return Ok(results);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody]ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemToShoppingList(shoppingList);

            return Ok($"Successfully added {shoppingList.Name}");
        }

        [HttpDelete]
        public IActionResult DeleteItemFromShoppingList([FromBody]ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);

            return Ok($"Successfully deleted {shoppingList.Name}");
        }

        [HttpPut]
        public IActionResult UpdateItemInShoppingList([FromBody]ShoppingListModel shoppingList)
        {
            _shoppingListService.UpdateItem(shoppingList);

            return Ok($"Successfully updated {shoppingList.Name}");
        }
    }
}