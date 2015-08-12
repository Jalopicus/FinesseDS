Public Class Synapse
    Private _Boredom As New ObservableCollection(Of TV)
    Private _Emission As New List(Of String)
    Sub New()
        With Me
            .Add("True Detective", 2, False, "Everybody dies.")
            .Add("Ray Donovan", 3, True, "Ray wins.")
            .Add("House of Cards", 3, True, "Frank wins.")
            .Add("Halt and Catch Fire", 2, True, "Everyone loses.")
            .Add("Falling Skies", 5, False, "Who cares?")
            .Add("Daredevil", 1, True, "Badassery.")
        End With
        With _Emission
            .Add("Show")
            .Add("Season")
            .Add("AnyGood")
            .Add("Spoiler")
        End With
    End Sub
    Sub Add(show As String, season As Integer, anyGood As Boolean, spoiler As String)
        Boredom.Add(New TV With {.Show = show, .Season = season, .AnyGood = anyGood, .Spoiler = spoiler})
    End Sub
    Public ReadOnly Property Emission As List(Of String)
        Get
            Emission = _Emission
        End Get
    End Property
    Public ReadOnly Property Boredom As ObservableCollection(Of TV)
        Get
            Boredom = _Boredom
        End Get
    End Property
End Class
Public Class TV
        Private _show As String, _season As Integer, _anyGood As Boolean, _spoiler As String
        Public Sub New()

        End Sub
        Public Property Show As String
            Get
                Show = _show
            End Get
            Set(value As String)
                _show = value
            End Set
        End Property
        Public Property Season As Integer
            Get
                Season = _season
            End Get
            Set
                _season = Value
            End Set
        End Property
        Public Property AnyGood As Boolean
            Get
                AnyGood = _anyGood
            End Get
            Set(value As Boolean)
                _anyGood = value
            End Set
        End Property
        Public Property Spoiler As String
            Get
                Spoiler = _spoiler

            End Get
            Set(value As String)
                _spoiler = value
            End Set
        End Property

    End Class
