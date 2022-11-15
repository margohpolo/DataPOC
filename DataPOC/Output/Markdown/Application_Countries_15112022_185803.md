## Data Dictionary: Application.Countries 
 <br /> 
 <br /> 
 Countries that contain the states or provinces (including geographic boundaries) 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**CountryID**| Numeric ID used for reference to a country within the database | 
|**CountryName**| Name of the country | 
|**FormalName**| Full formal name of the country as agreed by United Nations | 
|**IsoAlpha3Code**| 3 letter alphabetic code assigned to the country by ISO | 
|**IsoNumericCode**| Numeric code assigned to the country by ISO | 
|**CountryType**| Type of country or administrative region | 
|**LatestRecordedPopulation**| Latest available population for the country | 
|**Continent**| Name of the continent | 
|**Region**| Name of the region | 
|**Subregion**| Name of the subregion | 
|**Border**| Geographic border of the country as described by the United Nations | 
|**LastEditedBy**| Null | 
|**ValidFrom**| Null | 
|**ValidTo**| Null | 
 
 </Details> 
 <br /> 
 <br />  


#### Column Attributes 
 <Details> 
 <Summary>Click to view</Summary>
 

<br /> 
 | Column | ColumnDefault | IsNullable | DataType | CharMaxLength | CharDataLength | NumericPrecision | NumericScale | DatetimePrecision | CharSetName | CollationName |
 |------|------|------|------|------|------|------|------|------|------|------|
 |**CountryID**| (NEXT VALUE FOR [Sequences].[CountryID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**CountryName**| Null | NO | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**FormalName**| Null | NO | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**IsoAlpha3Code**| Null | YES | nvarchar | 3 | 6 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**IsoNumericCode**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**CountryType**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LatestRecordedPopulation**| Null | YES | bigint | Null | Null | 19 | 0 | Null | Null | Null | 
|**Continent**| Null | NO | nvarchar | 30 | 60 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Region**| Null | NO | nvarchar | 30 | 60 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Subregion**| Null | NO | nvarchar | 30 | 60 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Border**| Null | YES | geography | -1 | -1 | Null | Null | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ValidFrom**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**ValidTo**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
