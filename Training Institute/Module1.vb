Imports System.Data.SqlClient

Module Module1
    Public ti As SqlConnection

    Public Sub TD()
        ti = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\MP_ Works\VB @VTA_DIP_2019\Training Institute\Training Institute\Training Institute _Db.mdf;Integrated Security=True")
    End Sub

End Module
