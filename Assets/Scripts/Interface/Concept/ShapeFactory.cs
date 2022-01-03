using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShapeFactory
{

    //use getShape method to get object of type shape 
    public Shape getShape(string shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }
        if (String.Compare(shapeType, "CIRCLE", true) == 0)
        {
            return new Circle();

        }
        else if (String.Compare(shapeType, "RECTANGLE", true) == 0)
        {
            return new Rectangle();

        }
        else if (String.Compare(shapeType, "SQUARE", true) == 0)
        {
            return new Square();
        }

        return null;
    }
}
