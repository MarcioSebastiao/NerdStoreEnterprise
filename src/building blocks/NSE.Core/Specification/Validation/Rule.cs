namespace NSE.Core.Specification.Validation
{
    public class Rule<T>
    {
        private readonly Specification<T> _specificationSpec;

        public Rule(Specification<T> specificationSpec, string errorMessage)
        {
            _specificationSpec = specificationSpec;
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }

        public bool Validate(T obj)
        {
            return _specificationSpec.IsSatisfiedBy(obj);
        }

    }
}
