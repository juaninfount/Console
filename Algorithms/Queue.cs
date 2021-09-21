using System;

namespace Algorithms
{

    public class Queue<T> 
    {
        #region Members
        
        private int MaximumLength;
        private T _Front, _Rear;
        private T[] queue;

        #endregion

        #region Constructor

        public Queue(int c)
        {
            //this._Front = this._Rear = default(T);
            this.MaximumLength = c;
            queue = new T[this.MaximumLength];
        }

        #endregion

        #region Properties

        public int Size { get; private set; }

        #endregion
        
        #region  "Public Methods" 

        public T Dequeue()
        {
            T dequeue = default(T);
            if(this.Size == 0)
            {
                throw new System.Exception("Queue is empty");
            }

            if(this.Size >= 1)
            {
               dequeue = queue[0];
               if(this.Size == 1)
               {
                   queue = new T[this.MaximumLength];
               }
            }

            if(this.Size > 1)
            {
                for(int i=1; i<this.Size;i++)
                {
                    queue[i-1] = queue[i];
                }
                this._Front = queue[0];
                this.queue[this.Size-1] = default(T);
            }                        
            this.Size--;
            return dequeue;
        }

        public void Enqueue(T item)
        {            
            if(this.Size >= this.MaximumLength)
            {
                throw new System.Exception("Exceeded Size Exception");
            }

            queue[this.Size++] = item;   
            this._Rear = item;
        }

        public T Front()
        {
            if(this.Size == 0)
            {
                return default(T);
            }

            return queue[0];
        }

        public T Rear()
        {
            if(this.Size == 0)
            {
                return default(T);
            }

            return queue[this.Size-1];
        }

        public void Print() 
        {
            string args = "[";
            if (this.queue != null && this.queue.Length > 0) 
            {
                for (int i = 0; i < this.queue.Length; i++)
                {
                    if (i == 0)
                    {
                        args += queue[i];
                    }
                    else 
                    {
                        args += " " + queue[i];
                    }                    
                }
            }
            args += "]";
            Console.WriteLine(args);
        }

        #endregion   
  
    }

}
