using System;
class Node {
    public int IntData;
    public String StringData;
    public Node Next;

    public Node(int data) {
        IntData = data;
    }
    public Node(String data) {
        StringData = data;
        Next = null;
    }
}
class LL {
    Node head;
    public void AddFirst(String data) {
        Node newNode = new Node(data);
        newNode.Next = head;
        head =  newNode;
    }
    public void AddFirst(int data) {
        Node newNode = new Node(data);
        newNode.Next = head;
        head =  newNode;
    }

    public void AddLast(String data) {
        Node newNode = new Node(data);
        if(head == null) {
            newNode.Next=head;
            head = newNode;
        } else {
            Node curNode = head;
            while(curNode.Next != null) {
                curNode = curNode.Next;
            }
            curNode.Next = newNode;
        }
    }
    public void AddLast(int data) {
        Node newNode = new Node(data);
        if(head == null) {
            newNode.Next=head;
            head = newNode;
        } else {
            Node curNode = head;
            while(curNode.Next != null) {
                curNode = curNode.Next;
            }
            curNode.Next = newNode;
        }
    }

    public void DeleteFirst() {
        if(head == null) {
            Console.Write("List is already empty");
        } else {
            head = head.Next;
        }
    }

    public void DeleteLast() {
        if(head == null) {
            Console.Write("List is already empty");
        } else {
            Node curNode = head;
            while(curNode.Next.Next != null) {
                curNode = curNode.Next;
            }
            curNode.Next = null;
        }
    }

    public void print() {
        if(head == null) {
            Console.WriteLine("list is empty");
        } else {
            Node curNode = head;
            while(curNode != null) {
                if(curNode.StringData != null)
                Console.Write(curNode.StringData+" => ");
                else
                Console.Write(curNode.IntData+" => ");
                curNode = curNode.Next;
            }
            Console.Write("NULL");
        }

    }
}

class LinkedList {
    static void Main(String[] args) {
        LL list = new LL();
        String[] num = {"First", "Second", "Third", "Forth"};
        for(int i=0; i<4; i++) {
            Console.WriteLine("Enter "+num[i]+" Node Element");
            String str = Console.ReadLine();
            list.AddLast(str);
        }
        Console.WriteLine("Would you like to delete any node ? \n click y for yes, or any key for not");
        ConsoleKeyInfo checkf = Console.ReadKey();
        if(checkf.KeyChar == 'y') {
            Console.WriteLine("\nFrome Start or From Last ? \n click s for frome Start or any key for from Last");
            ConsoleKeyInfo checks = Console.ReadKey();
            if(checks.KeyChar == 's') {
                list.DeleteFirst();
            } else {
                list.DeleteLast();
            }
        }
        Console.WriteLine("Here is the Link List of given data");
        list.print();
    }
}