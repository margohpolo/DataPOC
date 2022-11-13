## Data Dictionary: Application.Cities 
 <br /> 
 <br /> 
 Cities that are part of any address (including geographic location) 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**CityID**| Numeric ID used for reference to a city within the database | 
|**CityName**| Formal name of the city | 
|**StateProvinceID**| State or province for this city | 
|**Location**| Geographic location of the city | 
|**LatestRecordedPopulation**| Latest available population for the City | 
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
 |**CityID**| (NEXT VALUE FOR [Sequences].[CityID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**CityName**| Null | NO | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**StateProvinceID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**Location**| Null | YES | geography | -1 | -1 | Null | Null | Null | Null | Null | 
|**LatestRecordedPopulation**| Null | YES | bigint | Null | Null | 19 | 0 | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ValidFrom**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**ValidTo**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
