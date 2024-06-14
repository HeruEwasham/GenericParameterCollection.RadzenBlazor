using System;
using Radzen;
using YngveHestem.GenericParameterCollection.ParameterValueConverters;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor
{
    public class TooltipOptionsConverter : ParameterCollectionParameterConverter<TooltipOptions>
    {
        protected override bool CanConvertFromParameterCollection(ParameterCollection value, IEnumerable<IParameterValueConverter> customConverter)
        {
            return value.HasKeyAndCanConvertTo("position", typeof(TooltipPosition)) &&
                value.HasKeyAndCanConvertTo("duration", typeof(int)) &&
                value.HasKeyAndCanConvertTo("delay", typeof(int)) &&
                value.HasKeyAndCanConvertTo("closeTooltipOnDocumentClick", typeof(bool)) &&
                value.HasKeyAndCanConvertTo("style", typeof(string)) &&
                value.HasKeyAndCanConvertTo("cssClass", typeof(string)) &&
                value.HasKeyAndCanConvertTo("text", typeof(string));
        }

        protected override bool CanConvertToParameterCollection(TooltipOptions value, IEnumerable<IParameterValueConverter> customConverter)
        {
            return value != null;
        }

        protected override TooltipOptions ConvertFromParameterCollection(ParameterCollection value, IEnumerable<IParameterValueConverter> customConverter)
        {
            int? duration = value.GetByKey<int>("duration");
            int? delay = value.GetByKey<int>("delay");
            if (duration == int.MinValue)
            {
                duration = null;
            }
            if (delay == int.MinValue)
            {
                delay = null;
            }

            return new TooltipOptions
            {
                Position = value.GetByKey<TooltipPosition>("position"),
                Duration = duration,
                Delay = delay,
                CloseTooltipOnDocumentClick = value.GetByKey<bool>("closeTooltipOnDocumentClick"),
                Style = value.GetByKey<string>("style"),
                CssClass = value.GetByKey<string>("cssClass"),
                Text = value.GetByKey<string>("text")
            };
        }

        protected override ParameterCollection ConvertToParameterCollection(TooltipOptions value, IEnumerable<IParameterValueConverter> customConverter)
        {
            var duration = 0;
            var delay = 0;
            if (value.Duration.HasValue)
            {
                duration = value.Duration.Value;
            }
            else
            {
                duration = int.MinValue;
            }

            if (value.Delay.HasValue)
            {
                delay = value.Delay.Value;
            }
            else
            {
                delay = int.MinValue;
            }

            return new ParameterCollection
            {
                { "position", value.Position },
                { "duration", duration },
                { "delay", delay },
                { "closeTooltipOnDocumentClick", value.CloseTooltipOnDocumentClick },
                { "style", value.Style },
                { "cssClass", value.CssClass },
                { "text", value.Text }
            };
        }
    }
}

