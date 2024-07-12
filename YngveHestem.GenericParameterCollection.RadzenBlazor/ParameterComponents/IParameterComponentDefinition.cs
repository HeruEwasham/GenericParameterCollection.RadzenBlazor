using System;
using Radzen;
using YngveHestem.GenericParameterCollection.ParameterValueConverters;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor.ParameterComponents
{
	public interface IParameterComponentDefinition
	{
        /// <summary>
        /// Based on the information gotten, should the referenced component be used for this parameter?
        /// </summary>
        /// <param name="parameter">The whole parameter.</param>
        /// <param name="additionalInfo">The additionalInfo-parameters already gotten for the parameter.</param>
        /// <param name="options">The options for the ParameterCollectionView, including any changes done by the parameters additionalInfo.</param>
        /// <param name="customConverters">Will be any customConverters added to the ParameterCollectionView.</param>
        /// <returns></returns>
        public bool ShouldComponentBeUsed(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters);

        /// <summary>
        /// Give any values that should be set in parameters in the component when created.
		/// This is called when the component is started to be created.
        ///
        /// Remember that all values needed, including setting the current value, is needed.
        /// </summary>
        /// <param name="parameter">The current parameter.</param>
        /// <param name="parameterName">The parametername, as it will be shown by the ParameterCollectionView. This is sent, so if you show it yourself, or have decided that the GUI should not show it, you have it rendered "correctly" here.</param>
        /// <param name="additionalInfo">The additionalInfo-parameters already gotten for the parameter.</param>
        /// <param name="options">The options for the ParameterCollectionView, including any changes done by the parameters additionalInfo.</param>
        /// <param name="customConverters">Will be any customConverters added to the ParameterCollectionView.</param>
        /// <param name="customParameterComponents">Will be any customParameterComponents added to the ParameterCollecyionView.</param>
        /// <param name="updateParameterValue">This action updates the given value to the correct parameter. The object inputted is the value that should be set as the new value. The value innputted here needs therefore to be a value that can be converted to Parameter's value. Either a default one or via one of the custom converters given. If the second parameter is set to something other than null, the additionalInfo-parameter will be set to this.</param>
        /// <param name="tooltipService">Service to use to add tooltip.</param>
        /// <returns></returns>
        public Dictionary<string, object> GetComponentParameters(Parameter parameter, string parameterName, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters, IParameterComponentDefinition[]? customParameterComponents, Action<object?, ParameterCollection?> updateParameterValue, TooltipService tooltipService);

        /// <summary>
        /// Get the type of BlazorComponent to create.
        /// As this is a method, this means one IParameterComponent can decide between multiple type of controls, as you can check different things in the parameters.
        /// </summary>
        /// <param name="parameter">The whole parameter.</param>
        /// <param name="additionalInfo">The additionalInfo-parameters already gotten for the parameter.</param>
        /// <param name="options">The options for the ParameterCollectionView, including any changes done by the parameters additionalInfo.</param>
        /// <param name="customConverters">Will be any customConverters added to the ParameterCollectionView.</param>
        /// <returns></returns>
        public Type GetComponentType(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters);

        /// <summary>
        /// Here you can return how the parameter name should be shown (None, RadzenFormField or RadzenFieldset).
        /// Be aware that if you select None, this means that the paramater will not show any naming-overlay for the parameter. If this then is wanted to be shown (often advised), the component need to show this in some way.
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="additionalInfo"></param>
        /// <param name="options">The options for the ParameterCollectionView, including any changes done by the parameters additionalInfo.</param>
        /// <param name="customConverters">Will be any customConverters added to the ParameterCollectionView.</param>
        /// <returns></returns>
        public ParameterComponentParentType GetHowParameterNameIsShown(Parameter parameter, ParameterCollection additionalInfo, ParameterCollectionViewOptions options, IParameterValueConverter[]? customConverters);
    }
}

