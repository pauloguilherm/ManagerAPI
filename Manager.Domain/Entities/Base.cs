using System.Collections.Generic;
namespace Manager.Domain.Entities{

    public abstract class Base{
        public Long Id { get; set; }
        internal List<String> _errors;
        public abstract bool Validate();
        public IReadOnlyCollection<String> Erros => _erros;
    }
}