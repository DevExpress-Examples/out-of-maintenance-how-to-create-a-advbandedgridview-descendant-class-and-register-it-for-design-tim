using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace MyXtraGrid
{
    public class MyAdvBandedGridInfoRegistrator : AdvBandedGridInfoRegistrator
    {
        public override string ViewName { get { return "MyAdvBandedGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyAdvBandedGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyAdvBandedGridViewInfo(view as MyAdvBandedGridView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new MyAdvBandedGridViewHandler(view as MyAdvBandedGridView); }
    }
}
