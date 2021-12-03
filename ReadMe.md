﻿[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fcodecov%2Fexample-csharp.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fcodecov%2Fexample-csharp?ref=badge_shield)

# Phill's Hypothetical Browser

Phill's Hypothetical Browser (PHB) is a testbed for security focused browser 
features built around WebView2 which is in turn a wrapper around Microsoft 
Edge which is a fork of Google Chrome. 

## What does it work on? How do I get started?

Currently, WebView2 and thus PHB is limited to Windows 7-11. Support for
MacOS is promised in the near future and eventual Linux support is clearly
on the product roadmap.

* [Build Guide](BuildGuide.md)

* [Installation Guide](InstallationGuide.md)


## Why write another browser?

Back when the Web was just beginning, proposing a new feature was easy. Some
features made it into the specs before anyone had noticed the spelling of
'Referer' was wrong.

Changing the Web today is hard because a browser represents thousands of
developer-years of effort. And the developers working on those browsers
respond to the instructions coming from the companies that pay their salaries
which are not always aligned with the interests of the users.

Every browser provider is also in the business of providing cloud services
to their users. Whether these services are profitable or can ever be profitable 
is uncertain. But the browser providers think they might be and so every browser
is currently tied to their proprietary cloud service. This makes the browsers 
sticky: Moving from Chrome to Edge imposes a switching cost. But this is a cost
the browser providers impose on the end users.

As is often said of Facebook, If you are not paying for the product, it is you.
This has applied to the Web since the early days of Netscape when some features 
were thrown into releases of the browser to serve a single Netscape customer's 
needs. Google makes its money out of advertising so don't expect Chrome to ever
let the user easily mute new tabs by default so that every time I visit CNN,
an advertisement for the company that took five months to fix my windscreen
because they lied about ordering the parts assaults my ears.

## What can PHB do?

All PHB can do at the moment is to load a page in a single tab. But getting to 
that stage only took me 15 minutes of coding. WebView2 is doing all the heavy 
lifting under the covers.

Using WebView2 means that I can implement at least some of the functionality 
I want to test without having to write a browser from scratch or forking 
Edge or Chrome. 


## What features are you planning to implement?

My first goal is to demonstrate the extended Web functionality made possible by 
my main project, the [Mathematical Mesh](https://github.com/hallambaker/Mathematical-Mesh).
These features include:

* [Share bookmarks](Bookmarks.md)

* [Password vault](Autofill.md)

* [Encrypted Authenticated Resource Locators](EARL.md)

* [Files encrypted to a Mesh encryption group](DARE.md)

* [Using Mesh Device credentials for Authentication](Authentication.md)

The leading browsers have supported a proprietary means of storing bookmarks and passwords
and sharing them across machines for decades and many proprietary 'password vault'
applications are available. But PHB will as far as I know be the first browser that
allows the user to choose their password vault service provider and it is 
certainly the first to use threshold cryptography to provide true end-to-end security 
for the passwords.

A secondary goal is to fix features that are clearly useful to the users but have
been removed from the browser or never implemented in the first place because
they threaten the commercial interests of the provider.

* [Control audio output](Audio.md)

* [Certificate validation security signal](Certificate.md)

Finally, there is a set of features that I think should be in the browser by default 
for which the response to a feature request is always 'you can always use an extension'.


## Are you trying to replace Edge and Chrome?

Of course not. When I was working on the Web at CERN we put an immense amount of time
and effort into persuading Microsoft to write a Web browser and make it part of the
Windows distribution.

The goal of PHB is to tip the scales in favor of the user by showing the value of 
features in a way that encourages the main browser providers to adopt them in their
own products.

## Can I help?

Sure, all help gratefully received. Give back to the main PHB build or head off in
your own direction.

In its basic form WebView2 only supports a single tab in a single Window. This is clearly 
far behind the capabilities modern users expect. Different people will have different
ideas about the features they want to add to the browser but there is no need for all
of us to write code to implement a multi-tabbed browsing window with tear off tabs.

Likewise, every application developer needs to package up their work for distribution.
At present, PHB only runs on Windows so an MSI installer will suffice. But WebView2
promises support for macOS in the near future and Linux is a reasonable expectation.
There is no need for every distribution to solve these problems separately or test out
the numerous existing open source solutions that claim to meet this need.

* [Basic browser features](BasicBrowser.md)

* [Distribution issues](Distribution.md)

