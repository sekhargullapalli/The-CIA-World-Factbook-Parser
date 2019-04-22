# Description

The factbook/json (2018 archive) folder contains 269 json files, each containing HTML content of the corresponding country profiles. The schema for that data is listed below. The HTML content of all these files is parsed and the data is organized into json format (representing a collecton of ` cia.factbook.parse.ProfileEntity ` type).  



# Schema Used for the Country Profiles in CIA Factbook

The information is origanized in the form of Category and Fields. The Fields can have Sub-Fields. Some of the fields are comparable and will be assosiated with a ranking. Note all fields/sub fields are not madatory for every country

This information is parsed from the factbook/docs/print_profileguide.html file (see ` cia.factbook.parse.FactbookParser.GetProfileSchema(string content) `)


+ Introduction
    + Background
+ Geography
    + Location
    + Geographic coordinates
    + Map references
    + Area
        + total
        + land
        + water
    + Area - comparative
    + Land boundaries
        + total
        + border countries
        + regional borders
    + Coastline
    + Maritime claims
        + territorial sea
        + exclusive economic zone
        + contiguous zone
        + continental shelf
        + exclusive fishing zone
    + Climate
    + Terrain
    + Elevation
        + mean elevation
        + elevation extremes
    + Natural resources
    + Land use
        + agricultural land
        + agricultural land: arable land
        + agricultural land: permanent crops
        + agricultural land: permanent pasture
        + forest
        + other
    + Irrigated land
    + Population distribution
    + Natural hazards
    + Environment - current issues
    + Environment - international agreements
        + party to
        + signed, but not ratified
    + Geography - note
+ People and Society
    + Population
    + Nationality
        + noun
        + adjective
    + Ethnic groups
    + Languages
    + Religions
    + Demographic profile
    + Age structure
        + 0-14 years
        + 15-24 years
        + 25-54 years
        + 55-64 years
        + 65 years and over
    + Dependency ratios
        + total dependency ratio
        + youth dependency ratio
        + elderly dependency ratio
        + potential support ratio
    + Median age
        + total
        + male
        + female
    + Population growth rate
    + Birth rate
    + Death rate
    + Net migration rate
    + Population distribution
    + Urbanization
        + urban population
        + rate of urbanization
    + Major urban areas - population
    + Sex ratio
        + at birth
        + 0-14 years
        + 15-24 years
        + 25-54 years
        + 55-64 years
        + 65 years and over
        + total population
    + Mother's mean age at first birth
    + Maternal mortality rate
    + Infant mortality rate
        + total
        + male
        + female
    + Life expectancy at birth
        + total population
        + male
        + female
    + Total fertility rate
    + Contraceptive prevalence rate
    + Health expenditures
    + Physicians density
    + Hospital bed density
    + Drinking water source
        + improved: urban
        + improved: rural
        + improved: total
        + unimproved: urban
        + unimproved: rural
        + unimproved: total
    + Sanitation facility access
        + improved: urban
        + improved: rural
        + improved: total
        + unimproved: urban
        + unimproved: rural
        + unimproved: total
    + HIV/AIDS - adult prevalence rate
    + HIV/AIDS - people living with HIV/AIDS
    + HIV/AIDS - deaths
    + Major infectious diseases
        + degree of risk
        + food or waterborne diseases
        + vectorborne diseases
        + water contact diseases
        + animal contact diseases
        + respiratory diseases
        + soil contact diseases
        + aerosolized dust or soil contact diseases
    + Obesity - adult prevalence rate
    + Children under the age of 5 years underweight
    + Education expenditures
    + Literacy
        + definition
        + total population
        + male
        + female
    + School life expectancy (primary to tertiary education)
        + total
        + male
        + female
    + Unemployment, youth ages 15-24
        + total
        + male
        + female
    + People - note
+ Government
    + Country name
        + conventional long form
        + conventional short form
        + local long form
        + local short form
        + former
        + abbreviation
        + etymology
    + Dependency status
    + Government type
    + Capital
        + name
        + geographic coordinates
        + time difference
        + daylight saving time
        + capital
    + Administrative divisions
    + Dependent areas
    + Independence
    + National holiday
    + Constitution
        + history
        + amendments
    + Legal system
    + International law organization participation
    + Citizenship
        + citizenship by birth
        + citizenship by descent only
        + dual citizenship recognized
        + residency requirement for naturalization
    + Suffrage
    + Judicial branch
        + highest courts
        + judge selection and term of office
        + subordinate courts
    + Executive branch
        + chief of state
        + head of government
        + cabinet
        + elections/appointments
        + election results
        + head of state
    + Legislative branch
        + description
        + elections
        + election results
    + Political parties and leaders
    + International organization participation
    + Diplomatic representation in the US
        + chief of mission
        + chancery
        + telephone
        + FAX
        + consulate(s) general
        + consulate(s)
        + embassy
        + honorary consulate(s)
    + Diplomatic representation from the US
        + chief of mission
        + embassy
        + mailing address
        + telephone
        + FAX
        + consulate(s) general
        + branch office(s)
        + consulate(s)
    + Flag description
    + National symbol(s)
    + National anthem
        + name
        + lyrics/music
    + Government - note
