# TokenInject
document [中文](README.md) | [English](README.en.md)

## introduce
Super simplified injection, inheritance interface can achieve injection

## use the tools

```csharp
using Token.Inject;

var builder = WebApplication.CreateBuilder(args);
// The current assembly is registered by default
builder.Services.AddAutoInject();
---
builder.Services.AddAutoInject(typeof(需要注册的程序集的类));

---
// When registration is required, the corresponding interface can be inherited
public class DateService:IDateService,ISingletonTag

public class DateService:IDateService,IScopedTag

public class DateService:IDateService,ITransientTag

```

