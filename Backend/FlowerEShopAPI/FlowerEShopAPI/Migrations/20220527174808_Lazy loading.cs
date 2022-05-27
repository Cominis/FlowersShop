using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowerEShopAPI.Migrations
{
    public partial class Lazyloading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nisl", "Mi nulla, blandit, tincidunt nunc, leo, mauris pulvinar fermentum duis. Commodo est odio, odio elit porta ut lobortis aptent tellus. Amet, etiam aptent molestie tincidunt eleifend, donec malesuada habitasse enim. Molestie nibh magna, ultrices eleifend, commodo, bibendum felis convallis nec. Purus placerat nec lacinia dictumst massa, ultricies metus tempor ut.", 96m, 37m, 0, "In", "Maximus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("036526be-993c-4d69-ba77-42f606d587cb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "In", "Adipiscing interdum, vehicula mauris, phasellus diam gravida posuere tellus conubia. Leo rhoncus, nullam molestie egestas orci commodo arcu quam, diam. Dui, inceptos elit, mattis mauris, blandit, varius vel, consectetur tellus. Aliquet eget phasellus consequat imperdiet vestibulum, platea finibus, fames luctus. Curabitur cras at in vestibulum, cursus, quam, praesent purus molestie.", 45m, 12m, "A", "Ligula." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sapien", "Rhoncus, massa pulvinar, varius ante, orci taciti dui et ut. Auctor odio efficitur facilisis in, luctus finibus interdum adipiscing sed. Aliquet volutpat, faucibus mollis curabitur tellus in proin dolor euismod. Lorem, urna est nunc at mi, scelerisque nam phasellus vel. Lacus vestibulum, taciti massa efficitur malesuada felis sagittis, magna, pulvinar.", 64m, 55m, "Quisque", "Risus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c30630-ef18-465b-9514-fc742de98727"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dui", "Convallis vitae, curabitur blandit, eget nulla tempor nisl pharetra fames. Amet, bibendum sapien accumsan vel, porttitor, porta, maecenas fusce diam. Odio, sem, tincidunt sapien orci nec, phasellus neque, vitae sit. Quisque elit, blandit, commodo, tincidunt tempor quam, at, porta urna. Sed, morbi urna, posuere tincidunt suscipit nunc eros primis tellus.", 24m, 84m, 0, "Sociosqu", "Tincidunt." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Cursus", "Volutpat, vivamus aptent finibus non ligula, iaculis id, himenaeos massa. Euismod non nulla, mi dictumst massa eleifend, lorem mollis risus. Consectetur et, pulvinar, orci tempus varius convallis libero laoreet, venenatis. Augue ultrices, tortor vitae, lectus nisi ad sapien orci laoreet. Sagittis luctus, congue, semper a quam ex, ad amet, sit.", 91m, 6m, 0, "Ultrices", "Sollicitudin." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Elit", "Commodo vehicula ante urna ligula, litora viverra in, interdum, sed. Varius, ultricies congue nunc, nulla, sapien maximus gravida placerat metus. Lorem laoreet, sed nisl eros rutrum leo, fringilla, velit finibus. Neque nec accumsan magna fusce risus sem, amet efficitur metus. Eget ex neque, lectus, suspendisse nam orci, conubia dui, vestibulum.", 65m, 44m, "Nullam", "Dapibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ligula", "Feugiat imperdiet felis non, vel habitasse nibh mattis varius venenatis. Pharetra bibendum, quisque inceptos sodales amet, dolor condimentum vitae molestie. Primis iaculis hac pharetra euismod, magna, porttitor etiam magna elementum. Erat placerat, dignissim adipiscing aenean rhoncus vulputate semper taciti luctus. Eget lacinia arcu, imperdiet finibus, metus a, cras pharetra habitasse.", 54m, 94m, "Vitae", "Torquent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff8504f-e274-4d9f-984b-df155739e516"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Lacus", "Lectus, massa mauris, consequat rhoncus dolor, pharetra tempor, sapien curabitur. Neque, sit fringilla, porttitor, accumsan tortor, eros, vitae, magna, conubia. Risus non, orci, nullam volutpat, mollis aliquet ultricies ullamcorper eros. Sapien dictum bibendum, class semper fringilla bibendum phasellus pulvinar turpis. Pulvinar, lectus posuere, sed, porttitor suscipit semper sit velit dapibus.", 69m, 18m, "Arcu", "Iaculis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Praesent", "Tortor odio dolor gravida id, ut nibh, porta lobortis mi. Dolor lacinia facilisis leo, urna, habitasse dictumst integer ac porta. Id, ante, nulla, amet, eu, egestas at praesent dictum elit. Himenaeos amet, interdum dolor at, felis augue consectetur ultrices sodales. Commodo mattis, dolor consequat habitasse rutrum arcu, pulvinar, auctor rhoncus.", 72m, 20m, "Vestibulum", "Magna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Congue", "Dui, maximus urna tincidunt lacinia ante, odio sagittis, scelerisque sodales. Litora id finibus imperdiet tempor finibus, ultrices lectus, lorem, justo. Amet ipsum fusce quis euismod, ex ante molestie quam pulvinar. Pellentesque blandit pharetra volutpat, eget etiam eros, nisl litora sem. Convallis fringilla, tellus, nibh, pulvinar, non arcu, vel, blandit, inceptos.", 21m, 92m, 0, "Fermentum", "Lacinia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Auctor", "Cursus, ac, vel duis condimentum ex, faucibus lacus suspendisse integer. Maecenas elementum dui tortor, vehicula sem, varius, varius volutpat venenatis. Iaculis gravida duis scelerisque malesuada lectus, imperdiet tristique elit quam. Congue phasellus massa, quam mauris, vitae, vel nisi, ultrices torquent. Pharetra at neque metus urna auctor tempus egestas scelerisque hac.", 25m, 45m, "Erat", "Gravida." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Eros", "Auctor, dui, sodales tempor, eros blandit, gravida sapien nulla, neque. Vestibulum sociosqu fusce pulvinar mauris, libero dolor, cras faucibus vel. Euismod nisl dolor, sem, blandit imperdiet metus vulputate nisi vivamus. A gravida orci placerat malesuada arcu litora egestas ipsum tempus. Pulvinar, eros mauris, elit et maximus aptent donec eleifend, finibus.", 60m, 96m, 1, "Rhoncus", "Torquent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21420154-8f18-4fb3-b745-60621cca5541"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sagittis", "Euismod phasellus dapibus elementum quis, interdum, pellentesque dui, consequat fringilla. At, dui nisl platea posuere non tincidunt velit vehicula interdum. Commodo, magna, imperdiet feugiat a dapibus lectus, laoreet, et, luctus. Lacinia, sagittis volutpat, arcu, erat, cursus, quisque feugiat, nunc lectus. Tempor, ullamcorper orci nunc neque nibh, nibh egestas efficitur vitae.", 36m, 73m, "Class", "Interdum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tellus", "Maecenas dui in dictumst ultrices, ultrices blandit, taciti etiam nulla. Elementum sit tellus, odio faucibus per id, enim posuere, lorem. Adipiscing luctus, varius, pulvinar luctus mi blandit, interdum, elit, nunc. Condimentum etiam dictumst ornare ac, eget eros, mauris, quam, neque. Mollis rutrum morbi sociosqu mi eros ligula, dolor ornare felis.", 51m, 59m, "Dapibus", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sit", "Feugiat efficitur dignissim erat nullam sed, mi, vitae, cursus praesent. Massa, a nunc rhoncus urna proin mattis, integer in, elit. Elementum posuere rhoncus, neque, augue dolor euismod tincidunt non vehicula. Ipsum nulla rutrum vivamus commodo, vestibulum, consectetur ultrices, ultricies euismod. Sem maecenas mi posuere proin quam facilisis magna, ex fusce.", 89m, 80m, "Dictum", "Donec." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Habitasse", "Posuere faucibus eleifend euismod tellus magna, ac tellus, accumsan eros. Finibus, pellentesque suscipit vel, vestibulum posuere pulvinar, ullamcorper libero convallis. Neque, mauris feugiat porta fringilla mattis id congue, commodo mi. Augue id, mattis, hac inceptos vivamus erat metus habitasse porta. Commodo libero leo lacus ligula quam, id, volutpat, turpis cras.", 45m, 22m, "Sollicitudin", "Mauris." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nam", "Tellus fringilla, eleifend, volutpat, metus vitae nostra, mauris, lectus etiam. At vivamus fringilla semper erat mattis commodo bibendum sagittis litora. Massa, quam, eget suspendisse habitasse euismod enim, amet, libero urna. Sapien class mi arcu, mattis tempor sed ante, pellentesque efficitur. Mattis, venenatis consequat tincidunt cras proin facilisis eget taciti platea.", 36m, 86m, 0, "Adipiscing", "Nam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tortor", "Convallis praesent tortor primis dolor, sem risus sagittis, leo, magna. Ex, hac duis ultrices sapien nec, hendrerit erat elit eros. Elit, dignissim urna velit habitasse erat vivamus sem tempor consequat. Viverra in ac, risus et, congue, a, eget vehicula tellus. Nisi arcu mi pharetra ac, elit fringilla bibendum ac felis.", 60m, 7m, "Mattis", "Mattis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vehicula", "Lorem, et risus pretium quis, neque nunc, pulvinar, porta, aptent. Maximus porttitor ut justo lectus, odio sagittis, at pulvinar suscipit. Eu, neque nibh posuere, efficitur semper molestie nunc sodales posuere. Quis egestas sem rutrum nulla, varius, aptent id bibendum, aliquet. Sagittis, quis urna vehicula odio iaculis auctor euismod, nunc, nibh.", 54m, 93m, 1, "Volutpat", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Bibendum", "Dictum fringilla, quam, vel tellus, orci, maximus varius venenatis eget. Cursus pellentesque a turpis quam semper odio, ultricies est vitae. Nulla, orci, maximus morbi magna elit, cursus, placerat, ante, sollicitudin. Ut conubia vel, luctus tincidunt fringilla aenean nunc elementum sem. Odio, sociosqu posuere consectetur tortor rutrum placerat, commodo dapibus integer.", 46m, 92m, 1, "Orci", "Augue." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("357cca07-da0f-4263-9575-9304ba791639"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Libero", "Nunc morbi est himenaeos vel, taciti nisi, euismod ipsum sagittis. Odio laoreet pellentesque congue, pretium hendrerit enim, sollicitudin elit eu. Inceptos iaculis ac eros, vestibulum blandit, finibus, nunc, vulputate id. Aptent pretium non conubia ornare ac, dapibus aliquet libero fames. Ligula, convallis interdum sed, sapien dictum ipsum posuere luctus odio.", 69m, 73m, 1, "Nostra", "Suscipit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tortor", "Bibendum taciti urna arcu elit ligula, in feugiat, facilisis finibus. Nisl commodo, placerat, scelerisque ex, interdum at enim varius tellus. Commodo, nisi faucibus molestie nibh, nec scelerisque pellentesque himenaeos eu. Sapien bibendum tempor malesuada cursus eget nisi vitae eu, pharetra. Nunc dolor, conubia augue varius, ante tristique lorem, eleifend, eu.", 22m, 3m, "Rhoncus", "Fermentum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quis", "Risus feugiat, lobortis cras dictumst massa, consectetur quis, nisi, dui. Rutrum sem eget blandit, posuere, quisque purus massa, dignissim pulvinar. Iaculis elit, mattis porta taciti aenean sociosqu quisque sed, dapibus. Lorem, convallis vulputate ac, auctor dui ornare orci, fusce torquent. Et, elit, placerat curabitur posuere, porta conubia praesent laoreet fringilla.", 79m, 59m, 1, "Magna", "Rhoncus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nunc", "Massa blandit, iaculis himenaeos sagittis nisi pellentesque conubia massa, pharetra. Interdum, elit, pulvinar, velit sagittis quis, quam, purus nam etiam. Lorem, tempor, nulla, luctus sagittis suspendisse amet, ullamcorper quam faucibus. Cras est eros, imperdiet rhoncus fusce nulla maecenas auctor placerat. Volutpat tincidunt convallis porta neque a, varius integer magna mattis.", 26m, 99m, 1, "Tortor", "Tempor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Eget", "Ad aliquet iaculis dolor ante, dolor, cras ligula habitasse class. Arcu ultrices duis nisl aliquam urna augue condimentum ipsum nisi. Urna, accumsan mi, placerat inceptos et leo nisl morbi sem. Fames morbi arcu, nibh lacinia ex faucibus sagittis, sodales nostra. Tincidunt felis fringilla sed vel, auctor, sociosqu suspendisse iaculis per.", 94m, 28m, 0, "Bibendum", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vestibulum", "Interdum, aliquam pharetra in vestibulum consectetur lobortis justo neque nisl. Nulla dictumst eleifend, platea sodales a, volutpat commodo suscipit pulvinar. Faucibus porta porta, eleifend, porttitor, euismod, leo, nunc, eu, quis. Porttitor ultrices venenatis sagittis, dictumst et, sem iaculis tortor vestibulum. Fusce class pellentesque lorem, vehicula morbi consectetur luctus lacus augue.", 75m, 49m, 0, "Fames", "Varius." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4158bf42-0721-4e06-9ebd-ddf682240f7a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory" },
                values: new object[] { "Fermentum", "Eu, porta sagittis, sapien ornare viverra velit tempus in dictum. Amet auctor ac interdum lacinia, risus aliquet fames hendrerit neque. Rutrum maximus fringilla, phasellus aptent cursus quam, odio, vivamus nullam. Finibus, vulputate pulvinar, egestas ligula, nibh nisi, mi convallis aliquam. Ac, porttitor a, porttitor, fusce cursus iaculis magna sociosqu venenatis.", 96m, 58m, 0, "Cras" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "In", "Himenaeos commodo ut eleifend odio, et, massa felis vitae faucibus. Cursus, sodales sollicitudin ultricies sem, id porta, diam lacus cursus. Risus efficitur platea dui, hac at, felis pellentesque feugiat, quam. Pulvinar, bibendum gravida curabitur lorem, aptent himenaeos lacinia, amet, eget. Hac lacus ac, lectus, ut aenean turpis accumsan sem, mauris.", 73m, 4m, 0, "Nisl", "Conubia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Interdum", "Commodo venenatis dolor, blandit, mattis non nunc mi tortor, ante. Interdum et, id, ut nunc, arcu, dictum ex, amet, duis. Pellentesque purus blandit, ligula, metus facilisis class nunc elit, dictumst. Malesuada nullam leo, tortor, nisi bibendum, tincidunt gravida arcu, praesent. Euismod fames diam interdum, malesuada placerat, erat, elementum sagittis, vitae.", 61m, 54m, "A", "Metus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Erat", "Feugiat ultrices, orci, sit sem congue vel hendrerit dapibus adipiscing. Fames lorem, convallis porttitor arcu, elementum ad pulvinar rhoncus nullam. Cursus morbi interdum, primis tellus, sem torquent viverra enim rutrum. Suspendisse habitasse tortor quam porttitor, erat primis placerat a, tempor. Ligula sed taciti semper dolor est vehicula himenaeos id tempus.", 18m, 45m, 1, "Et", "Finibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tellus", "Per taciti luctus vehicula lobortis mollis tincidunt hendrerit feugiat bibendum. Tempor et, elit, nibh, at eu, vestibulum arcu tellus arcu. Litora tempor nunc, dolor ultrices, nisi consequat porta volutpat dui. Augue arcu gravida feugiat, massa efficitur laoreet, dolor, fermentum pulvinar. Proin facilisis posuere egestas habitasse tempor rutrum sollicitudin feugiat, sociosqu.", 60m, 92m, "Facilisis", "Augue." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dictum", "Lacinia conubia nam aliquet volutpat neque eu, suspendisse luctus hendrerit. Auctor, laoreet rutrum dictumst justo sem, arcu, nec pulvinar ligula. Nam porttitor lorem aptent litora ultrices porta, dui, a vivamus. Laoreet, integer felis nullam quisque luctus, himenaeos elit diam fringilla. Magna urna, morbi luctus nulla integer orci enim, eros, ac.", 40m, 6m, "Dictum", "Blandit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Pharetra", "Sociosqu scelerisque litora consectetur magna, nunc, nisl habitasse arcu, ultricies. Aenean congue, pulvinar non mauris litora ante iaculis erat sodales. Convallis porta, vel bibendum, malesuada erat justo enim mattis, aenean. A ultrices, sed, pulvinar iaculis mattis in nisi, feugiat molestie. Ullamcorper suscipit litora hac proin cursus, consequat eleifend, enim sagittis.", 67m, 2m, "Dui", "Litora." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quisque", "Non cursus, maecenas enim lorem fringilla, porttitor, porta ipsum auctor. Convallis bibendum porta, eleifend, dictum nisl vestibulum arcu, tortor luctus. Enim, torquent cursus proin diam quis dolor, a, mattis ex. Ultricies tristique in risus massa, suspendisse himenaeos tempus at interdum. Blandit congue nam mi, consequat mauris sit luctus ornare libero.", 84m, 23m, 0, "Urna", "Luctus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Fermentum", "Elementum pretium vestibulum per facilisis primis velit mollis bibendum egestas. Porta nisi a, ante vulputate tristique mi, scelerisque fusce vestibulum. A, cursus, finibus, litora vehicula pulvinar, dictumst leo, nostra, pharetra. Nec vel feugiat, leo, dapibus ante, varius, semper fermentum nibh. Ante aptent ligula, lacinia, cras vestibulum elementum nulla tempor eleifend.", 51m, 64m, "Posuere", "Dignissim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Primis", "Ante placerat, neque, duis dictumst vitae, ultrices dolor gravida massa. Finibus nec quam, posuere, posuere non, tortor felis egestas morbi. Convallis sapien amet, cras finibus vel vel, fusce eleifend nulla. Congue, finibus, cursus finibus arcu magna, dui, auctor, rutrum scelerisque. Cursus, mattis, tristique pulvinar duis leo nisi nam amet per.", 87m, 74m, "Etiam", "Diam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53c7a9de-03b5-4482-8163-2d925ca7f3c5"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Suscipit", "Cras himenaeos elementum tempor, erat feugiat, nullam luctus, quisque laoreet. Nisi, nostra, luctus congue, nunc fringilla, pulvinar, lacinia, odio, ornare. Mi, viverra adipiscing varius, ullamcorper sit lorem, venenatis amet, quam. Vestibulum posuere, neque posuere maecenas fusce lectus, venenatis vitae sed. Tortor viverra dui, vel, eu, tempus hac accumsan pharetra ornare.", 66m, 27m, "Facilisis", "Habitasse." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("543372da-be2f-4ef6-8496-98a8a075799c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Massa", "Lacinia aliquet cursus, non ex, vivamus et varius eleifend, et. Odio lobortis massa, finibus, sapien odio, nullam enim posuere donec. Ipsum at, eu, congue mattis, sed viverra ultrices, est rutrum. Quis, mattis euismod, nisl sed non sapien nulla molestie fringilla. Mi turpis aenean ornare suspendisse leo euismod augue dapibus ipsum.", 47m, 62m, "Mollis", "Quis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quis", "Interdum, ipsum eget suscipit vel, massa a lacus porta ac. Nulla cursus, libero laoreet, eu feugiat, ac ornare urna, bibendum. Lorem odio quis eu euismod, dolor, ac, a, porttitor, risus. Libero viverra imperdiet rutrum porta, vel sociosqu praesent ultrices adipiscing. Ultrices lectus, ut tempor, libero massa commodo, felis in, ex.", 56m, 24m, 1, "Egestas", "Dignissim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Eros", "Urna, aptent sodales cursus et himenaeos pulvinar, nisi vitae, metus. Phasellus nam in, ex, faucibus pulvinar mi ligula, litora massa. Sed, suscipit posuere, erat, tellus pulvinar, lobortis bibendum, eros, dolor. Adipiscing lacus pretium suspendisse commodo arcu nec in, curabitur sem. Libero suspendisse amet, tincidunt tortor, enim, tempor nec quam conubia.", 98m, 50m, 0, "Cursus", "Quis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sagittis", "Neque euismod placerat, sit viverra tempus quam mollis fringilla eu. Congue malesuada tempor, urna lorem, varius sem, quisque elementum libero. Volutpat, eu congue vel, aliquam integer lobortis aptent feugiat praesent. Varius, volutpat finibus eleifend, auctor integer adipiscing morbi justo accumsan. Sagittis, lacinia, finibus, tortor tellus nulla, diam congue, augue etiam.", 92m, 84m, "At", "Laoreet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mi", "Fusce odio, tempus interdum quam vitae, neque, amet, nisi, erat. Ornare rhoncus nisi porttitor integer lacinia viverra mattis nam iaculis. Nullam mattis cursus, volutpat integer maximus augue amet, convallis odio. Phasellus leo praesent luctus fringilla, donec aenean vel ante, vehicula. Arcu, pulvinar aptent in interdum, faucibus mauris mauris, tellus, ex.", 52m, 63m, "Sapien", "Enim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Fermentum", "Dui himenaeos interdum molestie cras per tempor, odio, luctus feugiat. Vestibulum, condimentum morbi mattis, vivamus class in vitae eu curabitur. Sagittis, himenaeos molestie efficitur amet, cursus consectetur leo, quam, ullamcorper. Risus elit, pulvinar, congue, aptent inceptos mattis ipsum leo massa. Ligula mattis vulputate non, neque accumsan porta inceptos phasellus turpis.", 5m, 3m, "Felis", "Luctus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Adipiscing", "Pellentesque eu est non, tellus et feugiat, dui, urna, eleifend. Integer praesent interdum, pretium euismod erat mi, conubia est lorem. Euismod, varius, dapibus tempor non tortor etiam fermentum maecenas nunc. Ut tortor pulvinar elit in, arcu, ipsum habitasse sapien luctus. Lacinia, hendrerit etiam consectetur morbi ex magna dictum augue nullam.", 24m, 55m, 0, "Sed", "Eleifend." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Fermentum", "Lacus elit, urna, vivamus augue vehicula nisi placerat efficitur facilisis. Odio ultricies erat etiam bibendum, conubia lorem ac massa id. Odio, quis habitasse porta vel, ultrices, fringilla dolor, finibus platea. Amet, morbi vivamus eros varius, lacus eu, magna erat, tempor. Pulvinar, mi ligula convallis ante, aliquet taciti tellus finibus augue.", 14m, 14m, 1, "Congue", "Convallis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Porta", "Non in, malesuada donec purus lacus congue urna, platea porttitor. Laoreet rhoncus, ante ut aptent lacinia, in sit nulla, ac. Suscipit dolor, mi, at, erat, rhoncus interdum, odio nisl ante. Fusce facilisis nisl magna, torquent odio luctus lorem sapien bibendum. Orci interdum torquent vitae, cursus, feugiat, lorem luctus volutpat porttitor.", 24m, 20m, "Nulla", "Hendrerit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Luctus", "Tempor, purus nec volutpat nunc nulla, feugiat, quam bibendum lobortis. Enim, nec laoreet, ante class dui, quam hendrerit rhoncus metus. Commodo molestie cursus, morbi erat, phasellus nec, a, euismod hendrerit. Eu blandit habitasse sollicitudin arcu, turpis donec dui vitae interdum. Quam, quis mattis, volutpat, porta, congue taciti interdum lectus velit.", 97m, 21m, 1, "Ante", "Dictumst." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mi", "Justo ultricies luctus, lacinia mauris faucibus pulvinar aliquet mi a. Velit odio maecenas dui, interdum, finibus, lacus congue non habitasse. Tempor fusce lorem eleifend ullamcorper neque quam, luctus rhoncus ad. Ut conubia a tortor, mattis, fusce varius, consequat sem arcu. Interdum, varius elementum scelerisque dignissim dui, dapibus posuere, iaculis bibendum.", 52m, 71m, "Sagittis", "Pulvinar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Id", "Dictum hendrerit nunc, vel et purus eget quam, turpis nec. Cursus, ultrices, accumsan conubia rhoncus varius aptent tortor, volutpat, blandit. Odio sodales fames odio, lorem, lectus rhoncus, efficitur dui, vehicula. Et lectus in, fringilla, suspendisse etiam pretium sem erat, augue. Vitae dolor tempor amet, curabitur posuere, eros, vestibulum sed, commodo.", 20m, 9m, 0, "Litora", "Conubia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tempus", "Consectetur et, porttitor, ullamcorper ultrices urna, rhoncus, tellus, facilisis fusce. Aenean nulla, semper fringilla, lobortis mattis pretium torquent mi sed. Pulvinar, ullamcorper orci blandit in placerat non, ultrices odio, lorem. Nec, non, vestibulum elementum sociosqu eleifend, et, adipiscing fringilla efficitur. Phasellus fusce condimentum suspendisse amet, vitae, volutpat urna risus sed.", 60m, 95m, "Mattis", "Metus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Auctor", "Luctus litora semper aliquam duis porta platea arcu, dignissim eleifend. Erat, porta, mauris tempus aptent hac dictumst fermentum vehicula at. Ipsum lacus fringilla, torquent maximus felis sociosqu odio sit ante. Orci, fames rutrum ultrices, auctor, venenatis pulvinar, sociosqu erat, vivamus. Litora elit tellus, euismod interdum, inceptos libero sociosqu faucibus vehicula.", 85m, 30m, 0, "Finibus", "Nam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dolor", "Laoreet viverra dui, rhoncus enim tristique vitae non, bibendum, phasellus. Ut condimentum dictumst commodo fermentum non, dui gravida bibendum ante. Nostra, urna, nunc, non erat fames efficitur velit ante, odio. Primis vivamus at, conubia odio, hac vitae, magna, commodo, tellus. Efficitur mauris, porta est in magna semper sodales luctus, vitae.", 16m, 57m, "Ligula", "Proin." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Est", "Faucibus fringilla, urna purus pharetra at, vitae finibus id, euismod. Nec, facilisis urna ex, vitae finibus congue, quis, cursus id. Enim vestibulum, auctor, nunc, odio rhoncus rhoncus, nibh porttitor, eu. Eros quis nulla, fames porta leo himenaeos auctor, erat donec. Auctor, faucibus urna cras ex, tincidunt conubia morbi congue, facilisis.", 65m, 55m, "Dui", "Elit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("836bf6f7-71a6-485d-8514-455393908657"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Consequat", "Vitae diam proin dapibus vehicula quisque suscipit curabitur ex quis. Phasellus tempor iaculis urna, et pellentesque malesuada rhoncus felis maximus. Erat, sociosqu etiam ex, elit fermentum malesuada sollicitudin per eget. Sed risus volutpat mattis, quam sem, semper sociosqu maecenas proin. Lectus, tincidunt quam diam sem dignissim a, nibh, turpis magna.", 93m, 98m, 0, "Fringilla", "Pharetra." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Donec", "Pretium sollicitudin augue ipsum urna, at luctus curabitur elit nibh. Cursus congue, magna, turpis ultricies ac, sodales molestie luctus himenaeos. Magna, feugiat, eros, tempus tortor, augue efficitur nulla rutrum fringilla. Quis, dictumst maximus ex, a tortor fames odio, nisi inceptos. Mauris tempor habitasse porttitor, posuere egestas amet, volutpat, primis vel.", 76m, 48m, "Nec", "Auctor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Enim", "Fringilla, sapien pulvinar, torquent nulla platea tristique inceptos accumsan tortor. Odio, in ante, neque sodales mi, duis leo tempus pulvinar. Porttitor congue, maecenas euismod placerat dolor eget magna primis torquent. Augue condimentum molestie libero ad ex, pharetra nibh, interdum iaculis. Neque ante, ligula scelerisque massa diam ullamcorper leo tortor eu.", 7m, 93m, 1, "Tellus", "Volutpat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Aliquet", "Sodales id, fringilla duis nibh, tortor proin porttitor feugiat, lobortis. Vulputate blandit eros platea aptent vitae amet, tellus fringilla, molestie. Urna volutpat aliquam donec eu, porta aptent viverra elit, praesent. Lorem, dolor euismod, hendrerit magna enim arcu, ornare eros, sollicitudin. Odio, sapien massa, fringilla, lacinia sagittis, proin inceptos nam lectus.", 30m, 43m, 1, "Semper", "Vel." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Interdum", "Taciti ante mi a nulla pulvinar, quis, congue odio, vel. Laoreet, lacinia aliquam a, integer pellentesque taciti per neque lobortis. Torquent feugiat, mattis mi suscipit neque, ex porta quis urna. Euismod eros odio, dapibus porta, tempor, nunc magna, inceptos ut. Tempus volutpat, vehicula nec, feugiat nam habitasse eu, mauris luctus.", 41m, 22m, 0, "Malesuada", "Commodo." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Congue", "Nunc faucibus consequat suscipit mauris, ultricies dui at, nunc, sollicitudin. Massa, feugiat, himenaeos nulla ex morbi scelerisque leo sociosqu inceptos. Mi, arcu lacus nisl auctor placerat praesent proin sociosqu cursus. Primis lacus lobortis tempor, platea orci, amet, sed praesent congue. Nulla vestibulum, feugiat, auctor dolor lacinia sagittis, congue, ex, metus.", 63m, 1m, "Elit", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quam", "Nec est vestibulum consequat ultricies porttitor, adipiscing laoreet integer ornare. Adipiscing nisl varius, ligula euismod mattis himenaeos orci conubia sollicitudin. Nullam accumsan nulla vestibulum, rutrum efficitur a, tempor volutpat, blandit. Odio, accumsan euismod velit orci, maecenas quis sagittis finibus sagittis. Blandit sagittis, porttitor, gravida ornare vestibulum, pulvinar, hendrerit non iaculis.", 68m, 79m, 1, "Arcu", "Hendrerit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("962d2024-995d-4165-89c9-55e15d2176e3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory" },
                values: new object[] { "Lectus", "Tristique class ornare gravida lacinia maximus cursus, turpis rhoncus, pulvinar. Blandit et, vivamus tellus, facilisis tempus faucibus non, class himenaeos. Enim id, metus pharetra libero proin faucibus at feugiat ultrices. Auctor faucibus posuere, condimentum elementum dictum id, lacinia, et arcu. Ultrices nisi, libero vel, tortor porttitor quam tempor, erat risus.", 10m, 45m, "In" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Est", "Mauris, ultricies vel euismod, ornare nisl in rhoncus, turpis mi. Maecenas eleifend, lobortis odio, feugiat eu dictumst at, nulla lectus. Nec fermentum suscipit eleifend, ut dictumst quis praesent quis, nisl. Ad justo ipsum hendrerit volutpat tortor, semper faucibus tempor ornare. Leo tempus blandit turpis et pellentesque dui ornare in vel.", 96m, 41m, "Pulvinar", "Dapibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Pretium", "Luctus, vitae, rhoncus litora mi, rhoncus, bibendum ultrices, quam risus. Nostra, urna, quisque ante nisi, congue, convallis magna, egestas cursus. Venenatis tempor lacinia, luctus, curabitur varius, interdum lorem, nulla imperdiet. Tincidunt mauris justo ullamcorper quisque et luctus, id nunc, purus. Massa est ipsum dolor, ac aptent porttitor laoreet, id hac.", 77m, 51m, 1, "Per", "Ligula." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Feugiat", "Suspendisse erat semper cursus mi libero erat, euismod et himenaeos. Ad nunc, erat dui blandit, nam ultrices convallis pulvinar dictumst. Ultricies ac, vulputate placerat, lacinia turpis nam nunc, massa consectetur. Laoreet, nibh, maximus accumsan luctus risus convallis non, fermentum interdum. Dignissim nibh dui interdum, lorem, morbi conubia orci, cras rhoncus.", 97m, 74m, 1, "Amet", "Ullamcorper." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Proin", "Amet, augue euismod, lobortis urna libero vehicula luctus nec molestie. Congue faucibus viverra cursus leo, turpis mi, erat, torquent quis. Accumsan urna, id, nisi orci, molestie laoreet, quisque facilisis nulla. Ad leo at, at commodo, consequat massa elementum scelerisque imperdiet. Finibus luctus, lectus maecenas justo fusce purus ultrices congue, nisi.", 87m, 78m, 1, "Cursus", "Viverra." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Eros", "Dui eros, nisi mattis, ut turpis lacinia ipsum porttitor, ligula. Finibus pulvinar varius mollis auctor leo, turpis luctus, praesent nullam. In ultrices sed fermentum lacinia porta eleifend ullamcorper primis integer. Ligula, accumsan mattis lacinia, quam sit scelerisque arcu duis sociosqu. Per pulvinar, laoreet, justo sed bibendum, aenean urna, hac dolor.", 35m, 10m, 0, "Dolor", "Hendrerit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ad", "Vulputate feugiat, volutpat, aliquet ornare elit, mattis, a vitae, dui. Leo amet, pharetra libero gravida dignissim interdum, ut quis torquent. Malesuada ipsum euismod donec interdum, pretium amet posuere, enim nibh. Libero nullam enim laoreet, leo, neque, vel et, massa commodo. Hac et, mattis sollicitudin dictum lobortis interdum tempus at, nunc.", 56m, 37m, 1, "Ligula", "Sociosqu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Fermentum", "Feugiat, bibendum, fermentum congue semper dui lacinia porttitor, bibendum aptent. Id, lorem vel congue turpis class aliquam magna, nibh torquent. Blandit, erat maximus luctus sollicitudin imperdiet quis, nisi, ornare magna. Felis ullamcorper suspendisse faucibus lectus ipsum erat, sollicitudin magna elit. Justo massa, mi cras maecenas phasellus laoreet, lorem, primis est.", 80m, 89m, 1, "Himenaeos", "Quam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "A", "Aliquet felis euismod, sem elit pulvinar, ipsum ligula leo, cursus. Nibh sodales in, fermentum enim, sagittis, non, sed ex, rhoncus. Dui, erat sem placerat, nunc, est feugiat, nisl scelerisque tempor. Accumsan bibendum eros eu inceptos ultrices, volutpat proin viverra etiam. Interdum mattis feugiat et lacinia pellentesque commodo, fames nibh, facilisis.", 61m, 7m, "Felis", "Erat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Bibendum", "Purus cursus ex, finibus dictumst auctor, urna, faucibus facilisis ac. Conubia a, hac interdum varius, aliquet finibus, libero nulla mi. Enim cras viverra mollis per vestibulum faucibus dictumst velit dui. Sed, neque, interdum morbi faucibus dignissim elementum nostra, dictum ex. Phasellus orci libero lectus, adipiscing leo nec, id etiam aptent.", 36m, 87m, "Eleifend", "Sagittis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adaa5968-bab8-433d-abc6-217d49fa3395"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Suspendisse", "Eu interdum, cras pharetra vulputate eget laoreet at, nisl felis. Integer placerat ultricies tortor commodo, ut ligula lectus nam proin. Conubia fermentum ante, vitae, leo, tempus litora commodo, nam volutpat. Scelerisque tempor, sodales proin ex eget risus luctus enim auctor. Elit tincidunt gravida urna cursus litora amet quam, euismod, pulvinar.", 22m, 98m, 1, "Maximus", "Mattis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Magna, luctus metus nunc vel, conubia commodo, himenaeos facilisis ultricies. Dapibus imperdiet egestas aliquam id sagittis rutrum ultrices, inceptos vehicula. Cursus, leo amet adipiscing congue egestas suscipit aenean et at. Sed scelerisque eu nibh, primis congue, amet, leo, eros, placerat. Id, vestibulum quis, auctor aptent enim lacinia iaculis pulvinar neque.", 32m, 82m, 1, "Efficitur", "Enim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "In", "Primis taciti justo felis non ac, vehicula vivamus magna, porta. Fusce curabitur pulvinar, ligula, dolor libero elit, habitasse sodales integer. Vulputate cras elit quam, odio augue sapien efficitur rutrum eget. Suspendisse sollicitudin vestibulum eros nostra, bibendum porttitor, nec, lectus, phasellus. Nisi, orci ornare fames in quam, orci, risus convallis elit.", 36m, 73m, "Neque", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Vehicula", "Libero at integer nostra, magna amet sociosqu bibendum, vestibulum blandit. Elit varius, pharetra pulvinar interdum tincidunt aliquet consequat posuere, nullam. Pulvinar, posuere magna, sit dapibus enim efficitur inceptos ultricies tortor. Vestibulum justo torquent in, tortor leo, at, mauris orci, augue. Vestibulum cursus interdum, sociosqu nulla, nulla consequat vehicula eleifend torquent.", 22m, 62m, "Euismod", "Placerat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Scelerisque", "Eros mattis, neque, vulputate in a sagittis, vehicula faucibus lacus. Leo cursus condimentum magna, vestibulum, tempor, a, augue dignissim nec. Tempus congue, hac mauris, ullamcorper ad dictumst quis nec at. Congue tempor, ac, in, eget pretium per dui neque, suspendisse. Praesent euismod hendrerit rhoncus, egestas in, cursus, ante bibendum vehicula.", 90m, 92m, "A", "Aenean." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Accumsan donec pulvinar, dapibus massa odio nec lacus litora rhoncus. Aliquet dictumst convallis lacus in, elit auctor, bibendum placerat morbi. Primis eu, condimentum massa platea ad scelerisque semper eu tellus. Vel, urna porttitor, diam donec sollicitudin consequat erat nibh nec. Nisi, adipiscing fringilla, dictum aptent et torquent dapibus congue, dolor.", 61m, 26m, 1, "Id", "Placerat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"),
                columns: new[] { "Category", "Description", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vestibulum", "Morbi amet at consequat nullam ipsum elementum quis, litora ligula. Velit quis, sed dictum sapien tortor id feugiat, blandit, et. Nec placerat proin eget sagittis fermentum interdum, ultrices, facilisis lectus. Tincidunt risus sem, varius nibh, viverra eu rutrum nullam fames. Urna cras aliquet quis, finibus, libero interdum class hac accumsan.", 0m, 0, "Quis", "Finibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Euismod", "Auctor condimentum habitasse quam, lacinia primis tellus efficitur augue vestibulum. Ligula, risus porta duis sem, tincidunt nostra, rhoncus dapibus aliquam. Neque placerat non, arcu interdum, vitae placerat, urna, leo, bibendum. Malesuada porta, nisl class placerat volutpat, orci nibh ligula, purus. Urna lacus interdum, sit quam odio dictumst maximus non, nibh.", 84m, 74m, 0, "Neque", "Tellus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba3c9243-5390-488e-b598-2779fd398da8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Malesuada", "Cursus, maecenas ad neque, torquent dui, posuere risus nisi et. Aliquam fusce curabitur id, at proin nunc, quis lacinia dapibus. Leo, orci, ligula, leo urna nisl commodo nisi quam eros. Vitae massa placerat laoreet nec, varius ullamcorper vestibulum id, consequat. Dictum dapibus elit, conubia ipsum a, nibh platea congue, adipiscing.", 38m, 15m, "Lacinia", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Odio", "Euismod posuere, cras vulputate odio, interdum, etiam nam torquent vestibulum. Mollis hendrerit ligula blandit conubia vel nam leo, curabitur mattis. Pulvinar dapibus himenaeos cursus commodo, scelerisque purus orci volutpat, in. Mauris, vulputate sed, enim, eleifend libero etiam euismod quam ex. Fames varius, tempor convallis blandit malesuada elit, placerat eget nisi.", 10m, 29m, 1, "Finibus", "Laoreet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Viverra", "Sagittis volutpat, dolor, mi, erat, volutpat dictumst facilisis amet nulla. Dignissim pulvinar ligula velit consequat eu, tortor libero placerat id. Rutrum euismod eleifend, nulla, quam, sagittis vulputate feugiat fringilla, proin. Gravida nulla, purus nibh, mi commodo hac dignissim lacinia, turpis. Sagittis, quis, mi, ante vitae, vivamus inceptos tincidunt posuere, risus.", 99m, 82m, "Integer", "Dictum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Pharetra", "Sagittis, blandit volutpat porttitor, purus erat, non nibh leo venenatis. Quis ornare feugiat, id eleifend ex, sagittis at blandit, vel. Auctor, elementum at, litora lacinia, euismod ligula, sem, fames id. Rhoncus bibendum non, felis id euismod libero lorem quam, interdum. Fringilla neque eleifend, etiam convallis congue nullam commodo, nulla dignissim.", 90m, 96m, 0, "Sollicitudin", "Dolor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Libero", "In dictum imperdiet nam lorem, velit aenean viverra nibh urna. Tempor, placerat, mauris ultrices, vestibulum, elementum morbi erat torquent ante. Lacus euismod, nullam luctus et primis in, dui placerat vulputate. Maximus arcu, nam arcu eu, rhoncus aenean suspendisse semper leo. Congue elit, diam velit risus semper euismod, dignissim et consectetur.", 50m, 27m, "Massa", "Urna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nulla", "Pharetra aliquet mattis vitae, eget tempus consequat blandit, lacus velit. Eros congue, mi est duis lacus rhoncus, ullamcorper arcu maecenas. Bibendum, tempus blandit, et dolor urna cras laoreet sed, malesuada. Mattis, elit, felis orci, eget erat ad sodales fames vehicula. Vestibulum morbi blandit, cras bibendum, nullam iaculis viverra at nunc.", 24m, 43m, 0, "Nulla", "Iaculis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Fames", "Phasellus lobortis hac augue suscipit ultrices mauris lectus, finibus, volutpat. Est vestibulum eu, rhoncus gravida neque, tempor sem, justo hendrerit. Sit auctor imperdiet eget lacinia, tristique luctus, porttitor, sollicitudin per. Consectetur ex felis eleifend, vivamus nunc, hac conubia auctor sapien. Placerat non, class nibh, lacus orci cras maecenas congue ac.", 30m, 57m, "Lobortis", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Odio", "Amet inceptos maecenas ornare ante, arcu, magna, facilisis cursus, finibus. Varius semper auctor, ultrices, class vivamus magna orci eleifend, quam. Integer nulla, vitae, fames amet a, magna, ultrices quisque suscipit. Tortor, tortor condimentum fermentum varius nulla, sem, volutpat odio, massa. Commodo odio commodo, rhoncus, dolor dui luctus, congue euismod erat.", 4m, 43m, "Tincidunt", "Tristique." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vel", "Blandit, quis fringilla, dolor ultricies justo ultrices, neque, dui lectus. Rhoncus, dictum non at lacinia, ultrices dignissim laoreet nunc, justo. Pretium gravida sollicitudin commodo, sem inceptos sed sit class pulvinar. Luctus magna ornare tincidunt et, finibus, justo volutpat, ad eleifend. Nam et, metus vitae leo fames hendrerit morbi nisl sed.", 67m, 6m, 0, "Augue", "Praesent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Leo", "Eu blandit finibus facilisis nunc, in dui luctus, tempor, varius. Lacinia massa, eget orci, ante tellus, litora ullamcorper auctor, elementum. Ultrices, ac donec tincidunt congue volutpat inceptos et finibus ante. Ad dapibus ante, class semper metus maecenas eros, orci in. Urna cras nulla consectetur vehicula vitae, volutpat mauris, suspendisse cursus.", 93m, 50m, "Ac", "Urna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Libero", "Lacus feugiat ipsum a, ex tellus, a molestie eros sagittis. Dictum nulla, urna class id amet pulvinar luctus accumsan ad. Euismod, nibh urna, risus nulla porta turpis lacus accumsan neque. Neque, habitasse enim, id lacinia, metus tempor, malesuada sed, fusce. Porta orci blandit aenean finibus, sapien suspendisse et, ligula orci.", 91m, 41m, 1, "Libero", "Condimentum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vel", "Lacinia viverra orci, lectus, aptent a odio quis, ut lectus. Finibus hac dolor integer in ligula eu, ex tortor, orci. Lacinia, quis praesent suspendisse quisque odio vitae sem, consequat aliquet. Faucibus nisl sociosqu placerat, luctus ultrices torquent placerat tortor lacinia. Vulputate suspendisse eleifend, ac adipiscing dictumst bibendum, feugiat ac, ultricies.", 0m, 21m, 1, "Nulla", "Lacus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Aenean", "Nisl feugiat mauris, congue, laoreet quis maecenas fringilla vehicula tempor. Nunc vel quis faucibus lectus, lorem, accumsan varius ligula mi. Feugiat, sit id, nisi posuere at ullamcorper nisi, leo, pellentesque. Quam, sodales finibus erat, nibh, a eu, vestibulum placerat urna. Finibus in etiam turpis justo aptent nunc, fringilla, taciti lorem.", 5m, 5m, "Efficitur", "Non." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mollis", "Bibendum, luctus curabitur posuere, nostra, non, volutpat, metus ultricies neque. In nisl mi, venenatis aliquet auctor feugiat, feugiat et, lorem. Dapibus varius imperdiet luctus eu, massa, interdum, fermentum malesuada hendrerit. Placerat, posuere, sed nibh, dictumst eros in non sem ultrices. Orci non adipiscing ultrices, suscipit posuere, magna velit a tellus.", 88m, 54m, "Id", "At." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Laoreet", "Praesent vulputate facilisis sed magna mattis, urna conubia pulvinar, imperdiet. Class justo tortor conubia varius, vestibulum varius duis fringilla amet. A ornare nulla, cursus vitae laoreet et, posuere nec, per. Eleifend auctor, habitasse molestie ornare libero class elementum nibh, sit. Sociosqu dui, neque pellentesque quisque pulvinar, tempus aliquet rhoncus vestibulum.", 12m, 1m, "Interdum", "Orci." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ullamcorper", "Vestibulum, curabitur metus sit tellus massa, aptent rhoncus eget dignissim. Pretium luctus, hendrerit sit quis, efficitur neque, nulla cursus, euismod. Adipiscing mauris, pulvinar, massa, vivamus pulvinar nisi sem fusce nibh. Lacinia, nunc ante, justo euismod finibus congue dictum nisi, ipsum. Dignissim sed, nibh placerat nunc pellentesque gravida porta, quisque vulputate.", 28m, 34m, "Nisl", "Ligula." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quam", "Auctor, quis, urna a pulvinar tempor, tortor, efficitur semper morbi. Nisl viverra ad est dolor, ullamcorper mollis rutrum nulla, fames. Massa, nam odio ornare iaculis proin habitasse augue tellus placerat. Nisl ultrices commodo, ac, tellus elementum sociosqu mattis, suscipit lorem. Magna, at, nostra, lacinia, sociosqu et, commodo, diam ac, convallis.", 52m, 12m, 0, "Litora", "Efficitur." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f19d67-4312-431c-a3f9-1a76d5306820"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dignissim", "Tincidunt at lorem bibendum, porta, tempor, mi, ultricies vitae, hac. Volutpat, torquent fames a, sagittis, lectus, eu varius ex odio. Lectus, justo vitae iaculis diam nec, lacinia, torquent pulvinar, condimentum. Mollis velit maecenas magna, luctus pulvinar erat, lacinia porta auctor. Porttitor dui, nulla, fusce venenatis tellus, tempus non feugiat, porta.", 70m, 55m, "Congue", "Tellus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Efficitur", "Pellentesque ligula, leo orci tempor eleifend eros, sociosqu ante luctus. Congue turpis amet, leo ac, ac adipiscing porttitor cursus at. Nam malesuada feugiat, primis condimentum nunc, ligula, sed non, sagittis. Leo, mauris, urna id, primis luctus, eros urna, odio integer. Vestibulum, enim ante, porta, sapien habitasse mi, amet eu, class.", 54m, 20m, "Enim", "Ultrices." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Porttitor", "Vel, commodo eget integer morbi dignissim fermentum lobortis arcu adipiscing. Egestas sollicitudin at, lobortis tellus, nisl arcu vulputate dui aliquam. Ante accumsan laoreet, suscipit massa, cursus, sem, mauris ultrices lacus. Lectus, luctus volutpat, tristique eu dapibus class et viverra nulla. Commodo, efficitur est mattis, luctus pellentesque urna, ad maecenas fusce.", 51m, 88m, "Blandit", "Id." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sodales", "Placerat faucibus orci, pretium praesent nostra, ac vitae, ante hendrerit. Non, posuere, auctor, interdum integer tincidunt fusce odio semper primis. Lorem platea congue, nulla, faucibus cursus amet placerat tellus, ut. Tempus fusce massa vel amet tellus, erat sapien turpis ad. Per nam sem, taciti lacinia condimentum aptent nibh, congue lacus.", 52m, 63m, "Litora", "Platea." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dictumst", "Vestibulum risus nec, bibendum, eu, nunc, ante lobortis pulvinar congue. Sagittis, id, rhoncus leo ligula ligula, pretium lectus, euismod, quis. Euismod, mattis placerat augue justo elementum consectetur hac nostra, proin. Porta lectus tincidunt finibus, imperdiet facilisis ligula, donec diam convallis. Ornare non, laoreet, urna, lorem ante vitae, orci ultricies curabitur.", 74m, 59m, 1, "Diam", "Habitasse." });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("057912aa-1fee-42ef-ac7a-1fc00873f500"),
                column: "ProductId",
                value: new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("05935a3f-9210-4e21-ab3f-7a08662f0960"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("21420154-8f18-4fb3-b745-60621cca5541"), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("0b25a43d-8674-48bb-bb37-33c5868cc6bf"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("0ce1f781-ba3b-4353-9d2d-ea4fc3bff138"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("13c5e19c-8fec-46c6-a5b0-bd9a071727e6"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("167b01aa-f3a2-4e92-98f8-15285397c324"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("16d834c4-899e-4385-a5c5-7ee20a866156"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("19df2e7d-b6b1-4279-865c-c3cb6eef469c"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("1c712568-3924-496e-bd2b-e90e273bdf77"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("20de9a89-a7af-457c-a77d-5525f7967e71"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("22c529e3-c0cf-4dea-b975-81f33f1344b2"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("27f9f8c7-445a-4c15-8f9a-c210e9d0498d"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("29326627-aeb0-4ef2-8df3-50afa9958b6b"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("29f51c20-f78d-44ff-b1ca-7a2dfd530c37"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("3efab290-b8a5-4786-a245-82b1cedcaaa9"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("3f895757-60c2-47b5-b970-8a7b6d2f21bf"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("41a465a9-a9ee-4074-9e8f-eaa9bf9b162b"),
                column: "ProductId",
                value: new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("4281874c-0163-4a72-b7dc-bd5c2ae99d9c"),
                column: "ProductId",
                value: new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("52741742-e69e-4e6f-aadd-2c7c2a1bdce5"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("52b62791-a93f-492e-bf2d-dacf15084c91"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("541d3c16-c3cf-424a-81ed-1e78e871834c"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("5ddcc969-219c-4a7b-9f81-cee0fb595a94"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6036aa7e-32f4-462a-9daf-d36a60d29f96"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6364170f-fe82-47eb-95f5-860fe13c01d8"),
                column: "ProductId",
                value: new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("65a5c17e-1da1-479d-99b1-85b25ac6d7f8"),
                column: "ProductId",
                value: new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6bf27763-d7fc-4893-96e2-d844a2356432"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("08c30630-ef18-465b-9514-fc742de98727"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("71e1abf5-dba4-4a14-96a7-26ab5ff08ae3"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("74faf6c6-2d55-4423-9816-49f2c0e84a02"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("7f65eba2-8e80-4619-aacc-d5b2fdbe37cf"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("812663ee-abb0-4ffa-b869-dfd39087bfb6"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("8288865c-9838-46ca-aabc-a09e26628e49"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("846a7c4f-b232-4a0f-a4b4-e3dc3c36fd4a"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("85bde701-fb9d-4046-9a3e-9b9935657855"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("91892802-c837-47a1-8f34-64cf30a26d8d"),
                column: "ProductId",
                value: new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("926e452a-8a75-4aec-ba93-6fe3b8312d9b"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a680a97b-eea7-417b-a3f2-6d2eaf01bec4"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a7b1da80-5a54-4d50-a0a0-13360bb50b63"),
                column: "ProductId",
                value: new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a96f73c9-1a70-4355-bd13-ee8cd0b2ae98"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("b8c76a8e-bb51-4398-ace7-b52fde7de3e5"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("c2ab942e-060c-43a0-af48-73d80b94cb03"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("c3874b20-25ff-4ce1-a9de-5330f8bdf89b"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("cbf6d242-6f27-4c36-bd3d-075b6c041229"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("ce8e41b9-03ba-430d-94f5-486658c7fdc8"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("e03e356a-90ec-411d-94f2-64a96123c72f"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("08c30630-ef18-465b-9514-fc742de98727"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("e304a5d2-a1a5-4e5a-b39e-2b833bcde4e9"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f0652b4f-a6cb-482e-9183-a331198dac04"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f3f84eba-6811-4212-b5a0-a2cd63065214"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f86e9a91-7df3-4fcb-9e35-83d33840b92e"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("ba3c9243-5390-488e-b598-2779fd398da8"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f9d55e34-a009-403d-a97b-e9ea438b37d7"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("fc14503a-a7d9-4872-8e04-97c51e8841dc"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Amet semper porta lobortis arcu quisque eleifend, massa adipiscing bibendum. Mattis quam feugiat pulvinar eros sociosqu finibus mauris, mi, ac. Suspendisse arcu, eleifend, elit nisl eget taciti feugiat habitasse fringilla. Tempor arcu consequat non in vitae, rhoncus, pharetra facilisis erat. Leo consequat orci, iaculis nulla turpis venenatis quisque curabitur scelerisque.", "Quis.", "Integer congue" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Egestas suspendisse sed magna, et, in bibendum posuere pretium sagittis. At, varius, magna vestibulum, luctus leo, malesuada finibus, congue, rutrum. Adipiscing scelerisque laoreet tempor, ultrices, a nunc sodales porta arcu. Duis vitae nibh leo, eu dapibus nec, metus bibendum tempor. Sagittis ex metus id, nisl felis ultrices duis posuere, sem.", "Mattis.", "Hendrerit ad" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Cursus mollis blandit libero tristique leo id sociosqu non, vitae. Sociosqu adipiscing pellentesque lobortis egestas faucibus urna urna, hac pretium. Pretium per luctus, pulvinar sapien sodales gravida class duis inceptos. Quam, vestibulum sapien interdum sem consequat rutrum arcu, eros ante. Tristique urna, erat elit ultrices, nunc, sodales eleifend, lobortis himenaeos.", "Cras.", "Varius consectetur" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Mattis, quis, placerat, amet, ante, mauris, nulla, volutpat vulputate neque. Arcu leo per ante himenaeos et massa, bibendum blandit, tincidunt. Justo dictumst himenaeos sem, vehicula finibus, rutrum dui, pulvinar efficitur. Scelerisque sollicitudin tortor, efficitur magna purus laoreet commodo volutpat, sapien. Venenatis tempus velit laoreet, eu, vitae odio, inceptos sollicitudin sed.", "Neque.", "Proin nam" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Commodo, lacus eros, ex, ante vitae, pharetra pellentesque interdum suscipit. Congue adipiscing vestibulum, pretium et morbi vitae, curabitur finibus, lorem. Lectus massa, massa dictumst malesuada justo velit purus congue, euismod. Et, molestie diam porta, ligula, cursus, elementum quis eget vel. Eros, dui sit enim, iaculis sem, dictumst rhoncus nisi, nisl.", "Torquent.", "Congue lorem" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Tempus pharetra eros nulla orci ligula, nec laoreet, tortor odio. Ante mauris proin praesent primis luctus, lacus ultrices, at diam. Ligula fringilla varius est rutrum arcu ac porttitor, et, neque. Arcu, porta, velit sagittis, class amet, vitae, litora maecenas bibendum. Proin phasellus dui, velit maecenas neque aliquam venenatis elit vestibulum.", "Tortor.", "Nisi elementum" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Placerat nec, ornare cursus, nam interdum, tempor lectus, euismod varius. Et dignissim sociosqu luctus, quam, posuere, mauris, leo, erat, porttitor. Interdum, ultrices elementum nunc porta nec, tristique fringilla porta, id. Feugiat faucibus nulla pulvinar, tortor, conubia cursus sem, aptent amet. Blandit, habitasse congue, volutpat, facilisis porta, sed at, lacinia rhoncus.", "Nisi.", "Vehicula nec" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Eros, id, consequat ligula, non, enim, nullam placerat tempor, porttitor. Purus tellus, tortor morbi laoreet, ipsum orci mattis, duis ultricies. Arcu enim efficitur varius, tempor bibendum a, odio, ultrices, feugiat. Arcu, consequat himenaeos odio laoreet, suscipit phasellus maecenas magna pulvinar. Ultrices, risus magna congue, ullamcorper sodales commodo, mi tortor feugiat.", "Curabitur.", "Nunc diam" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Malesuada himenaeos condimentum porttitor, orci nulla nibh mauris congue, gravida. Ipsum amet, imperdiet suspendisse aliquet sed, enim finibus, sollicitudin primis. Sem praesent ullamcorper vitae gravida eleifend dui, enim, himenaeos vel. Eget tortor, ultrices, consequat sapien in auctor dapibus mi eu. Pharetra nibh vestibulum volutpat, rhoncus, nulla amet nisl dapibus non.", "Efficitur.", "Interdum laoreet" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Egestas pulvinar in mi nulla orci, magna cras eros, aliquet. Integer inceptos taciti platea metus fusce gravida morbi quisque tincidunt. Libero congue, ante interdum purus elit, justo metus platea lacinia. Commodo, turpis magna, dictumst sem, risus lobortis velit eu, rhoncus. Risus dui luctus ex, inceptos auctor, quis, fringilla amet eget.", "Sem.", "Adipiscing odio" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "luctus@gravida.com", "Dui vitae", "Orci", "Augue", "Sem" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "aptent@tortor.com", "Condimentum lorem", "Vehicula", "Finibus", "Eget" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "magna@mattis.com", "Per etiam", "Donec", "Pellentesque", "Mauris" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6c8019dc-0237-484d-80dc-452428bce548"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "dui@nam.com", "Risus semper", "Eu", "Sociosqu", "Diam" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "urna@nec.com", "Mollis turpis", "Placerat", "Vivamus", "Taciti" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "ligula@volutpat.com", "Hac euismod", "Neque", "Pellentesque", "Massa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "porta@ex.com", "Leo rutrum", "Aliquam", "Eros", "Nibh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("df749524-0c6b-416d-94c2-398f8b62e92d"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "porttitor@diam.com", "Finibus neque", "Fringilla", "Molestie", "Leo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "diam@primis.com", "Phasellus interdum", "Accumsan", "Ex", "Vestibulum" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f70f7a45-8539-4082-a181-9705c2b5c505"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "eleifend@vehicula.com", "Fames fringilla", "Neque", "Placerat", "Euismod" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Metus", "Magna libero ante, praesent etiam ultrices auctor, euismod nulla, et. Vulputate pulvinar nisi, dignissim nibh volutpat, rutrum sollicitudin inceptos et. Posuere, velit maecenas erat, tempus porta, pulvinar, et rhoncus arcu. Non risus id, ipsum conubia lacinia, enim leo semper torquent. Bibendum, nibh, finibus, consectetur suscipit sodales condimentum turpis gravida a.", 6m, 29m, 1, "Fringilla", "Turpis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("036526be-993c-4d69-ba77-42f606d587cb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Ligula, fermentum congue et aenean nulla, fringilla nec, interdum, facilisis. Id vehicula malesuada dapibus leo erat, laoreet, tincidunt ac nec. Purus diam quis, odio adipiscing placerat, ex vestibulum vel nisi. Sodales enim hac urna blandit tempor sed sem non, ultricies. Dapibus egestas ultrices mauris auctor primis metus scelerisque purus adipiscing.", 15m, 16m, "Nulla", "Dapibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Feugiat", "Felis mattis congue donec nibh at, commodo, neque, urna cras. Lacus fusce placerat, augue tristique habitasse libero ante, magna, et. Ante, rutrum neque, neque eget cursus porta, metus nunc, faucibus. Habitasse eros, ad ex hac diam at, mattis lacinia, cursus. Et, volutpat id proin laoreet commodo congue consectetur ante placerat.", 52m, 97m, "Convallis", "Orci." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c30630-ef18-465b-9514-fc742de98727"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Turpis", "Vel, adipiscing felis id integer tempus porta egestas rhoncus, diam. Ante urna id pellentesque dignissim elit, vitae, pulvinar tempor, tempor. Aenean duis phasellus nunc, dignissim venenatis vel quam at blandit. Euismod, vulputate ultrices dignissim varius, est dapibus torquent vehicula scelerisque. Blandit adipiscing tellus, pulvinar tristique mauris, justo tellus ut habitasse.", 50m, 65m, 1, "Enim", "Blandit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Mollis", "Platea feugiat tellus tortor, tristique mi, mauris, rhoncus, venenatis ipsum. Tortor, pulvinar, massa, dapibus etiam eu urna iaculis condimentum pharetra. Ac, tortor ut vel, mollis ante volutpat eu, blandit etiam. Sed etiam lacus enim, massa, quam dolor, placerat id laoreet. Eros egestas est dolor, primis auctor, feugiat, donec nunc condimentum.", 66m, 17m, 1, "Blandit", "Leo." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Leo", "Facilisis quam tortor, placerat gravida magna amet nullam urna dignissim. Ante, massa, non, iaculis maximus congue pulvinar nunc nec, class. Hac tempor, ligula, malesuada porta nec laoreet mi lectus cursus. Suscipit maecenas efficitur volutpat, in, massa, nisi posuere, quam lectus. Arcu, laoreet vulputate nulla tincidunt finibus interdum, fringilla tristique auctor.", 23m, 64m, "Integer", "Pharetra." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nulla", "Feugiat, cursus augue sociosqu luctus, quis, taciti ligula, nibh, suscipit. Elementum nam varius, velit platea viverra orci, venenatis orci proin. Morbi feugiat, magna, inceptos at, aliquam pharetra volutpat commodo justo. Pulvinar et, purus quam, euismod, suspendisse vehicula mi congue amet. Risus sem, ultrices, id, himenaeos nisi quisque litora eget et.", 38m, 58m, "Ac", "Erat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff8504f-e274-4d9f-984b-df155739e516"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Quis", "Enim, varius lacus inceptos praesent id a urna dolor, metus. Vel, feugiat, finibus lorem in turpis conubia auctor, proin hac. Habitasse nisi laoreet, efficitur cras tellus, placerat facilisis ex felis. A varius ex, ultricies finibus fusce lobortis ligula at tempor. Pretium lorem, quam bibendum, dapibus venenatis himenaeos lacinia interdum, odio.", 48m, 49m, "Vestibulum", "Nullam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Convallis", "Nostra, tortor, viverra blandit quam, vel orci, bibendum condimentum quis. Interdum curabitur erat elit nibh, porttitor eleifend, at sagittis, amet. Nunc, volutpat platea est sed, hac in in, lobortis fusce. Sit arcu finibus, fermentum orci, vestibulum rhoncus, accumsan elit in. Condimentum mauris, eros eleifend, tempor cursus, aliquam torquent non, dignissim.", 23m, 35m, "Nec", "Ligula." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Aliquet", "Class ipsum sapien eu, leo, adipiscing vitae, neque ultricies pretium. Ultrices dignissim class in, amet lectus commodo varius porta, tellus. Rutrum ornare scelerisque primis interdum, diam feugiat, elit eu sagittis. Habitasse nisi, vitae, et quisque molestie nibh, urna at, quis. Massa, nisi eget commodo, litora nisi, curabitur volutpat, congue, mattis.", 47m, 21m, 1, "Rhoncus", "Nec." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nisi", "Neque, lacinia, condimentum nunc tortor platea sem sed facilisis porta. Primis est tempor, finibus morbi turpis quis, orci in lacinia. Ante per tellus, erat, pulvinar tincidunt nibh duis bibendum, congue. Quis, mi lacinia nibh taciti consequat quam diam laoreet, leo. Faucibus feugiat elit, aliquet maximus aenean consequat suspendisse urna tempor.", 3m, 44m, "Lacus", "Dictumst." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Donec", "Vitae, sociosqu mattis, posuere, venenatis ex, ornare auctor, porttitor, at. Vel, ultrices ultricies eget lacinia per amet auctor, volutpat elementum. Ante ultrices maecenas ac ullamcorper magna nulla pellentesque purus sodales. In ac, eleifend, proin ultricies semper ante vitae, duis mauris. Venenatis himenaeos vestibulum massa, per finibus, lacinia, lorem neque, congue.", 80m, 65m, 0, "Semper", "Mollis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21420154-8f18-4fb3-b745-60621cca5541"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nec", "Phasellus ornare volutpat, placerat luctus, lobortis mi nunc, mattis, finibus. Imperdiet nulla diam torquent finibus lobortis tristique urna, eu, nulla. Mi, suscipit ac nisi, platea cras pharetra posuere arcu congue. Platea inceptos accumsan ad interdum, placerat leo diam phasellus vestibulum. Consectetur lorem accumsan neque, placerat, non, consequat porttitor nulla, bibendum.", 47m, 12m, "Laoreet", "Nisl." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "In", "Nunc elementum euismod, tortor, tempor, tempor facilisis pretium molestie elit. Laoreet, porta, varius volutpat, aliquam tincidunt nibh, fermentum a taciti. Odio, dignissim proin varius, nibh, facilisis ligula, risus mi, volutpat. In iaculis id, rutrum ante rhoncus rhoncus, tempor, fusce ligula. Ex suscipit amet bibendum, nulla lacinia maximus odio, erat, interdum.", 76m, 3m, "Justo", "Venenatis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Justo", "Ac, feugiat, erat mollis efficitur eleifend, placerat, sed praesent id. Pharetra nec porttitor velit adipiscing feugiat vulputate vel, pulvinar, consectetur. Urna magna, phasellus lacinia euismod elementum nunc, consequat dolor, dapibus. Neque, molestie odio, aliquam egestas dictumst fermentum litora tempor, himenaeos. Nibh mauris, porta, nulla dignissim habitasse aptent imperdiet phasellus sociosqu.", 28m, 48m, "Rhoncus", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ultricies", "Viverra porttitor, rhoncus, ut lacinia ante leo, fusce interdum urna. Porttitor dui, quis vestibulum per bibendum, fringilla ad viverra ultricies. Feugiat, metus eu placerat, ultrices, condimentum dignissim sagittis ultrices iaculis. Nunc, himenaeos euismod in, varius, massa, praesent pellentesque curabitur odio. Convallis cursus, et malesuada ut nam auctor dictum sapien ultricies.", 44m, 80m, "Rhoncus", "Vel." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Facilisis", "Adipiscing eros egestas lorem felis eros, rhoncus, dolor ut facilisis. Litora aenean tellus finibus, interdum semper tortor, sed vel, est. Felis lorem pulvinar, bibendum enim lacinia, porttitor, sed, himenaeos molestie. Rhoncus, sem iaculis nisl fusce mattis, tortor mi lectus nibh. Gravida sem torquent volutpat, nisi, condimentum tincidunt proin ante amet.", 31m, 35m, 1, "Purus", "Finibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Porta", "Molestie sem maximus tellus velit integer auctor, proin quam non. Odio eu eros, litora placerat, amet maximus urna, magna luctus. Himenaeos felis eros sociosqu vel est aenean commodo lorem neque. Vitae magna, at, duis vestibulum sed, ante cursus, lobortis himenaeos. Sem, vehicula per euismod luctus, elementum a, at dui, fermentum.", 9m, 12m, "Tortor", "Taciti." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nostra", "Arcu efficitur suspendisse porttitor, lobortis gravida mauris, dictumst fames erat. Luctus, blandit, mauris luctus posuere molestie ut tincidunt nulla a. Aptent neque urna suscipit faucibus dictum ex et, enim sed. Scelerisque fringilla pretium consequat orci eu, auctor, ullamcorper vitae maximus. Vitae rutrum adipiscing erat, vel varius, porttitor, donec lectus, faucibus.", 74m, 30m, 0, "Tristique", "Semper." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Porta", "Quis, rhoncus ullamcorper feugiat, tristique sagittis conubia non, ultrices, leo. Magna pulvinar, risus quisque et, tellus, pulvinar nisi dui, cras. Cras viverra vivamus lorem mollis eleifend vestibulum, sem, neque quis. Finibus inceptos quam feugiat varius mauris, ligula, massa, sem, mollis. Sollicitudin donec cursus, lacus vel et vivamus libero dui, cras.", 9m, 10m, 0, "Sed", "Quis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("357cca07-da0f-4263-9575-9304ba791639"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ullamcorper", "Sagittis, in tellus, luctus consequat auctor, leo sem, egestas ligula. Elementum neque id ipsum litora laoreet elit, arcu, congue, laoreet. Eros, quisque mi, elit, litora scelerisque fusce dolor lacinia, dolor. Risus ultrices, taciti auctor, congue, volutpat varius, vulputate ac, vehicula. Sociosqu taciti integer torquent turpis rhoncus, praesent sagittis risus primis.", 2m, 82m, 0, "Tellus", "A." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Id", "Tellus rutrum nec sed ligula diam tortor, maximus urna, velit. Euismod eleifend quis, sit feugiat, cras commodo sed sollicitudin tortor. Morbi eros elementum non, massa mi laoreet nostra, donec pulvinar. Primis vivamus rhoncus, sollicitudin nunc, amet, dignissim ligula, varius volutpat. Euismod lectus praesent scelerisque commodo, finibus, vulputate non dolor sapien.", 75m, 87m, "Lectus", "Mattis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Pulvinar", "Consequat porttitor, rhoncus massa ac laoreet, leo dapibus dui, consectetur. Orci nisi arcu, suscipit phasellus non aptent eu, vel, cursus. Pharetra posuere, primis bibendum, etiam vestibulum efficitur fermentum nibh auctor. Suspendisse commodo, integer luctus ex, eros arcu fermentum nisi, vivamus. Gravida amet arcu nec, orci in, dictumst scelerisque at habitasse.", 65m, 80m, 0, "Dictum", "Ex." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Volutpat", "Lectus, luctus, sapien imperdiet praesent porttitor lacinia at leo non. Massa ipsum rhoncus class tempor gravida felis tellus, sed feugiat. Amet, eros, eros massa, nisl blandit, fringilla vel, odio placerat. Nec rhoncus auctor et dictum tristique lacus ornare magna dolor. Purus donec feugiat, aliquam ut enim sem varius, nullam eleifend.", 91m, 8m, 0, "Finibus", "Sapien." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Duis", "Odio ante diam inceptos fringilla rutrum luctus urna metus ex. Cursus elementum justo sem lobortis tellus tortor, placerat, semper pretium. Dolor erat etiam sollicitudin primis porta, euismod luctus, iaculis interdum. Bibendum, velit ac a nisi consectetur habitasse ornare pellentesque mauris. Cursus nisi, efficitur duis finibus, id, conubia in pulvinar, habitasse.", 53m, 64m, 1, "Facilisis", "Dignissim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Proin", "Mollis auctor adipiscing mi, mattis, semper euismod, pharetra aliquet suspendisse. Placerat orci varius, interdum est eleifend proin sociosqu posuere, at. Justo erat, maximus sociosqu egestas ornare diam bibendum, mi eros. Porta, euismod, laoreet, vel accumsan nunc, cras hac malesuada pretium. Diam felis ligula ligula, nibh bibendum phasellus ad lacus posuere.", 33m, 92m, 1, "Nostra", "Tempor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4158bf42-0721-4e06-9ebd-ddf682240f7a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory" },
                values: new object[] { "Placerat", "Magna rhoncus mi, lorem, vitae consequat ipsum fermentum mauris maximus. Ex laoreet donec eleifend fames sem, facilisis porta, gravida sem. Sem laoreet ex nibh, risus venenatis sagittis, eget dapibus mi. Cursus elit, laoreet et nibh himenaeos quam purus quisque blandit. Tincidunt ante, lectus volutpat lobortis maecenas praesent augue ornare vitae.", 11m, 36m, 1, "Platea" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Mattis", "Phasellus cras id, lacinia laoreet orci, enim dignissim ante, fames. Euismod quam, id metus sapien maecenas viverra enim condimentum consectetur. Tempor, volutpat, arcu, ad justo leo, elementum consequat urna, ac. Mollis consectetur semper pellentesque faucibus nec, sagittis, convallis nulla sed. Commodo, felis dapibus nulla, sem sollicitudin mauris in bibendum, congue.", 63m, 27m, 1, "Finibus", "Porta." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Proin", "Scelerisque vestibulum urna, elementum morbi sem, varius, orci primis habitasse. Praesent laoreet venenatis primis eros fringilla, convallis sit tellus ad. Metus mauris, sapien fermentum proin rutrum vestibulum, bibendum, magna, vel. Maecenas nulla, eu, sem sollicitudin sociosqu accumsan placerat, molestie fames. Facilisis et, habitasse purus posuere ullamcorper erat, dignissim pulvinar, massa.", 38m, 79m, "Porta", "In." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nunc", "Feugiat, justo sodales laoreet nibh, lectus, volutpat, pellentesque ipsum consequat. A, himenaeos elit, ex risus luctus, nulla, aenean massa massa. Eros, ornare integer sodales imperdiet egestas leo platea enim ultricies. Neque lacinia vehicula enim turpis leo luctus elementum vitae tristique. Phasellus sapien mauris, odio eleifend diam sed, dui elementum ac.", 53m, 69m, 0, "Ligula", "Tortor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Eu", "Bibendum sociosqu dapibus vel enim nec, sed, finibus, blandit, nunc. Risus eu, congue, aenean ligula dui, lacinia, amet ex vivamus. Proin sem tempus in, volutpat, auctor, luctus euismod odio, mi. Primis ante donec semper quam, ac, pharetra congue convallis arcu. Tristique placerat pretium tincidunt accumsan in, sed, eros ac arcu.", 4m, 48m, "Convallis", "Scelerisque." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Pellentesque", "Ex, porttitor tempus finibus primis nunc consequat urna, ac, dignissim. Pulvinar sodales semper euismod hendrerit dictum molestie pretium taciti morbi. Lorem sed, volutpat, facilisis nisi, faucibus bibendum cras non, tellus. Leo, tellus, maximus taciti litora integer dui, ad at est. Porta, integer lorem, nunc, porta maximus urna mauris lobortis facilisis.", 74m, 37m, "Gravida", "Et." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Eleifend", "Sociosqu luctus, congue habitasse commodo, faucibus ullamcorper ipsum ac erat. Viverra ultrices vivamus porttitor, placerat, volutpat sodales primis interdum, finibus. Porta erat lacinia, massa fringilla auctor, varius imperdiet finibus, euismod. Aptent arcu est volutpat, augue accumsan auctor ultrices litora fusce. Sociosqu fermentum leo, ut himenaeos mollis arcu, condimentum purus quisque.", 78m, 23m, "Justo", "Lobortis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Donec", "Enim quam, cursus, fusce dui, per magna urna, nibh leo. Mi, dolor, nisl dui sed, amet, elit tortor, lectus, condimentum. Interdum amet lorem, eros leo, sollicitudin pulvinar, condimentum tempus dolor. Porta morbi augue ultrices, volutpat nunc, litora egestas nec hac. Phasellus dolor, dignissim nisi, quis lacinia, dapibus neque, vel, tempus.", 65m, 74m, 1, "Eu", "Sem." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Vitae", "Varius etiam orci, suscipit finibus a quis nunc, auctor, nunc. Eros nec, eu venenatis ipsum dictumst rutrum himenaeos mollis lacus. Commodo, varius consequat sagittis, dolor faucibus malesuada elementum neque magna. Nullam rhoncus feugiat sociosqu interdum lectus aptent ullamcorper inceptos blandit. Finibus, ultricies interdum, non pharetra porta, elit eleifend, euismod accumsan.", 76m, 92m, "Nulla", "Ultrices." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Porttitor", "Facilisis faucibus volutpat, posuere, sagittis, neque habitasse arcu dictum amet. Ac est accumsan pulvinar, erat, fermentum imperdiet tortor dui hac. Neque inceptos viverra cras magna sit luctus id per libero. Nunc pharetra per mauris, ornare tempus feugiat, habitasse euismod odio. Id id, nec velit sollicitudin et amet sagittis urna, at.", 70m, 18m, "Lorem", "Ullamcorper." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53c7a9de-03b5-4482-8163-2d925ca7f3c5"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Rhoncus", "Consequat neque nunc, ac posuere suscipit leo malesuada et, cursus. Sem commodo mauris sodales nulla sociosqu semper lacinia, tortor consectetur. Rhoncus consequat sed vel purus inceptos lacinia in accumsan sollicitudin. Dui, mollis enim interdum, lacinia, mattis, rhoncus, phasellus consectetur mauris. Cras nibh libero porta, convallis tempor interdum leo pharetra varius.", 15m, 59m, "Arcu", "Rutrum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("543372da-be2f-4ef6-8496-98a8a075799c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Blandit", "Justo ligula, tempor tellus, aptent duis commodo nam litora aenean. Odio, euismod conubia commodo erat, vel, aliquam tellus, auctor fringilla. Diam at, lacinia vivamus leo, feugiat leo inceptos euismod laoreet. Class cursus ac, donec porta, sagittis nisl lectus quisque nibh. Est vehicula erat, sed, neque aliquet dignissim egestas auctor, euismod.", 91m, 68m, "Condimentum", "Blandit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Tempor", "Sodales orci, neque, dui, mi, libero ad finibus eu, maximus. Odio, vestibulum, consequat habitasse facilisis enim odio augue massa, risus. Ex, aenean lectus molestie sodales sed, mollis fusce eros maecenas. Quis magna vitae himenaeos euismod adipiscing a, auctor, feugiat habitasse. Pellentesque blandit, vel dui fringilla efficitur mattis, semper conubia malesuada.", 11m, 45m, 0, "In", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Phasellus", "Leo, hac adipiscing at leo feugiat odio, cursus a tellus. Aliquam vehicula fusce phasellus nulla primis tortor tempus sit leo. Rhoncus, congue, auctor cursus adipiscing dictumst risus sagittis et, imperdiet. Amet, eros nostra, suspendisse ipsum nulla orci, luctus, ultricies quis. Fermentum pretium vitae, suscipit condimentum egestas dui blandit, lectus class.", 38m, 13m, 1, "Sem", "In." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Pulvinar", "Erat ac dictum inceptos elit dui neque, laoreet maecenas venenatis. Lacinia litora efficitur cursus, enim, bibendum est porttitor amet eros. Dolor, massa, tellus posuere sagittis, aliquam vivamus blandit, consequat nisl. Libero at, malesuada arcu, nulla praesent ultrices, porta, class vitae. Duis ut euismod, bibendum nisl ipsum sapien eu, nibh ante.", 53m, 99m, "Condimentum", "Gravida." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Eros", "Neque nam tincidunt elit, vitae placerat porta, turpis quam tempus. Fringilla, cursus non, magna auctor erat sagittis justo volutpat, tristique. Arcu, sem, dictumst nunc quis, libero rutrum dignissim eleifend nisi. Pulvinar vel duis erat malesuada tellus euismod mattis, nisi, arcu. Leo efficitur sem, litora quam, tempor, tellus, massa, faucibus amet.", 46m, 86m, "Ligula", "Posuere." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Odio", "Consectetur risus sem phasellus leo, integer euismod non, vivamus pharetra. Eu mauris primis nostra, mattis purus ex himenaeos nec, mattis. Cursus, aptent tristique hac praesent consectetur eros bibendum, fusce ultricies. Porttitor vestibulum, nullam pretium sagittis, feugiat, phasellus a blandit, nibh. A sem ipsum amet commodo, consequat interdum, urna id elit.", 18m, 80m, "Velit", "Arcu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Porttitor", "Tincidunt velit placerat elementum eros, odio, condimentum orci, dui felis. Lorem odio placerat, dictum consectetur nec amet, laoreet, congue, morbi. Commodo, urna, faucibus sagittis, at nulla ante, dapibus leo volutpat. Velit nunc tristique scelerisque diam eros, donec dui auctor, ligula. Nam nibh, class suspendisse eros, feugiat, ut turpis ultricies ligula.", 84m, 62m, 1, "Sociosqu", "Iaculis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Phasellus", "Volutpat luctus, condimentum tincidunt laoreet, eu dapibus elit congue, neque. Eu ullamcorper eu, rhoncus massa congue magna, tempus pulvinar iaculis. Vulputate odio, ullamcorper fames velit tempor, feugiat, adipiscing taciti massa. Sodales orci nibh, tempor, maximus non rhoncus, posuere, aliquet a. Maximus varius, porta in platea eleifend, adipiscing pellentesque malesuada efficitur.", 83m, 38m, 0, "Vitae", "Varius." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ex", "Nostra, suspendisse dolor platea sagittis erat, ex inceptos augue erat. Inceptos orci a mollis ac, porta, lacinia, efficitur nisi hendrerit. Faucibus convallis ut class facilisis ad pretium egestas sem, sodales. Faucibus dignissim vel egestas rutrum porttitor, in, tristique primis posuere. Bibendum, eleifend, aliquet eleifend massa mattis tortor, posuere, lacinia inceptos.", 18m, 1m, "Mollis", "Orci." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Taciti", "Pretium ex lacus rutrum at, commodo sollicitudin orci facilisis ultricies. Fames condimentum odio hac lobortis amet, quam, tempor, mi ex. Ullamcorper proin auctor nec pulvinar ante, laoreet enim erat, orci. Ante consectetur mi nulla, nisi et, et nisl bibendum ultrices. Lectus faucibus suscipit nibh, ligula, ornare porttitor, nisl fringilla, enim.", 33m, 23m, 0, "Gravida", "Ultrices." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Facilisis", "Sapien porttitor, duis erat, a, donec rutrum urna, porta, magna. Eget neque in euismod, vestibulum ipsum aliquet himenaeos sagittis, hendrerit. Eu ex, ullamcorper cursus aliquam quis, sem, pellentesque blandit rhoncus. Hendrerit efficitur sodales morbi sollicitudin elit, leo erat, ac in. Blandit, ac ex, et ullamcorper quam, malesuada mi pulvinar scelerisque.", 75m, 3m, "Euismod", "Blandit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Euismod", "Habitasse arcu, et, ante, erat, litora fames ligula suspendisse massa. Odio, massa dolor, tortor, mauris auctor orci congue, lorem, ex. Laoreet fermentum eros, hendrerit ex, in, volutpat, pellentesque commodo, sodales. Volutpat, gravida odio, primis dignissim metus nisl pretium viverra in. Quisque eu habitasse facilisis dignissim eu, eleifend, scelerisque hendrerit nisi.", 95m, 72m, 1, "Imperdiet", "Nulla." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Elementum", "Maximus leo, tellus sit faucibus turpis volutpat felis proin fringilla. Vitae, sed curabitur lorem tortor luctus cras mattis ex sollicitudin. Augue lacinia, porttitor, libero sed elementum cursus tempus iaculis erat. Quam urna et, duis euismod, efficitur vestibulum quisque amet sapien. Et, inceptos leo, torquent purus tristique dui consequat pellentesque sagittis.", 28m, 53m, "Eros", "Vivamus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Mi", "Ornare ultrices, accumsan tellus, ligula dapibus elementum enim hendrerit gravida. Dui imperdiet arcu a, a in convallis nam sodales urna. Conubia inceptos donec blandit, mi varius at, taciti turpis maecenas. Viverra nostra, consequat nam blandit, varius hendrerit sit commodo egestas. Aptent nisi litora feugiat felis aliquam pharetra elit leo ac.", 26m, 25m, 1, "Posuere", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tempus", "Fusce nunc, lectus porta, eleifend primis rhoncus, sem faucibus cursus. In nisi molestie neque, enim, primis nisi, ligula leo, rhoncus. Laoreet non, at, posuere, feugiat quis, eget in mauris, et. Lobortis lacinia, condimentum auctor, ex, laoreet, ultrices sagittis at phasellus. Nisi, rhoncus, faucibus at, enim mattis, eu, vel, litora vulputate.", 12m, 24m, "Dui", "Rutrum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Turpis", "Mattis, magna etiam interdum donec iaculis auctor, lacinia ac, suspendisse. Vel, bibendum, fames nostra, quis, dolor erat morbi felis imperdiet. Mattis enim arcu, nisi, at, sagittis, ac lacus ornare primis. Posuere lacinia, ac, tortor, ante, commodo vestibulum, non, morbi vulputate. Quis praesent congue ligula, magna, justo eu, taciti posuere, integer.", 9m, 50m, "At", "Urna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("836bf6f7-71a6-485d-8514-455393908657"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lectus", "Suspendisse ultrices litora elit, pellentesque pharetra augue feugiat cursus morbi. Metus sociosqu magna, fringilla, dolor, egestas in, tempus phasellus accumsan. Volutpat egestas torquent posuere, aenean ex efficitur ligula, tortor, at. Suspendisse magna lacinia a risus vestibulum in, vel vel, cursus. Nunc, dui tristique molestie sed, auctor tincidunt lacinia class vulputate.", 47m, 49m, 1, "Duis", "Id." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Eu", "In, vehicula enim, finibus euismod, ad sollicitudin aenean torquent urna. Ultrices, duis interdum, eros, porta, auctor sed id sed, sagittis. At, erat luctus, odio lectus, habitasse eros, nam pharetra urna. Sem at eros, iaculis id, efficitur integer morbi tellus per. Risus adipiscing nisl commodo, suscipit etiam elit, vulputate rutrum per.", 26m, 8m, "Sem", "Aliquet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dignissim", "Urna pharetra litora erat, ligula blandit, neque duis euismod taciti. Condimentum ex, blandit, mi lacinia, lobortis magna, quam, pretium eros. Diam feugiat eleifend, velit bibendum, tellus vel euismod ultrices, lacinia. Ante, in, dolor, sed amet eleifend, finibus, congue etiam vel. Tempor, luctus varius orci nulla nunc in, fringilla, at, tristique.", 64m, 0m, 0, "Inceptos", "Semper." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Felis", "Mattis semper eget scelerisque congue sit interdum, mauris nullam placerat. Magna, interdum, quis scelerisque at mauris, ornare aliquam congue, interdum. Molestie volutpat, ligula orci, laoreet, fringilla ad magna, lacinia, at. Venenatis mollis est lorem himenaeos conubia varius, lectus, enim lacinia. Nec ac, nunc torquent placerat, pulvinar, ante, ut rutrum est.", 84m, 75m, 0, "Est", "Varius." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ac", "Ad dictum donec laoreet, sodales suspendisse eu, dui duis bibendum. Congue elementum vivamus elit porttitor sollicitudin tempor massa orci, praesent. Nunc, amet velit dui dolor, bibendum, porttitor ornare maecenas primis. Placerat, leo, ac, non, efficitur eget amet nisi malesuada aliquet. Id, vel, quis, nulla euismod lobortis enim habitasse proin posuere.", 70m, 79m, 1, "Tempor", "Tellus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dictumst", "Vel laoreet et litora himenaeos nunc mattis, placerat enim, sodales. Placerat volutpat, orci, finibus laoreet vivamus sociosqu tortor, hac amet. Cursus lectus sapien a, nunc porta, sagittis, dignissim phasellus posuere. Tempus praesent maecenas ligula commodo, orci, nulla amet, proin sagittis. Vitae, turpis habitasse eu mattis, amet nisi ante nulla convallis.", 46m, 68m, "Enim", "Sociosqu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Consectetur", "Torquent aenean urna eu felis tortor id, dignissim sit porttitor. Dictum ultrices, mauris faucibus sed in, varius, a, vestibulum, tortor. Ligula suspendisse non venenatis arcu, ante, sem urna molestie viverra. Turpis eget elit, dui fames mattis, enim quam, ex, integer. Nulla, aptent sollicitudin nunc vehicula inceptos lacinia nunc, eleifend mi.", 27m, 36m, 0, "Laoreet", "Eleifend." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("962d2024-995d-4165-89c9-55e15d2176e3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory" },
                values: new object[] { "Porta", "Morbi eleifend quis, commodo, lobortis euismod ante, non, diam litora. Velit commodo, sagittis, ultrices morbi ultricies suspendisse varius neque aenean. Nulla, id, pulvinar, consectetur dictum odio, auctor, rhoncus ultrices, torquent. Diam malesuada orci class vel tellus, eros id, feugiat, lorem. Cras sem, fringilla, porta rhoncus, semper amet sem aptent amet.", 28m, 39m, "Vestibulum" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dictumst", "Id, egestas ligula, volutpat, pretium bibendum dictum efficitur velit fusce. Litora maximus dictum rutrum iaculis purus suspendisse convallis neque turpis. Arcu, ultrices, auctor, ac ad etiam quis, ex imperdiet et. Curabitur maecenas facilisis erat, sed suspendisse dignissim etiam morbi phasellus. Mollis quis arcu rutrum laoreet lorem, orci sed, mi mi.", 66m, 56m, "Tempus", "Sociosqu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Elementum", "Eleifend vehicula imperdiet a, fermentum nisi sit porta, laoreet, porta. Platea lectus, blandit mattis ullamcorper laoreet vel, dui nostra, luctus. Venenatis vulputate vitae felis quam, placerat, nec tristique porta erat. Tincidunt mi ante dolor, mollis vitae erat, fames fusce justo. Class elit laoreet neque, laoreet, hendrerit etiam quis, non commodo.", 58m, 83m, 0, "Amet", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Accumsan", "Ipsum mi elit tellus, commodo, purus arcu dignissim urna laoreet. Commodo tellus, mi ante mauris, sit donec ultrices volutpat congue. Ultricies leo ut volutpat, lectus, at, purus morbi neque taciti. Tortor elit, taciti tellus, donec ultrices, cras a tortor, metus. Mi, iaculis tortor nisi, tellus mauris a, fames finibus, purus.", 62m, 91m, 0, "Lorem", "Nulla." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Torquent", "Fringilla quis urna euismod tortor, varius ut praesent proin turpis. Arcu, eros, maximus ornare eleifend, a mattis, aliquam mollis luctus. Torquent eget vel, tellus lacus porta, ac, volutpat, curabitur ligula. Vestibulum primis ultrices amet per nibh, quis, vivamus taciti dui. Phasellus a quis, commodo risus sodales leo erat, et congue.", 11m, 87m, 0, "Luctus", "Habitasse." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dapibus", "Auctor fusce primis orci eros, sagittis finibus auctor, est dapibus. Enim, feugiat, enim hendrerit at, sed aliquam ultrices non, condimentum. Arcu blandit, ipsum orci quis consequat rhoncus, efficitur nunc quam. Id, pellentesque lorem, commodo massa consectetur vitae mi, vestibulum, orci. Ligula, eleifend, porttitor, arcu, tempus nec dolor, id, sem at.", 22m, 69m, 1, "Dignissim", "A." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Sit", "Urna, integer non ad nullam ligula mi, ex a, lectus. Litora hac at purus dictum ultrices, non, nisl etiam ullamcorper. Neque, risus amet, taciti litora ac, porttitor, primis dui sit. Dictumst porta rutrum torquent imperdiet purus neque, euismod lobortis varius. Elit, porta, adipiscing in, dapibus rhoncus, aptent congue iaculis rhoncus.", 88m, 76m, 0, "Lectus", "Orci." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Blandit", "Sit ante gravida fringilla, inceptos rutrum urna, sed, eros mauris. Enim nulla erat, sodales condimentum pulvinar, integer ex urna aliquet. Dignissim viverra dolor finibus laoreet habitasse pulvinar magna, tempus ipsum. Non, quam semper commodo dui viverra etiam luctus, mi diam. Consectetur taciti lacinia, lorem congue sed, laoreet felis tellus, mauris.", 1m, 1m, 0, "Sit", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Vel", "Dignissim adipiscing nibh, consectetur ante nunc, nullam cursus, risus luctus. Tincidunt vehicula varius, lectus, et accumsan lacinia dolor, sem fames. Curabitur dui duis cursus, erat, bibendum fames nibh, eros, porttitor. Imperdiet metus luctus a, nec, ad quis, at, commodo mi. Cras sodales tincidunt phasellus purus dapibus fermentum adipiscing tellus sem.", 12m, 79m, "Dictum", "Iaculis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Aptent", "Vel posuere leo nibh, interdum vivamus lacus non dignissim orci. Donec eu, nostra, laoreet litora urna, sit porttitor mattis rutrum. Congue rhoncus, porta porttitor consequat odio, interdum convallis suscipit himenaeos. Enim faucibus porttitor, ante, a, pretium praesent tempus convallis morbi. Fermentum iaculis elit proin luctus, feugiat sit auctor, quis quisque.", 13m, 76m, "Pharetra", "Orci." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adaa5968-bab8-433d-abc6-217d49fa3395"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Mauris", "Leo a magna, mollis eros nostra, mattis sagittis, luctus ante. Cursus, sit leo, torquent dapibus hac volutpat, massa, sed, diam. Mauris vitae, platea nullam euismod eget fermentum hac hendrerit ad. Ullamcorper nisi egestas odio, nunc, vulputate aptent sed pulvinar massa. Nibh, fringilla congue, mollis pulvinar, lacinia, sem sed, rhoncus, bibendum.", 65m, 6m, 0, "Iaculis", "Urna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lorem", "Posuere nec, libero nisl eget feugiat in, mauris magna, quisque. Dictum magna, ut torquent pulvinar sociosqu dapibus pretium enim, ultrices. Laoreet est varius luctus habitasse mi dapibus arcu, sodales sollicitudin. Sapien dui interdum elit, vitae, fames dictum commodo, curabitur enim. Urna, dolor, ex, suspendisse eros suscipit aliquet odio, sed, platea.", 53m, 42m, 0, "Eu", "Urna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Ultrices tristique nunc sollicitudin iaculis etiam pulvinar rutrum ex venenatis. Lorem vivamus suspendisse lectus, maximus aliquam dolor, felis ipsum euismod. Maecenas praesent elit, nisl mi, mauris, tempor, mattis posuere dapibus. Integer quisque torquent vestibulum ultrices rutrum per fames etiam ac. Lectus quis, quam, sagittis erat, fringilla blandit, dignissim convallis ligula.", 72m, 65m, "Himenaeos", "In." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tempor", "Interdum, tortor, at, torquent etiam pulvinar, fames elit euismod dolor. Tristique ultricies sapien magna, quam, orci, fermentum adipiscing nunc donec. Suspendisse turpis dui, sapien venenatis nulla eu sit ac ultricies. Eu viverra vestibulum habitasse posuere venenatis nulla a, maecenas nostra. In, eleifend quisque quam, maximus et, efficitur sodales torquent lobortis.", 82m, 38m, "Porttitor", "Luctus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nisi", "Erat, ullamcorper lobortis vivamus fames nam dui, luctus nunc, ut. Quis, sem pellentesque consequat dolor, phasellus varius enim, habitasse eget. Auctor magna tempus ultrices eros lacinia, at, class nibh fringilla. Aptent eros, maximus mi, et duis vitae dictumst tristique placerat. Arcu lectus et, felis vehicula non, semper porttitor, dignissim nec.", 34m, 4m, "Quisque", "Posuere." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nunc", "Fames nec, justo imperdiet urna, id, mi, cras arcu, felis. Mollis massa, feugiat, lobortis per euismod amet suspendisse class felis. Congue pulvinar hendrerit non dictumst fringilla, nunc, sagittis, laoreet lectus. Ac, quis, inceptos pharetra odio nam morbi finibus nibh luctus. Tempus massa, porta, auctor, finibus, suscipit nibh, nulla, egestas volutpat.", 60m, 80m, 0, "Mauris", "Et." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"),
                columns: new[] { "Category", "Description", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Aliquam", "Mauris, pulvinar, pellentesque sem, eros, vulputate scelerisque curabitur quam, in. Porta, rutrum sagittis volutpat vel, nec nibh ut tempus lectus. Ex, luctus, mollis non a inceptos proin odio vivamus arcu. Nec ac, massa, fringilla enim, mi litora blandit, malesuada eros. Nibh, tortor, sollicitudin fames lorem, arcu condimentum dolor, orci, mauris.", 37m, 1, "Quam", "Maximus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Porttitor", "Eleifend suspendisse hac pulvinar, sapien leo, a interdum sit aptent. Hac aenean eget suspendisse lacinia quam vulputate at, arcu, vivamus. Eleifend blandit, sit suspendisse volutpat risus nam scelerisque dolor, magna. Mattis, himenaeos dolor, et, lacinia mattis congue morbi gravida tellus. Eros, in, venenatis primis ante, nulla, odio orci, nunc vestibulum.", 69m, 58m, 1, "Venenatis", "Ipsum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba3c9243-5390-488e-b598-2779fd398da8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sit", "Arcu, tristique porta ac scelerisque non, etiam efficitur posuere, interdum. Vestibulum dolor porta, erat, tempus at conubia lacinia ante ante. Posuere, luctus donec integer accumsan torquent aliquet feugiat, proin quis. Euismod porttitor, ipsum dolor sodales mattis elit, neque, ligula non. Interdum, eros, sociosqu tempus purus quam, diam magna eros mauris.", 83m, 84m, "Tortor", "Pulvinar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Diam", "Leo porta nisi orci ultrices, nullam odio, erat a phasellus. Eros, praesent eget ligula risus mi elit, lacinia non, ex. Et, tortor per nunc fringilla, bibendum, consequat mauris, a, morbi. Posuere, vivamus nostra, tempus porta justo molestie nec dolor, quam. Lacus inceptos condimentum semper nulla, bibendum vel, nisl enim rhoncus.", 39m, 61m, 0, "Elit", "Magna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sit", "Eros, maximus ultricies urna placerat, amet luctus erat turpis facilisis. Suspendisse mi, eleifend semper sem, mattis, etiam laoreet, erat eleifend. Iaculis sapien vitae, ultricies non, ad porta, ac, tortor pretium. Molestie pulvinar fringilla, varius himenaeos egestas nam inceptos luctus, semper. Accumsan phasellus pretium duis in, ultrices, fames facilisis fringilla justo.", 91m, 62m, "Suscipit", "Est." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Per", "Feugiat, massa mi, congue magna at ultrices magna, ligula at. Praesent lacus interdum vehicula erat bibendum interdum, tempor, quis luctus. Sagittis dictum amet, mollis nisl varius, odio vivamus vulputate inceptos. Pulvinar, leo, odio, mauris, non, phasellus class vestibulum enim tortor. Massa, et blandit, id amet ac a mollis euismod lacinia.", 13m, 36m, 1, "Accumsan", "Sollicitudin." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dignissim", "Lectus, ligula ullamcorper cras justo vel proin ad maecenas commodo. Lacinia, proin turpis pellentesque eleifend primis rutrum lorem est nullam. Fermentum eleifend, varius ornare per finibus neque, enim, tristique fusce. Suspendisse lacinia eleifend non, in, orci varius, dictum auctor est. Cras blandit egestas sed, in elit, dictum odio, orci mauris.", 75m, 66m, "Quam", "Dignissim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dui", "Hac ex, litora amet, feugiat, erat, nostra, diam venenatis neque. A posuere, suspendisse cras fusce congue in hendrerit diam dapibus. Cursus, quisque ad elementum nec, tincidunt nec sociosqu ex, eleifend. Dictum laoreet ante, blandit conubia arcu risus mi, tempus tellus. Eros, class sit litora blandit, cursus, dui, urna elit, libero.", 18m, 49m, 1, "Erat", "Eros." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Rutrum", "Sed nibh, cursus ullamcorper ad mauris sodales ornare condimentum massa. Efficitur porttitor, eleifend, libero est etiam massa, ultricies in, metus. Dapibus platea curabitur imperdiet lacinia, pharetra duis neque, sapien consequat. Mauris, arcu massa, class aenean auctor, vivamus ipsum aptent nulla. Suscipit convallis maximus quis porta, donec nunc, faucibus taciti vivamus.", 5m, 71m, "Primis", "Congue." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Suscipit", "Quam vel taciti feugiat, quis, ex curabitur ut ac, sed. Tincidunt sodales nam neque eros, magna, ligula ullamcorper ipsum et. Tortor viverra risus integer rhoncus, eleifend eros, lacinia, dolor quam. Libero praesent cursus vitae leo ipsum massa, viverra in, donec. Quam auctor dictumst fringilla, facilisis dolor, tortor, id, volutpat, ullamcorper.", 35m, 87m, "Hac", "Egestas." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Porttitor", "Dictumst sagittis inceptos a posuere, dui interdum lectus, ullamcorper erat. Id vel, laoreet gravida eros vitae, rhoncus nisl lacus consectetur. In, class placerat adipiscing orci, ultrices, platea porttitor suspendisse sodales. Nibh elit eros interdum, vitae orci etiam tellus, pulvinar, libero. Primis ligula in, placerat, mattis, posuere ex non urna litora.", 21m, 75m, 1, "Imperdiet", "Arcu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Nibh, sapien vestibulum, aliquet ad metus ullamcorper finibus turpis id. Sed, quis iaculis sit dui finibus nec primis fusce cras. Bibendum luctus, maximus diam eget urna consequat ipsum magna aptent. Orci, condimentum fusce dui velit ac, ac quisque vitae tristique. Lectus dictumst finibus, ex tempor pretium tortor hac etiam ad.", 54m, 67m, "Laoreet", "Eros." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Semper", "Fusce auctor, pharetra efficitur nunc, himenaeos porta felis phasellus turpis. Et, dictum maximus morbi platea quis arcu, duis efficitur quisque. Non, sit augue adipiscing ultricies accumsan hendrerit ligula, lectus, ac. Eros ante, primis quisque vitae lorem elementum ullamcorper accumsan nulla. Curabitur augue bibendum, mattis, euismod per interdum vulputate conubia interdum.", 63m, 77m, 0, "Posuere", "Aliquet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Varius", "Nibh, tortor, nec, feugiat, vitae, fermentum varius mi fringilla, aptent. Ad in, massa ipsum sem, turpis nisl mi, vestibulum non. Torquent adipiscing bibendum eleifend interdum enim, egestas nunc sit massa. Vel proin tortor neque, dictum vitae suscipit aenean ligula cursus. Condimentum erat, porta vehicula mattis, commodo, blandit, fames hac accumsan.", 15m, 66m, 0, "Porttitor", "Turpis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Placerat", "Arcu purus faucibus nec, ornare ac, praesent ultrices, feugiat augue. Maximus in tellus, ligula nec tincidunt auctor sem, adipiscing ut. Porttitor mauris, quisque semper id velit condimentum sociosqu mi, a. Mi consequat id elit sagittis, ac facilisis eros ipsum elementum. Maecenas nibh, quis arcu vitae, bibendum auctor, varius, aliquam sagittis.", 30m, 96m, "Euismod", "Conubia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Placerat", "Volutpat, commodo, in, fames euismod, varius, lorem dapibus posuere platea. Tempus fames orci, at, sodales sed ultricies duis sit nibh. Vehicula elementum lacinia mi, velit dui posuere, quam, lacus ante. Habitasse lorem, odio, blandit, tortor, a vulputate dolor congue, condimentum. Maecenas hendrerit odio vehicula sagittis, feugiat nam efficitur quisque in.", 50m, 70m, "Mattis", "Eleifend." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Euismod", "Sem, placerat, ac id, efficitur torquent vitae consectetur non, quis. Tempor vitae, bibendum, ac aenean aliquam ex, a, tristique justo. Rhoncus, euismod maximus quam, in aliquam laoreet, porta lectus, luctus. Erat, massa feugiat, venenatis at arcu, tempor, primis turpis eget. Gravida faucibus rhoncus, arcu, sociosqu feugiat, sollicitudin hac ligula cursus.", 67m, 61m, "Lacinia", "Luctus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tempor", "Lectus rutrum tristique tempor id, nullam lacus arcu eros, mauris. Nisl nulla hac neque, sem, cras posuere, ac, primis vestibulum. Elit, diam vulputate quisque nec nullam ad ex bibendum vitae. Cras vitae elit ac tincidunt ultrices volutpat eleifend, praesent himenaeos. Mattis mauris, mollis lectus pulvinar, congue nisl sagittis, a, luctus.", 9m, 22m, "Interdum", "Bibendum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nullam", "Neque, sed vel, platea vulputate lorem, leo, velit tristique ad. Quis massa semper interdum condimentum ex cras fusce volutpat hendrerit. Placerat euismod vehicula pellentesque sapien arcu mi dictumst luctus, diam. Maecenas lacinia, mattis, mi fringilla, non, odio, sem, libero placerat. Amet, bibendum, malesuada ex, libero lacinia primis blandit, sit erat.", 29m, 49m, 1, "A", "Rhoncus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f19d67-4312-431c-a3f9-1a76d5306820"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nam", "Varius fermentum semper nam sodales porttitor, vel, interdum, pellentesque molestie. Pulvinar mi torquent auctor, litora primis a congue gravida eros. Quis habitasse tristique phasellus lacinia in, ultrices, congue massa consectetur. Donec eu enim, blandit, orci, cras auctor sem, ac, leo. Sodales vehicula egestas vestibulum, tempor, mi eu, elementum eleifend eros.", 37m, 56m, "Sem", "Consequat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mauris", "Lorem mollis eleifend mi taciti phasellus gravida leo pulvinar, cursus. Quam quam, erat dui ac blandit, et neque venenatis lectus. Etiam fermentum eget magna viverra vulputate vel, feugiat dolor rhoncus. Urna id, dictum lacinia, auctor, lacus tortor, euismod, quam sem. Vestibulum massa ut ultricies egestas magna, cursus, ac conubia suspendisse.", 25m, 29m, "Massa", "Accumsan." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ullamcorper", "Sed posuere iaculis egestas quam, id amet, interdum congue, cursus. Quis, vestibulum neque, posuere, neque ipsum risus leo, lacus adipiscing. Rhoncus, in, hendrerit nullam vitae, adipiscing facilisis porta feugiat praesent. Maecenas porttitor interdum vitae nulla posuere, hendrerit placerat nisi scelerisque. Tincidunt ex, suscipit vestibulum, fermentum sed, elit, varius felis vel.", 23m, 25m, "Ultricies", "Per." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ultrices", "A, eros condimentum magna est class arcu, at, cursus vel. Dui, dictumst iaculis ad nibh, maximus vitae augue porttitor, dolor. Pharetra porta inceptos tincidunt ex leo, non, platea elit duis. Ac tellus, felis ut condimentum torquent blandit, et tempor, ad. Ultrices, nec, rhoncus, hendrerit fringilla, ante, primis urna luctus nibh.", 21m, 77m, "Odio", "Finibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Id", "Nostra, congue, posuere, massa et tristique consectetur in, ultrices, rutrum. Malesuada nunc egestas vulputate magna, ligula vitae, tellus erat mattis. Commodo cursus orci, felis quisque sem, tellus pretium habitasse fringilla. Laoreet cursus facilisis cras porta, aptent non leo, commodo tortor. Mollis dolor, eget neque, purus nibh justo laoreet, massa, euismod.", 25m, 54m, 0, "Et", "Ornare." });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("057912aa-1fee-42ef-ac7a-1fc00873f500"),
                column: "ProductId",
                value: new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("05935a3f-9210-4e21-ab3f-7a08662f0960"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("0b25a43d-8674-48bb-bb37-33c5868cc6bf"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("0ce1f781-ba3b-4353-9d2d-ea4fc3bff138"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("13c5e19c-8fec-46c6-a5b0-bd9a071727e6"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("167b01aa-f3a2-4e92-98f8-15285397c324"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("16d834c4-899e-4385-a5c5-7ee20a866156"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("19df2e7d-b6b1-4279-865c-c3cb6eef469c"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("1c712568-3924-496e-bd2b-e90e273bdf77"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("20de9a89-a7af-457c-a77d-5525f7967e71"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("22c529e3-c0cf-4dea-b975-81f33f1344b2"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("27f9f8c7-445a-4c15-8f9a-c210e9d0498d"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("29326627-aeb0-4ef2-8df3-50afa9958b6b"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("29f51c20-f78d-44ff-b1ca-7a2dfd530c37"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("3efab290-b8a5-4786-a245-82b1cedcaaa9"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("3f895757-60c2-47b5-b970-8a7b6d2f21bf"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("41a465a9-a9ee-4074-9e8f-eaa9bf9b162b"),
                column: "ProductId",
                value: new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("4281874c-0163-4a72-b7dc-bd5c2ae99d9c"),
                column: "ProductId",
                value: new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("52741742-e69e-4e6f-aadd-2c7c2a1bdce5"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("52b62791-a93f-492e-bf2d-dacf15084c91"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("541d3c16-c3cf-424a-81ed-1e78e871834c"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("5ddcc969-219c-4a7b-9f81-cee0fb595a94"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6036aa7e-32f4-462a-9daf-d36a60d29f96"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6364170f-fe82-47eb-95f5-860fe13c01d8"),
                column: "ProductId",
                value: new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("65a5c17e-1da1-479d-99b1-85b25ac6d7f8"),
                column: "ProductId",
                value: new Guid("0ff8504f-e274-4d9f-984b-df155739e516"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6bf27763-d7fc-4893-96e2-d844a2356432"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("543372da-be2f-4ef6-8496-98a8a075799c"), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("71e1abf5-dba4-4a14-96a7-26ab5ff08ae3"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("74faf6c6-2d55-4423-9816-49f2c0e84a02"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("0ff8504f-e274-4d9f-984b-df155739e516"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("7f65eba2-8e80-4619-aacc-d5b2fdbe37cf"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("812663ee-abb0-4ffa-b869-dfd39087bfb6"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("8288865c-9838-46ca-aabc-a09e26628e49"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("846a7c4f-b232-4a0f-a4b4-e3dc3c36fd4a"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("85bde701-fb9d-4046-9a3e-9b9935657855"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("91892802-c837-47a1-8f34-64cf30a26d8d"),
                column: "ProductId",
                value: new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("926e452a-8a75-4aec-ba93-6fe3b8312d9b"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"), new Guid("6c8019dc-0237-484d-80dc-452428bce548") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a680a97b-eea7-417b-a3f2-6d2eaf01bec4"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a7b1da80-5a54-4d50-a0a0-13360bb50b63"),
                column: "ProductId",
                value: new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"));

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a96f73c9-1a70-4355-bd13-ee8cd0b2ae98"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("b8c76a8e-bb51-4398-ace7-b52fde7de3e5"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("357cca07-da0f-4263-9575-9304ba791639"), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("c2ab942e-060c-43a0-af48-73d80b94cb03"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("c3874b20-25ff-4ce1-a9de-5330f8bdf89b"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("cbf6d242-6f27-4c36-bd3d-075b6c041229"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("ce8e41b9-03ba-430d-94f5-486658c7fdc8"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("e03e356a-90ec-411d-94f2-64a96123c72f"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("e304a5d2-a1a5-4e5a-b39e-2b833bcde4e9"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("0ff8504f-e274-4d9f-984b-df155739e516"), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f0652b4f-a6cb-482e-9183-a331198dac04"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f3f84eba-6811-4212-b5a0-a2cd63065214"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f86e9a91-7df3-4fcb-9e35-83d33840b92e"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f9d55e34-a009-403d-a97b-e9ea438b37d7"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") });

            migrationBuilder.UpdateData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("fc14503a-a7d9-4872-8e04-97c51e8841dc"),
                columns: new[] { "ProductId", "UserId" },
                values: new object[] { new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Mauris pellentesque rhoncus, litora at, purus maecenas auctor, ullamcorper vitae. Dictumst feugiat, donec tincidunt non, taciti nec et, velit dignissim. Sed fusce posuere, molestie id at sed, ex, vel, cras. Facilisis volutpat lacinia etiam conubia et, blandit, dui eros, congue. Nostra, feugiat, volutpat maecenas blandit tempus quam nunc elementum eleifend.", "Ullamcorper.", "Quam sodales" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Mi, vitae ornare dui leo consectetur volutpat, convallis tempor, vestibulum. Feugiat euismod, urna mattis dignissim nullam id, quis, amet risus. Ac egestas dignissim ad tempor maecenas feugiat suscipit mattis augue. Nunc lorem sed, auctor nam quam, ornare tempor interdum, ultricies. Facilisis habitasse erat in, volutpat, tortor, a vel, bibendum urna.", "Tortor.", "Varius ultrices" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Arcu in nulla lacinia, velit massa in, rutrum porta, aliquet. Nisl bibendum facilisis lacinia, pulvinar, dictumst semper nec, dui, litora. Tempor, erat ligula viverra erat, cras class primis inceptos enim. Mi urna, platea varius, mattis, hendrerit maecenas blandit inceptos quisque. Ad vehicula massa ex, ante, nullam vitae, molestie etiam vel.", "Pharetra.", "Lorem eleifend" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Vitae ligula, volutpat ac eget vehicula tellus, sollicitudin fringilla, suscipit. Facilisis nibh vitae aptent iaculis class nisi, diam orci purus. Porttitor blandit augue scelerisque nisl donec varius arcu, non porta. At, imperdiet fusce elementum ipsum a porttitor, augue sodales platea. Mollis nec, himenaeos dolor, tellus, quam, adipiscing lorem, nunc nisi.", "Accumsan.", "Pulvinar eros" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Sollicitudin feugiat leo, condimentum lacinia phasellus ornare vehicula vel, morbi. Ultrices, nunc convallis eu quis et, hendrerit finibus, augue accumsan. Conubia leo consequat eu praesent tempus curabitur at, mi, sagittis. A aptent tempus scelerisque sem sapien lacinia, mattis volutpat, vestibulum. Urna in, placerat, convallis sollicitudin auctor sodales urna, integer consequat.", "Porta.", "Orci interdum" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Leo tristique gravida tortor, mauris fringilla pulvinar, dui, sapien ut. Sit mattis fames euismod, aenean ut eros cursus, semper porta. Faucibus augue quam, quisque platea cursus consectetur maximus sagittis porttitor. Auctor cursus, nulla, commodo hac turpis sed, aptent bibendum sollicitudin. Suscipit at, morbi sodales ad cursus finibus malesuada dolor, feugiat.", "Interdum.", "Placerat dictum" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Ornare massa, nostra, luctus id, mi mattis nunc sit quam. Pellentesque vitae pulvinar, fermentum sollicitudin mauris, eleifend vestibulum, orci augue. Pretium quam, nullam magna posuere, ad elit luctus fusce euismod. Scelerisque magna amet odio, rhoncus, feugiat varius vivamus rhoncus adipiscing. Ut taciti pellentesque odio ornare adipiscing massa, fermentum eleifend, et.", "Laoreet.", "Dolor egestas" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Lectus, platea tortor leo, elit, scelerisque aliquet vehicula vel accumsan. Nam quisque risus quam, fringilla mattis laoreet duis ex nec. Etiam ad velit nunc, nulla, dolor enim, et, dapibus nibh. Elementum risus tempus sagittis viverra dictum porttitor per auctor velit. Hac imperdiet auctor, diam velit lacinia, et, lacus fermentum dapibus.", "Commodo.", "Vitae dui" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Porttitor erat turpis leo volutpat in pulvinar, convallis pharetra ultricies. Tortor lacinia lectus, cursus in, pulvinar, orci dolor odio euismod. Pretium ante, bibendum egestas ad gravida sapien conubia mauris, augue. Habitasse sapien adipiscing interdum, rhoncus, consectetur varius posuere, odio, purus. Sem vestibulum hac a cursus adipiscing finibus, rhoncus, sodales dui.", "Ligula.", "Odio tellus" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Tortor, blandit class congue dictum cras elit, id cursus dui. Ex morbi cras ultrices elit, luctus, sit neque, quis, fames. Porta, a, nullam lacinia arcu primis laoreet lectus, magna nibh. Integer tristique turpis at in, taciti sapien fringilla, ex, vitae. Suscipit faucibus praesent feugiat, neque, convallis massa velit suspendisse venenatis.", "Tortor.", "Fringilla sem" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "faucibus@massa.com", "Blandit placerat", "Et", "Taciti", "Luctus" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "neque@ligula.com", "Pulvinar viverra", "Laoreet", "Feugiat", "Iaculis" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "scelerisque@tortor.com", "Porta maecenas", "Fringilla", "Sem", "Habitasse" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6c8019dc-0237-484d-80dc-452428bce548"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "augue@mollis.com", "Magna nullam", "Suscipit", "Id", "Fermentum" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "consequat@amet.com", "Condimentum rutrum", "Dictumst", "Leo", "Tempus" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "ligula@posuere.com", "Quis tristique", "Ligula", "Conubia", "Sed" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "convallis@donec.com", "Rhoncus sed", "Erat", "Ex", "Elit" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("df749524-0c6b-416d-94c2-398f8b62e92d"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "ante@lobortis.com", "Vel eleifend", "Pretium", "Dui", "Litora" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "quis@ex.com", "Rutrum rhoncus", "At", "Euismod", "Dictum" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f70f7a45-8539-4082-a181-9705c2b5c505"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "laoreet@praesent.com", "Aptent tortor", "Tempor", "Nam", "Bibendum" });
        }
    }
}
