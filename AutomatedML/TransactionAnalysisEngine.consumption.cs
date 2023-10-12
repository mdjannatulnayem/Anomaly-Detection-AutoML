﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace AutomatedML
{
    public partial class TransactionAnalysisEngine
    {
        /// <summary>
        /// model input class for TransactionAnalysisEngine.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"Time")]
            public float Time { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"V1")]
            public float V1 { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"V2")]
            public float V2 { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"V3")]
            public float V3 { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"V4")]
            public float V4 { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"V5")]
            public float V5 { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"V6")]
            public float V6 { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"V7")]
            public float V7 { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"V8")]
            public float V8 { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"V9")]
            public float V9 { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"V10")]
            public float V10 { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"V11")]
            public float V11 { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"V12")]
            public float V12 { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"V13")]
            public float V13 { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"V14")]
            public float V14 { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"V15")]
            public float V15 { get; set; }

            [LoadColumn(16)]
            [ColumnName(@"V16")]
            public float V16 { get; set; }

            [LoadColumn(17)]
            [ColumnName(@"V17")]
            public float V17 { get; set; }

            [LoadColumn(18)]
            [ColumnName(@"V18")]
            public float V18 { get; set; }

            [LoadColumn(19)]
            [ColumnName(@"V19")]
            public float V19 { get; set; }

            [LoadColumn(20)]
            [ColumnName(@"V20")]
            public float V20 { get; set; }

            [LoadColumn(21)]
            [ColumnName(@"V21")]
            public float V21 { get; set; }

            [LoadColumn(22)]
            [ColumnName(@"V22")]
            public float V22 { get; set; }

            [LoadColumn(23)]
            [ColumnName(@"V23")]
            public float V23 { get; set; }

            [LoadColumn(24)]
            [ColumnName(@"V24")]
            public float V24 { get; set; }

            [LoadColumn(25)]
            [ColumnName(@"V25")]
            public float V25 { get; set; }

            [LoadColumn(26)]
            [ColumnName(@"V26")]
            public float V26 { get; set; }

            [LoadColumn(27)]
            [ColumnName(@"V27")]
            public float V27 { get; set; }

            [LoadColumn(28)]
            [ColumnName(@"V28")]
            public float V28 { get; set; }

            [LoadColumn(29)]
            [ColumnName(@"Amount")]
            public float Amount { get; set; }

            [LoadColumn(30)]
            [ColumnName(@"Class")]
            public float Class { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for TransactionAnalysisEngine.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Time")]
            public float Time { get; set; }

            [ColumnName(@"V1")]
            public float V1 { get; set; }

            [ColumnName(@"V2")]
            public float V2 { get; set; }

            [ColumnName(@"V3")]
            public float V3 { get; set; }

            [ColumnName(@"V4")]
            public float V4 { get; set; }

            [ColumnName(@"V5")]
            public float V5 { get; set; }

            [ColumnName(@"V6")]
            public float V6 { get; set; }

            [ColumnName(@"V7")]
            public float V7 { get; set; }

            [ColumnName(@"V8")]
            public float V8 { get; set; }

            [ColumnName(@"V9")]
            public float V9 { get; set; }

            [ColumnName(@"V10")]
            public float V10 { get; set; }

            [ColumnName(@"V11")]
            public float V11 { get; set; }

            [ColumnName(@"V12")]
            public float V12 { get; set; }

            [ColumnName(@"V13")]
            public float V13 { get; set; }

            [ColumnName(@"V14")]
            public float V14 { get; set; }

            [ColumnName(@"V15")]
            public float V15 { get; set; }

            [ColumnName(@"V16")]
            public float V16 { get; set; }

            [ColumnName(@"V17")]
            public float V17 { get; set; }

            [ColumnName(@"V18")]
            public float V18 { get; set; }

            [ColumnName(@"V19")]
            public float V19 { get; set; }

            [ColumnName(@"V20")]
            public float V20 { get; set; }

            [ColumnName(@"V21")]
            public float V21 { get; set; }

            [ColumnName(@"V22")]
            public float V22 { get; set; }

            [ColumnName(@"V23")]
            public float V23 { get; set; }

            [ColumnName(@"V24")]
            public float V24 { get; set; }

            [ColumnName(@"V25")]
            public float V25 { get; set; }

            [ColumnName(@"V26")]
            public float V26 { get; set; }

            [ColumnName(@"V27")]
            public float V27 { get; set; }

            [ColumnName(@"V28")]
            public float V28 { get; set; }

            [ColumnName(@"Amount")]
            public float Amount { get; set; }

            [ColumnName(@"Class")]
            public uint Class { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public float PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("TransactionAnalysisEngine.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict scores for all possible labels.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static IOrderedEnumerable<KeyValuePair<string, float>> PredictAllLabels(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            var result = predEngine.Predict(input);
            return GetSortedScoresWithLabels(result);
        }

        /// <summary>
        /// Map the unlabeled result score array to the predicted label names.
        /// </summary>
        /// <param name="result">Prediction to get the labeled scores from.</param>
        /// <returns>Ordered list of label and score.</returns>
        /// <exception cref="Exception"></exception>
        public static IOrderedEnumerable<KeyValuePair<string, float>> GetSortedScoresWithLabels(ModelOutput result)
        {
            var unlabeledScores = result.Score;
            var labelNames = GetLabels(result);

            Dictionary<string, float> labledScores = new Dictionary<string, float>();
            for (int i = 0; i < labelNames.Count(); i++)
            {
                // Map the names to the predicted result score array
                var labelName = labelNames.ElementAt(i);
                labledScores.Add(labelName.ToString(), unlabeledScores[i]);
            }

            return labledScores.OrderByDescending(c => c.Value);
        }

        /// <summary>
        /// Get the ordered label names.
        /// </summary>
        /// <param name="result">Predicted result to get the labels from.</param>
        /// <returns>List of labels.</returns>
        /// <exception cref="Exception"></exception>
        private static IEnumerable<string> GetLabels(ModelOutput result)
        {
            var schema = PredictEngine.Value.OutputSchema;

            var labelColumn = schema.GetColumnOrNull("Class");
            if (labelColumn == null)
            {
                throw new Exception("Class column not found. Make sure the name searched for matches the name in the schema.");
            }

            // Key values contains an ordered array of the possible labels. This allows us to map the results to the correct label value.
            var keyNames = new VBuffer<float>();
            labelColumn.Value.GetKeyValues(ref keyNames);
            return keyNames.DenseValues().Select(x => x.ToString());
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}
