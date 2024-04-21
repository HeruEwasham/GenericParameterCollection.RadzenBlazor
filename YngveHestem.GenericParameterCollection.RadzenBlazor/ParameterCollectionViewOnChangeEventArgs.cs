using System;
namespace YngveHestem.GenericParameterCollection.RadzenBlazor
{
	public class ParameterCollectionViewOnChangeEventArgs
	{
		/// <summary>
		/// This provides the full ParameterCollection that you also can get by calling the ParameterCollectionView.ParameterCollection.
		/// </summary>
		public ParameterCollection NewParameterCollection { get; }

		/// <summary>
		/// The key for the parameter that was updated.
		/// </summary>
		public string? ParameterKey { get; }

		public ParameterCollectionViewOnChangeEventArgs(ParameterCollection newParameterCollection, string? parameterKey = null)
		{
			NewParameterCollection = newParameterCollection;
			ParameterKey = parameterKey;
		}
	}
}

