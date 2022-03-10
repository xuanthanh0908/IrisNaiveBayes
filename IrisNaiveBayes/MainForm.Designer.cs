
namespace IrisNaiveBayes
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_run_train = new System.Windows.Forms.Button();
            this.CB_alogrithm = new System.Windows.Forms.ComboBox();
            this.CB_Predict = new System.Windows.Forms.ComboBox();
            this.btn_open_train = new System.Windows.Forms.Button();
            this.DGV_training = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.parameters_groupBox = new System.Windows.Forms.GroupBox();
            this.svmParameters_panel = new System.Windows.Forms.Panel();
            this.svmAlgorithm_comboBox = new System.Windows.Forms.ComboBox();
            this.svmKernel_comboBox = new System.Windows.Forms.ComboBox();
            this.svmAlgorithm_label = new System.Windows.Forms.Label();
            this.svmKernel_label = new System.Windows.Forms.Label();
            this.bayesianParameters_panel = new System.Windows.Forms.Panel();
            this.bayesian_label = new System.Windows.Forms.Label();
            this.treeParameters_panel = new System.Windows.Forms.Panel();
            this.decisionTree_checkBox = new System.Windows.Forms.CheckBox();
            this.treeHeight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.treeJoin_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.treeHeight_label = new System.Windows.Forms.Label();
            this.treeJoin_label = new System.Windows.Forms.Label();
            this.btn_open_testing = new System.Windows.Forms.Button();
            this.btn_run_test = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClassificationLog_richTxt = new System.Windows.Forms.RichTextBox();
            this.confusionMatrix_checkBox = new System.Windows.Forms.CheckBox();
            this.performance_groupBox = new System.Windows.Forms.GroupBox();
            this.trainingTime_label = new System.Windows.Forms.Label();
            this.testingTime_label = new System.Windows.Forms.Label();
            this.classifierError_label = new System.Windows.Forms.Label();
            this.predictionErrorValue_label = new System.Windows.Forms.Label();
            this.predictionError_label = new System.Windows.Forms.Label();
            this.trainingTimeValue_label = new System.Windows.Forms.Label();
            this.classifierErrorValue_label = new System.Windows.Forms.Label();
            this.testingTimeValue_label = new System.Windows.Forms.Label();
            this.training_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.testing_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.reset_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_training)).BeginInit();
            this.parameters_groupBox.SuspendLayout();
            this.svmParameters_panel.SuspendLayout();
            this.bayesianParameters_panel.SuspendLayout();
            this.treeParameters_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeHeight_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeJoin_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.performance_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_run_train);
            this.groupBox1.Controls.Add(this.CB_alogrithm);
            this.groupBox1.Controls.Add(this.CB_Predict);
            this.groupBox1.Controls.Add(this.btn_open_train);
            this.groupBox1.Controls.Add(this.DGV_training);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(716, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tập train";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn thuật toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn thuộc tính dự đoán";
            // 
            // btn_run_train
            // 
            this.btn_run_train.Enabled = false;
            this.btn_run_train.Location = new System.Drawing.Point(579, 201);
            this.btn_run_train.Margin = new System.Windows.Forms.Padding(2);
            this.btn_run_train.Name = "btn_run_train";
            this.btn_run_train.Size = new System.Drawing.Size(133, 44);
            this.btn_run_train.TabIndex = 4;
            this.btn_run_train.Text = "Chạy file train";
            this.btn_run_train.UseVisualStyleBackColor = true;
            this.btn_run_train.Click += new System.EventHandler(this.btn_run_train_Click);
            // 
            // CB_alogrithm
            // 
            this.CB_alogrithm.BackColor = System.Drawing.SystemColors.Control;
            this.CB_alogrithm.Enabled = false;
            this.CB_alogrithm.FormattingEnabled = true;
            this.CB_alogrithm.Location = new System.Drawing.Point(579, 161);
            this.CB_alogrithm.Margin = new System.Windows.Forms.Padding(2);
            this.CB_alogrithm.Name = "CB_alogrithm";
            this.CB_alogrithm.Size = new System.Drawing.Size(135, 21);
            this.CB_alogrithm.TabIndex = 3;
            this.CB_alogrithm.SelectedIndexChanged += new System.EventHandler(this.CB_alogrithm_SelectedIndexChanged);
            // 
            // CB_Predict
            // 
            this.CB_Predict.BackColor = System.Drawing.SystemColors.Control;
            this.CB_Predict.Enabled = false;
            this.CB_Predict.FormattingEnabled = true;
            this.CB_Predict.Location = new System.Drawing.Point(579, 107);
            this.CB_Predict.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Predict.Name = "CB_Predict";
            this.CB_Predict.Size = new System.Drawing.Size(135, 21);
            this.CB_Predict.TabIndex = 2;
            this.CB_Predict.SelectedIndexChanged += new System.EventHandler(this.CB_Predict_SelectedIndexChanged);
            // 
            // btn_open_train
            // 
            this.btn_open_train.Location = new System.Drawing.Point(579, 30);
            this.btn_open_train.Margin = new System.Windows.Forms.Padding(2);
            this.btn_open_train.Name = "btn_open_train";
            this.btn_open_train.Size = new System.Drawing.Size(133, 44);
            this.btn_open_train.TabIndex = 1;
            this.btn_open_train.Text = "Mở file train";
            this.btn_open_train.UseVisualStyleBackColor = true;
            this.btn_open_train.Click += new System.EventHandler(this.btn_open_train_Click);
            // 
            // DGV_training
            // 
            this.DGV_training.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_training.Location = new System.Drawing.Point(4, 16);
            this.DGV_training.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_training.Name = "DGV_training";
            this.DGV_training.RowHeadersWidth = 62;
            this.DGV_training.RowTemplate.Height = 28;
            this.DGV_training.Size = new System.Drawing.Size(555, 238);
            this.DGV_training.TabIndex = 0;
            // 
            // parameters_groupBox
            // 
            this.parameters_groupBox.Controls.Add(this.svmParameters_panel);
            this.parameters_groupBox.Controls.Add(this.bayesianParameters_panel);
            this.parameters_groupBox.Controls.Add(this.treeParameters_panel);
            this.parameters_groupBox.Enabled = false;
            this.parameters_groupBox.Location = new System.Drawing.Point(754, 14);
            this.parameters_groupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.parameters_groupBox.Name = "parameters_groupBox";
            this.parameters_groupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.parameters_groupBox.Size = new System.Drawing.Size(177, 248);
            this.parameters_groupBox.TabIndex = 24;
            this.parameters_groupBox.TabStop = false;
            this.parameters_groupBox.Text = "Tham số";
            // 
            // svmParameters_panel
            // 
            this.svmParameters_panel.Controls.Add(this.svmAlgorithm_comboBox);
            this.svmParameters_panel.Controls.Add(this.svmKernel_comboBox);
            this.svmParameters_panel.Controls.Add(this.svmAlgorithm_label);
            this.svmParameters_panel.Controls.Add(this.svmKernel_label);
            this.svmParameters_panel.Location = new System.Drawing.Point(5, 23);
            this.svmParameters_panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.svmParameters_panel.Name = "svmParameters_panel";
            this.svmParameters_panel.Size = new System.Drawing.Size(170, 220);
            this.svmParameters_panel.TabIndex = 2;
            this.svmParameters_panel.Visible = false;
            // 
            // svmAlgorithm_comboBox
            // 
            this.svmAlgorithm_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.svmAlgorithm_comboBox.FormattingEnabled = true;
            this.svmAlgorithm_comboBox.Location = new System.Drawing.Point(5, 66);
            this.svmAlgorithm_comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.svmAlgorithm_comboBox.Name = "svmAlgorithm_comboBox";
            this.svmAlgorithm_comboBox.Size = new System.Drawing.Size(159, 21);
            this.svmAlgorithm_comboBox.TabIndex = 13;
            // 
            // svmKernel_comboBox
            // 
            this.svmKernel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.svmKernel_comboBox.FormattingEnabled = true;
            this.svmKernel_comboBox.Location = new System.Drawing.Point(5, 19);
            this.svmKernel_comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.svmKernel_comboBox.Name = "svmKernel_comboBox";
            this.svmKernel_comboBox.Size = new System.Drawing.Size(159, 21);
            this.svmKernel_comboBox.TabIndex = 9;
            // 
            // svmAlgorithm_label
            // 
            this.svmAlgorithm_label.Location = new System.Drawing.Point(2, 48);
            this.svmAlgorithm_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.svmAlgorithm_label.Name = "svmAlgorithm_label";
            this.svmAlgorithm_label.Size = new System.Drawing.Size(161, 16);
            this.svmAlgorithm_label.TabIndex = 12;
            this.svmAlgorithm_label.Text = "Thuật toán";
            // 
            // svmKernel_label
            // 
            this.svmKernel_label.Location = new System.Drawing.Point(0, 1);
            this.svmKernel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.svmKernel_label.Name = "svmKernel_label";
            this.svmKernel_label.Size = new System.Drawing.Size(163, 16);
            this.svmKernel_label.TabIndex = 11;
            this.svmKernel_label.Text = "Kernel :";
            // 
            // bayesianParameters_panel
            // 
            this.bayesianParameters_panel.Controls.Add(this.bayesian_label);
            this.bayesianParameters_panel.Location = new System.Drawing.Point(5, 23);
            this.bayesianParameters_panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bayesianParameters_panel.Name = "bayesianParameters_panel";
            this.bayesianParameters_panel.Size = new System.Drawing.Size(172, 220);
            this.bayesianParameters_panel.TabIndex = 1;
            this.bayesianParameters_panel.Visible = false;
            // 
            // bayesian_label
            // 
            this.bayesian_label.Location = new System.Drawing.Point(2, 90);
            this.bayesian_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bayesian_label.Name = "bayesian_label";
            this.bayesian_label.Size = new System.Drawing.Size(161, 16);
            this.bayesian_label.TabIndex = 11;
            this.bayesian_label.Text = "No parameters to show.";
            this.bayesian_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // treeParameters_panel
            // 
            this.treeParameters_panel.Controls.Add(this.decisionTree_checkBox);
            this.treeParameters_panel.Controls.Add(this.treeHeight_numericUpDown);
            this.treeParameters_panel.Controls.Add(this.treeJoin_numericUpDown);
            this.treeParameters_panel.Controls.Add(this.treeHeight_label);
            this.treeParameters_panel.Controls.Add(this.treeJoin_label);
            this.treeParameters_panel.Location = new System.Drawing.Point(5, 23);
            this.treeParameters_panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeParameters_panel.Name = "treeParameters_panel";
            this.treeParameters_panel.Size = new System.Drawing.Size(172, 220);
            this.treeParameters_panel.TabIndex = 0;
            this.treeParameters_panel.Visible = false;
            // 
            // decisionTree_checkBox
            // 
            this.decisionTree_checkBox.Location = new System.Drawing.Point(5, 121);
            this.decisionTree_checkBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.decisionTree_checkBox.Name = "decisionTree_checkBox";
            this.decisionTree_checkBox.Size = new System.Drawing.Size(158, 16);
            this.decisionTree_checkBox.TabIndex = 12;
            this.decisionTree_checkBox.Text = "Show decision tree";
            this.decisionTree_checkBox.UseVisualStyleBackColor = true;
            // 
            // treeHeight_numericUpDown
            // 
            this.treeHeight_numericUpDown.Location = new System.Drawing.Point(5, 98);
            this.treeHeight_numericUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeHeight_numericUpDown.Name = "treeHeight_numericUpDown";
            this.treeHeight_numericUpDown.Size = new System.Drawing.Size(158, 20);
            this.treeHeight_numericUpDown.TabIndex = 12;
            this.treeHeight_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treeJoin_numericUpDown
            // 
            this.treeJoin_numericUpDown.Location = new System.Drawing.Point(5, 45);
            this.treeJoin_numericUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeJoin_numericUpDown.Name = "treeJoin_numericUpDown";
            this.treeJoin_numericUpDown.Size = new System.Drawing.Size(158, 20);
            this.treeJoin_numericUpDown.TabIndex = 11;
            this.treeJoin_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treeHeight_label
            // 
            this.treeHeight_label.Location = new System.Drawing.Point(2, 68);
            this.treeHeight_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.treeHeight_label.Name = "treeHeight_label";
            this.treeHeight_label.Size = new System.Drawing.Size(161, 27);
            this.treeHeight_label.TabIndex = 10;
            this.treeHeight_label.Text = "Maximum height of the tree (set 0 to use default):";
            // 
            // treeJoin_label
            // 
            this.treeJoin_label.Location = new System.Drawing.Point(2, 0);
            this.treeJoin_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.treeJoin_label.Name = "treeJoin_label";
            this.treeJoin_label.Size = new System.Drawing.Size(161, 42);
            this.treeJoin_label.TabIndex = 9;
            this.treeJoin_label.Text = "How many times a variable can join the decision process (set 0 to use default):";
            // 
            // btn_open_testing
            // 
            this.btn_open_testing.Enabled = false;
            this.btn_open_testing.Location = new System.Drawing.Point(579, 30);
            this.btn_open_testing.Margin = new System.Windows.Forms.Padding(2);
            this.btn_open_testing.Name = "btn_open_testing";
            this.btn_open_testing.Size = new System.Drawing.Size(133, 44);
            this.btn_open_testing.TabIndex = 1;
            this.btn_open_testing.Text = "Mở file test";
            this.btn_open_testing.UseVisualStyleBackColor = true;
            this.btn_open_testing.Click += new System.EventHandler(this.btn_open_testing_Click);
            // 
            // btn_run_test
            // 
            this.btn_run_test.Enabled = false;
            this.btn_run_test.Location = new System.Drawing.Point(579, 124);
            this.btn_run_test.Margin = new System.Windows.Forms.Padding(2);
            this.btn_run_test.Name = "btn_run_test";
            this.btn_run_test.Size = new System.Drawing.Size(133, 44);
            this.btn_run_test.TabIndex = 4;
            this.btn_run_test.Text = "Chạy file test";
            this.btn_run_test.UseVisualStyleBackColor = true;
            this.btn_run_test.Click += new System.EventHandler(this.btn_run_test_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClassificationLog_richTxt);
            this.groupBox2.Controls.Add(this.confusionMatrix_checkBox);
            this.groupBox2.Controls.Add(this.btn_run_test);
            this.groupBox2.Controls.Add(this.btn_open_testing);
            this.groupBox2.Location = new System.Drawing.Point(8, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(716, 258);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tập test";
            // 
            // ClassificationLog_richTxt
            // 
            this.ClassificationLog_richTxt.BackColor = System.Drawing.SystemColors.Control;
            this.ClassificationLog_richTxt.Location = new System.Drawing.Point(4, 16);
            this.ClassificationLog_richTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ClassificationLog_richTxt.Name = "ClassificationLog_richTxt";
            this.ClassificationLog_richTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ClassificationLog_richTxt.Size = new System.Drawing.Size(556, 239);
            this.ClassificationLog_richTxt.TabIndex = 13;
            this.ClassificationLog_richTxt.Text = "";
            // 
            // confusionMatrix_checkBox
            // 
            this.confusionMatrix_checkBox.Location = new System.Drawing.Point(579, 92);
            this.confusionMatrix_checkBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.confusionMatrix_checkBox.Name = "confusionMatrix_checkBox";
            this.confusionMatrix_checkBox.Size = new System.Drawing.Size(133, 16);
            this.confusionMatrix_checkBox.TabIndex = 12;
            this.confusionMatrix_checkBox.Text = "Hiện thị ma trận";
            this.confusionMatrix_checkBox.UseVisualStyleBackColor = true;
            // 
            // performance_groupBox
            // 
            this.performance_groupBox.Controls.Add(this.trainingTime_label);
            this.performance_groupBox.Controls.Add(this.testingTime_label);
            this.performance_groupBox.Controls.Add(this.classifierError_label);
            this.performance_groupBox.Controls.Add(this.predictionErrorValue_label);
            this.performance_groupBox.Controls.Add(this.predictionError_label);
            this.performance_groupBox.Controls.Add(this.trainingTimeValue_label);
            this.performance_groupBox.Controls.Add(this.classifierErrorValue_label);
            this.performance_groupBox.Controls.Add(this.testingTimeValue_label);
            this.performance_groupBox.Location = new System.Drawing.Point(757, 285);
            this.performance_groupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.performance_groupBox.Name = "performance_groupBox";
            this.performance_groupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.performance_groupBox.Size = new System.Drawing.Size(174, 164);
            this.performance_groupBox.TabIndex = 26;
            this.performance_groupBox.TabStop = false;
            this.performance_groupBox.Text = "Performance";
            // 
            // trainingTime_label
            // 
            this.trainingTime_label.AutoSize = true;
            this.trainingTime_label.Location = new System.Drawing.Point(10, 37);
            this.trainingTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainingTime_label.Name = "trainingTime_label";
            this.trainingTime_label.Size = new System.Drawing.Size(70, 13);
            this.trainingTime_label.TabIndex = 14;
            this.trainingTime_label.Text = "Training time:";
            // 
            // testingTime_label
            // 
            this.testingTime_label.AutoSize = true;
            this.testingTime_label.Location = new System.Drawing.Point(10, 88);
            this.testingTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testingTime_label.Name = "testingTime_label";
            this.testingTime_label.Size = new System.Drawing.Size(67, 13);
            this.testingTime_label.TabIndex = 15;
            this.testingTime_label.Text = "Testing time:";
            // 
            // classifierError_label
            // 
            this.classifierError_label.AutoSize = true;
            this.classifierError_label.Location = new System.Drawing.Point(10, 63);
            this.classifierError_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classifierError_label.Name = "classifierError_label";
            this.classifierError_label.Size = new System.Drawing.Size(75, 13);
            this.classifierError_label.TabIndex = 16;
            this.classifierError_label.Text = "Classifier error:";
            // 
            // predictionErrorValue_label
            // 
            this.predictionErrorValue_label.AutoSize = true;
            this.predictionErrorValue_label.Location = new System.Drawing.Point(97, 112);
            this.predictionErrorValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.predictionErrorValue_label.Name = "predictionErrorValue_label";
            this.predictionErrorValue_label.Size = new System.Drawing.Size(10, 13);
            this.predictionErrorValue_label.TabIndex = 21;
            this.predictionErrorValue_label.Text = "-";
            // 
            // predictionError_label
            // 
            this.predictionError_label.AutoSize = true;
            this.predictionError_label.Location = new System.Drawing.Point(10, 113);
            this.predictionError_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.predictionError_label.Name = "predictionError_label";
            this.predictionError_label.Size = new System.Drawing.Size(81, 13);
            this.predictionError_label.TabIndex = 17;
            this.predictionError_label.Text = "Prediction error:";
            // 
            // trainingTimeValue_label
            // 
            this.trainingTimeValue_label.AutoSize = true;
            this.trainingTimeValue_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trainingTimeValue_label.Location = new System.Drawing.Point(97, 37);
            this.trainingTimeValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainingTimeValue_label.Name = "trainingTimeValue_label";
            this.trainingTimeValue_label.Size = new System.Drawing.Size(10, 13);
            this.trainingTimeValue_label.TabIndex = 18;
            this.trainingTimeValue_label.Text = "-";
            // 
            // classifierErrorValue_label
            // 
            this.classifierErrorValue_label.AutoSize = true;
            this.classifierErrorValue_label.Location = new System.Drawing.Point(97, 62);
            this.classifierErrorValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classifierErrorValue_label.Name = "classifierErrorValue_label";
            this.classifierErrorValue_label.Size = new System.Drawing.Size(10, 13);
            this.classifierErrorValue_label.TabIndex = 20;
            this.classifierErrorValue_label.Text = "-";
            // 
            // testingTimeValue_label
            // 
            this.testingTimeValue_label.AutoSize = true;
            this.testingTimeValue_label.Location = new System.Drawing.Point(97, 88);
            this.testingTimeValue_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testingTimeValue_label.Name = "testingTimeValue_label";
            this.testingTimeValue_label.Size = new System.Drawing.Size(10, 13);
            this.testingTimeValue_label.TabIndex = 19;
            this.testingTimeValue_label.Text = "-";
            // 
            // training_openFileDialog
            // 
            this.training_openFileDialog.DereferenceLinks = false;
            this.training_openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.training_openFileDialog.InitialDirectory = "E:\\FILE DEV\\AI\\IrisNaiveBayes";
            // 
            // testing_openFileDialog
            // 
            this.testing_openFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.testing_openFileDialog.InitialDirectory = "E:\\FILE DEV\\AI\\IrisNaiveBayes";
            // 
            // reset_button
            // 
            this.reset_button.Enabled = false;
            this.reset_button.Location = new System.Drawing.Point(754, 462);
            this.reset_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(177, 49);
            this.reset_button.TabIndex = 27;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.performance_groupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.parameters_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_training)).EndInit();
            this.parameters_groupBox.ResumeLayout(false);
            this.svmParameters_panel.ResumeLayout(false);
            this.bayesianParameters_panel.ResumeLayout(false);
            this.treeParameters_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeHeight_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeJoin_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.performance_groupBox.ResumeLayout(false);
            this.performance_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_run_train;
        private System.Windows.Forms.ComboBox CB_alogrithm;
        private System.Windows.Forms.ComboBox CB_Predict;
        private System.Windows.Forms.Button btn_open_train;
        private System.Windows.Forms.DataGridView DGV_training;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox parameters_groupBox;
        private System.Windows.Forms.Panel svmParameters_panel;
        private System.Windows.Forms.ComboBox svmAlgorithm_comboBox;
        private System.Windows.Forms.ComboBox svmKernel_comboBox;
        private System.Windows.Forms.Label svmAlgorithm_label;
        private System.Windows.Forms.Label svmKernel_label;
        private System.Windows.Forms.Panel bayesianParameters_panel;
        private System.Windows.Forms.Label bayesian_label;
        private System.Windows.Forms.Panel treeParameters_panel;
        private System.Windows.Forms.CheckBox decisionTree_checkBox;
        private System.Windows.Forms.NumericUpDown treeHeight_numericUpDown;
        private System.Windows.Forms.NumericUpDown treeJoin_numericUpDown;
        private System.Windows.Forms.Label treeHeight_label;
        private System.Windows.Forms.Label treeJoin_label;
        private System.Windows.Forms.Button btn_open_testing;
        private System.Windows.Forms.Button btn_run_test;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox confusionMatrix_checkBox;
        private System.Windows.Forms.GroupBox performance_groupBox;
        private System.Windows.Forms.Label trainingTime_label;
        private System.Windows.Forms.Label testingTime_label;
        private System.Windows.Forms.Label classifierError_label;
        private System.Windows.Forms.Label predictionErrorValue_label;
        private System.Windows.Forms.Label predictionError_label;
        private System.Windows.Forms.Label trainingTimeValue_label;
        private System.Windows.Forms.Label classifierErrorValue_label;
        private System.Windows.Forms.Label testingTimeValue_label;
        private System.Windows.Forms.RichTextBox ClassificationLog_richTxt;
        private System.Windows.Forms.OpenFileDialog training_openFileDialog;
        private System.Windows.Forms.OpenFileDialog testing_openFileDialog;
        private System.Windows.Forms.Button reset_button;
        //Thêm
        private System.Windows.Forms.RichTextBox classificationLog_richTextBox;
        private System.Windows.Forms.ComboBox attributeToPredict_comboBox;
        private System.Windows.Forms.ComboBox classifierToUse_comboBox;
    }
}

