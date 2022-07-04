# TokenInject
[![NuGet](https://img.shields.io/nuget/dt/Token.Inject.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/Token.Inject/)
[![NuGet](https://img.shields.io/nuget/v/Token.Inject.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/Token.Inject/)

document [中文](README.md) | [English](README.en.md)

## 介绍
超简化注入,继承接口即可实现注入

## 使用工具

```csharp
using Token.Inject;

var builder = WebApplication.CreateBuilder(args);
// 默认注册当前程序集
builder.Services.AddAutoInject();
---
builder.Services.AddAutoInject(typeof(需要注册的程序集的类));

---
// 在需要注册的时候继承相应的接口即可
public class DateService:IDateService,ISingletonTag

public class DateService:IDateService,IScopedTag

public class DateService:IDateService,ITransientTag

```

