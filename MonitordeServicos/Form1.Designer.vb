<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitor_Ellon
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monitor_Ellon))
        Me.gbGerenServico = New System.Windows.Forms.GroupBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnReinicarSair = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.btnDesistalar = New System.Windows.Forms.Button()
        Me.btnInstalar = New System.Windows.Forms.Button()
        Me.gbNomeServico = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtNomeServico = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgServicos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btIncluir = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.gbDadosServi = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txturlservice = New System.Windows.Forms.TextBox()
        Me.txtnmservice = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbGerenServico.SuspendLayout()
        Me.gbNomeServico.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.gbDadosServi.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGerenServico
        '
        Me.gbGerenServico.Controls.Add(Me.btnIniciar)
        Me.gbGerenServico.Controls.Add(Me.btnReinicarSair)
        Me.gbGerenServico.Controls.Add(Me.btnParar)
        Me.gbGerenServico.Controls.Add(Me.btnDesistalar)
        Me.gbGerenServico.Controls.Add(Me.btnInstalar)
        Me.gbGerenServico.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbGerenServico.Location = New System.Drawing.Point(0, 282)
        Me.gbGerenServico.Name = "gbGerenServico"
        Me.gbGerenServico.Size = New System.Drawing.Size(727, 75)
        Me.gbGerenServico.TabIndex = 33
        Me.gbGerenServico.TabStop = False
        Me.gbGerenServico.Text = "Gerenciamento do Serviço ellonSync.exe"
        '
        'btnIniciar
        '
        Me.btnIniciar.Enabled = False
        Me.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnIniciar.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Image = Global.MonitordeServicos.My.Resources.Resources.if_Arrow_film_movie_play_player_start_video_1886336
        Me.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIniciar.Location = New System.Drawing.Point(336, 22)
        Me.btnIniciar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(119, 41)
        Me.btnIniciar.TabIndex = 6
        Me.btnIniciar.TabStop = False
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnReinicarSair
        '
        Me.btnReinicarSair.Enabled = False
        Me.btnReinicarSair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReinicarSair.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReinicarSair.Image = Global.MonitordeServicos.My.Resources.Resources.if_radial_arrows_1216559
        Me.btnReinicarSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReinicarSair.Location = New System.Drawing.Point(583, 22)
        Me.btnReinicarSair.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReinicarSair.Name = "btnReinicarSair"
        Me.btnReinicarSair.Size = New System.Drawing.Size(140, 41)
        Me.btnReinicarSair.TabIndex = 5
        Me.btnReinicarSair.TabStop = False
        Me.btnReinicarSair.Text = "Reiniciar e Sair"
        Me.btnReinicarSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReinicarSair.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.Enabled = False
        Me.btnParar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnParar.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParar.Image = Global.MonitordeServicos.My.Resources.Resources.if_error_1646012
        Me.btnParar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParar.Location = New System.Drawing.Point(459, 22)
        Me.btnParar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(119, 41)
        Me.btnParar.TabIndex = 4
        Me.btnParar.TabStop = False
        Me.btnParar.Text = "Parar"
        Me.btnParar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'btnDesistalar
        '
        Me.btnDesistalar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDesistalar.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesistalar.Image = Global.MonitordeServicos.My.Resources.Resources.if_minus_1645995
        Me.btnDesistalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesistalar.Location = New System.Drawing.Point(131, 22)
        Me.btnDesistalar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDesistalar.Name = "btnDesistalar"
        Me.btnDesistalar.Size = New System.Drawing.Size(119, 41)
        Me.btnDesistalar.TabIndex = 2
        Me.btnDesistalar.TabStop = False
        Me.btnDesistalar.Tag = "r"
        Me.btnDesistalar.Text = "Desinstalar"
        Me.btnDesistalar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDesistalar.UseVisualStyleBackColor = True
        '
        'btnInstalar
        '
        Me.btnInstalar.Enabled = False
        Me.btnInstalar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInstalar.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstalar.Image = Global.MonitordeServicos.My.Resources.Resources.if_plus_1646001
        Me.btnInstalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInstalar.Location = New System.Drawing.Point(7, 22)
        Me.btnInstalar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInstalar.Name = "btnInstalar"
        Me.btnInstalar.Size = New System.Drawing.Size(119, 41)
        Me.btnInstalar.TabIndex = 1
        Me.btnInstalar.TabStop = False
        Me.btnInstalar.Text = "Instalar"
        Me.btnInstalar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInstalar.UseVisualStyleBackColor = True
        '
        'gbNomeServico
        '
        Me.gbNomeServico.Controls.Add(Me.GroupBox3)
        Me.gbNomeServico.Controls.Add(Me.txtNomeServico)
        Me.gbNomeServico.Controls.Add(Me.Label2)
        Me.gbNomeServico.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbNomeServico.Location = New System.Drawing.Point(0, 357)
        Me.gbNomeServico.Name = "gbNomeServico"
        Me.gbNomeServico.Size = New System.Drawing.Size(727, 44)
        Me.gbNomeServico.TabIndex = 32
        Me.gbNomeServico.TabStop = False
        Me.gbNomeServico.Text = "Nome do Serviço"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblStatus)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(549, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 44)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status Serviço"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(6, 15)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(160, 23)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "NÃO INSTALADO"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomeServico
        '
        Me.txtNomeServico.BackColor = System.Drawing.Color.White
        Me.txtNomeServico.Location = New System.Drawing.Point(111, 17)
        Me.txtNomeServico.Name = "txtNomeServico"
        Me.txtNomeServico.ReadOnly = True
        Me.txtNomeServico.Size = New System.Drawing.Size(139, 20)
        Me.txtNomeServico.TabIndex = 1
        Me.txtNomeServico.Text = "_ellonMonitorService"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome do Serviço:"
        '
        'dgServicos
        '
        Me.dgServicos.AllowUserToAddRows = False
        Me.dgServicos.AllowUserToDeleteRows = False
        Me.dgServicos.BackgroundColor = System.Drawing.Color.White
        Me.dgServicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgServicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Status})
        Me.dgServicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgServicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgServicos.GridColor = System.Drawing.Color.White
        Me.dgServicos.Location = New System.Drawing.Point(0, 124)
        Me.dgServicos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dgServicos.MultiSelect = False
        Me.dgServicos.Name = "dgServicos"
        Me.dgServicos.ReadOnly = True
        Me.dgServicos.RowHeadersVisible = False
        Me.dgServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgServicos.Size = New System.Drawing.Size(727, 158)
        Me.dgServicos.TabIndex = 34
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btIncluir, Me.btnExcluir})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(727, 73)
        Me.ToolStrip2.TabIndex = 35
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btIncluir
        '
        Me.btIncluir.AutoSize = False
        Me.btIncluir.AutoToolTip = False
        Me.btIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btIncluir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIncluir.Image = Global.MonitordeServicos.My.Resources.Resources.iconfinder_040_95876
        Me.btIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btIncluir.Name = "btIncluir"
        Me.btIncluir.Size = New System.Drawing.Size(110, 70)
        Me.btIncluir.Text = "Incluir"
        Me.btIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'btnExcluir
        '
        Me.btnExcluir.AutoSize = False
        Me.btnExcluir.AutoToolTip = False
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExcluir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.MonitordeServicos.My.Resources.Resources.iconfinder_039_95905
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(110, 70)
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'gbDadosServi
        '
        Me.gbDadosServi.Controls.Add(Me.Label3)
        Me.gbDadosServi.Controls.Add(Me.Label1)
        Me.gbDadosServi.Controls.Add(Me.Button1)
        Me.gbDadosServi.Controls.Add(Me.txturlservice)
        Me.gbDadosServi.Controls.Add(Me.txtnmservice)
        Me.gbDadosServi.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDadosServi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDadosServi.Location = New System.Drawing.Point(0, 73)
        Me.gbDadosServi.Name = "gbDadosServi"
        Me.gbDadosServi.Size = New System.Drawing.Size(727, 51)
        Me.gbDadosServi.TabIndex = 36
        Me.gbDadosServi.TabStop = False
        Me.gbDadosServi.Text = "Dados Serviço"
        Me.gbDadosServi.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "URL:"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.MonitordeServicos.My.Resources.Resources.iconfinder_tick_circle_27248
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(644, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.TabStop = False
        Me.Button1.Text = "Gravar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txturlservice
        '
        Me.txturlservice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txturlservice.Location = New System.Drawing.Point(196, 15)
        Me.txturlservice.Name = "txturlservice"
        Me.txturlservice.Size = New System.Drawing.Size(441, 21)
        Me.txturlservice.TabIndex = 1
        '
        'txtnmservice
        '
        Me.txtnmservice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnmservice.Location = New System.Drawing.Point(54, 15)
        Me.txtnmservice.Name = "txtnmservice"
        Me.txtnmservice.Size = New System.Drawing.Size(100, 21)
        Me.txtnmservice.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serviço"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.DefaultCellStyle = DataGridViewCellStyle3
        Me.Status.HeaderText = "Url Teste"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Monitor_Ellon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(727, 401)
        Me.Controls.Add(Me.dgServicos)
        Me.Controls.Add(Me.gbGerenServico)
        Me.Controls.Add(Me.gbNomeServico)
        Me.Controls.Add(Me.gbDadosServi)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Monitor_Ellon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Monitor de Serviços Ellon"
        Me.gbGerenServico.ResumeLayout(False)
        Me.gbNomeServico.ResumeLayout(False)
        Me.gbNomeServico.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgServicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.gbDadosServi.ResumeLayout(False)
        Me.gbDadosServi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbGerenServico As GroupBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnReinicarSair As Button
    Friend WithEvents btnParar As Button
    Friend WithEvents btnDesistalar As Button
    Friend WithEvents btnInstalar As Button
    Friend WithEvents gbNomeServico As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtNomeServico As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgServicos As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btIncluir As ToolStripButton
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents gbDadosServi As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txturlservice As TextBox
    Friend WithEvents txtnmservice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
