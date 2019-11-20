Imports System

Namespace InfiniteAsyncSourceEFSample
	Public Class Issue
		Public Property Id() As Integer
		Public Property Subject() As String
		Public Property Created() As Date
		Public Property Votes() As Integer
		Public Property Priority() As Priority
	End Class
	Public Enum Priority
		Low
		BelowNormal
		Normal
		AboveNormal
		High
	End Enum
End Namespace
