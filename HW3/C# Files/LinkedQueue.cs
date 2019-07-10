using System;

public class LinkedQueue<T> : QueueInterface<T>
{
    private Node<T> front;
    private Node<T> rear;

    public LinkedQueue()
    {
        front = null;
        rear = null;
    }

    public T push(T element)
    {
        if(element == null)
        {
            throw new NullpointerException();
        }

        if(isEmpty())
        {
            Node<T> tmp = new Node<T>(element, null);
        }

        else
        {
            Node<T> tmp = new Node<T>(element, null);
            rear.next = tmp;
            rear = tmp;
        }

        return element;
    }

    public T pop()
    {
        T temp = null;

        if(isEmpty())
        {
            throw new QueueUnderflowExcpetion("The queue was empty when pop was invoked.");
        }
        else if(front == rear)
        {
            tmp = front.data;
            front = null;
            rear = null;
        }
        else
        {
            tmp = front.data;
            front = front.next;
        }

        return tmp;
    }

    public Boolean isEmpty()
    {
        if(front == null && rear == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
