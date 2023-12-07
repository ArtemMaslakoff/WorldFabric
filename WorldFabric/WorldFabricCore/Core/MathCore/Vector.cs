namespace WorldFabricCore.Core.MathCore
{
    public class Vector
    {
        private double[] projections;
        private int countOfAxes;
        public Vector()
        {
            projections = new double[3];
            countOfAxes = 3;
        }
        public Vector(int countOfAxes)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException("Count of axes can be only > 0");
            }
            projections = new double[countOfAxes];
            this.countOfAxes = countOfAxes;
        }
        public Vector(int countOfAxes, double[] projections)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException("Count of axes can be only > 0");
            }
            if (countOfAxes != projections.Length)
            {
                throw new Exception();
            }
            this.projections = projections;
            this.countOfAxes = countOfAxes;
        }
        public void SetProjections(double[] newProjections)
        {
            if (countOfAxes != newProjections.Length)
            {
                throw new Exception();
            }
            projections = newProjections;
        }
        public void SetProjection(int projectionNumber, double projection)
        {
            if (projectionNumber < 0 || projectionNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            projections[projectionNumber] = projection;
        }
        public double[] GetProjections()
        {
            return projections;
        }
        public double GetProjection(int projectionNumber)
        {
            if (projectionNumber < 0 || projectionNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            return projections[projectionNumber];
        }
        public int GetCountOfAxes()
        {
            return countOfAxes;
        }
        public Vector Clone()
        {
            return new Vector(countOfAxes, projections);
        }
        public double Length()
        {
            double result = 0;
            foreach (var projection in projections)
            {
                result += Math.Pow(projection, 2);
            }
            return Math.Sqrt(result);
        }
        public override string ToString()
        {
            string result = "( ";
            for (int i = 0; i < countOfAxes; i++)
            {
                result += projections[i].ToString() + " ";
            }
            return result + ")";
        }
        public override bool Equals(object? other)
        {
            if (other is not Vector)
            {
                return false;
            }
            if (countOfAxes != ((Vector)other).countOfAxes || other == null)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            for (int i = 0; i < countOfAxes; i++)
            {
                if (projections[i] != ((Vector)other).projections[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            return countOfAxes;
        }
        public static Vector operator +(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            double[] resultProjection = new double[firstVector.countOfAxes];
            for (int i = 0; i < firstVector.countOfAxes; i++)
            {
                resultProjection[i] = firstVector.GetProjection(i) + secondVector.GetProjection(i);
            }
            return new Vector(firstVector.countOfAxes, resultProjection);
        }
        public static Vector operator -(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            double[] resultProjection = new double[firstVector.countOfAxes];
            for (int i = 0; i < firstVector.countOfAxes; i++)
            {
                resultProjection[i] = firstVector.GetProjection(i) - secondVector.GetProjection(i);
            }
            return new Vector(firstVector.countOfAxes, resultProjection);
        }
        public static bool operator ==(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            return firstVector.Length() == secondVector.Length();
        }
        public static bool operator !=(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            return firstVector.Length() != secondVector.Length();
        }
        public static bool operator <(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            return firstVector.Length() < secondVector.Length();
        }
        public static bool operator >(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            return firstVector.Length() > secondVector.Length();
        }
        public static bool operator <=(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            return firstVector.Length() <= secondVector.Length();
        }
        public static bool operator >=(Vector firstVector, Vector secondVector)
        {
            if (firstVector.countOfAxes != secondVector.countOfAxes)
            {
                throw new ArgumentException("Count of axes in Vectors must be equal");
            }
            return firstVector.Length() >= secondVector.Length();
        }
    }
}