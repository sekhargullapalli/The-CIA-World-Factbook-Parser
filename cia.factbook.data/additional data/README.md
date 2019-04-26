# Description

The file comparablefields.json list all fields in the country details, which are ranked. All the listed fields are ranked in descending order, except for two fields "Unemployment rate" and "Inflation rate". The json deserializes to list of ` cia.factbook.parse.ComparableField ` type. An example for the comparable field is:

```

{
    "FieldName": "Area",
    "Category": "Geography",
    "IsDescending": true
}

```
The notesanddef.json file deserializes to a Dictionary<string,string> and contains detailed description of the categories and fields in the country details schema. An example of a definition:

```
"Area": "This entry includes three subfields. Total area is the sum of all land and water areas delimited by international boundaries and/or coastlines. Land area is the aggregate of all surfaces delimited by international boundaries and/or coastlines, excluding inland water bodies (lakes, reservoirs, rivers). Water area is the sum of the surfaces of all inland water bodies, such as lakes, reservoirs, or rivers, as delimited by international boundaries and/or coastlines.",
```
