Public Class ActionsPane
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Globals.ThisDocument.Application.Run("SaveDeco")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Globals.ThisDocument.Application.Run("showuserform")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Globals.ThisDocument.Range.Select()
        Globals.ThisDocument.Range.Delete()

    End Sub
End Class
