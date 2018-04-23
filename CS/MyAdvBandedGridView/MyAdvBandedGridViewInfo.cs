using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace MyXtraGrid
{
    public class MyAdvBandedGridViewInfo : AdvBandedGridViewInfo
    {
        public MyAdvBandedGridViewInfo(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridView)
            : base(gridView)
        {
            
        }
    }
}
