using System;
using System.Text;
using System.Collections.Generic;

public class Animal
{
    protected int Legs { get; set; }
    protected bool Mamal { get; set; }
    protected string Name { get; set; }

    public Animal()
    {
        Legs = 4;
        Mamal = false;
        Name = "Bug";
    }

    public Animal(int LegCount, bool Mam, string Name_Given)
    {
        Legs = LegCount;
        Mamal = Mam;
        Name = Name_Given;
    }

    public string GetName()
    {
        return this.Name;
    }
}

public class Human : Animal
{
    public Human(int LegCount, bool Mam, string Name_Given) : base(LegCount, Mam, Name_Given)
    {

    }

}
public class Example
{

    public static void Main()
    {
        BinaryTree Test = new BinaryTree();
        int[] Temp = { 4, 2, 7, 1, 3, 6, 9 };
        foreach (int i in Temp)
        {
            Test.Add(i);
        }
        Test.Invert(Test.Root);
        Test.TraversePostOrder(Test.Root);


        LinkedListNode<int> test1 = new LinkedListNode<int>(2);
        LinkedList<int> test1_hold = new LinkedList<int>();
        test1_hold.AddLast(test1);
        test1_hold.AddLast(4);
        test1_hold.AddLast(3);

        LinkedListNode<int> test2 = new LinkedListNode<int>(5);
        LinkedList<int> test2_hold = new LinkedList<int>();
        test2_hold.AddLast(test2);
        test2_hold.AddLast(6);
        test2_hold.AddLast(4);

        AddLists testing = new AddLists();
        LinkedListNode<int> result = testing.AddLinkedList(test1,test2);
    
    }
}
