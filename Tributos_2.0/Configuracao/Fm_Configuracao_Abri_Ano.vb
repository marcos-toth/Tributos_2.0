Imports System.Data.SqlClient
Public Class Fm_Configuracao_Abri_Ano

    Private Sub Fm_Abri_Ano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.MdiParent = Fm_Principal
            conectar = New SqlConnection
            conectar.ConnectionString = cnn
            Preencher_Combo()
            'Cbo_Ano.SelectedItem = 0
            'Cbo_Ano.Text = DateTime.Now.Year + 1
            vlMes = Date.Today.Month
            'Cb_Ano.Text = vlAno & vlMes
            Verificar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Preencher_Combo()
        'Busca o Nome do usuário logado  
        conectar.Open()
        sql = "select * from Anos where Condicao="
        sql += "'" & "N" & "'"
        adaptar = New SqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "Anos")
        Cbo_Ano.ValueMember = "Id"
        Cbo_Ano.DisplayMember = "Ano"
        Cbo_Ano.DataSource = local.Tables(0)
        Cbo_Ano.SelectedIndex = 0
    End Sub
    Private Sub Verificar()
        Try
            conectar.Open()
            sql = "select * from Anos where Ano="
            sql += "'" & Cbo_Ano.Text & "'and Condicao="
            sql += "'" & "A" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Anos")
            resultado = local.Tables("Anos").Rows.Count

            If resultado > 0 Then
                LB_Inform.Text = "O Ano Já Está Aberto!"
            Else
                Btn_Abri_Ano.Text = "Abrir Ano"
                LB_Inform.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cbo_Ano_Validated(sender As Object, e As EventArgs) Handles Cbo_Ano.Validated
        Try
            conectar.Open()
            sql = "select * from Anos where Ano="
            sql += "'" & Cbo_Ano.Text & "'and Condicao="
            sql += "'" & "A" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Anos")
            resultado = local.Tables("Anos").Rows.Count

            If resultado > 0 Then
                LB_Inform.Text = "O Ano Já Está Aberto!"
            Else
                Btn_Abri_Ano.Text = "Abrir Ano"
                LB_Inform.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Abri_Ano_Click(sender As Object, e As EventArgs) Handles Btn_Abri_Ano.Click
        Try
            Verificar()
            If resultado = "0" Then
                'sql = "insert into Anos (Ano,Condicao)"
                'sql += "values ('" & Cbo_Ano.Text & "',"
                'sql += "'" & "A" & "')"
                'Conectar_Banco()


                sql = "update Anos set Condicao='" & "A" & "' "
                sql += " where Ano='" & Cbo_Ano.Text & "' "
                Conectar_Banco()

                sql = "insert into Anos (Ano,Condicao)"
                sql += "values ('" & Cbo_Ano.Text + 1 & "',"
                sql += "'" & "N" & "')"
                Conectar_Banco()

                GravarPeriodo()
                LB_Inform.Text = "Ano Gerado com Sucesso!!!"
                Preencher_Combo()
                Exit Sub
            End If
            LB_Inform.Text = "Esse Ano Já Esta Aberto"
        Catch ex As Exception
            MsgBox("Seus Dados Não Foram Gravados")
            conectar.Close()
            Exit Sub
        End Try
    End Sub

    Sub GravarPeriodo()

        For value As Integer = 1 To 12
            VPeriodo = Cbo_Ano.Text
            If value = 1 Then
                VPeriodo = Cbo_Ano.Text & "01"
            ElseIf value = 2 Then
                VPeriodo = Cbo_Ano.Text & "02"
            ElseIf value = 3 Then
                VPeriodo = Cbo_Ano.Text & "03"
            ElseIf value = 4 Then
                VPeriodo = Cbo_Ano.Text & "04"
            ElseIf value = 5 Then
                VPeriodo = Cbo_Ano.Text & "05"
            ElseIf value = 6 Then
                VPeriodo = Cbo_Ano.Text & "06"
            ElseIf value = 7 Then
                VPeriodo = Cbo_Ano.Text & "07"
            ElseIf value = 8 Then
                VPeriodo = Cbo_Ano.Text & "08"
            ElseIf value = 9 Then
                VPeriodo = Cbo_Ano.Text & "09"
            ElseIf value = 10 Then
                VPeriodo = Cbo_Ano.Text & "10"
            ElseIf value = 11 Then
                VPeriodo = Cbo_Ano.Text & "11"
            ElseIf value = 12 Then
                VPeriodo = Cbo_Ano.Text & "12"
            End If

            Try
                sql = "insert into Periodo (Periodo,Condicao)"
                sql += "values ('" & VPeriodo & "',"
                sql += "'" & "N" & "')"
                Conectar_Banco()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '' MsgBox(value)

            If (value = 12) Then
                Exit For
            End If
            Console.WriteLine(value)
        Next

    End Sub

    Public Sub Conectar_Banco()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Conectar.Close()
            Exit Sub
        End Try
    End Sub
End Class