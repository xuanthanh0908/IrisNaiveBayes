using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisNaiveBayes.ClassificationData
{
    abstract public class AbstractCommon
    {
        public AbstractCommon()
        {

        }
        abstract public double TrainClassifier(ProcessData trainingData);
        abstract public int[] TestClassifier(ProcessData testingData);
        abstract public int ComputeResult(double[] testingInput);
    }
}
