using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Core;

public class CoreClass4
{
    private readonly List<string> _items = new();

    public string Name { get; } = "CoreClass4";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"CoreClass4: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Core;

public class CoreClass5
{
    private readonly List<string> _items = new();

    public string Name { get; } = "CoreClass5";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"CoreClass5: {Count}";
    }
}

using System.Collections.Generic;
using System.Linq;
namespace ModManager.Mewgenics.Core;
public sealed class ProfileManager{
private readonly List<string> _profiles=new();
public IReadOnlyList<string> Profiles=>_profiles;
public bool Add(string name){
if(string.IsNullOrWhiteSpace(name)||_profiles.Contains(name)) return false;
_profiles.Add(name); return true;}
public bool Remove(string name)=>_profiles.Remove(name);
}
using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Core;

public class CoreClass1
{
    private readonly List<string> _items = new();

    public string Name { get; } = "CoreClass1";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"CoreClass1: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Core;

public class CoreClass2
{
    private readonly List<string> _items = new();

    public string Name { get; } = "CoreClass2";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"CoreClass2: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Core;

public class CoreClass3
{
    private readonly List<string> _items = new();

    public string Name { get; } = "CoreClass3";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"CoreClass3: {Count}";
    }
}
