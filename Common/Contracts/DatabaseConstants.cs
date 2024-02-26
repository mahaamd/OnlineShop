using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts
{
    public static class DatabaseConstants
    {
        public static class GodAdminUsers
        {
            // Define constants for user IDs
            public const string IzadniaUserId = "2";
            public const string BahmanyarUserId = "1";

            // Define constants for user first names
            public const string IzadniaFirstName = "Izadnia";
            public const string BahmanyarFirstName = "Bahmanyar";

            // Define constants for user last names
            public const string IzadniaLastName = "IzadniaLastName";
            public const string BahmanyarLastName = "BahmanyarLastName";

            // Define constants for user national IDs
            public const string IzadniaNationalId = "123456789";
            public const string BahmanyarNationalId = "987654321";

            // Define constants for user names
            public const string IzadniaUserName = "izadnia";
            public const string BahmanyarUserName = "bahmanyar";

            // Define constants for user passwords
            // Note: Storing password hashes as integers is not secure; this is just for demonstration purposes.
            public const int IzadniaPassword = 123456;
            public const int BahmanyarPassword = 654321;

            // Define constants for user cell phones
            public const string IzadniaCellphone = "1234567890";
            public const string BahmanyarCellphone = "9876543210";
        }

        public static class CheckConstraints
        {
            // Define constants for check constraints titles and expressions
            public const string CellphoneOnlyNumericalTitle = "CK_CellphoneOnlyNumerical";
            public const string CellphoneOnlyNumerical = "[CellPhone] LIKE '[0-9]%'";

            public const string NationalIdOnlyNumericalTitle = "CK_NationalIdOnlyNumerical";
            public const string NationalIdOnlyNumerical = "[NationalId] LIKE '[0-9]%'";

            public const string NationalIdCharacterNumberTitle = "CK_NationalIdCharacterNumber";
            public const string NationalIdCharacterNumber = "LEN([NationalId]) = 9";
        }

        public static class DefaultRoles
        {
            public const string GodAdminId = "10";
            public const string GodAdminName = "mohammad";
            public const string GodAdminNormalizedName = "ma";
            public const string GodAdminConcurrencyStamp = "mohammad_concurrency_stamp";

            public const string AdminId = "20";
            public const string AdminName = "Admin";
            public const string AdminNormalizedName = "ADMIN";
            public const string AdminConcurrencyStamp = "admin_concurrency_stamp";

            public const string userNumOneId = "4";
            public const string userNumOneName = "User Num One";
            public const string userNumOneNormalizedName = "USER_NUM_ONE";
            public const string userNumOneConcurrencyStamp = "user_num_one_concurrency_stamp";
        }
    }


}
