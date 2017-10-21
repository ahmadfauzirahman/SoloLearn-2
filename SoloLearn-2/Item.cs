namespace SoloLearn_2
{
    public class Item
    {
        public int Number { get; set; }
        public Item (int x )
        {
            Number = x;
        }

        public static Item operator +(Item a, Item b)
        {
            int c = a.Number - b.Number;
            Item res = new Item(c);
            return res;
        }
    }
}