﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentExamRegistration.DataAccess;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240404120245_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentExamRegistration.DataAccess.Entities.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("date");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<decimal>("Score")
                        .HasColumnType("numeric(1,0)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("LessonId");

                    b.HasIndex("StudentId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("StudentExamRegistration.DataAccess.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"));

                    b.Property<decimal>("Class")
                        .HasColumnType("numeric(2,0)");

                    b.Property<string>("LessonCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("LessonTitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TeacherSurname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("LessonId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("StudentExamRegistration.DataAccess.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<decimal>("Class")
                        .HasColumnType("numeric(2,0)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("StudentNumber")
                        .HasColumnType("numeric(5,0)");

                    b.Property<string>("StudentSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentExamRegistration.DataAccess.Entities.Exam", b =>
                {
                    b.HasOne("StudentExamRegistration.DataAccess.Entities.Lesson", "Lesson")
                        .WithMany("Exams")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentExamRegistration.DataAccess.Entities.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentExamRegistration.DataAccess.Entities.Lesson", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("StudentExamRegistration.DataAccess.Entities.Student", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
