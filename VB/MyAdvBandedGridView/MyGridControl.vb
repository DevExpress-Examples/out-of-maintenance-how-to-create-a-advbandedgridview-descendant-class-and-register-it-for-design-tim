Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace MyXtraGrid
	Public Class MyGridControl
		Inherits GridControl
		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyAdvBandedGridView")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyAdvBandedGridInfoRegistrator())
		End Sub
	End Class
End Namespace
