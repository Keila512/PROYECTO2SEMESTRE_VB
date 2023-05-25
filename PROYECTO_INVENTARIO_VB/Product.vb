Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public MustInherit Class Product
    Public name As String
    Public Property NameP() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property
    Public code As String
    Public Property CodeP As String
        Get
            Return code
        End Get
        Set(ByVal value As String)
            code = value
        End Set
    End Property
    Public entry_date As DateTime?
    Public Property Entry_dateP As DateTime?
        Get
            Return entry_date
        End Get
        Set(ByVal value As DateTime?)
            entry_date = value
        End Set
    End Property
    Public purchase_price As Double
    Public Property Purchase_priceP As Double
        Get
            Return purchase_price
        End Get
        Set(ByVal value As Double)
            purchase_price = value
        End Set
    End Property
    Public sale_price As Double
    Public Property Sale_priceP As Double
        Get
            Return sale_price
        End Get
        Set(ByVal value As Double)
            sale_price = value
        End Set
    End Property
    Public Sub New()
        name = String.Empty
        code = String.Empty
        entry_date = Nothing
        purchase_price = 0
        sale_price = 0
    End Sub
    Public Sub New(ByVal name As String, ByVal code As String, ByVal entry_date As DateTime?, ByVal purchase_price As Double, ByVal sale_price As Double)
        Me.name = name
        Me.code = code
        Me.entry_date = entry_date
        Me.purchase_price = purchase_price
        Me.sale_price = sale_price
    End Sub
    Public Overrides Function ToString() As String
        Return "Nombre: " & name & " Codigo: " & code & " Fecha de entrada: " & entry_date & " Precio de compra: " & purchase_price & " Precio de venta: " & sale_price
    End Function
End Class
