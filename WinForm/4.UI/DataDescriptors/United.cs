using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.UI.DataDescriptors
{
    /// <summary>
    /// Data visualization style
    /// </summary>
    public enum EditorDataStyle
    {
        Decimal, Number, Money, Percent, DateTime, Date
    }

    /// <summary>
    /// Delegate of getting data method for EditorColumnMode.ListBox
    /// </summary>
    /// <returns></returns>
    public delegate object GetListBoxItemsDelegate();

    /// <summary>
    /// Delegate of format data method 
    /// </summary>
    /// <param name="DataBoundItem"></param>
    /// <param name="DataPropertyName"></param>
    /// <returns></returns>
    public delegate object FormatValueDelegate(object DataBoundItem, string DataPropertyName);
}
