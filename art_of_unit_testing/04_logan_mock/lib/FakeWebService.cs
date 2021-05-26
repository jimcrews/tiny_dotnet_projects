namespace lib
{
    /// <summary>
    /// This handwritten class implements an interface, as a stub does, 
    /// but it saves some state for later, so that your test can then assert and verify that your mock was called correctly. 
    /// It’s still not a mock object. It will only become one when you use it as one in your test.
    /// </summary>
    public class FakeWebService : IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}