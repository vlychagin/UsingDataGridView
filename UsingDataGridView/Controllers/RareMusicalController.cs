using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingDataGridView.Models;

/*
* коллекция редких музыкальных инструментов и ее обработки по заданию
 * 1. Сортировки копии коллекции с выводом отсортированной коллекции
 *    в DataGridView в другой вкладке:
 *     • по названию
 *     • по мастеру
 *     • по году изготовления
 *     • по убыванию цены
 * 2. Выборка из коллекции:
 *     • по категории
 *     • по мастеру, создавшему инструмент
 *     • по городу хранения
*/

namespace UsingDataGridView.Controllers;

internal class RareMusicalController
{
    // коллекция редких музыкальных инструментов
    public List<MusicalInstrument> RareMusicals { get; set;} = new List<MusicalInstrument>();

    // инициализация коллекции
    public void Initializer() {

    } // Initializer
} // class RareMusicalController

