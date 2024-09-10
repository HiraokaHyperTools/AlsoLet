# HiraokaHyperTools.AlsoLet

[![NuGet Version](https://img.shields.io/nuget/v/HiraokaHyperTools.AlsoLet)](https://www.nuget.org/packages/HiraokaHyperTools.AlsoLet)

Supply pseudo-Kotlin Scope functions `Also` and `Let`.

```cs
using AlsoLet;
```

`.Also()` sample:

```cs
    return instance.Clone()
        .Also(
            it =>
            {
                it.Name = FixName(it.Name);
            }
        );
```

`.Let()` sample:

```cs
    return new Random(1).Next(-100, 100)
        .Let(
            number => (number < 0)
                ? $"{number} is negative"
                : $"{number} is zero or positive"
        );
```
