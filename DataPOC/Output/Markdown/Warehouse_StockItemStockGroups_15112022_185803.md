## Data Dictionary: Warehouse.StockItemStockGroups 
 <br /> 
 <br /> 
 Which stock items are in which stock groups 
 <br /> 
 <br /> 
 

####  Column Remarks
 <Details> 
 <Summary>Click to view</Summary> 
 

<br /> 
 | Column | Remarks | 
 |------|------|  
|**StockItemStockGroupID**| Internal reference for this linking row | 
|**StockItemID**| Stock item assigned to this stock group (FK indexed via unique constraint) | 
|**StockGroupID**| StockGroup assigned to this stock item (FK indexed via unique constraint) | 
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
 |**StockItemStockGroupID**| (NEXT VALUE FOR [Sequences].[StockItemStockGroupID]) | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockItemID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**StockGroupID**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedBy**| Null | NO | int | Null | Null | 10 | 0 | Null | Null | Null | 
|**LastEditedWhen**| (sysdatetime()) | NO | datetime2 | Null | Null | Null | Null | 7 | Null | Null | 
 
 </Details> 
