// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
 class binarysearchtree
{
    int data;
    Node left = null, right = null;

    Node(int data)
    {
        this.data = data;
    }
}

class Main
{
    // Recursive function to insert a key into a BST
    public static Node insert(Node root, int key)
    {

        if (root == null)
        {
            return new Node(key);
        }


        if (key < root.data)
        {
            root.left = insert(root.left, key);
        }


        else
        {
            root.right = insert(root.right, key);
        }

        return root;
    }

    // Recursive function to search in a given BST
    public static void search(Node root, int key, Node parent)
    {
        // if the key is not present in the key
        if (root == null)
        {
            Console.WriteLine("Key not found");
            return;
        }

        // if the key is found
        if (root.data == key)
        {
            if (parent == null)
            {
                Console.WriteLine("The node with key " + key + " is root node");
            }

            else if (key < parent.data)
            {
                Console.WriteLine("The given key is the left node of the node " +
                            "with key " + parent.data);
            }
            else
            {
                Console.WriteLine("The given key is the right node of the node " +
                            "with key " + parent.data);
            }

            return;
        }

        // if the given key is less than the root node, recur for the left subtree;
        // otherwise, recur for the right subtree

        if (key < root.data)
        {
            search(root.left, key, root);
        }
        else
        {
            search(root.right, key, root);
        }
    }

    public static void main(String[] args)
    {
        int[] keys = { 30, 70, 22, 40, 60, 95, 11, 65, 3, 16, 63, 67 };

        Node root = null;
        for (int key: keys)
        {
            root = insert(root, key);
        }

        search(root, 63, null);
    }
}