﻿Imports System.Data.SqlClient
Imports System
Module Conexao
    Public conectar As New SqlConnection
    Public comando As New SqlCommand
    Public command As New SqlCommand
    Public local As DataSet
    Public dt As DataSet
    Public adaptar As SqlDataAdapter
    Public dr As SqlDataReader
    Public registro As DataRow
    Public registro2 As DataRow
    Public sql As String

    Public cnn As String = "server=" & ShowLine("q8rwHakHlXn93cxQzOY5p9p4tz60gEkP6NKJUGtWWCo=", Crypt("ùó´²åâóí¹ë")) & ";user id=" & ShowLine("FtC8GvbO3MRG2K/ywdQ9zA==", Crypt("ùó´²åâóí¹ë")) & ";password=" & ShowLine("ieGNujmFoo4qwHC0Fj7mzg==", Crypt("ùó´²åâóí¹ë")) & ";database=" & ShowLine("UZ3AruXVeD3hVMb6sg82b5ROlWqNdSFwq/VHgIWbh0s=", Crypt("ùó´²åâóí¹ë"))
    'Public cnn As String = "server=" & ShowLine("qrfpvpTXg2GLLCqPky1Pw6+WvKccoSbiiRIsc2B20Ds=", Crypt("ëô³±·ò±")) & ";user id=" & ShowLine("nfuSTJVo/+YRCZnaCBpeLrxwVsS7lyLmeT3H5z7fS74=", Crypt("ëô³±·ò±")) & ";password=" & ShowLine("rC2PRRijXZe+3+eURoZk/hZrHfoaP6ra63XhUYvakUw=", Crypt("ëô³±·ò±")) & ";database=" & ShowLine("CQW6iWv6WrEy/gfvkEgGO2sRrl9sIIsCYGeUnxnmw+w=", Crypt("ëô³±·ò±"))


    Public resultado As Integer
    Public resultado2 As Integer
    Public Condicao As String
    Public Query As String
    Public use As String
    Public Canc As String
    Public vlAno As String
    Public VPeriodo As String
    Public VPeriodo2 As String
    Public vlMes As String
    Public vlMesComp As String
    Public vlPeriodoComp As String
    Public dataAtual As String
    Public Entidades As String
    Public EntidadeIR As String
    Public EntMae As String
    Public TipoRel As String
    Public Categoria As String
    Public TipoTributos As String
    Public Contabilidade As String
    Public Usuario As String
    Public NomeUsuario As String
    Public Nome_Entidade As String
    Public Nome_Cadastrado As String
    Public Nome_Usuario As Object
    Public Cod_Entidade As String
    Public CPF_CNPJ As String
    Public CNPJ As String
    Public EntidadeLogada As String
    Public EntidadeMae As String
    Public Senha As String
    Public TrocaSenha As String
    Public vSenha As String
    Public DataCadastro As String
    Public DataDeposito As String
    Public Consolidado As String
    Public vValor As String
    Public vlBase As String
    Public vlReducao As String
    Public vValor_Banco As String
    Public vCorr As String
    Public Total As String
    Public AvisoMes As String
    Public Ativo As String
    Public Datas As String
    Public Informe As String
    Public versao As String
    Public Connection As String
    Private server As String
    Public Contabilizado As String
    Public Recolhido As String
    Public vnivel As String
    Public VlData As String
    Public Cabecalho As String



    Public contador As Integer
    Public conta_Mes_Aberto As Integer
    Public vlCalendario As Integer
    Public vlDia As Integer
    Public R_Ano As Integer
    Public Tipo As Integer
    Public Id As Integer
    Public Quantidade As Integer
    Public ErroAcessoSite As Integer


    Public FGTS As Double
    Public FGTS_Mes_13 As Double
    Public FGTS_Mes As Double
    Public FGTS_Mes_SEFIP As Double
    Public FGTS_13 As Double
    Public FGTS_13_SEFIP As Double
    Public FGTS_Pago_Campo As Double
    Public INSS_Pago_Campo As Double
    Public INSS As Double
    Public INSS_Deducao As Double
    Public INSS_Aredondamento As Double
    Public INSS_RPA As Double
    Public Base As Double
    Public Base_IR_Aluguel As Double
    Public Reducao_Base_IR_Aluguel As Double



End Module