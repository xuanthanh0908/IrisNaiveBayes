using Accord.Math;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisNaiveBayes.ClassificationData
{
    public class ProcessData
    {
        public DataTable ExtractedDataset { get; private set; }
        public DataTable ProcessedDataset { get; private set; }
        public Codification CodeBook { get; private set; }
        public List<string> AllColumnNames { get; private set; }
        public List<string> InputColumnNames { get; private set; }
        public string OutputColumnName { get; private set; }
        public double[][] InputData { get; private set; }
        public int[] OutputData { get; private set; }
        public int InputAttributeNumber { get; private set; }
        public int OutputPossibleValues { get; private set; }

        public ProcessData()
        {
            initializeVariables();
        }
        private void initializeVariables()
        {
            ExtractedDataset = new DataTable();
            ProcessedDataset = new DataTable();
            CodeBook = new Codification();
            AllColumnNames = new List<string>();
            InputColumnNames = new List<string>();
            InputData = null;
            OutputData = null;
            InputAttributeNumber = 0;
            OutputPossibleValues = 0;
        }
        public bool OpenFileTraining(string path, bool HasHeader)
        {
            try
            {
                using (StreamReader file = new StreamReader(path)) // doc file txt
                {
                    string Line = "";
                    string[] ArrayLine = null;
                    Line = file.ReadLine(); // doc dong dau tien
                    ArrayLine = Line.Split(',');
                    for (int i = 0; i < ArrayLine.Length; i++)
                    {
                        if (!HasHeader)
                            AllColumnNames.Add("Attr_" + (i + 1).ToString());
                        else
                            AllColumnNames.Add(ArrayLine[i]);
                        ExtractedDataset.Columns.Add(AllColumnNames[i], typeof(string));
                    }
                    if (!HasHeader)
                        ExtractedDataset.Rows.Add(ArrayLine);
                    while ((Line = file.ReadLine()) != null)
                    {
                        ArrayLine = Line.Split(',');
                        ExtractedDataset.Rows.Add(ArrayLine);
                    }
                }
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        [Obsolete]

        public bool ProcessDataset(string AttrPredict, Codification Codebook = null)
        {

            ProcessedDataset = ExtractedDataset.Clone();

            InputData = new double[ExtractedDataset.Rows.Count][];
            OutputData = new int[ExtractedDataset.Rows.Count];

            foreach (DataColumn column in ExtractedDataset.Columns)
            {
                if (column.ColumnName != AttrPredict)
                {
                    InputColumnNames.Add(column.ColumnName);
                    ProcessedDataset.Columns[column.Ordinal].DataType = typeof(double);
                }
                else
                    OutputColumnName = column.ColumnName;
            }

            try
            {
                double tempValue = 0;
                DataRow processedRow = null;
                List<double> tempInput = null;

                for (int i = 0; i < ExtractedDataset.Rows.Count; i++)
                {
                    processedRow = ProcessedDataset.NewRow();
                    tempInput = new List<double>();
                    foreach (DataColumn column in ExtractedDataset.Columns)
                    {
                        if (column.ColumnName != AttrPredict)
                        {
                            Double.TryParse(
                                ExtractedDataset.Rows[i][column.Ordinal] as string,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                out tempValue);
                            processedRow[column.Ordinal] = tempValue;
                            tempInput.Add(tempValue);
                        }
                        else
                        {
                            processedRow[column.Ordinal] = ExtractedDataset.Rows[i][column.Ordinal];
                        }
                    }
                    ProcessedDataset.Rows.Add(processedRow);
                    InputData[i] = tempInput.ToArray();
                }
                if (Codebook != null)
                    this.CodeBook = Codebook;
                else
                    CodeBook = new Codification(ExtractedDataset, AttrPredict);

                ProcessedDataset = CodeBook.Apply(ProcessedDataset);

                OutputData = ProcessedDataset.ToArray<int>(AttrPredict);

                InputAttributeNumber = ExtractedDataset.Columns.Count - 1;

                OutputPossibleValues = CodeBook[AttrPredict].Symbols;
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }
    }
}
