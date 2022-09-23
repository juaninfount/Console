using System;

namespace Algorithms
{
    public class Stack<T>
    {
        #region Members

        private T[] stackArray;
        private int maximumLength;

        #endregion

        #region Properties

        public int Size {get; private set; }

        #endregion

        #region Constructor

        public Stack(int length)
        {
            this.maximumLength = length;
            this.stackArray = new T[length];
        }

        #endregion

        #region   Public Methods

        public void Push(T value)
        {
            if(this.Size >= maximumLength)
            {
                throw new System.Exception("Exceeded Size Exception");
            }

            stackArray[Size++] = value;
        }

        public T Pop()
        {             
            if(Size==0)
              throw new System.Exception("No elements.");

            
            T elem = stackArray[Size-1];
            Size--;                           
            return elem;
        }

        public T Peek()
        {
            if(Size==0)
              throw new System.Exception("No elements.");

            return stackArray[Size-1];
        }

         public void Print() 
        {
            string args = "[";
            if (this.stackArray != null && this.stackArray.Length > 0)
            {
                for (int i = 0; i < this.stackArray.Length; i++)
                {
                    if (i == 0)
                    {
                        args += stackArray[i];
                    }
                    else 
                    {
                        args += " " + stackArray[i];
                    }                    
                }
            }
            args = args + "]";
            Console.WriteLine(args);
        }

        #endregion
       
    }
}