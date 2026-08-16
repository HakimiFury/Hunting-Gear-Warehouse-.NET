<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomers_a208749
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_desc5 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_desc6 = New System.Windows.Forms.Label()
        Me.lbl_desc4 = New System.Windows.Forms.Label()
        Me.lbl_desc1 = New System.Windows.Forms.Label()
        Me.lbl_desc2 = New System.Windows.Forms.Label()
        Me.lbl_desc3 = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.mainPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_desc5
        '
        Me.lbl_desc5.AutoSize = True
        Me.lbl_desc5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc5.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc5.Location = New System.Drawing.Point(122, 391)
        Me.lbl_desc5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc5.Name = "lbl_desc5"
        Me.lbl_desc5.Size = New System.Drawing.Size(207, 21)
        Me.lbl_desc5.TabIndex = 176
        Me.lbl_desc5.Text = "Click here after edit the data."
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_update.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.HotPink
        Me.btn_update.Location = New System.Drawing.Point(13, 385)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(88, 34)
        Me.btn_update.TabIndex = 175
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_delete.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.HotPink
        Me.btn_delete.Location = New System.Drawing.Point(13, 426)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(88, 34)
        Me.btn_delete.TabIndex = 173
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'lbl_desc6
        '
        Me.lbl_desc6.AutoSize = True
        Me.lbl_desc6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc6.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc6.Location = New System.Drawing.Point(122, 432)
        Me.lbl_desc6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc6.Name = "lbl_desc6"
        Me.lbl_desc6.Size = New System.Drawing.Size(308, 21)
        Me.lbl_desc6.TabIndex = 172
        Me.lbl_desc6.Text = "Click here to delete selected customer data."
        '
        'lbl_desc4
        '
        Me.lbl_desc4.AutoSize = True
        Me.lbl_desc4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc4.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc4.Location = New System.Drawing.Point(122, 187)
        Me.lbl_desc4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc4.Name = "lbl_desc4"
        Me.lbl_desc4.Size = New System.Drawing.Size(119, 21)
        Me.lbl_desc4.TabIndex = 171
        Me.lbl_desc4.Text = "Phone Number:"
        '
        'lbl_desc1
        '
        Me.lbl_desc1.AutoSize = True
        Me.lbl_desc1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc1.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc1.Location = New System.Drawing.Point(122, 102)
        Me.lbl_desc1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc1.Name = "lbl_desc1"
        Me.lbl_desc1.Size = New System.Drawing.Size(100, 21)
        Me.lbl_desc1.TabIndex = 170
        Me.lbl_desc1.Text = "Customer ID:"
        '
        'lbl_desc2
        '
        Me.lbl_desc2.AutoSize = True
        Me.lbl_desc2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc2.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc2.Location = New System.Drawing.Point(122, 130)
        Me.lbl_desc2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc2.Name = "lbl_desc2"
        Me.lbl_desc2.Size = New System.Drawing.Size(127, 21)
        Me.lbl_desc2.TabIndex = 169
        Me.lbl_desc2.Text = "Customer Name:"
        '
        'lbl_desc3
        '
        Me.lbl_desc3.AutoSize = True
        Me.lbl_desc3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc3.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc3.Location = New System.Drawing.Point(122, 158)
        Me.lbl_desc3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc3.Name = "lbl_desc3"
        Me.lbl_desc3.Size = New System.Drawing.Size(69, 21)
        Me.lbl_desc3.TabIndex = 168
        Me.lbl_desc3.Text = "Address:"
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(288, 187)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(374, 25)
        Me.txt_phone.TabIndex = 167
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(288, 158)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(374, 25)
        Me.txt_address.TabIndex = 166
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(288, 130)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(374, 25)
        Me.txt_name.TabIndex = 165
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(288, 102)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(374, 25)
        Me.txt_id.TabIndex = 164
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_date.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_date.Location = New System.Drawing.Point(534, 31)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(106, 24)
        Me.lbl_date.TabIndex = 162
        Me.lbl_date.Text = "Date.now"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_back.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.HotPink
        Me.btn_back.Location = New System.Drawing.Point(11, 467)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(88, 32)
        Me.btn_back.TabIndex = 160
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_customer
        '
        Me.grd_customer.BackgroundColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_customer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_customer.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_customer.Location = New System.Drawing.Point(109, 215)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.Size = New System.Drawing.Size(678, 165)
        Me.grd_customer.TabIndex = 159
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_title.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_title.Location = New System.Drawing.Point(116, 25)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(281, 30)
        Me.lbl_title.TabIndex = 158
        Me.lbl_title.Text = "Update Customer Data"
        '
        'mainPicture
        '
        Me.mainPicture.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources.mainlogo
        Me.mainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainPicture.Location = New System.Drawing.Point(0, -1)
        Me.mainPicture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mainPicture.Name = "mainPicture"
        Me.mainPicture.Size = New System.Drawing.Size(109, 77)
        Me.mainPicture.TabIndex = 163
        Me.mainPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(109, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(678, 96)
        Me.PictureBox1.TabIndex = 161
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox2.Location = New System.Drawing.Point(109, 93)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(678, 418)
        Me.PictureBox2.TabIndex = 174
        Me.PictureBox2.TabStop = False
        '
        'frm_updatecustomers_a208749
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(786, 512)
        Me.Controls.Add(Me.lbl_desc5)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_desc6)
        Me.Controls.Add(Me.lbl_desc4)
        Me.Controls.Add(Me.lbl_desc1)
        Me.Controls.Add(Me.lbl_desc2)
        Me.Controls.Add(Me.lbl_desc3)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.mainPicture)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_updatecustomers_a208749"
        Me.Text = "Update Customer Form"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_desc5 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_desc6 As Label
    Friend WithEvents lbl_desc4 As Label
    Friend WithEvents lbl_desc1 As Label
    Friend WithEvents lbl_desc2 As Label
    Friend WithEvents lbl_desc3 As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents mainPicture As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
