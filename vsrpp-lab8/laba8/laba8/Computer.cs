using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Computer
    {
        public string CPU { get; set; }

        public int NumberOfRAM { get; set; }

        public string GPU { get; set; }

        public int NumberOfCore { get; set; }

        public Computer(string cpu,
            int numberOfRam,
            string gpu,
            int numberOfCore)
        {
            this.CPU = cpu;

            this.GPU = gpu;

            this.NumberOfCore = numberOfCore;

            this.NumberOfRAM = numberOfRam;
        }

        public Computer(string cpu, int numberOfRam, string gpu) : this(cpu,
           numberOfRam,
           gpu,
           8)
        {

        }

        public Computer(string cpu, int numberOfRam) : this(cpu,
            numberOfRam,
            "nvidia")
        {

        }

        public Computer(string cpu) : this(cpu,
            8)
        {

        }

        public Computer() : this("Intel")
        {

        }

        public override bool Equals(object obj)
        {
            if (obj is Computer
                && obj != null)
            {
                Computer tempComputer = (Computer)obj;

                if (this.CPU == tempComputer.CPU
                    && this.GPU == tempComputer.GPU
                    && this.NumberOfCore == tempComputer.NumberOfCore
                    && this.NumberOfRAM == tempComputer.NumberOfRAM)
                {
                    return true;
                }
            }

            return false;
        }

        public virtual string Show() => $"Процессор: {CPU}\n" +
            $"Количество оперативной памяти: {NumberOfRAM}\n" +
            $"Количество ядер: {NumberOfRAM}\n" +
            $"Видеокарта: {GPU}";

        public override string ToString() => string.Format($"{CPU}," +
           $"{NumberOfRAM}," +
           $"{NumberOfRAM}," +
           $"{GPU}");
    }
}
