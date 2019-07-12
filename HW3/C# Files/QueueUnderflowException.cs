using System;

public class QueueUnderflowException : Exception
{
	public QueueUnderflowException()
	{
        base();



    }

    public QueueUnderflowException(String message)
    {
        base(message);
    }

 
}
