# Simple Singleton

A simple singleton implementation for Unity in UPM form for easy addition to projects.

## Installation

In your Unity project open `Packages/manifest.json` and add `"com.jimthekiwifruit.simplesingleton": "https://github.com/JimTheKiwifruit/SimpleSingleton",` to the top of your dependencies:

```json
{
  "dependencies": {
    "com.jimthekiwifruit.simplesingleton": "https://github.com/JimTheKiwifruit/SimpleSingleton",
    "com.unity.collab-proxy": "1.2.16",
    "com.unity.ext.nunit": "1.0.0",
    "com.unity.ide.rider": "1.0.8",
    "com.unity.ide.vscode": "1.0.7",
    ...
  }
}
```

You can checkout the full docs on UPM dependancies at [https://docs.unity3d.com/Manual/upm-git.html](https://docs.unity3d.com/Manual/upm-git.html)

## Usage

Instead of extending from `MonoBehaviour`, extend from `Singelton<ClassName>` like this:

```csharp
using JimTheKiwifruit.Singleton;

public class YourClass : Singleton<YourClass> {

  void DoSomething() {
    print("Something");
  }

}
```

Now you can access your singleton from anywhere:

```csharp
void DoStuffWithSingletonClass() {
  YourClass.Instance.DoSomething();
}
```
