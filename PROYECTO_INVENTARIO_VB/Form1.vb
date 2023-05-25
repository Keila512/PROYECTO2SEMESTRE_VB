Imports System.Diagnostics.Contracts
Imports System.IO
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox


Partial Public Class Form1
    Inherits Form

    Private row As DataGridViewRow

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub save()
        Dim product As ProductDetails = New ProductDetails()
        product.NameP = txtname.Text.ToUpper()
        product.CodeP = txtcode.Text.ToUpper()
        product.Entry_dateP = dateTimePicker1.Value
        product.Purchase_priceP = Double.Parse(txtpurchase_price.Text)
        product.Sale_priceP = Double.Parse(txtsale_price.Text)
        product.AmountP = Integer.Parse(txtamount.Text)
        fill_DGV(product)
    End Sub

    Private Sub save(ByVal code As String, ByVal [exit] As Integer)
        Dim rowIndex As Integer = 0

        For Each row As DataGridViewRow In dgvBoard.Rows

            For Each cell As DataGridViewCell In row.Cells

                If cell.Value Is Nothing Then
                    Continue For
                End If

                If cell.Value.ToString() = code Then
                    rowIndex = row.Index
                    Exit For
                End If
            Next

            If rowIndex <> 0 Then
                Exit For
            End If
        Next

        dgvBoard.Rows(rowIndex).Cells(6).Value = [exit]
        Dim stock As Integer = Integer.Parse(dgvBoard.Rows(rowIndex).Cells(3).Value.ToString()) - [exit]
        dgvBoard.Rows(rowIndex).Cells(7).Value = stock
    End Sub

    Private Sub fill_DGV(ByVal product As ProductDetails)
        row = New DataGridViewRow()
        row.CreateCells(dgvBoard)

        Try
            row = New DataGridViewRow()
            row.CreateCells(dgvBoard)
            row.Cells(0).Value = product.code
            row.Cells(1).Value = dateTimePicker1.Text
            row.Cells(2).Value = product.name
            row.Cells(3).Value = product.amount
            row.Cells(4).Value = product.purchase_price
            row.Cells(5).Value = product.sale_price
            Dim sw As StreamWriter = New StreamWriter("PROYECT.txt", True, Encoding.ASCII)
            sw.WriteLine(txtcode.Text.ToUpper() & "," + dateTimePicker1.Text & "," + txtname.Text.ToUpper() & "," + txtpurchase_price.Text & "," + txtamount.Text & "," + txtsale_price.Text & "," + txtexit.Text)
            sw.Close()
            dgvBoard.Rows.Add(row)
            txtcode.Text = " "
            dateTimePicker1.Text = Nothing
            txtname.Text = " "
            txtpurchase_price.Text = " "
            txtamount.Text = " "
            txtsale_price.Text = " "
        Catch
            MessageBox.Show("IT SEEMS SOMETHING WENT WRONG..., PLEASE REVIEW AND FILL IN EACH FIELD CORRECTLY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        dgvBoard.Rows.Remove(dgvBoard.CurrentRow)
    End Sub

    Private Sub dgvBoard_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        txtcode.Text = dgvBoard.CurrentRow.Cells(0).Value.ToString()
        dateTimePicker1.Text = dgvBoard.CurrentRow.Cells(1).Value.ToString()
        txtname.Text = dgvBoard.CurrentRow.Cells(2).Value.ToString()
        txtpurchase_price.Text = dgvBoard.CurrentRow.Cells(3).Value.ToString()
        txtamount.Text = dgvBoard.CurrentRow.Cells(4).Value.ToString()
        txtsale_price.Text = dgvBoard.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnmost_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim totalA, totalB, totalC As Double
        totalA = 0
        totalB = 0
        totalC = 0

        For Each row As DataGridViewRow In dgvBoard.Rows

            If row.Cells(3).Value IsNot Nothing Then
                Dim value As Double = 0

                If Double.TryParse(row.Cells(3).Value.ToString(), value) Then
                    totalA += value
                End If

                txtentries.Text = totalA.ToString()
            End If

            If row.Cells(4).Value IsNot Nothing Then
                Dim value1 As Double = 0

                If Double.TryParse(row.Cells(4).Value.ToString(), value1) Then
                    totalB += value1
                End If

                txttotal1.Text = totalB.ToString("C")
            End If

            If row.Cells(5).Value IsNot Nothing Then
                Dim value2 As Double = 0

                If Double.TryParse(row.Cells(5).Value.ToString(), value2) Then
                    totalC += value2
                End If

                txttotal2.Text = totalC.ToString("C")
            End If
        Next
    End Sub

    Private Sub btnSave2_Click(ByVal sender As Object, ByVal e As EventArgs)
        save(txtCodeStock.Text, Integer.Parse(txtexit.Text))
    End Sub

    Private Sub btnSave1_Click(ByVal sender As Object, ByVal e As EventArgs)
        save()
    End Sub

    Private Sub btnStreamReader_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim sr As StreamReader = New StreamReader("PROYECT.txt")
        rtxtboxmost.Text = sr.ReadToEnd()
    End Sub
End Class
