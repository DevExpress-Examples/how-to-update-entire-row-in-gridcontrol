Imports System.Data.Entity

Namespace InfiniteAsyncSourceEFSample
	Public Class IssuesContext
		Inherits DbContext

		Shared Sub New()
			Database.SetInitializer(New IssuesContextInitializer())
		End Sub
		Public Sub New()
		End Sub

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
			MyBase.OnModelCreating(modelBuilder)

			modelBuilder.Entity(Of Issue)().Property(Function(x) x.Subject).IsRequired()
		End Sub

		Public Property Issues() As DbSet(Of Issue)
	End Class
End Namespace
