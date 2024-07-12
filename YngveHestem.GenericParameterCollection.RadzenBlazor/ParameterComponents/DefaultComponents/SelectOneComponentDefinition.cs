using Microsoft.AspNetCore.Components;
using Radzen;
using YngveHestem.GenericParameterCollection.ParameterValueConverters;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor.ParameterComponents.DefaultComponents;

public class SelectOneComponentDefinition : IParameterComponentDefinition
{
    public Dictionary<string, object> GetComponentParameters(Parameter parameter, string parameterName, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters, IParameterComponentDefinition[]? customParameterComponents, Action<object?, ParameterCollection?> updateParameterValue, TooltipService tooltipService)
    {
        Action<ElementReference>? tooltip = null;
        if (additionalInfo.HasKeyAndCanConvertTo(options.TooltipParameterTextKey, typeof(string)))
        {
            tooltip = (args) => {tooltipService.Open(args, additionalInfo.GetByKey<string>(options.TooltipParameterTextKey, customConverters), options.TooltipOptions);};
        }
        Dictionary<string, string>? prettyValues = null;
        if (additionalInfo.HasKeyAndCanConvertTo("prettyValues", typeof(ParameterCollection))) 
        {
            prettyValues = additionalInfo.GetByKey<ParameterCollection>("prettyValues").GetAsDictionary<string>();
        }
        return new Dictionary<string, object> {
            { "ParameterName", parameterName },
            { "Value", parameter.GetValue<string>(customConverters) },
            { "Choices", parameter.GetChoices().ToArray() },
            { "Options", options },
            { "Change", updateParameterValue },
            { "Tooltip", tooltip },
            { "AdditionalInfo", additionalInfo },
            { "CustomConverters", customConverters },
            { "CustomParameterComponents", customParameterComponents },
            { "ValueToPrettyDictionary", prettyValues }
        };
    }

    public Type GetComponentType(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return typeof(SelectOneComponent);
    }

    public ParameterComponentParentType GetHowParameterNameIsShown(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return ParameterComponentParentType.None;
    }

    public bool ShouldComponentBeUsed(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return parameter.Type == ParameterType.Enum || parameter.Type == ParameterType.SelectOne;
    }
}
