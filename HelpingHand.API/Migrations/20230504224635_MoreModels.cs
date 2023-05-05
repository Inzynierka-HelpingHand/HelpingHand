using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpingHand.API.Migrations
{
    /// <inheritdoc />
    public partial class MoreModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabelTicket_Label_LabelsId",
                table: "LabelTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketStatus_StatusId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketStatus",
                table: "TicketStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "TicketStatus",
                newName: "TicketStatuses");

            migrationBuilder.RenameTable(
                name: "Label",
                newName: "Labels");

            migrationBuilder.AddColumn<int>(
                name: "ComplexityId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HardwereId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsUrgent",
                table: "Tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LicenceId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TicketStatuses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketStatuses",
                table: "TicketStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Labels",
                table: "Labels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ComplexityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplexityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hardwere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeeperId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardwere", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hardwere_AspNetUsers_KeeperId",
                        column: x => x.KeeperId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Licence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LicenceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LicenceUser",
                columns: table => new
                {
                    LicencesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenceUser", x => new { x.LicencesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_LicenceUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LicenceUser_Licence_LicencesId",
                        column: x => x.LicencesId,
                        principalTable: "Licence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ComplexityId",
                table: "Tickets",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_HardwereId",
                table: "Tickets",
                column: "HardwereId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_LicenceId",
                table: "Tickets",
                column: "LicenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwere_KeeperId",
                table: "Hardwere",
                column: "KeeperId");

            migrationBuilder.CreateIndex(
                name: "IX_LicenceUser_UsersId",
                table: "LicenceUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Location_LocationId",
                table: "AspNetUsers",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LabelTicket_Labels_LabelsId",
                table: "LabelTicket",
                column: "LabelsId",
                principalTable: "Labels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_ComplexityTypes_ComplexityId",
                table: "Tickets",
                column: "ComplexityId",
                principalTable: "ComplexityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Hardwere_HardwereId",
                table: "Tickets",
                column: "HardwereId",
                principalTable: "Hardwere",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Licence_LicenceId",
                table: "Tickets",
                column: "LicenceId",
                principalTable: "Licence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketStatuses_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "TicketStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Location_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_LabelTicket_Labels_LabelsId",
                table: "LabelTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ComplexityTypes_ComplexityId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Hardwere_HardwereId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Licence_LicenceId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketStatuses_StatusId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ComplexityTypes");

            migrationBuilder.DropTable(
                name: "Hardwere");

            migrationBuilder.DropTable(
                name: "LicenceUser");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Licence");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ComplexityId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_HardwereId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_LicenceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketStatuses",
                table: "TicketStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Labels",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "ComplexityId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "HardwereId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "IsUrgent",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "LicenceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "TicketStatuses",
                newName: "TicketStatus");

            migrationBuilder.RenameTable(
                name: "Labels",
                newName: "Label");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TicketStatus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketStatus",
                table: "TicketStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label",
                table: "Label",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LabelTicket_Label_LabelsId",
                table: "LabelTicket",
                column: "LabelsId",
                principalTable: "Label",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketStatus_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "TicketStatus",
                principalColumn: "Id");
        }
    }
}
