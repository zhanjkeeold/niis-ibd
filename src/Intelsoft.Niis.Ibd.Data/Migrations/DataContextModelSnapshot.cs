﻿// <auto-generated />
using System;
using Intelsoft.Niis.Ibd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Intelsoft.Niis.Ibd.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.ContractRequestDispatchStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractRequestId")
                        .HasColumnType("int");

                    b.Property<bool>("Dispatched")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DispatchingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("ContractRequestId")
                        .IsUnique();

                    b.ToTable("ContractRequestDispatchStatuses");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.ContractRequestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssigneeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssigneeXin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<string>("ContractNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ContractRegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ContractTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ContractValidityDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Xin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("TypeId");

                    b.ToTable("ContractRequests");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.ContractTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameKz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("ContractTypes");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.IbdResponseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataProcessingText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ErrorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("IbdResponses");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.Maps.ContractRequestMessageMapEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractRequestId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("ContractRequestId");

                    b.HasIndex("MessageId");

                    b.ToTable("ContractRequestMessageMap");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.Maps.IbdResponseMessageMapEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IbdResponseId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("IbdResponseId");

                    b.HasIndex("MessageId");

                    b.ToTable("IbdResponseMessageMap");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.MessageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Method")
                        .HasColumnType("int");

                    b.Property<string>("RawData")
                        .HasColumnType("xml");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.PropertyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IntellectualPropertyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProtectionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RowCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidityDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.ContractRequestDispatchStatusEntity", b =>
                {
                    b.HasOne("Intelsoft.Niis.Ibd.Entities.ContractRequestEntity", "ContractRequest")
                        .WithOne("DispatchStatus")
                        .HasForeignKey("Intelsoft.Niis.Ibd.Entities.ContractRequestDispatchStatusEntity", "ContractRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.ContractRequestEntity", b =>
                {
                    b.HasOne("Intelsoft.Niis.Ibd.Entities.PropertyEntity", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intelsoft.Niis.Ibd.Entities.ContractTypeEntity", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.Maps.ContractRequestMessageMapEntity", b =>
                {
                    b.HasOne("Intelsoft.Niis.Ibd.Entities.ContractRequestEntity", "ContractRequest")
                        .WithMany("Messages")
                        .HasForeignKey("ContractRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intelsoft.Niis.Ibd.Entities.MessageEntity", "Message")
                        .WithMany("ContractRequests")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Intelsoft.Niis.Ibd.Entities.Maps.IbdResponseMessageMapEntity", b =>
                {
                    b.HasOne("Intelsoft.Niis.Ibd.Entities.IbdResponseEntity", "IbdResponse")
                        .WithMany("Messages")
                        .HasForeignKey("IbdResponseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intelsoft.Niis.Ibd.Entities.MessageEntity", "Message")
                        .WithMany("IbdResponses")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
