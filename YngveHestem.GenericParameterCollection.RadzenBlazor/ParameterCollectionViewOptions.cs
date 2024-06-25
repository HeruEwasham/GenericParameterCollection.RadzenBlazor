using System;
using Radzen;
using YngveHestem.GenericParameterCollection.RadzenBlazor.ParameterComponents;

namespace YngveHestem.GenericParameterCollection.RadzenBlazor
{
    [AttributeConvertible]
	public class ParameterCollectionViewOptions
	{
        /// <summary>
        /// Will a parameters additionalInfo override the given parameters if correct parameters are given?
        /// </summary>
        [ParameterProperty("additionalInfoWillOverride")]
        public bool AdditionalInfoWillOverride = true;

        /// <summary>
        /// Tooltip options for the form elements.
        /// </summary>
        [ParameterProperty("tooltipOptions")]
        public TooltipOptions? TooltipOptions = null;

        /// <summary>
        /// Tooltip options for any field sets (like any ParameterCollection-entries with default rendering).
        /// </summary>
        [ParameterProperty("tooltipOptionsFieldSet")]
        public TooltipOptions? TooltipOptionsFieldSet = null;

        /// <summary>
        /// Convert the parameter name to a human readable format. If set to false, the name will be shown as written, while if set to true, it will be altered to be read easily by a human, like setting first character to an upper character. Mark that this will only have an effect if it is the parameter key that is used. If another name is given, that will always be written as is.
        /// </summary>
        [ParameterProperty("humanReadable")]
        public bool ShowParameterNameAsHumanReadable = true;

        /// <summary>
        /// Specifies if the controls should be readOnly.
        /// </summary>
        [ParameterProperty("readOnly")]
        public bool ReadOnly = false;

        /// <summary>
        /// Specifies what the design variant should be used on the controls.
        /// </summary>
        [ParameterProperty("elementsDesignVariant")]
        public Variant ElementsDesignVariant = Variant.Outlined;

        /// <summary>
        /// Specifies if the form labels are floating or not.
        /// </summary>
        [ParameterProperty("allowFloatingLabel")]
        public bool AllowFloatingLabel = true;

        /// <summary>
        /// Specifies a parameter key to a parameter in a parameters additional info to use instead of the parameters key to show to the user. If the specified parameter can not be found (or converted to string), the given parameter's key is instead used.
        /// </summary>
        [ParameterProperty("readableParameterTextKey")]
        public string ReadableParameterTextKey = "name";

        /// <summary>
        /// Specifies a parameter key to a parameter in a parameters additional info to use for a tooltip.
        /// </summary>
        [ParameterProperty("tooltipParameterTextKey")]
        public string TooltipParameterTextKey = "tooltip";

        /// <summary>
        /// Specifies what the lowest number that can be entered in a number-field is.
        /// </summary>
        [ParameterProperty("minNumber")]
        public decimal MinNumber = decimal.MinValue;

        /// <summary>
        /// Specifies what the highest number that can be entered in a number-field is.
        /// </summary>
        [ParameterProperty("maxNumber")]
        public decimal MaxNumber = decimal.MaxValue;

        /// <summary>
        /// Specifies how much the gui should increment the value on an int value if the step-button is pressed.
        /// </summary>
        [ParameterProperty("stepInt")]
        public int StepInteger = 1;

        /// <summary>
        /// Specifies how much the gui should increment the value on a decimal value if the step-button is pressed.
        /// </summary>
        [ParameterProperty("stepDecimal")]
        public decimal StepDecimal = 0.1m;

        /// <summary>
        /// Specifies the placeholder text on controls that support that.
        /// </summary>
        [ParameterProperty("placeholder")]
        public string PlaceholderText = string.Empty;

        /// <summary>
        /// Specifies if strings should be shown as password (without readable characters).
        /// </summary>
        [ParameterProperty("isPassword")]
        public bool IsPassword = false;

        /// <summary>
        /// Specifies max number of characters that can be given in a text.
        /// </summary>
        [ParameterProperty("maxChars")]
        public long? MaxNumberOfCharacters = null;

