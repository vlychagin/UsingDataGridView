using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingDataGridView.Infrastructure;
using UsingDataGridView.Models;

/*
 * контроллер - обработки по заданию
 * коллекция редких музыкальных инструментов и ее обработки по заданию
 * 1. Сортировки копии коллекции с выводом отсортированной коллекции
 *    в DataGridView в другой вкладке:
 *     • по названию
 *     • по мастеру
 *     • по году изготовления
 *     • по убыванию страховой стоимости
 * 2. Выборка из коллекции:
 *     • по категории
 *     • по мастеру, создавшему инструмент
 *     • по городу хранения
*/

namespace UsingDataGridView.Controllers;

internal class RareMusicalController
{
    // коллекция редких музыкальных инструментов
    public List<MusicalInstrument> RareMusicals { get; set; } = new List<MusicalInstrument>();

    // имя файла для колекции
    public string FileName { get; set; }


    public RareMusicalController() {
        Initializer();
        FileName = "rare_musical.json";
    }


    public RareMusicalController(List<MusicalInstrument> rareMusicals, string fileName) {
        RareMusicals = rareMusicals;
        FileName = fileName;
    } // RareMusicalController


    // инициализация коллекции
    public void Initializer() {
        RareMusicals.Clear();

        int n = Utils.GetRandom(12, 20);
        for (int i = 0; i < n; i++) {
            var instrument = MusicalInstrument.MusicalInstrumentBuilder();
            instrument.Id = i + 1;
            RareMusicals.Add(instrument);
        } // for i
    } // Initializer

    // Сортировка копии коллекции по названию
    public IEnumerable<MusicalInstrument> OrderByName() {
        var copy = new List<MusicalInstrument>(RareMusicals);
        copy.Sort((a, b) => a.Name.CompareTo(b.Name));
        return copy;
    } // OrderByName


    // Сортировка копии коллекции по мастеру
    public IEnumerable<MusicalInstrument> OrderByArtisan() {
        var copy = new List<MusicalInstrument>(RareMusicals);
        copy.Sort((a, b) => a.Artisan.CompareTo(b.Artisan));
        return copy;
    } // OrderByArtisan


    // Сортировка копии коллекции по году изготовления
    public IEnumerable<MusicalInstrument> OrderByYear() {
        var copy = new List<MusicalInstrument>(RareMusicals);
        copy.Sort((a, b) => a.Year.CompareTo(b.Year));
        return copy;
    } // OrderByYear


    // Сортировка копии коллекции убыванию страховой стоимости
    public IEnumerable<MusicalInstrument> OrderByInsuranceDesc() {
        var copy = new List<MusicalInstrument>(RareMusicals);
        copy.Sort((a, b) => b.Insurance.CompareTo(a.Insurance));
        return copy;
    } // OrderByInsuranceDesc


    // Выборка из коллекции по категории
    public IEnumerable<MusicalInstrument> SelectWhereCategory(string category) =>
        RareMusicals.FindAll(m => m.Category == category);

    // Выборка из коллекции по мастеру, создавшему инструмент
    public IEnumerable<MusicalInstrument> SelectWhereArtisan(string artisan) =>
        RareMusicals.FindAll(m => m.Artisan == artisan);

    // Выборка из коллекции по городу хранения
    public IEnumerable<MusicalInstrument> SelectWhereCity(string city) =>
        RareMusicals.FindAll(m => m.City == city);

    // Сериализация в JSON-строку и запись в файл
    public void Save() {

    } // Save

    // Чтение из файла и десериализация из JSON-строку
    public void Load() {

    } // Load

} // class RareMusicalController

