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
    
    public partial class subjectparam : ModellBase
    {
        private int _subjectParamIId;
    	public int SubjectParamIId 
    	{ 
    		get { return _subjectParamIId; } 
    		set
    		{
    			if (value != _subjectParamIId) {
    				_subjectParamIId = value;
    				 OnPropertyChanged("SubjectParamIId");
    			}
    		} 
    	}
    
        private Nullable<int> _subjectID;
    	public Nullable<int> SubjectID 
    	{ 
    		get { return _subjectID; } 
    		set
    		{
    			if (value != _subjectID) {
    				_subjectID = value;
    				 OnPropertyChanged("SubjectID");
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
