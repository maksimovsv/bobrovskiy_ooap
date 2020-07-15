namespace OOP1
{
    public abstract class NativeDictionary<T>
    {
        // конструктор
        // постусловие: создана пустой словарь заданного размера
        protected NativeDictionary(int size){}

        // команды

        // предусловие: в словаре есть место для добавления
        // постусловие: в словарь добавлено новое значение
        public abstract void put(string key, T value);

        // предусловие: в словаре имеется ключ key;
        // постусловие: из словаря удалено значение с ключом key
        public abstract void remove(string key);

        // запросы

        public abstract bool is_key(string key); // содержится ли ключ value в словаре

        // предусловие: в словаре имеется ключ key;
        public abstract bool get(string key); // получить значение по ключу

        public abstract int size(); // количество элементов в словаре

        // запросы статусов (возможные значения статусов)
        public abstract int get_put_status(); // успешно; 
        // система коллизий не смогла найти свободный слот для пары ключ-значение

        public abstract int get_remove_status(); // успешно; ключа нет в словаре

        public abstract int get_get_status(); // успешно; ключа нет в словаре

    }
}
