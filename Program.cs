namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();//creating object of linkedlist class
            list.InsertFront(70);
            list.InsertFront(56);

            list.InsertAtParticularPosition(2, 30);


            list.Display();

            Console.Read();



        } 
    }
}
