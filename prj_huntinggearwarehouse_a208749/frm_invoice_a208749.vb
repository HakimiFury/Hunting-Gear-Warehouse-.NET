Public Class frm_invoice_a208749
    Private Sub frm_invoice_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now
        lbl_date.Text = current_date

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_huntinggearwarehouse_a208749.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_INVOICE_A208749"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_invoice.DataSource = mydatatable

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_a208749.Show()

        Me.Hide()

    End Sub


End Class