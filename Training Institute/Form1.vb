Imports System.Data.SqlClient

Public Class frmCourses

    Private Sub frmCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TD()

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmd As SqlCommand
        Dim Ans As String

        cmd = New SqlCommand("INSERT INTO Courses(CourseNo,CourseName) VALUES ('" & txtCrsNumber.Text & "','" & txtCrsName.Text & "')", ti)

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
        txtCrsName.Text = ""
        txtCrsNumber.Text = ""
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
        frmCourseModule.Show()
    End Sub
End Class
