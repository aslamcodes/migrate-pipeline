﻿// <auto-generated />
using System;
using EduQuest.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduQuest.Migrations
{
    [DbContext(typeof(EduQuestContext))]
    [Migration("20240730043441_target-audience-prerequisites")]
    partial class targetaudienceprerequisites
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence<int>("ContentOrders");

            modelBuilder.HasSequence<int>("SectionOrders");

            modelBuilder.Entity("EduQuest.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentId")
                        .IsUnique();

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("EduQuest.Entities.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR ContentOrders");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("EduQuest.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CourseObjective")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EducatorId")
                        .HasColumnType("int");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prerequisites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("TargetAudience")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCategoryId");

                    b.HasIndex("EducatorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EduQuest.Entities.CourseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Courses on various programming languages and software development techniques.",
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Courses on graphic design, UX/UI, and other design disciplines.",
                            Name = "Design"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Courses covering business management, entrepreneurship, and corporate strategy.",
                            Name = "Business"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Courses on digital marketing, advertising, and sales strategies.",
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Courses on music theory, instrument training, and music production.",
                            Name = "Music"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Courses on photography techniques, camera handling, and photo editing.",
                            Name = "Photography"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Courses on physical health, fitness routines, and nutrition.",
                            Name = "Health & Fitness"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Courses focused on personal growth, self-improvement, and life skills.",
                            Name = "Personal Development"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Courses covering lifestyle improvements, hobbies, and general well-being.",
                            Name = "Lifestyle"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Courses on IT infrastructure, software applications, and tech support.",
                            Name = "IT & Software"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Courses on learning new languages and improving language proficiency.",
                            Name = "Language"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Courses covering academic subjects and school-level education.",
                            Name = "Academics"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Courses on various engineering disciplines and technical skills.",
                            Name = "Engineering"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Courses covering different scientific fields and research methods.",
                            Name = "Science"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Courses on mathematics, from basic arithmetic to advanced calculus.",
                            Name = "Mathematics"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Courses on data analysis, machine learning, and big data.",
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Courses on various forms of art, history, and cultural studies.",
                            Name = "Art & Culture"
                        },
                        new
                        {
                            Id = 22,
                            Description = "Courses on financial management, accounting principles, and investments.",
                            Name = "Finance & Accounting"
                        },
                        new
                        {
                            Id = 24,
                            Description = "Courses on sales techniques, customer relations, and sales management.",
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 26,
                            Description = "Courses on management skills, leadership, and organizational behavior.",
                            Name = "Management"
                        },
                        new
                        {
                            Id = 27,
                            Description = "Courses on effective communication, public speaking, and interpersonal skills.",
                            Name = "Communication"
                        },
                        new
                        {
                            Id = 42,
                            Description = "Courses on physical fitness, exercise routines, and healthy living.",
                            Name = "Fitness"
                        });
                });

            modelBuilder.Entity("EduQuest.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<float>("DiscountAmount")
                        .HasColumnType("real");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderedCourseId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime?>("ProcessedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderedCourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EduQuest.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentTransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EduQuest.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR SectionOrders");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("EduQuest.Entities.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("EduQuest.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEducator")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordHashKey")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EduQuest.Entities.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("DurationHours")
                        .HasColumnType("int");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<int>("DurationSeconds")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentId")
                        .IsUnique();

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("EduQuest.Entities.Article", b =>
                {
                    b.HasOne("EduQuest.Entities.Content", "Content")
                        .WithOne("Article")
                        .HasForeignKey("EduQuest.Entities.Article", "ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("EduQuest.Entities.Content", b =>
                {
                    b.HasOne("EduQuest.Entities.Section", "Section")
                        .WithMany("Contents")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("EduQuest.Entities.Course", b =>
                {
                    b.HasOne("EduQuest.Entities.CourseCategory", "CourseCategory")
                        .WithMany("Courses")
                        .HasForeignKey("CourseCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduQuest.Entities.User", "Educator")
                        .WithMany("CoursesCreated")
                        .HasForeignKey("EducatorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CourseCategory");

                    b.Navigation("Educator");
                });

            modelBuilder.Entity("EduQuest.Entities.Order", b =>
                {
                    b.HasOne("EduQuest.Entities.Course", "OrderedCourse")
                        .WithMany("Orders")
                        .HasForeignKey("OrderedCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduQuest.Entities.User", "OrderedUser")
                        .WithMany("CoursesOrdered")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderedCourse");

                    b.Navigation("OrderedUser");
                });

            modelBuilder.Entity("EduQuest.Entities.Payment", b =>
                {
                    b.HasOne("EduQuest.Entities.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("EduQuest.Entities.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("EduQuest.Entities.Section", b =>
                {
                    b.HasOne("EduQuest.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EduQuest.Entities.StudentCourse", b =>
                {
                    b.HasOne("EduQuest.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduQuest.Entities.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EduQuest.Entities.Video", b =>
                {
                    b.HasOne("EduQuest.Entities.Content", "Content")
                        .WithOne("Video")
                        .HasForeignKey("EduQuest.Entities.Video", "ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("EduQuest.Entities.Content", b =>
                {
                    b.Navigation("Article")
                        .IsRequired();

                    b.Navigation("Video")
                        .IsRequired();
                });

            modelBuilder.Entity("EduQuest.Entities.Course", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EduQuest.Entities.CourseCategory", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("EduQuest.Entities.Order", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("EduQuest.Entities.Section", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("EduQuest.Entities.User", b =>
                {
                    b.Navigation("CoursesCreated");

                    b.Navigation("CoursesOrdered");
                });
#pragma warning restore 612, 618
        }
    }
}
