Imports System.Collections.Generic

Namespace InfiniteAsyncSourceEFSample
	Public Class User
		Public Property Id() As Integer
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Overridable Property Issues() As ICollection(Of Issue)
	End Class
End Namespace
