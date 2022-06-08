<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBoxValidate4 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate3 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate10 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate9 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate2 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate8 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate7 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate6 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate5 = New ValidacaoTexto.TextBoxValidate()
        Me.TextBoxValidate1 = New ValidacaoTexto.TextBoxValidate()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 389)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 50)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Moeda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(566, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CNPJ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Numero"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(207, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Letras"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(386, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CEP"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Telefone"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(202, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Celular"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(386, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "e-Mail"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(375, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 24)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Exemplos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 50)
        Me.Panel2.TabIndex = 9
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkVisited = True
        Me.LinkLabel1.Location = New System.Drawing.Point(208, 28)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(319, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://kallbuloso.com.br/amaralkarl/classe-de-validacao-textbox/"
        '
        'TextBoxValidate4
        '
        Me.TextBoxValidate4.GotFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate4.Location = New System.Drawing.Point(570, 99)
        Me.TextBoxValidate4.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate4.Name = "TextBoxValidate4"
        Me.TextBoxValidate4.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxValidate4.TabIndex = 3
        Me.TextBoxValidate4.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate4.TextoVazioDescricao = "99.999.999/999-99"
        Me.TextBoxValidate4.TipoValidacao = "CNPJ"
        '
        'TextBoxValidate3
        '
        Me.TextBoxValidate3.GotFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate3.Location = New System.Drawing.Point(390, 99)
        Me.TextBoxValidate3.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate3.Name = "TextBoxValidate3"
        Me.TextBoxValidate3.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxValidate3.TabIndex = 2
        Me.TextBoxValidate3.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate3.TextoVazioDescricao = "999.999.999-99"
        Me.TextBoxValidate3.TipoValidacao = "CPF"
        '
        'TextBoxValidate10
        '
        Me.TextBoxValidate10.GotFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxValidate10.Location = New System.Drawing.Point(390, 279)
        Me.TextBoxValidate10.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate10.Name = "TextBoxValidate10"
        Me.TextBoxValidate10.Size = New System.Drawing.Size(321, 20)
        Me.TextBoxValidate10.TabIndex = 8
        Me.TextBoxValidate10.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate10.TextoVazioDescricao = "e-mail"
        Me.TextBoxValidate10.TipoValidacao = "E-Mail"
        '
        'TextBoxValidate9
        '
        Me.TextBoxValidate9.GotFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxValidate9.Location = New System.Drawing.Point(206, 279)
        Me.TextBoxValidate9.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate9.Name = "TextBoxValidate9"
        Me.TextBoxValidate9.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxValidate9.TabIndex = 8
        Me.TextBoxValidate9.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate9.TextoVazioDescricao = "Celular"
        Me.TextBoxValidate9.TipoValidacao = "Celular"
        '
        'TextBoxValidate2
        '
        Me.TextBoxValidate2.GotFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate2.Location = New System.Drawing.Point(211, 99)
        Me.TextBoxValidate2.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate2.Name = "TextBoxValidate2"
        Me.TextBoxValidate2.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxValidate2.TabIndex = 1
        Me.TextBoxValidate2.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate2.TextoVazioDescricao = "DD/MM/AAAA"
        Me.TextBoxValidate2.TipoValidacao = "Data"
        '
        'TextBoxValidate8
        '
        Me.TextBoxValidate8.GotFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxValidate8.Location = New System.Drawing.Point(55, 279)
        Me.TextBoxValidate8.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate8.Name = "TextBoxValidate8"
        Me.TextBoxValidate8.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxValidate8.TabIndex = 7
        Me.TextBoxValidate8.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate8.TextoVazioDescricao = "Telefone"
        Me.TextBoxValidate8.TipoValidacao = "Telefone"
        '
        'TextBoxValidate7
        '
        Me.TextBoxValidate7.GotFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxValidate7.Location = New System.Drawing.Point(390, 184)
        Me.TextBoxValidate7.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate7.Name = "TextBoxValidate7"
        Me.TextBoxValidate7.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxValidate7.TabIndex = 6
        Me.TextBoxValidate7.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate7.TextoVazioDescricao = "Cep"
        Me.TextBoxValidate7.TipoValidacao = "CEP"
        '
        'TextBoxValidate6
        '
        Me.TextBoxValidate6.GotFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxValidate6.Location = New System.Drawing.Point(211, 184)
        Me.TextBoxValidate6.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate6.Name = "TextBoxValidate6"
        Me.TextBoxValidate6.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxValidate6.TabIndex = 5
        Me.TextBoxValidate6.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate6.TextoVazioDescricao = "Letras"
        Me.TextBoxValidate6.TipoValidacao = "Letras"
        '
        'TextBoxValidate5
        '
        Me.TextBoxValidate5.GotFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxValidate5.Location = New System.Drawing.Point(55, 184)
        Me.TextBoxValidate5.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate5.Name = "TextBoxValidate5"
        Me.TextBoxValidate5.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxValidate5.TabIndex = 4
        Me.TextBoxValidate5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxValidate5.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate5.TextoVazioDescricao = "Numeros"
        Me.TextBoxValidate5.TipoValidacao = "Numeros"
        '
        'TextBoxValidate1
        '
        Me.TextBoxValidate1.GotFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxValidate1.Location = New System.Drawing.Point(55, 99)
        Me.TextBoxValidate1.LostFocusColor = System.Drawing.Color.White
        Me.TextBoxValidate1.Name = "TextBoxValidate1"
        Me.TextBoxValidate1.Size = New System.Drawing.Size(94, 20)
        Me.TextBoxValidate1.TabIndex = 0
        Me.TextBoxValidate1.Text = "0,00"
        Me.TextBoxValidate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxValidate1.TextoVazioColor = System.Drawing.Color.Gray
        Me.TextBoxValidate1.TextoVazioDescricao = "Valor Pago"
        Me.TextBoxValidate1.TipoValidacao = "Moeda"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(349, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 24)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Créditos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 439)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxValidate4)
        Me.Controls.Add(Me.TextBoxValidate3)
        Me.Controls.Add(Me.TextBoxValidate10)
        Me.Controls.Add(Me.TextBoxValidate9)
        Me.Controls.Add(Me.TextBoxValidate2)
        Me.Controls.Add(Me.TextBoxValidate8)
        Me.Controls.Add(Me.TextBoxValidate7)
        Me.Controls.Add(Me.TextBoxValidate6)
        Me.Controls.Add(Me.TextBoxValidate5)
        Me.Controls.Add(Me.TextBoxValidate1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxValidate1 As TextBoxValidate
    Friend WithEvents TextBoxValidate2 As TextBoxValidate
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxValidate3 As TextBoxValidate
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxValidate4 As TextBoxValidate
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxValidate5 As TextBoxValidate
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxValidate6 As TextBoxValidate
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxValidate7 As TextBoxValidate
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxValidate8 As TextBoxValidate
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxValidate9 As TextBoxValidate
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxValidate10 As TextBoxValidate
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label11 As Label
End Class
