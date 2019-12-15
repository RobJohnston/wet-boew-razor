# wet-boew-razor
ASP.NET Razor variant of the [Web Experience Toolkit (WET) ](https://github.com/wet-boew/)

## Requirements
* .NET Core 2.1

## What's this all about
* [GC Intranet theme v4.0.27](https://wet-boew.github.io/themes-dist/theme-gc-intranet/index-en.html#en)
* Localized page partials for English and French.
* Uses libman to automatically pull in the WET-BOEW theme files and dependencies upon build
  * Doesn't include the IE 8 files
  * Only has the English and French localizations (if you need more, add to the libman.json file)
  * Doesn't include MathJax (if you need it, uncomment reference in the libman.json file)
  
 ## Status of page examples
 |    Covered     |  Description
 |:--------------:|:--------------
  ❌              | Content page
  ❌              | Content page - Secondary menu
  ❌              | Content page - Sub-site
  ❌              | Content page - No search or language selection link
  ✔              | Content page - No site menu or breadcrumb trail
  ❌               | Content page - No search, language selection link, site menu or breadcrumb trail
  ❌              | Content page - Signed Off
  ❌              | Content page - Signed On
  ❌              | Splash page
  ❌              | 404 error page
  ✔               | 404 error page - English/French
  ❌              | Server message page - English/French
  ✔               | Server message page
