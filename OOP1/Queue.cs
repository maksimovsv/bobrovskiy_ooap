﻿namespace OOP1
{
    public abstract class Queue<T>
    {
        public Queue(){}

        //КОМАНДЫ

        // предусловие: очередь не пуста
        // постусловие: из начала очереди удален объект
        public abstract void dequeue();

        // постусловие: в конец очереди добавлен объект
        public abstract void enqueue(T value);

        // постусловие: очередь пуста
        public abstract void clear();


        //ЗАПРОСЫ

        public abstract int size();

        // предусловие: очередь не пуста        
        public abstract T peek();

        public abstract bool get_dequeue_status();
        public abstract bool get_peek_status();
    }
}
