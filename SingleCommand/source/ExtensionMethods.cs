namespace muff1nOS.SingleCommand
{
	/// <summary>Static class for containing extension methods of other types.</summary>
	internal static class ExtensionMethods
	{
		/// <summary>Adds a GetCommand extension to the IModCommand[] type.</summary>
		/// <param name="command">Command that the user typed out.</param>
		/// <param name="outCommand">Value that should hold <c>command</c>'s relevant IModCommand, or null if none</param>
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
					break;
				}
			}

			outCommand = hold;
			return retval;
		}
	}
}