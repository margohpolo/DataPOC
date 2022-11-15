## Data Dictionary: Warehouse.StockItems 
 <br /> 
 <br /> 
 Main entity table for stock items 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**StockItemID**| Numeric ID used for reference to a stock item within the database | 
|**StockItemName**| Full name of a stock item (but not a full description) | 
|**SupplierID**| Usual supplier for this stock item | 
|**ColorID**| Color (optional) for this stock item | 
|**UnitPackageID**| Usual package for selling units of this stock item | 
|**OuterPackageID**| Usual package for selling outers of this stock item (ie cartons, boxes, etc.) | 
|**Brand**| Brand for the stock item (if the item is branded) | 
|**Size**| Size of this item (eg: 100mm) | 
|**LeadTimeDays**| Number of days typically taken from order to receipt of this stock item | 
|**QuantityPerOuter**| Quantity of the stock item in an outer package | 
|**IsChillerStock**| Does this stock item need to be in a chiller? | 
|**Barcode**| Barcode for this stock item | 
|**TaxRate**| Tax rate to be applied | 
|**UnitPrice**| Selling price (ex-tax) for one unit of this product | 
|**RecommendedRetailPrice**| Recommended retail price for this stock item | 
|**TypicalWeightPerUnit**| Typical weight for one unit of this product (packaged) | 
|**MarketingComments**| Marketing comments for this stock item (shared outside the organization) | 
|**InternalComments**| Internal comments (not exposed outside organization) | 
|**Photo**| Photo of the product | 
|**CustomFields**| Custom fields added by system users | 
|**Tags**| Advertising tags associated with this stock item (JSON array retrieved from CustomFields) | 
|**SearchDetails**| Combination of columns used by full text search | 
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
 |**StockItemID**| (NEXT VALUE FOR [Sequences].[StockItemID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockItemName**| Null | NO | nvarchar | 100 | 200 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**SupplierID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ColorID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**UnitPackageID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**OuterPackageID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**Brand**| Null | YES | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Size**| Null | YES | nvarchar | 20 | 40 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LeadTimeDays**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**QuantityPerOuter**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**IsChillerStock**| Null | NO | bit | Null | Null | Null | Null | Null | Null | Null | 
|**Barcode**| Null | YES | nvarchar | 50 | 100 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**TaxRate**| Null | NO | decimal | Null | Null | 18 | 3 | Null | Null | Null | 
|**UnitPrice**| Null | NO | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**RecommendedRetailPrice**| Null | YES | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**TypicalWeightPerUnit**| Null | NO | decimal | Null | Null | 18 | 3 | Null | Null | Null | 
|**MarketingComments**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**InternalComments**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Photo**| Null | YES | varbinary | -1 | -1 | Null | Null | Null | Null | Null | 
|**CustomFields**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**Tags**| Null | YES | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**SearchDetails**| Null | NO | nvarchar | -1 | -1 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**ValidFrom**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
|**ValidTo**| Null | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
