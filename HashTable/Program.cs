namespace HashTable
{
    public abstract class HashTable<T>
    {
        protected HashTable(int size){}

        //КОМАНДЫ

        // постусловие: добавлен новый элемент
        public abstract void put(T Value);

        // постусловие: значение удалено
        public abstract void delete(T Value);

        //ЗАПРОСЫ

        public abstract bool get_put_status();
        public abstract bool get_delete_status();

    }
}