+ Economy
    + Economy - overview
    + GDP (purchasing power parity)
    + GDP (official exchange rate)
    + GDP - real growth rate
    + GDP - per capita (PPP)
    + Gross national saving
    + GDP - composition, by end use
        + household consumption
        + government consumption
        + investment in fixed capital
        + investment in inventories
        + exports of goods and services
        + imports of goods and services
    + GDP - composition, by sector of origin
        + agriculture
        + industry
        + services
    + Agriculture - products
    + Industries
    + Industrial production growth rate
    + Labor force
    + Labor force - by occupation
        + agriculture
        + industry
        + services
        + industry and services
        + manufacturing
        + construction
        + commerce
        + other services
    + Unemployment rate
    + Population below poverty line
    + Household income or consumption by percentage share
        + lowest 10%
        + highest 10%
    + Distribution of family income - Gini index
    + Budget
        + revenues
        + expenditures
    + Taxes and other revenues
    + Budget surplus (+) or deficit (-)
    + Public debt
    + Fiscal year
    + Inflation rate (consumer prices)
    + Central bank discount rate
    + Commercial bank prime lending rate
    + Stock of narrow money
    + Stock of broad money
    + Stock of domestic credit
    + Market value of publicly traded shares
    + Current account balance
    + Exports
    + Exports - partners
    + Exports - commodities
    + Imports
    + Imports - commodities
    + Imports - partners
    + Reserves of foreign exchange and gold
    + Debt - external
    + Stock of direct foreign investment - at home
    + Stock of direct foreign investment - abroad
    + Exchange rates
+ Energy
    + Electricity access
        + population without electricity
        + electrification - total population
        + electrification - urban areas
        + electrification - rural areas
    + Electricity - production
    + Electricity - consumption
    + Electricity - exports
    + Electricity - imports
    + Electricity - installed generating capacity
    + Electricity - from fossil fuels
    + Electricity - from nuclear fuels
    + Electricity - from hydroelectric plants
    + Electricity - from other renewable sources
    + Crude oil - production
    + Crude oil - exports
    + Crude oil - imports
    + Crude oil - proved reserves
    + Refined petroleum products - production
    + Refined petroleum products - consumption
    + Refined petroleum products - exports
    + Refined petroleum products - imports
    + Natural gas - production
    + Natural gas - consumption
    + Natural gas - exports
    + Natural gas - imports
    + Natural gas - proved reserves
    + Carbon dioxide emissions from consumption of energy
+ Communications
    + Telephones - fixed lines
        + total subscriptions
        + subscriptions per 100 inhabitants
    + Telephones - mobile cellular
        + total subscriptions
        + subscriptions per 100 inhabitants
    + Telephone system
        + general assessment
        + domestic
        + international
    + Broadcast media
    + Internet country code
    + Internet users
        + total
        + percent of population
    + Broadband - fixed subscriptions
        + total
        + subscriptions per 100 inhabitants
    + Communications - note
+ Transportation
    + National air transport system
        + number of registered air carriers
        + inventory of registered aircraft operated by air carriers
        + annual passenger traffic on registered air carriers
        + annual freight traffic on registered air carriers
    + Civil aircraft registration country code prefix
    + Airports
        + total
    + Airports - with paved runways
        + total
        + over 3,047 m
        + 2,438 to 3,047 m
        + 1,524 to 2,437 m
        + 914 to 1,523 m
        + under 914 m
    + Airports - with unpaved runways
        + total
        + over 3,047 m
        + 2,438 to 3,047 m
        + 1,524 to 2,437 m
        + 914 to 1,523 m
        + under 914 m
    + Heliports
    + Pipelines
    + Railways
        + total
        + standard gauge
        + narrow gauge
        + broad gauge
        + dual gauge
    + Roadways
        + total
        + paved
        + unpaved
        + urban
        + non-urban
    + Waterways
    + Merchant marine
        + total
        + by type
    + Ports and terminals
        + major seaport(s)
        + oil terminal(s)
        + container port(s) (TEUs)
        + lake port(s)
        + LNG terminal(s) (export)
        + LNG terminal(s) (import)
        + river port(s)
        + dry bulk cargo port(s)
        + bulk cargo port(s)
    + Transportation - note
+ Military and Security
    + Military expenditures
    + Military branches
    + Military service age and obligation
    + Maritime threats
    + Military - note
+ Terrorism
    + Terrorist groups - home based
    + Terrorist groups - foreign based
+ Transnational Issues
    + Disputes - international
    + Refugees and internally displaced persons
        + refugees (country of origin)
        + IDPs
        + stateless persons
    + Trafficking in persons
        + current situation
        + tier rating
    + Illicit drugs
