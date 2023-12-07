using WorldFabricCore.Core.MathCore;

namespace WorldFabricCore.DiscreteWorldCore.DiscreteMathCore
{
    public class DiscreteTransform : Transform
    {
        private FilterType filterType;
        public DiscreteTransform() : base()
        {
            filterType = FilterType.MATH;
        }
        public DiscreteTransform(FilterType filterType) : base()
        {
            this.filterType = filterType;
        }
        public DiscreteTransform(Position position, Rotation rotation, Scale scale)
        {
            if (position.GetCountOfAxes() == rotation.GetCountOfAxes() && position.GetCountOfAxes() == scale.GetCountOfAxes())
            {
                filterType = FilterType.MATH;
                countOfAxes = position.GetCountOfAxes();
                this.position = new Position(countOfAxes);
                this.rotation = new Rotation(countOfAxes);
                this.scale = new Scale(countOfAxes);
                for (int i = 0; i < countOfAxes; i++)
                {
                    this.position.SetCoordinate(i, Filter(position.GetCoordinate(i)));
                    this.rotation.SetRotation(i, Filter(rotation.GetRotation(i)));
                    this.scale.SetScale(i, Filter(scale.GetScale(i)));
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public DiscreteTransform(Position position, Rotation rotation, Scale scale, FilterType filterType)
        {
            if (position.GetCountOfAxes() == rotation.GetCountOfAxes() && position.GetCountOfAxes() == scale.GetCountOfAxes())
            {
                this.filterType = filterType;
                countOfAxes = position.GetCountOfAxes();
                this.position = new Position(countOfAxes);
                this.rotation = new Rotation(countOfAxes);
                this.scale = new Scale(countOfAxes);
                for (int i = 0; i < countOfAxes; i++)
                {
                    this.position.SetCoordinate(i, Filter(position.GetCoordinate(i)));
                    this.rotation.SetRotation(i, Filter(rotation.GetRotation(i)));
                    this.scale.SetScale(i, Filter(scale.GetScale(i)));
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public FilterType GetFilterType()
        {
            return filterType;
        }
        public void SetFilterType(FilterType filterType)
        {
            this.filterType = filterType;
        }
        private double Filter(double number)
        {
            double result = 0;
            switch (filterType)
            {
                case FilterType.MATH:
                    result = Math.Round(number);
                    break;
                case FilterType.UP:
                    break;
                case FilterType.DOWN:
                    break;
            }
            return result;
        }
        public enum FilterType
        {
            MATH,
            UP,
            DOWN
        }
    }
}