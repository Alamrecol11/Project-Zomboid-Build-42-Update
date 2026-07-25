using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Storage;

public class StorageClass3
{
    private readonly List<string> _items = new();

    public string Name { get; } = "StorageClass3";

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
        return $"StorageClass3: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Storage;

public class StorageClass4
{
    private readonly List<string> _items = new();

    public string Name { get; } = "StorageClass4";

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
        return $"StorageClass4: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Storage;

public class StorageClass5
{
    private readonly List<string> _items = new();

    public string Name { get; } = "StorageClass5";

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
        return $"StorageClass5: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Storage;

public class StorageClass1
{
    private readonly List<string> _items = new();

    public string Name { get; } = "StorageClass1";

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
        return $"StorageClass1: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Storage;

public class StorageClass2
{
    private readonly List<string> _items = new();

    public string Name { get; } = "StorageClass2";

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
        return $"StorageClass2: {Count}";
    }
}
