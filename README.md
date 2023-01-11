Small demo of .NET Behavior Change from .NET Core 3.1 to .NET 6

When waiting on an `TcpListener.AcceptTcpClientAsync` call, if the
underlying listener is closed via `TcpListener.Close`, then different
errors are thrown based on the running .NET version.

If the version is .NET Core 3.1, you will get an `ObjectDisposedException`,
but if you're running .NET 6, you'll get a `SocketException`.

To see this behavior, run the `Runner` project with different versions of the
.NET framework. 

For .NET Core 3.1:
```
dotnet run -f netcoreapp3.1
```

For .NET 6:
```
dotnet run -f net6
```

You can see that the two calls produce different exceptions for the same code.