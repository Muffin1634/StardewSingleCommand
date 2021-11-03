using System;
using System.Linq;

using StardewModdingAPI;

namespace muff1nOS.SingleCommand
{
	/// <summary>Base abstract implementation of the IModCommand interface. Inherit from this class unless there is a good reason not to.</summary>
	public abstract class ModCommand : IModCommand
	{
		/* Fields */

		/// <summary>Monitor from SMAPI responsible for this command's input and output.</summary>
		protected IMonitor Monitor { get; }

		/* Properties */

		/// <inheritdoc />
		public string Name { get; }

		/// <inheritdoc />
		public string Invocation { get; }

		/// <inheritdoc />
		public string Description { get; }

		/// <inheritdoc />
		public string[] Parents { get; }

		/* Constructor */

		/// <summary>Constructor for a ModCommand instance.</summary>
		protected ModCommand(
			IMonitor monitor,
			string name,
			string invocation,
			string description = null,
			string[] parents = null)
		{
			this.Monitor = monitor;

			this.Name = name;
			this.Invocation = invocation;
			this.Description = description;
			this.Parents = parents;
		}

		/* Public Methods */

		/// <inheritdoc />
		public virtual void Handler(string[] parents, string[] args)
		{
			// if the required commands were provided before this one
			if (parents.Equals(this.Parents))
			{
				// if command has no arguments or the "help" argument
				if ((args[0] ?? "help") == "help")
					{ this.HelpHandler(this.Monitor); }
				else
				{
					this.UnknownHandler(
						this.Monitor,
						parents.Concat<String>(new string[] {args[0]}).ToArray()
					);
				}
			}
		}

		/* Protected Methods */

		/// <inheritdoc muff1nOS.SingleCommand.SingleCommandHandler.HelpHandler />
		protected virtual void HelpHandler(IMonitor monitor)
		{
			monitor.Log(this.Name + '\n'
						+ '\n'
						+ this.Description
							.Trim('\r')
							.Replace("\n\t", " "),
				LogLevel.Debug);
		}

		/// <inheritdoc muff1nOS.SingleCommand.SingleCommandHandler.UnknownHandler />
		protected virtual void UnknownHandler(IMonitor monitor, string[] cmd)
		{
			string fullCommand = String.Join(' ', cmd);
			Array.Resize<string>(ref cmd, cmd.Length - 1);
			string notFullCommand = String.Join(' ', cmd);

			monitor.Log($"Unknown command '{fullCommand}', Try '{notFullCommand} help' for how to use this command.", LogLevel.Debug);
		}
	}
}