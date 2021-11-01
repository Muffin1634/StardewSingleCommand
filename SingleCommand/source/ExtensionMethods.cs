namespace muff1nOS.SingleCommand
{
	internal static class ExtensionMethods
	{
		public static bool GetCommand(this IModCommand[] commandList, string command, out IModCommand outCommand)
		{
			IModCommand hold = null;
			bool retval = false;

			foreach (IModCommand entry in commandList)
			{
				if (command == entry.Invocation)
				{
					hold = entry;
					retval = true;
				}
			}

			outCommand = hold;
			return retval;
		}
	}
}