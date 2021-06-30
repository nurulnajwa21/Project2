<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainpage
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
        Me.BtnCust = New System.Windows.Forms.Button()
        Me.BtnShopkeeper = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(43, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FRIEND BAKERY"
        '
        'BtnCust
        '
        Me.BtnCust.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnCust.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnCust.FlatAppearance.BorderSize = 5
        Me.BtnCust.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCust.ForeColor = System.Drawing.Color.Sienna
        Me.BtnCust.Location = New System.Drawing.Point(382, 158)
        Me.BtnCust.Name = "BtnCust"
        Me.BtnCust.Size = New System.Drawing.Size(155, 58)
        Me.BtnCust.TabIndex = 1
        Me.BtnCust.Text = "CUSTOMER"
        Me.BtnCust.UseVisualStyleBackColor = False
        '
        'BtnShopkeeper
        '
        Me.BtnShopkeeper.BackColor = System.Drawing.Color.NavajoWhite
        Me.BtnShopkeeper.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnShopkeeper.FlatAppearance.BorderSize = 5
        Me.BtnShopkeeper.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShopkeeper.ForeColor = System.Drawing.Color.Sienna
        Me.BtnShopkeeper.Location = New System.Drawing.Point(182, 158)
        Me.BtnShopkeeper.Name = "BtnShopkeeper"
        Me.BtnShopkeeper.Size = New System.Drawing.Size(166, 58)
        Me.BtnShopkeeper.TabIndex = 2
        Me.BtnShopkeeper.Text = "SHOPKEEPER"
        Me.BtnShopkeeper.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(318, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "THANKYOU :)"
        '
        'formMainpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project2.My.Resources.Resources.photo1624284953__1_
        Me.ClientSize = New System.Drawing.Size(732, 469)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnShopkeeper)
        Me.Controls.Add(Me.BtnCust)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formMainpage"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCust As Button
    Friend WithEvents BtnShopkeeper As Button
    Friend WithEvents Label2 As Label
End Class
