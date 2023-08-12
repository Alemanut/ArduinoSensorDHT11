Public Class Form1
    'Declaracion de Variables 
    Dim vpb_sy, vpb_ly As Integer
    Dim TempL, HumL As Integer
    Dim Temp, Hum, TempResult, HumResult As String
    Dim TempToProgressBar As Single
    Dim ChartLimit As Integer = 30
    Dim StrSerialIn, StrSerialInRam As String

    Private Sub ComboBoxPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
        'Establece el foco de entrada en el control (PanelConexion)
        PanelConexion.Focus()
    End Sub

    Private Sub btescanear_Click(sender As Object, e As EventArgs) Handles btescanear.Click
        'Al hacer click sobre el boton de escanear se realizara lo sig.
        PanelConexion.Focus()
        'Si LabelStatus es = connected entonces mandara el siguiente mensaje
        If LabelStatus.Text = "Status : Connected" Then
            'Mensaje que se mandara cuando labelsatutus sea = connected
            MsgBox("Conncetion in progress, please Disconnect to scan the new port.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If ' Fin de la estructura
        ComboBoxPort.Items.Clear() ' Se limpiara la combobox
        Dim myPort As Array 'Declaramos myPort como un Array
        Dim i As Integer 'Declaramos i como un  entero
        myPort = IO.Ports.SerialPort.GetPortNames() 'Con esto obtenemos los nombres de los puertos serie del equipo
        ComboBoxPort.Items.AddRange(myPort) 'Agregramos los elementos de la combobox  a myPort
        i = ComboBoxPort.Items.Count 'i = a los items de la combobox
        i = i - i ' Se realiza una operacion con la variable i
        Try
            ComboBoxPort.SelectedIndex = i ' i sera igual al indice seleccionado de la combobox
            btConectar.Enabled = True ' Si el btconectar puede responder a la interaccion con el usario sera verdadero
        Catch ex As Exception ' ex representa los errores que se producen durante la ejecucion
            'Si hay un error de conexion con el puerto se enviara el sig. mensaje:
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = "" '
            ComboBoxPort.Items.Clear() 'Limpia el comboBoxPort
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen() ' Sirve para central el formulario
        PanelConexion.Focus() 'Establece el foco de entrada en el Panel 
        Circular_Humedad.Value = 0 ' Le asignamos el valor de 0 a la grafica de pastel
        ComboBoxBaudRate.SelectedIndex = 0S 'Le asiganamos el valor de 0s al ComboBoxBaudRate
        For i = 0 To 30 Step 1 'Para i = a 0 a 30, paso 1
            Chart1.Series("Humedad").Points.AddY(0) 'Anadimos el punto Y de la grafica Humedad
            If Chart1.Series(0).Points.Count = ChartLimit Then '
                Chart1.Series(0).Points.RemoveAt(0)
            End If
            Chart2.Series("Temperatura").Points.AddY(0) 'Anadimos el punto Y de la grafica Humedad
            If Chart2.Series(0).Points.Count = ChartLimit Then
                Chart2.Series(0).Points.RemoveAt(0)
            End If
        Next
        Chart1.ChartAreas(0).AxisY.Maximum = 180 'Valores maximos del Eje principal de la grafica 1
        Chart1.ChartAreas(0).AxisY.Minimum = -20 'Valores maximos del Eje principal de la grafica 1
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False '
        Chart2.ChartAreas(0).AxisY.Maximum = 70 'Valores maximos del Eje principal de la grafica 2
        Chart2.ChartAreas(0).AxisY.Minimum = -30 'Valores maximos del Eje principal de la grafica 2
        Chart2.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        PictureBoxTempBack.Height = 0 'Control de pixeles de la TemBack 
    End Sub

    Private Sub ComboBoxPort_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPort.DropDown
        PanelConexion.Focus() 'Establece el foco de entrada en el Panel 
    End Sub
    Private Sub ComboBoxPort_Click(sender As Object, e As EventArgs) Handles ComboBoxPort.Click

        If LabelStatus.Text = "Status : Connected" Then 'Si la LabelStatus esta conectada entonces
            'Se enviara el sig. mensaje
            MsgBox("Conncetion in progress, please Disconnect to change COM.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub
    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting '--> Leer datos seriales entrantes
            Dim TB As New TextBox ' Declara TB como una nueva TextBox
            TB.Multiline = True 'TB multilinea como verdadero
            TB.Text = StrSerialIn '--> Ingrese los datos seriales en el cuadro de texto
            If TB.Lines.Count > 0 Then 'Si los elementos de TB son mayor a 0 entonces 
                If TB.Lines(0) = "Failed to read from DHT sensor!" Then '--> Compruebe la conexion del sensor
                    'Arduino si no puede leer el sensor DHT, si esto sucede, la conexión se desconecta
                    TimerSerial.Stop() ' Se detiene el TimerSerial
                    SerialPort1.Close() 'Se cierra el SerialPort
                    LabelStatus.Text = "Status : Disconnect" 'Se muestra  "Disconnected" en la label
                    btDesconectar.SendToBack() 'Envia al control del boton desconectar al final
                    btConectar.BringToFront() 'Envia al control del boton conectar al inicio
                    PictureBoxStatusConnection.Visible = True 'La picture sera visible
                    PictureBoxStatusConnection.BackColor = Color.Red 'La picturebox se mostrara de color rojo
                    'Se mostrara el sig.  mensaje de advertencia:
                    MsgBox("Failed to read from DHT sensor !!!, Please check the Hardware and Please connect again.", MsgBoxStyle.Critical, "Connection failed !!!")
                    Return
                End If

                StrSerialInRam = TB.Lines(0).Substring(0, 1)
                If StrSerialInRam = "H" Then
                    Hum = TB.Lines(0)
                    HumL = Hum.Length
                Else
                    Hum = Hum
                End If
                StrSerialInRam = TB.Lines(1).Substring(0, 1)
                If StrSerialInRam = "T" Then
                    Temp = TB.Lines(1)
                    TempL = Temp.Length
                Else
                    Temp = Temp
                End If
                HumResult = Mid(Hum, 2, HumL)
                TempResult = Mid(Temp, 2, TempL)
                TempToProgressBar = TempResult 'Valor de la barra de progreso de la temperatura
                Circular_Humedad.Value = HumResult 'Valor de la grafica circular sibre la humedad
                Circular_Humedad.Text = Circular_Humedad.Value & " %" 'Valor de Humedad mas el signo %
                lbTemp.Text = TempResult & " °C" 'Valor de la temperatura contatenado con el simbolo de grados Celsius
                'El proceso para hacer una barra de progreso usando un cuadro de imagen(barra de progreso vertical) -  
                vpb_sy = MapVPB(TempToProgressBar, -20.0, 60.0, 0, 120) 'Mapeo de la barra de progreso
                If vpb_sy > 120 Then 'Si la barra de progreso es mayor a 120 entonces
                    vpb_sy = 120 'Barra igual a 120
                End If
                If vpb_sy < 0 Then 'Si la barra de progreso es mayor a 0 entonces
                    vpb_sy = 0 'Barra igual a 0
                End If
                'Operacion para obtener el valor de la barra de progreso o PictureBoxTempBack
                PictureBoxTempBack.Height = PictureBoxTempBack.Height * vpb_sy / 120
                vpb_ly = (PictureBoxTempBack.Height - vpb_sy) +
                PictureBoxTempBack.Location.Y 'Localizacion del eje Y de la barra dentro del formulario
                PictureBoxTempBack.Location = New Point(PictureBoxTempBack.Location.X, vpb_ly) ' Creamos un nuevo punto de localizacion
                '-----------Introduce los valores de temperatura y humedad en el gráfico----------------------------------
                Chart1.Series("Humedad").Points.AddY(HumResult) 'Valor de humedad mostrado en la grafica 
                If Chart1.Series(0).Points.Count = ChartLimit Then 'Se estable el limite que tendra la grafica
                    Chart1.Series(0).Points.RemoveAt(0)
                End If
                'Chart2.Series("Temperatura").Points.AddY(TempResult)
                If Chart2.Series(0).Points.Count = ChartLimit Then 'Se estable el limite que tendra la grafica
                    Chart2.Series(0).Points.RemoveAt(0)
                End If
                '-Si la conexión Then es exitosa y se está ejecutando, PictureBoxStatusConnection parpadeará -
                If PictureBoxStatusConnection.Visible = True Then
                    PictureBoxStatusConnection.Visible = False
                ElseIf PictureBoxStatusConnection.Visible = False Then
                    PictureBoxStatusConnection.Visible = True
                End If
            End If
        Catch ex As Exception
            TimerSerial.Stop() 'Se detiene el Timer
            SerialPort1.Close() 'Se cierra el Puerto Serial
            LabelStatus.Text = "Status : Disconnect" 'Se muestra "Disconnected" en la LabelStatus
            btDesconectar.SendToBack() 'Envia el control al final del orden 
            btConectar.BringToFront() 'Envia el control al inicio del orden 
            PictureBoxStatusConnection.BackColor = Color.Red 'Cambia el color de la picturebox a rojo
            'Se muestra el siguiente mensaje:
            MsgBox("Please check the Hardware and Please connect again." & ex.Message, MsgBoxStyle.Critical, "Connection failed !!!")
            Return
        End Try
    End Sub
    Private Sub ComboBoxPort_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
    End Sub
    Private Sub ComboBoxBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.SelectedIndexChanged
        PanelConexion.Focus() 'Establece el foco de entrada en el Panel 
    End Sub
    Private Sub ComboBoxBaudRate_DropDown(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.DropDown
        PanelConexion.Focus() 'Establece el foco de entrada en el Panel 
    End Sub
    Private Sub ComboBoxBaudRate_Click(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.Click
        'Si la LabelStatus esta conectada entonces
        If LabelStatus.Text = "Status : Connected" Then
            'Se muestra el sig. mensaje:
            MsgBox("Conncetion in progress, please Disconnect to change Baud Rate.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub
    Private Sub btConectar_Click(sender As Object, e As EventArgs) Handles btConectar.Click
        PanelConexion.Focus() 'Establece el foco de entrada en el Panel 
        Try
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem 'El BaudRate del Serialport1 sera el seleccionado en la combobox
            SerialPort1.PortName = ComboBoxPort.SelectedItem 'El puerto del serialPort1 sera el seleccionado de la combobox
            SerialPort1.Open() 'Abre el puerto serial 
            TimerSerial.Start() 'Inicia el TimerSerial
            LabelStatus.Text = "Status : Connected" 'Label status se muestra : Connected
            btConectar.SendToBack() 'Envia al control al final del orden
            btDesconectar.BringToFront() 'Envia al control al inicio del orden
            PictureBoxStatusConnection.BackColor = Color.Green 'La picturebox se mostrara de color verde
        Catch ex As Exception
            'Se mostrara el sig. mensaje:
            MsgBox("Please check the Hardware, COM, Baud Rate and try again.", MsgBoxStyle.Critical, "Connection failed !!!")
        End Try
    End Sub
    Private Sub btDesconectar_Click(sender As Object, e As EventArgs) Handles btDesconectar.Click
        'Al presionar el boton desconectar                               
        PanelConexion.Focus() 'Establece el foco de entrada en el Panel 
        TimerSerial.Stop() 'Se para el timer
        SerialPort1.Close() 'Se cierra el puerto serial
        btDesconectar.SendToBack() 'Envia al control al final del orden
        btConectar.BringToFront() 'Envia al control al incio del orden
        LabelStatus.Text = "Status : Disconnect" 'Se mostrara "Disconnected" en la label
        PictureBoxStatusConnection.Visible = True 'La pictureBox sera visible
        PictureBoxStatusConnection.BackColor = Color.Red 'La picturebox se mostrara de color rojo
    End Sub
    'Funcion MapVPB, declaracion de variables y parametros como single
    Function MapVPB(ByVal X As Single, ByVal In_min As Single, ByVal In_max As Single, ByVal Out_min As Single, ByVal Out_max As Single) As Integer
        Dim A As Single 'Declacraracion de la variable A como single
        Dim B As Single 'Declacraracion de la variable B como single
        'Operaciones entre variables locales y parametros
        A = X - In_min
        B = Out_max - Out_min
        A = A * B
        B = In_max - In_min
        A = A / B
        MapVPB = A + Out_min
    End Function
End Class
