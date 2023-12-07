namespace WorldFabricCore.Core.ParameterCore
{
    public struct Parameter
    {
        private string parameterName;
        public Parameter()
        {
            parameterName = "CommonParameter";
            ParameterLibrary.AddParameter(this);
        }
        public Parameter(string name)
        {
            parameterName = name;
            ParameterLibrary.AddParameter(this);
        }
        public string GetName()
        {
            return parameterName;
        }
        public override string ToString()
        {
            return "Parameter: " + parameterName;
        }
        public enum ParameterType
        {
            NUMERIC,
            STRING,
            BOOL
        }
    }
    public static class ParameterLibrary
    {
        private static List<Parameter> parameters = new List<Parameter>();
        public static void AddParameter(Parameter newParameter)
        {
            if (!parameters.Contains(newParameter))
            {
                parameters.Add(newParameter);
            }
        }
        public static void RemoveParameter(Parameter removableParameter)
        {
            parameters.Remove(removableParameter);
        }
        public static void ClearParameters()
        {
            parameters = new List<Parameter>();
        }
        public static Parameter GetParameter(string parameterName)
        {
            foreach (Parameter parameter in parameters)
            {
                if (parameter.GetName() == parameterName)
                {
                    return parameter;
                }
            }
            throw new Exception("Not found tag exception");
        }
        public static List<Parameter> GetParameterList()
        {
            return new List<Parameter>(parameters);
        }
        public static bool Contains(Parameter parameter)
        {
            if (parameters.Contains(parameter))
            {
                return true;
            }
            return false;
        }
        public static bool Contains(string parameterName)
        {
            foreach (Parameter parameter in parameters)
            {
                if (parameter.GetName() == parameterName)
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToString()
        {
            string result = "ParameterLibrary:\n";
            foreach (Parameter parameter in parameters)
            {
                result += parameter.ToString() + "\n";
            }
            return result;
        }
    }
}
