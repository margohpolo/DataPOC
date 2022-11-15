## Data Dictionary: Application.SystemParameters 
 <br /> 
 <br /> 
 Any configurable parameters for the whole system 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**SystemParameterID**| Numeric ID used for row holding system parameters | 
|**DeliveryAddressLine1**| First address line for the company | 
|**DeliveryAddressLine2**| Second address line for the company | 
|**DeliveryCityID**| ID of the city for this address | 
|**DeliveryPostalCode**| Postal code for the company | 
|**DeliveryLocation**| Geographic location for the company office | 
|**PostalAddressLine1**| First postal address line for the company | 
|**PostalAddressLine2**| Second postaladdress line for the company | 
|**PostalCityID**| ID of the city for this postaladdress | 
|**PostalPostalCode**| Postal code for the company when sending via mail | 
|**ApplicationSettings**| JSON-structured application settings | 
|**LastEditedBy**| Null | 
|**LastEditedWhen**| Null | 
 
 </Details> 
 <br /> 
 <br />  


#### Column Attributes 
 <Details> 
 <Summary>Click to view</Summary>
 

<br /> 
 | Column | ColumnDefault | IsNullable | DataType | CharMaxLength | CharDataLength | NumericPrecision | NumericScale | DatetimePrecision | CharSetName | CollationName |
 |------|------|------|------|------|------|------|------|------|------|------|
 |**SystemParameterID**| (NEXT VALUE FOR [Sequences].[SystemParameterID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**DeliveryAddressLine1**| Null | NO | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**DeliveryAddressLine2**| Null | YES | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**DeliveryCityID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**DeliveryPostalCode**| Null | NO | nvarchar | 10 | 20 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**DeliveryLocation**| Null | NO | geography | -1 | -1 | Null | Null | Null | Null | Null | 
|**PostalAddressLine1**| Null | NO | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PostalAddressLine2**| Null | YES | nvarchar | 60 | 120 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**PostalCityID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PostalPostalCode**| Null | NO | nvarchar | 10 | 20 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**ApplicationSettings**| Null | NO | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
