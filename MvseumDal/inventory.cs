//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvseumDal
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventory : ModellBase
    {
        private int _inventoryID;
    	public int InventoryID 
    	{ 
    		get { return _inventoryID; } 
    		set
    		{
    			if (value != _inventoryID) {
    				_inventoryID = value;
    				 OnPropertyChanged("InventoryID");
    			}
    		} 
    	}
    
        private Nullable<int> _bASE_ID;
    	public Nullable<int> BASE_ID 
    	{ 
    		get { return _bASE_ID; } 
    		set
    		{
    			if (value != _bASE_ID) {
    				_bASE_ID = value;
    				 OnPropertyChanged("BASE_ID");
    			}
    		} 
    	}
    
    }
}