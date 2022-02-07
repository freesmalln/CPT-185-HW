<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TechJobFair
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
        Me.DateAndLocation = New System.Windows.Forms.Button()
        Me.ExitWin = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Phrase = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelHall = New System.Windows.Forms.Label()
        Me.LabelRoom = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateAndLocation
        '
        Me.DateAndLocation.Location = New System.Drawing.Point(12, 322)
        Me.DateAndLocation.Name = "DateAndLocation"
        Me.DateAndLocation.Size = New System.Drawing.Size(205, 23)
        Me.DateAndLocation.TabIndex = 0
        Me.DateAndLocation.Text = "Press to get the date and location "
        Me.DateAndLocation.UseVisualStyleBackColor = True
        '
        'ExitWin
        '
        Me.ExitWin.Location = New System.Drawing.Point(76, 351)
        Me.ExitWin.Name = "ExitWin"
        Me.ExitWin.Size = New System.Drawing.Size(75, 23)
        Me.ExitWin.TabIndex = 1
        Me.ExitWin.Text = "Exit Window"
        Me.ExitWin.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(200, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(214, 37)
        Me.Title.TabIndex = 2
        Me.Title.Text = "Tech Job Fair"
        '
        'Phrase
        '
        Me.Phrase.AutoSize = True
        Me.Phrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phrase.Location = New System.Drawing.Point(203, 296)
        Me.Phrase.Name = "Phrase"
        Me.Phrase.Size = New System.Drawing.Size(220, 24)
        Me.Phrase.TabIndex = 3
        Me.Phrase.Text = "All students are welcome"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = "C:\Users\Owner\Downloads\Job Fair.jpg"
        Me.PictureBox1.Location = New System.Drawing.Point(13, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(603, 244)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(494, 338)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(66, 13)
        Me.LabelDate.TabIndex = 5
        Me.LabelDate.Text = "May 2, 2016"
        Me.LabelDate.Visible = False
        '
        'LabelHall
        '
        Me.LabelHall.AutoSize = True
        Me.LabelHall.Location = New System.Drawing.Point(464, 351)
        Me.LabelHall.Name = "LabelHall"
        Me.LabelHall.Size = New System.Drawing.Size(120, 13)
        Me.LabelHall.TabIndex = 6
        Me.LabelHall.Text = "Located In Lochlan Hall"
        Me.LabelHall.Visible = False
        '
        'LabelRoom
        '
        Me.LabelRoom.AutoSize = True
        Me.LabelRoom.Location = New System.Drawing.Point(494, 364)
        Me.LabelRoom.Name = "LabelRoom"
        Me.LabelRoom.Size = New System.Drawing.Size(56, 13)
        Me.LabelRoom.TabIndex = 7
        Me.LabelRoom.Text = "Room 101"
        Me.LabelRoom.Visible = False
        '
        'TechJobFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 453)
        Me.Controls.Add(Me.LabelRoom)
        Me.Controls.Add(Me.LabelHall)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Phrase)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ExitWin)
        Me.Controls.Add(Me.DateAndLocation)
        Me.Name = "TechJobFair"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateAndLocation As Button
    Friend WithEvents ExitWin As Button
    Friend WithEvents Title As Label
    Friend WithEvents Phrase As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelHall As Label
    Friend WithEvents LabelRoom As Label
End Class
