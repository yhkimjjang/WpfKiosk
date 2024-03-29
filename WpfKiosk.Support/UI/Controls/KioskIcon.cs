﻿using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfKiosk.Support.Enums;

namespace WpfKiosk.Support.UI.Controls;

public class KioskIcon : ContentControl
{
    public static DependencyProperty ModeProperty = DependencyProperty.Register("Mode", typeof(IconMode), typeof(KioskIcon), new PropertyMetadata(IconMode.None));
    public static DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(IconType), typeof(KioskIcon), new PropertyMetadata(IconType.None, IconPropertyChanged));
    public static DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageType), typeof(KioskIcon), new PropertyMetadata(ImageType.None, ImagePropertyChanged));
    public static DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(KioskIcon), new PropertyMetadata(Brushes.Silver));
    public static DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(Geometry), typeof(KioskIcon), new PropertyMetadata(null));
    public static DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(KioskIcon), new PropertyMetadata(null));

    public IconMode Mode
    {
        get => (IconMode)GetValue(ModeProperty);
        set => SetValue(ModeProperty, value);
    }

    public IconType Icon
    {
        get => (IconType)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public ImageType Image
    {
        get => (ImageType)GetValue(ImageProperty); 
        set => SetValue(ImageProperty, value);
    }

    public Brush Fill
    {
        get => (Brush)GetValue(FillProperty); 
        set => SetValue(FillProperty, value);
    }

    public Geometry Data
    {
        get => (Geometry)GetValue(DataProperty); 
        set => SetValue(DataProperty, value);
    }

    public ImageSource Source
    {
        get => (ImageSource)GetValue(SourceProperty); 
        set => SetValue(SourceProperty, value);
    }

    private static void IconPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        KioskIcon icon = (KioskIcon)d;
        string geometryData = Design.Geometies.GeometryConverter.GetData(icon.Icon.ToString());

        icon.Data = Geometry.Parse(geometryData);
        icon.Mode = IconMode.Icon;
    }

    private static void ImagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        KioskIcon icon = (KioskIcon)d;
        string base64 = Design.Images.ImageConverter.GetData(icon.Image.ToString());

        byte[] binaryData = Convert.FromBase64String(base64);

        BitmapImage bi = new BitmapImage();
        bi.BeginInit();
        bi.StreamSource = new MemoryStream(binaryData);
        bi.EndInit();

        icon.Source = bi;
        icon.Mode = IconMode.Image;
    }

    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
    }

    static KioskIcon()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(KioskIcon), new FrameworkPropertyMetadata(typeof(KioskIcon)));
    }
}
