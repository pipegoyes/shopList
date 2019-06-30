using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Core.SharedKernel;

namespace CleanArchitecture.Core.Entities
{
    public class ShopList : BaseEntity
    {
        public IList<ShopItem> ShopItems { get; }

        public ShopList()
        {
            ShopItems = new List<ShopItem>();
        }

        public ShopItem AddShopItem(ShopItem newItem)
        {
            ShopItems.Add(newItem);
            Events.Add(new AddedShopItemEvent(newItem));
            return newItem;
        }

        //public void DeleteShopItem(ShopItem removedItem)
        //{
        //    var selectedItem = ShopItems.Remove(removedItem);
        //    Events.Add(new DeletedShopItemEvent(removedItem));
        //}
    }

    public class AddedShopItemEvent : BaseDomainEvent
    {
        public AddedShopItemEvent(ShopItem newItem)
        {
            AddedShopItem = newItem;
        }

        public ShopItem AddedShopItem { get; }
    }
}
