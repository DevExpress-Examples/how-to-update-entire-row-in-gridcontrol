Imports DevExpress.Xpf.Grid
Imports System.Linq
Imports System.Windows

Namespace InfiniteAsyncSourceEFSample
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()

			Dim context = New IssuesContext()
			grid.ItemsSource = context.Issues.ToArray()
		End Sub

		Private Sub TableView_ValidateRow(ByVal sender As Object, ByVal e As GridRowValidationEventArgs)
			Dim issue = CType(e.Row, Issue)
			Using context = New IssuesContext()
				Dim result = context.Issues.SingleOrDefault(Function(b) b.Id = issue.Id)
				If result IsNot Nothing Then
					result.Subject = issue.Subject
					result.Priority = issue.Priority
					result.Votes = issue.Votes
					result.Priority = issue.Priority
					context.SaveChanges()
				End If
			End Using
		End Sub
	End Class
End Namespace
