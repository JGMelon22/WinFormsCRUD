namespace WinFormsCRUD.Helpers;

public class TextBoxInputNumbers
{
	public bool TextBoxLimit(KeyPressEventArgs e)
	{
		char ch = e.KeyChar;
		if (!char.IsNumber(ch))
		{
			e.Handled = true;
			return false;
		}

		else
		{
			return true;
		}
	}
}
