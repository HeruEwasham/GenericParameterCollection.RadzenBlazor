using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using YngveHestem.GenericParameterCollection;
using YngveHestem.GenericParameterCollection.ParameterValueConverters;
using YngveHestem.GenericParameterCollection.RadzenBlazor;
using YngveHestem.GenericParameterCollection.RadzenBlazor.ParameterComponents;

namespace TestProject.TestClasses
{
    public class ColorParameterDefinition : IParameterComponentDefinition
    {
        public Dictionary<string, object> GetComponentParameters(Parameter parameter, string parameterName, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters, IParameterComponentDefinition[]? customParameterComponents, Action<object, ParameterCollection?> updateParameterValue, TooltipService tooltipService)
        {
            // Mark that RadzenColorPicker take in a color in string format, for instance RGB (or for example hex if you want), and return a string formatted for RGB. For this example I therefore decide to let it format it in RGB, and things work out this simple. Read more about the colorpicker here: https://blazor.radzen.com/colorpicker
            return new Dictionary<string, object>
            {
                { "ShowHSV", true },
                { "ShowRGBA", false },
                { "Value", parameter.GetValue<string>(customConverters) },
                { "Change", EventCallback.Factory.Create<string>(this, (value) => updateParameterValue(value, null)) },
                { "Disabled", options.ReadOnly },
                { "aria-label", parameterName }
            };
        }

        public Type GetComponentType(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
        {
            return typeof(Radzen.Blazor.RadzenColorPicker);
        }

        public ParameterComponentParentType GetHowParameterNameIsShown(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
        {
            return ParameterComponentParentType.RadzenFormField;
        }

        public bool ShouldComponentBeUsed(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters)
        {
            return additionalInfo.HasKeyAndCanConvertTo("type", typeof(string)) && additionalInfo.GetByKey<string>("type") == "color";
        }
    }
}

