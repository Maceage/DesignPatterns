using BridgePattern.Formatters;

namespace BridgePattern.Domain
{
    public abstract class Publication
    {
        protected Publication(IFormatter formatter)
        {
            Formatter = formatter;
        }

        protected IFormatter Formatter { get; private set; }

        public abstract void Print();
    }
}