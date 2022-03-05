using Accord.MachineLearning.Bayes;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Distributions.Univariate;
using IrisNaiveBayes.ClassificationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisNaiveBayes.Alogrithm
{
    public class NaivebayesClass : AbstractCommon
    {
        public NaiveBayes<NormalDistribution> BayesianModel { get; private set; }
        
        public override double TrainClassifier(ProcessData trainingData)
        {
            double classifierErr = 0;
            BayesianModel = new NaiveBayes<NormalDistribution>(
                trainingData.OutputPossibleValues,
                trainingData.InputAttributeNumber,
                NormalDistribution.Standard);
            classifierErr = BayesianModel.Estimate(
                trainingData.InputData,
                trainingData.OutputData,
                true,
                new NormalOptions { Regularization = 1e-5 });
            return classifierErr;
        }

        public override int[] TestClassifier(ProcessData testingData)
        {
            List<int> results = new List<int>();

            // Predict the results for a series of inputs.
            foreach (double[] input in testingData.InputData)
            {
                results.Add(BayesianModel.Compute(input));
            }

            return results.ToArray();
        }

        public override int ComputeResult(double[] testingInput)
        {
            int result = BayesianModel.Compute(testingInput);
            return result;
        }
    }
}
