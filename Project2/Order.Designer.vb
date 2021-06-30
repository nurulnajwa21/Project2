<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOrder
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
        Me.txtboxAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NudQuantityOrder = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvOrder = New System.Windows.Forms.DataGridView()
        Me.Name_Cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Items_Name_Order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity_Order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address_Order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtboxItemsNameOrder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnBackOrder = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnListAllOrder = New System.Windows.Forms.Button()
        CType(Me.NudQuantityOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(174, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(737, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MAKE AN ORDER NOW ! "
        '
        'txtboxAddress
        '
        Me.txtboxAddress.BackColor = System.Drawing.Color.White
        Me.txtboxAddress.Location = New System.Drawing.Point(153, 282)
        Me.txtboxAddress.Multiline = True
        Me.txtboxAddress.Name = "txtboxAddress"
        Me.txtboxAddress.Size = New System.Drawing.Size(202, 76)
        Me.txtboxAddress.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(39, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Address"
        '
        'NudQuantityOrder
        '
        Me.NudQuantityOrder.BackColor = System.Drawing.Color.White
        Me.NudQuantityOrder.Location = New System.Drawing.Point(153, 222)
        Me.NudQuantityOrder.Name = "NudQuantityOrder"
        Me.NudQuantityOrder.Size = New System.Drawing.Size(209, 22)
        Me.NudQuantityOrder.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(38, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Quantity"
        '
        'txtboxName
        '
        Me.txtboxName.BackColor = System.Drawing.Color.White
        Me.txtboxName.Location = New System.Drawing.Point(153, 103)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(202, 22)
        Me.txtboxName.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(38, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name "
        '
        'DgvOrder
        '
        Me.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name_Cust, Me.Items_Name_Order, Me.Quantity_Order, Me.Address_Order})
        Me.DgvOrder.Location = New System.Drawing.Point(387, 103)
        Me.DgvOrder.Name = "DgvOrder"
        Me.DgvOrder.RowHeadersWidth = 51
        Me.DgvOrder.RowTemplate.Height = 24
        Me.DgvOrder.Size = New System.Drawing.Size(731, 373)
        Me.DgvOrder.TabIndex = 16
        '
        'Name_Cust
        '
        Me.Name_Cust.HeaderText = "Name"
        Me.Name_Cust.MinimumWidth = 6
        Me.Name_Cust.Name = "Name_Cust"
        Me.Name_Cust.Width = 125
        '
        'Items_Name_Order
        '
        Me.Items_Name_Order.HeaderText = "Items Name"
        Me.Items_Name_Order.MinimumWidth = 6
        Me.Items_Name_Order.Name = "Items_Name_Order"
        Me.Items_Name_Order.Width = 125
        '
        'Quantity_Order
        '
        Me.Quantity_Order.HeaderText = "Quantity"
        Me.Quantity_Order.MinimumWidth = 6
        Me.Quantity_Order.Name = "Quantity_Order"
        Me.Quantity_Order.Width = 125
        '
        'Address_Order
        '
        Me.Address_Order.HeaderText = "Address"
        Me.Address_Order.MinimumWidth = 6
        Me.Address_Order.Name = "Address_Order"
        Me.Address_Order.Width = 125
        '
        'txtboxItemsNameOrder
        '
        Me.txtboxItemsNameOrder.BackColor = System.Drawing.Color.White
        Me.txtboxItemsNameOrder.Location = New System.Drawing.Point(153, 162)
        Me.txtboxItemsNameOrder.Name = "txtboxItemsNameOrder"
        Me.txtboxItemsNameOrder.Size = New System.Drawing.Size(202, 22)
        Me.txtboxItemsNameOrder.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(38, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Items Name "
        '
        'BtnBackOrder
        '
        Me.BtnBackOrder.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnBackOrder.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnBackOrder.FlatAppearance.BorderSize = 5
        Me.BtnBackOrder.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackOrder.ForeColor = System.Drawing.Color.Snow
        Me.BtnBackOrder.Location = New System.Drawing.Point(269, 427)
        Me.BtnBackOrder.Name = "BtnBackOrder"
        Me.BtnBackOrder.Size = New System.Drawing.Size(103, 49)
        Me.BtnBackOrder.TabIndex = 21
        Me.BtnBackOrder.Text = "BACK"
        Me.BtnBackOrder.UseVisualStyleBackColor = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnSubmit.FlatAppearance.BorderSize = 5
        Me.BtnSubmit.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.Snow
        Me.BtnSubmit.Location = New System.Drawing.Point(25, 427)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(98, 53)
        Me.BtnSubmit.TabIndex = 22
        Me.BtnSubmit.Text = "SUBMIT"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnListAllOrder
        '
        Me.BtnListAllOrder.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnListAllOrder.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnListAllOrder.FlatAppearance.BorderSize = 5
        Me.BtnListAllOrder.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListAllOrder.ForeColor = System.Drawing.Color.Snow
        Me.BtnListAllOrder.Location = New System.Drawing.Point(129, 427)
        Me.BtnListAllOrder.Name = "BtnListAllOrder"
        Me.BtnListAllOrder.Size = New System.Drawing.Size(134, 49)
        Me.BtnListAllOrder.TabIndex = 23
        Me.BtnListAllOrder.Text = "LIST ALL"
        Me.BtnListAllOrder.UseVisualStyleBackColor = False
        '
        'formOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project2.My.Resources.Resources.photo1624289982
        Me.ClientSize = New System.Drawing.Size(1142, 513)
        Me.Controls.Add(Me.BtnListAllOrder)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnBackOrder)
        Me.Controls.Add(Me.txtboxItemsNameOrder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DgvOrder)
        Me.Controls.Add(Me.txtboxAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NudQuantityOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formOrder"
        Me.Text = "Order"
        CType(Me.NudQuantityOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NudQuantityOrder As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvOrder As DataGridView
    Friend WithEvents txtboxItemsNameOrder As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBackOrder As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Name_Cust As DataGridViewTextBoxColumn
    Friend WithEvents Items_Name_Order As DataGridViewTextBoxColumn
    Friend WithEvents Quantity_Order As DataGridViewTextBoxColumn
    Friend WithEvents Address_Order As DataGridViewTextBoxColumn
    Friend WithEvents BtnListAllOrder As Button
End Class
