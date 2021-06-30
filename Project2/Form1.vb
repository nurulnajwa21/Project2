Public Class formMainpage
    Private Sub BtnShopkeeper_Click(sender As Object, e As EventArgs) Handles BtnShopkeeper.Click
        formShopkeeper.Show()
        Me.Show()
    End Sub

    Private Sub BtnCust_Click(sender As Object, e As EventArgs) Handles BtnCust.Click
        formCustomer.Show()
        Me.Show()
    End Sub
End Class
