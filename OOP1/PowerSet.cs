namespace OOP1
{
    public abstract class HashTableAdt<T>
    {
        // конструктор
        // постусловие: создана пустая хэш-таблица заданного размера
        public abstract HashTable<T> HashTable(int sz);

        // команды
        // предусловие: в таблице имеется свободный слот для value;
        // постусловие: в таблицу добавлено новое значение
        public abstract void put(T value);

        // предусловие: в таблице имеется значение value;
        // постусловие: из таблицы удалено значение value
        public abstract void remove(T value);

        // запросы
        public abstract bool get(T value); // содержится ли значение value в таблице

        public abstract int size(); // количество элементов в таблице

        // запросы статусов (возможные значения статусов)
        public abstract int get_put_status(); // успешно; 
        // система коллизий не смогла найти свободный слот для значения

        public abstract int get_remove_status(); // успешно; значения нету в таблице
    }
    public abstract class PowerSet<T> : HashTableAdt<T>
    {
        // ЗАПРОСЫ

        // постусловие: вернуло пересечение текущего множества и set2
        public abstract PowerSet<T> intersection(PowerSet<T> set2);

        // постусловие: вернуло объединение текущего множества и set2
        public abstract PowerSet<T> union(PowerSet<T> set2);

        // постусловие: вернуло разницу текущего множества и set2
        public abstract PowerSet<T> difference(PowerSet<T> set2);

        public abstract bool is_subset(PowerSet<T> set2); // возвращает true, если set2 есть подмножество текущего множества, иначе false
    }
}
