using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnderGroups.Migrations.Data
{
    /// <inheritdoc />
    public partial class CheckConstainsType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create unique index ix_TypeCondition
                    on public.""UnderGroups"" (""StudentId"", ""GroupTypeId"")
                    where ""UnderGroups"".""GroupTypeId"" = 3;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop index public.ix_TypeCondition;");
        }
    }
}
