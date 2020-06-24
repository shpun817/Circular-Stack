using System;

public class CircularStack<T> {

    private T[] arr;
    private int maxSize; // This is fixed
    private int size;
    private int top;
    private int bottom;

    public CircularStack(int ms) {
        arr = new T[ms];
        size = top = bottom = 0;
        this.maxSize = ms;
    }

    public int getSize() { return size; }
    public int getMaxSize() { return maxSize; }

    public void push(T obj) {

        int dummyTop = top;
        ++dummyTop;
        dummyTop %= maxSize;
        if (dummyTop == bottom) {
            ++bottom;
            bottom %= maxSize;
        }
        top = dummyTop;
        arr[top] = obj;
        ++size;

    }

    public T pop() {

        if (size == 0) return default(T);
        T obj = arr[top];
        --top;
        top %= maxSize;
        --size;
        return obj;

    }

}

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}