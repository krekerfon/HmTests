using NUnit.Framework;
using System;
using System.Collections;
using System.Configuration;
using System.Linq;

namespace NUnitTests.CaseData
{
    public class CaseSource 
    {
        private static string[] listCaseTwoArgRealData = ConfigurationManager.AppSettings.AllKeys
                            .Where(caseKey => caseKey.StartsWith("twoArgsReal"))
                            .Select(caseKey => ConfigurationManager.AppSettings[caseKey])
                            .ToArray();

        private static string[] listCaseTwoArgIntData = ConfigurationManager.AppSettings.AllKeys
                          .Where(caseKey => caseKey.StartsWith("twoArgsInt"))
                          .Select(caseKey => ConfigurationManager.AppSettings[caseKey])
                          .ToArray();

        public static IEnumerable IntTestCasesTwoArg
        {
            get
            {
                foreach (var v in listCaseTwoArgIntData)
                {
                    var args = v.Split(',');
                    yield return new TestCaseData(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                }
            }
        }

        public static IEnumerable DoubleTestCasesTwoArg
        {
            get
            {
                foreach (var v in listCaseTwoArgRealData)
                {
                    var args = v.Split(',');
                    yield return new TestCaseData(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
                }
            }
        }

        public static IEnumerable StringTestCasesTwoArg
        {
            get
            {
                var args = listCaseTwoArgRealData.Concat(listCaseTwoArgIntData);
                foreach (var v in args)
                {
                    var caseData = v.Split(',');
                    yield return new TestCaseData(caseData[0], caseData[1]);
                }
            }
        }

        public static double[] NegativeDouble =>
            ConfigurationManager.AppSettings["NegativeReal"]
            .Split(',')
            .Select(x => Convert.ToDouble(x))
            .ToArray();

        public static double[] PositiveDouble =>
            ConfigurationManager.AppSettings["PositiveReal"]
            .Split(',')
            .Select(x => Convert.ToDouble(x))
            .ToArray();

        public static int[] PositiveInt =>
            ConfigurationManager.AppSettings["PositiveInt"]
            .Split(',')
            .Select(x => Convert.ToInt32(x))
            .ToArray();

        public static Double[] RealValues =>
          ConfigurationManager.AppSettings["RealValues"]
          .Split(',')
          .Select(x => Convert.ToDouble(x))
          .ToArray();

        public static string[] StringRealValues =>
          ConfigurationManager.AppSettings["RealValues"]
          .Split(',')
          .ToArray();

        public static int[] IntValues =>
          ConfigurationManager.AppSettings["IntValues"]
          .Split(',')
          .Select(x => Convert.ToInt32(x))
          .ToArray();

        public static string[] StringIntValues =>
         ConfigurationManager.AppSettings["IntValues"]
         .Split(',')
         .ToArray();

        public static int[] NegativeInt =>
           ConfigurationManager.AppSettings["NegativeInt"]
           .Split(',')
           .Select(x => Convert.ToInt32(x))
           .ToArray();

        public static string[] NotNumberArgs =>
          ConfigurationManager.AppSettings["NotNumberArgs"]
          .Split(',');

    }
}
