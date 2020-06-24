# Circular-Stack

Simple class. Anyone can build it. Just building this in case I need it later in my projects.
Feel free to take the code. Feel free to share what you think about my code, (good, bad or ugly :)

Documentation:

Constructor:
  CircularStack<T>(int maxSize);  // Create a CircularStack with given max size, initialize it to be an empty stack ready to store objects of type T
                                  // Throws OverflowException when maxSize <= 0
  
Mutators:
  void Push(T obj); // Push obj to the top of the CircularStack, wraps around the end and front if necessary
  T Pop(); // Pop the element at the top
  void Resize(int newSize)  // Change the max size of the CircularStack, getting rid of elements that cannot be stored with the new size
                            // You can view it as keep popping elements out until the new stack can store the old stack
                            // Throws OverflowException when maxSize <= 0
                            
Accessor:
  T Peek(); // Get the element at the top without popping it out of the stack
