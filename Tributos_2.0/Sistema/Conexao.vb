Imports System.Data.SqlClient
Imports System
Module Conexao
    Public conectar As New SqlConnection
    Public comando As New SqlCommand
    Public local As DataSet
    Public adaptar As SqlDataAdapter
    Public command As New SqlCommand
    Public sql As String
    Public resultado As Integer
    Public resultado2 As Integer
    Public registro As DataRow
    Public registro2 As DataRow
    Public dt As DataSet
    Public cnn As String = "server=" & ShowLine("qrfpvpTXg2GLLCqPky1Pw6+WvKccoSbiiRIsc2B20Ds=", Crypt("ëô³±·ò±")) & ";user id=" & ShowLine("nfuSTJVo/+YRCZnaCBpeLrxwVsS7lyLmeT3H5z7fS74=", Crypt("ëô³±·ò±")) & ";password=" & ShowLine("rC2PRRijXZe+3+eURoZk/hZrHfoaP6ra63XhUYvakUw=", Crypt("ëô³±·ò±")) & ";database=" & ShowLine("CQW6iWv6WrEy/gfvkEgGO2sRrl9sIIsCYGeUnxnmw+w=", Crypt("ëô³±·ò±"))
    Public Connection As String
    Private server As String
    Public Contabilizado As String
    Public Recolhido As String
    Public vnivel As String
    Public contador As Integer
    Public Condicao As String
    Public use As String
    Public Canc As String
    Public vValor As String
    Public vValor_Banco As String
    Public vCorr As String
    Public Total As String
    Public vlAno As Integer
    Public vlCalendario As Integer
    Public VPeriodo As String
    Public VPeriodo2 As String
    Public vlMes As Integer
    Public vlDia As Integer
    Public R_Ano As Integer
    Public Entidades As String
    Public Tipo As Integer
    Public EntMae As String
    Public TipoRel As String
    Public Usuario As String
    Public NomeUsuario As String
    Public CPF_CNPJ As String
    Public Id As Integer
    Public EntidadeLogada As String
    Public Senha As String
    Public TrocaSenha As String
    Public vSenha As String
    Public DataCadastro As String
    Public versao As String
    Public Consolidado As String

End Module
