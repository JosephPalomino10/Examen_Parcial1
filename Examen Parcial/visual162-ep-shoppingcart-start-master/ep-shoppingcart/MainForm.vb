Public Class MainForm
    Private PanelH As Boolean = True
    Private PanelM As Boolean = False
    Private PanelC As Boolean = False
    Private PanelA As Boolean = False

    Private CantHL1 As Integer = 0
    Private CantHL2 As Integer = 0
    Private CantHL3 As Integer = 0
    Private CantHL4 As Integer = 0

    Private CantML1 As Integer = 0
    Private CantML2 As Integer = 0
    Private CantML3 As Integer = 0
    Private CantML4 As Integer = 0

    Private CantCL1 As Integer = 0
    Private CantCL2 As Integer = 0
    Private CantCL3 As Integer = 0
    Private CantCL4 As Integer = 0

    Private CantAL1 As Integer = 0
    Private CantAL2 As Integer = 0
    Private CantAL3 As Integer = 0
    Private CantAL4 As Integer = 0

    Private Total As Integer = 0

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click
        ' Estado Paneles
        PanelH = True
        PanelM = False
        PanelC = False
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black


        ' Cotton Linen V-Neck Jumper
        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
        lblPrecio.Text = "$95"

        ' Talla XS
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black

        ' Talla M
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black

        ' Talla L
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black

        ' Talla XL
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Estableciendo Etiquetas Cantidades
        txtCantidad.Text = CantHL1.ToString()
        txtCantidad.Text = CantHL2.ToString()
        txtCantidad.Text = CantHL3.ToString()
        txtCantidad.Text = CantHL4.ToString()

    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        ' Estado Paneles
        PanelH = False
        PanelM = True
        PanelC = False
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black

        'Nicola Blouse
        lblTitulo.Text = "Nicola Blouse"
        lblPrecio.Text = "$120"

        ' Talla XS
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black

        ' Talla M
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black

        ' Talla L
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black

        ' Talla XL
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver
    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click
        ' Estado Paneles
        PanelH = False
        PanelM = False
        PanelC = True
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black

        'Philip 1d Trainers
        lblTitulo.Text = "Philip 1d Trainers"
        lblPrecio.Text = "$55"

        ' Talla 37
        lblTallaP1.Text = "37"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla 38
        lblTallaP2.Text = "38"
        lblTallaP2.ForeColor = Color.Black

        ' Talla 40
        lblTallaP3.Text = "40"
        lblTallaP3.ForeColor = Color.Black

        ' Talla 41
        lblTallaP4.Text = "41"
        lblTallaP4.ForeColor = Color.Black

        ' Talla 42
        lblTallaP5.Text = "42"
        lblTallaP5.ForeColor = Color.Silver
    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        ' Estado Paneles
        PanelH = False
        PanelM = False
        PanelC = False
        PanelA = True

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.SteelBlue

        'Strap Watch 1791
        lblTitulo.Text = "Strap Watch 1791"
        lblPrecio.Text = "$175"

        ' Talla XS
        lblTallaP1.Text = "-"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "-"
        lblTallaP2.ForeColor = Color.Silver

        ' Talla M
        lblTallaP3.Text = "-"
        lblTallaP3.ForeColor = Color.Silver

        ' Talla L
        lblTallaP4.Text = "-"
        lblTallaP4.ForeColor = Color.Silver

        ' Talla XL
        lblTallaP5.Text = "-"
        lblTallaP5.ForeColor = Color.Silver
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox("GRACIAS POR SU COMPRA", MsgBoxStyle.Information, "Tommy Hilfiger")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_01_normal
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_02_normal
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_03_normal
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_04_normal
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        ' Cambiando al siguiente
        Dim lblprecio As Integer = CInt(txtCantidad.Text)

        ' Verificando si la cantidad actual es nueve (suponiendo cantidad maxima: 9)
        If lblprecio = 9 Then Exit Sub

        ' Estableciendo nueva cantidad 
        lblprecio = lblprecio + 1

        ' Actualizando cantidad panel activo
        If PanelH Then CantHL1 = lblprecio
        If PanelM Then CantML1 = lblprecio
        If PanelC Then CantCL1 = lblprecio
        If PanelA Then CantAL1 = lblprecio


    End Sub
End Class