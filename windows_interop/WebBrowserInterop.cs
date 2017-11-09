namespace WebBrowserInterop {
    public interface IWebBrowserInterop
    {
        string call(string message, string param);
        void alert(string message);
    }
}