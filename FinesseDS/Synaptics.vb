Public Class Synaptics
    Class Fingerprints
        Public Property Test1

    End Class
    Class Specs

    End Class
    Class HeroSheet

    End Class
    Class Genome

    End Class
End Class

Public Class EmissionsTest
    Private _transposed As New Dictionary(Of String, Object)
    Sub New()
        With _transposed
            .Add("Test1", 2356)
            .Add("Test2", "Fart")
            .Add("Test3", 326523.54532)
        End With
    End Sub
    Public ReadOnly Property Emit As ObservableCollection(Of String)
        Get
            Emit = New ObservableCollection(Of String)(_transposed.Keys.ToList)
        End Get
    End Property
    Default Public Property Item(ByVal key As String)
        Get
            If _transposed.ContainsKey(key) Then
                Return _transposed(key)
            Else
                Return Nothing
            End If
        End Get
        Set(value)
            If _transposed.ContainsKey(key) Then
                _transposed(key) = value
            End If
        End Set
    End Property
End Class