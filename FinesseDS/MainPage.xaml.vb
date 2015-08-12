' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim Synn As Synapse, Tvv As TV



    Private Sub TextBlock_Loading(sender As Object, e As RoutedEventArgs)
        Dim tb As TextBlock = sender
        Dim bd As New Binding With {.Source = Me.Tvv, .Path = New PropertyPath(tb.Tag),
            .Mode = BindingMode.TwoWay, .UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged}
        BindingOperations.SetBinding(tb, TextBlock.TextProperty, bd)
    End Sub

    Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
        Synn = Me.Resources("Syn")
        Tvv = Me.Resources("Tv")
        Tvv.Show = "Ughh"




    End Sub
End Class
