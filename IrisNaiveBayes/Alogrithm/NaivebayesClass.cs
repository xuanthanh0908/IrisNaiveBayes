
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

        public override double TrainClassifier(ProcessData trainingData) // xử lý sự kiện
        {
            // Vân làm phần này
            double classifierError = 0;

            // Create a new Naive Bayes classifier.
            BayesianModel = new NaiveBayes<NormalDistribution>(
               trainingData.OutputPossibleValues,//huấn luyện dl các gt đầu ra (tương tự Y và N ..class)
               trainingData.InputAttributeNumber,//huyến luyện dl số thuộc tính đầu vào (dl phân tích 012..)
               NormalDistribution.Standard);//phân phối bình thg theo tiêu chuẩn

            // Compute the Naive Bayes model.
            classifierError = BayesianModel.Estimate(// = ước tính mô hình bayes //classifierError: tg tu dữ liệu-> loại j
                trainingData.InputData,//dl đầu vào // tương tự X trong ML
                trainingData.OutputData,//dl đầu ra // tương tự y
                true,
                new NormalOptions { Regularization = 1e-5 /* Để tránh không có phương sai. tránh kết quả = 0*/ });

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
