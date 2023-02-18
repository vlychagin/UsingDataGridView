namespace UsingDataGridView.Infrastructure
{
    public static class Utils
    {

        // объект для получения случайных чисел
        public static readonly Random Random = new Random(Environment.TickCount);

        // Получение случайного числа
        // краткая форма записи метода - это не лямбда выражение
        public static int GetRandom(int lo, int hi) => Random.Next(lo, hi + 1);
        public static double GetRandom(double lo, double hi) => lo + (hi - lo) * Random.NextDouble();

        public static string[] Categories =
        {
            "струнный",          // 0
            "духовой",           // 1
            "язычковый",         // 2
            "ударный",           // 3
            "клавишный",         // 4
            "механический",      // 5
            "электромузыкальный" // 6
        }; // Categories

        // шаблоны для инструментов
        public static (string Name, string Category)[] Instruments = new (string nameof, string Category)[] {
            ("скрипка",     Categories[0]), 
            ("виолончель",  Categories[0]),  
            ("контрабас",   Categories[0]), 
            ("гитара",      Categories[0]),  
            ("саксофон",    Categories[1]),  
            ("кларнет",     Categories[1]),
            ("фагот",       Categories[1]), 
            ("барабан",     Categories[2]), 
            ("треугольник", Categories[2]), 
            ("бубен",       Categories[2]),  
            ("цимбалы",     Categories[2]),  
            ("рояль",       Categories[3]),
            ("клавесин",    Categories[3]), 
            ("ор­ке­ст­ри­он",  Categories[4]), 
            ("арфа",        Categories[0]),
        }; // Instruments


        // имена мастеров
        public static string[] ArtisanNames = {
            "Павлова А.Ю.", "Игорев П.З.", "Захарова П.Е.", "Швац Е.Н.",
            "Елисеева А.В.", "Зайцева У.К.", "Голованок Г.Д.", "Осипов С.Н.",
            "Золотов С.И.", "Макаров М.Д.", "Петрова Е.А.", "Павлов К.К."
        }; // ArtisansName

        // города хранения
        public static string[] Cities = {
            "Макеевка", "Донецк", "Снежное", "Амвросиевка", "Мариуполь", "Горловка", "Волноваха", 
            "Новоазовск", "Старобешево", "Иловайск"
        };

    }
    // class Utils
}