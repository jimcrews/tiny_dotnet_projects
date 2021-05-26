using lib;

namespace testsLib
{
    /// <summary>
    /// Simple stub code that always returns true
    /// A fake denotes an object that looks like another object but can be used as a mock or a stub.
    /// </summary>
    public class FakeExtensionManager : IExtensionManager
    {
        public bool willBeValid = false;
        public bool isValid(string fileName)
        {
            return willBeValid;
        }
    }
}