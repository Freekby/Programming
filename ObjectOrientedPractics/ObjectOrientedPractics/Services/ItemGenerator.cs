namespace ObjectOrientedPractices
{
    internal static class ItemGenerator
    {
        private static int itemGeneratedCount=0;
        public static Item Generate()
        {
            Item item = new Item($"name{itemGeneratedCount}", $"info{itemGeneratedCount}", itemGeneratedCount);
            itemGeneratedCount++;
            return item;
        }
    }
}
