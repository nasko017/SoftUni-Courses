
namespace ClassBoxData
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (IsZeroOrNegetive(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMesseges.CannotBeZeroOrNegetive, nameof(this.Length)));
                }
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (IsZeroOrNegetive(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMesseges.CannotBeZeroOrNegetive, nameof(Width)));
                }
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (IsZeroOrNegetive(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMesseges.CannotBeZeroOrNegetive, nameof(this.Height)));
                }
                height = value;
            }
        }

        private double SurfaceArea()
        {
            return 2 * (Length * Width) + 2 * (Length * Height) + 2 * (Height * Width);
        }

        private double LateralSurfaceArea()
        {
            return 2 * (Length * Height) + 2 * (Width * Height);
        }

        private double Volume()
        {
            return Length * Width * Height;
        }

        private bool IsZeroOrNegetive(double value)
        {
            if (value <= 0)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().TrimEnd();
        }

    }

}
