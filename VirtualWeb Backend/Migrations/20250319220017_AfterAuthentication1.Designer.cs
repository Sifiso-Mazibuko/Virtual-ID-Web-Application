﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VID.Data;

#nullable disable

namespace VID.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250319220017_AfterAuthentication1")]
    partial class AfterAuthentication1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VID.Models.Applicant", b =>
                {
                    b.Property<int>("ApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("APPLICANT_ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ApplicantId"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("ApplicantId"), 2L, null, null, null, null, null);

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("EMAIL");

                    b.Property<string>("PersonId")
                        .HasColumnType("text")
                        .HasColumnName("PERSON_ID");

                    b.Property<string>("UserPhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("USER_PHONE_NUMBER");

                    b.HasKey("ApplicantId");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("VID.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("APPLICATION_ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ApplicationId"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("ApplicationId"), 2L, null, null, null, null, null);

                    b.Property<string>("ApplicantId")
                        .HasColumnType("text")
                        .HasColumnName("APPLICANT_ID");

                    b.Property<string>("Citizenship")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CITIZENSHIP");

                    b.Property<string>("CountryOfBirth")
                        .HasColumnType("text")
                        .HasColumnName("COUNTRYOFBIRTH");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DATEOFBIRTH");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("EMAIL");

                    b.Property<string>("FatherId")
                        .HasColumnType("text")
                        .HasColumnName("FATHERID");

                    b.Property<string>("FatherName")
                        .HasColumnType("text")
                        .HasColumnName("FATHERNAME");

                    b.Property<string>("FullName")
                        .HasColumnType("text")
                        .HasColumnName("FULLNAME");

                    b.Property<string>("Gender")
                        .HasColumnType("text")
                        .HasColumnName("GENDER");

                    b.Property<string>("MotherId")
                        .HasColumnType("text")
                        .HasColumnName("MOTHERID");

                    b.Property<string>("MotherName")
                        .HasColumnType("text")
                        .HasColumnName("MOTHERRNAME");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NATIONALITY");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("PHONENUMBER");

                    b.Property<string>("Province")
                        .HasColumnType("text")
                        .HasColumnName("PROVINCE");

                    b.Property<string>("Status")
                        .HasColumnType("text")
                        .HasColumnName("STATUS");

                    b.HasKey("ApplicationId");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("VID.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("DOCUMENT_ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DocumentId"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("DocumentId"), 2L, null, null, null, null, null);

                    b.Property<string>("ApplicationId")
                        .HasColumnType("text")
                        .HasColumnName("APPLICATION_ID");

                    b.Property<byte[]>("BirthCertificate")
                        .HasColumnType("bytea")
                        .HasColumnName("DOCUMENT_BIRTHCERTIFICATE");

                    b.Property<string>("DocumentCode")
                        .HasColumnType("text")
                        .HasColumnName("DOCUMENT_CODE");

                    b.Property<byte[]>("IdCopy")
                        .HasColumnType("bytea")
                        .HasColumnName("DOCUMENT_IDENTITY_NUMBER_COPY");

                    b.HasKey("DocumentId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("VID.Models.NextOfKin", b =>
                {
                    b.Property<int>("NextOfKinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("NEXT_OF_KIN_ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("NextOfKinId"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("NextOfKinId"), 2L, null, null, null, null, null);

                    b.Property<string>("NOKID")
                        .HasColumnType("text")
                        .HasColumnName("NEXT_OF_KIN_IDENTITYID");

                    b.Property<string>("NOKNAME")
                        .HasColumnType("text")
                        .HasColumnName("NEXT_OF_KIN_NAME");

                    b.Property<string>("NextOfKinPhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("NEXT_OF_KIN_PHONENUMBER");

                    b.Property<string>("PersonId")
                        .HasColumnType("text")
                        .HasColumnName("PERSON_ID");

                    b.Property<string>("Relationship")
                        .HasColumnType("text")
                        .HasColumnName("RELATIONSHIP");

                    b.HasKey("NextOfKinId");

                    b.ToTable("NextOfKin");
                });

            modelBuilder.Entity("VID.Models.Person", b =>
                {
                    b.Property<string>("IdentityId")
                        .HasColumnType("text")
                        .HasColumnName("IDENTITY_ID");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DATEOFBIRTH");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Firstname")
                        .HasColumnType("text")
                        .HasColumnName("FIRSTNAME");

                    b.Property<string>("Gender")
                        .HasColumnType("text")
                        .HasColumnName("GENDER");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer")
                        .HasColumnName("PERSON_ID");

                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("PersonId"), 2L, null, null, null, null, null);

                    b.Property<string>("Surname")
                        .HasColumnType("text")
                        .HasColumnName("SURNAME");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("USER_PASSWORD");

                    b.HasKey("IdentityId");

                    b.ToTable("person", (string)null);
                });

            modelBuilder.Entity("VID.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("STATUS_ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StatusID"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<int>("StatusID"), 2L, null, null, null, null, null);

                    b.Property<string>("StatusName")
                        .HasColumnType("text")
                        .HasColumnName("STATUS_NAME");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
