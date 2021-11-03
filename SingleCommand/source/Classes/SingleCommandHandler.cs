using System;
using System.Linq;

using StardewModdingAPI;

namespace muff1nOS.SingleCommand
{
	/// <summary>Class for the base command handler. Handles all sub-(sub-(sub-(etc)))commands, so you only need one.</summary>
	public class SingleCommandHandler
	{
		/* Fields */

		/// <summary>Monitor from SMAPI responsible for this command's input and output.</summary>
		private IMonitor Monitor { get; }

		/// <summary>List of all of your IModCommands.</summary>
		protected IModCommand[] CommandList { get; set; }

		/* Properties */

		/// <summary>The name of your mod.</summary>
		public readonly string ModName;

		/// <summary>The invocation of your mod's command, i.e. what you type into the console.</summary>
		public readonly string CommandInvocation;

		/// <summary>The description of the command, shown when running 'help <yourCommand>'.</summary>
		/// <remarks>This is not shown when running '<yourCommand> help'; that is handler by the command's <see>HelpHandler</see></remarks>
		public readonly string CommandDescription;

		/* Public methods */

		/// <summary>Constructor for a SingleCommandHandler instance.</summary>
		public SingleCommandHandler(
			IMonitor monitor,
			IModCommand[] commandList,
			string modName,
			string commandInvocation,
			string commandDescription)
		{
			this.Monitor = monitor;
			this.CommandList = commandList;

			this.ModName = modName;
			this.CommandInvocation = commandInvocation;
			this.CommandDescription = commandDescription;
		}

		/// <summary>Base command handler.</summary>
		public virtual void Handler(string[] args)
		{
			if ((args.FirstOrDefault<string>() ?? "help") == "help")
			{
				// if no command specified or is the "help" command
				this.HelpHandler(this.Monitor);
			}
			else
			{
				string command = args[0];
				string[] arguments = args.Skip(1).ToArray();

				if (this.CommandList.GetCommand(command, out IModCommand modCommand))
				{
					// if it is a normal subcommand
					modCommand.Handler(
						new string[] {this.CommandInvocation},
						arguments
					);
				}
				else
				{
					// if it is unknown
					this.UnknownHandler(
						this.Monitor,
						command
					);
				}
			}
		}

		/// <summary>Register your mod's base command with SMAPI.</summary>
		/// <param name="commandHelper">SMAPI's command API.</param>
		public virtual void RegisterCommand(ICommandHelper commandHelper)
		{
			commandHelper.Add(
				this.CommandInvocation,
				$"Command for {this.ModName}. Type '{this.CommandInvocation} help' for more info.",
				(_, args) => this.Handler(args)
			);
		}

		/* Protected methods */

		/// <summary>The command's help information.</summary>
		/// <param name="monitor"><inheritdoc this.monitor /></param>
		/// <remarks>You may use a fancier multiline parser if you wish.</remarks>
		protected virtual void HelpHandler(IMonitor monitor)
		{
			monitor.Log(this.ModName + '\n'
						+ '\n'
						+ this.CommandDescription
							.Trim('\r')
							.Replace("\n\t", " "),
				LogLevel.Debug);
		}

		/// <summary>Handler for unknown arguments.</summary>
		/// <param name="monitor"><inheritdoc this.monitor /></param>
		/// <param name="faultyArg">Unknown argument that caused this method to be called.</param>
		/// <remarks>This UnknownHandler is a bit different from the others, in that it knows it handles the base command and can do less work.</remarks>
		protected virtual void UnknownHandler(IMonitor monitor, string faultyArg)
			{ monitor.Log($"Unknown command '{this.CommandInvocation} {faultyArg}'. Use '{this.CommandInvocation} help' for how to use this command.", LogLevel.Debug); }
	}
}