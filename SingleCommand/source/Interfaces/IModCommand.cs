namespace muff1nOS.SingleCommand
{
	/// <summary>Interface that all ModCommands must implement to be compatible with the SingleCommandHandler.</summary>
	public interface IModCommand
	{
		/* Properties */

		/// <summary>The name of the command.</summary>
		string Name { get; }

		/// <summary>The invocation of the command.</summary>
		string Invocation { get; }

		/// <summary>The information displayed when the help command is executed.</summary>
		string Description { get; }

		/// <summary>The parent command that this command is executed with.</summary>
		string[] Parents { get; }

		/* Public Methods */

		/// <summary>The command's handler.</summary>
		/// <param name="parents">Array of strings containing arguments before this one.</param>
		/// <param name="args">Array of strings containing arguments after this one.</param>
		void Handler(string[] parents, string[] args);
	}
}