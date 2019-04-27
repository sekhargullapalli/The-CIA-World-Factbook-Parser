# CIA World Factbook Parser

In this project, the data contained in the [CIA world factbook](https://www.cia.gov/library/publications/the-world-factbook/) is collected are parsed into JSON format. The data collected is extracted from The CIA World Factbook 2018 archive (around 1.6 GB is size) which can be downloaded [here](https://www.cia.gov/library/publications/download).

The main data files created (in cia.factbook.data folder) are:

+ countrieslist.json: The list of the countries with country codes and link to flag files, national anthems etc
+ notesanddefs.json: A decription of the various fields, categories 
+ comparablefields.json: A list of the fields in country details that are comparable, e.g., Area, Population etc
+ countrydetails.json (compressed as countrydetails.zip): All the details of the countries organized as categories, fields and sub-fields in JSON format.


The parser used for this is a .net core console application and is included in this repository.

# Acknowledgement
The .net core application uses AngleSharp Nuget Package for DOM parsing of the HTML content and Newtonsoft.Json for JSON serialization

# Useful Links

[The World Factbook](https://www.cia.gov/library/publications/the-world-factbook/)

[The World Factbook Archive](https://www.cia.gov/library/publications/download)

[The World Factbook FAQ](https://www.cia.gov/library/publications/the-world-factbook/docs/faqs.html)


# License

Conversion of the content of CIA World Factbook 2018 into JSON format
Copyright (C) 2019  Vijaya Sekhar Gullapalli

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
