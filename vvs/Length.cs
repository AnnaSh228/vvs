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
        public static Length operator *(Length instance, double number)
        {
            
            return new Length(instance.value * number, instance.type); ;
        }

        public static Length operator *(double number, Length instance)
        {
            return instance * number;
        }


        public Length To(MeasureType newType)
        {
            var newValue = this.value;
         
            if (this.type == MeasureType.C)
            {
               
                switch (newType)
                {
                  
                    case MeasureType.C:
                        newValue = this.value;
                        break;

                    case MeasureType.F:
                        newValue = this.value * 32;
                        break;
               
                    case MeasureType.Ra:
                        newValue = this.value * 491.67;
                        break;
                    
                    case MeasureType.K:
                        newValue = this.value * 273.15;
                        break;
                }
            }
            else if(newType == MeasureType.C)
            {
                switch (this.type) 
                {
                    case MeasureType.C:
                        newValue = this.value;
                        break;
                    case MeasureType.F:
                        newValue = this.value / 32; 
                        break;
                    case MeasureType.Ra:
                        newValue = this.value / 491.67; 
                        break;
                    case MeasureType.K:
                        newValue = this.value / 273.15; 
                        break;
                }
            
            }
            else
            {
                newValue = this.To(MeasureType.C).To(newType).value;
            }
            return new Length(newValue, newType);
        }
        public static Length operator +(Length instance1, Length instance2)
        {
           
            return instance1 + instance2.To(instance1.type).value;
        }

        
        public static Length operator -(Length instance1, Length instance2)
        {
        
            return instance1 - instance2.To(instance1.type).value;
        }
        public static Length operator *(Length instance1, Length instance2)
        {

            return instance1 * instance2.To(instance1.type).value;
        }

    }
    
}

