<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
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

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Axis1 = New myUCLib.Axis()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.ButtonInit = New System.Windows.Forms.Button()
		Me.ButtonStart = New System.Windows.Forms.Button()
		Me.ButtonStop = New System.Windows.Forms.Button()
		Me.TextBoxAlpha0 = New System.Windows.Forms.TextBox()
		Me.TextBoxDt = New System.Windows.Forms.TextBox()
		Me.TextBoxV0 = New System.Windows.Forms.TextBox()
		Me.TextBoxT = New System.Windows.Forms.TextBox()
		Me.TextBoxH = New System.Windows.Forms.TextBox()
		Me.TextBoxXBase = New System.Windows.Forms.TextBox()
		Me.TextBoxYBase = New System.Windows.Forms.TextBox()
		Me.TextBoxXmax = New System.Windows.Forms.TextBox()
		Me.TextBoxYmax = New System.Windows.Forms.TextBox()
		Me.TextBoxVmax = New System.Windows.Forms.TextBox()
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
		Me.ButtonClear = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Axis1
		'
		Me.Axis1.axis_bkcolor = System.Drawing.Color.White
		Me.Axis1.axis_color = System.Drawing.Color.Gray
		Me.Axis1.Axis_Type = CType(1, Byte)
		Me.Axis1.E_x = 0
		Me.Axis1.E_y = 0
		Me.Axis1.Location = New System.Drawing.Point(298, 12)
		Me.Axis1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Axis1.Name = "Axis1"
		Me.Axis1.Pix_color = System.Drawing.Color.Black
		Me.Axis1.Pix_Size = 2.0!
		Me.Axis1.Pix_type = CType(1, Byte)
		Me.Axis1.Size = New System.Drawing.Size(490, 323)
		Me.Axis1.TabIndex = 0
		Me.Axis1.x_Base = 1.0!
		Me.Axis1.x_Name = "X"
		Me.Axis1.y_Base = 1.0!
		Me.Axis1.y_Name = "Y"
		'
		'Timer1
		'
		Me.Timer1.Interval = 10
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(253, 369)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(103, 17)
		Me.RadioButton1.TabIndex = 1
		Me.RadioButton1.Text = "переключатель"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'ButtonInit
		'
		Me.ButtonInit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ButtonInit.Location = New System.Drawing.Point(382, 351)
		Me.ButtonInit.Name = "ButtonInit"
		Me.ButtonInit.Size = New System.Drawing.Size(97, 55)
		Me.ButtonInit.TabIndex = 2
		Me.ButtonInit.Text = "Координаты"
		Me.ButtonInit.UseVisualStyleBackColor = False
		'
		'ButtonStart
		'
		Me.ButtonStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ButtonStart.Location = New System.Drawing.Point(503, 351)
		Me.ButtonStart.Name = "ButtonStart"
		Me.ButtonStart.Size = New System.Drawing.Size(97, 55)
		Me.ButtonStart.TabIndex = 3
		Me.ButtonStart.Text = "Старт"
		Me.ButtonStart.UseVisualStyleBackColor = False
		'
		'ButtonStop
		'
		Me.ButtonStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ButtonStop.Location = New System.Drawing.Point(623, 351)
		Me.ButtonStop.Name = "ButtonStop"
		Me.ButtonStop.Size = New System.Drawing.Size(97, 55)
		Me.ButtonStop.TabIndex = 4
		Me.ButtonStop.Text = "Стоп"
		Me.ButtonStop.UseVisualStyleBackColor = False
		'
		'TextBoxAlpha0
		'
		Me.TextBoxAlpha0.Location = New System.Drawing.Point(12, 64)
		Me.TextBoxAlpha0.Name = "TextBoxAlpha0"
		Me.TextBoxAlpha0.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxAlpha0.TabIndex = 5
		'
		'TextBoxDt
		'
		Me.TextBoxDt.Location = New System.Drawing.Point(12, 108)
		Me.TextBoxDt.Name = "TextBoxDt"
		Me.TextBoxDt.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxDt.TabIndex = 6
		'
		'TextBoxV0
		'
		Me.TextBoxV0.Location = New System.Drawing.Point(12, 156)
		Me.TextBoxV0.Name = "TextBoxV0"
		Me.TextBoxV0.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxV0.TabIndex = 6
		'
		'TextBoxT
		'
		Me.TextBoxT.Location = New System.Drawing.Point(145, 64)
		Me.TextBoxT.Name = "TextBoxT"
		Me.TextBoxT.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxT.TabIndex = 7
		'
		'TextBoxH
		'
		Me.TextBoxH.Location = New System.Drawing.Point(12, 206)
		Me.TextBoxH.Name = "TextBoxH"
		Me.TextBoxH.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxH.TabIndex = 7
		'
		'TextBoxXBase
		'
		Me.TextBoxXBase.Location = New System.Drawing.Point(12, 254)
		Me.TextBoxXBase.Name = "TextBoxXBase"
		Me.TextBoxXBase.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxXBase.TabIndex = 8
		'
		'TextBoxYBase
		'
		Me.TextBoxYBase.Location = New System.Drawing.Point(12, 303)
		Me.TextBoxYBase.Name = "TextBoxYBase"
		Me.TextBoxYBase.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxYBase.TabIndex = 9
		'
		'TextBoxXmax
		'
		Me.TextBoxXmax.Location = New System.Drawing.Point(145, 108)
		Me.TextBoxXmax.Name = "TextBoxXmax"
		Me.TextBoxXmax.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxXmax.TabIndex = 10
		'
		'TextBoxYmax
		'
		Me.TextBoxYmax.Location = New System.Drawing.Point(145, 156)
		Me.TextBoxYmax.Name = "TextBoxYmax"
		Me.TextBoxYmax.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxYmax.TabIndex = 11
		'
		'TextBoxVmax
		'
		Me.TextBoxVmax.Location = New System.Drawing.Point(145, 206)
		Me.TextBoxVmax.Name = "TextBoxVmax"
		Me.TextBoxVmax.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxVmax.TabIndex = 12
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(22, 48)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "alpha0"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(34, 92)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(16, 13)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "dt"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(34, 140)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(20, 13)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "V0"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(191, 48)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(14, 13)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "T"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(37, 190)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(15, 13)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "H"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(36, 238)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(14, 13)
		Me.Label6.TabIndex = 16
		Me.Label6.Text = "X"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(37, 287)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(14, 13)
		Me.Label7.TabIndex = 17
		Me.Label7.Text = "Y"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(172, 92)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(33, 13)
		Me.Label8.TabIndex = 18
		Me.Label8.Text = "Xmax"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(172, 140)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(33, 13)
		Me.Label9.TabIndex = 19
		Me.Label9.Text = "Ymax"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(172, 190)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(33, 13)
		Me.Label10.TabIndex = 20
		Me.Label10.Text = "Vmax"
		'
		'ButtonClear
		'
		Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ButtonClear.Location = New System.Drawing.Point(145, 301)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(111, 55)
		Me.ButtonClear.TabIndex = 21
		Me.ButtonClear.Text = "Удалить"
		Me.ButtonClear.UseVisualStyleBackColor = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBoxVmax)
		Me.Controls.Add(Me.TextBoxYmax)
		Me.Controls.Add(Me.TextBoxXmax)
		Me.Controls.Add(Me.TextBoxYBase)
		Me.Controls.Add(Me.TextBoxXBase)
		Me.Controls.Add(Me.TextBoxH)
		Me.Controls.Add(Me.TextBoxT)
		Me.Controls.Add(Me.TextBoxV0)
		Me.Controls.Add(Me.TextBoxDt)
		Me.Controls.Add(Me.TextBoxAlpha0)
		Me.Controls.Add(Me.ButtonStop)
		Me.Controls.Add(Me.ButtonStart)
		Me.Controls.Add(Me.ButtonInit)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.Axis1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Axis1 As myUCLib.Axis
	Friend WithEvents Timer1 As Timer
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents ButtonInit As Button
	Friend WithEvents ButtonStart As Button
	Friend WithEvents ButtonStop As Button
	Friend WithEvents TextBoxAlpha0 As TextBox
	Friend WithEvents TextBoxDt As TextBox
	Friend WithEvents TextBoxV0 As TextBox
	Friend WithEvents TextBoxT As TextBox
	Friend WithEvents TextBoxH As TextBox
	Friend WithEvents TextBoxXBase As TextBox
	Friend WithEvents TextBoxYBase As TextBox
	Friend WithEvents TextBoxXmax As TextBox
	Friend WithEvents TextBoxYmax As TextBox
	Friend WithEvents TextBoxVmax As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents ButtonClear As Button
End Class
