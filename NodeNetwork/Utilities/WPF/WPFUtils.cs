﻿using Avalonia;
using System.Collections.Generic;
using System.Linq;

namespace NodeNetwork.Views.Controls
{
    public static class WPFUtils
    {
        public static T FindParent<T>(AvaloniaObject childObject) where T : AvaloniaObject
        {
            AvaloniaObject curObj = childObject;
            do
            {
                curObj = VisualTreeHelper.GetParent(curObj);
                if (curObj == null) return default(T);
            } while (!(curObj is T));
            return (T)curObj;
        }

        public static IEnumerable<Point> GetIntersectionPoints(Geometry g1, Geometry g2)
        {
            Geometry og1 = g1.GetWidenedPathGeometry(new Pen(Brushes.Black, 1.0));
            Geometry og2 = g2.GetWidenedPathGeometry(new Pen(Brushes.Black, 1.0));

            CombinedGeometry cg = new CombinedGeometry(GeometryCombineMode.Intersect, og1, og2);

            PathGeometry pg = cg.GetFlattenedPathGeometry();
            foreach (PathFigure figure in pg.Figures)
            {
                Rect fig = new PathGeometry(new[] { figure }).Bounds;
                yield return new Point(fig.Left + fig.Width / 2.0, fig.Top + fig.Height / 2.0);
            }
        }

        public static IEnumerable<T> FindDescendantsOfType<T>(AvaloniaObject root, bool skipChildrenOnHit) where T : AvaloniaObject
        {
            int childCount = VisualTreeHelper.GetChildrenCount(root);
            for (int i = 0; i < childCount; i++)
            {
                var obj = VisualTreeHelper.GetChild(root, i);
                if (obj is T t)
                {
                    yield return t;

                    if (skipChildrenOnHit)
                    {
                        continue;
                    }
                }

                foreach (var subChild in FindDescendantsOfType<T>(obj, skipChildrenOnHit))
                {
                    yield return subChild;
                }
            }
        }
    }
}
