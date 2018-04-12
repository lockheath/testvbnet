Imports System.Data.SqlClient

Public Class Form1
    Private Sub BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub BTN_LOGIN_Click(sender As Object, e As EventArgs) Handles BTN_LOGIN.Click
        Dim connection As New SqlConnection("Server= RK570815\SQLEXPRESS; Database = TestDB; Integrated Security = true")

        Dim command As New SqlCommand("select * from Table_Login where Username = @username and Password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUSERNAME.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPASSWORD.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Username Or Password Are Invalid")

        Else

            'MessageBox.Show("Login Successfully")

            Dim frm As New Form2()

            Me.Hide()

            frm.Show()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
