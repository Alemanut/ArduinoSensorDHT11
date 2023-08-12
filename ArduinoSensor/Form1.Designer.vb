<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btescanear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PanelConexion = New System.Windows.Forms.Panel()
        Me.PictureBoxStatusConnection = New System.Windows.Forms.PictureBox()
        Me.btConectar = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.lbbaudrate = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.btDesconectar = New System.Windows.Forms.Button()
        Me.PanelHumedad = New System.Windows.Forms.Panel()
        Me.Circular_Humedad = New CircularProgressBar.CircularProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTemp = New System.Windows.Forms.Panel()
        Me.lbTemp = New System.Windows.Forms.Label()
        Me.lbTempMin = New System.Windows.Forms.Label()
        Me.lbTempMax = New System.Windows.Forms.Label()
        Me.PictureBoxTemp = New System.Windows.Forms.PictureBox()
        Me.PictureBoxTempBack = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.PanelConexion.SuspendLayout()
        CType(Me.PictureBoxStatusConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHumedad.SuspendLayout()
        Me.PanelTemp.SuspendLayout()
        CType(Me.PictureBoxTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTempBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btescanear
        '
        Me.btescanear.BackColor = System.Drawing.Color.White
        Me.btescanear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btescanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btescanear.Location = New System.Drawing.Point(3, 29)
        Me.btescanear.Name = "btescanear"
        Me.btescanear.Size = New System.Drawing.Size(119, 23)
        Me.btescanear.TabIndex = 0
        Me.btescanear.Text = "Escanear Puerto"
        Me.btescanear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Conexion"
        '
        'PanelConexion
        '
        Me.PanelConexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelConexion.Controls.Add(Me.PictureBoxStatusConnection)
        Me.PanelConexion.Controls.Add(Me.btConectar)
        Me.PanelConexion.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConexion.Controls.Add(Me.LabelStatus)
        Me.PanelConexion.Controls.Add(Me.lbbaudrate)
        Me.PanelConexion.Controls.Add(Me.ComboBoxPort)
        Me.PanelConexion.Controls.Add(Me.Label1)
        Me.PanelConexion.Controls.Add(Me.btDesconectar)
        Me.PanelConexion.Controls.Add(Me.btescanear)
        Me.PanelConexion.Location = New System.Drawing.Point(9, 12)
        Me.PanelConexion.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelConexion.Name = "PanelConexion"
        Me.PanelConexion.Size = New System.Drawing.Size(282, 194)
        Me.PanelConexion.TabIndex = 2
        '
        'PictureBoxStatusConnection
        '
        Me.PictureBoxStatusConnection.BackColor = System.Drawing.Color.White
        Me.PictureBoxStatusConnection.Location = New System.Drawing.Point(151, 158)
        Me.PictureBoxStatusConnection.Name = "PictureBoxStatusConnection"
        Me.PictureBoxStatusConnection.Size = New System.Drawing.Size(119, 18)
        Me.PictureBoxStatusConnection.TabIndex = 9
        Me.PictureBoxStatusConnection.TabStop = False
        '
        'btConectar
        '
        Me.btConectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConectar.Location = New System.Drawing.Point(0, 109)
        Me.btConectar.Name = "btConectar"
        Me.btConectar.Size = New System.Drawing.Size(119, 23)
        Me.btConectar.TabIndex = 8
        Me.btConectar.Text = "Conectar"
        Me.btConectar.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(149, 67)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBaudRate.TabIndex = 7
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(3, 158)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(122, 18)
        Me.LabelStatus.TabIndex = 7
        Me.LabelStatus.Text = "Status Conection"
        '
        'lbbaudrate
        '
        Me.lbbaudrate.AutoSize = True
        Me.lbbaudrate.BackColor = System.Drawing.Color.White
        Me.lbbaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbbaudrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbbaudrate.Location = New System.Drawing.Point(29, 72)
        Me.lbbaudrate.Name = "lbbaudrate"
        Me.lbbaudrate.Size = New System.Drawing.Size(68, 16)
        Me.lbbaudrate.TabIndex = 6
        Me.lbbaudrate.Text = "BaudRate"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(149, 29)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPort.TabIndex = 5
        '
        'btDesconectar
        '
        Me.btDesconectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDesconectar.Location = New System.Drawing.Point(151, 109)
        Me.btDesconectar.Name = "btDesconectar"
        Me.btDesconectar.Size = New System.Drawing.Size(119, 23)
        Me.btDesconectar.TabIndex = 3
        Me.btDesconectar.Text = "Desconectar"
        Me.btDesconectar.UseVisualStyleBackColor = False
        '
        'PanelHumedad
        '
        Me.PanelHumedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelHumedad.Controls.Add(Me.Circular_Humedad)
        Me.PanelHumedad.Controls.Add(Me.Label2)
        Me.PanelHumedad.Location = New System.Drawing.Point(287, 12)
        Me.PanelHumedad.Name = "PanelHumedad"
        Me.PanelHumedad.Size = New System.Drawing.Size(238, 194)
        Me.PanelHumedad.TabIndex = 3
        '
        'Circular_Humedad
        '
        Me.Circular_Humedad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.Circular_Humedad.AnimationSpeed = 500
        Me.Circular_Humedad.BackColor = System.Drawing.Color.Transparent
        Me.Circular_Humedad.Cursor = System.Windows.Forms.Cursors.Default
        Me.Circular_Humedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circular_Humedad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Circular_Humedad.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Circular_Humedad.InnerMargin = 2
        Me.Circular_Humedad.InnerWidth = -1
        Me.Circular_Humedad.Location = New System.Drawing.Point(44, 61)
        Me.Circular_Humedad.MarqueeAnimationSpeed = 2000
        Me.Circular_Humedad.Name = "Circular_Humedad"
        Me.Circular_Humedad.OuterColor = System.Drawing.Color.Gray
        Me.Circular_Humedad.OuterMargin = -25
        Me.Circular_Humedad.OuterWidth = 26
        Me.Circular_Humedad.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Circular_Humedad.ProgressWidth = 25
        Me.Circular_Humedad.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.Circular_Humedad.Size = New System.Drawing.Size(119, 94)
        Me.Circular_Humedad.StartAngle = 270
        Me.Circular_Humedad.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Circular_Humedad.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.Circular_Humedad.SubscriptText = ""
        Me.Circular_Humedad.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Circular_Humedad.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.Circular_Humedad.SuperscriptText = ""
        Me.Circular_Humedad.TabIndex = 10
        Me.Circular_Humedad.Text = "0"
        Me.Circular_Humedad.TextMargin = New System.Windows.Forms.Padding(0)
        Me.Circular_Humedad.Value = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Humedad"
        '
        'PanelTemp
        '
        Me.PanelTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelTemp.Controls.Add(Me.lbTemp)
        Me.PanelTemp.Controls.Add(Me.lbTempMin)
        Me.PanelTemp.Controls.Add(Me.lbTempMax)
        Me.PanelTemp.Controls.Add(Me.PictureBoxTemp)
        Me.PanelTemp.Controls.Add(Me.PictureBoxTempBack)
        Me.PanelTemp.Controls.Add(Me.Label3)
        Me.PanelTemp.Location = New System.Drawing.Point(523, 12)
        Me.PanelTemp.Name = "PanelTemp"
        Me.PanelTemp.Size = New System.Drawing.Size(225, 194)
        Me.PanelTemp.TabIndex = 4
        '
        'lbTemp
        '
        Me.lbTemp.AutoSize = True
        Me.lbTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTemp.Location = New System.Drawing.Point(59, 90)
        Me.lbTemp.Name = "lbTemp"
        Me.lbTemp.Size = New System.Drawing.Size(50, 16)
        Me.lbTemp.TabIndex = 15
        Me.lbTemp.Text = "00.00 C"
        '
        'lbTempMin
        '
        Me.lbTempMin.AutoSize = True
        Me.lbTempMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTempMin.Location = New System.Drawing.Point(63, 155)
        Me.lbTempMin.Name = "lbTempMin"
        Me.lbTempMin.Size = New System.Drawing.Size(25, 16)
        Me.lbTempMin.TabIndex = 14
        Me.lbTempMin.Text = "-20"
        '
        'lbTempMax
        '
        Me.lbTempMax.AutoSize = True
        Me.lbTempMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTempMax.Location = New System.Drawing.Point(63, 34)
        Me.lbTempMax.Name = "lbTempMax"
        Me.lbTempMax.Size = New System.Drawing.Size(21, 16)
        Me.lbTempMax.TabIndex = 13
        Me.lbTempMax.Text = "60"
        '
        'PictureBoxTemp
        '
        Me.PictureBoxTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBoxTemp.Location = New System.Drawing.Point(18, 51)
        Me.PictureBoxTemp.Name = "PictureBoxTemp"
        Me.PictureBoxTemp.Size = New System.Drawing.Size(35, 120)
        Me.PictureBoxTemp.TabIndex = 12
        Me.PictureBoxTemp.TabStop = False
        '
        'PictureBoxTempBack
        '
        Me.PictureBoxTempBack.BackColor = System.Drawing.Color.White
        Me.PictureBoxTempBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxTempBack.Location = New System.Drawing.Point(18, 29)
        Me.PictureBoxTempBack.Name = "PictureBoxTempBack"
        Me.PictureBoxTempBack.Size = New System.Drawing.Size(35, 142)
        Me.PictureBoxTempBack.TabIndex = 11
        Me.PictureBoxTempBack.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Temperatura"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalBrick
        Me.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(9, 209)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series1.LabelBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Humedad"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(366, 307)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Chart2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalBrick
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(378, 209)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series2.LabelBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series2.Legend = "Legend1"
        Series2.Name = "Temperatura"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(367, 307)
        Me.Chart2.TabIndex = 6
        Me.Chart2.Text = "Chart2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 449)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 8
        '
        'TimerSerial
        '
        Me.TimerSerial.Enabled = True
        Me.TimerSerial.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 535)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.PanelTemp)
        Me.Controls.Add(Me.PanelHumedad)
        Me.Controls.Add(Me.PanelConexion)
        Me.Name = "Form1"
        Me.PanelConexion.ResumeLayout(False)
        Me.PanelConexion.PerformLayout()
        CType(Me.PictureBoxStatusConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHumedad.ResumeLayout(False)
        Me.PanelHumedad.PerformLayout()
        Me.PanelTemp.ResumeLayout(False)
        Me.PanelTemp.PerformLayout()
        CType(Me.PictureBoxTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTempBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btescanear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PanelConexion As Panel
    Friend WithEvents btDesconectar As Button
    Friend WithEvents btConectar As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents lbbaudrate As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents PanelHumedad As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelTemp As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Circular_Humedad As CircularProgressBar.CircularProgressBar
    Friend WithEvents lbTemp As Label
    Friend WithEvents lbTempMin As Label
    Friend WithEvents lbTempMax As Label
    Friend WithEvents PictureBoxTemp As PictureBox
    Friend WithEvents PictureBoxTempBack As PictureBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents LabelStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents PictureBoxStatusConnection As PictureBox
End Class
