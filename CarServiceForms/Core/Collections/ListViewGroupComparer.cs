using CarServiceForms.Classes;
using System.Collections;

using System.Windows.Forms;

namespace CarServiceForms.Core.Collections
{
    class ListViewGroupComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            var xListViewGroup = x as ListViewGroup;
            var yListViewGroup = y as ListViewGroup;
            if (xListViewGroup == null || yListViewGroup == null)
            {
                return 0;
            }

            var xServiceItemGroupDTO = xListViewGroup.Tag as ServiceItemWithServiceItemGroupDTO;
            var yServiceItemGroupDTO = yListViewGroup.Tag as ServiceItemWithServiceItemGroupDTO;

            return xServiceItemGroupDTO.ServiceItemGroupOrder.CompareTo(yServiceItemGroupDTO.ServiceItemGroupOrder);
        }
    }
}
