// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

public class Node
{
	public int data;
	public Node left, right;

	public Node(int item)
	{
		data = item;
		left = right = null;
	}
}


public class BinaryTree
{
	public Node root;


	public virtual int size()
	{
		return size(root);
	}


	public virtual int size(Node node)
	{
		if (node == null)
		{
			return 0;
		}
		else
		{
			return (size(node.left) + 1 + size(node.right));
		}
	}

	public static void Main(string[] args)
	{
		BinarySearchTree tree = new BinarySearchTree();

		tree.insert(56);
		tree.insert(30);
		tree.insert(22);
		tree.insert(11);
		tree.insert(3);
		tree.insert(16);
		tree.insert(40);
		tree.insert(70);
		tree.insert(60);
		tree.insert(65);
		tree.insert(63);
		tree.insert(67);
		tree.insert(95);

		Console.WriteLine("The size of binary tree is : " + tree.size());
	}
}
