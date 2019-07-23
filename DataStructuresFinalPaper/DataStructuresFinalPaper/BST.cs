using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class BST
    {
        Bnode root;
        public void Add(int data)
        {
            root = Add(data, root);
        }
        private Bnode Add(int data, Bnode node)
        {
            if (node == null)
            {
                Bnode newnode = new Bnode(data);

                return newnode;
            }
            else
            {

                if (data > node.data)
                {
                    node.right = Add(data, node.right);
                    return node;
                }
                else if (data < node.data)
                {
                    node.left = Add(data, node.left);
                    return node;
                }
                else
                    return node;

            }
        }
        public void Inorder()
        {
            Inorder(root);
        }
        private void Inorder(Bnode node)
        {
            if (node != null)
            {
                Inorder(node.left);
                Console.WriteLine(node.data);
                Inorder(node.right);
            }
        }
        private void preorder(Bnode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data);
                preorder(node.left);
                preorder(node.right);
            }
        }
        public void preorder()
        {
            preorder(root);
        }
        public void postorder()
        {
            postorder(root);
        }
        private void postorder(Bnode node)
        {
            if (node != null)
            {
                postorder(node.left);
                postorder(node.right);
                Console.WriteLine(node.data);
            }
        }
        public void Delete(int data)
        {
            Delete(data, root);
        }
        private Bnode Delete(int data, Bnode node)
        {
            if (node != null)
            {
                if (data == node.data)
                {
                    if (node.left == null && node.right == null)
                    {
                        return null;
                    }
                   else if (node.left == null && node.right != null)
                    {
                        node = node.right;
                        return node;
                    }
                    else if (node.right == null && node.left != null)
                    {
                        node = node.left;
                        return node;
                    }
                    else
                    {
                        Bnode temp = Successor(node);
                        node.data = temp.data;
                        node.right = Delete(temp.data, node.right);
                        return node;


                    }
                }
                else if (data > node.data)
                {
                    node.right = Delete(data, node.right);
                    return node;

                }
                else
                {
                    node.left = Delete(data, node.left);
                    return node;
                }
            }
            else
            {
                return null;
            }
        }
        private Bnode Successor(Bnode node)
        {
            return GetMinimum(node.right);
        }
        private Bnode GetMinimum(Bnode node)
        {
            while (node.left != null)
            {
                node = node.left;
            }
            return node;
        }
    }
}
