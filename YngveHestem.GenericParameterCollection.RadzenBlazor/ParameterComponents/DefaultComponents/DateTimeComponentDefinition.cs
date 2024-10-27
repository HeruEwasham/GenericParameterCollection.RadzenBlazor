using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Radzen;
using Radzen.Blazor;
using YngveHestem.GenericParameterCollection.ParameterValueConverters;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor.ParameterComponents.DefaultComponents;

public class DateTimeComponentDefinition : IParameterComponentDefinition
{
    public Dictionary<string, object> GetComponentParameters(Parameter parameter, string parameterName, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters, IParameterComponentDefinition[]? customParameterComponents, Action<object?, ParameterCollection?> updateParameterValue, TooltipService tooltipService)
    {
        var result = new Dictionary<string, object> 
        {
            { "aria-label", parameterName },
            { "ReadOnly", options.ReadOnly },
            { "Placeholder", options.PlaceholderText },
            { "AllowClear", options.IsNullable },
            { "ShowDays", true },
            { "ShowCalendarWeek", options.ShowCalenderWeek },
            { "Min", options.MinDate },
            { "Max", options.MaxDate },
            { "CalendarWeekTitle", options.CalendarWeekTitle },
            { "Value", parameter.GetValue<DateTime?>(customConverters) },
            { "Change", EventCallback.Factory.Create<DateTime?>(this, (value) => updateParameterValue(value, null)) }
        };

        if (parameter.Type == ParameterType.DateTime) 
        {
            result.Add("DateFormat", options.DateTimeFormat);
            result.Add("ShowTime", true);
            result.Add("ShowSeconds", true);
            result.Add("HoursStep", options.HoursStep.ToString());
            result.Add("MinutesStep", options.MinutesStep.ToString());
            result.Add("SecondsStep", options.SecondsStep.ToString());
        }
        else if (parameter.Type == ParameterType.Date) 
        {
            result.Add("DateFormat", options.DateFormat);
        }

        return result;
    }

    public Type GetComponentType(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        if (options.IsNullable) 
        {
            return typeof(RadzenDatePicker<DateTime?>);
        }
        else
        {
            return typeof(RadzenDatePicker<DateTime>);
        }
    }

    public ParameterComponentParentType GetHowParameterNameIsShown(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return ParameterComponentParentType.RadzenFormField;
    }

    public bool ShouldComponentBeUsed(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return parameter.Type == ParameterType.DateTime || parameter.Type == ParameterType.Date;
    }
}
