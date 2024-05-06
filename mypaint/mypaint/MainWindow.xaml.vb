Imports Microsoft.Win32
Imports System.IO

Class MainWindow
    Dim grad1 As Color
    Dim grad2 As Color

    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        If shapelabel.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = widthslider.Value
            el.Height = heightslider.Value
            el.Fill = ColorRectangle.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
        If shapelabel.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = widthslider.Value
            el.Height = heightslider.Value
            el.Fill = ColorRectangle.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
    End Sub

    Private Sub ColorRectangle_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ColorRectangle.MouseDown, color1.MouseDown, color2.MouseDown, color3.MouseDown, color4.MouseDown
        ColorRectangle.Fill = sender.fill
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveRange(1, DrawingCanvas.Children.Count)
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveAt(DrawingCanvas.Children.Count - 1)
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        shapelabel.Content = sender.content
    End Sub

    Private Sub Ellipse_Click(sender As Object, e As RoutedEventArgs) Handles Ellipse.Click
        shapelabel.Content = sender.content
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As RoutedEventArgs) Handles SaveButton.Click
        ExportToPng(DrawingCanvas)
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(DrawingCanvas, 647)

        Canvas.SetTop(DrawingCanvas, 434)

    End Sub

    Private Sub Color11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color11.MouseDown
        grad1 = Color.FromRgb(R.Value, G.Value, B.Value)
        sender.fill = New SolidColorBrush(grad1)
    End Sub

    Private Sub Color22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color22.MouseDown
        grad2 = Color.FromRgb(R.Value, G.Value, B.Value)
        sender.fill = New SolidColorBrush(grad2)
    End Sub

    Private Sub angleslider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleslider.ValueChanged
        ColorRectangle.Fill = New LinearGradientBrush(grad1, grad2, angleslider.Value)
    End Sub
    Private Sub ShapeButton_Click(sender As Object, e As RoutedEventArgs) Handles ShapeButton.Click
        Dim r As New Polygon
        Dim p As New Point
        r.Fill = ColorRectangle.Fill
        r.Points.Add(p + New Point(56 * WidthSlider.Value, 56 * WidthSlider.Value))
        r.Points.Add(p + New Point(34 * WidthSlider.Value, 34 * WidthSlider.Value))
        r.Points.Add(p + New Point(34 * WidthSlider.Value, 56 * WidthSlider.Value))
        r.Points.Add(p + New Point(56 * WidthSlider.Value, 34 * WidthSlider.Value))
        r.Points.Add(p + New Point(84 * WidthSlider.Value, 84 * WidthSlider.Value))
        r.Points.Add(p + New Point(21 * WidthSlider.Value, 21 * WidthSlider.Value))
        r.Points.Add(p + New Point(21 * WidthSlider.Value, 84 * WidthSlider.Value))
        r.Points.Add(p + New Point(84 * WidthSlider.Value, 21 * WidthSlider.Value))
        DrawingCanvas.Children.Add(r)
    End Sub
End Class
