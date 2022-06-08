'**************************************************************
'Projeto retirado do site
'https://kallbuloso.com.br/amaralkarl/classe-de-validacao-textbox/
'Todos os méritos são dos donos originais do projeto do site kallbuloso
'Eu Cláudio Barto - apenas fiz alguns ajustes para meu uso e aplicacao em 
'projetos realizados aqui na empresa
'disponivel no github
'***********************************************************************
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Drawing

Public Class TextBoxValidate
    Inherits TextBox 'Herdamos a clase TextBox

    ' Vamos colocar um código para alterar a cor de fundo do componente
#Region "Alteração de Cores"
    Private _gotFocusColor As Color = System.Drawing.Color.LightYellow 'Quando o objeto ganha o foco
    <Category("Validação do Texto")>
    <Description("Determina a cor do objeto recebe o foco.")>
    Public Property GotFocusColor() As Color 'Altera a cor do Textbox quando o controle estiver ativo
        Get
            Return _gotFocusColor
        End Get
        Set(ByVal Value As Color)
            If Not Value.Equals(_gotFocusColor) Then
                _gotFocusColor = Value
                If Focused Then MyBase.BackColor = _gotFocusColor
            End If
        End Set
    End Property

    Private _lostFocusColor As Color = Color.White ' Quando o objeto perde o foco
    <Category("Validação do Texto")>
    <Description("Determina a cor do objeto perde o foco.")>
    Public Property LostFocusColor() As Color 'Retorna a cor do Textbox quando o controle não estiver ativo
        Get
            Return _lostFocusColor
        End Get
        Set(ByVal Value As Color)
            If Not Value.Equals(_lostFocusColor) Then
                _lostFocusColor = Value
                If Not Focused Then MyBase.BackColor = _lostFocusColor
            End If
        End Set
    End Property

    Protected Overrides Sub OnGotFocus(e As System.EventArgs)
        MyBase.OnGotFocus(e)
        MyBase.BackColor = _gotFocusColor
    End Sub

    Protected Overrides Sub OnLostFocus(e As System.EventArgs)
        MyBase.OnLostFocus(e)
        MyBase.BackColor = _lostFocusColor
    End Sub

    Public Shadows ReadOnly Property Backcolor() As Color
        Get
            Return MyBase.BackColor()
        End Get
    End Property
#End Region

#Region "Texto Vazio"
    'Agregando Categorias
    Dim _textoVazio As String 'Novas propiedades
    <Category("Validação do Texto")>
    <Description("Digite o texto a ser descrito")>
    Public Property TextoVazioDescricao As String 'Irá conter o texto a ser exibido quando o textbox está vazio
        Get
            Return _textoVazio
        End Get
        Set(value As String)
            _textoVazio = value
        End Set
    End Property

    Private _colorTextoVazio As Color 'Cor do texto Vazio
    <Category("Validação do Texto")>
    <Description("Selecione a cor do texto descritivo")>
    Public Property TextoVazioColor As Color 'Irá conter a cor texto a ser exibido quando o textbox está vazio
        Get
            Return _colorTextoVazio
        End Get
        Set(value As Color)
            _colorTextoVazio = value
        End Set
    End Property

    Private bndTextoVazio As Boolean = False 'indica se o TextoVacio está ativo
    'Criamos um método que vai verificar se o textbox está vazio
    Private Sub VerificaTextoVazio()
        If (Me.Text.Length > 0) Then
            bndTextoVazio = False 'Caso haja um texto, a descrição é desativada
        Else
            bndTextoVazio = True ' Caso não haja um texto, a descrição é desativada
        End If

        Me.SetStyle(ControlStyles.UserPaint, bndTextoVazio) 'Isto nos permitirá mostrar um evento de uma segunda caixa de texto 
        Me.Refresh() 'Atualiza o textbox
    End Sub

    'Reescrevemos os metodos do textbox
    Protected Overrides Sub OnCreateControl() 'Quando é criado o controle no Form
        MyBase.OnCreateControl()
        VerificaTextoVazio() 'Verificamos se deve ativar o TextoVazio
    End Sub

    Protected Overrides Sub OnTextChanged(e As System.EventArgs)
        MyBase.OnTextChanged(e)
        VerificaTextoVazio()
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        'Aqui mostramos no textBox o conteúdo do TextoVazio, ou o conteúdo do TextBox.text
        If (bndTextoVazio) Then 'se o textoVacio esta ativo
            e.Graphics.DrawString(TextoVazioDescricao, New Font(Me.Font, FontStyle.Italic), New SolidBrush(TextoVazioColor), New Point(0, 0))
        Else
            e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), New Point(0, 0))
        End If
        MyBase.OnPaint(e)
    End Sub

