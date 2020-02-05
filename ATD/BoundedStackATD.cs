using System.Collections.Generic;

namespace ATD
{
    public abstract class BoundedStackATD<T>
    {
        public const int POP_NIL = 0; // pop() ещё не вызывалась
        public const int POP_OK = 1; // последняя pop() отработала нормально
        public const int POP_ERR = 2; // стек пуст

        public const int PEEK_NIL = 0; // peek() ещё не вызывалась
        public const int PEEK_OK = 1; // последняя peek() вернула корректное значение 
        public const int PEEK_ERR = 2; // стек пуст

        public const int PUSH_NIL = 0; // push() ещё не вызывалась
        public const int PUSH_OK = 1; // последняя push() выполнилась корректно
        public const int PUSH_ERR = 2; // стек уже полностью заполнен

        // конструктор
        protected BoundedStackATD(int maxSize = 32) {}
        // постусловие: создан новый пустой стек


        // команды:
        // предусловие: количество элементов в стеке меньше максимально возможного; 
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
        public abstract int get_push_status(); // возвращает значение PUSH_*
    }

    public class BoundedStackImplementation<T> : BoundedStackATD<T>
    {
        // скрытые поля
        private List<T> stack; // основное хранилище стека

        private int peek_status; // статус запроса peek()
        private int pop_status; // статус команды pop()
        private int push_status; // статус команды push()

        private int maxSize;

        public BoundedStackImplementation(int maxSize = 32)
        {
            clear();
            this.maxSize = maxSize;
        }

        public override void push(T value)
        {
            if (size() < maxSize)
            {
                stack.Add(value);
                push_status = PUSH_OK;
            }
            else
                push_status = PUSH_ERR;
        }

        public override void pop()
        {
            if (size() > 0)
            {
                stack.RemoveAt(size() - 1);
                pop_status = POP_OK;
            }
            else
                pop_status = POP_ERR;
        }

        public override void clear()
        {
            stack = new List<T>(); // пустой список/стек
            // начальные статусы для предусловий peek() и pop()
            peek_status = PEEK_NIL;
            pop_status = POP_NIL;
            push_status = PUSH_NIL;
        }

        public override T peek()
        {
            T result = default(T);

            if (size() > 0)
            {
                result = stack[size() - 1];
                peek_status = PEEK_OK;
            }
            else
            {
                peek_status = PEEK_ERR;
            }

            return result;
        }

        public override int size()
        {
            return stack.Count;
        }

        public override int get_pop_status()
        {
            return pop_status;
        }

        public override int get_peek_status()
        {
            return peek_status;
        }

        public override int get_push_status()
        {
            return push_status;
        }
    }
}