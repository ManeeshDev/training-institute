<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseModule
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCrsNo = New System.Windows.Forms.TextBox()
        Me.txtModName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.btnCrsMod = New System.Windows.Forms.Label()
        Me.btnStDt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.btnUpdate.Location = New System.Drawing.Point(244, 186)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(78, 32)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
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
        Me.btnAdd.Location = New System.Drawing.Point(44, 186)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(188, 32)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add New Record"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtCrsNo
        '
        Me.txtCrsNo.Location = New System.Drawing.Point(142, 146)
        Me.txtCrsNo.Multiline = True
        Me.txtCrsNo.Name = "txtCrsNo"
        Me.txtCrsNo.Size = New System.Drawing.Size(180, 20)
        Me.txtCrsNo.TabIndex = 3
        '
        'txtModName
        '
        Me.txtModName.Location = New System.Drawing.Point(142, 110)
        Me.txtModName.Multiline = True
        Me.txtModName.Name = "txtModName"
        Me.txtModName.Size = New System.Drawing.Size(180, 20)
        Me.txtModName.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Course No"
        '
        'txtModNo
        '
        Me.txtModNo.Location = New System.Drawing.Point(142, 73)
        Me.txtModNo.Multiline = True
        Me.txtModNo.Name = "txtModNo"
        Me.txtModNo.Size = New System.Drawing.Size(180, 20)
        Me.txtModNo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Module Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Module  No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C O U R S E  M O D U L E S"
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 364
        Me.LineShape1.Y1 = 1
        Me.LineShape1.Y2 = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(366, 251)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.ForeColor = System.Drawing.Color.Blue
        Me.btnExit.Location = New System.Drawing.Point(298, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(24, 13)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        '
        'btnCrsMod
        '
        Me.btnCrsMod.AutoSize = True
        Me.btnCrsMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrsMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCrsMod.ForeColor = System.Drawing.Color.Blue
        Me.btnCrsMod.Location = New System.Drawing.Point(139, 225)
        Me.btnCrsMod.Name = "btnCrsMod"
        Me.btnCrsMod.Size = New System.Drawing.Size(75, 13)
        Me.btnCrsMod.TabIndex = 26
        Me.btnCrsMod.Text = "Course Details"
        '
        'btnStDt
        '
        Me.btnStDt.AutoSize = True
        Me.btnStDt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStDt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStDt.ForeColor = System.Drawing.Color.Blue
        Me.btnStDt.Location = New System.Drawing.Point(41, 225)
        Me.btnStDt.Name = "btnStDt"
        Me.btnStDt.Size = New System.Drawing.Size(79, 13)
        Me.btnStDt.TabIndex = 27
        Me.btnStDt.Text = "Student Details"
        '
        'frmCourseModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(366, 251)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCrsMod)
        Me.Controls.Add(Me.btnStDt)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCrsNo)
        Me.Controls.Add(Me.txtModName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtModNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmCourseModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Module"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCrsNo As System.Windows.Forms.TextBox
    Friend WithEvents txtModName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtModNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents btnCrsMod As System.Windows.Forms.Label
    Friend WithEvents btnStDt As System.Windows.Forms.Label
End Class
