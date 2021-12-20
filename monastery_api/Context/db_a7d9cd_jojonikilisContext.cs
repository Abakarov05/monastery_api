using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using monastery_api.Models;

#nullable disable

namespace monastery_api.Context
{
    public partial class db_a7d9cd_jojonikilisContext : DbContext
    {
        public db_a7d9cd_jojonikilisContext()
        {
        }

        public db_a7d9cd_jojonikilisContext(DbContextOptions<db_a7d9cd_jojonikilisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NotesAndService> NotesAndServices { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OfferStatus> OfferStatuses { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<ScheduleWork> ScheduleWorks { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }
        public virtual DbSet<TypeItem> TypeItems { get; set; }
        public virtual DbSet<TypeTask> TypeTasks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=SQL5101.site4now.net;Initial Catalog=db_a7d9cd_jojonikilis;User Id=db_a7d9cd_jojonikilis_admin;Password=1234567qwertyu");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.ToTable("budget");

                entity.HasIndex(e => e.Id, "budget_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdNotePrice, "budget_notes_id_fk");

                entity.HasIndex(e => e.IdOfferItemPrice, "budget_offers_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BudgetDate)
                    .HasPrecision(0)
                    .HasColumnName("budget_date");

                entity.Property(e => e.IdNotePrice).HasColumnName("id_note_price");

                entity.Property(e => e.IdOfferItemPrice).HasColumnName("id_offer_item_price");


            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("discounts");

                entity.HasIndex(e => e.Id, "discount_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.DiscountPercent, "discount_percent_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("items");

                entity.HasIndex(e => e.Id, "item_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdStore, "item_store_id_fk");

                entity.HasIndex(e => e.IdType, "item_type_item_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdStore).HasColumnName("id_store");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.ItemPrice).HasColumnName("item_price");


            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("notes");

                entity.HasIndex(e => e.Id, "notes_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdUser, "notes_users_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.NotePrice).HasColumnName("note_price");


            });

            modelBuilder.Entity<NotesAndService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("notes_and_services");

                entity.HasIndex(e => e.IdNote, "notes_and_services_notes_id_fk");

                entity.HasIndex(e => e.IdService, "notes_and_services_services_id_fk");

                entity.Property(e => e.IdNote).HasColumnName("id_note");

                entity.Property(e => e.IdService).HasColumnName("id_service");


            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.ToTable("offers");

                entity.HasIndex(e => e.Id, "offers_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdItem, "offers_items_id_fk");

                entity.HasIndex(e => e.IdOfferStatus, "offers_offer_status_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

                entity.Property(e => e.IdOfferStatus).HasColumnName("id_offer_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.OfferDate)
                    .HasColumnType("date")
                    .HasColumnName("offer_date");


            });

            modelBuilder.Entity<OfferStatus>(entity =>
            {
                entity.ToTable("offer_status");

                entity.HasIndex(e => e.Id, "offer_status_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.OfferStatusName, "offer_status_offer_status_name_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OfferStatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("offer_status_name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => e.Id, "roles_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.RoleName, "roles_role_name_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.ToTable("salaries");

                entity.HasIndex(e => e.Id, "salaries_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdUser, "salaries_users_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.SalaryPrice).HasColumnName("salary_price");


            });

            modelBuilder.Entity<ScheduleWork>(entity =>
            {
                entity.ToTable("schedule_works");

                entity.HasIndex(e => e.Id, "schedule_works_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.ScheduleWorkDate, "schedule_works_schedule_work_date_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdService, "schedule_works_services_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.ScheduleWorkDate)
                    .HasPrecision(0)
                    .HasColumnName("schedule_work_date");


            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("services");

                entity.HasIndex(e => e.Id, "services_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.ServiceName, "services_service_name_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ServiceDescription)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("service_description");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("service_name");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("store");

                entity.HasIndex(e => e.Id, "store_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.StoreItemName, "store_store_item_name_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StoreItemAvailable).HasColumnName("store_item_available");

                entity.Property(e => e.StoreItemName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_item_name");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("tasks");

                entity.HasIndex(e => e.Id, "tasks_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdTypeTask, "tasks_type_task_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTypeTask).HasColumnName("id_type_task");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("task_name");


            });

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.ToTable("todo");

                entity.HasIndex(e => e.Id, "todo_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdTask, "todo_tasks_id_fk");

                entity.HasIndex(e => e.IdUser, "todo_users_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTask).HasColumnName("id_task");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.TodoStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("todo_status");


            });

            modelBuilder.Entity<TypeItem>(entity =>
            {
                entity.ToTable("type_item");

                entity.HasIndex(e => e.Id, "type_item_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.TypeItemName, "type_item_type_item_name_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TypeItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type_item_name");
            });

            modelBuilder.Entity<TypeTask>(entity =>
            {
                entity.ToTable("type_task");

                entity.HasIndex(e => e.Id, "type_task_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TypeTaskName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type_task_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.IdDiscount, "users_discounts_id_fk");

                entity.HasIndex(e => e.Id, "users_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.UserLogin, "users_login_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.IdRole, "users_roles_id_fk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDiscount).HasColumnName("id_discount");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_login");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("user_password");

                entity.Property(e => e.UserSurname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_surname");


            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
