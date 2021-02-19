using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        Articles,
        Orders,
        OrderHistory,
        Goals,
        Messages
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
