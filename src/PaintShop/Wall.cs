﻿namespace PaintShop;

// 1 - Crie uma classe Wall
public class Wall
{
    double _width;
    public double Width {
        get { return _width; }
        set { if (value > 0) {
            _width = value;
            } else { _width = 1; }
        }
    }
    double _height;
    public double Height
    {
        get { return _height; }
        set
        {
            if (value > 0)
            {
                _height = value;
            }
            else { _height = 1; }
        }
    }
    public double ExcludedArea { get; set; }
    public double PaintableArea { get { return Height * Width - ExcludedArea; } }
    public Wall(double width, double height)
    {
        Width = width;
        Height = height;
    }
}