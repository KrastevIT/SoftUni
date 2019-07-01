namespace PointInRectangle
{
    public class Rectangle
    {

        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public Rectangle(Point topleft, Point bottomRRight)
        {
            TopLeft = topleft;
            BottomRight = bottomRRight;
        }

        public bool Contains(Point poin)
        {
            bool insideByX = poin.X >= TopLeft.X && poin.X <= BottomRight.X;

            bool insideByY = poin.Y >= TopLeft.Y && poin.Y <= BottomRight.Y;

            return insideByX && insideByY;
        }
    }
}
