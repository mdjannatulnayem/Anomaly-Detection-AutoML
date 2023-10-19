using AutomatedML;

Console.WriteLine("Machine Learning-Based Credit Card Transaction Fraud Detection and Prevention System");

//Load sample data
var sampleData = new TransactionAnalysisEngine.ModelInput()
{
    V1 = 1.191857F,
    V2 = 0.2661507F,
    V3 = 0.1664801F,
    V4 = 0.4481541F,
    V5 = 0.06001765F,
    V6 = -0.08236081F,
    V7 = -0.07880298F,
    V8 = 0.08510166F,
    V9 = -0.2554251F,
    V10 = -0.1669744F,
    V11 = 1.612727F,
    V12 = 1.065235F,
    V13 = 0.489095F,
    V14 = -0.1437723F,
    V15 = 0.6355581F,
    V16 = 0.463917F,
    V17 = -0.1148047F,
    V18 = -0.1833613F,
    V19 = -0.145783F,
    V20 = -0.06908313F,
    V21 = -0.2257752F,
    V22 = -0.6386719F,
    V23 = 0.101288F,
    V24 = -0.3398465F,
    V25 = 0.1671704F,
    V26 = 0.1258945F,
    V27 = -0.008983099F,
    V28 = 0.01472417F,
    Amount = 2.69F,
};

//Load model and predict output
var result = TransactionAnalysisEngine.Predict(sampleData);


Console.WriteLine($"Predicted class:{result.Class}");
