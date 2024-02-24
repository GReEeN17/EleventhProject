using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EleventhProject.Server.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "blood_type_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "breed_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "city_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "clinic_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "donation_history_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "donor_search_card_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "pet_type_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "pet_vaccination_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "user_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateSequence<int>(
                name: "vaccination_dict_sequence",
                minValue: 1L,
                maxValue: 999999L);

            migrationBuilder.CreateTable(
                name: "blood_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"vaccination_dict_sequence\"')"),
                    title = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blood_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "breed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetTypeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetTypeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vaccination_dict",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaccination_dict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clinic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    address = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clinic_city_CityId",
                        column: x => x.CityId,
                        principalTable: "city",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    username = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    password = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    phone_number = table.Column<long>(type: "bigint", nullable: false),
                    surname = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    middle_name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    not_ready_for_donation = table.Column<bool>(type: "boolean", nullable: false),
                    absense_begin_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    absense_end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_city_CityId",
                        column: x => x.CityId,
                        principalTable: "city",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "donor_search_card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatorId = table.Column<int>(type: "integer", nullable: false),
                    ClinicId = table.Column<int>(type: "integer", nullable: false),
                    reason = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    blood_amount = table.Column<int>(type: "integer", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_required = table.Column<bool>(type: "boolean", nullable: false),
                    pets_current = table.Column<int>(type: "integer", nullable: false),
                    pets_needed = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donor_search_card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_donor_search_card_clinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "clinic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_donor_search_card_user_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    PetTypeId = table.Column<int>(type: "integer", nullable: false),
                    BreedId = table.Column<int>(type: "integer", nullable: false),
                    BloodTypeId = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    age = table.Column<int>(type: "integer", nullable: false),
                    weight = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pet_PetTypeEntity_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pet_blood_type_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalTable: "blood_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pet_breed_BreedId",
                        column: x => x.BreedId,
                        principalTable: "breed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pet_user_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "donation_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecipientId = table.Column<int>(type: "integer", nullable: false),
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donation_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_donation_history_pet_DonorId",
                        column: x => x.DonorId,
                        principalTable: "pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_donation_history_pet_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pet_vaccination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VaccinationDictId = table.Column<int>(type: "integer", nullable: false),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet_vaccination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pet_vaccination_pet_PetId",
                        column: x => x.PetId,
                        principalTable: "pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pet_vaccination_vaccination_dict_VaccinationDictId",
                        column: x => x.VaccinationDictId,
                        principalTable: "vaccination_dict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clinic_CityId",
                table: "clinic",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_donation_history_DonorId",
                table: "donation_history",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_donation_history_RecipientId",
                table: "donation_history",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_donor_search_card_ClinicId",
                table: "donor_search_card",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_donor_search_card_CreatorId",
                table: "donor_search_card",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_BloodTypeId",
                table: "pet",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_BreedId",
                table: "pet",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_OwnerId",
                table: "pet",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_PetTypeId",
                table: "pet",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_vaccination_PetId",
                table: "pet_vaccination",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_vaccination_VaccinationDictId",
                table: "pet_vaccination",
                column: "VaccinationDictId");

            migrationBuilder.CreateIndex(
                name: "IX_user_CityId",
                table: "user",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "donation_history");

            migrationBuilder.DropTable(
                name: "donor_search_card");

            migrationBuilder.DropTable(
                name: "pet_vaccination");

            migrationBuilder.DropTable(
                name: "clinic");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "vaccination_dict");

            migrationBuilder.DropTable(
                name: "PetTypeEntity");

            migrationBuilder.DropTable(
                name: "blood_type");

            migrationBuilder.DropTable(
                name: "breed");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropSequence(
                name: "blood_type_sequence");

            migrationBuilder.DropSequence(
                name: "breed_sequence");

            migrationBuilder.DropSequence(
                name: "city_sequence");

            migrationBuilder.DropSequence(
                name: "clinic_sequence");

            migrationBuilder.DropSequence(
                name: "donation_history_sequence");

            migrationBuilder.DropSequence(
                name: "donor_search_card_sequence");

            migrationBuilder.DropSequence(
                name: "pet_type_sequence");

            migrationBuilder.DropSequence(
                name: "pet_vaccination_sequence");

            migrationBuilder.DropSequence(
                name: "user_sequence");

            migrationBuilder.DropSequence(
                name: "vaccination_dict_sequence");
        }
    }
}
