# wet-boew-razor
ASP.NET Razor variant of the [Web Experience Toolkit (WET) ](https://github.com/wet-boew/)

## Requirements
* ASP.NET Core 3.0

## Highlights
* [GC Intranet theme v4.0.27](https://wet-boew.github.io/themes-dist/theme-gc-intranet/index-en.html#en)
* Localized page partials for English and French.
* Uses libman to automatically pull in the WET-BOEW theme files and dependencies upon build
  * Doesn't include the IE 8 files
  * Only has the English and French localizations (if you need more, add to the libman.json file)
  * Doesn't include MathJax due to its size (if you need it, uncomment reference in the libman.json file)

## TODO
* Toggle the search on or off.
* Content pages for signed-on and signed-off.
* Can the breadcrumb and secondary menu be constructed via a sitemap file?

---

## Purpose
This theme adapts the [Government of Canada Web Usability theme](https://wet-boew.github.io/themes-dist/theme-gc-intranet/docs/ref/theme-gc-intranet/theme-gc-intranet-en.html) 
for intranet sites __using ASP.NET razor pages__.


## Use when

This theme can be used on Government of Canada intranet sites (including web applications).

## Do not use when

This theme can only be used on Government of Canada intranet sites.

## Working example
English and French examples available from the "Index" page of the application.

## How to implement

### General instructions

1. Use the *.cshtml files to create your Web pages.
2. __Optional:__ Create, install and link to one or more new CSS files (will be used for custom CSS)
3. All *.css, *.js, and *.gif file paths referenced in the partial files should be pulled in upon build by libman.
4. Replace the page title by setting `ViewData["Title"]`.
5. Correct the metadata values in `ViewData["Description"]`, `ViewData["Subject"]`, `ViewData["Issued"]` values

### Server instructions

Configure Custom HTTP Headers to emit __"X-UA-Compatible" "IE=Edge"__. Instructions on configuring IIS (English / French) or Apache (English / French) can be found on MSDN. This setting will ensure Internet Explorer 8, 9, and 10 will use their most recent rendering engine, as opposed to "Compatibility Views".

### Content page-specific instructions (content-*.cshtml)
* Correct the menu bar links or remove the menu bar
* Set the supported cultures (e.g., en-CA and fr-CA) in StartUp.cs.
* __Optional:__ Set a sub-site title by including ViewData["SubSiteName"] on a page.
* __Optional:__ Implement the secondary menu (maximum of 2 levels)
* Correct the search field or remove the search field
* Correct the breadcrumb trail or remove the breadcrumb trail
* Correct the __Transparency__ link or remove the __Transparency__ link
* Correct the site footer links
* Set `ViewData["Modified"]` to include the __Date Modified__ field on a page and in metadata.

### Splash page-specific instructions (splashpage-*.shtml)
1. Correct the English and French language links

### Server message page-specific instructions (serv*.html)
1. Replace the English and/or French messages.

##  Source code
* [Government of Canada Intranet theme source code on GitHub](https://github.com/wet-boew/theme-gc-intranet/tree/master/src)
* [Government of Canada Intranet theme demo pages source code on GitHub](https://github.com/wet-boew/theme-gc-intranet/tree/master/site/pages)
* [wet-boew-razor](https://github.com/RobJohnston/wet-boew-razor)
  