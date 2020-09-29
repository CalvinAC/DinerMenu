'Calvin Coxen
'RCET0265
'Spring 2020
'Diner Menu Program
'https://github.com/CalvinAC/DinerMenu


Public Class DinerMenuForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Displays writen text when the button is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Pizza_1.Click
        MenuItems.Text = "The original flavor of pizza, cheese! "
        PictureBox1.Hide()

    End Sub

    'Displays writen text when the button is clicked
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Pizza_2.Click
        MenuItems.Text = "For anyone still unsure about the truth, pineapple does NOT belong
on pizza. Don't order this"
        PictureBox1.Hide()

    End Sub

    'Displays writen text when the button is clicked
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Pizza_3.Click
        MenuItems.Text = "EXTRA ULTRA ULTIMATE MAN EATERS MEEEEET LOVERS HEART ATTACK-ON-BREAD PIZZA. EVERY SLICE CLOGS YOUR ARTERYS. Made only for true chicagoans."
        PictureBox1.Hide()

    End Sub

    'Displays writen text and saved image when the button is clicked. 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Pizza_4.Click
        MenuItems.Text = "It's Pizza Time!"

        PictureBox1.BackgroundImage = My.Resources.pizza_time
        PictureBox1.Show()

    End Sub

    'Displays writen text when the button is clicked
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Pizza_5.Click
        MenuItems.Text = "A custom pie made to order. Have it any style, deepdish, hand tossed, thin crust, you name it!
Any and all toppings allowed (barring pineapple for obvious reasons). This pie will take you to flavor town."
        PictureBox1.Hide()

    End Sub

    'Closes program
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Exit_1.Click
        Me.Close()
    End Sub
End Class
