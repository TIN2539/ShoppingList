using System;
using System.Windows.Forms;

namespace ShoppingList
{
	public partial class MainWindow : Form
	{
		private string normalizedString = "";

		public MainWindow()
		{
			InitializeComponent();
		}

		public bool IsAddButtonEnabled
		{
			get
			{
				return addButton.Enabled = IsUniqueString;
			}
		}

		public bool IsUniqueString
		{
			get
			{
				bool checkSpacebar = IsUnnecessarySpacebar;
				return normalizedString.Length > 0 && productCheckedListBox.FindStringExact(normalizedString) == -1;
			}
		}

		public bool IsUnnecessarySpacebar
		{
			get
			{
				char[] separator = { ' ' };
				string[] words = productTextBox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				if (words.Length > 0)
				{
					words[0] = words[0].Substring(0, 1).ToUpper() + words[0].Substring(1, words[0].Length - 1).ToLower();
				}
				normalizedString = string.Join(" ", words);
				return true;
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			productCheckedListBox.Items.Add(normalizedString);
			productTextBox.Clear();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			DeleteElement();
			EditButtonEnabled();
		}

		private void DeleteElement()
		{
			productCheckedListBox.Items.RemoveAt(productCheckedListBox.SelectedIndex);
		}

		private void DownButton_Click(object sender, EventArgs e)
		{
			MoveItemDown(productCheckedListBox.SelectedIndex + 2);
		}

		private void EditButtonEnabled()
		{
			if (productCheckedListBox.SelectedIndex >= 0)
			{
				downButton.Enabled = true;
				upButton.Enabled = true;
				deleteButton.Enabled = true;
				if (productCheckedListBox.SelectedIndex == 0)
				{
					upButton.Enabled = false;
				}
				else if (productCheckedListBox.SelectedIndex == productCheckedListBox.Items.Count - 1)
				{
					downButton.Enabled = false;
				}
			}
			else
			{
				downButton.Enabled = false;
				upButton.Enabled = false;
				deleteButton.Enabled = false;
			}
		}

		private void MoveItemDown(int newItemPosition)
		{
			CheckState checkState = productCheckedListBox.CheckedItems.Contains(productCheckedListBox.SelectedItem) ? CheckState.Checked : CheckState.Unchecked;
			productCheckedListBox.Items.Insert(newItemPosition, productCheckedListBox.SelectedItem);
			productCheckedListBox.SetItemCheckState(newItemPosition, checkState);
			productCheckedListBox.Items.RemoveAt(productCheckedListBox.SelectedIndex);
			productCheckedListBox.SetSelected(newItemPosition - 1, true);
		}

		private void MoveItemUp(int newItemPosition)
		{
			CheckState checkState = productCheckedListBox.CheckedItems.Contains(productCheckedListBox.SelectedItem) ? CheckState.Checked : CheckState.Unchecked;
			productCheckedListBox.Items.Insert(newItemPosition, productCheckedListBox.SelectedItem);
			productCheckedListBox.SetItemCheckState(newItemPosition, checkState);
			productCheckedListBox.Items.RemoveAt(productCheckedListBox.SelectedIndex);
			productCheckedListBox.SetSelected(newItemPosition, true);
		}

		private void ProductCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditButtonEnabled();
		}

		private void ProductTextBox_TextChanged(object sender, EventArgs e)
		{
			bool addButtonEnabled = IsAddButtonEnabled;
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			MoveItemUp(productCheckedListBox.SelectedIndex - 1);
		}

		//Попытка исправить сhecked при нажатии в пустом месте
		/*private void ProductCheckedListBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (productCheckedListBox.SelectedItems.Count > 0)
			{
				Point locationPoint = productCheckedListBox.GetItemRectangle(productCheckedListBox.SelectedIndex).Location;
				Point formPoint = new Point(locationPoint.X + productCheckedListBox.Location.X, locationPoint.Y + productCheckedListBox.Location.Y);

				int errorband = productCheckedListBox.GetItemHeight(0);

				if (formPoint.X - e.Location.X < errorband && formPoint.X - e.Location.X > 0 && e.Location.Y - formPoint.Y < errorband && e.Location.Y - formPoint.Y > 0)
				{
					productCheckedListBox.SetItemChecked(productCheckedListBox.SelectedIndex, !productCheckedListBox.GetItemChecked(productCheckedListBox.SelectedIndex));
				}
			}
		}*/
	}
}