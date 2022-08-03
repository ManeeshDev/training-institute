<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourses
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCrsNumber = New System.Windows.Forms.TextBox()
        Me.txtCrsName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnStDt = New System.Windows.Forms.Label()
        Me.btnCrsMod = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C O U R S E  D E T A I L S"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Course Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course Name"
        '
        'txtCrsNumber
        '
        Me.txtCrsNumber.Location = New System.Drawing.Point(142, 69)
        Me.txtCrsNumber.Multiline = True
        Me.txtCrsNumber.Name = "txtCrsNumber"
        Me.txtCrsNumber.Size = New System.Drawing.Size(180, 20)
        Me.txtCrsNumber.TabIndex = 1
        '
        'txtCrsName
        '
        Me.txtCrsName.Location = New System.Drawing.Point(142, 113)
        Me.txtCrsName.Multiline = True
        Me.txtCrsName.Name = "txtCrsName"
        Me.txtCrsName.Size = New System.Drawing.Size(180, 20)
        Me.txtCrsName.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(31, 156)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(186, 32)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add New Record"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(238, 156)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 32)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 361
        Me.LineShape1.Y1 = 1
        Me.LineShape1.Y2 = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(360, 227)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'btnStDt
        '
        Me.btnStDt.AutoSize = True
        Me.btnStDt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStDt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStDt.ForeColor = System.Drawing.Color.Blue
        Me.btnStDt.Location = New System.Drawing.Point(31, 198)
        Me.btnStDt.Name = "btnStDt"
        Me.btnStDt.Size = New System.Drawing.Size(79, 13)
        Me.btnStDt.TabIndex = 6
        Me.btnStDt.Text = "Student Details"
        '
        'btnCrsMod
        '
        Me.btnCrsMod.AutoSize = True
        Me.btnCrsMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrsMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrsMod.ForeColor = System.Drawing.Color.Blue
        Me.btnCrsMod.Location = New System.Drawing.Point(125, 198)
        Me.btnCrsMod.Name = "btnCrsMod"
        Me.btnCrsMod.Size = New System.Drawing.Size(83, 13)
        Me.btnCrsMod.TabIndex = 6
        Me.btnCrsMod.Text = "Course Modules"
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.ForeColor = System.Drawing.Color.Blue
        Me.btnExit.Location = New System.Drawing.Point(292, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(24, 13)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        '
        'frmCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(360, 227)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCrsMod)
        Me.Controls.Add(Me.btnStDt)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCrsName)
        Me.Controls.Add(Me.txtCrsNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmCourses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCrsNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCrsName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnStDt As System.Windows.Forms.Label
    Friend WithEvents btnCrsMod As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label

End Class
