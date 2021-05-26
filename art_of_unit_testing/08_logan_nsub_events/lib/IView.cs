using System;

namespace lib
{
    public interface IView
    {
        event Action Loaded;
        void Render(string text);
    }
}