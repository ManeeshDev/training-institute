Imports System.Data.SqlClient

Public Class frmCourseModule

    Private Sub frmCourseModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TD()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmd As SqlCommand
        Dim Ans As String

        cmd = New SqlCommand("INSERT INTO CourseModule(ModuleNo,ModuleName,CourseNo) VALUES('" & txtModNo.Text & "','" & txtModName.Text & "','" & txtCrsNo.Text & "')", ti)

        If ti.State = ConnectionState.Closed Then
            ti.Open()
        End If

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

    Private Sub clear()
        txtCrsNo.Text = ""
        txtModNo.Text = ""
        txtModName.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnStDt_Click(sender As Object, e As EventArgs) Handles btnStDt.Click
        Me.Hide()
        frmStudents.Show()
    End Sub

    Private Sub btnCrsMod_Click(sender As Object, e As EventArgs) Handles btnCrsMod.Click
        Me.Hide()
        frmCourses.Show()
    End Sub
End Class