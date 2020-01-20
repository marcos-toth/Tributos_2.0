Imports System.Data.SqlClient
Module Conexcao_SQL

    Public Sub UPDATE_Consulta_Mes()
        Try
            Query = "Update_Periodo_APS"
            comando.Connection = conectar
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = Query
            comando.CommandTimeout = 360
            conectar.Open()
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
