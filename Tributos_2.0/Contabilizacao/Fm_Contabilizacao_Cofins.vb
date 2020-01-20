Imports System.Data.SqlClient

Public Class Fm_Contabilizacao_Cofins
    Private Sub Fm_Contabilizacao_Cofins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal

        Txt_Data_Pagamento.Text = Date.Today
        vlDia = DateTime.Now.Day
        vlAno = DateTime.Now.Year
        vlCalendario = DateTime.Now.Year()
        vlMes = DateTime.Now.Month - 1
        ComboData()
        Preencher_Combo_01()
        'Conectar ao banco
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
    End Sub
    Private Sub Preencher_Combo_02()
        Try
            Btn_Contabilizar.Text = "Inserir Data de Pagamento"
            Btn_Contabilizar.Width = 160
            sql = "Select  DISTINCT Mes from cofins Where Recolhido="
            sql += " '" & "N" & "' "
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Cofins")
            CB_Periodo.ValueMember = "id"
            CB_Periodo.DisplayMember = "Mes"
            CB_Periodo.DataSource = local.Tables(0)
            resultado = local.Tables("Cofins").Rows.Count
            If resultado = 0 Then
                lbInform.Text = "Não Existe Período para Gerar Guia"
                Btn_Contabilizar.Enabled = False
            Else
                lbInform.Text = ""
                LB_Periodo.Text = "Mês Para Colocar a Data:"
                Btn_Contabilizar.Text = "Inserir Data de Pagamento"
                Btn_Contabilizar.Width = 160
                Btn_Contabilizar.Enabled = True
                'Btn_Contabilizar.Size.Widt(75)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_Combo_01()
        Try
            Btn_Contabilizar.Text = "Encerrar Cadastro"
            Btn_Contabilizar.Width = 110
            sql = "Select  DISTINCT Mes from cofins Where Recolhido "
            sql += " is null"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Cofins")
            CB_Periodo.ValueMember = "id"
            CB_Periodo.DisplayMember = "Mes"
            CB_Periodo.DataSource = local.Tables(0)
            resultado = local.Tables("Cofins").Rows.Count
            If resultado = 0 Then
                lbInform.Text = "Não Existe Período para Encerrar"
                Btn_Contabilizar.Enabled = False

            Else
                lbInform.Text = ""
                Btn_Contabilizar.Text = "Encerrar"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub IDMAx()
        Try
            If R_Fechar.Checked Then
                sql = "Select Max(Id) MaxID from Cofins "
                sql += "Where Contabilizado='" & "S" & "'"
            Else
                sql = "Select Max(Id) MaxID from Cofins "
                sql += "Where Recolhido='" & "S" & "'"
            End If

            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            resultado = local.Tables("IR").Rows.Count
            registro = local.Tables("IR").Rows(0)
            Id = local.Tables(0).Rows(0)("MaxId")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboData()

        If vlMes = "1" Then
            vlMes = "01"
        ElseIf vlMes = "2" Then
            vlMes = "02"
        ElseIf vlMes = "3" Then
            vlMes = "03"
        ElseIf vlMes = "4" Then
            vlMes = "04"
        ElseIf vlMes = "5" Then
            vlMes = "05"
        ElseIf vlMes = "6" Then
            vlMes = "06"
        ElseIf vlMes = "7" Then
            vlMes = "07"
        ElseIf vlMes = "8" Then
            vlMes = "08"
        ElseIf vlMes = "9" Then
            vlMes = "09"
        End If
    End Sub

    Private Sub Btn_Contabilizar_Click(sender As Object, e As EventArgs) Handles Btn_Contabilizar.Click
        IDMAx()
        vlMes = CB_Periodo.Text
        ComboData()
        vlAno = Year(Txt_Data_Pagamento.Text)
        DataCadastro = Format(CType(Txt_Data_Pagamento.Text, DateTime), "yyyy/MM/dd HH:mm:ss")
        If resultado > 0 Then
            If MsgBox("Olá " & NomeUsuario & Informe, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    If R_Fechar.Checked Then
                        sql = "update Cofins set Contabilizado='" & "S" & "',"
                        sql += " DataFechamento='" & DataCadastro & "',"
                        sql += " Recolhido='" & "N" & "'"
                        sql += "Where Contabilizado='" & "N" & "'"
                        sql += "And Mes<='" & vlMes & " '"
                        sql += "And Id>'" & Id & "'"
                        Gravar_Banco()
                        Preencher_Combo_01()
                    Else
                        sql = "update Cofins set Recolhido='" & "S" & "',"
                        sql += " DataRecolhimento='" & DataCadastro & "'"
                        sql += "Where Contabilizado='" & "S" & "'"
                        sql += "And Mes<='" & vlMes & " '"
                        sql += "And Id>'" & Id & "'"
                        sql += "and Recolhido='" & "N" & "'"
                        Gravar_Banco()
                        Preencher_Combo_02()
                    End If
                    MsgBox("Contabilização Realizada com Sucesso!", vbInformation, "COFINS")
                Catch ex As Exception
                    conectar.Close()
                    MsgBox("Erro de Conecção, Não foi realizada a Contabilização")
                    Me.Close()
                End Try
            End If
        Else
            lbInform.Text = "Todos os dados ja foram contabilizados!!"
            Txt_Data_Pagamento.Focus()
            Btn_Contabilizar.Enabled = False
        End If
    End Sub

    Private Sub R_Fechar_CheckedChanged(sender As Object, e As EventArgs) Handles R_Fechar.CheckedChanged
        LB_Informacao.Text = "Favor Inserir a Data do Fechamento da Guia de COFINS S/ Faturamento."
        Informe = " Deseja Marcar como Encerrada a Guia de COFINS S/ Faturamento ?"
        Preencher_Combo_01()
    End Sub

    Private Sub R_Contabilizar_CheckedChanged(sender As Object, e As EventArgs) Handles R_Contabilizar.CheckedChanged
        LB_Informacao.Text = "Favor Inserir a Data do Pagamento da Guia de COFINS S/ Faturamento."
        Informe = " Deseja Marcar Como Contabilizado a Guia de COFINS S/ Faturamento ?"

        Preencher_Combo_02()


    End Sub
    Sub Gravar_Banco()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conectar.Close()
        End Try
      
    End Sub
End Class