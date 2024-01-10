using System;

class Node
{
    public int coefficient;
    public int power;
    public Node next;

    public Node(int coeff, int pow)
    {
        coefficient = coeff;
        power = pow;
        next = null;
    }
}

class Polynomial
{
    public Node head;

    public Polynomial()
    {
        head = null;
    }

    public void InsertTerm(int coeff, int pow)
    {
        Node newNode = new Node(coeff, pow);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
    }

    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write($"{current.coefficient}x^{current.power}");
            if (current.next != null)
            {
                Console.Write(" + ");
            }
            current = current.next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static Polynomial AddPolynomials(Polynomial poly1, Polynomial poly2)
    {
        Polynomial result = new Polynomial();
        Node current1 = poly1.head;
        Node current2 = poly2.head;

        while (current1 != null && current2 != null)
        {
            if (current1.power > current2.power)
            {
                result.InsertTerm(current1.coefficient, current1.power);
                current1 = current1.next;
            }
            else if (current2.power > current1.power)
            {
                result.InsertTerm(current2.coefficient, current2.power);
                current2 = current2.next;
            }
            else
            {
                int newCoefficient = current1.coefficient + current2.coefficient;
                result.InsertTerm(newCoefficient, current1.power);
                current1 = current1.next;
                current2 = current2.next;
            }
        }

        while (current1 != null)
        {
            result.InsertTerm(current1.coefficient, current1.power);
            current1 = current1.next;
        }

        while (current2 != null)
        {
            result.InsertTerm(current2.coefficient, current2.power);
            current2 = current2.next;
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
