CREATE DATABASE "ProductsDatabase";

CREATE TABLE "Products" (
	"Product_ID"	INTEGER,
	"Product"	TEXT,
	PRIMARY KEY("Product_ID")
);

CREATE TABLE "Categories" (
	"Category_ID"	INTEGER,
	"Category"	TEXT,
	PRIMARY KEY("Category_ID")
);

CREATE TABLE "ProdToCat" (
	"Product_ID"	INTEGER,
	"Category_ID"	INTEGER,
	PRIMARY KEY("Product_ID","Category_ID"),
	FOREIGN KEY("Category_ID") REFERENCES "Categories"("Category_ID"),
	FOREIGN KEY("Product_ID") REFERENCES "Products"("Product_ID")
);

SELECT Products.Product, Categories.Category FROM Products
LEFT JOIN ProdToCat ON Products.Product_ID = ProdToCat.Product_ID
LEFT JOIN Categories ON Categories.Category_ID = ProdToCat.Category_ID