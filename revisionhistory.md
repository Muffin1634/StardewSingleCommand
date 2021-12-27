# Commits and Revisions



	7. Prerelease 1.0.0-alpha.15
	muff1nOS, 12/27/21 14:19 UTC-08:00
	Update package dependencies
	> Pathoschild.Stardew.ModBuildConfig: 4.0.0-beta.20210916 -> 4.0.0



	6. Prerelease 1.0.0-alpha.14
	muff1nOS, 11/03/21 10:32 UTC-08:00
	Commit for Prerelease 1.0.0-alpha.14
	> made ModCommand.UnknownHandler better and more concise
	> fixed args for the call to that function too
	> fixed command handler invocation from SingleCommandHandler
		(Classes/SingleCommandHandler.cs(65,20))
	> also we dont really need the bool return from that handler either so i
		took it out



	5. Prerelease 1.0.0-alpha.13
	muff1nOS, 11/02/21 20:19 UTC-08:00
	Commit for Prerelease 1.0.0-alpha.13
	Made SingleCommandHandler.CommandList settable outside of constructor



	4. Prerelease 1.0.0-alpha.12
	muff1nOS, 11/02/21 20:06 UTC-08:00
	Commit for Prerelease 1.0.0-alpha.12
	According to SemVer 2.0.0 I must make an entire new version if I change one
		word as I have done here (Classes/SingleCommandHandler.cs(15,2),
		private -> protected)
		Isn't that amazing



	3. Prerelease 1.0.0-alpha.11
	muff1nOS, 11/02/21 14:03 UTC-08:00
	Commit for Prerelease 1.0.0-alpha.11
	Also:
	> edited .gitconfig
	> Changed LICENSE to make license appear on GitHub
	> Added copyright and license notice at the bottom of the README.md
		links to relevant places



	2. Prerelease 1.0.0-alpha.10
	muff1nOS, 10/31/21 22:32 UTC-08:00
	Added commit and revision history because it's nice to have one



	1. Prerelease 1.0.0-alpha.10
	muff1nOS, 10/31/21 22:24 UTC-08:00
	Initial commit for Prerelease 1.0.0-alpha.10



--------------------------------------------------------------------------------

## Commit/Revision Format

```
newer commit
newer commit
newer commit



	<commit number>. <revision version>
	<author>, <mm/dd/yy> <local 24h time> <timezone>
	<commit message>
	<if spanning multiple lines
		indent like this>

	<optional: changes list>



older commit
older commit
older commit
```

Adding the following list would be more helpful in tracking an individual
commit's changes, but do not feel obligated to add them if you feel they are
unnecessary or if the commit message describes the changes well enough.

```

	+ <addition>
		> <list item>
		> <another list item>
	- <removal>
	> <other change>

```

Note that `>` has two different meanings:

1. As a token in the main list
> Some other change that is neither an addition nor deletion

2. As a token in a sublist
> A delimiter of individual items.