**************
Zip File Archive Extractor
**************

Blake Mccabe - 20131003

The purpose of this small app is to extract files of a defined file name pattern from a zip archive folder to another folder.

It was built for the UsWeather Summary app (http://usweathersummary.azurewebsites.net) as the process of moving approximately 72 files from the QCLCD archives folders by hand was very tedious and error prone.  Each month's archive folder contained several files, but only a one file from each month's folder was required.

By resetting the values in the origin path, file matching, and destination strings, anyone (with Visual Studio 2012) can use the app to extract their desired files from zip archive folders programmatically.

  