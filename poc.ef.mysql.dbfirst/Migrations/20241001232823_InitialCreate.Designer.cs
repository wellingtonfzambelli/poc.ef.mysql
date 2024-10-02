﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using poc.ef.mysql.dbfirst.Entities;

#nullable disable

namespace poc.ef.mysql.dbfirst.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241001232823_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int")
                        .HasColumnName("customerNumber");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("addressLine1");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("addressLine2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("ContactFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contactFirstName");

                    b.Property<string>("ContactLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contactLastName");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("country");

                    b.Property<decimal?>("CreditLimit")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("creditLimit");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("customerName");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("postalCode");

                    b.Property<int?>("SalesRepEmployeeNumber")
                        .HasColumnType("int")
                        .HasColumnName("salesRepEmployeeNumber");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("state");

                    b.HasKey("CustomerNumber")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "SalesRepEmployeeNumber" }, "salesRepEmployeeNumber");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeNumber")
                        .HasColumnType("int")
                        .HasColumnName("employeeNumber");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("extension");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("jobTitle");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("OfficeCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("officeCode");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("int")
                        .HasColumnName("reportsTo");

                    b.HasKey("EmployeeNumber")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "OfficeCode" }, "officeCode");

                    b.HasIndex(new[] { "ReportsTo" }, "reportsTo");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Office", b =>
                {
                    b.Property<string>("OfficeCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("officeCode");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("addressLine1");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("addressLine2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("country");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("postalCode");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("state");

                    b.Property<string>("Territory")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("territory");

                    b.HasKey("OfficeCode")
                        .HasName("PRIMARY");

                    b.ToTable("offices", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Order", b =>
                {
                    b.Property<int>("OrderNumber")
                        .HasColumnType("int")
                        .HasColumnName("orderNumber");

                    b.Property<string>("Comments")
                        .HasColumnType("text")
                        .HasColumnName("comments");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int")
                        .HasColumnName("customerNumber");

                    b.Property<DateOnly>("OrderDate")
                        .HasColumnType("date")
                        .HasColumnName("orderDate");

                    b.Property<DateOnly>("RequiredDate")
                        .HasColumnType("date")
                        .HasColumnName("requiredDate");

                    b.Property<DateOnly?>("ShippedDate")
                        .HasColumnType("date")
                        .HasColumnName("shippedDate");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("status");

                    b.HasKey("OrderNumber")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CustomerNumber" }, "customerNumber");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Orderdetail", b =>
                {
                    b.Property<int>("OrderNumber")
                        .HasColumnType("int")
                        .HasColumnName("orderNumber");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("productCode");

                    b.Property<short>("OrderLineNumber")
                        .HasColumnType("smallint")
                        .HasColumnName("orderLineNumber");

                    b.Property<decimal>("PriceEach")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("priceEach");

                    b.Property<int>("QuantityOrdered")
                        .HasColumnType("int")
                        .HasColumnName("quantityOrdered");

                    b.HasKey("OrderNumber", "ProductCode")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "ProductCode" }, "productCode");

                    b.ToTable("orderdetails", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Payment", b =>
                {
                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int")
                        .HasColumnName("customerNumber");

                    b.Property<string>("CheckNumber")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("checkNumber");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("amount");

                    b.Property<DateOnly>("PaymentDate")
                        .HasColumnType("date")
                        .HasColumnName("paymentDate");

                    b.HasKey("CustomerNumber", "CheckNumber")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.ToTable("payments", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Product", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("productCode");

                    b.Property<decimal>("BuyPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("buyPrice");

                    b.Property<decimal>("Msrp")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("MSRP");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("productDescription");

                    b.Property<string>("ProductLine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("productLine");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("productName");

                    b.Property<string>("ProductScale")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("productScale");

                    b.Property<string>("ProductVendor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("productVendor");

                    b.Property<short>("QuantityInStock")
                        .HasColumnType("smallint")
                        .HasColumnName("quantityInStock");

                    b.HasKey("ProductCode")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductLine" }, "productLine");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Productline", b =>
                {
                    b.Property<string>("ProductLine1")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("productLine");

                    b.Property<string>("HtmlDescription")
                        .HasColumnType("mediumtext")
                        .HasColumnName("htmlDescription");

                    b.Property<byte[]>("Image")
                        .HasColumnType("mediumblob")
                        .HasColumnName("image");

                    b.Property<string>("TextDescription")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)")
                        .HasColumnName("textDescription");

                    b.HasKey("ProductLine1")
                        .HasName("PRIMARY");

                    b.ToTable("productlines", (string)null);
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Customer", b =>
                {
                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Employee", "SalesRepEmployeeNumberNavigation")
                        .WithMany("Customers")
                        .HasForeignKey("SalesRepEmployeeNumber")
                        .HasConstraintName("customers_ibfk_1");

                    b.Navigation("SalesRepEmployeeNumberNavigation");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Employee", b =>
                {
                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Office", "OfficeCodeNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeCode")
                        .IsRequired()
                        .HasConstraintName("employees_ibfk_2");

                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Employee", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("employees_ibfk_1");

                    b.Navigation("OfficeCodeNavigation");

                    b.Navigation("ReportsToNavigation");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Order", b =>
                {
                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Customer", "CustomerNumberNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerNumber")
                        .IsRequired()
                        .HasConstraintName("orders_ibfk_1");

                    b.Navigation("CustomerNumberNavigation");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Orderdetail", b =>
                {
                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Order", "OrderNumberNavigation")
                        .WithMany("Orderdetails")
                        .HasForeignKey("OrderNumber")
                        .IsRequired()
                        .HasConstraintName("orderdetails_ibfk_1");

                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Product", "ProductCodeNavigation")
                        .WithMany("Orderdetails")
                        .HasForeignKey("ProductCode")
                        .IsRequired()
                        .HasConstraintName("orderdetails_ibfk_2");

                    b.Navigation("OrderNumberNavigation");

                    b.Navigation("ProductCodeNavigation");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Payment", b =>
                {
                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Customer", "CustomerNumberNavigation")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerNumber")
                        .IsRequired()
                        .HasConstraintName("payments_ibfk_1");

                    b.Navigation("CustomerNumberNavigation");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Product", b =>
                {
                    b.HasOne("poc.ef.mysql.dbfirst.Entities.Productline", "ProductLineNavigation")
                        .WithMany("Products")
                        .HasForeignKey("ProductLine")
                        .IsRequired()
                        .HasConstraintName("products_ibfk_1");

                    b.Navigation("ProductLineNavigation");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Employee", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("InverseReportsToNavigation");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Order", b =>
                {
                    b.Navigation("Orderdetails");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Product", b =>
                {
                    b.Navigation("Orderdetails");
                });

            modelBuilder.Entity("poc.ef.mysql.dbfirst.Entities.Productline", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
