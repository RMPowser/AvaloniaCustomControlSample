using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;

namespace NestedComboBoxMinSample.CustomControls
{
	[TemplatePart("PART_comboBox", typeof(ComboBox))]
	public class CustomComboBox : SelectingItemsControl
	{
		public ComboBox? comboBox;

		protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
		{
			base.OnApplyTemplate(e);

			comboBox ??= e.NameScope.Find<ComboBox>("PART_comboBox");

			if (comboBox != null)
			{
				comboBox.ItemsSource = Items;
				comboBox.SelectedIndex = 0;
			}
		}
	}
}
