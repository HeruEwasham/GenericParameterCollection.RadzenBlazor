using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using YngveHestem.GenericParameterCollection.ParameterValueConverters;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor.ParameterComponents.DefaultComponents;

public class IntDecimalComponentDefinition : IParameterComponentDefinition
{
    public Dictionary<string, object> GetComponentParameters(Parameter parameter, string parameterName, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters, IParameterComponentDefinition[]? customParameterComponents, Action<object?, ParameterCollection?> updateParameterValue, TooltipService tooltipService)
    {
        var result = new Dictionary<string, object> 
        {
            { "aria-label", parameterName },
            { "ReadOnly", options.ReadOnly },
            { "Placeholder", options.PlaceholderText },
            { "Min", options.MinNumber},
            { "Max", options.MaxNumber},
        };

        if (parameter.Type == ParameterType.Int) 
        {
            result.Add("Step", options.StepInteger.ToString());
            if (options.IsNullable)
            {
                result.Add("Value", parameter.GetValue<int?>(customConverters));
                result.Add("Change", EventCallback.Factory.Create<int?>(this, (value) => updateParameterValue(value, null)));
            }
            else 
            {
                result.Add("Value", parameter.HasValue() ? parameter.GetValue<int>(customConverters) : null);
                result.Add("Change", EventCallback.Factory.Create<int>(this, (value) => updateParameterValue(value, null)));
            }
        }
        else if (parameter.Type == ParameterType.Decimal) 
        {
            result.Add("Step", options.StepDecimal.ToString());
            if (options.IsNullable)
            {
                result.Add("Value", parameter.GetValue<decimal?>(customConverters));
                result.Add("Change", EventCallback.Factory.Create<decimal?>(this, (value) => updateParameterValue(value, null)));
            }
            else
            {
                result.Add("Value", parameter.HasValue() ? parameter.GetValue<decimal>(customConverters) : null);
                result.Add("Change", EventCallback.Factory.Create<decimal>(this, (value) => updateParameterValue(value, null)));
            }
        }

        return result;
    }

    public Type GetComponentType(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        if (parameter.Type == ParameterType.Int) 
        {
            if (options.IsNullable)
            {
                return typeof(RadzenNumeric<int?>);
            }
            else 
            {
                return typeof(RadzenNumeric<int>);
            }
        }
        else if (parameter.Type == ParameterType.Decimal) 
        {
            if (options.IsNullable)
            {
                return typeof(RadzenNumeric<decimal?>);
            }
            else 
            {
                return typeof(RadzenNumeric<decimal>);
            }
        }

        throw new ArgumentOutOfRangeException("The parametertype " + parameter.Type + " is not supported by " + nameof(IntDecimalComponentDefinition));
    }

    public ParameterComponentParentType GetHowParameterNameIsShown(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return ParameterComponentParentType.RadzenFormField;
    }

    public bool ShouldComponentBeUsed(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return parameter.Type == ParameterType.Int || parameter.Type == ParameterType.Decimal;
    }
}
