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
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(505, 184)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(179, 23)
        Me.btnProcurar.TabIndex = 0
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'txtProcurar
        '
        Me.txtProcurar.Location = New System.Drawing.Point(120, 186)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(354, 20)
        Me.txtProcurar.TabIndex = 1
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(505, 242)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(179, 62)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "Informações"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(120, 242)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(354, 62)
        Me.txtInfo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(114, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pesquisar Por Arquivos ou Diretórios"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.txtProcurar)
        Me.Controls.Add(Me.btnProcurar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcurar As Button
    Friend WithEvents txtProcurar As TextBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents Label1 As Label
End Class
