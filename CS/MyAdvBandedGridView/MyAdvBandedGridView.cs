using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;

namespace MyXtraGrid
{
    public class MyAdvBandedGridView : AdvBandedGridView
    {
        public MyAdvBandedGridView(DevExpress.XtraGrid.GridControl ownerGrid)
            : base(ownerGrid)
        {
            
        }
        public MyAdvBandedGridView()
        {
            
        }
        protected override string ViewName { get { return "MyAdvBandedGridView"; } }
    }
}
