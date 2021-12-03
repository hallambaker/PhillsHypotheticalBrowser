# Certificate validation security signal

**Goal:** Provide the user with a clear security signal that immediately distinguishes
the validation requirements met by the TLS certificate presented (EV, OV, or DV).


## Why did the security signal disappear?

Contrary to popular misunderstanding, neither SSL nor TLS were originally 
designed to protect the confidentiality of Web traffic. The original brief
was considerably narrower - to make using a credit card online at least as
safe as using one in a bricks and mortar store.

When SSL was originally proposed, US export restrictions limited the strength
of encryption to 40 bits. Although this was later increased to 56 bits and 
Server Gated Crypto introduced for use by banks, SSL and TLS gave only limited 
protection of confidentiality until the export regime was changed in 2000.

The primary purpose of what is now known as the 'WebPKI' was to establish a
degree of accountability by tying an online identity to a 'real life' identity,
in most cases a corporate registration. TLS does not prevent a merchant taking
your credit card number and not delivering the goods but if the TLS certificate
meets the CABForum Extended Validation criteria, it does mean that there is 
a likelihood of consequences if they do.

When TLS was first deployed, Public Key cryptography required rather more CPU
power than the machines of the day really supported. The problem being particularly
accute for servers. As a result, use of TLS was typically limited to payments 
and other interactions. While TLS was intended to be a general purpose security
control from the start, the user experience was built arround an implicit assumption
that it was only being used for a limited number of security critical interactions.

As a result of the thousand-fold increase in performance since, TLS is now 
correctly recognized as a tool that can and should be ubiquitous. Performance
need not limit the use of TLS to just security critical interactions. But as 
use of TLs became ubiquitous, 'usability experts' decided that the security
signal that users had relied on to tell which parts of the Web were safe for over
a decade was just too difficult for them to understand and rather than design 
a better security signal, the 'best solution' was to eliminate the signal entirely
and rely on a proprietary 'Web safety' service.

The company that pursued this stratgegy most aggressively was Google which in
addition to being the publisher of Chrome was (and is) also the main source of revenue for 
Mozilla, the publisher of the then second ranked Firefox.




# Implementation Considerations

The main requirement is a means of intercepting the TLS connection setup so that the
server certificate can be read.

Secondary requirement will be to make use of additional cert status validation 
mechanism.

This particular project could also provide the basis for implementing personal user
certification such as certs issued under a callsign CA.



