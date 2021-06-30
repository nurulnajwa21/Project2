Public Class formCatalogue
    Private Sub BtnBackCatalogue_Click(sender As Object, e As EventArgs) Handles BtnBackCatalogue.Click
        formCustomer.Show()
        Me.Close()
    End Sub
End Class