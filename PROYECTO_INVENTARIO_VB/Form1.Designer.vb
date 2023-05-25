Imports System.Reflection

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvBoard = New DataGridView()
        label15 = New Label()
        txtCodeStock = New TextBox()
        label14 = New Label()
        btnStreamReader = New Button()
        rtxtboxmost = New RichTextBox()
        label13 = New Label()
        textBox1 = New TextBox()
        label12 = New Label()
        txtexit = New TextBox()
        btnSave2 = New Button()
        label11 = New Label()
        label = New Label()
        btnmost = New Button()
        txttotal2 = New TextBox()
        txttotal1 = New TextBox()
        label10 = New Label()
        label7 = New Label()
        txtentries = New TextBox()
        label9 = New Label()
        btnDelete = New Button()
        txtsale_price = New TextBox()
        label8 = New Label()
        txtcode = New TextBox()
        txtamount = New TextBox()
        txtname = New TextBox()
        txtpurchase_price = New TextBox()
        dateTimePicker1 = New DateTimePicker()
        label6 = New Label()
        label5 = New Label()
        btnSave1 = New Button()
        label4 = New Label()
        label3 = New Label()
        label2 = New Label()
        label1 = New Label()
        Code = New DataGridViewTextBoxColumn()
        Date_Entry = New DataGridViewTextBoxColumn()
        NameColumn = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        Purchase_Price = New DataGridViewTextBoxColumn()
        Sale_Price = New DataGridViewTextBoxColumn()
        Exits = New DataGridViewTextBoxColumn()
        Stock = New DataGridViewTextBoxColumn()
        CType(dgvBoard, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label15
        ' 
        label15.AutoSize = True
        label15.Location = New Point(615, 124)
        label15.Name = "label15"
        label15.Size = New Size(52, 15)
        label15.TabIndex = 74
        label15.Text = "CODIGO"
        ' 
        ' txtCodeStock
        ' 
        txtCodeStock.Location = New Point(676, 125)
        txtCodeStock.Margin = New Padding(3, 2, 3, 2)
        txtCodeStock.Name = "txtCodeStock"
        txtCodeStock.Size = New Size(112, 23)
        txtCodeStock.TabIndex = 73
        ' 
        ' label14
        ' 
        label14.AutoSize = True
        label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        label14.Location = New Point(855, 228)
        label14.Name = "label14"
        label14.Size = New Size(258, 25)
        label14.TabIndex = 72
        label14.Text = "PRODUCTOS REGISTRADOS"
        ' 
        ' btnStreamReader
        ' 
        btnStreamReader.Location = New Point(1124, 232)
        btnStreamReader.Margin = New Padding(3, 2, 3, 2)
        btnStreamReader.Name = "btnStreamReader"
        btnStreamReader.Size = New Size(82, 22)
        btnStreamReader.TabIndex = 71
        btnStreamReader.Text = "MOSTRAR"
        btnStreamReader.UseVisualStyleBackColor = True
        AddHandler Me.btnStreamReader.Click, AddressOf Me.btnStreamReader_Click
        ' 
        ' rtxtboxmost
        ' 
        rtxtboxmost.Location = New Point(842, 258)
        rtxtboxmost.Margin = New Padding(3, 2, 3, 2)
        rtxtboxmost.Name = "rtxtboxmost"
        rtxtboxmost.Size = New Size(365, 242)
        rtxtboxmost.TabIndex = 70
        rtxtboxmost.Text = ""
        ' 
        ' label13
        ' 
        label13.AutoSize = True
        label13.Location = New Point(612, 153)
        label13.Name = "label13"
        label13.Size = New Size(55, 15)
        label13.TabIndex = 69
        label13.Text = "SALIDAS:"
        ' 
        ' textBox1
        ' 
        textBox1.Location = New Point(879, 58)
        textBox1.Margin = New Padding(3, 2, 3, 2)
        textBox1.Name = "textBox1"
        textBox1.Size = New Size(110, 23)
        textBox1.TabIndex = 68
        ' 
        ' label12
        ' 
        label12.AutoSize = True
        label12.Location = New Point(765, 59)
        label12.Name = "label12"
        label12.Size = New Size(97, 15)
        label12.TabIndex = 67
        label12.Text = "TOTAL DE STOCK:"
        ' 
        ' txtexit
        ' 
        txtexit.Location = New Point(678, 151)
        txtexit.Margin = New Padding(3, 2, 3, 2)
        txtexit.Name = "txtexit"
        txtexit.Size = New Size(110, 23)
        txtexit.TabIndex = 66
        ' 
        ' btnSave2
        ' 
        btnSave2.Location = New Point(677, 186)
        btnSave2.Margin = New Padding(3, 2, 3, 2)
        btnSave2.Name = "btnSave2"
        btnSave2.Size = New Size(111, 22)
        btnSave2.TabIndex = 65
        btnSave2.Text = "MOSTRAR STOCK"
        btnSave2.UseVisualStyleBackColor = True
        AddHandler Me.btnSave2.Click, AddressOf Me.btnSave2_Click

        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.BackColor = SystemColors.ActiveBorder
        label11.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        label11.ForeColor = SystemColors.ActiveCaptionText
        label11.Location = New Point(14, 5)
        label11.Name = "label11"
        label11.Size = New Size(197, 16)
        label11.TabIndex = 64
        label11.Text = "REGISTRO DE PRODUCTOS"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.BackColor = SystemColors.ButtonShadow
        label.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        label.Location = New Point(676, 24)
        label.Name = "label"
        label.Size = New Size(89, 25)
        label.TabIndex = 63
        label.Text = "TOTALES"
        ' 
        ' btnmost
        ' 
        btnmost.Location = New Point(1070, 87)
        btnmost.Margin = New Padding(3, 2, 3, 2)
        btnmost.Name = "btnmost"
        btnmost.Size = New Size(82, 22)
        btnmost.TabIndex = 62
        btnmost.Text = "MOSTRAR"
        btnmost.UseVisualStyleBackColor = True
        AddHandler Me.btnmost.Click, AddressOf Me.btnmost_Click
        ' 
        ' txttotal2
        ' 
        txttotal2.Location = New Point(1070, 52)
        txttotal2.Margin = New Padding(3, 2, 3, 2)
        txttotal2.Name = "txttotal2"
        txttotal2.Size = New Size(137, 23)
        txttotal2.TabIndex = 61
        ' 
        ' txttotal1
        ' 
        txttotal1.Location = New Point(1070, 22)
        txttotal1.Margin = New Padding(3, 2, 3, 2)
        txttotal1.Name = "txttotal1"
        txttotal1.Size = New Size(137, 23)
        txttotal1.TabIndex = 60
        ' 
        ' label10
        ' 
        label10.AutoSize = True
        label10.Location = New Point(1009, 58)
        label10.Name = "label10"
        label10.Size = New Size(51, 15)
        label10.TabIndex = 59
        label10.Text = "VENTAS:"
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Point(994, 27)
        label7.Name = "label7"
        label7.Size = New Size(66, 15)
        label7.TabIndex = 58
        label7.Text = "COMPRAS:"
        ' 
        ' txtentries
        ' 
        txtentries.Location = New Point(855, 25)
        txtentries.Margin = New Padding(3, 2, 3, 2)
        txtentries.Name = "txtentries"
        txtentries.Size = New Size(134, 23)
        txtentries.TabIndex = 57
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Location = New Point(774, 29)
        label9.Name = "label9"
        label9.Size = New Size(68, 15)
        label9.TabIndex = 56
        label9.Text = "ENTRADAS:"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(587, 72)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 55
        btnDelete.Text = "ELIMINAR"
        btnDelete.UseVisualStyleBackColor = True
        AddHandler Me.btnDelete.Click, AddressOf Me.btnDelete_Click
        ' 
        ' txtsale_price
        ' 
        txtsale_price.Location = New Point(464, 84)
        txtsale_price.Name = "txtsale_price"
        txtsale_price.Size = New Size(100, 23)
        txtsale_price.TabIndex = 54
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Location = New Point(343, 60)
        label8.Name = "label8"
        label8.Size = New Size(120, 15)
        label8.TabIndex = 53
        label8.Text = "PRECIO DE COMPRA:"
        ' 
        ' txtcode
        ' 
        txtcode.Location = New Point(152, 60)
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(161, 23)
        txtcode.TabIndex = 52
        ' 
        ' txtamount
        ' 
        txtamount.Location = New Point(464, 29)
        txtamount.Name = "txtamount"
        txtamount.Size = New Size(100, 23)
        txtamount.TabIndex = 51
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(152, 84)
        txtname.Name = "txtname"
        txtname.Size = New Size(161, 23)
        txtname.TabIndex = 50
        ' 
        ' txtpurchase_price
        ' 
        txtpurchase_price.Location = New Point(464, 55)
        txtpurchase_price.Name = "txtpurchase_price"
        txtpurchase_price.Size = New Size(100, 23)
        txtpurchase_price.TabIndex = 49
        ' 
        ' dateTimePicker1
        ' 
        dateTimePicker1.Format = DateTimePickerFormat.Short
        dateTimePicker1.Location = New Point(152, 36)
        dateTimePicker1.Name = "dateTimePicker1"
        dateTimePicker1.Size = New Size(161, 23)
        dateTimePicker1.TabIndex = 48
        ' 
        ' label6
        ' 
        label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        label6.AutoSize = True
        label6.BackColor = SystemColors.ActiveBorder
        label6.Font = New Font("Corbel", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        label6.Location = New Point(14, 170)
        label6.Name = "label6"
        label6.Size = New Size(463, 42)
        label6.TabIndex = 47
        label6.Text = "INVENTARIO DE PRODUCTOS"
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(23, 42)
        label5.Name = "label5"
        label5.Size = New Size(119, 15)
        label5.TabIndex = 46
        label5.Text = "FECHA DE ENTRADA:"
        ' 
        ' btnSave1
        ' 
        btnSave1.Location = New Point(587, 30)
        btnSave1.Name = "btnSave1"
        btnSave1.Size = New Size(75, 23)
        btnSave1.TabIndex = 45
        btnSave1.Text = "AGREGAR"
        btnSave1.UseVisualStyleBackColor = True
        AddHandler Me.btnSave1.Click, AddressOf Me.btnSave1_Click
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(343, 84)
        label4.Name = "label4"
        label4.Size = New Size(105, 15)
        label4.TabIndex = 44
        label4.Text = "PRECIO DE VENTA:"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(343, 36)
        label3.Name = "label3"
        label3.Size = New Size(68, 15)
        label3.TabIndex = 43
        label3.Text = "ENTRADAS:"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(23, 65)
        label2.Name = "label2"
        label2.Size = New Size(55, 15)
        label2.TabIndex = 42
        label2.Text = "CÓDIGO:"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(23, 87)
        label1.Name = "label1"
        label1.Size = New Size(84, 15)
        label1.TabIndex = 41
        label1.Text = "DESCRIPCION:"
        ' 
        ' dgvBoard
        ' 
        dgvBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBoard.Columns.AddRange(New DataGridViewColumn() {Code, Date_Entry, NameColumn, Amount, Purchase_Price, Sale_Price, Exits, Stock})
        dgvBoard.Location = New Point(4, 218)
        dgvBoard.Name = "dgvBoard"
        dgvBoard.RowTemplate.Height = 25
        dgvBoard.Size = New Size(832, 282)
        dgvBoard.TabIndex = 75
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.Name = "Code"
        ' 
        ' Date_Entry
        ' 
        Date_Entry.HeaderText = "Date_Entry"
        Date_Entry.Name = "Date_Entry"
        ' 
        ' NameColumn
        ' 
        NameColumn.HeaderText = "NameColumn"
        NameColumn.Name = "NameColumn"
        ' 
        ' Amount
        ' 
        Amount.HeaderText = "Amount"
        Amount.Name = "Amount"
        ' 
        ' Purchase_Price
        ' 
        Purchase_Price.HeaderText = "Purchase_Price"
        Purchase_Price.Name = "Purchase_Price"
        ' 
        ' Sale_Price
        ' 
        Sale_Price.HeaderText = "Sale_Price"
        Sale_Price.Name = "Sale_Price"
        ' 
        ' Exits
        ' 
        Exits.HeaderText = "Exits"
        Exits.Name = "Exits"
        ' 
        ' Stock
        ' 
        Stock.HeaderText = "Stock"
        Stock.Name = "Stock"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1217, 510)
        Controls.Add(dgvBoard)
        Controls.Add(label15)
        Controls.Add(txtCodeStock)
        Controls.Add(label14)
        Controls.Add(btnStreamReader)
        Controls.Add(rtxtboxmost)
        Controls.Add(label13)
        Controls.Add(textBox1)
        Controls.Add(label12)
        Controls.Add(txtexit)
        Controls.Add(btnSave2)
        Controls.Add(label11)
        Controls.Add(label)
        Controls.Add(btnmost)
        Controls.Add(txttotal2)
        Controls.Add(txttotal1)
        Controls.Add(label10)
        Controls.Add(label7)
        Controls.Add(txtentries)
        Controls.Add(label9)
        Controls.Add(btnDelete)
        Controls.Add(txtsale_price)
        Controls.Add(label8)
        Controls.Add(txtcode)
        Controls.Add(txtamount)
        Controls.Add(txtname)
        Controls.Add(txtpurchase_price)
        Controls.Add(dateTimePicker1)
        Controls.Add(label6)
        Controls.Add(label5)
        Controls.Add(btnSave1)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBoard, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents label15 As Label
    Private WithEvents dgvBoard As DataGridView
    Private WithEvents txtCodeStock As TextBox
    Private WithEvents label14 As Label
    Private WithEvents btnStreamReader As Button
    Private WithEvents rtxtboxmost As RichTextBox
    Private WithEvents label13 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label12 As Label
    Private WithEvents txtexit As TextBox
    Private WithEvents btnSave2 As Button
    Private WithEvents label11 As Label
    Private WithEvents label As Label
    Private WithEvents btnmost As Button
    Private WithEvents txttotal2 As TextBox
    Private WithEvents txttotal1 As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label7 As Label
    Private WithEvents txtentries As TextBox
    Private WithEvents label9 As Label
    Private WithEvents btnDelete As Button
    Private WithEvents txtsale_price As TextBox
    Private WithEvents label8 As Label
    Private WithEvents txtcode As TextBox
    Private WithEvents txtamount As TextBox
    Private WithEvents txtname As TextBox
    Private WithEvents txtpurchase_price As TextBox
    Private WithEvents dateTimePicker1 As DateTimePicker
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents btnSave1 As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Date_Entry As DataGridViewTextBoxColumn
    Friend WithEvents NameColumn As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Purchase_Price As DataGridViewTextBoxColumn
    Friend WithEvents Sale_Price As DataGridViewTextBoxColumn
    Friend WithEvents Exits As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
End Class
