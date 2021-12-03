# Passwords and Other Autofill Interactions

Password autofill is actually just one instance of a general 'autofill' capability
that should be under user control. In particular it should be easy to set up multiple
profiles and 

## Mesh Password Catalog

The Mesh Password Catalog is an end-to-end secure credential store which may be used to
record usernames and passwords for use at Internet services and associated information
(URLs of login pages, HTML form ids, etc.)

The password catalog will probably need to be extended to support additional information 
relevant to the autofill capability.

## Mesh Contact Catalog

It should be possible to pull autofill details out of the contacts catalog. To send a
package to a friend for example.

The contacts catalog is also the natural place to store the user's delivery address,
which is the item they are most likely to want to autofill.


## Password Interactions

* Add username / password

* List passwords

* Delete passwords

* Auto-generate strong passwords

* Multiple profiles support [Hook to profiles for browser as a whole]


## Email address interactions

Wouldn't it be nice to be able to autogenerate a disposable SMTP email account that can be given
to a site nagging for one so that all the spam sent in return can be easily disposed of?


# Implementation Considerations

* There is no easy to hook in API for passwords.

* Some form of Microformat is going to be needed.

* The autofill code will bave to traverse the DOM looking for the password entry fields

* May have to create a mechanism to identify/share site profiles for password etc. entry forms.
