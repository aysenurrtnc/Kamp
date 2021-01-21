using System;
namespace MyDictionary
{
    class MyDictionaryDemo<Tkey, Tvalue>
    {
        Tkey[] _keys;
        Tvalue[] _values;

        public MyDictionaryDemo()
        {
            _keys = new Tkey[0];
            _values = new Tvalue[0];
        }

        public void Add(Tkey keyItem, Tvalue valueItem)
        {
            Tkey[] _tempKeys = _keys;
            Tvalue[] _tempValues = _values;

            _keys = new Tkey[_keys.Length + 1];
            _values = new Tvalue[_values.Length + 1];


            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];

            }

            _keys[_keys.Length - 1] = keyItem;
            _values[_values.Length - 1] = valueItem;
        }

        public Tkey[] Key
        {
            get { return _keys; }
        }

        public Tvalue[] Value
        {
            get { return _values; }
        }

    }
}
