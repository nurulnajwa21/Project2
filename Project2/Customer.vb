Public Class formCustomer
    Private Sub BtnCatalogue_Click(sender As Object, e As EventArgs) Handles BtnCatalogue.Click
        formCatalogue.Show()
        Me.Show()
    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        formOrder.Show()
        Me.Show()
    End Sub

    Private Sub BtnBackCust_Click(sender As Object, e As EventArgs) Handles BtnBackCust.Click
        formMainpage.Show()
        Me.Close()
    End Sub
End Class