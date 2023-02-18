using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UsingDataGridView.Infrastructure;

namespace UsingDataGridView.Models;

/*
 * Инструмент описывается полями: 
 *     • числовой идентификатор
 *     • название инструмента
 *     • категория (духовой, струнный, ударный, и т.д.)
 *     • мастер, создавший инструмент
 *     • год изготовления инструмента
 *     • город хранения
 *     • страховая стоимость
 */
public class MusicalInstrument
{
    // числовой идентификатор
    public int Id { get; set; }

    // название инструмента
    public string Name { get; set; } = null!;

    // категор ия(духовой, струнный, ударный, и т.д.)
    public string Category { get; set; } = null!;

    // мастер, создавший инструмент
    public string Artisan { get; set; } = null!;

    // год изготовления инструмента
    public int Year { get; set; }

    // город хранения
    public string City { get; set; } = null!;

    // страховая стоимость
    public int Insurance { get; set; }

    // фабричный метод создания объекта класса MusicalInstrument
    public static MusicalInstrument MusicalInstrumentBuilder() {
        // получить индексы массивов-шаблонов
        int indexInstrument = Utils.GetRandom(0, Utils.Instruments.Length - 1);
        int indexArtisan = Utils.GetRandom(0, Utils.ArtisanNames.Length - 1);
        int indexCity = Utils.GetRandom(0, Utils.Cities.Length - 1);

        // генерация данных об инструменте
        return new MusicalInstrument {
            Name = Utils.Instruments[indexInstrument].Name,
            Category = Utils.Instruments[indexInstrument].Category,
            Artisan = Utils.ArtisanNames[indexArtisan],
            Year = Utils.GetRandom(1910, 1999),
            City = Utils.Cities[indexCity],
            Insurance = Utils.GetRandom(200, 3000) * 100
        };
    } // MusicalInstrumentBuilder

} // class MusicalInstrument

