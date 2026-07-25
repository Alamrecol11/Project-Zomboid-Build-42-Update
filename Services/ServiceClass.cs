using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Services;

public class ServicesClass1
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ServicesClass1";

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
        return $"ServicesClass1: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Services;

public class ServicesClass2
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ServicesClass2";

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
        return $"ServicesClass2: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Services;

public class ServicesClass3
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ServicesClass3";

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
        return $"ServicesClass3: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Services;

public class ServicesClass4
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ServicesClass4";

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
        return $"ServicesClass4: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Services;

public class ServicesClass5
{
    private readonly List<string> _items = new();

    public string Name { get; } = "ServicesClass5";

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
        return $"ServicesClass5: {Count}";
    }
}

using System.Threading.Tasks;
namespace ModManager.Mewgenics.Services;
public class DownloadService{
public Task InitializeAsync(){return Task.CompletedTask;}
public async Task<bool> DownloadAsync(string id){
await Task.Delay(10);
return !string.IsNullOrWhiteSpace(id);
}}
