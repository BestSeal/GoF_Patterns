using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Proxy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public Proxy proxy;
        public MainWindow()
        {
            InitializeComponent();
            proxy = new Proxy(HoleImg);
            proxy.Img.MouseRightButtonDown += Image_OnMouseRightButtonDown;
            proxy.Img.MouseLeftButtonDown += Image_OnMouseDown;
            proxy.Img.MouseLeftButtonUp += Image_OnMouseUp;
            proxy.Img.MouseMove += Image_OnMouseMove;
        }

        private void Image_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && Clipboard.ContainsImage())
            {
                proxy.Img.Source = Clipboard.GetImage();
            }
        }

        private void Image_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            proxy.Position = Mouse.GetPosition(this);
            CaptureMouse();
        }

        private void Image_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseCaptured)
            {
                var canvas = VisualTreeHelper.GetParent(this) as UIElement;
                var position = e.GetPosition(canvas);
                RenderTransform = new TranslateTransform(position.X - proxy.Position.X, position.Y - proxy.Position.Y);
            }
        }

        private void Image_OnMouseUp(object sender, MouseEventArgs e)
        {
            ReleaseMouseCapture();
        }

        public class Proxy
        {
            public Point Position { get; set; }
            public Image Img { get; set; }

            public Proxy(Image img)
            {
                Img = img;
            }
        }
    }
}