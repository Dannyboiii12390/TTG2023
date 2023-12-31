﻿using MonoGameLib.Shapes;


namespace TTG.Helpers
{
    internal static class ShapebatcherHelpers
    {

        public static void Draw(this ShapeBatcher shapeBatcher, Shape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    shapeBatcher.HelperDraw(shape as Circle);
                    break;

                case Triangle triangle:
                    shapeBatcher.HelperDrawTriangle(shape as Triangle);
                    break;

                case Line line:
                    shapeBatcher.HelperDrawLine(shape as Line);
                    break;
                case Polygon polygon:
                    shapeBatcher.HelperDrawPolygon(shape as Polygon);
                    break;
                default:
                    break;
            }
        }

        private static void HelperDraw(this ShapeBatcher shapeBatcher, Circle circle)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawCircle(circle._position, circle._radius, circle.numVertices, circle.thickness, circle._colour);
            shapeBatcher.End();
        }

        public static void HelperDrawArrow(this ShapeBatcher shapeBatcher, Circle circle)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawArrow(circle._position, circle._velocity, 2, 10, circle._colour);
            shapeBatcher.End();
        }

        private static void HelperDrawLine(this ShapeBatcher shapeBatcher, Line line)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawLine(line._position, line.end, line.thickness, line._colour);
            shapeBatcher.End();
        }
        private static void HelperDrawTriangle(this ShapeBatcher shapeBatcher, Triangle triangle)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawLine(triangle._position, triangle._position2, 2, triangle._colour);
            shapeBatcher.DrawLine(triangle._position2, triangle._position3, 2, triangle._colour);
            shapeBatcher.DrawLine(triangle._position, triangle._position3, 2, triangle._colour);
            shapeBatcher.End();

        }

        private static void HelperDrawPolygon(this ShapeBatcher shapeBatcher, Polygon polygon)
        {
            shapeBatcher.Begin();
            foreach (Triangle triangle in polygon.triangles)
            {
                shapeBatcher.DrawTriangle(triangle._position, triangle._position2, triangle._position3, polygon._colour);
                //shapeBatcher.DrawLine(triangle._position, triangle._position2, 2, polygon._colour);
                //shapeBatcher.DrawLine(triangle._position2, triangle._position3, 2, polygon._colour);
                //shapeBatcher.DrawLine(triangle._position3, triangle._position, 2, polygon._colour);

            }
            shapeBatcher.End();
        }
        public static void HelperDrawSquare(this ShapeBatcher shapeBatcher, Square square)
        {
            shapeBatcher.Draw(square.hitbox);
        }

    }

}
