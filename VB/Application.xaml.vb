Imports DevExpress.Internal
Imports System.Windows

Namespace InfiniteAsyncSourceEFSample
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Public Sub New()
			DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory()
		End Sub
	End Class
End Namespace
