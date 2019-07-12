using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private readonly int width;
        private readonly int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public string Draw()
        {
            var sb = new StringBuilder();

            DrawLine(this.width, '*', '*', sb);

            for (int i = 1; i < this.height - 1; ++i)
            {
                DrawLine(this.width, '*', ' ', sb);
            }

            DrawLine(this.width, '*', '*', sb);

            return sb.ToString();
        }

        private void DrawLine(int width, char end, char mid, StringBuilder sb)
        {
            sb.Append(end);

            for (int i = 1; i < width - 1; ++i)
            {
                sb.Append(mid);
            }

            sb.AppendLine(end.ToString().TrimEnd());
        }
    }
}
