# Description

The list of countries, their GEC, ISO 3166, STANAG and INTERNET codes are extracted from the factbook/appendix/print_appendixf.html file

For ease, I have copied the content and saved it as a CSV file and converted it a JSON file (representing a collection of ` cia.factbook.parse.Country ` type)

Then, the corresponding flag file, national anthem file, data file are identified for each country by searching appropriate folders and JSON file is updated. If a file is not found, the file name is set to empty string.

In this folder, the following file are placed:

+ The CSV file created from the factbook/appendix/print_appendixf.html file
+ JSON file with country names, codes and mapping to flag, national anthem and data files.

The first entity in the JSON file:
```
 {
    "Name": "Afghanistan",
    "GEC": "AF",
    "ISO_3166_1_Alpha2": "AF",
    "ISO_3166_1_Alpha3": "AFG",
    "ISO_3166_1_Numeric": "4",
    "STANAG": "AFG",
    "Internet": ".af",
    "Comment": "",
    "Flagfile": "AF-flag.gif",
    "AnthemFile": "AF.mp3",
    "Datafile": "af.json"
  }
```

