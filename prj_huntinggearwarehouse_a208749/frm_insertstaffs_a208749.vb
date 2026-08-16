Public Class frm_insertstaffs_a208749
    Private Sub frm_insertstaffs_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A208749")

        txt_id.Text = generate_id()

    End Sub

    Private Function generate_id() As String

        Dim lastid As Object = run_sql_query("SELECT MAX(FLD_STAFFS_ID) AS LASTID FROM TBL_STAFFS_A208749").Rows(0).Item("LASTID")

        If IsDBNull(lastid) OrElse String.IsNullOrEmpty(lastid.ToString()) Then
            Return "STF001"
        End If

        Dim numericPart As Integer
        If lastid.ToString().StartsWith("STF") AndAlso Integer.TryParse(Mid(lastid.ToString(), 5), numericPart) Then

            numericPart += 1
        Else

            numericPart = 1
        End If

        Dim newid As String = "STF" & numericPart.ToString("D3")

        Return newid
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_STAFFS_A208749 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_position.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A208749")

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_position.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        frm_updatestaffs_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_modify_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub
End Class