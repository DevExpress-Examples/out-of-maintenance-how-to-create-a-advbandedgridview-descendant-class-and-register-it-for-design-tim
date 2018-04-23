Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo

Namespace MyXtraGrid
	Public Class MyAdvBandedGridInfoRegistrator
		Inherits AdvBandedGridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyAdvBandedGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyAdvBandedGridView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
			Return New MyAdvBandedGridViewInfo(TryCast(view, MyAdvBandedGridView))
		End Function
		Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
			Return New MyAdvBandedGridViewHandler(TryCast(view, MyAdvBandedGridView))
		End Function
	End Class
End Namespace
