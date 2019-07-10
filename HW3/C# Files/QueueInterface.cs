using System;



public interface QueueInterface<T>
{
    int main()
    { 
        T push(T element);

        try
        {
            T pop();
        }

        catch(QueueUnderflowException ex)
        {
            throw;  
        }


    boolean isEmpty();

    }
}

