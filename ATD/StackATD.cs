namespace ATD
{
    public abstract class StackATD<T>
    {
        public const int POP_NIL = 0; // pop() ещё не вызывалась
        public const int POP_OK = 1; // последняя pop() отработала нормально
        public const int POP_ERR = 2; // стек пуст

        public const int PEEK_NIL = 0; // peek() ещё не вызывалась
        public const int PEEK_OK = 1; // последняя peek() вернула корректное значение 
        public const int PEEK_ERR = 2; // стек пуст

        // конструктор
        protected StackATD() {}
        // постусловие: создан новый пустой стек
        

        // команды:
        // постусловие: в стек добавлено новое значение
        public abstract void push(T value);

        // предусловие: стек не пустой; 
        // постусловие: из стека удалён верхний элемент
        public abstract void pop();

        // постусловие: из стека удалятся все значения
        public abstract void clear();


        // запросы:
        // предусловие: стек не пустой
        public abstract T peek();

        public abstract int size();


        // дополнительные запросы:
        public abstract int get_pop_status(); // возвращает значение POP_*
        public abstract int get_peek_status(); // возвращает значение PEEK_*
    }
}