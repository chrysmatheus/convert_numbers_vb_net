<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdb_for_arabic = New System.Windows.Forms.RadioButton()
        Me.rdb_for_rom = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_avançar = New System.Windows.Forms.Button()
        Me.btn_gerar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_voltar2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_result
        '
        Me.lbl_result.BackColor = System.Drawing.Color.White
        Me.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_result.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_result.ForeColor = System.Drawing.Color.Red
        Me.lbl_result.Location = New System.Drawing.Point(935, 214)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(135, 33)
        Me.lbl_result.TabIndex = 13
        Me.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(469, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 56)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Selecione qual o tipo de conversão " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "deseja fazer :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdb_for_arabic
        '
        Me.rdb_for_arabic.AutoSize = True
        Me.rdb_for_arabic.BackColor = System.Drawing.Color.White
        Me.rdb_for_arabic.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_for_arabic.Location = New System.Drawing.Point(503, 233)
        Me.rdb_for_arabic.Name = "rdb_for_arabic"
        Me.rdb_for_arabic.Size = New System.Drawing.Size(192, 32)
        Me.rdb_for_arabic.TabIndex = 10
        Me.rdb_for_arabic.TabStop = True
        Me.rdb_for_arabic.Text = "Romano para arábico"
        Me.rdb_for_arabic.UseVisualStyleBackColor = False
        '
        'rdb_for_rom
        '
        Me.rdb_for_rom.AutoSize = True
        Me.rdb_for_rom.BackColor = System.Drawing.Color.White
        Me.rdb_for_rom.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_for_rom.Location = New System.Drawing.Point(503, 195)
        Me.rdb_for_rom.Name = "rdb_for_rom"
        Me.rdb_for_rom.Size = New System.Drawing.Size(191, 32)
        Me.rdb_for_rom.TabIndex = 9
        Me.rdb_for_rom.TabStop = True
        Me.rdb_for_rom.Text = "Arábico para romano"
        Me.rdb_for_rom.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 56)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Digite o número ou algarismo romano que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "deseja converter :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_num
        '
        Me.txt_num.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num.Location = New System.Drawing.Point(150, 226)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(96, 39)
        Me.txt_num.TabIndex = 7
        Me.txt_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(897, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Resultado da conversão:"
        '
        'btn_avançar
        '
        Me.btn_avançar.BackColor = System.Drawing.Color.White
        Me.btn_avançar.BackgroundImage = Global.convert.My.Resources.Resources.Next_2_2_icon
        Me.btn_avançar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_avançar.FlatAppearance.BorderSize = 0
        Me.btn_avançar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_avançar.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_avançar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_avançar.Location = New System.Drawing.Point(285, 330)
        Me.btn_avançar.Name = "btn_avançar"
        Me.btn_avançar.Size = New System.Drawing.Size(45, 43)
        Me.btn_avançar.TabIndex = 16
        Me.btn_avançar.UseVisualStyleBackColor = False
        '
        'btn_gerar
        '
        Me.btn_gerar.BackColor = System.Drawing.Color.White
        Me.btn_gerar.BackgroundImage = Global.convert.My.Resources.Resources.Next_2_2_icon
        Me.btn_gerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gerar.FlatAppearance.BorderSize = 0
        Me.btn_gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gerar.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_gerar.Location = New System.Drawing.Point(688, 330)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(43, 44)
        Me.btn_gerar.TabIndex = 12
        Me.btn_gerar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(23, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(363, 360)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(419, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(363, 360)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(815, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(363, 360)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.convert.My.Resources.Resources.arrow_refresh_1_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(974, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 42)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.White
        Me.btn_voltar.BackgroundImage = Global.convert.My.Resources.Resources.Previous_icon
        Me.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_voltar.Location = New System.Drawing.Point(460, 329)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(40, 44)
        Me.btn_voltar.TabIndex = 20
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_voltar2
        '
        Me.btn_voltar2.BackColor = System.Drawing.Color.White
        Me.btn_voltar2.BackgroundImage = Global.convert.My.Resources.Resources.Previous_icon
        Me.btn_voltar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_voltar2.FlatAppearance.BorderSize = 0
        Me.btn_voltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar2.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar2.ForeColor = System.Drawing.Color.Transparent
        Me.btn_voltar2.Location = New System.Drawing.Point(857, 338)
        Me.btn_voltar2.Name = "btn_voltar2"
        Me.btn_voltar2.Size = New System.Drawing.Size(38, 35)
        Me.btn_voltar2.TabIndex = 21
        Me.btn_voltar2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.convert.My.Resources.Resources.User_Interface_Exit_icon
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(1099, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 22
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 442)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_voltar2)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_avançar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.btn_gerar)
        Me.Controls.Add(Me.rdb_for_arabic)
        Me.Controls.Add(Me.rdb_for_rom)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONVERSÃO DE NÚMEROS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_result As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdb_for_arabic As RadioButton
    Friend WithEvents rdb_for_rom As RadioButton
    Friend WithEvents Label1 As Label
    Private WithEvents txt_num As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_gerar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_avançar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_voltar2 As Button
    Friend WithEvents Button4 As Button
End Class
