using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    public abstract class ParentQueue<T>
    {
        public ParentQueue() { }

        //КОМАНДЫ

        // предусловие: очередь не пуста
        // постусловие: из начала очереди удален объект
        public abstract void remove_front();

        // постусловие: в конец очереди добавлен объект
        public abstract void add_tail(T value);

        // постусловие: очередь пуста
        public abstract void clear();


        //ЗАПРОСЫ

        public abstract int size();

        // предусловие: очередь не пуста        
        public abstract T peek();

        public abstract bool get_remove_front_status();
        public abstract bool get_peek_status();
    }

    public abstract class Queue<T> : ParentQueue<T> {}

    public abstract class Deque<T> : ParentQueue<T>
    {
        protected Deque(){}

        //КОМАНДЫ

        // постусловие: в конец очереди добавлен объект
        public abstract void add_front(T value);

        // предусловие: очередь не пуста
        // постусловие: из конца очереди удален объект
        public abstract void remove_tail();

        //ЗАПРОСЫ

        public abstract bool get_remove_tail_status();
    }
}
