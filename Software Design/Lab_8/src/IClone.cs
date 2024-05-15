using System.Runtime.CompilerServices;

namespace Lab_8.src
{
    public interface IClone<T> where T : class
    {
        public T Clone();
    }
}