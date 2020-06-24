# Circular-Stack

## Introduction
Simple class. Anyone can build it. Just building this in case I need it later in my projects.
Feel free to take the code. Feel free to share what you think about my code (good, bad or ugly :)

## Documentation:

### Constructor:
  // Create a CircularStack with given max size, initialize it to be an empty stack ready to store objects of type T\
  // Throws OverflowException when maxSize <= 0\
  **_CircularStack<T>(int maxSize);_**\
                                  
  
### Mutators:
  // Push obj to the top of the CircularStack, wraps around the end and front if necessary\
  **_void Push(T obj);_**\
  \
  // Pop the element at the top\
  **_T Pop();_**\
  \
  // Change the max size of the CircularStack, getting rid of elements that cannot be stored with the new size\
  // You can view it as keep popping elements out until the new stack can store the old stack\
  // Throws OverflowException when maxSize <= 0\
  **_void Resize(int newSize)_**\ 
### Accessor:
  // Get the element at the top without popping it out of the stack\
  **_T Peek();_**
