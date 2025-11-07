Imports System.Data
Imports System.Data.Common
Imports System.Reflection.Metadata
Imports System.Data.OleDb

Module modDB
    Public CONN As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data\App.accdb;Persist Security Info=False;"

    Public Function GetTable(sql As String, params As List(Of OleDbParameter)) As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(CONN)
            Using cmd As New OleDbCommand(sql, cn)
                If params IsNot Nothing Then
                    AddParameters(cmd, params)
                End If
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function Exec(sql As String, params As List(Of OleDbParameter)) As Integer
        Using cn As New OleDbConnection(CONN)
            Using cmd As New OleDbCommand(sql, cn)
                If params IsNot Nothing Then
                    AddParameters(cmd, params)
                End If
                cn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Private Sub AddParameters(cmd As OleDbCommand, params As List(Of OleDbParameter))
        cmd.Parameters.Clear()
        For i As Integer = 0 To params.Count - 1
            Dim src = params(i)
            Dim val = If(src IsNot Nothing, src.Value, DBNull.Value)
            Dim dbType As OleDbType


            If src IsNot Nothing AndAlso src.OleDbType <> OleDbType.VarWChar Then

                dbType = src.OleDbType
            Else
                dbType = InferOleDbType(val)
            End If

            Dim paramName = "@p" & i.ToString()
            Dim p As New OleDbParameter(paramName, dbType)
            p.Value = If(val Is Nothing, DBNull.Value, val)
            cmd.Parameters.Add(p)
        Next
    End Sub

    Private Function InferOleDbType(value As Object) As OleDbType
        If value Is Nothing OrElse Convert.IsDBNull(value) Then
            Return OleDbType.VarWChar
        End If

        Dim t = value.GetType()

        If t Is GetType(Integer) OrElse t Is GetType(Int16) OrElse t Is GetType(Int32) Then
            Return OleDbType.Integer
        End If
        If t Is GetType(Long) Then
            Return OleDbType.BigInt
        End If
        If t Is GetType(Boolean) Then
            Return OleDbType.Boolean
        End If
        If t Is GetType(Decimal) Then
            Return OleDbType.Decimal
        End If
        If t Is GetType(Double) OrElse t Is GetType(Single) Then
            Return OleDbType.Double
        End If
        If t Is GetType(DateTime) Then
            Return OleDbType.Date
        End If


        Return OleDbType.VarWChar
    End Function
End Module