# muff1nOS' Single Command SDV Mod tool thingy something

~~fill in this very empty void with words sometime in the future~~ edit: it is currently the sometime in the future, and i am filling this empty void with words.

tl;dr i saw content patcher's JSON file functionality and went "That's a pretty good idea, I bet Pathos won't mind if I take some of that myself."

The way things currently work is complicated: you make a base command class that inherits from one in the project, then also make more command classes inheriting from an abstract class that defines a generic interface. I thought this was pretty cool at the time, just having an entire folder dedicated to commands so you know what the layout is. Each command in its separate file in its own folder in a hierarchy matching the command structure. Cool, right? Of course...

...not. Fast-forward two months to now: I've been in the SDV Discord (not linked here) answering peoples' questions about modding, and asking a few of my own. Many questions were related to one of the most popular mod frameworks, Content Patcher, uses JSON files to define its behavior. One time I forget when, someone had a question about a JSON file for Content Patcher. Other people who actually had experience with it answered the question immediately, but I was curious as to how people knew. Someone linked the [official docs](https://github.com/Pathoschild/StardewMods/blob/develop/ContentPatcher/docs/author-guide.md) in the chat, and so I combed through it. It's very thorough, but the thing that piqued my interest was a list of JSON schemas at the end. I opened one and looked through it, and it's [pretty detailed](https://smapi.io/schemas/content-patcher.json). Pathos really does a lot of great work for the SDV community, modded or not. Mostly backend stuff and internal stuff and an API on the website and extensive documentation and more mods and [the thing that made modding possible in the first place](https://smapi.io), but I digress.

Anyways that got me thinking of structure and JSON schemas for JSON files. My attention has always shifted between projects pretty often, and when I switched to this one, I was thinking about schemas. Schemas schemas schemas. I was playing around with schemas, learning how to make one for fun, and I thought "Wouldn't it be cool if you could define your command entirely in JSON and not with 10 different files?" So now we're here, where I'm beginning the big overhaul of this project. All the packages will probably be taken down, the repo wiki changed, the works. So much buildup for such an abrupt ending of a story. My fault haha

Anyways, I'm deleting this entire paragraph and also the note below (not the license footer) when I commit 1.0.0-alpha.10, which is the first iteration of this completely superior format. also I'm switching to Conventional Commits, or something mangled enough to my liking. The only people who care about strictly sticking to the format are big projects anyways.

--------------------------------------------------------------------------------

~~also i start my prereleases with \*.10 (1.0.0-alpha.**10**) because gold nugget packer doesn't like (1.0.0-alpha.**01**)??? idk weird stuff~~
e: just realized that this restriction is part of semver 2.0.0 actually so uhh whatever

--------------------------------------------------------------------------------

Copyright (c) 2021 muff1nOS. StardewSingleCommand is licensed under the [Apache License 2.0](http://www.apache.org/licenses/LICENSE-2.0) (SPDX:[Apache-2.0](https://spdx.org/licenses/Apache-2.0.html)). See this repository's [license](LICENSE) for more information.
