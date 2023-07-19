namespace MB10.HashtableAufgabe
{
    public class Hashtable : IHashtable
    {
        private const int InitialCapacity = 10;
        private const double LoadFactor = 0.75;

        private Element[] elements;
        private int size;

        public Hashtable()
        {
            elements = new Element[InitialCapacity];
            size = 0;
        }

        public bool Put(Element e)
        {
            if (size >= elements.Length * LoadFactor)
            {
                Resize();
            }

            int index = GetIndex(e.Id);
            if (elements[index] == null)
            {
                elements[index] = e;
                size++;
                return true;
            }
            else
            {
                // Handle collision with linear probing
                int startIndex = index;
                do
                {
                    index = (index + 1) % elements.Length;
                    if (elements[index] == null)
                    {
                        elements[index] = e;
                        size++;
                        return true;
                    }
                } while (index != startIndex);

                // Hashtable is full
                return false;
            }
        }

        public Element Get(string id)
        {
            int index = GetIndex(id);
            if (elements[index] != null && elements[index].Id == id)
            {
                return elements[index];
            }
            else
            {
                // Handle collision with linear probing
                int startIndex = index;
                do
                {
                    index = (index + 1) % elements.Length;
                    if (elements[index] != null && elements[index].Id == id)
                    {
                        return elements[index];
                    }
                } while (index != startIndex);

                // Element not found
                return null;
            }
        }

        public bool Delete(string id)
        {
            int index = GetIndex(id);
            if (elements[index] != null && elements[index].Id == id)
            {
                elements[index] = null;
                size--;
                return true;
            }
            else
            {
                // Handle collision with linear probing
                int startIndex = index;
                do
                {
                    index = (index + 1) % elements.Length;
                    if (elements[index] != null && elements[index].Id == id)
                    {
                        elements[index] = null;
                        size--;
                        return true;
                    }
                } while (index != startIndex);

                // Element not found
                return false;
            }
        }

        private int GetIndex(string id)
        {
            int hashCode = id.GetHashCode();
            int index = hashCode % elements.Length;
            if (index < 0)
            {
                index += elements.Length; // Ensure positive index
            }
            return index;
        }

        private void Resize()
        {
            int newCapacity = elements.Length * 2;
            Element[] newElements = new Element[newCapacity];

            foreach (Element element in elements)
            {
                if (element != null)
                {
                    int index = GetIndex(element.Id);
                    if (newElements[index] == null)
                    {
                        newElements[index] = element;
                    }
                    else
                    {
                        // Handle collision with linear probing
                        int startIndex = index;
                        do
                        {
                            index = (index + 1) % newCapacity;
                        } while (newElements[index] != null && index != startIndex);

                        newElements[index] = element;
                    }
                }
            }

            elements = newElements;
        }
    }
}
