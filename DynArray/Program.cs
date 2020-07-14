namespace DynArray
{
    public abstract class DynArray<T>
    {
        // конструктор
        public DynArray(){}

        // КОМАНДЫ

        // постусловие: в конец массива добавлен новый элемент;
        public abstract void append(T item);

        // предусловие: индекс находится в границах массива
        // постусловие:  в i-ю позицию массива добавлен новый элемент, все последующие элементы сдвинуты вперед;
        public abstract void insert(T item, int i);

        // предусловие: массив не пустой; индекс находится в границах массива
        // постусловие:  из i-й позиции массива удалён элемент, все последующие элементы сдвинуты назад;
        public abstract void remove(int i);
        
        // постусловие:  удалены все элементы массива
        public abstract void clear();

        // ЗАПРОСЫ

        // предусловие: массив не пустой; индекс находится в границах массива
        public abstract T get_item(int i);

        public abstract int size();

        // запросы статусов
        public abstract int get_insert_status();
        public abstract int get_remove_status();
        public abstract int get_get_status();



    }
}
