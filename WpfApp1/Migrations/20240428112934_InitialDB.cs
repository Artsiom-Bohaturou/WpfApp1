using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "analysis_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    executable_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    parameters = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_analysis_types", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "assortment_rolls",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assortment_rolls", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "assortments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slide3_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slide2_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slide_xyz_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assortments", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "blueprints",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    link = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slide = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_blueprints", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "builds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    link = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slide = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_builds", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "connection_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_connection_types", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "equipments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slide_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_equipments", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "exports",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_exports", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "instruction_group_positions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_instruction_group_positions", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "instruction_positions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    small_picture_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    picture2_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    picture3_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reference3_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reference2_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    model_xls_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    formula_xls_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_instruction_positions", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "material_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_material_groups", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "material_subgroups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_material_subgroups", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mark = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_materials", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "measurement_unit_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_measurement_unit_groups", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "measurement_units",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    short_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_measurement_units", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    link = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slide = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    short_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_models", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameter_group",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameter_group", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "prefixes",
                columns: table => new
                {
                    prefix_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    prefix_number = table.Column<int>(type: "int", nullable: true),
                    prefix_text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_prefixes", x => x.prefix_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    position = table.Column<int>(type: "int", nullable: false),
                    ready_percentage = table.Column<float>(type: "float", nullable: true),
                    project_registration_date = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_projects", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "assortment_assortment_roll",
                columns: table => new
                {
                    assortment_rolls_id = table.Column<int>(type: "int", nullable: false),
                    assortments_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assortment_assortment_roll", x => new { x.assortment_rolls_id, x.assortments_id });
                    table.ForeignKey(
                        name: "fk_assortment_assortment_roll_assortment_rolls_assortment_rolls_~",
                        column: x => x.assortment_rolls_id,
                        principalTable: "assortment_rolls",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_assortment_assortment_roll_assortments_assortments_id",
                        column: x => x.assortments_id,
                        principalTable: "assortments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "technology_processes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    principles = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true),
                    equipment_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_technology_processes", x => x.id);
                    table.ForeignKey(
                        name: "fk_technology_processes_equipments_equipment_id",
                        column: x => x.equipment_id,
                        principalTable: "equipments",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    short_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    code_for_connection = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    connection_type_id = table.Column<int>(type: "int", nullable: true),
                    export_id = table.Column<int>(type: "int", nullable: true),
                    type_date = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hidden = table.Column<int>(type: "int", nullable: true),
                    initialize = table.Column<int>(type: "int", nullable: true),
                    formula = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameters", x => x.id);
                    table.ForeignKey(
                        name: "fk_parameters_connection_types_connection_type_id",
                        column: x => x.connection_type_id,
                        principalTable: "connection_types",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_parameters_exports_export_id",
                        column: x => x.export_id,
                        principalTable: "exports",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "instruction_group_position_instruction_position",
                columns: table => new
                {
                    instruction_group_positions_id = table.Column<int>(type: "int", nullable: false),
                    instruction_positions_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_instruction_group_position_instruction_position", x => new { x.instruction_group_positions_id, x.instruction_positions_id });
                    table.ForeignKey(
                        name: "fk_instruction_group_position_instruction_position_instruction_g~",
                        column: x => x.instruction_group_positions_id,
                        principalTable: "instruction_group_positions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_instruction_group_position_instruction_position_instruction_p~",
                        column: x => x.instruction_positions_id,
                        principalTable: "instruction_positions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "material_group_material_subgroup",
                columns: table => new
                {
                    material_groups_id = table.Column<int>(type: "int", nullable: false),
                    material_subgroups_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_material_group_material_subgroup", x => new { x.material_groups_id, x.material_subgroups_id });
                    table.ForeignKey(
                        name: "fk_material_group_material_subgroup_material_groups_material_gro~",
                        column: x => x.material_groups_id,
                        principalTable: "material_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_material_group_material_subgroup_material_subgroups_material_~",
                        column: x => x.material_subgroups_id,
                        principalTable: "material_subgroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "assortment_material",
                columns: table => new
                {
                    assortments_id = table.Column<int>(type: "int", nullable: false),
                    materials_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assortment_material", x => new { x.assortments_id, x.materials_id });
                    table.ForeignKey(
                        name: "fk_assortment_material_assortments_assortments_id",
                        column: x => x.assortments_id,
                        principalTable: "assortments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_assortment_material_materials_materials_id",
                        column: x => x.materials_id,
                        principalTable: "materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "equipment_material",
                columns: table => new
                {
                    equipments_id = table.Column<int>(type: "int", nullable: false),
                    materials_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_equipment_material", x => new { x.equipments_id, x.materials_id });
                    table.ForeignKey(
                        name: "fk_equipment_material_equipments_equipments_id",
                        column: x => x.equipments_id,
                        principalTable: "equipments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_equipment_material_materials_materials_id",
                        column: x => x.materials_id,
                        principalTable: "materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "material_material_subgroup",
                columns: table => new
                {
                    material_subgroups_id = table.Column<int>(type: "int", nullable: false),
                    materials_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_material_material_subgroup", x => new { x.material_subgroups_id, x.materials_id });
                    table.ForeignKey(
                        name: "fk_material_material_subgroup_material_subgroups_material_subgro~",
                        column: x => x.material_subgroups_id,
                        principalTable: "material_subgroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_material_material_subgroup_materials_materials_id",
                        column: x => x.materials_id,
                        principalTable: "materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "measurement_unit_measurement_unit_group",
                columns: table => new
                {
                    measurement_unit_groups_id = table.Column<int>(type: "int", nullable: false),
                    measurement_units_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_measurement_unit_measurement_unit_group", x => new { x.measurement_unit_groups_id, x.measurement_units_id });
                    table.ForeignKey(
                        name: "fk_measurement_unit_measurement_unit_group_measurement_unit_group~",
                        column: x => x.measurement_unit_groups_id,
                        principalTable: "measurement_unit_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_measurement_unit_measurement_unit_group_measurement_units_mea~",
                        column: x => x.measurement_units_id,
                        principalTable: "measurement_units",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "constructions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    project_id = table.Column<int>(type: "int", nullable: false),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    small_picture_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    picture2_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    picture2_dcount = table.Column<int>(type: "int", nullable: true),
                    picture3_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    small_reference_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reference3_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reference2_dfile_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    model_xls_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    formula_xls_file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    position_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_constructions", x => x.id);
                    table.ForeignKey(
                        name: "fk_constructions_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "project_elements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    short_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    position = table.Column<int>(type: "int", nullable: false),
                    is_editable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    blueprint_id = table.Column<int>(type: "int", nullable: false),
                    model_id = table.Column<int>(type: "int", nullable: false),
                    build_id = table.Column<int>(type: "int", nullable: false),
                    project_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_project_elements", x => x.id);
                    table.ForeignKey(
                        name: "fk_project_elements_blueprints_blueprint_id",
                        column: x => x.blueprint_id,
                        principalTable: "blueprints",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_elements_builds_build_id",
                        column: x => x.build_id,
                        principalTable: "builds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_elements_models_model_id",
                        column: x => x.model_id,
                        principalTable: "models",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_elements_projects_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "prefix_technology_process",
                columns: table => new
                {
                    prefixes_prefix_id = table.Column<int>(type: "int", nullable: false),
                    technology_processes_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_prefix_technology_process", x => new { x.prefixes_prefix_id, x.technology_processes_id });
                    table.ForeignKey(
                        name: "fk_prefix_technology_process_prefixes_prefixes_prefix_id",
                        column: x => x.prefixes_prefix_id,
                        principalTable: "prefixes",
                        principalColumn: "prefix_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_prefix_technology_process_technology_processes_technology_pro~",
                        column: x => x.technology_processes_id,
                        principalTable: "technology_processes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameter_parameter_group",
                columns: table => new
                {
                    parameter_group_id = table.Column<int>(type: "int", nullable: false),
                    parameters_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameter_parameter_group", x => new { x.parameter_group_id, x.parameters_id });
                    table.ForeignKey(
                        name: "fk_parameter_parameter_group_parameter_group_parameter_group_id",
                        column: x => x.parameter_group_id,
                        principalTable: "parameter_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_parameter_parameter_group_parameters_parameters_id",
                        column: x => x.parameters_id,
                        principalTable: "parameters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameter_values",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    parameter_id = table.Column<int>(type: "int", nullable: false),
                    parameter_string_value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unit_short_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameter_values", x => x.id);
                    table.ForeignKey(
                        name: "fk_parameter_values_parameters_parameter_id",
                        column: x => x.parameter_id,
                        principalTable: "parameters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "technologies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    principles = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ready_percentage = table.Column<float>(type: "float", nullable: true),
                    parameter_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_technologies", x => x.id);
                    table.ForeignKey(
                        name: "fk_technologies_parameters_parameter_id",
                        column: x => x.parameter_id,
                        principalTable: "parameters",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "analysis_type_construction",
                columns: table => new
                {
                    analysis_types_id = table.Column<int>(type: "int", nullable: false),
                    constructions_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_analysis_type_construction", x => new { x.analysis_types_id, x.constructions_id });
                    table.ForeignKey(
                        name: "fk_analysis_type_construction_analysis_types_analysis_types_id",
                        column: x => x.analysis_types_id,
                        principalTable: "analysis_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_analysis_type_construction_constructions_constructions_id",
                        column: x => x.constructions_id,
                        principalTable: "constructions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "construction_documents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    construction_id = table.Column<int>(type: "int", nullable: false),
                    sequence_number = table.Column<int>(type: "int", nullable: false),
                    symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_construction_documents", x => x.id);
                    table.ForeignKey(
                        name: "fk_construction_documents_constructions_construction_id",
                        column: x => x.construction_id,
                        principalTable: "constructions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "construction_incidences",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    construction_id = table.Column<int>(type: "int", nullable: false),
                    sequence = table.Column<int>(type: "int", nullable: true),
                    applicability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_construction_incidences", x => x.id);
                    table.ForeignKey(
                        name: "fk_construction_incidences_constructions_construction_id",
                        column: x => x.construction_id,
                        principalTable: "constructions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "construction_instruction_position",
                columns: table => new
                {
                    constructions_id = table.Column<int>(type: "int", nullable: false),
                    instruction_positions_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_construction_instruction_position", x => new { x.constructions_id, x.instruction_positions_id });
                    table.ForeignKey(
                        name: "fk_construction_instruction_position_constructions_construction~",
                        column: x => x.constructions_id,
                        principalTable: "constructions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_construction_instruction_position_instruction_positions_instr~",
                        column: x => x.instruction_positions_id,
                        principalTable: "instruction_positions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "assortment_parameter_value",
                columns: table => new
                {
                    assortments_id = table.Column<int>(type: "int", nullable: false),
                    parameter_values_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assortment_parameter_value", x => new { x.assortments_id, x.parameter_values_id });
                    table.ForeignKey(
                        name: "fk_assortment_parameter_value_assortments_assortments_id",
                        column: x => x.assortments_id,
                        principalTable: "assortments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_assortment_parameter_value_parameter_values_parameter_values_~",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "construction_parameter_value",
                columns: table => new
                {
                    constructions_id = table.Column<int>(type: "int", nullable: false),
                    parameter_values_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_construction_parameter_value", x => new { x.constructions_id, x.parameter_values_id });
                    table.ForeignKey(
                        name: "fk_construction_parameter_value_constructions_constructions_id",
                        column: x => x.constructions_id,
                        principalTable: "constructions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_construction_parameter_value_parameter_values_parameter_value~",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "equipment_parameter_value",
                columns: table => new
                {
                    equipments_id = table.Column<int>(type: "int", nullable: false),
                    parameter_values_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_equipment_parameter_value", x => new { x.equipments_id, x.parameter_values_id });
                    table.ForeignKey(
                        name: "fk_equipment_parameter_value_equipments_equipments_id",
                        column: x => x.equipments_id,
                        principalTable: "equipments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_equipment_parameter_value_parameter_values_parameter_values_id",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "material_parameter_value",
                columns: table => new
                {
                    materials_id = table.Column<int>(type: "int", nullable: false),
                    parameter_values_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_material_parameter_value", x => new { x.materials_id, x.parameter_values_id });
                    table.ForeignKey(
                        name: "fk_material_parameter_value_materials_materials_id",
                        column: x => x.materials_id,
                        principalTable: "materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_material_parameter_value_parameter_values_parameter_values_id",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameter_value_prefix",
                columns: table => new
                {
                    parameter_values_id = table.Column<int>(type: "int", nullable: false),
                    prefixes_prefix_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameter_value_prefix", x => new { x.parameter_values_id, x.prefixes_prefix_id });
                    table.ForeignKey(
                        name: "fk_parameter_value_prefix_parameter_values_parameter_values_id",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_parameter_value_prefix_prefixes_prefixes_prefix_id",
                        column: x => x.prefixes_prefix_id,
                        principalTable: "prefixes",
                        principalColumn: "prefix_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameter_value_project",
                columns: table => new
                {
                    parameter_values_id = table.Column<int>(type: "int", nullable: false),
                    projects_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameter_value_project", x => new { x.parameter_values_id, x.projects_id });
                    table.ForeignKey(
                        name: "fk_parameter_value_project_parameter_values_parameter_values_id",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_parameter_value_project_projects_projects_id",
                        column: x => x.projects_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameter_value_technology_process",
                columns: table => new
                {
                    parameter_values_id = table.Column<int>(type: "int", nullable: false),
                    technology_processes_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameter_value_technology_process", x => new { x.parameter_values_id, x.technology_processes_id });
                    table.ForeignKey(
                        name: "fk_parameter_value_technology_process_parameter_values_parameter~",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_parameter_value_technology_process_technology_processes_techn~",
                        column: x => x.technology_processes_id,
                        principalTable: "technology_processes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "parameter_value_technology",
                columns: table => new
                {
                    parameter_values_id = table.Column<int>(type: "int", nullable: false),
                    technologies_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_parameter_value_technology", x => new { x.parameter_values_id, x.technologies_id });
                    table.ForeignKey(
                        name: "fk_parameter_value_technology_parameter_values_parameter_values_~",
                        column: x => x.parameter_values_id,
                        principalTable: "parameter_values",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_parameter_value_technology_technologies_technologies_id",
                        column: x => x.technologies_id,
                        principalTable: "technologies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "technology_technology_process",
                columns: table => new
                {
                    technologies_id = table.Column<int>(type: "int", nullable: false),
                    technology_processes_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_technology_technology_process", x => new { x.technologies_id, x.technology_processes_id });
                    table.ForeignKey(
                        name: "fk_technology_technology_process_technologies_technologies_id",
                        column: x => x.technologies_id,
                        principalTable: "technologies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_technology_technology_process_technology_processes_technology~",
                        column: x => x.technology_processes_id,
                        principalTable: "technology_processes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_analysis_type_construction_constructions_id",
                table: "analysis_type_construction",
                column: "constructions_id");

            migrationBuilder.CreateIndex(
                name: "ix_assortment_assortment_roll_assortments_id",
                table: "assortment_assortment_roll",
                column: "assortments_id");

            migrationBuilder.CreateIndex(
                name: "ix_assortment_material_materials_id",
                table: "assortment_material",
                column: "materials_id");

            migrationBuilder.CreateIndex(
                name: "ix_assortment_parameter_value_parameter_values_id",
                table: "assortment_parameter_value",
                column: "parameter_values_id");

            migrationBuilder.CreateIndex(
                name: "ix_construction_documents_construction_id",
                table: "construction_documents",
                column: "construction_id");

            migrationBuilder.CreateIndex(
                name: "ix_construction_incidences_construction_id",
                table: "construction_incidences",
                column: "construction_id");

            migrationBuilder.CreateIndex(
                name: "ix_construction_instruction_position_instruction_positions_id",
                table: "construction_instruction_position",
                column: "instruction_positions_id");

            migrationBuilder.CreateIndex(
                name: "ix_construction_parameter_value_parameter_values_id",
                table: "construction_parameter_value",
                column: "parameter_values_id");

            migrationBuilder.CreateIndex(
                name: "ix_constructions_project_id",
                table: "constructions",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "ix_equipment_material_materials_id",
                table: "equipment_material",
                column: "materials_id");

            migrationBuilder.CreateIndex(
                name: "ix_equipment_parameter_value_parameter_values_id",
                table: "equipment_parameter_value",
                column: "parameter_values_id");

            migrationBuilder.CreateIndex(
                name: "ix_instruction_group_position_instruction_position_instruction_~",
                table: "instruction_group_position_instruction_position",
                column: "instruction_positions_id");

            migrationBuilder.CreateIndex(
                name: "ix_material_group_material_subgroup_material_subgroups_id",
                table: "material_group_material_subgroup",
                column: "material_subgroups_id");

            migrationBuilder.CreateIndex(
                name: "ix_material_material_subgroup_materials_id",
                table: "material_material_subgroup",
                column: "materials_id");

            migrationBuilder.CreateIndex(
                name: "ix_material_parameter_value_parameter_values_id",
                table: "material_parameter_value",
                column: "parameter_values_id");

            migrationBuilder.CreateIndex(
                name: "ix_measurement_unit_measurement_unit_group_measurement_units_id",
                table: "measurement_unit_measurement_unit_group",
                column: "measurement_units_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameter_parameter_group_parameters_id",
                table: "parameter_parameter_group",
                column: "parameters_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameter_value_prefix_prefixes_prefix_id",
                table: "parameter_value_prefix",
                column: "prefixes_prefix_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameter_value_project_projects_id",
                table: "parameter_value_project",
                column: "projects_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameter_value_technology_technologies_id",
                table: "parameter_value_technology",
                column: "technologies_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameter_value_technology_process_technology_processes_id",
                table: "parameter_value_technology_process",
                column: "technology_processes_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameter_values_parameter_id",
                table: "parameter_values",
                column: "parameter_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameters_connection_type_id",
                table: "parameters",
                column: "connection_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_parameters_export_id",
                table: "parameters",
                column: "export_id");

            migrationBuilder.CreateIndex(
                name: "ix_prefix_technology_process_technology_processes_id",
                table: "prefix_technology_process",
                column: "technology_processes_id");

            migrationBuilder.CreateIndex(
                name: "ix_project_elements_blueprint_id",
                table: "project_elements",
                column: "blueprint_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_project_elements_build_id",
                table: "project_elements",
                column: "build_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_project_elements_model_id",
                table: "project_elements",
                column: "model_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_project_elements_project_id",
                table: "project_elements",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "ix_technologies_parameter_id",
                table: "technologies",
                column: "parameter_id");

            migrationBuilder.CreateIndex(
                name: "ix_technology_processes_equipment_id",
                table: "technology_processes",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "ix_technology_technology_process_technology_processes_id",
                table: "technology_technology_process",
                column: "technology_processes_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "analysis_type_construction");

            migrationBuilder.DropTable(
                name: "assortment_assortment_roll");

            migrationBuilder.DropTable(
                name: "assortment_material");

            migrationBuilder.DropTable(
                name: "assortment_parameter_value");

            migrationBuilder.DropTable(
                name: "construction_documents");

            migrationBuilder.DropTable(
                name: "construction_incidences");

            migrationBuilder.DropTable(
                name: "construction_instruction_position");

            migrationBuilder.DropTable(
                name: "construction_parameter_value");

            migrationBuilder.DropTable(
                name: "equipment_material");

            migrationBuilder.DropTable(
                name: "equipment_parameter_value");

            migrationBuilder.DropTable(
                name: "instruction_group_position_instruction_position");

            migrationBuilder.DropTable(
                name: "material_group_material_subgroup");

            migrationBuilder.DropTable(
                name: "material_material_subgroup");

            migrationBuilder.DropTable(
                name: "material_parameter_value");

            migrationBuilder.DropTable(
                name: "measurement_unit_measurement_unit_group");

            migrationBuilder.DropTable(
                name: "parameter_parameter_group");

            migrationBuilder.DropTable(
                name: "parameter_value_prefix");

            migrationBuilder.DropTable(
                name: "parameter_value_project");

            migrationBuilder.DropTable(
                name: "parameter_value_technology");

            migrationBuilder.DropTable(
                name: "parameter_value_technology_process");

            migrationBuilder.DropTable(
                name: "prefix_technology_process");

            migrationBuilder.DropTable(
                name: "project_elements");

            migrationBuilder.DropTable(
                name: "technology_technology_process");

            migrationBuilder.DropTable(
                name: "analysis_types");

            migrationBuilder.DropTable(
                name: "assortment_rolls");

            migrationBuilder.DropTable(
                name: "assortments");

            migrationBuilder.DropTable(
                name: "constructions");

            migrationBuilder.DropTable(
                name: "instruction_group_positions");

            migrationBuilder.DropTable(
                name: "instruction_positions");

            migrationBuilder.DropTable(
                name: "material_groups");

            migrationBuilder.DropTable(
                name: "material_subgroups");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropTable(
                name: "measurement_unit_groups");

            migrationBuilder.DropTable(
                name: "measurement_units");

            migrationBuilder.DropTable(
                name: "parameter_group");

            migrationBuilder.DropTable(
                name: "parameter_values");

            migrationBuilder.DropTable(
                name: "prefixes");

            migrationBuilder.DropTable(
                name: "blueprints");

            migrationBuilder.DropTable(
                name: "builds");

            migrationBuilder.DropTable(
                name: "models");

            migrationBuilder.DropTable(
                name: "technologies");

            migrationBuilder.DropTable(
                name: "technology_processes");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "parameters");

            migrationBuilder.DropTable(
                name: "equipments");

            migrationBuilder.DropTable(
                name: "connection_types");

            migrationBuilder.DropTable(
                name: "exports");
        }
    }
}
