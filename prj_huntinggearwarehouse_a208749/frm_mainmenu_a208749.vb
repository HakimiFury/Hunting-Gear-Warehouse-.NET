Public Class frm_mainmenu_a208749
    Private Sub frm_mainmenu_a208749_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("Welcome to the Hunting Gear Warehouse Store")

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

    End Sub

    Private Sub btn_prd_Click(sender As Object, e As EventArgs) Handles btn_prd.Click

        frm_products_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click

        frm_staffs_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click

        frm_customers_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_ord_Click(sender As Object, e As EventArgs) Handles btn_ord.Click

        frm_order_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click

        frm_invoice_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_prddetails_Click(sender As Object, e As EventArgs) Handles btn_prddetails.Click

        frm_productsdetails_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click

        frm_modify_a208749.Show()

        Me.Hide()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        MsgBox("Thank you, have a nice day!")
        End
    End Sub


End Class
