<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_a208749
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
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_invoice = New System.Windows.Forms.DataGridView()
        Me.lbl_Invoice = New System.Windows.Forms.Label()
        Me.mainPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_date.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_date.Location = New System.Drawing.Point(719, 36)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(139, 32)
        Me.lbl_date.TabIndex = 20
        Me.lbl_date.Text = "Date.now"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_back.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.HotPink
        Me.btn_back.Location = New System.Drawing.Point(13, 502)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(135, 37)
        Me.btn_back.TabIndex = 19
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_invoice
        '
        Me.grd_invoice.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grd_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_invoice.Location = New System.Drawing.Point(161, 90)
        Me.grd_invoice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grd_invoice.Name = "grd_invoice"
        Me.grd_invoice.RowHeadersWidth = 51
        Me.grd_invoice.Size = New System.Drawing.Size(903, 464)
        Me.grd_invoice.TabIndex = 16
        '
        'lbl_Invoice
        '
        Me.lbl_Invoice.AutoSize = True
        Me.lbl_Invoice.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_Invoice.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Invoice.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_Invoice.Location = New System.Drawing.Point(169, 30)
        Me.lbl_Invoice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Invoice.Name = "lbl_Invoice"
        Me.lbl_Invoice.Size = New System.Drawing.Size(124, 37)
        Me.lbl_Invoice.TabIndex = 15
        Me.lbl_Invoice.Text = "Invoice"
        '
        'mainPicture
        '
        Me.mainPicture.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources.mainlogo
        Me.mainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainPicture.Location = New System.Drawing.Point(-3, 0)
        Me.mainPicture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mainPicture.Name = "mainPicture"
        Me.mainPicture.Size = New System.Drawing.Size(164, 92)
        Me.mainPicture.TabIndex = 21
        Me.mainPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(161, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(909, 92)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frm_invoice_a208749
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.mainPicture)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_invoice)
        Me.Controls.Add(Me.lbl_Invoice)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_invoice_a208749"
        Me.Text = "Invoice"
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_invoice As DataGridView
    Friend WithEvents lbl_Invoice As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mainPicture As PictureBox
End Class
