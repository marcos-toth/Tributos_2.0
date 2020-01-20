﻿Imports System.Data.SqlClient

Public Class Fm_Principal
    Private Sub Fm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If vnivel = "1" Then
            ObservaçõesRecolhimentoToolStripMenuItem1.Enabled = False
            ContabilizarToolStripMenuItem.Enabled = False
            UniãoToolStripMenuItem.Enabled = False
            CadastroDeduçãoINSSToolStripMenuItem.Enabled = False
            UsuáriosToolStripMenuItem1.Enabled = False
            ConfiguraçãoToolStripMenuItem.Enabled = False
            CadastroEntidadesToolStripMenuItem.Enabled = False
            ToolStrip2.Visible = False
            CentralizaçãoToolStripMenuItem.Enabled = False


        ElseIf vnivel = "2" Then
            CadastroFunçõesToolStripMenuItem.Enabled = False
            CadastroPagamentoRealizadoCampoToolStripMenuItem.Enabled = False
            ObservaçõesRecolhimentoToolStripMenuItem1.Enabled = False
            ContabilizarToolStripMenuItem.Enabled = False
            UsuáriosToolStripMenuItem.Enabled = False
            UniãoToolStripMenuItem.Enabled = False
            CadastroDeduçãoINSSToolStripMenuItem.Enabled = False
            CadastroObservaçõesToolStripMenuItem.Enabled = False
            UsuáriosToolStripMenuItem1.Enabled = False
            ConfiguraçãoToolStripMenuItem.Enabled = False
            CadastroEntidadesToolStripMenuItem.Enabled = False
            ToolStrip1.Visible = False
            ToolStrip2.Visible = False
            CadastroFunçõesToolStripMenuItem.Enabled = False
            CentralizaçãoToolStripMenuItem.Enabled = False

        ElseIf vnivel = "3" Then
            CadastroFunçõesToolStripMenuItem.Enabled = False
            CadastroPagamentoRealizadoCampoToolStripMenuItem.Enabled = False
            CadastroFunçõesToolStripMenuItem.Enabled = False
            ObservaçõesRecolhimentoToolStripMenuItem1.Enabled = False
            ContabilizarToolStripMenuItem.Enabled = False
            CadastroToolStripMenuItem.Enabled = False
            UniãoToolStripMenuItem.Enabled = False
            CadastroDeduçãoINSSToolStripMenuItem.Enabled = False
            CadastroObservaçõesToolStripMenuItem.Enabled = False
            UsuáriosToolStripMenuItem1.Enabled = False
            ConfiguraçãoToolStripMenuItem.Enabled = False
            InformeAnualIRAluguéisToolStripMenuItem.Enabled = False
            CadastroFunçõesToolStripMenuItem.Enabled = False
            ObservaçõesRecolhimentoToolStripMenuItem1.Enabled = False
            CadastroToolStripMenuItem.Enabled = False
            CadastroEntidadesToolStripMenuItem.Enabled = False
            ToolStrip1.Visible = False
            ToolStrip2.Visible = False
            CadastroFunçõesToolStripMenuItem.Enabled = False
            CentralizaçãoToolStripMenuItem.Enabled = False

        ElseIf vnivel = "4" Then
            CadastroFunçõesToolStripMenuItem.Enabled = False
            CadastroPagamentoRealizadoCampoToolStripMenuItem.Enabled = False
            ContabilizarToolStripMenuItem.Enabled = False
            CampoToolStripMenuItem.Enabled = False
            UsuáriosToolStripMenuItem.Enabled = False
            COFINSSFaturamentoLojasToolStripMenuItem.Enabled = False
            DepósitosCentralizaçãoDeEncargosToolStripMenuItem.Enabled = False
            IRAlugéisToolStripMenuItem.Enabled = False
            'CadastroObservaçõesToolStripMenuItem.Visible = False
            UsuáriosToolStripMenuItem.Enabled = False
            ConfiguraçãoToolStripMenuItem.Enabled = False
            CadastroEntidadesToolStripMenuItem.Enabled = False
            ToolStrip1.Enabled = False
            ToolStrip2.Visible = False
            CadastroFunçõesToolStripMenuItem.Enabled = False
            CentralizaçãoToolStripMenuItem.Enabled = False

        ElseIf vnivel = "5" Then
            'CadastroFunçõesToolStripMenuItem.Enabled = False
            DepósitosCentralizaçãoDeEncargosToolStripMenuItem.Enabled = False
            CampoToolStripMenuItem.Visible = False
            UsuáriosToolStripMenuItem.Visible = False
            COFINSSFaturamentoLojasToolStripMenuItem.Visible = False
            IRAlugéisToolStripMenuItem.Visible = False
            UsuáriosToolStripMenuItem1.Visible = False
            ConfiguraçãoToolStripMenuItem.Visible = False
            ToolStrip1.Visible = False
            TributosToolStripMenuItem1.Visible = False
            CentralizaçãoToolStripMenuItem.Visible = False
            ContabilizarCOFINSToolStripMenuItem.Visible = False
            ContabilizarDeduçãoINSSToolStripMenuItem.Visible = False
            ContabilizarIRAlugueisToolStripMenuItem.Visible = False

        ElseIf vnivel = "0" Then
            ToolStrip2.Visible = False
        End If
        'Preenchimento da Statusbar
        Dim dtt As DateTime = DateTime.Now
        Dim sMsg As String
        Dim sTgl As String
        sTgl = dtt.ToShortDateString
        Nome_Usuario = Usuario
        StatusBar1.Panels(0).Text = "Sistema de Centralização de Tributos da União Central Brasileira"
        StatusBar1.Panels(1).Text = "Usuário: " & Usuario
        StatusBar1.Panels(2).Text = sTgl
        sMsg = dtt.ToShortTimeString
        StatusBar1.Panels(4).Text = "Entidade Logada: " & EntidadeLogada
        StatusBar1.Panels(5).Text = Versao
        AvisoMes = DateTime.Now.Month
        If My.Settings.VesaoAplic <> versao Then
            Fm_Versao.Show()
        End If
        If My.Settings.Data <> AvisoMes Then
            Fm_Data_Deposito.Show()
        End If
        vlMes = Date.Today.Month

    End Sub
    Private Sub COFINSSFaturamentoLojasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COFINSSFaturamentoLojasToolStripMenuItem.Click
        Fm_Cadastro_COFINS.Show()
    End Sub
    Private Sub DepósitosCentralizaçãoDeEncargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepósitosCentralizaçãoDeEncargosToolStripMenuItem.Click
        Fm_Cadastro_Depositos.Show()
    End Sub

    Private Sub COFINSFaturamentoLojasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COFINSFaturamentoLojasToolStripMenuItem.Click
        Fm_Relatorio_UCB_Cofins.Show()
    End Sub
    Private Sub DepósitosPendentesAFazerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepósitosPendentesAFazerToolStripMenuItem.Click
        Fm_Relatorio_Nao_Depositaram.Show()
    End Sub
    Private Sub DepósitosRealizadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepósitosRealizadosToolStripMenuItem.Click
        Fm_Relatorio_UCB_Depositos.Show()
    End Sub
   
    Private Sub COFINSLojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COFINSLojaToolStripMenuItem.Click
        Fm_Relatorio_Campo_COFINS.Show()
    End Sub
    Private Sub EncargosParaDepósitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncargosParaDepósitoToolStripMenuItem.Click
        Fm_Relatorio_Campo_Deposito.Show()
    End Sub
    Private Sub ContatoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContatoToolStripMenuItem1.Click
        Fm_Contato.Show()
    End Sub
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub
    Private Sub VideoTreinamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoTreinamentoToolStripMenuItem.Click
        Fm_Video_Treinamentos.Show()
    End Sub
    Private Sub HistóricosDasVersõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricosDasVersõesToolStripMenuItem.Click
        Fm_Versao.Show()
    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("Olá " & NomeUsuario & " Deseja Sair do Sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            FecharSistema()
        End If
    End Sub
    Private Sub FecharSistema()
        Me.Dispose()
        Application.Exit()
    End Sub
    Private Sub Fm_Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FecharSistema()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        StatusBar1.Panels(3).Text = TimeString
    End Sub

    Private Sub AbatimentoINSSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Fm_relatorio_AbatimentoINSS.Show()
    End Sub
    Private Sub AbatimentoINSSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbatimentoINSSToolStripMenuItem1.Click
        Fm_relatorio_AbatimentoINSS.Show()
    End Sub
    Private Sub ContabilizarCOFINSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ContabilizarCOFINSToolStripMenuItem.Click
        Fm_Contabilizacao_Cofins.Show()
    End Sub

    Private Sub ContabilizarIRAlugueisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilizarIRAlugueisToolStripMenuItem.Click
        Fm_Contabilizacao_IR.Show()
    End Sub


    Private Sub ContabilizarDeduçãoINSSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilizarDeduçãoINSSToolStripMenuItem.Click
        If MsgBox("Olá " & NomeUsuario & " Deseja Marcar Como Contabilizado os as Deduções de INSS?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                sql = "update DeducaoINSS set Contabilizado='" & "S" & "'"
                sql += "Where Mes='" & vlMes & "'"
                conectar.Open()
                comando = New SqlCommand(sql)
                comando.Connection = conectar
                comando.ExecuteNonQuery()
                conectar.Close()
                MsgBox("Contabilização Realizada com Sucesso!!", vbInformation, "Contabilização")
            Catch ex As Exception
                conectar.Close()
                MsgBox("Erro de Conecção, Não foi realizada a Contabilização")
            End Try
        End If
    End Sub

    Private Sub CadastroObservaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroObservaçõesToolStripMenuItem.Click
        Fm_Cadastro_Observacao.Show()
    End Sub

    Private Sub AbrirAnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirAnoToolStripMenuItem.Click
        Fm_Configuracao_Abri_Ano.Show()
    End Sub

    Private Sub AbrirPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirPeriodoToolStripMenuItem.Click
        Fm_Configuracao_Abre_Periodo.Show()
    End Sub

    Private Sub FechaPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaPeríodoToolStripMenuItem.Click
        Fm_Configuracao_Fecha_Periodo.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem1.Click
        Fm_Relatório_Usuario.Show()
    End Sub

    Private Sub TrocaSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrocaSenhaToolStripMenuItem.Click
        Fm_Troca_Senha.Show()
    End Sub

    Private Sub StatusBar1_PanelClick(sender As Object, e As StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick
        If vnivel = "0" Then
            Fm_Trocar_Entidade_Logada.Show()
        End If
    End Sub
    Private Sub ObservaçõesRecolhimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObservaçõesRecolhimentoToolStripMenuItem1.Click
        Fm_Relatorio_Observacao.Show()
    End Sub

    Private Sub InformeAnualIRAluguéisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeAnualIRAluguéisToolStripMenuItem.Click
        Fm_Relatorio_Informe_IR.Show()
    End Sub
    Private Sub BuscarSaldoMensalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarSaldoMensalToolStripMenuItem.Click
        Fm_Contabilizacao_Tributos.Show()
    End Sub
    Private Sub BuscarSaldo13ºToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarSaldo13ºToolStripMenuItem.Click
        Fm_Contabilizacao_Decimo_Terceiro.Show()
    End Sub

    Private Sub CadastroDeduçãoINSSMensalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeduçãoINSSMensalToolStripMenuItem.Click
        Fm_Cadastro_Deducao_INSS.Show()
    End Sub

    Private Sub CadastroDeduçãoINSS13ºToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeduçãoINSS13ºToolStripMenuItem.Click
        Fm_Cadastro__Deducao_INSS_Decimo_Terceiro.Show()
    End Sub

    Private Sub AbatimentoINSS13ºToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbatimentoINSS13ºToolStripMenuItem.Click
        Fm_relatorio_AbatimentoINSS_13.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        Fm_Cadastro_Usuario.Show()
    End Sub

    Private Sub RelatórioMensalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioMensalToolStripMenuItem.Click
        Fm_Relatorio_Tributos.Show()
    End Sub

    Private Sub RelatórioINSS13ºToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioINSS13ºToolStripMenuItem.Click
        Fm_Relatorio_INSS_Decimo_Terceiro.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles Tributo_Mensal.Click
        Fm_Relatorio_Tributos.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles Cad_COFINS.Click
        Fm_Cadastro_COFINS.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles Cad_Depositos.Click
        Fm_Cadastro_Depositos.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles Cad_IR_Aluguel.Click
        Fm_Cadastro_IR_Aluguel.Show()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles Calculadora.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles Troca_Senha.Click
        Fm_Troca_Senha.Show()
    End Sub

    Private Sub DataParaOsDepósitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataParaOsDepósitosToolStripMenuItem.Click
        Fm_Data_Deposito.Show()
    End Sub

    Private Sub Data_Para_Depositos_Click(sender As Object, e As EventArgs) Handles Data_Para_Depositos.Click
        Fm_Data_Deposito.Show()
    End Sub

    Private Sub RelatórioTributos13ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioTributos13ToolStripMenuItem.Click
        Fm_Relatorio_Decimo_Terceiro.Show()
    End Sub

    Private Sub CadastroEntidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroEntidadesToolStripMenuItem.Click
        Fm_Cadastro_Entidade.Show()
    End Sub

    Private Sub RelatórioTributosMêsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioTributosMêsToolStripMenuItem.Click
        Fm_Relatorio_Tributos_Recolhimento_UCB.Show()
    End Sub

    Private Sub FechaAnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaAnoToolStripMenuItem.Click
        Fm_Configuracao_Fecha_Ano.Show()
    End Sub

    Private Sub Relatorio_Tributos_Click(sender As Object, e As EventArgs) Handles Relatorio_Tributos.Click
        Fm_Relatorio_Tributos_Recolhimento_UCB.Show()
    End Sub

    Private Sub CadastroFunçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroFunçõesToolStripMenuItem.Click
        Fm_Cadastro_Funcao.Show()
    End Sub

    Private Sub FunçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunçõesToolStripMenuItem.Click
        Fm_Relatorio_Funcoes.Show()
    End Sub

    Private Sub Deducao_IINSS_Click(sender As Object, e As EventArgs) Handles Deducao_IINSS.Click
        Fm_Cadastro_Deducao_INSS.Show()
    End Sub

    Private Sub IR_Aluguel_Click(sender As Object, e As EventArgs) Handles IR_Aluguel.Click
        Fm_Relatorio_Informe_IR.Show()
    End Sub

    Private Sub RelatórioIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioIRToolStripMenuItem.Click
        Fm_Relatorio_Centralizacao.Show()
    End Sub

    Private Sub CadastroPagamentoRealizadoCampoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroPagamentoRealizadoCampoToolStripMenuItem.Click
        Fm_Cadastro_Pagamentos_Realizados.show()
    End Sub

    Private Sub DatasDepósitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatasDepósitosToolStripMenuItem.Click
        Fm_Cad_Data_Deposito.Show()
    End Sub

    Private Sub EntidadeComOMesAbertoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntidadeComOMesAbertoToolStripMenuItem.Click
        Fm_Mes_Aberto_APS.Show()
    End Sub

    Private Sub IRAluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRAluguelToolStripMenuItem.Click
        Fm_Cadastro_IR_Aluguel.Show()
    End Sub

    Private Sub IRMultaRescisóriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRMultaRescisóriaToolStripMenuItem.Click
        Fm_cadastro_IR_Recisao_Aluguel.Show()
    End Sub

    Private Sub IRRecisãoAluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRRecisãoAluguelToolStripMenuItem.Click
        Fm_IR_Recisao_Aluguel.Show()
    End Sub

    Private Sub IRAluguelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IRAluguelToolStripMenuItem1.Click
        Fm_Relatorio_Campo_IR.Show()
    End Sub

    Private Sub IRAluguelToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles IRAluguelToolStripMenuItem2.Click
        Fm_Relatorio_UCB_IR.Show()
    End Sub

    Private Sub IRRescisãoAluguélToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRRescisãoAluguélToolStripMenuItem.Click
        Fm_UCB_IR_Resisao_Contrato.Show()
    End Sub

    Private Sub CadastroClienteIRAluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroClienteIRAluguelToolStripMenuItem.Click
        Fm_Cadastro_Cliente__IR.Show()
    End Sub

    Private Sub ClienteIRAluguelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteIRAluguelToolStripMenuItem.Click
        Fm_Cadastro_Cliente_IR_Aluguel_R.Show()
    End Sub
End Class