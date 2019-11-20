Imports System
Imports System.Data.Entity
Imports System.Linq

Namespace InfiniteAsyncSourceEFSample
	Public Class IssuesContextInitializer
		Inherits DropCreateDatabaseIfModelChanges(Of IssuesContext)

		Protected Overrides Sub Seed(ByVal context As IssuesContext)
			MyBase.Seed(context)
			Dim rnd = New Random()
			Dim issues = Enumerable.Range(0, 1000).Select(Function(i) New Issue() With {
				.Subject = OutlookDataGenerator.GetSubject(),
				.Created = Date.Today.AddDays(-rnd.Next(30)),
				.Priority = OutlookDataGenerator.GetPriority(),
				.Votes = rnd.Next(100)
			}).ToArray()
			context.Issues.AddRange(issues)

			context.SaveChanges()
		End Sub
	End Class
End Namespace