        /// <summary>
        /// Specifies the number of rows a textarea will show.
        /// </summary>
        [ParameterProperty("textareaRows")]
        public int NumberOfRowsInTextArea = 5;

        /// <summary>
        /// Specifies the number of columns (characters) a textarea will show horizontally.
        /// </summary>
        [ParameterProperty("textareaColumns")]
        public int NumberOfColumnsInTextArea = 100;

        /// <summary>
        /// Specifies what mime types are accepted when selecting file.
        /// </summary>
        [ParameterProperty("acceptedMimeTypes")]
        public string[]? AcceptedMimeTypes = null;

        /// <summary>
        /// Specifies the text to show on the Choose file button.
        /// </summary>
        [ParameterProperty("chooseFileText")]
        public string ChooseFileText = "Choose file";

        /// <summary>
        /// Specifies the text to show on the Delete file button.
        /// </summary>
        [ParameterProperty("deleteFileText")]
        public string DeleteFileText = "Delete";

        /// <summary>
        /// Specifies the max file size allowed.
        /// </summary>
        [ParameterProperty("maxFileSize")]
        public int MaxFileSize = 5 * 1024 * 1024;

        /// <summary>
        /// Specifies the height of the file preview.
        /// </summary>
        [ParameterProperty("previewHeight")]
        public int FilePreviewHeight = 300;

        /// <summary>
        /// Specifies the width of the file preview.
        /// </summary>
        [ParameterProperty("previewWidth")]
        public int FilePreviewWidth = 500;

        /// <summary>
        /// Specifies the time format to be shown in DateTime-parameters.
        /// </summary>
        [ParameterProperty("dateTimeFormat")]
        public string DateTimeFormat = "g";

        /// <summary>
        /// Specifies the time format to be shown in Date-parameters.
        /// </summary>
        [ParameterProperty("dateFormat")]
        public string DateFormat = "d";

        /// <summary>
        /// Specifies how much the gui should increment the hour when the hour step is clicked.
        /// </summary>
        [ParameterProperty("hoursStep")]
        public decimal HoursStep = 1.0m;

        /// <summary>
        /// Specifies how much the gui should increment the minute when the minute step is clicked.
        /// </summary>
        [ParameterProperty("minutesStep")]
        public decimal MinutesStep = 1.0m;

        /// <summary>
        /// Specifies how much the gui should increment the second when the second step is clicked.
        /// </summary>
        [ParameterProperty("secondsStep")]
        public decimal SecondsStep = 1.0m;

        /// <summary>
        /// Show the given week in the calendar.
        /// </summary>
        [ParameterProperty("showCalendarWeek")]
        public bool ShowCalenderWeek = true;

        /// <summary>
        /// Specifies the title of the week-column.
        /// </summary>
        [ParameterProperty("calendarWeekTitle")]
        public string CalendarWeekTitle = "#";

        /// <summary>
        /// The earliest date that is possible to pick.
        /// </summary>
        [ParameterProperty("minDate")]
        public DateTime MinDate = new DateTime(1950, 1, 1);

        /// <summary>
        /// The latest date that is possible to pick.
        /// </summary>
        [ParameterProperty("maxDate")]
        public DateTime MaxDate = DateTime.Now.AddYears(30);

        /// <summary>
        /// Specifies the maximum number of selected labels to show in the DropDownList.
        /// </summary>
        [ParameterProperty("maxSelectedLabels")]
        public int MaxSelectedLabels = 4;

        /// <summary>
        /// Specifies if you want the labels when seleecting multiple in a DropDownList should look likee chips instead of normal labels.
        /// </summary>
        [ParameterProperty("showLabelsAsChips")]
        public bool ShowLabelsAsChips = false;

        /// <summary>
        /// Specifies the text shown after the number of items selected when selecting multiple items in a DropDownList.
        /// </summary>
        [ParameterProperty("selectedItemsText")]
        public string SelectedItemsText = "items selected";

