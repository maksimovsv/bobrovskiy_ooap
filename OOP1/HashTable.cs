namespace OOP1
{
    public abstract class HashTable<T>
    {
        protected HashTable(int size){}

        //КОМАНДЫ

        // предусловие: есть место для нового значения
        // постусловие: добавлен новый элемент
        public abstract void put(T Value);

        // предусловие: в таблице было это значение
        // постусловие: значение удалено
        public abstract void delete(T Value);

        //ЗАПРОСЫ

        public abstract bool get_put_status();
        public abstract bool get_delete_status();

    }
}
