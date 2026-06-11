using Microsoft.Data.SqlClient;

string connectionString = "Data Source=DESKTOP-N9RRF7S;Initial Catalog=accadmyDb;Integrated Security=True;TrustServerCertificate=True";
string createTableSql = @"
IF OBJECT_ID('dbo.ssTable', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.ssTable
    (
        ssId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        stdRegisNo VARCHAR(50) NOT NULL UNIQUE,
        student_contact VARCHAR(20) NULL,
        whatsapp_number VARCHAR(20) NULL,
        updated_by VARCHAR(100) NULL,
        change_reason VARCHAR(500) NULL,
        update_date DATETIME NULL,
        created_at DATETIME NULL CONSTRAINT DF_ssTable_created_at DEFAULT GETDATE(),
        updated_at DATETIME NULL,
        CONSTRAINT FK_ssTable_StudentTb
            FOREIGN KEY (stdRegisNo) REFERENCES dbo.StudentTb(stdRegisNo)
    );
END;

IF COL_LENGTH('dbo.ssTable', 'student_contact') IS NULL
    ALTER TABLE dbo.ssTable ADD student_contact VARCHAR(20) NULL;

IF COL_LENGTH('dbo.ssTable', 'whatsapp_number') IS NULL
    ALTER TABLE dbo.ssTable ADD whatsapp_number VARCHAR(20) NULL;

IF COL_LENGTH('dbo.ssTable', 'updated_by') IS NULL
    ALTER TABLE dbo.ssTable ADD updated_by VARCHAR(100) NULL;

IF COL_LENGTH('dbo.ssTable', 'change_reason') IS NULL
    ALTER TABLE dbo.ssTable ADD change_reason VARCHAR(500) NULL;

IF COL_LENGTH('dbo.ssTable', 'update_date') IS NULL
    ALTER TABLE dbo.ssTable ADD update_date DATETIME NULL;

IF COL_LENGTH('dbo.ssTable', 'created_at') IS NULL
    ALTER TABLE dbo.ssTable ADD created_at DATETIME NULL CONSTRAINT DF_ssTable_created_at DEFAULT GETDATE();

IF COL_LENGTH('dbo.ssTable', 'updated_at') IS NULL
    ALTER TABLE dbo.ssTable ADD updated_at DATETIME NULL;";

string inspectSql = @"
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ssTable'
ORDER BY ORDINAL_POSITION;";

using SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

using (SqlCommand command = new SqlCommand(createTableSql, connection))
{
    command.ExecuteNonQuery();
}

using (SqlCommand command = new SqlCommand(inspectSql, connection))
using (SqlDataReader reader = command.ExecuteReader())
{
    while (reader.Read())
        Console.WriteLine($"{reader["COLUMN_NAME"]}|{reader["DATA_TYPE"]}|{reader["IS_NULLABLE"]}");
}
