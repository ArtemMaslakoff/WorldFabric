namespace WorldFabricCore.Core.MathCore
{
    public class Transform
    {
        protected Position position;
        protected Rotation rotation;
        protected Scale scale;
        protected int countOfAxes;
        public Transform()
        {
            countOfAxes = 3;
            position = new Position(countOfAxes);
            rotation = new Rotation(countOfAxes);
            scale = new Scale(countOfAxes);
        }
        public Transform(Position position, Rotation rotation, Scale scale)
        {
            if (position.GetCountOfAxes() == rotation.GetCountOfAxes() && position.GetCountOfAxes() == scale.GetCountOfAxes())
            {
                countOfAxes = position.GetCountOfAxes();
                this.position = new Position(countOfAxes);
                this.rotation = new Rotation(countOfAxes);
                this.scale = new Scale(countOfAxes);
                for (int i = 0; i < countOfAxes; i++)
                {
                    this.position.SetCoordinate(i, position.GetCoordinate(i));
                    this.rotation.SetRotation(i, rotation.GetRotation(i));
                    this.scale.SetScale(i, scale.GetScale(i));
                }
            }
            else
            {
                throw new ArgumentException();
            }
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
        public void Translate(Vector vector)
        {
            if (vector.GetCountOfAxes() != countOfAxes)
            {
                throw new ArgumentException();
            }
            position.Translate(vector);
        }
        public void Rotate(Vector vector)
        {
            if (vector.GetCountOfAxes() != countOfAxes)
            {
                throw new ArgumentException();
            }
            rotation.Rotate(vector);
        }
        public void Scale(Vector vector)
        {
            if (vector.GetCountOfAxes() != countOfAxes)
            {
                throw new ArgumentException();
            }
            scale.LocalScale(vector);
        }
        public override string ToString()
        {
            string result = "Transform: \n";
            result += "\tCount of axes: " + countOfAxes + "\n";
            result += "\t" + position.ToString() + "\n";
            result += "\t" + rotation.ToString() + "\n";
            result += "\t" + scale.ToString();
            return result;
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
        public void Translate(Vector vector)
        {
            if (vector.GetCountOfAxes() != countOfAxes)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < countOfAxes; i++)
            {
                coordinates[i] += vector.GetProjection(i);
            }
        }
        public Vector ToVector()
        {
            return new Vector(countOfAxes, coordinates);
        }
        public override string ToString()
        {
            string result = "Position: ( ";
            for (int i = 0; i < countOfAxes; i++)
            {
                result += coordinates[i].ToString() + " ";
            }
            return result + ")";
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
        public void Rotate(Vector vector)
        {
            if (vector.GetCountOfAxes() != countOfAxes)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < countOfAxes; i++)
            {
                rotations[i] += vector.GetProjection(i);
            }
        }
        public Vector ToVector()
        {
            return new Vector(countOfAxes, rotations);
        }
        public override string ToString()
        {
            string result = "Rotation: ( ";
            for (int i = 0; i < countOfAxes; i++)
            {
                result += rotations[i].ToString() + " ";
            }
            return result + ")";
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
        public void LocalScale(Vector vector)
        {
            if (vector.GetCountOfAxes() != countOfAxes)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < countOfAxes; i++)
            {
                scales[i] += vector.GetProjection(i);
            }
        }
        public Vector ToVector()
        {
            return new Vector(countOfAxes, scales);
        }
        public override string ToString()
        {
            string result = "Scale: ( ";
            for (int i = 0; i < countOfAxes; i++)
            {
                result += scales[i].ToString() + " ";
            }
            return result + ")";
        }
    }
}