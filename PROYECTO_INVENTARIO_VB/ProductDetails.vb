Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Class ProductDetails
    Inherits Product
    Private exits As Integer
    Public Property ExitsP As Integer
        Get
            Return exits
        End Get
        Set(ByVal value As Integer)
            exits = value
        End Set
    End Property
    Private stock As Integer
    Public Property StockP As Integer
        Get
            Return stock
        End Get
        Set(ByVal value As Integer)
            stock = value
        End Set
    End Property
    Public amount As Integer
    Public Property AmountP As Integer
        Get
            Return amount
        End Get
        Set(ByVal value As Integer)
            amount = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        name = String.Empty
        code = String.Empty
        entry_date = Nothing
        purchase_price = 0
        sale_price = 0
        exits = 0
        stock = 0
        amount = 0
    End Sub
    Public Sub New(ByVal name As String, ByVal code As String, ByVal entry_date As DateTime?, ByVal purchase_price As Double, ByVal sale_price As Double, ByVal exits As Integer, ByVal stock As Integer, ByVal amount As Integer)
        MyBase.New(name, code, entry_date, purchase_price, sale_price)
        Me.name = name
        Me.code = code
        Me.entry_date = entry_date
        Me.purchase_price = purchase_price
        Me.sale_price = sale_price
        Me.exits = exits
        Me.stock = stock
        Me.amount = amount
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " salida: " + exits & " Stock: " + stock & " Entrada: " + amount
    End Function
End Class
