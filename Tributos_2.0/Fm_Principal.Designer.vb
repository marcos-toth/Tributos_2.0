﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Principal))
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.NomeSistema = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Data = New System.Windows.Forms.StatusBarPanel()
        Me.Hora = New System.Windows.Forms.StatusBarPanel()
        Me.Entidade_Logada = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COFINSSFaturamentoLojasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepósitosCentralizaçãoDeEncargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRAlugéisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRAluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRMultaRescisóriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroPagamentoRealizadoCampoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CadastroClienteIRAluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.CadastroDeduçãoINSSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeduçãoINSSMensalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeduçãoINSS13ºToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroObservaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CadastroFunçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroEntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentralizaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaPeríodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirAnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaAnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DatasDepósitosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSaldoMensalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSaldo13ºToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContabilizarCOFINSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizarDeduçãoINSSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizarIRAlugueisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TributosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioMensalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioINSS13ºToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CampoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.COFINSLojaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncargosParaDepósitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRAluguéisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRAluguelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRRecisãoAluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClienteIRAluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UniãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbatimentoINSSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbatimentoINSS13ºToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.COFINSFaturamentoLojasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRAluguéisToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRAluguelToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRRescisãoAluguélToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.RelatórioTributosMêsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioTributos13ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.DepósitosPendentesAFazerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepósitosRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.EntidadeComOMesAbertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ObservaçõesRecolhimentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeAnualIRAluguéisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.FunçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataParaOsDepósitosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContatoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricosDasVersõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoTreinamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrocaSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cad_Depositos = New System.Windows.Forms.ToolStripButton()
        Me.Cad_COFINS = New System.Windows.Forms.ToolStripButton()
        Me.Cad_IR_Aluguel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tributo_Mensal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.IR_Aluguel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.Data_Para_Depositos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.Calculadora = New System.Windows.Forms.ToolStripButton()
        Me.Troca_Senha = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Deducao_IINSS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.Relatorio_Tributos = New System.Windows.Forms.ToolStripButton()
        Me.Relatorio_Cofins = New System.Windows.Forms.ToolStripButton()
        Me.Relatorio_IR_Aluguel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.NomeSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Entidade_Logada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.NomeSistema, Me.StatusBarPanel1, Me.Data, Me.Hora, Me.Entidade_Logada, Me.StatusBarPanel5})
        Me.StatusBar1.ShowPanels = True
        '
        'NomeSistema
        '
        Me.NomeSistema.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.NomeSistema.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        resources.ApplyResources(Me.NomeSistema, "NomeSistema")
        '
        'StatusBarPanel1
        '
        resources.ApplyResources(Me.StatusBarPanel1, "StatusBarPanel1")
        '
        'Data
        '
        resources.ApplyResources(Me.Data, "Data")
        '
        'Hora
        '
        resources.ApplyResources(Me.Hora, "Hora")
        '
        'Entidade_Logada
        '
        resources.ApplyResources(Me.Entidade_Logada, "Entidade_Logada")
        '
        'StatusBarPanel5
        '
        resources.ApplyResources(Me.StatusBarPanel5, "StatusBarPanel5")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.CentralizaçãoToolStripMenuItem, Me.ConfiguraçãoToolStripMenuItem, Me.ContabilizarToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.AjudaToolStripMenuItem1, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroToolStripMenuItem, "CadastroToolStripMenuItem")
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COFINSSFaturamentoLojasToolStripMenuItem, Me.DepósitosCentralizaçãoDeEncargosToolStripMenuItem, Me.IRAlugéisToolStripMenuItem, Me.CadastroPagamentoRealizadoCampoToolStripMenuItem, Me.ToolStripSeparator1, Me.CadastroClienteIRAluguelToolStripMenuItem, Me.ToolStripSeparator25, Me.CadastroDeduçãoINSSToolStripMenuItem, Me.CadastroObservaçõesToolStripMenuItem, Me.ToolStripSeparator5, Me.CadastroFunçõesToolStripMenuItem, Me.CadastroEntidadesToolStripMenuItem, Me.UsuáriosToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        '
        'COFINSSFaturamentoLojasToolStripMenuItem
        '
        resources.ApplyResources(Me.COFINSSFaturamentoLojasToolStripMenuItem, "COFINSSFaturamentoLojasToolStripMenuItem")
        Me.COFINSSFaturamentoLojasToolStripMenuItem.Name = "COFINSSFaturamentoLojasToolStripMenuItem"
        '
        'DepósitosCentralizaçãoDeEncargosToolStripMenuItem
        '
        resources.ApplyResources(Me.DepósitosCentralizaçãoDeEncargosToolStripMenuItem, "DepósitosCentralizaçãoDeEncargosToolStripMenuItem")
        Me.DepósitosCentralizaçãoDeEncargosToolStripMenuItem.Name = "DepósitosCentralizaçãoDeEncargosToolStripMenuItem"
        '
        'IRAlugéisToolStripMenuItem
        '
        Me.IRAlugéisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IRAluguelToolStripMenuItem, Me.IRMultaRescisóriaToolStripMenuItem})
        resources.ApplyResources(Me.IRAlugéisToolStripMenuItem, "IRAlugéisToolStripMenuItem")
        Me.IRAlugéisToolStripMenuItem.Name = "IRAlugéisToolStripMenuItem"
        '
        'IRAluguelToolStripMenuItem
        '
        resources.ApplyResources(Me.IRAluguelToolStripMenuItem, "IRAluguelToolStripMenuItem")
        Me.IRAluguelToolStripMenuItem.Name = "IRAluguelToolStripMenuItem"
        '
        'IRMultaRescisóriaToolStripMenuItem
        '
        resources.ApplyResources(Me.IRMultaRescisóriaToolStripMenuItem, "IRMultaRescisóriaToolStripMenuItem")
        Me.IRMultaRescisóriaToolStripMenuItem.Name = "IRMultaRescisóriaToolStripMenuItem"
        '
        'CadastroPagamentoRealizadoCampoToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroPagamentoRealizadoCampoToolStripMenuItem, "CadastroPagamentoRealizadoCampoToolStripMenuItem")
        Me.CadastroPagamentoRealizadoCampoToolStripMenuItem.Name = "CadastroPagamentoRealizadoCampoToolStripMenuItem"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'CadastroClienteIRAluguelToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroClienteIRAluguelToolStripMenuItem, "CadastroClienteIRAluguelToolStripMenuItem")
        Me.CadastroClienteIRAluguelToolStripMenuItem.Name = "CadastroClienteIRAluguelToolStripMenuItem"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        resources.ApplyResources(Me.ToolStripSeparator25, "ToolStripSeparator25")
        '
        'CadastroDeduçãoINSSToolStripMenuItem
        '
        Me.CadastroDeduçãoINSSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeduçãoINSSMensalToolStripMenuItem, Me.CadastroDeduçãoINSS13ºToolStripMenuItem})
        resources.ApplyResources(Me.CadastroDeduçãoINSSToolStripMenuItem, "CadastroDeduçãoINSSToolStripMenuItem")
        Me.CadastroDeduçãoINSSToolStripMenuItem.Name = "CadastroDeduçãoINSSToolStripMenuItem"
        '
        'CadastroDeduçãoINSSMensalToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroDeduçãoINSSMensalToolStripMenuItem, "CadastroDeduçãoINSSMensalToolStripMenuItem")
        Me.CadastroDeduçãoINSSMensalToolStripMenuItem.Name = "CadastroDeduçãoINSSMensalToolStripMenuItem"
        '
        'CadastroDeduçãoINSS13ºToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroDeduçãoINSS13ºToolStripMenuItem, "CadastroDeduçãoINSS13ºToolStripMenuItem")
        Me.CadastroDeduçãoINSS13ºToolStripMenuItem.Name = "CadastroDeduçãoINSS13ºToolStripMenuItem"
        '
        'CadastroObservaçõesToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroObservaçõesToolStripMenuItem, "CadastroObservaçõesToolStripMenuItem")
        Me.CadastroObservaçõesToolStripMenuItem.Name = "CadastroObservaçõesToolStripMenuItem"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'CadastroFunçõesToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroFunçõesToolStripMenuItem, "CadastroFunçõesToolStripMenuItem")
        Me.CadastroFunçõesToolStripMenuItem.Name = "CadastroFunçõesToolStripMenuItem"
        '
        'CadastroEntidadesToolStripMenuItem
        '
        resources.ApplyResources(Me.CadastroEntidadesToolStripMenuItem, "CadastroEntidadesToolStripMenuItem")
        Me.CadastroEntidadesToolStripMenuItem.Name = "CadastroEntidadesToolStripMenuItem"
        '
        'UsuáriosToolStripMenuItem
        '
        resources.ApplyResources(Me.UsuáriosToolStripMenuItem, "UsuáriosToolStripMenuItem")
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        '
        'CentralizaçãoToolStripMenuItem
        '
        Me.CentralizaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioIRToolStripMenuItem})
        Me.CentralizaçãoToolStripMenuItem.Name = "CentralizaçãoToolStripMenuItem"
        resources.ApplyResources(Me.CentralizaçãoToolStripMenuItem, "CentralizaçãoToolStripMenuItem")
        '
        'RelatórioIRToolStripMenuItem
        '
        Me.RelatórioIRToolStripMenuItem.Name = "RelatórioIRToolStripMenuItem"
        resources.ApplyResources(Me.RelatórioIRToolStripMenuItem, "RelatórioIRToolStripMenuItem")
        '
        'ConfiguraçãoToolStripMenuItem
        '
        Me.ConfiguraçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirPeriodoToolStripMenuItem, Me.FechaPeríodoToolStripMenuItem, Me.ToolStripSeparator4, Me.AbrirAnoToolStripMenuItem, Me.FechaAnoToolStripMenuItem, Me.ToolStripSeparator3, Me.DatasDepósitosToolStripMenuItem})
        Me.ConfiguraçãoToolStripMenuItem.Name = "ConfiguraçãoToolStripMenuItem"
        resources.ApplyResources(Me.ConfiguraçãoToolStripMenuItem, "ConfiguraçãoToolStripMenuItem")
        '
        'AbrirPeriodoToolStripMenuItem
        '
        resources.ApplyResources(Me.AbrirPeriodoToolStripMenuItem, "AbrirPeriodoToolStripMenuItem")
        Me.AbrirPeriodoToolStripMenuItem.Name = "AbrirPeriodoToolStripMenuItem"
        '
        'FechaPeríodoToolStripMenuItem
        '
        resources.ApplyResources(Me.FechaPeríodoToolStripMenuItem, "FechaPeríodoToolStripMenuItem")
        Me.FechaPeríodoToolStripMenuItem.Name = "FechaPeríodoToolStripMenuItem"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'AbrirAnoToolStripMenuItem
        '
        resources.ApplyResources(Me.AbrirAnoToolStripMenuItem, "AbrirAnoToolStripMenuItem")
        Me.AbrirAnoToolStripMenuItem.Name = "AbrirAnoToolStripMenuItem"
        '
        'FechaAnoToolStripMenuItem
        '
        Me.FechaAnoToolStripMenuItem.Name = "FechaAnoToolStripMenuItem"
        resources.ApplyResources(Me.FechaAnoToolStripMenuItem, "FechaAnoToolStripMenuItem")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'DatasDepósitosToolStripMenuItem
        '
        Me.DatasDepósitosToolStripMenuItem.Name = "DatasDepósitosToolStripMenuItem"
        resources.ApplyResources(Me.DatasDepósitosToolStripMenuItem, "DatasDepósitosToolStripMenuItem")
        '
        'ContabilizarToolStripMenuItem
        '
        Me.ContabilizarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContabilizaçãoToolStripMenuItem, Me.ToolStripSeparator7, Me.ContabilizarCOFINSToolStripMenuItem, Me.ContabilizarDeduçãoINSSToolStripMenuItem, Me.ContabilizarIRAlugueisToolStripMenuItem})
        Me.ContabilizarToolStripMenuItem.Name = "ContabilizarToolStripMenuItem"
        resources.ApplyResources(Me.ContabilizarToolStripMenuItem, "ContabilizarToolStripMenuItem")
        '
        'ContabilizaçãoToolStripMenuItem
        '
        Me.ContabilizaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarSaldoMensalToolStripMenuItem, Me.BuscarSaldo13ºToolStripMenuItem})
        resources.ApplyResources(Me.ContabilizaçãoToolStripMenuItem, "ContabilizaçãoToolStripMenuItem")
        Me.ContabilizaçãoToolStripMenuItem.Name = "ContabilizaçãoToolStripMenuItem"
        '
        'BuscarSaldoMensalToolStripMenuItem
        '
        resources.ApplyResources(Me.BuscarSaldoMensalToolStripMenuItem, "BuscarSaldoMensalToolStripMenuItem")
        Me.BuscarSaldoMensalToolStripMenuItem.Name = "BuscarSaldoMensalToolStripMenuItem"
        '
        'BuscarSaldo13ºToolStripMenuItem
        '
        resources.ApplyResources(Me.BuscarSaldo13ºToolStripMenuItem, "BuscarSaldo13ºToolStripMenuItem")
        Me.BuscarSaldo13ºToolStripMenuItem.Name = "BuscarSaldo13ºToolStripMenuItem"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'ContabilizarCOFINSToolStripMenuItem
        '
        resources.ApplyResources(Me.ContabilizarCOFINSToolStripMenuItem, "ContabilizarCOFINSToolStripMenuItem")
        Me.ContabilizarCOFINSToolStripMenuItem.Name = "ContabilizarCOFINSToolStripMenuItem"
        '
        'ContabilizarDeduçãoINSSToolStripMenuItem
        '
        resources.ApplyResources(Me.ContabilizarDeduçãoINSSToolStripMenuItem, "ContabilizarDeduçãoINSSToolStripMenuItem")
        Me.ContabilizarDeduçãoINSSToolStripMenuItem.Name = "ContabilizarDeduçãoINSSToolStripMenuItem"
        '
        'ContabilizarIRAlugueisToolStripMenuItem
        '
        resources.ApplyResources(Me.ContabilizarIRAlugueisToolStripMenuItem, "ContabilizarIRAlugueisToolStripMenuItem")
        Me.ContabilizarIRAlugueisToolStripMenuItem.Name = "ContabilizarIRAlugueisToolStripMenuItem"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TributosToolStripMenuItem1, Me.ToolStripSeparator6, Me.CampoToolStripMenuItem, Me.UniãoToolStripMenuItem, Me.ToolStripSeparator11, Me.ObservaçõesRecolhimentoToolStripMenuItem1, Me.InformeAnualIRAluguéisToolStripMenuItem, Me.ToolStripSeparator19, Me.FunçõesToolStripMenuItem, Me.UsuáriosToolStripMenuItem1})
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        resources.ApplyResources(Me.RelatórioToolStripMenuItem, "RelatórioToolStripMenuItem")
        '
        'TributosToolStripMenuItem1
        '
        Me.TributosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioMensalToolStripMenuItem, Me.RelatórioINSS13ºToolStripMenuItem})
        resources.ApplyResources(Me.TributosToolStripMenuItem1, "TributosToolStripMenuItem1")
        Me.TributosToolStripMenuItem1.Name = "TributosToolStripMenuItem1"
        '
        'RelatórioMensalToolStripMenuItem
        '
        resources.ApplyResources(Me.RelatórioMensalToolStripMenuItem, "RelatórioMensalToolStripMenuItem")
        Me.RelatórioMensalToolStripMenuItem.Name = "RelatórioMensalToolStripMenuItem"
        '
        'RelatórioINSS13ºToolStripMenuItem
        '
        resources.ApplyResources(Me.RelatórioINSS13ºToolStripMenuItem, "RelatórioINSS13ºToolStripMenuItem")
        Me.RelatórioINSS13ºToolStripMenuItem.Name = "RelatórioINSS13ºToolStripMenuItem"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'CampoToolStripMenuItem
        '
        Me.CampoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.COFINSLojaToolStripMenuItem, Me.EncargosParaDepósitoToolStripMenuItem, Me.IRAluguéisToolStripMenuItem, Me.ToolStripSeparator2, Me.ClienteIRAluguelToolStripMenuItem})
        resources.ApplyResources(Me.CampoToolStripMenuItem, "CampoToolStripMenuItem")
        Me.CampoToolStripMenuItem.Name = "CampoToolStripMenuItem"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        resources.ApplyResources(Me.ToolStripSeparator8, "ToolStripSeparator8")
        '
        'COFINSLojaToolStripMenuItem
        '
        resources.ApplyResources(Me.COFINSLojaToolStripMenuItem, "COFINSLojaToolStripMenuItem")
        Me.COFINSLojaToolStripMenuItem.Name = "COFINSLojaToolStripMenuItem"
        '
        'EncargosParaDepósitoToolStripMenuItem
        '
        resources.ApplyResources(Me.EncargosParaDepósitoToolStripMenuItem, "EncargosParaDepósitoToolStripMenuItem")
        Me.EncargosParaDepósitoToolStripMenuItem.Name = "EncargosParaDepósitoToolStripMenuItem"
        '
        'IRAluguéisToolStripMenuItem
        '
        Me.IRAluguéisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IRAluguelToolStripMenuItem1, Me.IRRecisãoAluguelToolStripMenuItem})
        resources.ApplyResources(Me.IRAluguéisToolStripMenuItem, "IRAluguéisToolStripMenuItem")
        Me.IRAluguéisToolStripMenuItem.Name = "IRAluguéisToolStripMenuItem"
        '
        'IRAluguelToolStripMenuItem1
        '
        resources.ApplyResources(Me.IRAluguelToolStripMenuItem1, "IRAluguelToolStripMenuItem1")
        Me.IRAluguelToolStripMenuItem1.Name = "IRAluguelToolStripMenuItem1"
        '
        'IRRecisãoAluguelToolStripMenuItem
        '
        resources.ApplyResources(Me.IRRecisãoAluguelToolStripMenuItem, "IRRecisãoAluguelToolStripMenuItem")
        Me.IRRecisãoAluguelToolStripMenuItem.Name = "IRRecisãoAluguelToolStripMenuItem"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ClienteIRAluguelToolStripMenuItem
        '
        resources.ApplyResources(Me.ClienteIRAluguelToolStripMenuItem, "ClienteIRAluguelToolStripMenuItem")
        Me.ClienteIRAluguelToolStripMenuItem.Name = "ClienteIRAluguelToolStripMenuItem"
        '
        'UniãoToolStripMenuItem
        '
        Me.UniãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbatimentoINSSToolStripMenuItem1, Me.AbatimentoINSS13ºToolStripMenuItem, Me.ToolStripSeparator9, Me.COFINSFaturamentoLojasToolStripMenuItem, Me.IRAluguéisToolStripMenuItem1, Me.ToolStripSeparator18, Me.RelatórioTributosMêsToolStripMenuItem, Me.RelatórioTributos13ToolStripMenuItem, Me.ToolStripSeparator10, Me.DepósitosPendentesAFazerToolStripMenuItem, Me.DepósitosRealizadosToolStripMenuItem, Me.ToolStripSeparator24, Me.EntidadeComOMesAbertoToolStripMenuItem})
        resources.ApplyResources(Me.UniãoToolStripMenuItem, "UniãoToolStripMenuItem")
        Me.UniãoToolStripMenuItem.Name = "UniãoToolStripMenuItem"
        '
        'AbatimentoINSSToolStripMenuItem1
        '
        resources.ApplyResources(Me.AbatimentoINSSToolStripMenuItem1, "AbatimentoINSSToolStripMenuItem1")
        Me.AbatimentoINSSToolStripMenuItem1.Name = "AbatimentoINSSToolStripMenuItem1"
        '
        'AbatimentoINSS13ºToolStripMenuItem
        '
        resources.ApplyResources(Me.AbatimentoINSS13ºToolStripMenuItem, "AbatimentoINSS13ºToolStripMenuItem")
        Me.AbatimentoINSS13ºToolStripMenuItem.Name = "AbatimentoINSS13ºToolStripMenuItem"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        '
        'COFINSFaturamentoLojasToolStripMenuItem
        '
        resources.ApplyResources(Me.COFINSFaturamentoLojasToolStripMenuItem, "COFINSFaturamentoLojasToolStripMenuItem")
        Me.COFINSFaturamentoLojasToolStripMenuItem.Name = "COFINSFaturamentoLojasToolStripMenuItem"
        '
        'IRAluguéisToolStripMenuItem1
        '
        Me.IRAluguéisToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IRAluguelToolStripMenuItem2, Me.IRRescisãoAluguélToolStripMenuItem})
        resources.ApplyResources(Me.IRAluguéisToolStripMenuItem1, "IRAluguéisToolStripMenuItem1")
        Me.IRAluguéisToolStripMenuItem1.Name = "IRAluguéisToolStripMenuItem1"
        '
        'IRAluguelToolStripMenuItem2
        '
        resources.ApplyResources(Me.IRAluguelToolStripMenuItem2, "IRAluguelToolStripMenuItem2")
        Me.IRAluguelToolStripMenuItem2.Name = "IRAluguelToolStripMenuItem2"
        '
        'IRRescisãoAluguélToolStripMenuItem
        '
        resources.ApplyResources(Me.IRRescisãoAluguélToolStripMenuItem, "IRRescisãoAluguélToolStripMenuItem")
        Me.IRRescisãoAluguélToolStripMenuItem.Name = "IRRescisãoAluguélToolStripMenuItem"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        resources.ApplyResources(Me.ToolStripSeparator18, "ToolStripSeparator18")
        '
        'RelatórioTributosMêsToolStripMenuItem
        '
        resources.ApplyResources(Me.RelatórioTributosMêsToolStripMenuItem, "RelatórioTributosMêsToolStripMenuItem")
        Me.RelatórioTributosMêsToolStripMenuItem.Name = "RelatórioTributosMêsToolStripMenuItem"
        '
        'RelatórioTributos13ToolStripMenuItem
        '
        resources.ApplyResources(Me.RelatórioTributos13ToolStripMenuItem, "RelatórioTributos13ToolStripMenuItem")
        Me.RelatórioTributos13ToolStripMenuItem.Name = "RelatórioTributos13ToolStripMenuItem"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'DepósitosPendentesAFazerToolStripMenuItem
        '
        resources.ApplyResources(Me.DepósitosPendentesAFazerToolStripMenuItem, "DepósitosPendentesAFazerToolStripMenuItem")
        Me.DepósitosPendentesAFazerToolStripMenuItem.Name = "DepósitosPendentesAFazerToolStripMenuItem"
        '
        'DepósitosRealizadosToolStripMenuItem
        '
        resources.ApplyResources(Me.DepósitosRealizadosToolStripMenuItem, "DepósitosRealizadosToolStripMenuItem")
        Me.DepósitosRealizadosToolStripMenuItem.Name = "DepósitosRealizadosToolStripMenuItem"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        resources.ApplyResources(Me.ToolStripSeparator24, "ToolStripSeparator24")
        '
        'EntidadeComOMesAbertoToolStripMenuItem
        '
        resources.ApplyResources(Me.EntidadeComOMesAbertoToolStripMenuItem, "EntidadeComOMesAbertoToolStripMenuItem")
        Me.EntidadeComOMesAbertoToolStripMenuItem.Name = "EntidadeComOMesAbertoToolStripMenuItem"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        resources.ApplyResources(Me.ToolStripSeparator11, "ToolStripSeparator11")
        '
        'ObservaçõesRecolhimentoToolStripMenuItem1
        '
        resources.ApplyResources(Me.ObservaçõesRecolhimentoToolStripMenuItem1, "ObservaçõesRecolhimentoToolStripMenuItem1")
        Me.ObservaçõesRecolhimentoToolStripMenuItem1.Name = "ObservaçõesRecolhimentoToolStripMenuItem1"
        '
        'InformeAnualIRAluguéisToolStripMenuItem
        '
        resources.ApplyResources(Me.InformeAnualIRAluguéisToolStripMenuItem, "InformeAnualIRAluguéisToolStripMenuItem")
        Me.InformeAnualIRAluguéisToolStripMenuItem.Name = "InformeAnualIRAluguéisToolStripMenuItem"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        resources.ApplyResources(Me.ToolStripSeparator19, "ToolStripSeparator19")
        '
        'FunçõesToolStripMenuItem
        '
        resources.ApplyResources(Me.FunçõesToolStripMenuItem, "FunçõesToolStripMenuItem")
        Me.FunçõesToolStripMenuItem.Name = "FunçõesToolStripMenuItem"
        '
        'UsuáriosToolStripMenuItem1
        '
        resources.ApplyResources(Me.UsuáriosToolStripMenuItem1, "UsuáriosToolStripMenuItem1")
        Me.UsuáriosToolStripMenuItem1.Name = "UsuáriosToolStripMenuItem1"
        '
        'AjudaToolStripMenuItem1
        '
        Me.AjudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.DataParaOsDepósitosToolStripMenuItem, Me.ToolStripSeparator15, Me.ContatoToolStripMenuItem1, Me.HistóricosDasVersõesToolStripMenuItem, Me.VideoTreinamentoToolStripMenuItem, Me.ToolStripSeparator16, Me.TrocaSenhaToolStripMenuItem})
        Me.AjudaToolStripMenuItem1.Name = "AjudaToolStripMenuItem1"
        resources.ApplyResources(Me.AjudaToolStripMenuItem1, "AjudaToolStripMenuItem1")
        '
        'CalculadoraToolStripMenuItem
        '
        resources.ApplyResources(Me.CalculadoraToolStripMenuItem, "CalculadoraToolStripMenuItem")
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        '
        'DataParaOsDepósitosToolStripMenuItem
        '
        resources.ApplyResources(Me.DataParaOsDepósitosToolStripMenuItem, "DataParaOsDepósitosToolStripMenuItem")
        Me.DataParaOsDepósitosToolStripMenuItem.Name = "DataParaOsDepósitosToolStripMenuItem"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        resources.ApplyResources(Me.ToolStripSeparator15, "ToolStripSeparator15")
        '
        'ContatoToolStripMenuItem1
        '
        resources.ApplyResources(Me.ContatoToolStripMenuItem1, "ContatoToolStripMenuItem1")
        Me.ContatoToolStripMenuItem1.Name = "ContatoToolStripMenuItem1"
        '
        'HistóricosDasVersõesToolStripMenuItem
        '
        resources.ApplyResources(Me.HistóricosDasVersõesToolStripMenuItem, "HistóricosDasVersõesToolStripMenuItem")
        Me.HistóricosDasVersõesToolStripMenuItem.Name = "HistóricosDasVersõesToolStripMenuItem"
        '
        'VideoTreinamentoToolStripMenuItem
        '
        resources.ApplyResources(Me.VideoTreinamentoToolStripMenuItem, "VideoTreinamentoToolStripMenuItem")
        Me.VideoTreinamentoToolStripMenuItem.Name = "VideoTreinamentoToolStripMenuItem"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        resources.ApplyResources(Me.ToolStripSeparator16, "ToolStripSeparator16")
        '
        'TrocaSenhaToolStripMenuItem
        '
        resources.ApplyResources(Me.TrocaSenhaToolStripMenuItem, "TrocaSenhaToolStripMenuItem")
        Me.TrocaSenhaToolStripMenuItem.Name = "TrocaSenhaToolStripMenuItem"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        resources.ApplyResources(Me.SairToolStripMenuItem, "SairToolStripMenuItem")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cad_Depositos, Me.Cad_COFINS, Me.Cad_IR_Aluguel, Me.ToolStripSeparator13, Me.Tributo_Mensal, Me.ToolStripSeparator12, Me.IR_Aluguel, Me.ToolStripSeparator14, Me.Data_Para_Depositos, Me.ToolStripSeparator17, Me.Calculadora, Me.Troca_Senha})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'Cad_Depositos
        '
        Me.Cad_Depositos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Cad_Depositos, "Cad_Depositos")
        Me.Cad_Depositos.Name = "Cad_Depositos"
        '
        'Cad_COFINS
        '
        Me.Cad_COFINS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Cad_COFINS, "Cad_COFINS")
        Me.Cad_COFINS.Name = "Cad_COFINS"
        '
        'Cad_IR_Aluguel
        '
        Me.Cad_IR_Aluguel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Cad_IR_Aluguel, "Cad_IR_Aluguel")
        Me.Cad_IR_Aluguel.Name = "Cad_IR_Aluguel"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        resources.ApplyResources(Me.ToolStripSeparator13, "ToolStripSeparator13")
        '
        'Tributo_Mensal
        '
        Me.Tributo_Mensal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Tributo_Mensal, "Tributo_Mensal")
        Me.Tributo_Mensal.Name = "Tributo_Mensal"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        resources.ApplyResources(Me.ToolStripSeparator12, "ToolStripSeparator12")
        '
        'IR_Aluguel
        '
        Me.IR_Aluguel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.IR_Aluguel, "IR_Aluguel")
        Me.IR_Aluguel.Name = "IR_Aluguel"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        resources.ApplyResources(Me.ToolStripSeparator14, "ToolStripSeparator14")
        '
        'Data_Para_Depositos
        '
        Me.Data_Para_Depositos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Data_Para_Depositos, "Data_Para_Depositos")
        Me.Data_Para_Depositos.Name = "Data_Para_Depositos"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        resources.ApplyResources(Me.ToolStripSeparator17, "ToolStripSeparator17")
        '
        'Calculadora
        '
        Me.Calculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Calculadora, "Calculadora")
        Me.Calculadora.Name = "Calculadora"
        '
        'Troca_Senha
        '
        Me.Troca_Senha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Troca_Senha, "Troca_Senha")
        Me.Troca_Senha.Name = "Troca_Senha"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Deducao_IINSS, Me.ToolStripSeparator23, Me.Relatorio_Tributos, Me.Relatorio_Cofins, Me.Relatorio_IR_Aluguel, Me.ToolStripSeparator20, Me.ToolStripButton5, Me.ToolStripSeparator21, Me.ToolStripButton7, Me.ToolStripSeparator22})
        resources.ApplyResources(Me.ToolStrip2, "ToolStrip2")
        Me.ToolStrip2.Name = "ToolStrip2"
        '
        'Deducao_IINSS
        '
        Me.Deducao_IINSS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Deducao_IINSS, "Deducao_IINSS")
        Me.Deducao_IINSS.Name = "Deducao_IINSS"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        resources.ApplyResources(Me.ToolStripSeparator23, "ToolStripSeparator23")
        '
        'Relatorio_Tributos
        '
        Me.Relatorio_Tributos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Relatorio_Tributos, "Relatorio_Tributos")
        Me.Relatorio_Tributos.Name = "Relatorio_Tributos"
        '
        'Relatorio_Cofins
        '
        Me.Relatorio_Cofins.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Relatorio_Cofins, "Relatorio_Cofins")
        Me.Relatorio_Cofins.Name = "Relatorio_Cofins"
        '
        'Relatorio_IR_Aluguel
        '
        Me.Relatorio_IR_Aluguel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.Relatorio_IR_Aluguel, "Relatorio_IR_Aluguel")
        Me.Relatorio_IR_Aluguel.Name = "Relatorio_IR_Aluguel"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        resources.ApplyResources(Me.ToolStripSeparator20, "ToolStripSeparator20")
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton5, "ToolStripButton5")
        Me.ToolStripButton5.Name = "ToolStripButton5"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        resources.ApplyResources(Me.ToolStripSeparator21, "ToolStripSeparator21")
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton7, "ToolStripButton7")
        Me.ToolStripButton7.Name = "ToolStripButton7"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        resources.ApplyResources(Me.ToolStripSeparator22, "ToolStripSeparator22")
        '
        'Fm_Principal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusBar1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "Fm_Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NomeSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Entidade_Logada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents NomeSistema As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Data As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Hora As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Entidade_Logada As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COFINSSFaturamentoLojasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepósitosCentralizaçãoDeEncargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRAlugéisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UniãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COFINSFaturamentoLojasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepósitosRealizadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRAluguéisToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CampoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COFINSLojaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncargosParaDepósitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRAluguéisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContatoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoTreinamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepósitosPendentesAFazerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeduçãoINSSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbatimentoINSSToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContabilizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContabilizarCOFINSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContabilizarIRAlugueisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistóricosDasVersõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContabilizarDeduçãoINSSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroObservaçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContabilizaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirAnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaPeríodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TributosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocaSenhaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ObservaçõesRecolhimentoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InformeAnualIRAluguéisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuscarSaldoMensalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSaldo13ºToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeduçãoINSSMensalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeduçãoINSS13ºToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbatimentoINSS13ºToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RelatórioMensalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioINSS13ºToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tributo_Mensal As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cad_Depositos As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cad_COFINS As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cad_IR_Aluguel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataParaOsDepósitosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Troca_Senha As System.Windows.Forms.ToolStripButton
    Friend WithEvents Calculadora As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Data_Para_Depositos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RelatórioTributosMêsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioTributos13ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroEntidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaAnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents Relatorio_Tributos As System.Windows.Forms.ToolStripButton
    Friend WithEvents Relatorio_Cofins As System.Windows.Forms.ToolStripButton
    Friend WithEvents Relatorio_IR_Aluguel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CadastroFunçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FunçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Deducao_IINSS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IR_Aluguel As System.Windows.Forms.ToolStripButton
    Friend WithEvents CentralizaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroPagamentoRealizadoCampoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DatasDepósitosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ToolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EntidadeComOMesAbertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRAluguelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRMultaRescisóriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRAluguelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRRecisãoAluguelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRAluguelToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRRescisãoAluguélToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroClienteIRAluguelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As ToolStripSeparator
    Friend WithEvents ClienteIRAluguelToolStripMenuItem As ToolStripMenuItem
End Class