#End Region

#Region "Validação de Documentos"
    'Criamos uma nova Classe "Tipo"
    Public Class Tipo
        Inherits StringConverter 'Herdamos o StringConverter
        Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
            Return True
        End Function

        Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
            Return New StandardValuesCollection(New String() {"Default", "CPF", "CNPJ", "PIS", "Data",
                                                              "E-Mail", "Telefone", "Celular", "CEP", "Moeda", "Numeros", "Letras"}) 'Aqui definimos as validações diversas (Deixei o CNH fora)
        End Function
    End Class

    Private m_TipoValidacao As String
    <TypeConverter(GetType(Tipo)), Category("Validação do Texto kallbuloso")>
    <Description("Determina se há validação.")>
    Public Property TipoValidacao() As String
        Get
            Return m_TipoValidacao
        End Get
        Set(value As String)
            m_TipoValidacao = value
        End Set
    End Property

    'Vamos remover a máscara ou caracteres especiais quando o componente recebe o foco exeto quando moeda
    Private Sub RemoveCaracteres(Caracter As Object)
        If Me.m_TipoValidacao = "CPF" Or
            Me.m_TipoValidacao = "CNPJ" Or
            Me.m_TipoValidacao = "PIS" Or
            Me.m_TipoValidacao = "Data" Or
            Me.m_TipoValidacao = "Telefone" Or
            Me.m_TipoValidacao = "Celular" Or
            Me.m_TipoValidacao = "CEP" Then
            Caracter.text = Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Caracter.text,
                        "/", ""), ".", ""), "-", ""), "(", ""), ")", ""), " ", ""), "R", ""), "$", "")
        End If

    End Sub

    Private Function RemoveCaracteresString(Caracter As String) As String
        If Me.m_TipoValidacao = "CPF" Or
            Me.m_TipoValidacao = "CNPJ" Or
            Me.m_TipoValidacao = "PIS" Or
            Me.m_TipoValidacao = "Data" Or
            Me.m_TipoValidacao = "Telefone" Or
            Me.m_TipoValidacao = "Celular" Or
            Me.m_TipoValidacao = "CEP" Then
            Caracter = Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Caracter,
                        "/", ""), ".", ""), "-", ""), "(", ""), ")", ""), " ", ""), "R", ""), "$", "")
        End If
        Return Caracter
    End Function

    'Aqui temos a validação do que foi digitado quando o objeto perde o foco
    Protected Overrides Sub OnValidating(e As System.ComponentModel.CancelEventArgs)
        MyBase.OnValidating(e)
        If Me.Text.Length > 0 Then
            Select Case Me.m_TipoValidacao
                Case Is = "CPF"
                    If ValidarCpf(Me.Text) = True Then
                        Dim Num As Double
                        Dim StrCpf As String = RemoveCaracteresString(Me.Text)
                        Num = StrCpf
                        Me.Text = Format(Num, "###\.###\.###\-##")
                        Exit Sub
                    Else
                        MsgBox("CPF Inválido!!!", MsgBoxStyle.Critical, "Erro de Digitação")
                        Me.Focus()
                    End If
                Case Is = "CNPJ"
                    If ValidarCnpj(Me.Text) = True Then
                        Dim Num As Double
                        Dim StrCnpj As String = RemoveCaracteresString(Me.Text)
                        'Num = Me.Text
                        Num = StrCnpj
                        Me.Text = Format(Num, "##\.###\.###\/####\-##")
                        Exit Sub
                    Else
                        MsgBox("CNPJ Inválido!!!", MsgBoxStyle.Critical, "Erro de Digitação")
                        Me.Focus()
                    End If
                    Exit Sub
                Case Is = "PIS"
                    If ValidarPis(Me.Text) = True Then
                        Dim Num As Double
                        Dim StrPis As String = RemoveCaracteresString(Me.Text)
                        'Num = Me.Text
                        Num = StrPis

                        Me.Text = Format(Num, "###\.####\.###\-#")
                        Exit Sub
                    Else
                        MsgBox("PIS Inválido!!!", MsgBoxStyle.Critical, "Erro de Digitação")
                        Me.Focus()
                    End If
                    Exit Sub
                Case Is = "Data"
                    If IsData(Me.Text) = True Then
                        Dim Num As Double
                        'Num = Me.Text
                        Num = RemoveCaracteresString(Me.Text)
                        Me.Text = Format(Num, "##\/##\/####")
                        Exit Sub
                    Else
                        MsgBox("Data Inválida!!!", MsgBoxStyle.Critical, "Erro de Digitação")
                        Me.Focus()
                    End If
                    Exit Sub
                Case Is = "E-Mail"
                    If IsEmail(Me.Text) = False Then
                        MsgBox("E-mail Inválido!!!", MsgBoxStyle.Critical, "Erro de Digitação")
                        Me.Focus()
                    End If
                    Exit Sub
                Case Is = "Telefone"
                    ValidaTelefone(Me)
                    Exit Sub
                Case Is = "Celular"
                    ValidaCelular(Me)
                    Exit Sub
                Case Is = "CEP"
                    If ValidaCep(Me) = True Then
                        Dim Num As Double
                        Num = RemoveCaracteresString(Me.Text)
                        Me.Text = Format(Num, "00000\-000")
                    End If
                    Exit Sub
                    'Case Is = "CNH"
                    '    If ValidaCNH(Me.Text) = False Then
                    '        MsgBox("CNH Inválida!!!", MsgBoxStyle.Critical, "Erro de Digitação")
                    '        Me.Focus()
                    '    End If
                    '    Exit Sub
            End Select
        End If
    End Sub

    'Validação de CNPJ
    Private Shared Function ValidarCnpj(cnpj As String) As Boolean
        Dim multiplicador1 As Integer() = New Integer(11) {5, 4, 3, 2, 9, 8,
            7, 6, 5, 4, 3, 2}
        Dim multiplicador2 As Integer() = New Integer(12) {6, 5, 4, 3, 2, 9,
            8, 7, 6, 5, 4, 3,
            2}
        Dim soma As Integer
        Dim resto As Integer
        Dim digito As String
        Dim tempCnpj As String
        cnpj = cnpj.Trim()
        cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "")
        If cnpj.Length <> 14 Then
            Return False
        End If
        tempCnpj = cnpj.Substring(0, 12)
        soma = 0
        For i As Integer = 0 To 11
            soma += Integer.Parse(tempCnpj(i).ToString()) * multiplicador1(i)
        Next
        resto = (soma Mod 11)
        If resto < 2 Then
            resto = 0
        Else
            resto = 11 - resto
        End If
        digito = resto.ToString()
        tempCnpj = tempCnpj & digito
        soma = 0
        For i As Integer = 0 To 12
            soma += Integer.Parse(tempCnpj(i).ToString()) * multiplicador2(i)
        Next
        resto = (soma Mod 11)
        If resto < 2 Then
            resto = 0
        Else
            resto = 11 - resto
        End If
        digito = digito & resto.ToString()
        Return cnpj.EndsWith(digito)
    End Function

    'Valudação de CPF
    Private Shared Function ValidarCpf(cpf As String) As Boolean
        Dim multiplicador1 As Integer() = New Integer(8) {10, 9, 8, 7, 6, 5,
            4, 3, 2}
        Dim multiplicador2 As Integer() = New Integer(9) {11, 10, 9, 8, 7, 6,
            5, 4, 3, 2}
        Dim tempCpf As String
        Dim digito As String
        Dim soma As Integer
        Dim resto As Integer
        cpf = cpf.Trim()
        cpf = cpf.Replace(".", "").Replace("-", "")
        If cpf.Length <> 11 Then
            Return False
        End If
        tempCpf = cpf.Substring(0, 9)
        soma = 0
        For i As Integer = 0 To 8
            soma += Integer.Parse(tempCpf(i).ToString()) * multiplicador1(i)
        Next
        resto = soma Mod 11
        If resto < 2 Then
            resto = 0
        Else
            resto = 11 - resto
        End If
        digito = resto.ToString()
        tempCpf = tempCpf & digito
        soma = 0
        For i As Integer = 0 To 9
            soma += Integer.Parse(tempCpf(i).ToString()) * multiplicador2(i)
        Next
        resto = soma Mod 11
        If resto < 2 Then
            resto = 0
        Else
            resto = 11 - resto
        End If
        digito = digito & resto.ToString()
        Return cpf.EndsWith(digito)
    End Function

    'Validação de PIS
    Private Shared Function ValidarPis(pis As String) As Boolean
        Dim multiplicador As Integer() = New Integer(9) {3, 2, 9, 8, 7, 6,
            5, 4, 3, 2}
        Dim soma As Integer
        Dim resto As Integer
        If pis.Trim().Length <> 11 Then
            Return False
        End If
        pis = pis.Trim()
        pis = pis.Replace("-", "").Replace(".", "").PadLeft(11, "0"c)
        soma = 0
        For i As Integer = 0 To 9
            soma += Integer.Parse(pis(i).ToString()) * multiplicador(i)
        Next
        resto = soma Mod 11
        If resto < 2 Then
            resto = 0
        Else
            resto = 11 - resto
        End If
        Return pis.EndsWith(resto.ToString())
    End Function

    'Validação de E-mail
    Private Shared Function IsEmail(ByVal Email) As Boolean
        Dim ValidFlag As Boolean = False
        Dim atCount As Integer
        Dim SpecialFlag As Boolean
        Dim atLoop As Integer
        Dim atChr As String
        Dim BadFlag As Boolean
        Dim tAry1(1) As String
        Dim UserNAme As String
        Dim domainName As String
        If (Email <> "") And (InStr(1, Email, "@") > 0) And (InStr(1, Email, ".") > 0) Then
            atCount = 0
            SpecialFlag = False
            For atLoop = 1 To Len(Email)
                atChr = Mid(Email, atLoop, 1)
                If atChr = "@" Then atCount = atCount + 1
                If (atChr >= Chr(32)) And (atChr <= Chr(44)) Then SpecialFlag = True
                If (atChr = Chr(47)) Or (atChr = Chr(96)) Or (atChr >= Chr(123)) Then SpecialFlag = True
                If (atChr >= Chr(58)) And (atChr <= Chr(63)) Then SpecialFlag = True
                If (atChr >= Chr(91)) And (atChr <= Chr(94)) Then SpecialFlag = True
            Next
            If (atCount = 1) And (SpecialFlag = False) Then
                BadFlag = False
                tAry1 = Split(Email, "@")
                UserNAme = tAry1(0)
                domainName = tAry1(1)
                If (UserNAme = "") Or (domainName = "") Then BadFlag = True
                If Mid(domainName, 1, 1) = "." Then BadFlag = True
                If Mid(domainName, Len(domainName), 1) = "." Then BadFlag = True
                ValidFlag = True
            End If
        End If
        If BadFlag = True Then ValidFlag = False
        IsEmail = ValidFlag
    End Function

    'Validação de Celular
    Private Sub ValidaCelular(Celular As Object)
        If Len(Celular.text) <> 0 Then
            If Len(Celular.text) = 10 Then
                Dim Tel As Double
                Tel = Celular.text
                Celular.text = Format(Tel,
                    "\(##\) ####\-####")
            ElseIf Len(Celular.text) = 11 Then
                Dim Tel As Double
                Tel = Celular.text
                Celular.text = Format(Tel,
                    "\(##\) #####\-####")
            ElseIf Len(Celular.text) = 8 OrElse Len(Celular.text) = 9 Then
                Dim Tel As Double
                Tel = Celular.text
                Celular.text = Format(Tel,
                    "#####\-####")
            ElseIf Len(Celular.text) = 14 Then
                Exit Sub
            ElseIf Len(Celular.text) = 15 Then
                Exit Sub
            Else
                MsgBox("Número de ""Celular"" incorreto!" & vbNewLine & "Digite o DDD + o Número." _
                       & vbNewLine & "Ex: 11999999999 (somente os números)!",
                       vbCritical, "Erro Nº Telefone!")
                Celular.Select()
                'Celular.clear()
            End If
        End If
    End Sub

    'Validação de Telefone
    Private Sub ValidaTelefone(Telefone As Object)
        If Len(Telefone.text) <> 0 Then
            If Len(Telefone.text) = 10 Then
                Dim Tel As Double
                Tel = Telefone.text
                Telefone.text = Format(Tel, "\(##\) ####\-####")
            ElseIf Len(Telefone.text) = 8 Then
                Dim Tel As Double
                Tel = Telefone.text
                Telefone.text = Format(Tel, "####\-####")
            ElseIf Len(Telefone.text) = 14 Then
                Exit Sub
            ElseIf Len(Telefone.text) = 9 Then
                Exit Sub
            Else
                MsgBox("Número de ""Telefone"" incorreto!" _
                       & vbNewLine & "Digite o DDD + o Número." _
                       & vbNewLine & "Ex: 1143244444 (somente os 10 dígitos)!" _
                       & vbNewLine & "Ou Digite somente o Número." _
                       & vbNewLine & "Ex: 43244444 (somente os 8 dígitos)!",
                       vbCritical, "Erro Nº Telefone!")
                Telefone.Select()
            End If
        End If
    End Sub

    'Validação de Data
    Private Function IsData(DataPar As Object) As Boolean
        Try
            Dim Num As Double
            Num = Me.Text
            Me.Text = CDate(Format(Num, "##\/##\/####"))
            If IsDate(Me.Text) = True Then
                RemoveCaracteres(Me)
                Return True
            End If
        Catch ex As Exception
            RemoveCaracteres(Me)
            Return False
            Exit Function
        End Try
        Return DataPar
    End Function

    'Somente números
    Public Function SomenteNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SomenteNumeros = 0
        Else
            SomenteNumeros = Keyascii
        End If
        ' teclas adicionais permitidas
        Select Case Keyascii
            Case 8
                SomenteNumeros = Keyascii ' Backspace
            Case 13
                SomenteNumeros = Keyascii ' Enter
            Case 32
                SomenteNumeros = Keyascii ' Espace
        End Select

        '** Na propriedade "keyPress"
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SomenteNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        'End If
    End Function

    'Somente Letras
    Public Function SomenteLetras(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' Intercepta um código ASCII recebido e admite somente letras
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SomenteLetras = 0
        Else
            SomenteLetras = KeyAscii
        End If
        ' teclas adicionais permitidas
        If KeyAscii = 8 Then SomenteLetras = KeyAscii ' Backspace
        If KeyAscii = 13 Then SomenteLetras = KeyAscii ' Enter
        If KeyAscii = 32 Then SomenteLetras = KeyAscii ' Espace

        '** No Form, na propriedade "keyPress"
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SomenteLetras(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        'End If

    End Function

    'Valida CEP
    Private Function ValidaCep(Cep As Object) As Boolean
        If Len(Cep.Text) <> 8 Then
            MsgBox("Cep incorreto! Digite somente números (sem caracteres).",
                   CType(vbQuestion + vbYesNo, MsgBoxStyle), "Erro de Cep")
            Cep.Focus()
            Return False
            Exit Function
        ElseIf IsNothing(Cep.Text) Then
            If MsgBox("Endereço sem CEP." & " Deseja Continuar?", CType(vbQuestion + vbYesNo,
                      MsgBoxStyle), "...::: Erro no CEP :::...") = MsgBoxResult.No Then
                Cep.Focus()
                Return False
                Exit Function
            End If
            ' Procura o Cep no Banco e carrega no Form
        ElseIf Len(Cep.Text) = 8 Then
            Return True
        End If
        Return ValidaCep
    End Function

    'Valida Moeda
    Private Sub ValidaMoeda(Moeda As Object)
        Dim n As String = String.Empty
        Dim v As Double = 0
        n = Moeda.Text.Replace(",", "").Replace(".", "")
        If n.Equals("") Then n = "0"
        n = n.PadLeft(3, "0")
        If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
        v = CDbl(n) / 100
        Moeda.Text = String.Format("{0:N}", v)
        Moeda.SelectionStart = Moeda.Text.Length
    End Sub

    'Valida CNH
    Private Function ValidaCNH(CNH As String) As Boolean
        Dim CNHValor As Double
        Dim CNHNumero As String
        Dim CNHDigito As String
        Dim RestoDivisao As Double
        Dim ResultadoSubtracao As Double

        ValidaCNH = True

        CNH = Trim(CNH)

        If Trim(CNH) = "" Then
            ValidaCNH = False
        Else
            If Len(Trim(CNH)) <> 9 Then
                ValidaCNH = False
            Else
                CNHNumero = LSet(CNH, 8)
                CNHDigito = RSet(CNH, 1)
                CNHValor = CBool(CNHNumero)
                RestoDivisao = CNHValor Mod 11
                If RestoDivisao = 0 Then
                    ResultadoSubtracao = 0
                ElseIf RestoDivisao = 1 Then
                    ResultadoSubtracao = 0
                Else
                    ResultadoSubtracao = 11 - RestoDivisao
                End If

                If Val(CNHDigito) <> ResultadoSubtracao Then
                    ValidaCNH = False
                End If
            End If
        End If
        Return ValidaCNH
    End Function

    '"Default", "CPF", "CNPJ", "PIS", "Data", "E-Mail", "Telefone", "Celular", "CEP", "Moeda"
    Private Sub txtPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Me.m_TipoValidacao = "CPF" Or
             Me.m_TipoValidacao = "CNPJ" Or
             Me.m_TipoValidacao = "PIS" Or
             Me.m_TipoValidacao = "Data" Or
             Me.m_TipoValidacao = "Telefone" Or
             Me.m_TipoValidacao = "Celular" Or
             Me.m_TipoValidacao = "Moeda" Or
             Me.m_TipoValidacao = "Numeros" Or
             Me.m_TipoValidacao = "CEP" Then 'Me.m_TipoValidacao = "CNH" Or (deixei fora)
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SomenteNumeros(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        ElseIf Me.m_TipoValidacao = "Letras" Then
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SomenteLetras(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPerson_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        If Me.m_TipoValidacao = "Moeda" Then
            ValidaMoeda(Me)
        End If
    End Sub

#End Region

#Region "Construtor e Destrutor"
    'Definindo o Construtor
    Sub New()
        'Valores iniciais (padrão)
        _colorTextoVazio = Color.Gray
        _textoVazio = "<Descrição do Campo>"
        m_TipoValidacao = "Default"
    End Sub

    'Definindo o Destrutor
    Protected Overrides Sub Finalize()
        Try
        Finally
            MyBase.Finalize()
        End Try
    End Sub
#End Region
End Class
