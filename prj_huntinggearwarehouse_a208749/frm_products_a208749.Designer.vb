<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_products_a208749
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
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.mainPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_date.Location = New System.Drawing.Point(543, 27)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(106, 24)
        Me.lbl_date.TabIndex = 19
        Me.lbl_date.Text = "Date.now"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_back.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.HotPink
        Me.btn_back.Location = New System.Drawing.Point(12, 449)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(101, 30)
        Me.btn_back.TabIndex = 17
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(123, 75)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.Size = New System.Drawing.Size(743, 420)
        Me.grd_product.TabIndex = 15
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_product.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_product.Location = New System.Drawing.Point(129, 22)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(160, 30)
        Me.lbl_product.TabIndex = 14
        Me.lbl_product.Text = "Product List"
        '
        'mainPicture
        '
        Me.mainPicture.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources.mainlogo
        Me.mainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainPicture.Location = New System.Drawing.Point(0, 0)
        Me.mainPicture.Name = "mainPicture"
        Me.mainPicture.Size = New System.Drawing.Size(123, 75)
        Me.mainPicture.TabIndex = 20
        Me.mainPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(123, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(743, 84)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frm_products_a208749
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.mainPicture)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_product)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_products_a208749"
        Me.Text = "Product List"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents lbl_product As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mainPicture As PictureBox
End Class
