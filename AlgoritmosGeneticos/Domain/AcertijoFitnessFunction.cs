using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;
using System.Drawing;

namespace AlgoritmosGeneticos.Domain
{
    class AcertijoFitnessFunction
    {
        private static AcertijoFitnessFunction instance;
        private AcertijoFitnessFunction() {}

        public static AcertijoFitnessFunction Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AcertijoFitnessFunction();
                }
                return instance;
            }
        }

        
    }
}
