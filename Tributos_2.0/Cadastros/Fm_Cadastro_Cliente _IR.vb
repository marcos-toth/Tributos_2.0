Imports System.Data.SqlClient
Public Class Fm_Cadastro_Cliente__IR

    Private Sub Fm_Cadastro_Cliente__IR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Me.MdiParent = Fm_Principal
        lbInform.Text = ""
    End Sub
    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        InsereEnter(Me)
    End Sub
    Private Sub txt_CPF_Leave(sender As Object, e As EventArgs) Handles Txt_CPF.Leave ' Seleciona o cliente cadastrado
        Try
            resultado = 0
            resultado2 = 0
            lbInform.Text = ""

            vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
            vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
            sql = "select * from Cliente_IR where CPF_CNPJ="
            sql += "'" & Txt_CPF.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Cliente_IR")
            resultado2 = local.Tables("Cliente_IR").Rows.Count
            If resultado2 > 0 Then
                registro = local.Tables("Cliente_IR").Rows(0)
                Txt_Nome.Text = registro("Nome")
                Txt_Email.Text = registro("Email")
                Txt_Telefone.Text = registro("Telefone")
                Id = registro("Id")
                btnSalvar.Enabled = False
                btnEditar.Enabled = True
                btnSalvar.Text = "Editar"
            ElseIf resultado2 = 0 Then
                Txt_Nome.Enabled = Enabled
                Txt_Email.Enabled = Enabled
                Txt_Telefone.Enabled = Enabled
                Txt_Nome.Focus()
                btnSalvar.Enabled = True
                btnEditar.Enabled = False
                btnSalvar.Text = "Inserir"
                Exit Sub
            End If
            'Txt_Nome.Enabled = False
          
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If resultado2 > 0 Then

                If MsgBox("Deseja Realmente Alterar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                    sql = "update Cliente_IR set Email='" & Txt_Email.Text & "' ,"
                    sql += "Nome='" & Txt_Nome.Text & "' ,"
                    sql += "Telefone='" & Txt_Telefone.Text & "' "
                    sql += " where Id='" & Id & "' "
                    Conectar_Banco()
                End If

            ElseIf resultado2 = 0 Then

                sql = "insert into Cliente_IR (Nome, CPF_CNPJ, Email)"
                sql += "values ('" & Txt_Nome.Text & "',"
                sql += "'" & Txt_CPF.Text & "',"
                sql += "'" & Txt_Email.Text & "',"
                sql += "Telefone='" & Txt_Telefone.Text & "' ) "
                Conectar_Banco()

            End If

            lbInform.Text = "Dados Gravado com Sucesso!!!"

        Catch ex As Exception
            MsgBox("Seus Dados Não Foram Gravados")
            conectar.Close()
            Exit Sub
        End Try
        limpar()

        Exit Sub
        lbInform.Text = "Favor Inserir Um Valor Base!!"

    End Sub
    Private Sub txt_Nome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Nome.TextChanged, Txt_Nome.TextChanged
        Dim selStart As Integer
        Dim selLength As Integer
        selStart = Me.Txt_Nome.SelectionStart
        selLength = Me.Txt_Nome.SelectionLength
        Me.Txt_Nome.Text = StrConv(Me.Txt_Nome.Text, VbStrConv.ProperCase)
        Me.Txt_Nome.SelectionStart = selStart
        Me.Txt_Nome.SelectionLength = selLength
    End Sub

    Private Sub Txt_Nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nome.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_Email.Focus()
        End If
    End Sub
    Private Sub Txt_Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Email.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_Telefone.Focus()
        End If
    End Sub
    Private Sub Txt_telefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Telefone.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Focus()
        End If
    End Sub
    Private Sub Conectar_Banco()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conectar.Close()
            Exit Sub
        End Try
    End Sub
    Private Sub limpar()
        resultado = 0
        resultado2 = 0
        Txt_CPF.Clear()
        Txt_Nome.Clear()
        Txt_Email.Clear()
        Txt_Telefone.Clear()

        Txt_CPF.Enabled = True
        Txt_Email.Enabled = False
        Txt_Nome.Enabled = False
        Txt_Telefone.Enabled = False

        Txt_CPF.Focus()

        btnSalvar.Enabled = False
        btnEditar.Enabled = False
        btnSalvar.Text = "Inserir"
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limpar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Txt_CPF.Enabled = False
        Txt_Email.Enabled = True
        Txt_Nome.Enabled = True
        Txt_Email.Enabled = True
        Txt_Telefone.Enabled = True
        btnSalvar.Text = "Editar"
        btnSalvar.Enabled = True
    End Sub
End Class