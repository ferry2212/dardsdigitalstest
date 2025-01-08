using System;
public class MockRandom : Random
{
    private readonly int[] _values;
    private int _index;

    public MockRandom(int[] values)
    {
        _values = values;
        _index = 0;
    }

    public override int Next(int minValue, int maxValue)
    {
        if (_index >= _values.Length) _index = 0;
        return _values[_index++];
    }
}