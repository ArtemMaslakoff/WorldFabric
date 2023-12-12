using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFabricCore.Core.ParameterCore
{
    public abstract class Value
    {
        protected Parameter parameter;
        public Value()
        {
            parameter = new Parameter();
        }
        public Value(Parameter parameter)
        {
            this.parameter = parameter;
        }
        public abstract string GetStringValue();
        public abstract double GetNumericValue();
        public abstract bool GetBoolValue();
        public abstract void SetStringValue(string value);
        public abstract void SetNumericValue(double value);
        public abstract void SetBoolValue(bool value);
    }
    public class StringValue : Value
    {
        private string value;
        public StringValue() : base()
        {
            this.value = "";
        }
        public StringValue(string value) : base()
        {
            this.value = value;
        }
        public StringValue(Parameter parameter) : base(parameter)
        {
            value = "";
        }
        public StringValue(Parameter parameter, string value) : base(parameter)
        {
            this.value = value;
        }
        public override bool GetBoolValue()
        {
            throw new NotImplementedException();
        }
        public override double GetNumericValue()
        {
            throw new NotImplementedException();
        }
        public override string GetStringValue()
        {
            return value;
        }
        public override void SetBoolValue(bool value)
        {
            throw new NotImplementedException();
        }
        public override void SetNumericValue(double value)
        {
            throw new NotImplementedException();
        }
        public override void SetStringValue(string value)
        {
            this.value = value;
        }
    }
    public class NumericValue : Value
    {
        private double value;
        public NumericValue() : base()
        {
            this.value = 0;
        }
        public NumericValue(double value) : base()
        {
            this.value = value;
        }
        public NumericValue(Parameter parameter) : base(parameter)
        {
            value = 0;
        }
        public NumericValue(Parameter parameter, double value) : base(parameter)
        {
            this.value = value;
        }
        public override bool GetBoolValue()
        {
            throw new NotImplementedException();
        }
        public override double GetNumericValue()
        {
            return value;
        }
        public override string GetStringValue()
        {
            throw new NotImplementedException();
        }
        public override void SetBoolValue(bool value)
        {
            throw new NotImplementedException();
        }
        public override void SetNumericValue(double value)
        {
            this.value = value;
        }
        public override void SetStringValue(string value)
        {
            throw new NotImplementedException();
        }
    }
    public class BoolValue : Value
    {
        private bool value;
        public BoolValue() : base()
        {
            this.value = false;
        }
        public BoolValue(bool value) : base()
        {
            this.value = value;
        }
        public BoolValue(Parameter parameter) : base(parameter)
        {
            value = false;
        }
        public BoolValue(Parameter parameter, bool value) : base(parameter)
        {
            this.value = value;
        }
        public override bool GetBoolValue()
        {
            return value;
        }
        public override double GetNumericValue()
        {
            throw new NotImplementedException();
        }
        public override string GetStringValue()
        {
            throw new NotImplementedException();
        }
        public override void SetBoolValue(bool value)
        {
            this.value = value;
        }
        public override void SetNumericValue(double value)
        {
            throw new NotImplementedException();
        }
        public override void SetStringValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
