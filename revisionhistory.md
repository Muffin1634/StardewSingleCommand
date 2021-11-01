# Commits and Revisions



	2. Prerelease 1.0.0-alpha.10
	muff1nOS, 10/31/21 22:32pm UTC-08:00
	Added commit and revision history because it's nice to have one



	1. Prerelease 1.0.0-alpha.10
	muff1nOS, 10/31/21 22:24pm UTC-08:00
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