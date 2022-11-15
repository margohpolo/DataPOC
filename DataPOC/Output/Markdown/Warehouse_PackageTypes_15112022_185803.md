## Data Dictionary: Warehouse.PackageTypes 
 <br /> 
 <br /> 
 Ways that stock items can be packaged (ie: each, box, carton, pallet, kg, etc. 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**PackageTypeID**| Numeric ID used for reference to a package type within the database | 
|**PackageTypeName**| Full name of package types that stock items can be purchased in or sold in | 
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
 |**PackageTypeID**| (NEXT VALUE FOR [Sequences].[PackageTypeID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**PackageTypeName**| Null | NO | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ValidFrom**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**ValidTo**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
