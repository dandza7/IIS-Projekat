using System.Runtime.Serialization;

namespace IIS_Projekat.Services.Impl
{
    [Serializable]
    internal class DuplicateItemExtension : Exception
    {
        public DuplicateItemExtension()
        {
        }

        public DuplicateItemExtension(string? message) : base(message)
        {
        }

        public DuplicateItemExtension(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateItemExtension(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}