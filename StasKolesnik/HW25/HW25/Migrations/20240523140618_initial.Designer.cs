﻿// <auto-generated />
using DZLesson25.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DZLesson25.Migrations
{
    [DbContext(typeof(MeetingDbContext))]
    [Migration("20240523140618_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DZLesson25.DB.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdRoom")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("DZLesson25.DB.MeetingRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeetingRooms");
                });

            modelBuilder.Entity("DZLesson25.DB.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DZLesson25.DB.UsersInMeeting", b =>
                {
                    b.Property<int>("IdMeeting")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("IdMeeting", "IdUser");

                    b.HasIndex("IdUser");

                    b.ToTable("UsersInMetings");
                });

            modelBuilder.Entity("DZLesson25.DB.Meeting", b =>
                {
                    b.HasOne("DZLesson25.DB.MeetingRoom", "Room")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DZLesson25.DB.UsersInMeeting", b =>
                {
                    b.HasOne("DZLesson25.DB.Meeting", "Meeting")
                        .WithMany("usersInMeetings")
                        .HasForeignKey("IdMeeting")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DZLesson25.DB.User", "User")
                        .WithMany("usersInMeetings")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DZLesson25.DB.Meeting", b =>
                {
                    b.Navigation("usersInMeetings");
                });

            modelBuilder.Entity("DZLesson25.DB.User", b =>
                {
                    b.Navigation("usersInMeetings");
                });
#pragma warning restore 612, 618
        }
    }
}
