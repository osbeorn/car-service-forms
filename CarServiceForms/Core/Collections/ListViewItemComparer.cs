using CarServiceForms.Classes;
using System.Collections;

using System.Windows.Forms;

namespace CarServiceForms.Core.Collections
{
    class ListViewItemComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            var xListViewItem = x as ListViewItem;
            var yListViewItem = y as ListViewItem;
            if (xListViewItem == null || yListViewItem == null)
            {
                return 0;
            }

            var xServiceItemDTO = xListViewItem.Tag as ServiceItemWithServiceItemGroupDTO;
            var yServiceItemDTO = yListViewItem.Tag as ServiceItemWithServiceItemGroupDTO;

            var result = xServiceItemDTO.ServiceItemGroupOrder.CompareTo(yServiceItemDTO.ServiceItemGroupOrder);
            if (result == 0)
            {
                return xServiceItemDTO.Order.CompareTo(yServiceItemDTO.Order);
            }
            else
            {
                return result;
            }
        }
    }
}
