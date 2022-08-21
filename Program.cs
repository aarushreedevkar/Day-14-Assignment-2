namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkList list = new LinkList();//creating object of linkedlist class


            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("\nAdd after 30 : 40");
            list.AddAfterAtPerticulatPosition(30);
            int position = list.deletePerticulatElement(30);
            Console.WriteLine("\nthe size of linkedlist is {0} ", position);
            list.Display();
            Console.Read();
        }
        }
    }


