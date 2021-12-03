# Distribution

If more than a few people are going to use PHB, it will have to be available
as a binary distribution with a platform specific installer for each supported
platform

This is not difficult work and there are numerous online resources. The problem
being that many of those resources are out of date or wrong.

What is required is a completely turnkey scheme such that when a release is 
being created, builds are automatically cut for each of the supported platforms,
these are wrapped in the platform specific packaging tools and the binary
distributions pushed out to the relevant Web sites for download.

The whole process should also be authenticated under the relevant code signing
keys.

## Windows

Need code to build an MSI


## macOS

Need code to build a PKG

This has to be via a script, not a GUI command.


## Linux

Need to know the tar layout for each of the distributions to be directly supported.

Since Edge is only supported on Unbuntu and Centos directly, it probably makes sense
to focus on those.

## iOS

Will need to publish to the store.

## Android

Will need to publish to the store.