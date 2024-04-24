using System;
using System.Xml.Linq;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor
{
	internal static class Extensions
	{
		public static ParameterCollection DeepCopyJson(this ParameterCollection parameters)
		{
			return ParameterCollection.FromJson(parameters.ToJson());
		}

        public static string HumanReadable(this string text)
        {
            return text.FirstCharToUpper();
        }

        public static string FirstCharToUpper(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return $"{input[0].ToString().ToUpper()}{input.Substring(1)}";
        }

        public static string JoinOrEmpty(this string[]? values, string seperator)
        {
            if (values == null)
            {
                return string.Empty;
            }

            return string.Join(seperator, values);
        }

        public static Type GetDefaultSingleType(this ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Int:
                    return typeof(int);
                case ParameterType.String:
                    return typeof(string);
                case ParameterType.String_Multiline:
                    return typeof(string);
                case ParameterType.Decimal:
                    return typeof(decimal);
                case ParameterType.Bytes:
                    return typeof(byte[]);
                case ParameterType.Bool:
                    return typeof(bool);
                case ParameterType.DateTime:
                    return typeof(DateTime);
                case ParameterType.Date:
                    return typeof(DateTime);
                case ParameterType.String_IEnumerable:
                    return typeof(string);
                case ParameterType.String_Multiline_IEnumerable:
                    return typeof(string);
                case ParameterType.Int_IEnumerable:
                    return typeof(int);
                case ParameterType.Decimal_IEnumerable:
                    return typeof(decimal);
                case ParameterType.Bool_IEnumerable:
                    return typeof(bool);
                case ParameterType.DateTime_IEnumerable:
                    return typeof(DateTime);
                case ParameterType.Date_IEnumerable:
                    return typeof(DateTime);
                case ParameterType.ParameterCollection:
                    return typeof(ParameterCollection);
                case ParameterType.ParameterCollection_IEnumerable:
                    return typeof(ParameterCollection);
                case ParameterType.Enum:
                    return typeof(ParameterCollection);
                case ParameterType.SelectOne:
                    return typeof(ParameterCollection);
                case ParameterType.SelectMany:
                    return typeof(ParameterCollection);
                default:
                    throw new ArgumentOutOfRangeException(nameof(parameterType), "This should not happen.");
            }
        }

        public static List<Tuple<int, object>> GetNumberedList<TValue>(this IEnumerable<TValue> list)
        {
            var result = new List<Tuple<int, object>>();
            var i = 0;
            foreach(var item in list)
            {
                if (item != null)
                {
                    result.Add(new Tuple<int, object>(i, item));
                    i++;
                }
            }
            return result;
        }

        internal static TValue GetDefaultValue<TValue>(ParameterCollection additionalInfo)
        {
            if (additionalInfo != null && additionalInfo.HasKeyAndCanConvertTo("defaultValue", typeof(TValue)))
            {
                return additionalInfo.GetByKey<TValue>("defaultValue");
            }

            var type = typeof(TValue);
            if (type == typeof(string))
            {
                return (TValue)(object)string.Empty;
            }
            else if (type == typeof(DateTime))
            {
                return (TValue)(object)DateTime.Now;
            }
            else
            {
                return default(TValue);
            }
        }
    }
}

