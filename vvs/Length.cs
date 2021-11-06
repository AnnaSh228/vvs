using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vvs
{
    public enum MeasureType { C, F, Ra, K };
    public class Length
    {
        private double value;
        private MeasureType type;


        public Length(double value, MeasureType type)
        {
            this.value = value;
            this.type = type;
        }

       
        public string Verbose()

        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.C:
                    typeVerbose = "градус Цельсия";
                    break;
                case MeasureType.F:
                    typeVerbose = "градус Фаренгейта";
                    break;
                case MeasureType.Ra:
                    typeVerbose = "градус Ранкина";
                    break;
                case MeasureType.K:
                    typeVerbose = "Кельвинов";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
        public static Length operator +(Length instance, double number)
        {
            var newValue = instance.value + number;
            var length = new Length(newValue, instance.type);
            return length;
        }

        public static Length operator +(double number, Length instance)
        {
            return instance + number;
        }
        public static Length operator -(Length instance, double number)
        {
            return new Length(instance.value - number, instance.type); ;
        }

        public static Length operator -(double number, Length instance)
        {
            return instance - number;
        }
    }
}
