// Check if the proxy string is not null or empty
if (!string.IsNullOrEmpty(proxy))
{
    try
    {
        // Initialize a new WebProxy instance with the proxy string
        request.Proxy = new WebProxy(proxy);

        // Configure the WebProxy instance to bypass the proxy server for local addresses
        request.Proxy.BypassProxyOnLocal = true;
    }
    catch (UriFormatException ex)
    {
        // Handle any UriFormatException that might occur
        Console.WriteLine("The proxy URI is invalid: " + ex.Message);
    }
}
else
{
    // If the proxy string is null or empty, do not set the proxy
    Console.WriteLine("No proxy will be used as the proxy string is empty.");
}
