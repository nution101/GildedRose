﻿using System;

namespace DataAccessLibrary
{
    //Defines the Inventory Item data object
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public bool QualityAppreciates { get; set; }
    }
}