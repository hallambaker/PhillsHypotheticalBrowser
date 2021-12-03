# Data At Rest Envelope

Data At Rest Envelope (DARE) is a component technology of the Mathematical Mesh which 
makes it easy to secure Data at Rest.

In particular, the threshold encryhption supported in the Mesh allows a document
to be encrypted to a group of users whose membership changes over time.

If Bob joins the group, he can be given access to every document encrypted to
the group encryption key in a single operation. When Carol leaves the group, 
she can read what she has already decrypted and saved but she cannot decrypt 
any new documents.

The encrypted documents themselves do not change when the group membership 
changes. Nor does the key service through which the group membership is maintained 
have read access to the document contents.

