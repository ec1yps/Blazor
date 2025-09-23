using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Academy.Models;

public partial class Pv319ImportContext : DbContext
{
    public Pv319ImportContext()
    {
    }

    public Pv319ImportContext(DbContextOptions<Pv319ImportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Direction> Directions { get; set; }

    public virtual DbSet<Discipline> Disciplines { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=AcademyContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Direction>(entity =>
        {
            entity.Property(e => e.DirectionId).HasColumnName("direction_id");
            entity.Property(e => e.DirectionName)
                .HasMaxLength(50)
                .HasColumnName("direction_name");
        });

        modelBuilder.Entity<Discipline>(entity =>
        {
            entity.Property(e => e.DisciplineId)
                .ValueGeneratedNever()
                .HasColumnName("discipline_id");
            entity.Property(e => e.DisciplineName)
                .HasMaxLength(150)
                .HasColumnName("discipline_name");
            entity.Property(e => e.NumberOfLessons).HasColumnName("number_of_lessons");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("group_id");
            entity.Property(e => e.Direction).HasColumnName("direction");
            entity.Property(e => e.GroupName)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("group_name");
            entity.Property(e => e.StartTime)
                .HasPrecision(0)
                .HasColumnName("start_time");
            entity.Property(e => e.Weekdays).HasColumnName("weekdays");

            entity.HasOne(d => d.DirectionNavigation).WithMany(p => p.Groups)
                .HasForeignKey(d => d.Direction)
                .HasConstraintName("FK_Groups_Directions");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(s => s.StudId);

            entity.Property(e => e.StudId).HasColumnName("stud_id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Group).HasColumnName("group");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middle_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("phone");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");

            entity.HasOne(d => d.GroupNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.Group)
                .HasConstraintName("FK_Students_Groups");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.Property(e => e.TeacherId)
                .ValueGeneratedNever()
                .HasColumnName("teacher_id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middle_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("phone");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Rate)
                .HasColumnType("smallmoney")
                .HasColumnName("rate");
            entity.Property(e => e.WorkSince).HasColumnName("work_since");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
