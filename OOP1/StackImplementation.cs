using System.Collections.Generic;

namespace OOP1
{
    public class StackImplementation<T> : StackATD<T>
    {
        // скрытые поля
        private List<T> stack; // основное хранилище стека
        private int peek_status; // статус запроса peek()
        private int pop_status; // статус команды pop()

        // интерфейс класса, реализующий АТД StackATD

        public StackImplementation()
        {
            clear();
        }

        public override void push(T value)
        {
            stack.Add(value);
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
    }
}