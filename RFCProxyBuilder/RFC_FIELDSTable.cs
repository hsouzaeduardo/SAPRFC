
//------------------------------------------------------------------------------
// 
//     This code was generated by a SAP. NET Connector Proxy Generator Version 2.0
//     Created at 2006-12-13
//     Created from Windows
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// 
//------------------------------------------------------------------------------
using System;
//using System.Text;
//using System.Collections;
//using System.Runtime.InteropServices;
using System.Xml.Serialization;
//using System.Web.Services;
//using System.Web.Services.Description;
//using System.Web.Services.Protocols;
using SAP.Connector;

namespace RFCProxyBuilder
{
  /// <summary>
  /// A typed collection of RFC_FIELDS elements.
  /// </summary>
  [Serializable]
  public class RFC_FIELDSTable : SAPTable 
  {
  
    /// <summary>
    /// Returns the element type RFC_FIELDS.
    /// </summary>
    /// <returns>The type RFC_FIELDS.</returns>
    public override Type GetElementType() 
    {
        return (typeof(RFC_FIELDS));
    }

    /// <summary>
    /// Creates an empty new row of type RFC_FIELDS.
    /// </summary>
    /// <returns>The newRFC_FIELDS.</returns>
    public override object CreateNewRow()
    { 
        return new RFC_FIELDS();
    }
     
    /// <summary>
    /// The indexer of the collection.
    /// </summary>
    public RFC_FIELDS this[int index] 
    {
        get 
        {
            return ((RFC_FIELDS)(List[index]));
        }
        set 
        {
            List[index] = value;
        }
    }
        
    /// <summary>
    /// Adds a RFC_FIELDS to the end of the collection.
    /// </summary>
    /// <param name="value">The RFC_FIELDS to be added to the end of the collection.</param>
    /// <returns>The index of the newRFC_FIELDS.</returns>
    public int Add(RFC_FIELDS value) 
    {
        return List.Add(value);
    }
        
    /// <summary>
    /// Inserts a RFC_FIELDS into the collection at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which value should be inserted.</param>
    /// <param name="value">The RFC_FIELDS to insert.</param>
    public void Insert(int index, RFC_FIELDS value) 
    {
        List.Insert(index, value);
    }
        
    /// <summary>
    /// Searches for the specified RFC_FIELDS and returnes the zero-based index of the first occurrence in the collection.
    /// </summary>
    /// <param name="value">The RFC_FIELDS to locate in the collection.</param>
    /// <returns>The index of the object found or -1.</returns>
    public int IndexOf(RFC_FIELDS value) 
    {
        return List.IndexOf(value);
    }
        
    /// <summary>
    /// Determines wheter an element is in the collection.
    /// </summary>
    /// <param name="value">The RFC_FIELDS to locate in the collection.</param>
    /// <returns>True if found; else false.</returns>
    public bool Contains(RFC_FIELDS value) 
    {
        return List.Contains(value);
    }
        
    /// <summary>
    /// Removes the first occurrence of the specified RFC_FIELDS from the collection.
    /// </summary>
    /// <param name="value">The RFC_FIELDS to remove from the collection.</param>
    public void Remove(RFC_FIELDS value) 
    {
        List.Remove(value);
    }

    /// <summary>
    /// Copies the contents of the RFC_FIELDSTable to the specified one-dimensional array starting at the specified index in the target array.
    /// </summary>
    /// <param name="array">The one-dimensional destination array.</param>           
    /// <param name="index">The zero-based index in array at which copying begins.</param>           
    public void CopyTo(RFC_FIELDS[] array, int index) 
    {
        List.CopyTo(array, index);
	}
  }
}