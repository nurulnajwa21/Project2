<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCatalogue = New System.Windows.Forms.Button()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.BtnBackCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(222, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "HELLO !"
        '
        'BtnCatalogue
        '
        Me.BtnCatalogue.BackColor = System.Drawing.Color.Turquoise
        Me.BtnCatalogue.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnCatalogue.FlatAppearance.BorderSize = 5
        Me.BtnCatalogue.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatalogue.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCatalogue.Location = New System.Drawing.Point(255, 126)
        Me.BtnCatalogue.Name = "BtnCatalogue"
        Me.BtnCatalogue.Size = New System.Drawing.Size(155, 58)
        Me.BtnCatalogue.TabIndex = 7
        Me.BtnCatalogue.Text = "CATALOGUE"
        Me.BtnCatalogue.UseVisualStyleBackColor = False
        '
        'BtnOrder
        '
        Me.BtnOrder.BackColor = System.Drawing.Color.Turquoise
        Me.BtnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnOrder.FlatAppearance.BorderSize = 5
        Me.BtnOrder.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrder.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnOrder.Location = New System.Drawing.Point(255, 190)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(155, 58)
        Me.BtnOrder.TabIndex = 8
        Me.BtnOrder.Text = "ORDER"
        Me.BtnOrder.UseVisualStyleBackColor = False
        '
        'BtnBackCust
        '
        Me.BtnBackCust.BackColor = System.Drawing.Color.Turquoise
        Me.BtnBackCust.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnBackCust.FlatAppearance.BorderSize = 5
        Me.BtnBackCust.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackCust.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnBackCust.Location = New System.Drawing.Point(255, 254)
        Me.BtnBackCust.Name = "BtnBackCust"
        Me.BtnBackCust.Size = New System.Drawing.Size(155, 58)
        Me.BtnBackCust.TabIndex = 9
        Me.BtnBackCust.Text = "BACK"
        Me.BtnBackCust.UseVisualStyleBackColor = False
        '
        'formCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project2.My.Resources.Resources.photo1624284953__2_
        Me.ClientSize = New System.Drawing.Size(504, 336)
        Me.Controls.Add(Me.BtnBackCust)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.BtnCatalogue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formCustomer"
        Me.Text = "Welcome to FRIEND BAKERY !"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCatalogue As Button
    Friend WithEvents BtnOrder As Button
    Friend WithEvents BtnBackCust As Button
End Class
