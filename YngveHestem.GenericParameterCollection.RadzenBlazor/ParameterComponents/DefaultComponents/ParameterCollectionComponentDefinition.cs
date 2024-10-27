using Microsoft.AspNetCore.Components;
using Radzen;
using YngveHestem.GenericParameterCollection.ParameterValueConverters;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor.ParameterComponents.DefaultComponents;

public class ParameterCollectionComponentDefinition : IParameterComponentDefinition
{
    public Dictionary<string, object> GetComponentParameters(Parameter parameter, string parameterName, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters, IParameterComponentDefinition[]? customParameterComponents, Action<object?, ParameterCollection?> updateParameterValue, TooltipService tooltipService)
    {
        return new Dictionary<string, object> 
        {
            { "ParameterCollection", parameter.GetValue<ParameterCollection>(customConverters) },
            { "Options", options },
            { "OnChange", EventCallback.Factory.Create<ParameterCollectionViewOnChangeEventArgs>(this, (args) => updateParameterValue(args.NewParameterCollection, null)) },
            { "CustomConverters", customConverters },
            { "CustomParameterComponents", customParameterComponents }
        };
    }

    public Type GetComponentType(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return typeof(ParameterCollectionView);
    }

    public ParameterComponentParentType GetHowParameterNameIsShown(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return ParameterComponentParentType.RadzenFieldset;
    }

    public bool ShouldComponentBeUsed(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
    {
        return parameter.Type == ParameterType.ParameterCollection;
    }
}
