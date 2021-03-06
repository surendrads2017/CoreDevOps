// <auto-generated />
using CoreDevOps.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDevOps.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDevOps.Models.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoItem");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "In Meeting need to discuss some points.",
                            IsComplete = true,
                            Name = "Meeting with management"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "List of this this item buy.",
                            IsComplete = false,
                            Name = "Go for shooping"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Here is task to ask to do on call.",
                            IsComplete = true,
                            Name = "Call to some one for do some task"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
