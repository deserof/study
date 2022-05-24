using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Desktop : Computer
    {
        public int PowerBlock { get; set; }

        public string TypeBody { get; set; }

        public Desktop(int powerBlock,
            string typeBody)
            : base()
        {
            this.PowerBlock = powerBlock;

            this.TypeBody = typeBody;
        }

        public Desktop(int powerBlock)
            : this(powerBlock, "Mini Tower")
        {
        }

        public Desktop()
            : this(500)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj is Desktop
                && obj != null)
            {
                Desktop tempDesktop = (Desktop)obj;

                if (this.CPU == tempDesktop.CPU
                    && this.GPU == tempDesktop.GPU
                    && this.NumberOfCore == tempDesktop.NumberOfCore
                    && this.NumberOfRAM == tempDesktop.NumberOfRAM
                    && this.PowerBlock == tempDesktop.PowerBlock
                    && this.TypeBody == tempDesktop.TypeBody)
                {
                    return true;
                }
            }

            return false;
        }

        public override string Show() => $"Процессор: {CPU}\n" +
          $"Количество оперативной памяти: {NumberOfRAM}\n" +
          $"Количество ядер: {NumberOfRAM}\n" +
          $"Видеокарта: {GPU}\n" +
          $"Тип батареи: {PowerBlock}\n" +
          $"Время работы: {TypeBody}";

        public override string ToString() => string.Format($"Десктоп| Процессор: {CPU}" +
            $" Видеокарта: {GPU}" +
            $" Блок питания: {PowerBlock}");
    }
}
