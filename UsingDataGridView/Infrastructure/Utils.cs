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
            "струнный", "духовой", "язычковый", "ударный",
            "клавишный", "механический", "электромузыкальный"
        }; // Categories


        public static (string Name, string Category)[] Instruments = new (string nameof, string Category)[] {
            ("скрипка", "струнный"), 
            ("виолончель", "струнный"),  
            ("контрабас", "струнный"), 
            ("гитара", "струнный"),  
            ("саксофон", "духовой"),  
            ("кларнет", "духовой"),
            ("фагот", "духовой"), 
            ("барабан", "ударный"), 
            ("треугольник", "ударный"), 
            ("бубен", "ударный"),  
            ("цимбалы", "ударный"),  
            ("рояль", "клавишный"),
            ("клавесин", "клавишный"), 
            ("ор­ке­ст­ри­он", "механический"), 
            ("арфа", "струнный"),
        }; // Instruments

        public static string[] ArtisanNames = {
            "Павлова А.Ю.", "Игорев П.З.", "Захарова П.Е.", "Швац Е.Н.",
            "Елисеева А.В.", "Зайцева У.К.", "Голованок Г.Д.", "Осипов С.Н.",
            "Золотов С.И.", "Макаров М.Д.", "Петрова Е.А.", "Павлов К.К."
        }; // ArtisansName

        public static int Index = 0;

        public static string[] Cities = {
            "Макеевка", "Донецк", "Снежное", "Амвросиевка", "Мариуполь", "Горловка", "Волноваха", 
            "Новоазовск", "Старобешево", "Иловайск"
        };

    }
    // class Utils
}