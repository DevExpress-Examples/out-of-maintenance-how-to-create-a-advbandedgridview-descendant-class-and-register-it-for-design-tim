Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.BandedGrid

Namespace MyXtraGrid
	Public Class MyAdvBandedGridViewInfo
		Inherits AdvBandedGridViewInfo
		Public Sub New(ByVal gridView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)
			MyBase.New(gridView)

		End Sub
	End Class
End Namespace
