Public Class formShopkeeper
    Private Sub BtnAddItems_Click(sender As Object, e As EventArgs) Handles BtnAddItems.Click
        formAddItems.Show()
        Me.Show()
    End Sub
    Private Sub BtnBackShop_Click(sender As Object, e As EventArgs) Handles BtnBackShop.Click
        formMainpage.Show()
        Me.Close()
    End Sub
End Class