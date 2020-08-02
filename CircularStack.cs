using System;

public class CircularStack<T> {

    private T[] _arr;
    private int _maxSize; // This is fixed
    private int _top;
    private int _bottom;
	private bool _isEmpty;

    public CircularStack (int maxSize) {
        if (maxSize <= 0)
            throw new OverflowException("Size of CircularStack not positive.");
        _arr = new T[maxSize];
		for (int i = 0; i < maxSize; ++i) {
			_arr[i] = default(T);
		}
        _top = _bottom = 0;
        _maxSize = maxSize;
		_isEmpty = true;
    }

    public int GetSize() {
		if (_top > _bottom) {
			return (_top - _bottom + 1);
		} else if (_top < _bottom) {
			return (_maxSize - _bottom + _top + 1);
		} else if (_isEmpty) {
			return 0;
		} else {
			return 1;
		}
	}
    public int GetMaxSize() { return _maxSize; }

    public void Push(T obj) {
        if (_isEmpty) {
			_isEmpty = false;
			_top = _bottom = 0; // Reset to play safe
		} else {
			_top = (_top + 1) % _maxSize;
			if (_bottom == _top) {
				_bottom = (_bottom + 1) % _maxSize;
			}
		}
		_arr[_top] = obj;
    }

	public T Peek() {
		if (_isEmpty) {
			return default(T);
		}
		return _arr[_top];
	}

    public T Pop() {
        if (_isEmpty) {
			return default(T);
		} else {
			T obj = _arr[_top];
			if (_top == _bottom) {
				_isEmpty = true;
			} else {
				if (_top == 0) {
					_top = _maxSize;
				}
				--_top;
			}
			return obj;
		}
    }

    public void Resize(int newSize) {
        if (newSize <= 0)
			throw new OverflowException("Size of CircularStack not positive.");
        T[] tempArr = new T[newSize];
		int currentSize = GetSize();
		int tempSize = newSize<currentSize?newSize:currentSize;
		for (int i = 0; i < tempSize; ++i) {
			tempArr[i] = _arr[(_bottom+i)%_maxSize];
		}
		_arr = tempArr;
		_bottom = 0;
		_top = newSize<currentSize?newSize-1:currentSize-1;
		_maxSize = newSize;
    }

	public void Clear() {
		for (int i = 0; i < _maxSize; ++i) {
			_arr[i] = default(T);
		}
       _top = _bottom = 0;
	   _isEmpty = true;
	}

    public override String ToString() {
        String str = "";
		int size = GetSize();
        for (int i = 0; i < size; ++i) {
            str += _arr[(_bottom+i)%_maxSize] + " ";
        }
        return str.TrimEnd();
    }

}

/* FOR TESTING
class Program
{
	static void Main(string[] args)
	{
		CircularStack<int> cs = new CircularStack<int>(5);
		cs.Push(2);
		cs.Push(1);
		cs.Push(3);
		cs.Push(4);
		cs.Push(11);
		cs.Resize(3);
		cs.Resize(4);
		Console.WriteLine(cs.Peek());
		Console.WriteLine(cs);
	}
}
*/
