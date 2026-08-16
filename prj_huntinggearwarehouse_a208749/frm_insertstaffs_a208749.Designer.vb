<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaffs_a208749
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
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.mainPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.lbl_desc1 = New System.Windows.Forms.Label()
        Me.lbl_desc2 = New System.Windows.Forms.Label()
        Me.lbl_desc3 = New System.Windows.Forms.Label()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_desc4 = New System.Windows.Forms.Label()
        Me.lbl_desc5 = New System.Windows.Forms.Label()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_date.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_date.Location = New System.Drawing.Point(723, 34)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(139, 32)
        Me.lbl_date.TabIndex = 28
        Me.lbl_date.Text = "Date.now"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_back.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.HotPink
        Me.btn_back.Location = New System.Drawing.Point(16, 567)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(135, 37)
        Me.btn_back.TabIndex = 27
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_staff
        '
        Me.grd_staff.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(167, 267)
        Me.grd_staff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 51
        Me.grd_staff.Size = New System.Drawing.Size(915, 212)
        Me.grd_staff.TabIndex = 25
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_staff.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_staff.Location = New System.Drawing.Point(173, 28)
        Me.lbl_staff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(334, 37)
        Me.lbl_staff.TabIndex = 24
        Me.lbl_staff.Text = "Insert New Staff Data"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_update.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.HotPink
        Me.btn_update.Location = New System.Drawing.Point(16, 523)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(135, 37)
        Me.btn_update.TabIndex = 30
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'mainPicture
        '
        Me.mainPicture.BackgroundImage = Global.prj_huntinggearwarehouse_a208749.My.Resources.Resources.mainlogo
        Me.mainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainPicture.Location = New System.Drawing.Point(1, 0)
        Me.mainPicture.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mainPicture.Name = "mainPicture"
        Me.mainPicture.Size = New System.Drawing.Size(164, 92)
        Me.mainPicture.TabIndex = 29
        Me.mainPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Location = New System.Drawing.Point(165, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(916, 103)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_insert.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.HotPink
        Me.btn_insert.Location = New System.Drawing.Point(16, 479)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(135, 37)
        Me.btn_insert.TabIndex = 31
        Me.btn_insert.Text = "SUBMIT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'lbl_desc1
        '
        Me.lbl_desc1.AutoSize = True
        Me.lbl_desc1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc1.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc1.Location = New System.Drawing.Point(180, 110)
        Me.lbl_desc1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc1.Name = "lbl_desc1"
        Me.lbl_desc1.Size = New System.Drawing.Size(79, 28)
        Me.lbl_desc1.TabIndex = 162
        Me.lbl_desc1.Text = "Staff ID:"
        '
        'lbl_desc2
        '
        Me.lbl_desc2.AutoSize = True
        Me.lbl_desc2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc2.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc2.Location = New System.Drawing.Point(180, 146)
        Me.lbl_desc2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc2.Name = "lbl_desc2"
        Me.lbl_desc2.Size = New System.Drawing.Size(112, 28)
        Me.lbl_desc2.TabIndex = 161
        Me.lbl_desc2.Text = "Staff Name:"
        '
        'lbl_desc3
        '
        Me.lbl_desc3.AutoSize = True
        Me.lbl_desc3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc3.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc3.Location = New System.Drawing.Point(180, 183)
        Me.lbl_desc3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc3.Name = "lbl_desc3"
        Me.lbl_desc3.Size = New System.Drawing.Size(130, 28)
        Me.lbl_desc3.TabIndex = 160
        Me.lbl_desc3.Text = "Staff Position:"
        '
        'txt_position
        '
        Me.txt_position.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_position.Location = New System.Drawing.Point(361, 183)
        Me.txt_position.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(452, 30)
        Me.txt_position.TabIndex = 158
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(361, 146)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(452, 30)
        Me.txt_name.TabIndex = 157
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(361, 110)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(452, 30)
        Me.txt_id.TabIndex = 156
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox2.Location = New System.Drawing.Point(165, 100)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(916, 530)
        Me.PictureBox2.TabIndex = 164
        Me.PictureBox2.TabStop = False
        '
        'lbl_desc4
        '
        Me.lbl_desc4.AutoSize = True
        Me.lbl_desc4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc4.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc4.Location = New System.Drawing.Point(180, 484)
        Me.lbl_desc4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc4.Name = "lbl_desc4"
        Me.lbl_desc4.Size = New System.Drawing.Size(348, 28)
        Me.lbl_desc4.TabIndex = 165
        Me.lbl_desc4.Text = "Click here when the form is completed."
        '
        'lbl_desc5
        '
        Me.lbl_desc5.AutoSize = True
        Me.lbl_desc5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lbl_desc5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc5.ForeColor = System.Drawing.Color.HotPink
        Me.lbl_desc5.Location = New System.Drawing.Point(180, 528)
        Me.lbl_desc5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc5.Name = "lbl_desc5"
        Me.lbl_desc5.Size = New System.Drawing.Size(563, 28)
        Me.lbl_desc5.TabIndex = 166
        Me.lbl_desc5.Text = "Click here to access update staff credentials or delete staff form."
        '
        'frm_insertstaffs_a208749
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1077, 619)
        Me.Controls.Add(Me.lbl_desc5)
        Me.Controls.Add(Me.lbl_desc4)
        Me.Controls.Add(Me.lbl_desc1)
        Me.Controls.Add(Me.lbl_desc2)
        Me.Controls.Add(Me.lbl_desc3)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.mainPicture)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_insertstaffs_a208749"
        Me.Text = "Insert New Staffs Form"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainPicture As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_staff As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents lbl_desc1 As Label
    Friend WithEvents lbl_desc2 As Label
    Friend WithEvents lbl_desc3 As Label
    Friend WithEvents txt_position As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_desc4 As Label
    Friend WithEvents lbl_desc5 As Label
End Class
