using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamEduConsultancy.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "sqNumeric",
                incrementBy: 10,
                minValue: 0L,
                maxValue: 500L,
                cyclic: true);

            migrationBuilder.CreateTable(
                name: "applicationStatus",
                columns: table => new
                {
                    applicationStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicationStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__applicat__1D6A3E7655F9E822", x => x.applicationStatusId);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    countryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__country__D32076BC7C66F7B8", x => x.countryId);
                });

            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__course__2AA84FD12A57843A", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "designation",
                columns: table => new
                {
                    designationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    designationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__designat__197CE32AE3606AB9", x => x.designationId);
                });

            migrationBuilder.CreateTable(
                name: "document",
                columns: table => new
                {
                    documentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__document__EFAAAD855AACDC45", x => x.documentId);
                });

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    genderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__gender__306E22409F5F05F1", x => x.genderId);
                });

            migrationBuilder.CreateTable(
                name: "intake",
                columns: table => new
                {
                    intakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    intakeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    intakeDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__intake__0F690089EE7FEDDE", x => x.intakeId);
                });

            migrationBuilder.CreateTable(
                name: "scholarship",
                columns: table => new
                {
                    scholarshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scholarshipName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__scholars__B8F36A2244C7EEEE", x => x.scholarshipId);
                });

            migrationBuilder.CreateTable(
                name: "subject",
                columns: table => new
                {
                    subjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__subject__ACF9A760BCEA0091", x => x.subjectId);
                });

            migrationBuilder.CreateTable(
                name: "visaReason",
                columns: table => new
                {
                    visaReasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visaReasonName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    deletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__visaReas__6CE74CD39603920F", x => x.visaReasonId);
                });

            migrationBuilder.CreateTable(
                name: "university",
                columns: table => new
                {
                    universityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    universityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__universi__F5A408802D1C7984", x => x.universityId);
                    table.ForeignKey(
                        name: "FK__universit__count__4222D4EF",
                        column: x => x.countryId,
                        principalTable: "country",
                        principalColumn: "countryId");
                });

            migrationBuilder.CreateTable(
                name: "counselor",
                columns: table => new
                {
                    counselorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    counselorFName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    counselorLName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    designationId = table.Column<int>(type: "int", nullable: false),
                    counselorFullName = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__counselo__237F0883D27DC7BB", x => x.counselorId);
                    table.ForeignKey(
                        name: "FK__counselor__desig__3C69FB99",
                        column: x => x.designationId,
                        principalTable: "designation",
                        principalColumn: "designationId");
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentFName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    studentLName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nid = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    email = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    phone = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    passportId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    passExDate = table.Column<DateOnly>(type: "date", nullable: true),
                    lastStudyLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastMarks = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    genderId = table.Column<int>(type: "int", nullable: false),
                    dateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    deletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__student__4D11D63C36550460", x => x.studentId);
                    table.ForeignKey(
                        name: "FK__student__genderI__5070F446",
                        column: x => x.genderId,
                        principalTable: "gender",
                        principalColumn: "genderId");
                });

            migrationBuilder.CreateTable(
                name: "universityCourse",
                columns: table => new
                {
                    universityCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    universityId = table.Column<int>(type: "int", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    universityCourseFee = table.Column<decimal>(type: "money", nullable: true, defaultValue: 0.00m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__universi__F6A76FC811FC78AE", x => x.universityCourseId);
                    table.ForeignKey(
                        name: "FK__universit__cours__6383C8BA",
                        column: x => x.courseId,
                        principalTable: "course",
                        principalColumn: "courseId");
                    table.ForeignKey(
                        name: "FK__universit__unive__628FA481",
                        column: x => x.universityId,
                        principalTable: "university",
                        principalColumn: "universityId");
                });

            migrationBuilder.CreateTable(
                name: "application",
                columns: table => new
                {
                    applicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    intakeId = table.Column<int>(type: "int", nullable: false),
                    universityId = table.Column<int>(type: "int", nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    applicationStatusId = table.Column<int>(type: "int", nullable: false),
                    applicationDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__applicat__79FDB1CFE2F65E13", x => x.applicationId);
                    table.ForeignKey(
                        name: "FK__applicati__appli__59FA5E80",
                        column: x => x.applicationStatusId,
                        principalTable: "applicationStatus",
                        principalColumn: "applicationStatusId");
                    table.ForeignKey(
                        name: "FK__applicati__count__5629CD9C",
                        column: x => x.countryId,
                        principalTable: "country",
                        principalColumn: "countryId");
                    table.ForeignKey(
                        name: "FK__applicati__intak__571DF1D5",
                        column: x => x.intakeId,
                        principalTable: "intake",
                        principalColumn: "intakeId");
                    table.ForeignKey(
                        name: "FK__applicati__stude__5535A963",
                        column: x => x.studentId,
                        principalTable: "student",
                        principalColumn: "studentId");
                    table.ForeignKey(
                        name: "FK__applicati__subje__59063A47",
                        column: x => x.subjectId,
                        principalTable: "subject",
                        principalColumn: "subjectId");
                    table.ForeignKey(
                        name: "FK__applicati__unive__5812160E",
                        column: x => x.universityId,
                        principalTable: "university",
                        principalColumn: "universityId");
                });

            migrationBuilder.CreateTable(
                name: "counselorStudent",
                columns: table => new
                {
                    counselorStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    counselorId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    assignedDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__counselo__B1BC2371854703CD", x => x.counselorStudentId);
                    table.ForeignKey(
                        name: "FK__counselor__couns__6D0D32F4",
                        column: x => x.counselorId,
                        principalTable: "counselor",
                        principalColumn: "counselorId");
                    table.ForeignKey(
                        name: "FK__counselor__stude__6E01572D",
                        column: x => x.studentId,
                        principalTable: "student",
                        principalColumn: "studentId");
                });

            migrationBuilder.CreateTable(
                name: "studentCourse",
                columns: table => new
                {
                    studentCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    grade = table.Column<decimal>(type: "decimal(3,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__studentC__5A4F4B33E4DCF593", x => x.studentCourseId);
                    table.ForeignKey(
                        name: "FK__studentCo__cours__68487DD7",
                        column: x => x.courseId,
                        principalTable: "course",
                        principalColumn: "courseId");
                    table.ForeignKey(
                        name: "FK__studentCo__stude__6754599E",
                        column: x => x.studentId,
                        principalTable: "student",
                        principalColumn: "studentId");
                });

            migrationBuilder.CreateTable(
                name: "studentDocument",
                columns: table => new
                {
                    studentDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    documentId = table.Column<int>(type: "int", nullable: false),
                    submissionDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    documentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__studentD__76E55BDC58375288", x => x.studentDocumentId);
                    table.ForeignKey(
                        name: "FK__studentDo__docum__7D439ABD",
                        column: x => x.documentId,
                        principalTable: "document",
                        principalColumn: "documentId");
                    table.ForeignKey(
                        name: "FK__studentDo__stude__7C4F7684",
                        column: x => x.studentId,
                        principalTable: "student",
                        principalColumn: "studentId");
                });

            migrationBuilder.CreateTable(
                name: "studentScholarship",
                columns: table => new
                {
                    studentScholarshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    scholarshipId = table.Column<int>(type: "int", nullable: false),
                    awardDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__studentS__CBBEA6A77979D850", x => x.studentScholarshipId);
                    table.ForeignKey(
                        name: "FK__studentSc__schol__06CD04F7",
                        column: x => x.scholarshipId,
                        principalTable: "scholarship",
                        principalColumn: "scholarshipId");
                    table.ForeignKey(
                        name: "FK__studentSc__stude__05D8E0BE",
                        column: x => x.studentId,
                        principalTable: "student",
                        principalColumn: "studentId");
                });

            migrationBuilder.CreateTable(
                name: "studentUpdateLog",
                columns: table => new
                {
                    logId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    updatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__studentU__7839F64D2F710B0A", x => x.logId);
                    table.ForeignKey(
                        name: "FK__studentUp__stude__17F790F9",
                        column: x => x.studentId,
                        principalTable: "student",
                        principalColumn: "studentId");
                });

            migrationBuilder.CreateTable(
                name: "applicationReason",
                columns: table => new
                {
                    applicationReasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicationId = table.Column<int>(type: "int", nullable: false),
                    visaReasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__applicat__49672E9BA9038270", x => x.applicationReasonId);
                    table.ForeignKey(
                        name: "FK__applicati__appli__74AE54BC",
                        column: x => x.applicationId,
                        principalTable: "application",
                        principalColumn: "applicationId");
                    table.ForeignKey(
                        name: "FK__applicati__visaR__75A278F5",
                        column: x => x.visaReasonId,
                        principalTable: "visaReason",
                        principalColumn: "visaReasonId");
                });

            migrationBuilder.CreateTable(
                name: "applicationUpdateLog",
                columns: table => new
                {
                    logId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicationId = table.Column<int>(type: "int", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    updatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__applicat__7839F64D567396A7", x => x.logId);
                    table.ForeignKey(
                        name: "FK__applicati__appli__1DB06A4F",
                        column: x => x.applicationId,
                        principalTable: "application",
                        principalColumn: "applicationId");
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    paymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicationId = table.Column<int>(type: "int", nullable: false),
                    paymentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    paymentAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    paymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__payment__A0D9EFC673C01254", x => x.paymentId);
                    table.ForeignKey(
                        name: "FK__payment__applica__5CD6CB2B",
                        column: x => x.applicationId,
                        principalTable: "application",
                        principalColumn: "applicationId");
                });

            migrationBuilder.CreateTable(
                name: "visaApplication",
                columns: table => new
                {
                    visaApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicationId = table.Column<int>(type: "int", nullable: false),
                    visaType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    submissionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    decisionDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__visaAppl__82522E1C9D232C9F", x => x.visaApplicationId);
                    table.ForeignKey(
                        name: "FK__visaAppli__appli__00200768",
                        column: x => x.applicationId,
                        principalTable: "application",
                        principalColumn: "applicationId");
                });

            migrationBuilder.CreateIndex(
                name: "idx_applicationDate",
                table: "application",
                column: "applicationDate");

            migrationBuilder.CreateIndex(
                name: "idx_applicationId",
                table: "application",
                column: "applicationId");

            migrationBuilder.CreateIndex(
                name: "IX_application_applicationStatusId",
                table: "application",
                column: "applicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_application_countryId",
                table: "application",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_application_intakeId",
                table: "application",
                column: "intakeId");

            migrationBuilder.CreateIndex(
                name: "IX_application_subjectId",
                table: "application",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_application_universityId",
                table: "application",
                column: "universityId");

            migrationBuilder.CreateIndex(
                name: "UQ_studentApplication",
                table: "application",
                columns: new[] { "studentId", "universityId", "subjectId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_applicationReason_applicationId",
                table: "applicationReason",
                column: "applicationId");

            migrationBuilder.CreateIndex(
                name: "IX_applicationReason_visaReasonId",
                table: "applicationReason",
                column: "visaReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_applicationUpdateLog_applicationId",
                table: "applicationUpdateLog",
                column: "applicationId");

            migrationBuilder.CreateIndex(
                name: "IX_counselor_designationId",
                table: "counselor",
                column: "designationId");

            migrationBuilder.CreateIndex(
                name: "UQ_counselorName",
                table: "counselor",
                columns: new[] { "counselorFName", "counselorLName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_counselorStudent_studentId",
                table: "counselorStudent",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "UQ_counselorStudent",
                table: "counselorStudent",
                columns: new[] { "counselorId", "studentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_countryId",
                table: "country",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_applicationId",
                table: "payment",
                column: "applicationId");

            migrationBuilder.CreateIndex(
                name: "idx_studentID",
                table: "student",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_student_genderId",
                table: "student",
                column: "genderId");

            migrationBuilder.CreateIndex(
                name: "UQ__student__AB6E6164AC5C8903",
                table: "student",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__student__B43B145FB7617FDD",
                table: "student",
                column: "phone",
                unique: true,
                filter: "[phone] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__student__DF97D0F438CBAD7A",
                table: "student",
                column: "nid",
                unique: true,
                filter: "[nid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourse_courseId",
                table: "studentCourse",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "UQ_studentCourse",
                table: "studentCourse",
                columns: new[] { "studentId", "courseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentDocument_documentId",
                table: "studentDocument",
                column: "documentId");

            migrationBuilder.CreateIndex(
                name: "UQ_studentDocument",
                table: "studentDocument",
                columns: new[] { "studentId", "documentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentScholarship_scholarshipId",
                table: "studentScholarship",
                column: "scholarshipId");

            migrationBuilder.CreateIndex(
                name: "UQ_studentScholarship",
                table: "studentScholarship",
                columns: new[] { "studentId", "scholarshipId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentUpdateLog_studentId",
                table: "studentUpdateLog",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_university_countryId",
                table: "university",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "UQ_university",
                table: "university",
                columns: new[] { "universityName", "countryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_universityCourse_courseId",
                table: "universityCourse",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "UQ_universityCourse",
                table: "universityCourse",
                columns: new[] { "universityId", "courseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visaApplication_applicationId",
                table: "visaApplication",
                column: "applicationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicationReason");

            migrationBuilder.DropTable(
                name: "applicationUpdateLog");

            migrationBuilder.DropTable(
                name: "counselorStudent");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "studentCourse");

            migrationBuilder.DropTable(
                name: "studentDocument");

            migrationBuilder.DropTable(
                name: "studentScholarship");

            migrationBuilder.DropTable(
                name: "studentUpdateLog");

            migrationBuilder.DropTable(
                name: "universityCourse");

            migrationBuilder.DropTable(
                name: "visaApplication");

            migrationBuilder.DropTable(
                name: "visaReason");

            migrationBuilder.DropTable(
                name: "counselor");

            migrationBuilder.DropTable(
                name: "document");

            migrationBuilder.DropTable(
                name: "scholarship");

            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "application");

            migrationBuilder.DropTable(
                name: "designation");

            migrationBuilder.DropTable(
                name: "applicationStatus");

            migrationBuilder.DropTable(
                name: "intake");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "subject");

            migrationBuilder.DropTable(
                name: "university");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropSequence(
                name: "sqNumeric");
        }
    }
}
