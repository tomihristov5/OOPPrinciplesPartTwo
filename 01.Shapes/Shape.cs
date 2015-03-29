namespace _01.Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentOutOfRangeException("Both width ana height must be possitive");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentOutOfRangeException("Both width ana height must be possitive");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
