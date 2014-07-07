Imports System.Data.OleDb
Imports System.Data
Imports System.IO

Module dbConnection

    Public databaseConn As OleDbConnection

    Public Function openConn() As OleDbConnection
        If IsNothing(databaseConn) Then
        ElseIf databaseConn.State = ConnectionState.Open Then
            databaseConn.Close()
        End If

        databaseConn = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=./Database/shop_management_system.accdb;")

        Try
            databaseConn.Open()
        Catch ex As Exception
            MsgBox("Cannot open database", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try

        Return databaseConn
    End Function

    Public conn As New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=./Database/shop_management_system.accdb")
End Module
