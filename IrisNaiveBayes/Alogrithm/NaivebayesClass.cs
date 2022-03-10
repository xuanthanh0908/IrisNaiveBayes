using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Distributions.Univariate;
using System.Collections.Generic;
using IrisNaiveBayes.ClassificationData;


namespace IrisNaiveBayes.Alogrithm
{
    public class NaivebayesClass : AbstractCommon
    {
        public NaiveBayes<NormalDistribution> BayesianModel { get; private set; }
        public NaivebayesClass()
        {

        }

        public override double TrainClassifier(ProcessData trainingData)
        {
            double classifierError = 0;

            // Create a new Naive Bayes classifier.
            BayesianModel = new NaiveBayes<NormalDistribution>(
               trainingData.OutputPossibleValues,
               trainingData.InputAttributeNumber,
               NormalDistribution.Standard);

            // Compute the Naive Bayes model.
            classifierError = BayesianModel.Estimate(
                trainingData.InputData,
                trainingData.OutputData,
                true,
                new NormalOptions { Regularization = 1e-5 /* To avoid zero variances. */ });

            return classifierError;
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
