using GenHTTP.Engine;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Webservices;

using TestREST.Services;

var api = Layout.Create()
                .AddService<GarageDoorResource>("door")
                .Add(CorsPolicy.Permissive());

return Host.Create()
           .Handler(api)
           .Defaults()
           .Console()
#if DEBUG
           .Development()
#endif
           .Run();