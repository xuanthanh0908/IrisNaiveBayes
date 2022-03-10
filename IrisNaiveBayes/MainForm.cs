
using Accord.Controls;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using IrisNaiveBayes.ClassificationData;
using IrisNaiveBayes.Alogrithm;

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
            this.Size = new Size(1000, 630);
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
                this.Refresh();
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

        [Obsolete]
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
                    classifierError = classifier.TrainClassifier(trainingData);
            }
            catch
            {
                ClassificationLog_richTxt.SelectionColor = Color.Red;
                ClassificationLog_richTxt.SelectedText =
                    "=====> Có lỗi xảy ra trong quá trình sử dụng NaiveBayes training !!" +
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
            btn_open_testing.Enabled = trainingFileLoaded & dataTrained;
            btn_run_test.Enabled = trainingFileLoaded && testingFileLoaded && dataTrained;
        }

            // Deactivate some window's controls if
            // classifier's training was successful.
            attributeToPredict_comboBox.Enabled = false;
            classifierToUse_comboBox.Enabled = false;
            treeJoin_numericUpDown.Enabled = false;
            treeHeight_numericUpDown.Enabled = false;
            svmKernel_comboBox.Enabled = false;
            svmAlgorithm_comboBox.Enabled = false;
            decisionTree_checkBox.Enabled = false;
            this.Refresh();

            // Show a visual tree if decision tree classifier
            // was chosen and the user checked the check box.
        }

        private void CB_alogrithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_alogrithm.SelectedIndex >= 0)
            {
                classifierChosen = true;
                parameters_groupBox.Text = CB_alogrithm.SelectedValue.ToString();
                parameters_groupBox.Enabled = true;
                switch (CB_alogrithm.SelectedItem.ToString())
                {
                    case "Decision Tree":
                        treeParameters_panel.Visible = true;
                        bayesianParameters_panel.Visible = false;
                        svmParameters_panel.Visible = false;
                        break;
                    case "Naive Bayesian":
                        treeParameters_panel.Visible = false;
                        bayesianParameters_panel.Visible = true;
                        svmParameters_panel.Visible = false;
                        break;
                    case "SVM":
                        treeParameters_panel.Visible = false;
                        bayesianParameters_panel.Visible = false;
                        svmParameters_panel.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                classifierChosen = false;
                treeParameters_panel.Visible = false;
                bayesianParameters_panel.Visible = false;
                svmParameters_panel.Visible = false;
                parameters_groupBox.Text = "Training Parameters";
                parameters_groupBox.Enabled = false;
            }
            btn_run_train.Enabled = attributeChosen && classifierChosen;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            /*if (matrixVisualizer != null)
                matrixVisualizer.Close();*/
            trainingFileLoaded = false;
            testingFileLoaded = false;
            dataTrained = false;
            attributeChosen = false;
            classifierChosen = false;
            classifierError = 0;
            predictionError = 0;
            classifier = null;
            trainingData = null;
            testingData = null;
            /*parameters_groupBox.Enabled = false;
            treeParameters_panel.Visible = false;
            bayesianParameters_panel.Visible = false;
            svmParameters_panel.Visible = false;
            treeJoin_numericUpDown.Value = 0;
            treeJoin_numericUpDown.Enabled = true;
            treeHeight_numericUpDown.Value = 0;
            treeHeight_numericUpDown.Enabled = true;*/
           /* svmKernel_comboBox.SelectedIndex = 0;
            svmKernel_comboBox.Enabled = true;
            svmAlgorithm_comboBox.SelectedIndex = 0;
            svmAlgorithm_comboBox.Enabled = true;
            decisionTree_checkBox.Enabled = true;*/
            CB_Predict.DataSource = null;
            CB_Predict.Enabled = false;
            CB_alogrithm.DataSource = null;
            CB_alogrithm.Enabled = false;
            btn_open_train.Enabled = true;
            btn_run_train.Enabled = false;
            btn_open_testing.Enabled = false;
            DGV_training.DataSource = null;
            DGV_training.Enabled = false;
            trainingTimeValue_label.ForeColor = SystemColors.ControlText;
            testingTimeValue_label.ForeColor = SystemColors.ControlText;
            classifierErrorValue_label.ForeColor = SystemColors.ControlText;
            predictionErrorValue_label.ForeColor = SystemColors.ControlText;
            trainingTimeValue_label.Text = "-";
            testingTimeValue_label.Text = "-";
            classifierErrorValue_label.Text = "-";
            predictionErrorValue_label.Text = "-";
            ClassificationLog_richTxt.Clear();
            ClassificationLog_richTxt.Enabled = false;
        }

        private void btn_open_testing_Click(object sender, EventArgs e)
        {
            ClassificationLog_richTxt.SelectionStart = ClassificationLog_richTxt.Text.Length;
            ClassificationLog_richTxt.ScrollToCaret();
            if (testing_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                testingData = new ProcessData();
                if (!testingData.OpenFileTraining(testing_openFileDialog.FileName, true))
                {
                    ClassificationLog_richTxt.SelectionColor = Color.Red;
                    ClassificationLog_richTxt.SelectedText =
                        "==========> Testing file :" +
                        testing_openFileDialog.FileName +
                    " xảy ra lỗi !!" +
                    Environment.NewLine;
                }
                testingFileLoaded = true;
                ClassificationLog_richTxt.SelectionColor = Color.Green;
                ClassificationLog_richTxt.SelectedText =
                    "==========> Testing file :" +
                    testing_openFileDialog.FileName +
                " thành công !!" +
                Environment.NewLine;

                reset_button.Enabled = true;
                btn_run_test.Enabled = trainingFileLoaded && testingFileLoaded && dataTrained;
            }
        }

        [Obsolete]
        private void btn_run_test_Click(object sender, EventArgs e)
        {
            ClassificationLog_richTxt.SelectionStart = ClassificationLog_richTxt.Text.Length;
            ClassificationLog_richTxt.ScrollToCaret();

            if (!testingData.ProcessDataset(trainingData.OutputColumnName, trainingData.CodeBook))
            {
                ClassificationLog_richTxt.SelectionColor = Color.Red;
                ClassificationLog_richTxt.SelectedText =
                    "=====> Có lỗi xảy ra trong quá trình testing dữ liệu !!" +
                    Environment.NewLine;
                return;
            }
            ClassificationLog_richTxt.SelectionColor = Color.Green;
            ClassificationLog_richTxt.SelectedText =
                "=====> Testing dữ liệu thành công. Kết quả : " +
                Environment.NewLine;

            // Reset prediction error.
            predictionError = 0;
            chronometer.Reset();
            chronometer.Start();

            int[] predictedValues = classifier.TestClassifier(testingData);
            chronometer.Stop();

            for (int i = 0; i < predictedValues.Length; i++)
            {
                if (predictedValues[i] == testingData.OutputData[i])
                {
                    ClassificationLog_richTxt.SelectionColor = Color.Green;
                    ClassificationLog_richTxt.SelectedText =
                        "MATCHING: expected " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            testingData.OutputData[i]) +
                        " and predicted " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            predictedValues[i]) +
                            Environment.NewLine;
                }
                else
                {
                    ++predictionError;
                    ClassificationLog_richTxt.SelectionColor = Color.Red;
                    ClassificationLog_richTxt.SelectedText =
                        "NOT MATCHNG: expected " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            testingData.OutputData[i]) +
                        " but predicted " +
                        testingData.CodeBook.Translate(
                            testingData.OutputColumnName,
                            predictedValues[i]) +
                        Environment.NewLine;
                }
            }

            ClassificationLog_richTxt.SelectionStart = ClassificationLog_richTxt.Text.Length;
            ClassificationLog_richTxt.ScrollToCaret();

            // Đóng cửa sổ cũ hiển thị ma trận nhầm lẫn
            // (nếu có) và hiển thị một cửa sổ mới khi người dùng
            // đã đánh dấu vào hộp kiểm.
            if (matrixVisualizer != null)
                matrixVisualizer.Close();
            if (confusionMatrix_checkBox.Checked)
            {
                matrixVisualizer = new ConfusionMatrixView(testingData, predictedValues);
                matrixVisualizer.Show();
            }

            testingTimeValue_label.ForeColor = Color.Blue;
            testingTimeValue_label.Text = chronometer.ElapsedMilliseconds + " ms";
            predictionErrorValue_label.ForeColor = (predictionError == 0) ? Color.Green : Color.Red;
            predictionErrorValue_label.Text =
                string.Format("{0:0.00}", predictionError * 100 / predictedValues.Length) + "%";
        }
    }
}
