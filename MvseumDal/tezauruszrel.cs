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
    
    public partial class tezauruszrel : ModellBase
    {
        private int _tezauruszRelId;
    	public int TezauruszRelId 
    	{ 
    		get { return _tezauruszRelId; } 
    		set
    		{
    			if (value != _tezauruszRelId) {
    				_tezauruszRelId = value;
    				 OnPropertyChanged("TezauruszRelId");
    			}
    		} 
    	}
    
        private Nullable<int> _sUPER_TYPE_ID;
    	public Nullable<int> SUPER_TYPE_ID 
    	{ 
    		get { return _sUPER_TYPE_ID; } 
    		set
    		{
    			if (value != _sUPER_TYPE_ID) {
    				_sUPER_TYPE_ID = value;
    				 OnPropertyChanged("SUPER_TYPE_ID");
    			}
    		} 
    	}
    
        private Nullable<int> _rEL_LEFT;
    	public Nullable<int> REL_LEFT 
    	{ 
    		get { return _rEL_LEFT; } 
    		set
    		{
    			if (value != _rEL_LEFT) {
    				_rEL_LEFT = value;
    				 OnPropertyChanged("REL_LEFT");
    			}
    		} 
    	}
    
        private Nullable<int> _rEL_RIGHT;
    	public Nullable<int> REL_RIGHT 
    	{ 
    		get { return _rEL_RIGHT; } 
    		set
    		{
    			if (value != _rEL_RIGHT) {
    				_rEL_RIGHT = value;
    				 OnPropertyChanged("REL_RIGHT");
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
