using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP.Database.Migrations
{
    public partial class AddedCheckToMovieTableIfIsTvShow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTvShow",
                table: "Movies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "1dbaee7b-d9ce-4c12-981d-a5d93915139b", new DateTime(2021, 9, 5, 22, 56, 24, 270, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "d1a48e3a-284f-4863-b1f7-ae4c72bdb79e", new DateTime(2021, 9, 5, 22, 56, 24, 270, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "37f1d88f-da32-49f1-868b-2895798e5aa3", new DateTime(2021, 9, 5, 22, 56, 24, 270, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "7a5a0d39-355c-4290-ac66-a089fe6e697c", new DateTime(2021, 9, 5, 22, 56, 24, 269, DateTimeKind.Local).AddTicks(6638), new DateTime(2021, 9, 5, 22, 56, 24, 261, DateTimeKind.Local).AddTicks(5326), "AQAAAAEAACcQAAAAEFLiZxTsJ5nNCEIRPohtXCSDFd5eDwqQLNY3GttHFBGsW1bkqkigPuVje2ofW0hNqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "3fcb0327-f9d7-4882-bc0a-07f8d717c343", new DateTime(2021, 9, 5, 22, 56, 24, 261, DateTimeKind.Local).AddTicks(5314), new DateTime(2021, 9, 5, 22, 56, 24, 253, DateTimeKind.Local).AddTicks(3572), "AQAAAAEAACcQAAAAEDHpWmUQgMTLm1gr9lD8HpRIM6j7cisn1XljPuBz610/+xCj9m1clPYv9SjZ/gxYng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "c019aee6-62fb-491c-bda1-84660a8e0371", new DateTime(2021, 9, 5, 22, 56, 24, 253, DateTimeKind.Local).AddTicks(2860), new DateTime(2021, 9, 5, 22, 56, 24, 239, DateTimeKind.Local).AddTicks(4080), "AQAAAAEAACcQAAAAENKK2T3pm4ozO1Jre+BSLFituUTO29rC7xglJTxeOFXaj/RAanSylEcY7w3V81RyXw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1968), 5.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1960), 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1953), 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1944), 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(251), 4.0 });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PublicId", "Url" },
                values: new object[,]
                {
                    { -34, "brooklynninenine_s2pba3", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872097/brooklynninenine_s2pba3.jpg" },
                    { -33, "see_olpjnm", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872087/see_olpjnm.jpg" },
                    { -32, "titans_hkz342", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872086/titans_hkz342.jpg" },
                    { -31, "walkingdead_bycpz3", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872085/walkingdead_bycpz3.jpg" },
                    { -29, "thesopranos_alr5zq", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872080/thesopranos_alr5zq.jpg" },
                    { -13, "denzelwashington_fu9qmb", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799745/denzelwashington_fu9qmb.jpg" },
                    { -14, "halleberry_zduavw", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799738/halleberry_zduavw.jpg" },
                    { -15, "willsmith_eua0te", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799737/willsmith_eua0te.jpg" },
                    { -16, "vacationfriends_dbo6hr", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871033/vacationfriends_dbo6hr.jpg" },
                    { -17, "pig_byciwz", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871033/pig_byciwz.jpg" },
                    { -18, "nowayhome_xivojd", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871035/nowayhome_xivojd.jpg" },
                    { -19, "beckett-2021_nco3v7", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871035/beckett-2021_nco3v7.jpg" },
                    { -30, "rickandmorty_l5ptrk", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872081/rickandmorty_l5ptrk.jpg" },
                    { -20, "junglecruise_fzefqf", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871037/junglecruise_fzefqf.jpg" },
                    { -22, "wrathofman_xv5ufx", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871039/wrathofman_xv5ufx.jpg" },
                    { -23, "breakingbad_uxgsek", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872064/breakingbad_uxgsek.jpg" },
                    { -24, "americanhorrorstory_k1w0he", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872066/americanhorrorstory_k1w0he.jpg" },
                    { -25, "friends_dsvbpm", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872066/friends_dsvbpm.jpg" },
                    { -26, "gameofthrones_h0lrog", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872068/gameofthrones_h0lrog.jpg" },
                    { -27, "peakyblinders_jz6bxi", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872070/peakyblinders_jz6bxi.jpg" },
                    { -28, "greys_fczdub", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630872074/greys_fczdub.jpg" },
                    { -21, "onceuponatimeinhollywood_jymdi7", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630871037/onceuponatimeinhollywood_jymdi7.jpg" },
                    { -12, "annehathaway_sgrmnh", "https://res.cloudinary.com/doisz5wiz/image/upload/v1630799748/annehathaway_sgrmnh.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreatedById", "CreatedByUserId", "DateCreated", "DateDeleted", "DateModified", "DeletedById", "DeletedByUserId", "FirstName", "IsDeleted", "LastName", "ModifiedById", "ModifiedByUserId", "PhotoId" },
                values: new object[,]
                {
                    { -7, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1665), null, null, null, null, "Anne", false, "Hathaway", null, null, -12 },
                    { -8, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1671), null, null, null, null, "Denzel", false, "Washington", null, null, -13 },
                    { -9, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1678), null, null, null, null, "Halle", false, "Berry", null, null, -14 },
                    { -10, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 273, DateTimeKind.Local).AddTicks(1684), null, null, null, null, "Will", false, "Smith", null, null, -15 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedById", "CreatedByUserId", "DateCreated", "DateDeleted", "DateModified", "DeletedById", "DeletedByUserId", "Description", "IsDeleted", "IsTvShow", "ModifiedById", "ModifiedByUserId", "PhotoId", "RatingTotal", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { -22, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2478), null, null, null, null, "A team of young superheroes combat evil and other perils.", false, true, null, null, -32, 3.7000000000000002, new DateTime(2018, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titans" },
                    { -21, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2471), null, null, null, null, "Sheriff Deputy Rick Grimes wakes up from a coma to learn the world is in ruins and must lead a group of survivors to stay alive.", false, true, null, null, -31, 3.3999999999999999, new DateTime(2010, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walking Dead" },
                    { -20, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2464), null, null, null, null, "An animated series that follows the exploits of a super scientist and his not-so-bright grandson.", false, true, null, null, -30, 3.2999999999999998, new DateTime(2013, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rick and Morty" },
                    { -19, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2457), null, null, null, null, "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.", false, true, null, null, -29, 3.1000000000000001, new DateTime(1999, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sopranos" },
                    { -18, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2450), null, null, null, null, "A drama centered on the personal and professional lives of five surgical interns and their supervisors.", false, true, null, null, -28, 3.0, new DateTime(2005, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grey's Anatomy" },
                    { -17, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2443), null, null, null, null, "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.", false, true, null, null, -27, 5.0, new DateTime(2013, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaky Blinders" },
                    { -16, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2436), null, null, null, null, "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", false, true, null, null, -26, 4.7000000000000002, new DateTime(2013, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones" },
                    { -15, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2429), null, null, null, null, "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.", false, true, null, null, -25, 4.4000000000000004, new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friends" },
                    { -13, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2075), null, null, null, null, "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", false, true, null, null, -23, 4.0, new DateTime(2008, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking bad" },
                    { -23, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2484), null, null, null, null, "Far in a dystopian future, the human race has lost the sense of sight, and society has had to find new ways to interact, build, hunt, and to survive.", false, true, null, null, -33, 2.8799999999999999, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "See" },
                    { -12, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2068), null, null, null, null, "The plot follows H, a cold and mysterious character working at a cash truck company responsible for moving hundreds of millions of dollars around Los Angeles each week.", false, false, null, null, -22, 4.0999999999999996, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrath of Man" },
                    { -10, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2052), null, null, null, null, "A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywood's Golden Age in 1969 Los Angeles.", false, false, null, null, -21, 5.0, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Once Upon A Time... In Hollywood" },
                    { -7, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1982), null, null, null, null, "Based on Disneyland's theme park ride where a small riverboat takes a group of travelers through a jungle filled with dangerous animals and reptiles but with a supernatural element.", false, false, null, null, -20, 3.8999999999999999, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jungle Cruise" },
                    { -8, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1989), null, null, null, null, "Following a tragic car accident in Greece, an American tourist finds himself at the center of a dangerous political conspiracy and on the run for his life.", false, false, null, null, -19, 3.7999999999999998, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beckett" },
                    { -6, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1975), null, null, null, null, "For the first time in the cinematic history of Spider-Man, our friendly neighborhood hero is unmasked and no longer able to separate his normal life from the high-stakes of being a Super Hero.", false, false, null, null, -18, 3.0, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider Man: No Way Home" },
                    { -11, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2060), null, null, null, null, "A truffle hunter who lives alone in the Oregonian wilderness must return to his past in Portland in search of his beloved foraging pig after she is kidnapped.", false, false, null, null, -17, 2.8999999999999999, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pig" },
                    { -9, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(1996), null, null, null, null, "A couple meets up with another couple while on vacation in Mexico, but their friendship takes an awkward turn when they get back home.", false, false, null, null, -16, 3.5499999999999998, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vacation Friends" },
                    { -14, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2420), null, null, null, null, "An anthology series centering on different characters and locations, including a house with a murderous past, an insane asylum, a witch coven, a freak show circus, a haunted hotel, and much more.", false, true, null, null, -24, 4.2999999999999998, new DateTime(2011, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Horror Story" },
                    { -24, "rOFHG9xvlRKAdXOjUh3J", null, new DateTime(2021, 9, 5, 22, 56, 24, 275, DateTimeKind.Local).AddTicks(2492), null, null, null, null, "Comedy series following the exploits of Det. Jake Peralta and his diverse, lovable colleagues as they police the NYPD's 99th Precinct.", false, true, null, null, -34, 2.8999999999999999, new DateTime(2013, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooklyn 99" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DropColumn(
                name: "IsTvShow",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 5, 1, 36, 21, 340, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee2b0b2-e5f4-4bab-b7aa-bc6d6237efd0",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "c7ae3798-c41c-4838-8d46-e990dea8e888", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf0bbae-1fc5-4ca2-9eb4-1557aed94397",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "fdb52333-8430-43a0-bf5b-9508b0e0a8d9", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cdd8900-b5a2-41ef-bd55-2a4215f04c48",
                columns: new[] { "ConcurrencyStamp", "DateCreated" },
                values: new object[] { "a7540a5a-39d7-4df3-b8da-5c3c10d8f073", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "NsOUTyrRU3CRxdPY06lP",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "1b6a93ed-225b-49c5-9cec-1d5577d7acfc", new DateTime(2021, 9, 5, 1, 36, 21, 339, DateTimeKind.Local).AddTicks(1217), new DateTime(2021, 9, 5, 1, 36, 21, 333, DateTimeKind.Local).AddTicks(7496), "AQAAAAEAACcQAAAAEJv2xK3FVSwJuYTq5IeiybodIjs3zb/UL2ysrL5sH7APB9o7ErliZJEpDT7RCthZww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pQVqvZg7tnJYQv93gme9",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "2fa2de0b-07fc-41a9-89ac-dd627f21ddbb", new DateTime(2021, 9, 5, 1, 36, 21, 333, DateTimeKind.Local).AddTicks(7487), new DateTime(2021, 9, 5, 1, 36, 21, 328, DateTimeKind.Local).AddTicks(3261), "AQAAAAEAACcQAAAAEC3zVhb26CeMYbYwtHJn+lUimF8sy8YsJHk/QGilAOkgVrfG2xMqgyLeOxRaSVWgaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "rOFHG9xvlRKAdXOjUh3J",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "LastOnline", "PasswordHash" },
                values: new object[] { "91a40f83-0c37-4adf-adcc-19bce6c8f1a1", new DateTime(2021, 9, 5, 1, 36, 21, 328, DateTimeKind.Local).AddTicks(2751), new DateTime(2021, 9, 5, 1, 36, 21, 321, DateTimeKind.Local).AddTicks(1543), "AQAAAAEAACcQAAAAEA65Q/XXktHerHSsTMCTSlQe5zmo0lAYuCdcAvbI+Wqmt5nSv2cRwcaCxPgfmQf70g==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4463), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4459), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4454), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(4448), 0.0 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "RatingTotal" },
                values: new object[] { new DateTime(2021, 9, 5, 1, 36, 21, 341, DateTimeKind.Local).AddTicks(3583), 0.0 });
        }
    }
}
