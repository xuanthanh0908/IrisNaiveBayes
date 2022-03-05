using Accord.Controls;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using IrisNaiveBayes.Alogrithm;
using IrisNaiveBayes.ClassificationData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisNaiveBayes
{
    public partial class MainForm : Form
    {
        private AbstractCommon classifier;
        private ProcessData trainingData;
        private ProcessData testingData;
        private double classifierError;
        private double predictionError;
        private List<string> classificationMethods;
        private Dictionary<string, IKernel> kernelList;
        private Dictionary<string, SupportVectorMachineLearningConfigurationFunction> algorithmList;
        // Flags.
        private bool trainingFileLoaded;

        private bool testingFileLoaded;
        private bool dataTrained;
        private bool attributeChosen;
        private bool classifierChosen;
        // Used to measure performance.
        private Stopwatch chronometer;
        // Used to visualize the confusion matrix.
        private ConfusionMatrixView matrixVisualizer;
        public MainForm()
        {
            InitializeComponent();
            classifierError = 0;
            predictionError = 0;
            trainingFileLoaded = false;
            testingFileLoaded = false;
            dataTrained = false;
            attributeChosen = false;
            classifierChosen = false;
            chronometer = new Stopwatch();

            classificationMethods = new List<string>
            {
                "Naive Bayesian"
            };

            kernelList = new Dictionary<string, IKernel>
            {
                {"Default", null},
                {"Linear", new Linear()},
                {"Gaussian", new Gaussian()},
                {"Laplacian", new Laplacian()},
                {"Chi Square", new ChiSquare()},
                {"Histogram Intersection", new HistogramIntersection()}
            };
        }

        private void btn_open_train_Click(object sender, EventArgs e)
        {
            ClassificationLog_richTxt.SelectionStart = ClassificationLog_richTxt.Text.Length;
            ClassificationLog_richTxt.ScrollToCaret();
            if(training_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                trainingData = new ProcessData();
                if (!trainingData.OpenFileTraining(training_openFileDialog.FileName, true))
                {
                    ClassificationLog_richTxt.SelectionColor = Color.Red;
                    ClassificationLog_richTxt.SelectedText =
                        "==========> Training file :" +
                        training_openFileDialog.FileName + 
                    " xảy ra lỗi !!" +
                    Environment.NewLine;
                }
                trainingFileLoaded = true;
                ClassificationLog_richTxt.SelectionColor = Color.Green;
                ClassificationLog_richTxt.SelectedText =
                    "==========> Training file :" +
                    training_openFileDialog.FileName +
                " thành công !!" +
                Environment.NewLine;

                // set some data to form
                DGV_training.DataSource = trainingData.ExtractedDataset;
                CB_Predict.DataSource = trainingData.AllColumnNames;
                CB_Predict.SelectedIndex = -1;
                CB_Predict.Enabled = true;
                CB_alogrithm.DataSource = classificationMethods;
                CB_alogrithm.SelectedIndex = -1;
                CB_alogrithm.Enabled = true;
                btn_run_train.Enabled = attributeChosen && classifierChosen;
                btn_run_test.Enabled = trainingFileLoaded && testingFileLoaded && dataTrained;
                reset_button.Enabled = true;
            }
        }

        private void CB_Predict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Predict.SelectedIndex >= 0)
                attributeChosen = true;
            else
                attributeChosen = false;
            btn_run_train.Enabled = attributeChosen && classifierChosen;
        }

        private void btn_run_train_Click(object sender, EventArgs e)
        {
            ClassificationLog_richTxt.SelectionStart = ClassificationLog_richTxt.Text.Length;
            ClassificationLog_richTxt.ScrollToCaret();
            if (!trainingData.Processdata(CB_Predict.SelectedItem.ToString()))
            {
                ClassificationLog_richTxt.SelectionColor = Color.Red;
                ClassificationLog_richTxt.SelectedText =
                    "=====> Có lỗi xảy ra trong quá trình training dữ liệu !!" +
                    Environment.NewLine;
                return;
            }
            ClassificationLog_richTxt.SelectionColor = Color.Green;
            ClassificationLog_richTxt.SelectedText =
                "=====> Training dữ liệu thành công !!" +
                Environment.NewLine;
            switch (CB_alogrithm.SelectedItem.ToString())
            {
                case "Naive Bayesian":
                    classifier = new NaivebayesClass();
                    break;
                default:
                    // Return if no valid classifier is selected.
                    return;
            }
            chronometer.Reset();
            chronometer.Start();
            try
            {
                if (classifier is NaivebayesClass)
                    classifierError = ((NaivebayesClass)classifier).TrainClassifier(
                        trainingData);
                /*svmAlgorithm_comboBox*/
            }
            catch
            {
                ClassificationLog_richTxt.SelectionColor = Color.Red;
                ClassificationLog_richTxt.SelectedText =
                    "=====> Có lỗi xảy ra trong quá trình training dữ liệu !!" +
                    Environment.NewLine;
                return;
            }
            chronometer.Stop();
            ClassificationLog_richTxt.SelectionColor = Color.Green;
            ClassificationLog_richTxt.SelectedText =
                "=====> Phân lớp dữ liệu traning thành công !!" +
                Environment.NewLine;
            // show performance
            trainingTimeValue_label.ForeColor = Color.Blue;
            trainingTimeValue_label.Text = chronometer.ElapsedMilliseconds + " ms";
            classifierErrorValue_label.ForeColor = (classifierError == 0) ? Color.Green : Color.Red;
            classifierErrorValue_label.Text =
                string.Format("{0:0.00}", classifierError * 100) + "%";
            dataTrained = true;
            CB_Predict.Enabled = false;
            CB_alogrithm.Enabled = false;
            btn_run_train.Enabled = false;
            btn_run_test.Enabled = trainingFileLoaded && testingFileLoaded && dataTrained;
        }
    }
}
