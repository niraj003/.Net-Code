Q-6: Create your own linked list to represent a polynomial. Write a program to perform addition of two polynomials

using System;

class Node
{
    public int Data;
    public int Power;
    public Node Next;

    public Node(int data, int pow)
    {
        Data = data;
        Power = pow;
        Next = null;
    }
}

class Polynomial
{
    public Node head;

    public Polynomial()
    {
        head = null;
    }

    public void InsertTerm(int data, int pow)
    {
        Node newNode = new Node(data, pow);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write($"{current.Data}x^{current.Power}");
            if (current.Next != null)
            {
                Console.Write(" + ");
            }
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class HelloWorld
{
    static Polynomial AddPolynomials(Polynomial poly1, Polynomial poly2)
    {
        Polynomial result = new Polynomial();
        Node current1 = poly1.head;
        Node current2 = poly2.head;

        while (current1 != null && current2 != null)
        {
            if (current1.Power > current2.Power)
            {
                result.InsertTerm(current1.Data, current1.Power);
                current1 = current1.Next;
            }
            else if (current2.Power > current1.Power)
            {
                result.InsertTerm(current2.Data, current2.Power);
                current2 = current2.Next;
            }
            else
            {
                int newData = current1.Data + current2.Data;
                result.InsertTerm(newData, current1.Power);
                current1 = current1.Next;
                current2 = current2.Next;
            }
        }

        while (current1 != null)
        {
            result.InsertTerm(current1.Data, current1.Power);
            current1 = current1.Next;
        }

        while (current2 != null)
        {
            result.InsertTerm(current2.Data, current2.Power);
            current2 = current2.Next;
        }

        return result;
    }

    static void Main()
    {
        Polynomial poly1 = new Polynomial();
        poly1.InsertTerm(3, 2);
        poly1.InsertTerm(4, 1);
        poly1.InsertTerm(5, 0);

        Polynomial poly2 = new Polynomial();
        poly2.InsertTerm(2, 3);
        poly2.InsertTerm(1, 1);
        poly2.InsertTerm(7, 0);

        Console.WriteLine("First polynomial:");
        poly1.Display();
        Console.WriteLine("Second polynomial:");
        poly2.Display();

        Polynomial resultantPoly = AddPolynomials(poly1, poly2);
        Console.WriteLine("Sum of polynomials:");
        resultantPoly.Display();
    }
}