        /// <summary>
        /// Specifies the text shown besides the checkmark to select all items when selecting multiple items in a DropDownList.
        /// </summary>
        [ParameterProperty("selectAllItemsText")]
        public string SelectAllItemsText = string.Empty;

        /// <summary>
        /// Specifies what type of bool control to use.
        /// </summary>
        [ParameterProperty("boolControl")]
        public BoolControl BoolControlToUse = BoolControl.Switch;

        /// <summary>
        /// Specifies if lists should be virtualized. If not, the list will be paged.
        /// </summary>
        [ParameterProperty("useVirtualizationOnList")]
        public bool UseVirtualizationOnList = true;

        /// <summary>
        /// Specifies the size of each page if the list is paged.
        /// </summary>
        [ParameterProperty("listPageSize")]
        public int ListPageSize = 5;

        /// <summary>
        /// Specifies the text on the button to add a new object to the list.
        /// </summary>
        [ParameterProperty("addEntryToListText")]
        public string AddEntryToListText = "Add";

        /// <summary>
        /// Specifies the text on the button to delete the given object from the list.
        /// </summary>
        [ParameterProperty("deleteEntryFromListText")]
        public string DeleteEntryFromListText = "Delete";

        /// <summary>
        /// Specifies the text used to describe the delete button on the given entry in a list for screen readers. You can use {0} to get the current number the entry are in the list, use {1} to get the parameters viewable name and {2} to get the current value.
        /// </summary>
        [ParameterProperty("deleteEntryFromListAriaDescription")]
        public string DeleteEntryFromListAriaDescription = "Delete entry number {0} from the list in parameter \"{1}\". The entry has the value \"{2}\".";

        /// <summary>
        /// Specifies the text used to describe the add button to add a new entry in a list for screen readers. You can use {0} to get the parameters viewable name.
        /// </summary>
        [ParameterProperty("addEntryToListAriaDescription")]
        public string AddEntryToListAriaDescription = "Add a new entry to the list in parameter \"{0}\".";

        /// <summary>
        /// Defines how any parent component is shown when using "extra parameters" like "parametersIf:true" and "parametersIf:false".
        /// </summary>
        [ParameterProperty("parentTypeWhenHavingExtraParameters")]
        public ExtraParametersParentType ParentTypeWhenHavingExtraParameters = ExtraParametersParentType.None;

        /// <summary>
        /// Specifies the text used on the the collection of extra parameters (not all ParentTypeWhenHavingExtraParameters-options use it). You can use {0} to get the parameterName of the main parameter and use {1} to get the value of the main parameter.
        /// </summary>
        [ParameterProperty("extraParametersName")]
        public string ExtraParametersName = "Extra parameters when {0} is {1}";

