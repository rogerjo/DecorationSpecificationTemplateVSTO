Public Class ThisDocument

    Private Sub ThisDocument_Startup() Handles Me.Startup
        Me.ActionsPane.Controls.Add(DecoPane)
    End Sub

    Private Sub ThisDocument_Shutdown() Handles Me.Shutdown

    End Sub

    Dim DecoPane As New ActionsPane

End Class
