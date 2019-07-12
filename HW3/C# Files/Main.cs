using System;
using System.Collections.Generic;

public class Main
{
	static LinkedList<String> generateBinaryRepresentationList(int n)
    {
        LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

        LinkedList<String> output = new LinkedList<string>();

        if(n < 1)
        {
            return output;
        }

        q.push(new StringBuilder("1"));

        while(n-- > 0)
        {
            StringBuilder sb = q.pop();
            output.add(sb.toString());

            StringBuilder sbc = new StringBuilder(sb.toString());

            sb.Append('0');
            q.push(sb);

            sbc.Append('1');
            q.push(sbc);
        }
        return output;
    }


    public static void main(String[] args)
    {
        int n = 10;

        if(args.Length < 1)
        {
            Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
            Console.WriteLine("\tjava Main 12");
            return;
        }

        try
        {
            n = Int32.TryParse(args[0]);
        }
        catch
        {
            Console.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
            return;
        }

        LinkedList<String> output = generateBinaryRepresentationList(n);


        int maxLength = output.getLast().length();
        for(int j = 0; j < output.length; j++)
        {
            for (int i = 0; i < maxLength - s.Length(); ++i)
            {
                Console.WriteLine(" ");
            }
            Console.WriteLine("s");
        }

    }
}
