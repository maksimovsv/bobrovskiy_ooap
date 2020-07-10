namespace AtdLinkedList
{
    public abstract class LinkedList<T>
    {
        public const int GET_NIL = 0; // get() ещё не вызывалась
        public const int GET_OK = 1; // последняя get() вернула корректное значение 
        public const int GET_ERR = 2; // список пуст

        public const int RIGHT_NIL = 0; // right() ещё не вызывалась
        public const int RIGHT_OK = 1; // курсор сдвинулся вправо
        public const int RIGHT_ERR = 2; // курсор не сдвинулся вправо, может потому, что справа нет ничего или список пуст

        public const int REMOVE_NIL = 0; // remove() ещё не вызывалась
        public const int REMOVE_OK = 1; // текущий узел удален
        public const int REMOVE_ERR = 2; // текущий узел не удален, так как курсор указывал на пустой список

        // КОНСТРУКТОР
        // постусловие: создан новый пустой список
        protected LinkedList() {}
        

        // КОМАНДЫ

        // установить курсор на первый узел в списке;
        // постусловие - курсор указывает на первый элемент или на NULL
        public abstract void head();

        // установить курсор на последний узел в списке;
        // постусловие - курсор указывает на последний элемент или на NULL
        public abstract void tail();

        // сдвинуть курсор на один узел вправо;
        // постусловие - курсор указывает на следующий справа элемент
        public abstract void right();

        // вставить следом за текущим узлом новый узел с заданным значением;
        // постусловие - новый узел вставлен спhава
        public abstract void put_right(T value);

        // вставить перед текущим узлом новый узел с заданным значением;
        // постусловие - новый узел вставлен слева
        public abstract void put_left(T value);

        // удалить текущий узел (курсор смещается к правому соседу, если он есть, в противном случае курсор смещается к левому соседу, если он есть);
        // постусловие - текущий узел удален
        public abstract void remove();

        // очистить список;
        // постусловие - из списка удалятся все значения
        public abstract void clear();

        // добавить новый узел в хвост списка;
        // постусловие - в конец списка добавлен новый узел
        public abstract void add_tail(T value);

        // заменить значение текущего узла на заданное;
        // постусловие - текущее значение заменено
        public abstract void replace(T value);

        // установить курсор на следующий узел с искомым значением(по отношению к текущему узлу);
        // постусловие - курсор установлен на искомое значение
        public abstract void find(T value);

        // удалить в списке все узлы с заданным значением;
        // постусловие - все узлы с текущим значение удалены
        public abstract void remove_all(T value);

        // ЗАПРОСЫ

        // получить значение текущего узла;
        // предусловие: курсор указывает на какой-нибудь элемент
        public abstract T get();

        // посчитать количество узлов в списке.
        public abstract int size();

        // находится ли курсор в начале списка?
        public abstract bool is_head();

        // находится ли курсор в конце списка?
        public abstract bool is_tail();

        // установлен ли курсор на какой-либо узел в списке (по сути, непустой ли список).
        public abstract bool is_value();

        // ДОПОЛНИТЕЛЬНЫЕ ЗАПРОСЫ

        public abstract int get_get_status(); // возвращает значение GET_*
        public abstract int get_right_status(); // возвращает значение RIGHT_*
        public abstract int get_remove_status(); // возвращает значение REMOVE_*

    }
}
