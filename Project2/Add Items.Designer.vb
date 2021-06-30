<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddItems
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvAddItems = New System.Windows.Forms.DataGridView()
        Me.Item_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxItems = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxPrice = New System.Windows.Forms.TextBox()
        Me.BtnListAll = New System.Windows.Forms.Button()
        CType(Me.DgvAddItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnBack.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(278, 433)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(84, 44)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "BACK"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(43, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADD ITEMS"
        '
        'DgvAddItems
        '
        Me.DgvAddItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAddItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item_Name, Me.Quantity_, Me.Price_})
        Me.DgvAddItems.Location = New System.Drawing.Point(397, 86)
        Me.DgvAddItems.Name = "DgvAddItems"
        Me.DgvAddItems.RowHeadersWidth = 51
        Me.DgvAddItems.RowTemplate.Height = 24
        Me.DgvAddItems.Size = New System.Drawing.Size(521, 341)
        Me.DgvAddItems.TabIndex = 2
        '
        'Item_Name
        '
        Me.Item_Name.HeaderText = "ITEMS NAME"
        Me.Item_Name.MinimumWidth = 6
        Me.Item_Name.Name = "Item_Name"
        Me.Item_Name.Width = 125
        '
        'Quantity_
        '
        Me.Quantity_.HeaderText = "QUANTITY"
        Me.Quantity_.MinimumWidth = 6
        Me.Quantity_.Name = "Quantity_"
        Me.Quantity_.Width = 125
        '
        'Price_
        '
        Me.Price_.HeaderText = "PRICE (RM)"
        Me.Price_.MinimumWidth = 6
        Me.Price_.Name = "Price_"
        Me.Price_.Width = 125
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnAdd.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(50, 433)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(84, 44)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Items Name "
        '
        'txtboxItems
        '
        Me.txtboxItems.BackColor = System.Drawing.Color.White
        Me.txtboxItems.Location = New System.Drawing.Point(144, 178)
        Me.txtboxItems.Name = "txtboxItems"
        Me.txtboxItems.Size = New System.Drawing.Size(202, 22)
        Me.txtboxItems.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quantity"
        '
        'NudQuantity
        '
        Me.NudQuantity.BackColor = System.Drawing.Color.White
        Me.NudQuantity.Location = New System.Drawing.Point(144, 252)
        Me.NudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudQuantity.Name = "NudQuantity"
        Me.NudQuantity.Size = New System.Drawing.Size(209, 22)
        Me.NudQuantity.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Price (RM)"
        '
        'txtboxPrice
        '
        Me.txtboxPrice.BackColor = System.Drawing.Color.White
        Me.txtboxPrice.Location = New System.Drawing.Point(144, 330)
        Me.txtboxPrice.Name = "txtboxPrice"
        Me.txtboxPrice.Size = New System.Drawing.Size(202, 22)
        Me.txtboxPrice.TabIndex = 9
        '
        'BtnListAll
        '
        Me.BtnListAll.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnListAll.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListAll.Location = New System.Drawing.Point(144, 433)
        Me.BtnListAll.Name = "BtnListAll"
        Me.BtnListAll.Size = New System.Drawing.Size(114, 44)
        Me.BtnListAll.TabIndex = 10
        Me.BtnListAll.Text = "LIST ALL"
        Me.BtnListAll.UseVisualStyleBackColor = False
        '
        'formAddItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project2.My.Resources.Resources.photo1624284953__3_
        Me.ClientSize = New System.Drawing.Size(965, 495)
        Me.Controls.Add(Me.BtnListAll)
        Me.Controls.Add(Me.txtboxPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NudQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxItems)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DgvAddItems)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "formAddItems"
        Me.Text = "Add Items"
        CType(Me.DgvAddItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvAddItems As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Item_Name As DataGridViewTextBoxColumn
    Friend WithEvents Quantity_ As DataGridViewTextBoxColumn
    Friend WithEvents Price_ As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxItems As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NudQuantity As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxPrice As TextBox
    Friend WithEvents BtnListAll As Button
End Class
