namespace WorldFabricCore.Core.MathCore
{
    public class Transform
    {
        protected Position position;
        protected Rotation rotation;
        protected Scale scale;
        public Transform()
        {
            position = new Position();
            rotation = new Rotation();
            scale = new Scale();
        }
        public Transform(Position position, Rotation rotation, Scale scale)
        {
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }
        public Position GetPosition()
        {
            return position;
        }
        public Rotation GetRotation()
        {
            return rotation;
        }
        public Scale GetScale()
        {
            return scale;
        }
    }
    public class Position
    {
        private double[] coordinates;
        private int countOfAxes;
        public Position()
        {
            coordinates = new double[3];
            countOfAxes = 3;
        }
        public Position(int countOfAxes)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException();
            }
            coordinates = new double[countOfAxes];
            this.countOfAxes = countOfAxes;
        }
        public Position(int countOfAxes, double[] coordinates)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException();
            }
            if (countOfAxes != coordinates.Length)
            {
                throw new Exception();
            }
            this.countOfAxes = countOfAxes;
            this.coordinates = coordinates;
        }
        public void SetCoordinates(double[] newCoordinates)
        {
            if (countOfAxes != newCoordinates.Length)
            {
                throw new Exception();
            }
            coordinates = newCoordinates;
        }
        public void SetCoordinate(int coordinateNumber, double coordinate)
        {
            if (coordinateNumber < 0 || coordinateNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            coordinates[coordinateNumber] = coordinate;
        }
        public double[] GetCoordinates()
        {
            return coordinates;
        }
        public double GetCoordinate(int coordinateNumber)
        {
            if (coordinateNumber < 0 || coordinateNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            return coordinates[coordinateNumber];
        }
        public int GetCountOfAxes()
        {
            return countOfAxes;
        }
    }
    public class Rotation
    {
        private double[] rotations;
        private int countOfAxes;
        public Rotation()
        {
            rotations = new double[3];
            countOfAxes = 3;
        }
        public Rotation(int countOfAxes)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException();
            }
            rotations = new double[countOfAxes];
            this.countOfAxes = countOfAxes;
        }
        public Rotation(int countOfAxes, double[] rotations)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException();
            }
            if (countOfAxes != rotations.Length)
            {
                throw new Exception();
            }
            this.countOfAxes = countOfAxes;
            this.rotations = rotations;
        }
        public void SetRotations(double[] newRotations)
        {
            if (countOfAxes != newRotations.Length)
            {
                throw new Exception();
            }
            rotations = newRotations;
        }
        public void SetRotation(int rotationNumber, double rotation)
        {
            if (rotationNumber < 0 || rotationNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            rotations[rotationNumber] = rotation;
        }
        public double[] GetRotations()
        {
            return rotations;
        }
        public double GetRotation(int rotationNumber)
        {
            if (rotationNumber < 0 || rotationNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            return rotations[rotationNumber];
        }
        public int GetCountOfAxes()
        {
            return countOfAxes;
        }
    }
    public class Scale
    {
        private double[] scales;
        private int countOfAxes;
        public Scale()
        {
            scales = new double[3];
            countOfAxes = 3;
        }
        public Scale(int countOfAxes)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException();
            }
            scales = new double[countOfAxes];
            this.countOfAxes = countOfAxes;
        }
        public Scale(int countOfAxes, double[] scales)
        {
            if (countOfAxes < 1)
            {
                throw new ArgumentException();
            }
            if (countOfAxes != scales.Length)
            {
                throw new Exception();
            }
            this.countOfAxes = countOfAxes;
            this.scales = scales;
        }
        public void SetScales(double[] newScales)
        {
            if (countOfAxes != newScales.Length)
            {
                throw new Exception();
            }
            scales = newScales;
        }
        public void SetScale(int scaleNumber, double scale)
        {
            if (scaleNumber < 0 || scaleNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            scales[scaleNumber] = scale;
        }
        public double[] GetScales()
        {
            return scales;
        }
        public double GetScale(int scaleNumber)
        {
            if (scaleNumber < 0 || scaleNumber >= countOfAxes)
            {
                throw new IndexOutOfRangeException();
            }
            return scales[scaleNumber];
        }
        public int GetCountOfAxes()
        {
            return countOfAxes;
        }
    }
}
