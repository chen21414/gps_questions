using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class DateTransform
{

    public static void Main(string[] args)
    {
        var input = new List<string> {"2010/02/20", "19/12/2016",
                                      "11-18-2012", "20130720"};
        DateTransform.TransformDateFormat(input).ForEach(Console.WriteLine);
    }
    public static List<string> TransformDateFormat(List<string> input)
    {
        List<string> list = new List<string>();
        foreach (string dt in input)
        {
            string newDate = ConvertToStandard(dt);

            if (newDate != null)
            {
                list.Add(newDate);
            }
        }
        return list;
    }
    private static string ConvertToStandard(string value)
    {
        if (DateTime.TryParseExact(value,
              //TODO: add more formats here if you want
              new string[] { "yyyy/M/d", "d/M/yyyy", "M-d-yyyy" },
              CultureInfo.InvariantCulture,
              DateTimeStyles.AssumeLocal,
              out var date))
            return date.ToString("yyyyMMdd"); //TODO: Put the right format here
        else // parsing failed. You may want to throw new ArgumentException here
            return null;
    }

}


//answer:
//https://stackoverflow.com/questions/70508654/c-sharp-an-application-requires-date-formats-to-be-converted-into-one-common-dat

//toList()
//https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.tolist?view=net-6.0
