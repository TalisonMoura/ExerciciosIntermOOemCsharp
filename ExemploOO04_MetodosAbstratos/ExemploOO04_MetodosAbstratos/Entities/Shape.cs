﻿using ExemploOO04_MetodosAbstratos.Entities.Enums;
namespace ExemploOO04_MetodosAbstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

       // public Shape() { }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();

    }
}
