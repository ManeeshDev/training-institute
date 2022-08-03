Imports System.Data.SqlClient

Public Class frmStudents

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TD()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmd As SqlCommand
        Dim Ans As String

        If ti.State = ConnectionState.Closed Then
            ti.Open()
        End If

        cmd = New SqlCommand("INSERT INTO Students(NICno,Name,Address,CourseNo) VALUES('" & txtNIC.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtCrsNo.Text & "')", ti)

        Ans = MsgBox("Do you Want to save Changes..?", vbYesNo + vbQuestion, "Save")

        If Ans = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully..!!", MsgBoxStyle.Information, "Save")
            clear()
        Else
            MsgBox("Save Canceled..", MsgBoxStyle.Information, "Save")
        End If

        ti.Close()

    End Sub

    Private Sub clear() '******** sub procedure- this should be called in an event procedure ********
        txtNIC.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtCrsNo.Text = ""
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCrsMod_Click(sender As Object, e As EventArgs) Handles btnCrsMod.Click
        Me.Hide()
        frmCourseModule.Show()
    End Sub

    Private Sub btnCrsDt_Click(sender As Object, e As EventArgs) Handles btnCrsDt.Click
        Me.Hide()
        frmCourses.Show()
    End Sub
End Class