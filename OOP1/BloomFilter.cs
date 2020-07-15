namespace OOP1
{
    public abstract class BloomFilter
    {
        protected BloomFilter(){}

        // КОМАНДЫ

        // постусловие: добавлена строка str1 в фильтр
        public abstract void add(string str1);
        
        // ЗАПРОСЫ
        public abstract bool is_value(string str1); // проверка, имеется ли строка str1 в фильтре
    }
}
