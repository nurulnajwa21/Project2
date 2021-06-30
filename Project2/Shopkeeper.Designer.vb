<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formShopkeeper
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
        Me.BtnAddItems = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBackShop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAddItems
        '
        Me.BtnAddItems.BackColor = System.Drawing.Color.Orange
        Me.BtnAddItems.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnAddItems.FlatAppearance.BorderSize = 5
        Me.BtnAddItems.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItems.ForeColor = System.Drawing.Color.Snow
        Me.BtnAddItems.Location = New System.Drawing.Point(112, 144)
        Me.BtnAddItems.Name = "BtnAddItems"
        Me.BtnAddItems.Size = New System.Drawing.Size(166, 58)
        Me.BtnAddItems.TabIndex = 5
        Me.BtnAddItems.Text = "ADD ITEMS"
        Me.BtnAddItems.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(71, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(517, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SHOPKEEPER"
        '
        'BtnBackShop
        '
        Me.BtnBackShop.BackColor = System.Drawing.Color.Orange
        Me.BtnBackShop.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnBackShop.FlatAppearance.BorderSize = 5
        Me.BtnBackShop.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackShop.ForeColor = System.Drawing.Color.Snow
        Me.BtnBackShop.Location = New System.Drawing.Point(352, 144)
        Me.BtnBackShop.Name = "BtnBackShop"
        Me.BtnBackShop.Size = New System.Drawing.Size(155, 58)
        Me.BtnBackShop.TabIndex = 6
        Me.BtnBackShop.Text = "BACK"
        Me.BtnBackShop.UseVisualStyleBackColor = False
        '
        'formShopkeeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project2.My.Resources.Resources.photo1624284953__1_1
        Me.ClientSize = New System.Drawing.Size(656, 409)
        Me.Controls.Add(Me.BtnBackShop)
        Me.Controls.Add(Me.BtnAddItems)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formShopkeeper"
        Me.Text = "Shopkeeper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddItems As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBackShop As Button
End Class
