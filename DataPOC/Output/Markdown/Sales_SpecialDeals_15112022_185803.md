## Data Dictionary: Sales.SpecialDeals 
 <br /> 
 <br /> 
 Special pricing (can include fixed prices, discount $ or discount %) 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**SpecialDealID**| ID (sequence based) for a special deal | 
|**StockItemID**| Stock item that the deal applies to (if NULL, then only discounts are permitted not unit prices) | 
|**CustomerID**| ID of the customer that the special pricing applies to (if NULL then all customers) | 
|**BuyingGroupID**| ID of the buying group that the special pricing applies to (optional) | 
|**CustomerCategoryID**| ID of the customer category that the special pricing applies to (optional) | 
|**StockGroupID**| ID of the stock group that the special pricing applies to (optional) | 
|**DealDescription**| Description of the special deal | 
|**StartDate**| Date that the special pricing starts from | 
|**EndDate**| Date that the special pricing ends on | 
|**DiscountAmount**| Discount per unit to be applied to sale price (optional) | 
|**DiscountPercentage**| Discount percentage per unit to be applied to sale price (optional) | 
|**UnitPrice**| Special price per unit to be applied instead of sale price (optional) | 
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
 |**SpecialDealID**| (NEXT VALUE FOR [Sequences].[SpecialDealID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockItemID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**CustomerID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**BuyingGroupID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**CustomerCategoryID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockGroupID**| Null | YES | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**DealDescription**| Null | NO | nvarchar | 30 | 60 | Null | Null | Null | UNICODE | Latin1_General_100_CI_AS | 
|**StartDate**| Null | NO | date | Null | Null | Null | Null | 0 | Null | Null | 
|**EndDate**| Null | NO | date | Null | Null | Null | Null | 0 | Null | Null | 
|**DiscountAmount**| Null | YES | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**DiscountPercentage**| Null | YES | decimal | Null | Null | 18 | 3 | Null | Null | Null | 
|**UnitPrice**| Null | YES | decimal | Null | Null | 18 | 2 | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
