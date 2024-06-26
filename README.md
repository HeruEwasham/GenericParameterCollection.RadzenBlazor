# GenericParameterCollection.RadzenBlazor

This provides controls for using [GenericParameterCollection](https://github.com/HeruEwasham/GenericParameterCollection) in the Blazor by using [Radzen.Blazor](https://blazor.radzen.com).

## How to use this package

The easiest way to use the package is to download it from nuget: https://www.nuget.org/packages/YngveHestem.GenericParameterCollection.RadzenBlazor.

## Initial setup of Radzen

This package uses Radzen, including ToolTip-functionality. This must be set up correctly in the target project. If you are using Radzen already in the project, you will most likely not need to do anything, or eventually very little. See Radzen.Blazor's [Getting Started](https://blazor.radzen.com/get-started)-guide for what you eventually need to do.

## Main features/controls

### ParameterCollectionView

This is a Blazor-component. This is the main control that handles editing a given ParameterCollection object.

#### Properties and events

Here is a list of properties and events of the ParameterCollectionView-component.

##### ParameterCollection

Set this to the ParameterCollection the component should render.

Mark that the component will not automatically update the given ParameterCollection. To get the new value you need to either use the Get of this property, or using the NewParameterCollection-property you get in the OnChange-event.

##### Options

This property let you set customized Options for how the ParameterCollectionView should look and behave.

##### OnChange-event

This event is triggered each time the user do a change in the component.

When the event is triggered you will get an object that will contain both the new ParameterCollection, and the key to the parameter that was changed.

Mark: If you use this OnChange-event, you must currently manually set the new ParameterCollection to the ParameterCollection that is referenced in the component before the OnChange-event has exited. If not you may see that Blazor reloads the last version of the ParameterCollection.

##### CustomParameterComponents

Here you can define a list of custom comonent definitions.

This can be good to use if you for instance want a color picker for picking some colors, or have your own component you want to use for some parameter.

##### CustomConverters

Do you have some custom converters you need to use for converting some custom value, or want to change how some value is converted in the ParameterCollectionView? Then you can define a list of theese here.

#### Example code

The example-code below sets the ParameterCollection inside a RadzenCard that also has a heading with the text "Parameters". This is gotten from the TestProject. See that to get even more understanding by how it is used.

```
<Radzen.Blazor.RadzenCard>
    <Radzen.Blazor.RadzenText TextStyle="Radzen.Blazor.TextStyle.DisplayH2">Parameters</Radzen.Blazor.RadzenText>
    <ParameterCollectionView @ref="_parameterCollectionView" ParameterCollection="@_parameters" Options="@_options" OnChange="@(args => {
                                                                                                                                    _parameters = args.NewParameterCollection;
                                                                                                                                    Console.WriteLine($"{DateTime.Now}: ParameterCollection got update. Parameter updated was {args.ParameterKey ?? string.Empty}.");
                                                                                                                                    })"></ParameterCollectionView>
</Radzen.Blazor.RadzenCard>
```

### Options

The controls let you provide a ParameterCollectionViewOptions. Here you can define some customisation of how the control looks and works. Most are both self explanatory and well documented in code. Most of theese options can also be set for a specific parameter if the option AdditionalInfoWillOverride is set to true (default is true). Then one or more of the given parameters below can be given in a parameters additionalInfo.

#### Different options

Here is a list of parameters that can either be defined in ParameterCollectionPanelOptions or as a ParameterCollection (some can only be given in one, while many can be given both ways).

If you define this in a ParameterCollection-ParameterType, the changes will affect all parameters in that ParameterCollection.

| Variable name in option-class | Parameter key | Type | Description | Default value in option-class |
| ----------- | ----------- | ----------- | ----------- | ----------- |
| AdditionalInfoWillOverride | additionalInfoWillOverride | bool | Can parameters from a ParameterCollection, like AdditionalInfo from a parameter, override the values defined in this options-object. Mark that if this is set to false in the Options-object that it uses as a base, this will have no effect. | true |
| TooltipOptions | tooltipOptions | TooltipOptions | Tooltip options for the form elements. | null |
| TooltipOptionsFieldSet | tooltipOptionsFieldSet | TooltipOptions | Tooltip options for any field sets (like any ParameterCollection-entries with default rendering). | null |
| ShowParameterNameAsHumanReadable | humanReadable | bool | Convert the parameter name to a human readable format. If set to false, the name will be shown as written, while if set to true, it will be altered to be read easily by a human, like setting first character to an upper character. Mark that this will only have an effect if it is the parameter key that is used. If another name is given, that will always be written as is. | True |
| ReadOnly | readOnly | bool | If true, the control that shows the parameters value should be read only/disabled | False |
| ElementsDesignVariant | elementsDesignVariant | Variant | Specifies what the design variant should be used on the controls. | Outlined |
| AllowFloatingLabel | allowFloatingLabel | bool | Specifies if the form labels are floating or not. | true |
| ReadableParameterTextKey | readableParameterTextKey | string | Specifies a parameter key to a parameter in a parameters additional info to use instead of the parameters key to show to the user. If the specified parameter can not be found (or converted to string), the given parameter's key is instead used. | name |
| TooltipParameterTextKey | tooltipParameterTextKey | string | Specifies a parameter key to a parameter in a parameters additional info to use for a tooltip. | tooltip |
| MinNumber | minNumber | decimal | Specifies what the lowest number that can be entered in a number-field is. | decimal.MinValue |
| MaxNumber | maxNumber | decimal | Specifies what the highest number that can be entered in a number-field is. | decimal.MaxValue |
| StepInteger and StepDecimal | step | decimal | Defines how much a number (both integers and decimals) should increment/decrement with if the increment/decrement buttons are used | if int, 1, if a decimal-number, 0.1 |
| StepInteger | stepInt | int | Specifies how much the gui should increment the value on an int value if the step-button is pressed. | 1 |
| StepDecimal | stepDecimal | decimal | Specifies how much the gui should increment the value on a decimal value if the step-button is pressed. | 0.1 |
| PlaceholderText | placeholder | string | Specifies the placeholder text on controls that support that. | string.Empty |
| IsPassword | isPassword | bool | Specifies if strings should be shown as password (without readable characters). | false |
| MaxNumberOfCharacters | maxChars | long? | Specifies max number of characters that can be given in a text. | null |
| NumberOfRowsInTextArea | textareaRows | int | Specifies the number of rows a textarea will show. | 5 |
| NumberOfColumnsInTextArea | textareaColumns | int | Specifies the number of columns (characters) a textarea will show horizontally. | 100 |
| AcceptedMimeTypes | acceptedMimeTypes | string[] | Specifies what mime types are accepted when selecting file. | null |
| ChooseFileText | chooseFileText | string | Specifies the text to show on the Choose file button. | Choose file |
| DeleteFileText | deleteFileText | string | Specifies the text to show on the Delete file button. | Delete |
| MaxFileSize | maxFileSize | int | Specifies the max file size allowed. | 5 * 1024 * 1024 |
| FilePreviewHeight | previewHeight | int | Specifies the height of the file preview. | 300 |
| FilePreviewWidth | previewWidth | int | Specifies the width of the file preview. | 500 |
| MinDate | minDate | DateTime | The earliest date that is possible to pick. | DateTime.Today.AddYears(-1000) |
| MaxDate | maxDate | DateTime | The latest date that is possible to pick. | DateTime.Today.AddYears(1000) |
| DateTimeFormat | dateTimeFormat | string | Specifies the time format to be shown in DateTime-parameters. | g |
| DateFormat | dateFormat | string | Specifies the time format to be shown in Date-parameters. | d |
| HoursStep | hoursStep | decimal | Specifies how much the gui should increment the hour when the hour step is clicked. | 1.0 |
| MinutesStep | minutesStep | decimal | Specifies how much the gui should increment the minute when the minute step is clicked. | 1.0 |
| SecondsStep | secondsStep | decimal | Specifies how much the gui should increment the second when the second step is clicked. | 1.0 |
| ShowCalenderWeek | showCalendarWeek | bool | Show the given week in the calendar. | true |
| CalendarWeekTitle | calendarWeekTitle | string | Specifies the title of the week-column. | # |
| MaxSelectedLabels | maxSelectedLabels | int | Specifies the maximum number of selected labels to show in the DropDownList. | 4 |
| ShowLabelsAsChips | showLabelsAsChips | bool | Specifies if you want the labels when seleecting multiple in a DropDownList should look likee chips instead of normal labels. | false |
| SelectedItemsText | selectedItemsText | string | Specifies the text shown after the number of items selected when selecting multiple items in a DropDownList. | items selected |
| SelectAllItemsText | selectAllItemsText | string | Specifies the text shown besides the checkmark to select all items when selecting multiple items in a DropDownList. | string.Empty |
| BoolControlToUse | boolControl | BoolControl | Specifies what type of bool control to use. | Switch |
| UseVirtualizationOnList | useVirtualizationOnList | bool | Specifies if lists should be virtualized. If not, the list will be paged. | true |
| ListPageSize | listPageSize | int | Specifies the size of each page if the list is paged. | 5 |
| AddEntryToListText | addEntryToListText | string | Specifies the text on the button to add a new object to the list. | Add |
| DeleteEntryFromListText | deleteEntryFromListText | string | Specifies the text on the button to delete the given object from the list. | Delete |
| DeleteEntryFromListAriaDescription | deleteEntryFromListAriaDescription | string | Specifies the text used to describe the delete button on the given entry in a list for screen readers. You can use {0} to get the current number the entry are in the list, use {1} to get the parameters viewable name and {2} to get the current value. | Delete entry number {0} from the list in parameter "{1}". The entry has the value "{2}". |
| AddEntryToListAriaDescription | addEntryToListAriaDescription | string | Specifies the text used to describe the add button to add a new entry in a list for screen readers. You can use {0} to get the parameters viewable name. | Add a new entry to the list in parameter "{0}". |
| | defaultValue | TValue (Generic baseed on value (IEnumerable)) | This is used on IEnumerable-types to define their Default-value (which is their initial state when adding new value). | If not defined, this will either be default(TValue) or String.Empty if TValue is string or DateTime.Now if TValue is DateTime. |
| | parametersIf:true | ParameterCollection | Any parameters specified here in a bool-parameter will be shown and be editable (if not set to readonly), if the value is set to true. If set to false this will not be shown. | |
| | parametersIf:false | ParameterCollection | Any parameters specified here in a bool-parameter will be shown and be editable (if not set to readonly), if the value is set to false. If set to true this will not be shown. | |
| ParentTypeWhenHavingExtraParameters | parentTypeWhenHavingExtraParameters | ParameterComponentParentType | Defines how any parent component is shown when using "extra parameters" like "parametersIf:true" and "parametersIf:false". Possible valuees are None, RadzenFieldsetOnOnlyCollection, RadzenFieldsetOverWholeParameter | None |
| ExtraParametersName | extraParametersName | string | Specifies the text used on the the collection of extra parameters (not all ParentTypeWhenHavingExtraParameters-options use it). You can use {0} to get the parameterName of the main parameter and use {1} to get the value of the main parameter. | Extra parameters when {0} is {1} |
| | parametersIf:true:name | string | Specifies the text used on the the collection of extra parameters if value is true (not all ParentTypeWhenHavingExtraParameters-options use it). If set, this will be used instead of ExtraParametersName. | |
| | parametersIf:false:name | string | Specifies the text used on the the collection of extra parameters if value is false (not all ParentTypeWhenHavingExtraParameters-options use it). If set, this will be used instead of ExtraParametersName. | |
| | parametersIf:VALUE | ParameterCollection | Any parameters specified here in an Enum-, SelectOne or SelectMany-parameter will be shown and be editable (if not set to readonly), if the value is set to the value specified as VALUE. Remember that VALUE-part of the name need to be exactly as the value (including uppercase/lowercase, etc.) | |
| | parametersIf:VALUE:name | string | Specifies the text used on the the collection of extra parameters if value is VALUE (not all ParentTypeWhenHavingExtraParameters-options use it). If set, this will be used instead of ExtraParametersName. | |
| SelectManyExtraParametersGetOwnParent | selectManyExtraParametersGetOwnParent | bool | Should each extra parameter-collection (one for each value that has one), get it's own visible parent (RadzenFieldset). ExtraParametersParentType will here decide if all the given collections should have one too or not. | true |
| SelectManyExtraParametersName | selectManyExtraParametersName | string | Specifies the text used on the the total collection of extra parameters for SelectMany-parameters (not all ParentTypeWhenHavingExtraParameters-options use it). You can use {0} to get the parameterName of the main parameter. | Extra parameters when {0} has theese values |
| | prettyValues | ParameterCollection | Let you change the values shown to the user on Enum-, SelectOne- and SelectMany-parameter to something other. The value gotten back and sent in must be the correct value. This can be useful if you want to support multiple languages or if you just want to show prettier enum-values to the user. | |