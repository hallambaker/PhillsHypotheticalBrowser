# Favorites, Bookmarks and History Interactions

Handling of bookmarks has deteriorated substantially in recent browsers. As a user
of the Google Toolbar, I was more than irritated by the fact that Chrome has never
supported use of the Google Toolbar Bookmarks store.

Rather than viewing browser history, bookmarks, downloads and sharing links as separate
activities, I believe these should be viewed as a continum with the whole process under
effective user control.

At one end of the spectrum there are sites where I want all my activities to be completely
untracked. Ideally, I would like this setting to be configured in such a fashion that 
the set of untracked sites is not kept in the browser in an easily deciphered form.

For all other sites, I want to be able to keep a complete history of every URI I have
visited and when. And I want this information to be available to tools that I run
on machines I control to perform predictions of other content I may be interested in.

In a small number of cases, I will want to explicitly bookmark a site for future interest. 
Such bookmarks may serve a multitude of purposes:

* To mark the site as being of interest for future visits (aka favorite)

* To mark that page to allow it to be revisited.

* To mark that page as a resource that I may cite in a future document I write.

* To annotate the page with my personal comments.

And in each of these cases, I may or may not wish to share the results of marking that
page with other people which may be a specific audience or the public.

The act of posting a link to Twitter or Facebook indicates that it is significant to me. 
Making this a browser feature allows the fact the page was blogged or tweeted to be captured
in the history feed.

Many times, my comments to Twitter are more of the nature of an aide memoir to myself
rather than for public consumption. If I find an interesting piece of news, I will
tweet it with a few brief comments.

The deepest commitment I can make to a piece of content is to add it to my personal
archive. As the cost of storage continues to fall, if a page is sufficiently interesting
to me that I want to create a bookmark, why not keep a copy in my personal archive?


## Mesh Bookmarks Catalog

The Mesh Bookmarks catalog is an end-to-end secure storage vault. The current schema will
need extension to support capture of annotations and history.


## Shared Bookmarks and Annotations

It should be possible for the user to create as many separate annotation catalogs as they
like and share these to different audiences.

So I might have separate annotations feeds for each of my professional interests
(cryptography, renewable energy) for my personal (friends, family), social and
so on.

Some of these feeds might be public but it is likely some will be private. I find
the way that some people share pictures of their children on public forums like 
Facebook quite worrying. Especially when they are quasi-public figures.

## One Way Do Not Remember

A simple way to create a 'do not remember' function is to generate a random key k 
and use it to calculate MAC of the site DNS address. If the site is not to be 
remembered, the result is recorded in a blocklist.

