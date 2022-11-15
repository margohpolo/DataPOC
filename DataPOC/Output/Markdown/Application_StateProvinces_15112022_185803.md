## Data Dictionary: Application.StateProvinces 
 <br /> 
 <br /> 
 States or provinces that contain cities (including geographic location) 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**StateProvinceID**| Numeric ID used for reference to a state or province within the database | 
|**StateProvinceCode**| Common code for this state or province (such as WA - Washington for the USA) | 
|**StateProvinceName**| Formal name of the state or province | 
|**CountryID**| Country for this StateProvince | 
|**SalesTerritory**| Sales territory for this StateProvince | 
|**Border**| Geographic boundary of the state or province | 
|**LatestRecordedPopulation**| Latest available population for the StateProvince | 
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
 |**StateProvinceID**| (NEXT VALUE FOR [Sequences].[StateProvinceID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StateProvinceCode**| Null | NO | nvarchar | 5 | 10 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**StateProvinceName**| Null | NO | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**CountryID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**SalesTerritory**| Null | NO | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Border**| Null | YES | geography | -1 | -1 | Null | Null | Null | Null | Null | 
|**LatestRecordedPopulation**| Null | YES | bigint | Null | Null | 19 | 0 | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ValidFrom**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**ValidTo**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
