﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationRestaurant.Data;

namespace WebApplicationRestaurant.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210314161553_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DishIngredient", b =>
                {
                    b.Property<int>("DishesId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.HasKey("DishesId", "IngredientsId");

                    b.HasIndex("IngredientsId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("DishMenuPlan", b =>
                {
                    b.Property<int>("DishesId")
                        .HasColumnType("int");

                    b.Property<int>("MenuPlansId")
                        .HasColumnType("int");

                    b.HasKey("DishesId", "MenuPlansId");

                    b.HasIndex("MenuPlansId");

                    b.ToTable("MenuPlanItem");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PlaceSchedule", b =>
                {
                    b.Property<int>("PlacesId")
                        .HasColumnType("int");

                    b.Property<int>("SchedulesId")
                        .HasColumnType("int");

                    b.HasKey("PlacesId", "SchedulesId");

                    b.HasIndex("SchedulesId");

                    b.ToTable("SchedulePlace");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("fk_category");

                    b.Property<double>("Cost")
                        .HasColumnType("float")
                        .HasColumnName("cost");

                    b.Property<int>("DishUnitId")
                        .HasColumnType("int")
                        .HasColumnName("fk_unit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.Property<double>("Weight")
                        .HasColumnType("float")
                        .HasColumnName("weight");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CategoryId" }, "IX_Dish_fk_category");

                    b.HasIndex(new[] { "DishUnitId" }, "IX_Dish_fk_unit");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.DishStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("DishStatus");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.DishUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("DishUnit");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Count")
                        .HasColumnType("float")
                        .HasColumnName("count");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("delivery_date");

                    b.Property<int>("IngredientUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IngredientUnitId" }, "IX_Ingredient_fk_unit");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.IngredientUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("IngredientUnit");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.MenuPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("PlanEndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("plan_end_date");

                    b.Property<DateTime>("PlanStartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("plan_start_date");

                    b.HasKey("Id");

                    b.ToTable("MenuPlan");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0)
                        .HasColumnName("amount");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("create_time")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("FinishTime")
                        .HasColumnType("datetime")
                        .HasColumnName("finish_time");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int")
                        .HasColumnName("fk_place");

                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("fk_status");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("fk_user");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PlaceId" }, "IX_Order_fk_place");

                    b.HasIndex(new[] { "StatusId" }, "IX_Order_fk_status");

                    b.HasIndex(new[] { "UserId" }, "IX_Order_fk_user");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderIngredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("create_date")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("fk_status");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("fk_user");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "StatusId" }, "IX_OrderIngredients_fk_status");

                    b.HasIndex(new[] { "UserId" }, "IX_OrderIngredients_fk_user");

                    b.ToTable("OrderIngredients");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderIngredientsItem", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("OrderIngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("count");

                    b.HasKey("IngredientId", "OrderIngredientsId");

                    b.HasIndex("OrderIngredientsId");

                    b.ToTable("OrderIngredientsItem");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderIngredientsStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("OrderIngredientsStatus");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Available")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("available");

                    b.Property<DateTime?>("ReserveTime")
                        .HasColumnType("datetime")
                        .HasColumnName("reserve_time");

                    b.Property<string>("ReserverName")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("reserver_name")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("fk_user");

                    b.Property<DateTime>("WorkingDate")
                        .HasColumnType("datetime")
                        .HasColumnName("working_date");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_OrderIngredients_fk_user")
                        .HasDatabaseName("IX_OrderIngredients_fk_user1");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("fk_order");

                    b.Property<int>("DishId")
                        .HasColumnType("int")
                        .HasColumnName("fk_dish");

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("count");

                    b.Property<int>("DishStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("fk_status");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("fk_user");

                    b.HasKey("OrderId", "DishId");

                    b.HasIndex("DishId");

                    b.HasIndex(new[] { "DishStatusId" }, "IX_SchoppingCartItem_fk_status");

                    b.HasIndex(new[] { "UserId" }, "IX_SchoppingCartItem_fk_user");

                    b.ToTable("ShoppingCartItem");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("Name")
                        .IsFixedLength(true);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .HasColumnName("Surname")
                        .IsFixedLength(true);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DishIngredient", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DishMenuPlan", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.MenuPlan", null)
                        .WithMany()
                        .HasForeignKey("MenuPlansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaceSchedule", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.Place", null)
                        .WithMany()
                        .HasForeignKey("PlacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.Schedule", null)
                        .WithMany()
                        .HasForeignKey("SchedulesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Dish", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.Category", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Dish_Category")
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.DishUnit", "DishUnit")
                        .WithMany("Dishes")
                        .HasForeignKey("DishUnitId")
                        .HasConstraintName("FK_Dish_Unit")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("DishUnit");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Ingredient", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.IngredientUnit", "IngredientUnit")
                        .WithMany("Ingredients")
                        .HasForeignKey("IngredientUnitId")
                        .HasConstraintName("FK_Ingredient_Unit")
                        .IsRequired();

                    b.Navigation("IngredientUnit");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Order", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.Place", "Place")
                        .WithMany("Orders")
                        .HasForeignKey("PlaceId")
                        .HasConstraintName("FK_Order_Place")
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK_Order_OrderStatus")
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Order_User")
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderIngredients", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.OrderIngredientsStatus", "Status")
                        .WithMany("OrderIngredients")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK_OrderIngredients_OrderIngredientsStatus")
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.User", "User")
                        .WithMany("OrderIngredients")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_OrderIngredients_User")
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderIngredientsItem", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.Ingredient", "Ingredient")
                        .WithMany("OrderIngredientsItems")
                        .HasForeignKey("IngredientId")
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.OrderIngredients", "OrderIngredients")
                        .WithMany("OrderIngredientsItems")
                        .HasForeignKey("OrderIngredientsId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("OrderIngredients");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Schedule", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.User", "User")
                        .WithMany("Schedules")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Schedule_User")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("WebApplicationRestaurant.Models.Dish", "Dish")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("DishId")
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.DishStatus", "DishStatus")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("DishStatusId")
                        .HasConstraintName("FK_SchoppingCartItem_DishStatus")
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.Order", "Order")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("WebApplicationRestaurant.Models.User", "User")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_SchoppingCartItem_User");

                    b.Navigation("Dish");

                    b.Navigation("DishStatus");

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Category", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Dish", b =>
                {
                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.DishStatus", b =>
                {
                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.DishUnit", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Ingredient", b =>
                {
                    b.Navigation("OrderIngredientsItems");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.IngredientUnit", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Order", b =>
                {
                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderIngredients", b =>
                {
                    b.Navigation("OrderIngredientsItems");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderIngredientsStatus", b =>
                {
                    b.Navigation("OrderIngredients");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.Place", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebApplicationRestaurant.Models.User", b =>
                {
                    b.Navigation("OrderIngredients");

                    b.Navigation("Orders");

                    b.Navigation("Schedules");

                    b.Navigation("ShoppingCart");
                });
#pragma warning restore 612, 618
        }
    }
}
