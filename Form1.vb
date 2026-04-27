Public Class Form1
    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SalesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SalesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CookiesDataSet)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CookiesDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.CookiesDataSet.Sales)

    End Sub
End Class
