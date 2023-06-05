﻿// <auto-generated />
using System;
using AasxServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AasxServerStandardBib.Migrations
{
    [DbContext(typeof(AasContext))]
    [Migration("20230602130418_allsematicid")]
    partial class allsematicid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("AasxServer.AasSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AasId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Aasx")
                        .HasColumnType("TEXT");

                    b.Property<string>("AssetId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AssetKind")
                        .HasColumnType("TEXT");

                    b.Property<string>("Idshort")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AasSets");
                });

            modelBuilder.Entity("AasxServer.SubmodelSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AasId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AasSetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aasx")
                        .HasColumnType("TEXT");

                    b.Property<string>("AllIdshort")
                        .HasColumnType("TEXT");

                    b.Property<string>("AllSemanticId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Idshort")
                        .HasColumnType("TEXT");

                    b.Property<string>("SemanticId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubmodelId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AasSetId");

                    b.ToTable("SubmodelSets");
                });

            modelBuilder.Entity("AasxServer.SubmodelSet", b =>
                {
                    b.HasOne("AasxServer.AasSet", null)
                        .WithMany("Submodels")
                        .HasForeignKey("AasSetId");
                });

            modelBuilder.Entity("AasxServer.AasSet", b =>
                {
                    b.Navigation("Submodels");
                });
#pragma warning restore 612, 618
        }
    }
}
