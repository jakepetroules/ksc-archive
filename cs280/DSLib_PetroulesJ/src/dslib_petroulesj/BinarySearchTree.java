package dslib_petroulesj;

/**
 *
 * @author Jake Petroules
 */
public class BinarySearchTree<T extends Comparable<? super T>>
{
    private Node<T> root;

    /**
     * Initializes a new instance of the {@see BinarySearchTree} class.
     */
    public BinarySearchTree()
    {
    }

    public void clear()
    {
        this.root = null;
    }

    @SuppressWarnings("SizeReplaceableByIsEmpty")
    public boolean isEmpty()
    {
        return this.size() == 0;
    }

    public int size()
    {
        return this.inorder().size();
    }

    public void add(T value)
    {
        if (value == null)
        {
            return;
        }

        if (this.root == null)
        {
            this.root = new Node(value);
        }
        else
        {
            this.root = this.insert(this.root, value);
        }
    }

    private Node<T> insert(Node<T> node, T value)
    {
        Node<T> result = new Node<T>(node);
        int compare = result.value.compareTo(value);

        if (compare > 0)
        {
            if (result.left != null)
            {
                result.left = this.insert(result.left, value);
            }
            else
            {
                result.left = new Node<T>(value);
            }
        }
        else if (compare < 0)
        {
            if (result.right != null)
            {
                result.right = this.insert(result.right, value);
            }
            else
            {
                result.right = new Node<T>(value);
            }
        }

        return result;
    }

    public T get(T value)
    {
        if (this.root == null)
        {
            return null;
        }

        Node<T> node = this.root;
        int compareResult;
        while ((compareResult = node.value.compareTo(value)) != 0)
        {
            if (compareResult > 0)
            {
                if (node.left != null)
                {
                    node = node.left;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (node.right != null)
                {
                    node = node.right;
                }
                else
                {
                    return null;
                }
            }
        }

        return node.value;
    }

    public void remove(T value)
    {
        if (this.root == null)
        {
            return;
        }

        if (this.root.value.compareTo(value) == 0)
        {
            Node auxRoot = new Node();
            auxRoot.left = this.root;
            this.root.remove(value, auxRoot);
            this.root = auxRoot.left;
        }
        else
        {
            this.root.remove(value, null);
        }
    }

    public ArrayList<T> preorder()
    {
        ArrayList<T> list = new ArrayList<T>();
        if (this.root != null)
        {
            this.root.preorder(list);
        }

        return list;
    }

    public ArrayList<T> inorder()
    {
        ArrayList<T> list = new ArrayList<T>();
        if (this.root != null)
        {
            this.root.inorder(list);
        }

        return list;
    }

    public ArrayList<T> postorder()
    {
        ArrayList<T> list = new ArrayList<T>();
        if (this.root != null)
        {
            this.root.postorder(list);
        }
        
        return list;
    }

    private class Node<T extends Comparable<? super T>>
    {
        private T value;
        private Node<T> left;
        private Node<T> right;

        public Node()
        {
        }

        public Node(T value)
        {
            this.value = value;
        }

        public Node(Node<T> node)
        {
            this.value = node.value;
            this.left = node.left;
            this.right = node.right;
        }

        public boolean remove(T value, Node<T> parent)
        {
            if (value.compareTo(this.value) < 0)
            {
                if (this.left != null)
                {
                    return this.left.remove(value, this);
                }
                else
                {
                    return false;
                }
            }
            else if (value.compareTo(this.value) > 0)
            {
                if (this.right != null)
                {
                    return this.right.remove(value, this);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (this.left != null && this.right != null)
                {
                    this.value = this.right.minValue();
                    this.right.remove(this.value, this);
                }
                else if (parent.left == this)
                {
                    parent.left = (this.left != null) ? this.left : this.right;
                }
                else if (parent.right == this)
                {
                    parent.right = (this.left != null) ? this.left : this.right;
                }

                return true;
            }
        }

        public T minValue()
        {
            if (this.left == null)
            {
                return this.value;
            }
            else
            {
                return this.left.minValue();
            }
        }

        public void preorder(ArrayList<T> list)
        {
            list.add(this.value);

            if (this.left != null)
            {
                this.left.preorder(list);
            }

            if (this.right != null)
            {
                this.right.preorder(list);
            }
        }

        public void inorder(ArrayList<T> list)
        {
            if (this.left != null)
            {
                this.left.inorder(list);
            }

            list.add(this.value);

            if (this.right != null)
            {
                this.right.inorder(list);
            }
        }

        public void postorder(ArrayList<T> list)
        {
            if (this.left != null)
            {
                this.left.postorder(list);
            }

            if (this.right != null)
            {
                this.right.postorder(list);
            }
            
            list.add(this.value);
        }
    }
}