        public ParameterCollectionViewOptions CreateCopy()
        {
            return new ParameterCollectionViewOptions
            {
                AdditionalInfoWillOverride = AdditionalInfoWillOverride,
                TooltipOptions = TooltipOptions,
                TooltipOptionsFieldSet = TooltipOptionsFieldSet,
                ShowParameterNameAsHumanReadable = ShowParameterNameAsHumanReadable,
                ReadOnly = ReadOnly,
                ElementsDesignVariant = ElementsDesignVariant,
                AllowFloatingLabel = AllowFloatingLabel,
                ReadableParameterTextKey = ReadableParameterTextKey,
                TooltipParameterTextKey = TooltipParameterTextKey,
                MinNumber = MinNumber,
                MaxNumber = MaxNumber,
                StepInteger = StepInteger,
                StepDecimal = StepDecimal,
                PlaceholderText = PlaceholderText,
                IsPassword = IsPassword,
                MaxNumberOfCharacters = MaxNumberOfCharacters,
                NumberOfRowsInTextArea = NumberOfRowsInTextArea,
                NumberOfColumnsInTextArea = NumberOfColumnsInTextArea,
                AcceptedMimeTypes = AcceptedMimeTypes,
                ChooseFileText = ChooseFileText,
                DeleteFileText = DeleteFileText,
                MaxFileSize = MaxFileSize,
                FilePreviewHeight = FilePreviewHeight,
                FilePreviewWidth = FilePreviewWidth,
                DateTimeFormat = DateTimeFormat,
                DateFormat = DateFormat,
                HoursStep = HoursStep,
                MinutesStep = MinutesStep,
                SecondsStep = SecondsStep,
                ShowCalenderWeek = ShowCalenderWeek,
                CalendarWeekTitle = CalendarWeekTitle,
                MinDate = MinDate,
                MaxDate = MaxDate,
                MaxSelectedLabels = MaxSelectedLabels,
                ShowLabelsAsChips = ShowLabelsAsChips,
                SelectedItemsText = SelectedItemsText,
                SelectAllItemsText = SelectAllItemsText,
                BoolControlToUse = BoolControlToUse,
                UseVirtualizationOnList = UseVirtualizationOnList,
                ListPageSize = ListPageSize,
                AddEntryToListText = AddEntryToListText,
                DeleteEntryFromListText = DeleteEntryFromListText,
                DeleteEntryFromListAriaDescription = DeleteEntryFromListAriaDescription,
                AddEntryToListAriaDescription = AddEntryToListAriaDescription,
                ParentTypeWhenHavingExtraParameters = ParentTypeWhenHavingExtraParameters,
                ExtraParametersName = ExtraParametersName
            };
        }
        /// <summary>
        /// Creates a copy from a list of parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <param name="defaultOptions">A list of options to use if correct parameter is not found. if this is null, the default parameter is used.</param>
        /// <returns></returns>
        public static ParameterCollectionViewOptions CreateFromParameterCollection(ParameterCollection parameters, ParameterCollectionViewOptions? defaultOptions = null)
        {
            var options = new ParameterCollectionViewOptions();

            if (defaultOptions != null)
            {
                options = defaultOptions.CreateCopy();
            }

            if (parameters == null)
            {
                return options;
            }

            if (parameters.HasKeyAndCanConvertTo("additionalInfoWillOverride", typeof(bool)))
            {
                options.AdditionalInfoWillOverride = parameters.GetByKey<bool>("additionalInfoWillOverride");
            }

            if (parameters.HasKeyAndCanConvertTo("tooltipOptions", typeof(TooltipOptions)))
            {
                options.TooltipOptions = parameters.GetByKey<TooltipOptions>("tooltipOptions", new[] { new TooltipOptionsConverter() });
            }

            if (parameters.HasKeyAndCanConvertTo("tooltipOptionsFieldSet", typeof(TooltipOptions)))
            {
                options.TooltipOptionsFieldSet = parameters.GetByKey<TooltipOptions>("tooltipOptionsFieldSet", new[] { new TooltipOptionsConverter() });
            }

            if (parameters.HasKeyAndCanConvertTo("humanReadable", typeof(bool)))
            {
                options.ShowParameterNameAsHumanReadable = parameters.GetByKey<bool>("humanReadable");
            }

            if (parameters.HasKeyAndCanConvertTo("readOnly", typeof(bool)))
            {
                options.ReadOnly = parameters.GetByKey<bool>("readOnly");
            }

            if (parameters.HasKeyAndCanConvertTo("elementsDesignVariant", typeof(Variant)))
            {
                options.ElementsDesignVariant = parameters.GetByKey<Variant>("elementsDesignVariant");
            }

            if (parameters.HasKeyAndCanConvertTo("allowFloatingLabel", typeof(bool)))
            {
                options.AllowFloatingLabel = parameters.GetByKey<bool>("allowFloatingLabel");
            }

            if (parameters.HasKeyAndCanConvertTo("readableParameterTextKey", typeof(string)))
            {
                options.ReadableParameterTextKey = parameters.GetByKey<string>("readableParameterTextKey");
            }

            if (parameters.HasKeyAndCanConvertTo("tooltipParameterTextKey", typeof(string)))
            {
                options.TooltipParameterTextKey = parameters.GetByKey<string>("tooltipParameterTextKey");
            }

            if (parameters.HasKeyAndCanConvertTo("minNumber", typeof(decimal)))
            {
                options.MinNumber = parameters.GetByKey<decimal>("minNumber");
            }

            if (parameters.HasKeyAndCanConvertTo("maxNumber", typeof(decimal)))
            {
                options.MaxNumber = parameters.GetByKey<decimal>("maxNumber");
            }

            if (parameters.HasKeyAndCanConvertTo("step", typeof(decimal)))
            {
                var inc = parameters.GetByKey<decimal>("step");
                if (inc < 1)
                {
                    options.StepInteger = 1;
                }
                else
                {
                    options.StepInteger = (int)inc;
                }
                options.StepDecimal = inc;
            }

            if (parameters.HasKeyAndCanConvertTo("stepInt", typeof(int)))
            {
                options.StepInteger = parameters.GetByKey<int>("stepInt");
            }

            if (parameters.HasKeyAndCanConvertTo("stepDecimal", typeof(decimal)))
            {
                options.StepDecimal = parameters.GetByKey<decimal>("stepDecimal");
            }

            if (parameters.HasKeyAndCanConvertTo("placeholder", typeof(string)))
            {
                options.PlaceholderText = parameters.GetByKey<string>("placeholder");
            }

            if (parameters.HasKeyAndCanConvertTo("isPassword", typeof(bool)))
            {
                options.IsPassword = parameters.GetByKey<bool>("isPassword");
            }

            if (parameters.HasKeyAndCanConvertTo("maxChars", typeof(long)))
            {
                var v = parameters.GetByKey<long>("maxChars");
                if (v < 0)
                {
                    options.MaxNumberOfCharacters = null;
                }
                else
                {
                    options.MaxNumberOfCharacters = v;
                }
            }

            if (parameters.HasKeyAndCanConvertTo("textareaRows", typeof(int)))
            {
                options.NumberOfRowsInTextArea = parameters.GetByKey<int>("textareaRows");
            }

            if (parameters.HasKeyAndCanConvertTo("textareaColumns", typeof(int)))
            {
                options.NumberOfColumnsInTextArea = parameters.GetByKey<int>("textareaColumns");
            }

            if (parameters.HasKeyAndCanConvertTo("acceptedMimeTypes", typeof(string[])))
            {
                options.AcceptedMimeTypes = parameters.GetByKey<string[]>("acceptedMimeTypes");
            }

            if (parameters.HasKeyAndCanConvertTo("chooseFileText", typeof(string)))
            {
                options.ChooseFileText = parameters.GetByKey<string>("chooseFileText");
            }

            if (parameters.HasKeyAndCanConvertTo("deleteFileText", typeof(string)))
            {
                options.DeleteFileText = parameters.GetByKey<string>("deleteFileText");
            }

            if (parameters.HasKeyAndCanConvertTo("maxFileSize", typeof(int)))
            {
                options.MaxFileSize = parameters.GetByKey<int>("maxFileSize");
            }

            if (parameters.HasKeyAndCanConvertTo("previewHeight", typeof(int)))
            {
                options.FilePreviewHeight = parameters.GetByKey<int>("previewHeight");
            }

            if (parameters.HasKeyAndCanConvertTo("previewWidth", typeof(int)))
            {
                options.FilePreviewWidth = parameters.GetByKey<int>("previewWidth");
            }

            if (parameters.HasKeyAndCanConvertTo("dateTimeFormat", typeof(string)))
            {
                options.DateTimeFormat = parameters.GetByKey<string>("dateTimeFormat");
            }

            if (parameters.HasKeyAndCanConvertTo("dateFormat", typeof(string)))
            {
                options.DateFormat = parameters.GetByKey<string>("dateFormat");
            }

            if (parameters.HasKeyAndCanConvertTo("hoursStep", typeof(decimal)))
            {
                options.HoursStep = parameters.GetByKey<decimal>("hoursStep");
            }

            if (parameters.HasKeyAndCanConvertTo("minutesStep", typeof(decimal)))
            {
                options.MinutesStep = parameters.GetByKey<decimal>("minutesStep");
            }

            if (parameters.HasKeyAndCanConvertTo("secondsStep", typeof(decimal)))
            {
                options.SecondsStep = parameters.GetByKey<decimal>("secondsStep");
            }

            if (parameters.HasKeyAndCanConvertTo("showCalendarWeek", typeof(bool)))
            {
                options.ShowCalenderWeek = parameters.GetByKey<bool>("showCalendarWeek");
            }

            if (parameters.HasKeyAndCanConvertTo("calendarWeekTitle", typeof(string)))
            {
                options.CalendarWeekTitle = parameters.GetByKey<string>("calendarWeekTitle");
            }

            if (parameters.HasKeyAndCanConvertTo("minDate", typeof(DateTime)))
            {
                options.MinDate = parameters.GetByKey<DateTime>("minDate");
            }

            if (parameters.HasKeyAndCanConvertTo("maxDate", typeof(DateTime)))
            {
                options.MaxDate = parameters.GetByKey<DateTime>("maxDate");
            }

            if (parameters.HasKeyAndCanConvertTo("maxSelectedLabels", typeof(int)))
            {
                options.MaxSelectedLabels = parameters.GetByKey<int>("maxSelectedLabels");
            }

            if (parameters.HasKeyAndCanConvertTo("showLabelsAsChips", typeof(bool)))
            {
                options.ShowLabelsAsChips = parameters.GetByKey<bool>("showLabelsAsChips");
            }

            if (parameters.HasKeyAndCanConvertTo("selectedItemsText", typeof(string)))
            {
                options.SelectedItemsText = parameters.GetByKey<string>("selectedItemsText");
            }

            if (parameters.HasKeyAndCanConvertTo("selectAllItemsText", typeof(string)))
            {
                options.SelectAllItemsText = parameters.GetByKey<string>("selectAllItemsText");
            }

            if (parameters.HasKeyAndCanConvertTo("boolControl", typeof(BoolControl)))
            {
                options.BoolControlToUse = parameters.GetByKey<BoolControl>("boolControl");
            }

            if (parameters.HasKeyAndCanConvertTo("useVirtualizationOnList", typeof(bool)))
            {
                options.UseVirtualizationOnList = parameters.GetByKey<bool>("useVirtualizationOnList");
            }

            if (parameters.HasKeyAndCanConvertTo("listPageSize", typeof(int)))
            {
                options.ListPageSize = parameters.GetByKey<int>("listPageSize");
            }

            if (parameters.HasKeyAndCanConvertTo("addEntryToListText", typeof(string)))
            {
                options.AddEntryToListText = parameters.GetByKey<string>("addEntryToListText");
            }

            if (parameters.HasKeyAndCanConvertTo("deleteEntryFromListText", typeof(string)))
            {
                options.DeleteEntryFromListText = parameters.GetByKey<string>("deleteEntryFromListText");
            }

            if (parameters.HasKeyAndCanConvertTo("deleteEntryFromListAriaDescription", typeof(string)))
            {
                options.DeleteEntryFromListAriaDescription = parameters.GetByKey<string>("deleteEntryFromListAriaDescription");
            }

            if (parameters.HasKeyAndCanConvertTo("addEntryToListAriaDescription", typeof(string)))
            {
                options.AddEntryToListAriaDescription = parameters.GetByKey<string>("addEntryToListAriaDescription");
            }

            if (parameters.HasKeyAndCanConvertTo("parentTypeWhenHavingExtraParameters", typeof(ExtraParametersParentType)))
            {
                options.ParentTypeWhenHavingExtraParameters = parameters.GetByKey<ExtraParametersParentType>("parentTypeWhenHavingExtraParameters");
            }

            if (parameters.HasKeyAndCanConvertTo("extraParametersName", typeof(string)))
            {
                options.ExtraParametersName = parameters.GetByKey<string>("extraParametersName");
            }

            return options;
        }
	}
}

