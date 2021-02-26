<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Aula01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Vídeo01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Vídeo02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Vídeo03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Lbl_denominador = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 46)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Aula01ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(728, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Aula01ToolStripMenuItem
        '
        Me.Aula01ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Vídeo01ToolStripMenuItem, Me.Vídeo02ToolStripMenuItem, Me.Vídeo03ToolStripMenuItem})
        Me.Aula01ToolStripMenuItem.Name = "Aula01ToolStripMenuItem"
        Me.Aula01ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.Aula01ToolStripMenuItem.Text = "Aula 01"
        '
        'Vídeo01ToolStripMenuItem
        '
        Me.Vídeo01ToolStripMenuItem.Name = "Vídeo01ToolStripMenuItem"
        Me.Vídeo01ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Vídeo01ToolStripMenuItem.Text = "Vídeo 01"
        '
        'Vídeo02ToolStripMenuItem
        '
        Me.Vídeo02ToolStripMenuItem.Name = "Vídeo02ToolStripMenuItem"
        Me.Vídeo02ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Vídeo02ToolStripMenuItem.Text = "Vídeo 02"
        '
        'Vídeo03ToolStripMenuItem
        '
        Me.Vídeo03ToolStripMenuItem.Name = "Vídeo03ToolStripMenuItem"
        Me.Vídeo03ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Vídeo03ToolStripMenuItem.Text = "Vídeo 03"
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(15, 104)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Denominador.TabIndex = 2
        '
        'Lbl_denominador
        '
        Me.Lbl_denominador.AutoSize = True
        Me.Lbl_denominador.Location = New System.Drawing.Point(12, 88)
        Me.Lbl_denominador.Name = "Lbl_denominador"
        Me.Lbl_denominador.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_denominador.TabIndex = 3
        Me.Lbl_denominador.Text = "Label1"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 412)
        Me.Controls.Add(Me.Lbl_denominador)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Aula01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Vídeo03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Lbl_denominador As Label
End Class
