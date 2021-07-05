using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Proxy
{
    public partial class MainWindow : Window
    {
        private Point _imageClickPosition;
        private Point _borderClickPosition;

        private readonly Proxy _proxy;
        
        public MainWindow()
        {
            InitializeComponent();
            _proxy = new Proxy(ProxyImage, ImageBorder);
        }

        private void ProxyImage_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _proxy.MousePos = Mouse.GetPosition(ProxyImage);
            if (_proxy.Img.IsMouseCaptured)
            {
                _proxy.ImageBorder.BorderBrush = Brushes.White;;
                _proxy.Img.ReleaseMouseCapture();
            }
            else
            {
                _proxy.ImageBorder.BorderBrush = Brushes.Black;
                Mouse.Capture(_proxy.Img, CaptureMode.SubTree); 
            }
        }

        private void ProxyImage_OnMouseMove(object sender, MouseEventArgs e)
        {               
            var mousePoint = Mouse.GetPosition(MainCanvas);
            if (_proxy.Img.IsMouseCaptured)
            {
                _proxy.Transform(mousePoint);
            }
        }

        private void ProxyImage_OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && Clipboard.ContainsImage())
            {
                _proxy.Source = Clipboard.GetImage();
            }
        }
        
        public class Proxy
        {
            public Point MousePos { get; set; }
            public Image Img { get; }
            public Border ImageBorder { get; }

            public ImageSource Source
            {
                set => Img.Source = value;
            }

            public void Transform(Point point)
            {
                Img.LayoutTransform = new TranslateTransform(point.X - MousePos.X, point.Y - MousePos.Y);
                ImageBorder.RenderTransform = new TranslateTransform(point.X - MousePos.X, point.Y - MousePos.Y);
            }

            public Proxy(Image img, Border border)
            {
                Img = img;
                ImageBorder = border;
            }
        }
    }
}