using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace uddip2.LifeTimeSample;

public class Function
{
    private int Count;

    public Function()
    {
        Count = 0;
        LambdaLogger.Log("Init");
    }
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(string input, ILambdaContext context)
    {
        LambdaLogger.Log("Invoked FuntionHandler");
        Count++;
        Thread.Sleep(5000);
        return $"{input} - {Count}".ToUpper();
    }
}
