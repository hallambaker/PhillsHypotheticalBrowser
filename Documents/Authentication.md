# User Authentication

It should be easy to authenticate to Web properties using a variety of
credentials.

My personal view is that it is the difficulty of managing private keys 
across multiple devices that has been the chief obstacle to use of 
public key authentication rather than the lack of a particular protocol
capability.

Over the years, we seem to have proliferated rather a lot of frameworks
for plugging in authentication schemes. Do these actually help at all?
I am doubful.

HTTP has a perfectly adequate authentication mechanism built into the
protocol. I think implementing a public key authentication scheme based
on a challenge response built on HTTP should probably be our first 
priority.

If other people want to use PHB as a test vehicle for their prefered
scheme using DIDs, SAML, etc. etc. that is also fine.
