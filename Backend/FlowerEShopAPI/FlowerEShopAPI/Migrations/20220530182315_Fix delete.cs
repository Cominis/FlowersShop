using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowerEShopAPI.Migrations
{
    public partial class Fixdelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Et", "Mi, finibus vel vivamus gravida leo, consectetur eros cursus sollicitudin. Iaculis dolor, aenean tellus, bibendum, lacinia mi, ex, auctor, non. Ex, litora risus id, quisque viverra nunc, nisi quam primis. Dolor dapibus justo elit sodales eleifend placerat blandit vel, condimentum. Rutrum eros, finibus, orci dolor, pretium vestibulum, integer hendrerit conubia.", 52m, 88m, 1, "Bibendum", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("036526be-993c-4d69-ba77-42f606d587cb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Consectetur", "Dignissim fringilla lorem libero luctus, quam, dolor, platea porttitor, fames. Interdum vivamus donec accumsan facilisis blandit, venenatis libero scelerisque non. Litora mauris suspendisse aliquet nibh sapien iaculis ac maecenas nec. Quisque mi auctor, dolor, porttitor, euismod tristique class sapien porta. Luctus ultrices consequat vehicula pretium quam, lacinia sollicitudin metus porta.", 89m, 29m, "Elit", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Neque", "Mauris, per lorem, porta, euismod, volutpat, facilisis dolor, tellus, litora. Et posuere elit non, lacinia, molestie fringilla, tellus, cursus urna. Vulputate lorem, platea amet, odio, mauris, tincidunt quam, mattis, taciti. Maecenas volutpat, vel, nisi, dolor aenean eleifend venenatis consequat in. Mi ac sed, auctor, sapien auctor tristique platea orci, at.", 18m, 90m, 0, "Faucibus", "Consectetur." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c30630-ef18-465b-9514-fc742de98727"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ex", "Sociosqu sodales felis magna, vel mi, pulvinar faucibus ante, tempor. Vulputate finibus molestie donec a dolor pulvinar, vestibulum, lacinia, phasellus. Ad bibendum, inceptos interdum varius nullam nisi, tincidunt porttitor, eleifend. Dignissim hendrerit ex ultrices, magna fusce rutrum vestibulum diam accumsan. Congue, nam eget convallis sed non, id, sollicitudin interdum nulla.", 49m, 89m, "Dictum", "Dolor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ullamcorper", "Sagittis, magna nisi sollicitudin lacinia metus sociosqu sed, posuere, fringilla. Gravida placerat, facilisis bibendum, sapien commodo semper tortor, aptent ac. Sagittis, primis ligula id, tortor, fringilla urna, orci sit nulla. Dui arcu, nibh rutrum sapien taciti condimentum auctor, rhoncus, leo. Mollis amet malesuada neque rutrum euismod, semper duis eros ac.", 94m, 50m, 1, "Rutrum", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Habitasse", "Ultrices vel metus feugiat, iaculis quis taciti fames id ipsum. Fringilla, lectus, mauris, phasellus nunc a, vulputate etiam blandit in. Justo in, sodales auctor, erat felis viverra fermentum non, at. Nostra, magna, habitasse purus elementum porttitor, nulla, sed, vestibulum, vitae. Lobortis finibus consequat quam, ligula hendrerit lacinia, ullamcorper primis metus.", 10m, 95m, 1, "Urna", "Vulputate." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Lobortis praesent consequat tortor vel feugiat blandit interdum, tellus, turpis. Luctus, mattis elit molestie gravida sapien vel, tellus orci, litora. Urna lacinia, odio, ante id, odio litora vehicula conubia justo. Nibh, enim, quisque varius, euismod mollis et leo, id, litora. A, dui, aptent eleifend, eros, lorem cursus, dapibus himenaeos quam.", 99m, 19m, 0, "Vivamus", "Ligula." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff8504f-e274-4d9f-984b-df155739e516"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Viverra", "Eros faucibus duis euismod nunc fusce proin sociosqu porta, magna. Pellentesque rhoncus amet, arcu justo sem, tortor, commodo, maecenas volutpat. Feugiat, consequat fringilla, facilisis pretium arcu id dolor, feugiat bibendum. Himenaeos aliquam dapibus eleifend, quam, turpis vulputate et, nam habitasse. Eu rhoncus, est placerat, fringilla, tortor, odio cursus, nisi interdum.", 16m, 23m, "Mattis", "Posuere." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Commodo", "Maecenas nec nulla amet, sollicitudin primis leo, mauris ex, nunc. Non, convallis nullam interdum, magna massa, lorem rhoncus tortor sociosqu. Hac a ultrices, tellus nisi, a, iaculis dui urna, fames. Odio, turpis nulla, per quam commodo, posuere blandit, scelerisque nisi. Eros, urna quisque commodo, non vehicula mauris laoreet vivamus quam.", 63m, 6m, "Pulvinar", "Imperdiet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Blandit", "Molestie viverra donec nibh, placerat eros, id, posuere, ultrices dictumst. Massa mollis euismod adipiscing nunc auctor varius luctus, tortor nibh. Dapibus bibendum vel efficitur lorem, lectus, massa odio, litora pellentesque. Cras lobortis euismod vivamus maecenas rutrum nulla, sit proin magna. Ut vestibulum, tortor, hendrerit finibus, feugiat, urna, et, eros, nam.", 61m, 48m, 0, "Nulla", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Velit", "Posuere, lorem auctor finibus, sodales duis phasellus per gravida luctus. Dui eros, quam porta, magna orci mauris, sagittis, ante finibus. Ligula molestie eu, a ac imperdiet tempor posuere non mattis. Amet, nisi aptent et, amet ligula, nullam ultrices, luctus congue. Dictum et, integer nibh, cursus libero id, auctor, vitae, sollicitudin.", 61m, 7m, 0, "Morbi", "Nisl." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Massa", "Arcu ultrices, egestas nisi luctus, fusce porttitor mattis, curabitur lacinia. Est in sociosqu arcu nulla fames sagittis, arcu, purus in. Semper vestibulum, per nostra, efficitur commodo, nulla rutrum tristique vivamus. Primis tellus, sodales fusce nisi placerat luctus, per quis, tortor. Bibendum, id etiam tristique ligula maecenas ad litora magna, enim.", 72m, 20m, "Lectus", "Hendrerit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21420154-8f18-4fb3-b745-60621cca5541"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Feugiat", "Turpis suspendisse felis sed vestibulum, condimentum nisl mauris, purus non. Class nulla, lorem sem, porta, commodo, integer vehicula fringilla eget. Et, molestie volutpat tortor tristique porta, adipiscing nostra, eleifend nulla. Lacinia, pharetra massa, eu, sociosqu duis et, auctor eros posuere. Nibh amet neque, posuere ante, vulputate nisl erat, nullam lectus.", 61m, 6m, 1, "Vel", "Nulla." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Odio sit neque class feugiat, porta, pulvinar pretium malesuada lorem. Ante amet, vehicula pretium volutpat a, massa orci ullamcorper rutrum. Iaculis quis, metus tempor fames quam ullamcorper leo, donec in. Erat duis tincidunt quis, enim massa commodo laoreet, varius augue. Nec, bibendum blandit purus urna ante proin tincidunt donec cras.", 95m, 93m, 0, "Luctus", "Libero." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "A", "Mi, lacinia rhoncus, at class tortor sociosqu ultrices, eget nunc. Nisl et, consectetur amet, massa fringilla maecenas tellus, erat porta. Hac commodo, odio, vestibulum, sollicitudin magna, posuere, volutpat dui finibus. At, eleifend, et, tristique leo porttitor, congue, dui, pulvinar euismod. Fusce a, placerat suspendisse habitasse hac aliquet id, quisque lectus.", 84m, 84m, "Vehicula", "Lectus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Magna", "Fusce gravida quam, sapien congue orci, auctor cras lacus hendrerit. Metus risus tempor litora conubia mollis imperdiet eros posuere posuere. Duis porttitor, malesuada accumsan urna mi, ad dictumst ornare felis. Dui lorem, nulla massa, dolor, pellentesque egestas cursus, volutpat, laoreet. Duis tristique scelerisque tortor, nunc, ultricies quam, iaculis felis nec.", 16m, 24m, "Dolor", "Mattis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Mi", "Etiam phasellus enim, nullam nulla volutpat, per nisi pellentesque venenatis. Sed volutpat tristique magna amet non imperdiet nunc auctor, proin. Laoreet, pharetra quis condimentum leo, nulla dapibus posuere magna, class. Sagittis commodo magna nam varius, ligula fermentum at, habitasse porttitor. Est feugiat, in magna, condimentum bibendum, ligula, efficitur diam taciti.", 16m, 43m, 0, "Commodo", "Aptent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Justo", "Turpis felis ultricies auctor et mauris conubia eu suscipit amet. Dictumst mi tempor, vestibulum, sagittis, volutpat, malesuada dui neque, proin. Erat pharetra lorem torquent justo tristique platea blandit morbi praesent. Finibus, nisi blandit, dolor, semper odio, orci rhoncus enim, sollicitudin. Litora nisi aenean dignissim ornare conubia finibus purus viverra venenatis.", 75m, 23m, "Dui", "Feugiat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Magna", "Torquent vivamus congue, tortor magna, enim, gravida libero eros, platea. Pretium finibus mi, tristique nisl varius aliquet varius, dui, non. Eleifend, nec, urna vestibulum, eu, volutpat nam aenean leo, lectus. Euismod, vel, lorem ac, diam massa pretium libero imperdiet finibus. Inceptos lobortis sagittis mi, quis, quis ex sem, aliquam adipiscing.", 41m, 80m, 0, "Cursus", "Cras." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Imperdiet", "Orci blandit, nullam pharetra sapien amet quam, efficitur morbi dictumst. Elit in, viverra fermentum cursus integer at, massa, a mi. Gravida scelerisque at, eget quisque primis nibh turpis porttitor volutpat. Vel, nisi mauris tincidunt tellus, convallis tempus dui, vestibulum, accumsan. Non ex lacinia pellentesque nullam faucibus nisi, ligula a, tincidunt.", 37m, 41m, 1, "Duis", "Erat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("357cca07-da0f-4263-9575-9304ba791639"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lorem", "Luctus, posuere, placerat neque, aenean inceptos eros lorem ligula, maximus. Odio hac nisi mollis vel ultrices fringilla nibh, et lacinia. Elementum non sed vehicula ligula elit, ante per id, amet. Gravida lectus, luctus, eros, volutpat suscipit sit congue, tortor, nunc. Massa, habitasse aliquam nisi, varius urna sapien inceptos auctor, bibendum.", 56m, 29m, 1, "Fames", "Egestas." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Malesuada", "Efficitur varius tortor nam amet, mattis nibh tempor, non, bibendum. Urna, eleifend facilisis interdum, duis commodo tellus, mattis euismod in. Amet, nec, urna, maximus laoreet per malesuada blandit, mollis pellentesque. Hendrerit fringilla, semper auctor, conubia nullam nisl luctus tempor ultrices. Fringilla primis iaculis mattis mauris ac, eleifend, volutpat porttitor, purus.", 32m, 43m, 1, "Ullamcorper", "Dapibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Non", "Quis, mi arcu, massa, dignissim elementum eget lorem mauris, lectus. Taciti lectus mattis proin finibus, volutpat sociosqu viverra vestibulum, enim. Vel leo fames luctus, dui, libero et, arcu, maximus vulputate. Ac tincidunt enim, fringilla nisi tellus erat et, turpis elit. Porttitor neque, vel ex suscipit egestas dignissim erat, mauris elit.", 64m, 79m, 1, "Aptent", "Consequat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Euismod", "Conubia massa, pharetra gravida risus ultricies nam hac mattis commodo. Lacus primis nulla, odio porta, vitae, auctor sem, venenatis placerat. Feugiat, adipiscing ante, euismod, aenean volutpat, pulvinar quam eu aliquet. Donec neque velit fames nulla, fermentum aptent ipsum nibh suspendisse. Ultricies augue pulvinar finibus, nibh, placerat, auctor, libero dolor, nisi.", 2m, 37m, "Nunc", "In." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sem", "Varius, nec, dui vitae ac fames ipsum eros, ullamcorper luctus. Dui, nostra, mattis, molestie et, integer porttitor in, egestas rhoncus. Rhoncus facilisis id euismod nec tortor cursus pretium ullamcorper fusce. Metus id, arcu, taciti adipiscing quisque auctor scelerisque suscipit lorem. Pellentesque enim adipiscing interdum, tellus, blandit commodo risus nec non.", 28m, 59m, "Congue", "Cras." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Praesent", "Quisque fermentum amet ac mattis vitae posuere, diam sociosqu nibh. Eget semper dapibus per eros, quis condimentum imperdiet tempor iaculis. Pharetra quis, adipiscing finibus, nam finibus feugiat semper diam sem. Dolor ligula rutrum dui, auctor, odio, ultrices sagittis, curabitur vestibulum. Lobortis ex, vulputate fames ac, porta torquent auctor, litora accumsan.", 20m, 92m, 1, "Hac", "Dictum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4158bf42-0721-4e06-9ebd-ddf682240f7a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Iaculis", "At, ut commodo magna nisi, odio, adipiscing interdum arcu, lacinia. Et, non, amet sem, pretium torquent erat, congue ornare fringilla. Odio, at, luctus, ultrices, ligula, metus rhoncus varius eleifend, rutrum. Aptent eu luctus, neque arcu porttitor, blandit eget pharetra dui. Laoreet fames congue, lectus commodo, sociosqu id tristique feugiat feugiat.", 84m, 83m, "Enim", "Ipsum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mattis", "Elit, ac, sem dui, ex tempus nibh rutrum hac ipsum. Eu, risus lectus felis mi, rutrum conubia porttitor feugiat, sapien. Mattis at rhoncus non, venenatis a per ultricies adipiscing quam. Finibus, non vitae porta, diam tortor purus dui tellus semper. Felis lectus nec arcu maximus posuere porta, malesuada arcu, aptent.", 88m, 33m, "Nisi", "Pellentesque." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"),
                columns: new[] { "Category", "Description", "Price", "Status", "SubCategory", "Title" },
                values: new object[] { "Metus", "A, fames non varius, eleifend, volutpat egestas suscipit nibh pellentesque. Iaculis dui sagittis maecenas semper leo, orci, eget tempor vel. Ex amet, varius et euismod, blandit, turpis morbi tincidunt risus. Fames aliquet nec, eros viverra venenatis eu libero ullamcorper rutrum. Elementum arcu, risus ligula dui, interdum gravida felis nulla, vulputate.", 66m, 1, "Fermentum", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Fermentum", "Fermentum nibh etiam tellus congue, ut pretium placerat maximus sociosqu. Cursus class taciti consequat porttitor convallis laoreet, finibus rhoncus hendrerit. Suscipit mattis aptent tristique in neque ante, et, aenean odio. Consectetur tellus, arcu sem, elit lacus suspendisse vitae nisi tortor. Dapibus enim eu, neque aliquet praesent cras pulvinar, consectetur tellus.", 91m, 44m, 1, "Fusce", "Auctor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Platea", "Vitae platea fusce urna, quam mollis sed praesent sagittis non. Arcu diam laoreet, feugiat vulputate porttitor eleifend, congue, mi, dignissim. Aliquet tortor iaculis auctor, nisi tempus erat, vitae luctus, lorem. Phasellus ultrices, rhoncus, consectetur ultrices venenatis urna sodales nam dui. Dignissim quis lacus interdum, ex enim, tortor, conubia ligula, auctor.", 49m, 9m, "Facilisis", "Odio." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Velit", "Iaculis ultricies lectus lacinia, ipsum varius porttitor amet, semper suspendisse. Eu, himenaeos nibh enim, lobortis quisque efficitur luctus eu curabitur. Habitasse dictum tempor, quam eros quam, ante nibh, pharetra interdum. Sapien ante, faucibus vehicula auctor phasellus lorem, rhoncus, ex vitae. Mauris porttitor dui in mattis, pulvinar, bibendum a, nunc, quisque.", 66m, 39m, "Odio", "Placerat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mi", "Ante elementum tortor, sapien sem dictum nulla, commodo euismod arcu. Himenaeos ultrices, lorem sagittis, a, litora interdum nostra, maecenas in. Tempor, id fermentum luctus eu, enim, lobortis finibus, integer erat. In ex, euismod rhoncus, eu, vel eros, nisl ante rhoncus. Nisl vel congue phasellus pretium felis venenatis maximus placerat arcu.", 90m, 66m, "Consequat", "Massa." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Malesuada", "Euismod a, neque tincidunt pulvinar ornare volutpat maximus mollis arcu. Lacinia, eu, platea placerat, pretium etiam vitae arcu mauris, placerat. Porta, commodo, cursus per vel id volutpat, primis laoreet tellus. Tempor, lectus, eu, neque molestie lacinia, eu volutpat, gravida varius. Fringilla nunc, sociosqu varius morbi vitae iaculis donec mi tellus.", 41m, 96m, 0, "Tellus", "Dictum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ac", "Sodales felis sapien sagittis, nec luctus, blandit leo sem, nulla. Pharetra luctus, posuere, ultrices, viverra cras mattis, quis, mauris conubia. Consequat sem nulla ac, mi vitae porttitor, et arcu, justo. Habitasse inceptos elit, luctus, rhoncus, laoreet, risus lacinia tellus ultrices. Imperdiet vel nulla, integer class cursus, ultricies egestas fermentum a.", 78m, 44m, 1, "Cursus", "Ac." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Elit", "A morbi ultricies nisi, euismod, facilisis himenaeos enim, diam ornare. Euismod posuere nulla, felis convallis amet venenatis id ipsum per. Vitae id laoreet, finibus tempor eu mattis, urna bibendum mattis. Laoreet efficitur quam, congue, vitae, porttitor nisi tortor, hac fringilla. Varius, maecenas quis, congue, euismod malesuada pulvinar bibendum, fusce gravida.", 31m, 91m, 1, "Elit", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53c7a9de-03b5-4482-8163-2d925ca7f3c5"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Sapien", "Sem iaculis per pretium ante, eu vel, aliquet nunc, libero. Dictumst nostra, vitae, massa eros, lectus, vehicula aptent non hendrerit. Erat, luctus ligula, bibendum porttitor, dapibus curabitur sollicitudin posuere, purus. Auctor, metus habitasse posuere, nulla, augue mi bibendum litora vitae. Rhoncus amet nunc molestie eros, ex tellus scelerisque quam, id.", 31m, 35m, 1, "Arcu", "Dictum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("543372da-be2f-4ef6-8496-98a8a075799c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sem", "Sit posuere, nunc quisque sollicitudin scelerisque amet auctor luctus condimentum. Vehicula nulla, at, libero praesent taciti convallis sagittis, feugiat nisi. Vivamus quam, quam non, neque, habitasse viverra efficitur mattis commodo. Ultrices augue a, vulputate pharetra at, nulla, dolor rhoncus, congue. Quisque dictum pretium varius litora fermentum nisl elit, auctor sollicitudin.", 53m, 26m, "Nulla", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Iaculis", "Phasellus torquent dolor, vitae, a magna sit eleifend, quisque fermentum. Tempor adipiscing odio, euismod, nibh sociosqu luctus tellus, posuere, nullam. Integer ac velit curabitur torquent imperdiet dui, platea fringilla, mi. Duis non eget id id, molestie nunc, euismod justo porttitor. Interdum, massa ut duis nisi tristique bibendum dictum ultrices nisi.", 66m, 29m, "A", "Nisl." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Fusce", "Ac, ac mattis lorem, euismod habitasse venenatis sed, cursus eros. Augue vulputate in luctus, porttitor, lorem vivamus sed nunc, fermentum. Vel porttitor a sodales quis ad rutrum ultricies et, nibh. Orci, convallis magna platea iaculis himenaeos volutpat lorem urna, varius. Fringilla, tempor, lacus ad nostra, hendrerit ligula, ullamcorper vel, tempus.", 15m, 12m, 0, "Vitae", "Sit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Risus", "Aptent id ut risus erat, semper volutpat ultricies imperdiet a. In varius velit sed, magna odio, ex fringilla eu id. Nunc malesuada lorem, curabitur posuere consectetur purus donec vehicula ante. Nunc, quisque magna, nisi, dictumst faucibus non quam nec, interdum. Nunc, conubia elementum cursus, duis cursus a, velit consequat sociosqu.", 54m, 64m, "Porttitor", "Torquent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Pharetra", "Curabitur ac vitae, leo, mollis massa, maximus tincidunt lacus elit. Purus nam nisi semper ex, ornare et, finibus, placerat rhoncus. Massa, risus viverra dictumst maecenas euismod, vivamus at, porta dolor. Dui, purus massa, erat lacinia, leo, odio, diam fermentum congue. Accumsan conubia maximus dignissim justo a, at habitasse luctus, tempor.", 45m, 70m, 1, "Orci", "Fermentum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Himenaeos", "Cursus phasellus ultricies id molestie vehicula sodales varius adipiscing facilisis. Euismod, mauris ligula eleifend auctor, maximus mattis facilisis porta, lacinia. Nisi, auctor leo nulla rutrum lectus suspendisse donec rhoncus, convallis. Massa pharetra placerat, felis nostra, erat dui at, diam interdum. Purus fringilla, dapibus maecenas porta, malesuada sollicitudin sociosqu risus in.", 64m, 37m, 0, "Viverra", "Massa." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lacinia", "Lorem dui hendrerit tellus, amet, conubia mi, lacinia dui, ligula. Augue dignissim blandit tellus risus lacinia, nunc, ex, malesuada varius. Congue, gravida fermentum ultrices, risus nisi, bibendum vel, viverra lorem. Tempor rhoncus, finibus facilisis lobortis primis a suspendisse egestas dui. Vehicula per massa gravida morbi dignissim platea tincidunt nullam inceptos.", 52m, 45m, 1, "Augue", "Fames." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Eros", "Orci, consectetur laoreet quisque mauris ut rhoncus, tincidunt nibh aliquet. Fringilla arcu quis, ac phasellus morbi luctus, tincidunt donec ullamcorper. Bibendum, litora porttitor, quam est neque, venenatis primis pharetra laoreet. Non taciti purus tempor lorem eros, nisl massa cursus, quisque. Cras nam phasellus maximus pulvinar blandit, dolor suscipit sem porttitor.", 40m, 90m, "Eros", "Dolor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Aenean", "Nisi, sed, est posuere gravida cursus, porttitor at, etiam ultricies. Risus laoreet, eros, leo erat platea placerat sagittis, turpis duis. Nisi ultrices tortor, morbi blandit, vehicula odio quam, vel, metus. Lacinia, eleifend blandit porta congue adipiscing dictumst justo iaculis quis. Nibh ultricies a, bibendum ut sed et luctus, maximus augue.", 35m, 87m, 1, "Accumsan", "Imperdiet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory" },
                values: new object[] { "Varius", "Ut volutpat, placerat torquent aliquam viverra feugiat quisque lectus, tellus. Est lobortis tortor, ac, amet inceptos consectetur nibh amet, placerat. Erat, rhoncus, fermentum erat lorem maecenas sapien orci arcu aptent. Lectus, eget pretium diam porta, posuere mi, porttitor, commodo, eleifend. Eget eleifend, consequat cras placerat, aenean commodo metus pulvinar varius.", 38m, 58m, 1, "Pulvinar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Taciti", "Vestibulum, phasellus suspendisse maecenas morbi dolor, volutpat ante, purus imperdiet. Donec nunc, vehicula gravida metus aenean nam eros, semper ex. Luctus molestie posuere nec maecenas et dui auctor elit enim. Ultricies congue a nisi felis laoreet inceptos mattis rutrum sed. Sed, urna at condimentum elit felis proin a, eleifend sit.", 77m, 22m, "Rhoncus", "Pulvinar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Morbi", "Eget at tincidunt maecenas lacus dui adipiscing etiam magna blandit. Ex semper nam massa nisi, mattis, ut feugiat, laoreet massa. Mauris, elementum imperdiet platea massa orci, dictumst id, magna, interdum. Feugiat, litora tempor ligula, conubia massa lectus, mattis, sem molestie. Orci sagittis vestibulum duis sociosqu elementum non, volutpat, porta aenean.", 65m, 65m, 0, "A", "Id." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Fames", "Velit aliquet vestibulum sem, lorem massa, litora sapien finibus nulla. Sodales hac est eu, volutpat, platea ornare enim nunc laoreet. Quisque a bibendum euismod odio bibendum, cras nisl scelerisque porta. Enim, inceptos purus elit, ut bibendum diam magna imperdiet taciti. A tellus, luctus adipiscing vel, libero fames cursus, finibus suspendisse.", 17m, 11m, "Erat", "Phasellus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dictum", "Volutpat, nisi, tempor, sem pulvinar, ex augue pellentesque nostra, nibh. Commodo quam, scelerisque cursus, mi et aliquam lacinia, quis, vel. Blandit dapibus vitae, etiam tempus eu mollis aptent dictum finibus. Lectus, blandit etiam tempor, maximus tortor, blandit, suscipit bibendum interdum. Imperdiet lacus arcu, aliquam et platea tincidunt a, euismod, enim.", 60m, 79m, 0, "Auctor", "Felis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Condimentum", "Donec inceptos purus pharetra a, lorem, sagittis tortor ultrices, dolor. Molestie donec suscipit venenatis elit quam, litora sociosqu eget orci. Enim, ut lacus aliquam magna, euismod, maximus pellentesque ligula eleifend. Himenaeos ex dictumst urna a, sollicitudin turpis suscipit pulvinar neque. Mauris, fringilla posuere, dolor sit erat, adipiscing commodo dictum vestibulum.", 54m, 65m, 0, "Conubia", "Bibendum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Finibus", "Posuere, aliquam etiam maximus finibus, arcu, odio luctus, ultrices, ac. Nunc massa, posuere torquent volutpat orci sagittis commodo malesuada ac. Ullamcorper lobortis metus nisl justo pellentesque aliquet ipsum luctus porttitor. Elit, nibh, suspendisse et cras platea eleifend, massa, bibendum neque. Gravida fringilla scelerisque class ornare nam iaculis non, interdum, risus.", 77m, 27m, 0, "Et", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("836bf6f7-71a6-485d-8514-455393908657"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Enim", "Nullam interdum, fusce bibendum sollicitudin tortor aliquet ad cursus, ullamcorper. Amet, neque, posuere tellus, bibendum tellus sagittis, tempus lacus a. Iaculis in, non nisi, quam pretium facilisis ex, sapien finibus. Imperdiet euismod mauris, ligula pharetra urna interdum, nunc metus nec. Per nisi, pulvinar nullam blandit hendrerit quis aptent posuere, cursus.", 25m, 22m, "Ultrices", "Aptent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Tincidunt", "Neque adipiscing posuere interdum, ut in, justo sed feugiat nisi. Et feugiat, viverra himenaeos ex, vitae, orci, dui quisque sem. Mattis tortor, nullam erat, lacinia, feugiat, dictum fusce curabitur habitasse. Praesent ante, curabitur porttitor dolor ac sit condimentum faucibus bibendum. Quis ultrices urna cursus quis, iaculis suspendisse tincidunt per enim.", 86m, 75m, 1, "Vel", "Odio." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lacinia", "Condimentum eu, ex dui tellus, rhoncus ex, mi est et. Quisque sociosqu ultrices dolor, eleifend eros fringilla, per neque mattis. Commodo, orci sollicitudin varius fermentum neque conubia nisl pretium arcu. Tellus elementum congue mauris non sagittis tempor, est feugiat aenean. Curabitur convallis libero vitae, est ac, bibendum aliquet fermentum orci.", 14m, 12m, 0, "In", "Iaculis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Facilisis", "Sociosqu fermentum lacinia cras ac, euismod, commodo, ante semper nisi. Convallis nec elit ex, interdum, cras pretium lacinia, enim odio. Litora mi, vulputate mattis, habitasse lacinia, orci quis, vestibulum, fringilla. Mauris facilisis hendrerit elit sed posuere ornare sodales ut sociosqu. Commodo arcu leo, mattis himenaeos dolor, pulvinar enim, posuere, consectetur.", 49m, 96m, 0, "Molestie", "Dui." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Semper", "Fermentum odio accumsan tempor, ultrices maximus nam donec quam, sapien. Platea sapien aliquet consectetur eget vitae, porttitor adipiscing leo, mauris. Duis id, blandit, ac, lorem at, sem, vestibulum fringilla mi. Sodales nisl non rhoncus, mi interdum, sapien at, dolor, suscipit. Arcu, cursus, erat eros semper vivamus fames cursus tellus vitae.", 34m, 95m, "Nulla", "In." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Id", "Finibus, pulvinar lacinia, ac dictum eleifend, vel, convallis vivamus euismod. Fusce praesent gravida fames maximus lorem elementum eros litora nostra. Neque conubia eu, varius at, pulvinar tellus, nec, ante pellentesque. Nec rhoncus, leo nec, blandit arcu, luctus, efficitur dolor, feugiat. Elit, congue, nunc lacinia, nunc, fringilla dui tortor enim volutpat.", 71m, 95m, "Etiam", "Vivamus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Efficitur", "Finibus, ad erat vel, ut pellentesque elit lorem torquent sed. Tempor tristique lorem a dui praesent facilisis semper pharetra sollicitudin. Maximus enim bibendum fermentum orci, a, quis, mauris ad volutpat. Magna, quam tristique litora maximus elit, mattis eu, duis non. Interdum, quis suspendisse pharetra cras metus pellentesque vulputate nisi, ultrices.", 75m, 85m, 0, "Nunc", "Suspendisse." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("962d2024-995d-4165-89c9-55e15d2176e3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Imperdiet", "Rhoncus, est suspendisse non, porttitor, mattis, eleifend, feugiat leo laoreet. Fames leo, quis, class lectus, inceptos donec interdum, auctor, sagittis. Nibh tellus, eros, etiam at, ex, sem erat, malesuada magna. Id, lobortis elit arcu egestas varius ipsum mollis nisi placerat. Luctus euismod, eu, id, lacus rutrum tristique tortor, feugiat, dolor.", 96m, 15m, 1, "Maecenas", "Et." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Volutpat", "Congue est arcu, conubia non, mauris eros convallis dui congue. Lorem, lacinia dolor fringilla, posuere, quisque vulputate cursus, amet augue. Lacinia maximus eu quisque amet lectus, enim, sagittis felis urna. Platea nisi eros, a, enim ac, at, commodo, non euismod. Dictumst phasellus morbi nunc rhoncus, magna, quam, luctus, vivamus orci.", 58m, 41m, 1, "Dictumst", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Augue", "Interdum rhoncus condimentum dictum class lobortis placerat vestibulum primis sed. Taciti suscipit leo, enim mauris, fames ex ipsum aptent ac. Leo pulvinar tempor tempor, euismod auctor, eros laoreet varius lorem. In phasellus blandit curabitur erat, sed, litora arcu, lectus aptent. Ac hac luctus, nisi enim, dictum conubia consequat mattis, nisi.", 92m, 23m, "Orci", "Ac." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Non", "Arcu, interdum, elit volutpat, ac, vivamus habitasse luctus ac est. Porta ac, integer ultricies aenean at, ultrices, mi, convallis rhoncus. Magna et, rhoncus nisl aptent cursus aenean placerat, dui, viverra. Pulvinar, aptent erat, consequat congue tortor lectus scelerisque varius, urna. Tellus eleifend magna, maecenas finibus, nisl facilisis dui posuere, fringilla.", 4m, 98m, 1, "Nisl", "Sociosqu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Cursus", "Ex, est eros, iaculis feugiat, et risus consequat class feugiat. Interdum, litora cursus, fermentum ante varius, duis rhoncus, per posuere. Porta, maecenas tellus dapibus tempor suspendisse fringilla, nisi ex, morbi. Lacinia mauris, auctor, aliquam per at efficitur pulvinar hac elit. Odio ultricies amet suspendisse efficitur pulvinar, tellus, ut hendrerit praesent.", 35m, 62m, 0, "Eu", "Erat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Fames", "Sed finibus arcu, blandit porta gravida interdum luctus, non ex. Mi mattis condimentum nisi, aptent augue interdum, lacinia volutpat ante. Arcu ligula nec, lectus vivamus vitae, interdum, finibus ante lorem. Pretium blandit, suscipit dignissim accumsan condimentum cras platea dolor, pharetra. Litora dui ad eget erat auctor, tristique enim, imperdiet praesent.", 76m, 10m, "At", "Lectus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Magna", "Praesent sit vulputate at a ac tellus porttitor, tincidunt hac. Lectus molestie ante sagittis, euismod, luctus, placerat vestibulum non eros. Fringilla, vitae, amet, aliquam enim dictum cursus, conubia integer nullam. Imperdiet pellentesque eleifend, per est posuere at, auctor, elit, viverra. Erat sem ex, tellus elit habitasse ligula rhoncus, pulvinar, semper.", 30m, 12m, 1, "Fringilla", "Placerat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Pellentesque", "Semper elit placerat, lacinia ultricies neque nec, luctus, interdum quam. Sociosqu tempus ac, dignissim aliquam nunc curabitur turpis gravida sit. Mi, himenaeos bibendum sed praesent pulvinar, non, eu, proin congue. Fringilla, libero vel, sollicitudin et leo eu eros, himenaeos auctor. Euismod inceptos hendrerit ex, bibendum, leo, enim laoreet massa elementum.", 31m, 96m, "Urna", "Mattis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Lacinia", "Eros elit, sociosqu sollicitudin accumsan quam lorem venenatis nec, quisque. Varius mollis id, interdum placerat, ac ex blandit viverra nostra. Placerat erat habitasse non porttitor, taciti ac velit convallis himenaeos. Ultrices dapibus eleifend, morbi bibendum, posuere class praesent ex blandit. Ultrices ligula, adipiscing posuere auctor laoreet platea a, sagittis, porta.", 8m, 45m, "Odio", "Libero." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dui", "Velit pharetra nec, iaculis tempor, et, massa, volutpat sit tristique. Nisl lectus enim, orci pulvinar, feugiat nunc, luctus, finibus nibh. Fringilla, a mollis etiam lobortis vel, blandit dapibus pretium augue. Bibendum, convallis semper elit, orci, luctus quisque id dui quis. Adipiscing phasellus aliquam in, arcu pulvinar, turpis magna euismod, cursus.", 74m, 74m, 0, "Porttitor", "Enim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adaa5968-bab8-433d-abc6-217d49fa3395"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Bibendum", "Non, libero amet convallis tellus cursus, tempus odio et, turpis. Dictum porta pulvinar, luctus non lectus curabitur hendrerit eget tellus. Congue, pharetra nibh tempor, gravida commodo consequat quis, elementum aptent. Nullam turpis odio condimentum tortor ad sed elit, a elit. Convallis justo interdum, ex, aptent mi, et, odio, aliquet cursus.", 44m, 46m, "Massa", "Suscipit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Id", "Vestibulum, mauris taciti dignissim molestie urna, massa, fames feugiat luctus. Platea mauris, varius amet, magna sem, aptent mi, sagittis, scelerisque. Sodales lorem habitasse mauris, luctus commodo nisi varius mi, vestibulum. Porttitor augue ante, nulla, quam, est elit, tempus nec, hac. Pulvinar eu a, sollicitudin interdum, dui, at tempor cras mauris.", 59m, 28m, "Integer", "Urna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Magna", "Tellus, odio dapibus diam id blandit, nisi lacinia placerat ullamcorper. Porta integer at per tellus, class velit vitae, maximus eu. Ex tempor, lectus, semper risus nibh sagittis eleifend, orci, quis. Non arcu condimentum sollicitudin id, arcu, leo semper varius sed. Magna, vehicula proin hendrerit nunc habitasse at luctus, arcu vestibulum.", 64m, 81m, "Aliquam", "Nisi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Egestas", "Varius urna sem mauris, malesuada dolor scelerisque donec fusce luctus. Pharetra porttitor ultrices est quam elit, maecenas orci eu, maximus. Dui vel, mauris, tempor, id, dictum maximus auctor, placerat litora. Elementum dui vestibulum, magna, diam quis, in auctor, lacus sapien. Nec, quam consequat sit ultrices, neque, class consectetur porttitor, ipsum.", 69m, 34m, 0, "Tristique", "Litora." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Et", "Ligula, suscipit himenaeos fringilla sem nullam commodo pharetra vel, conubia. Accumsan metus congue commodo eget lorem blandit, pulvinar aenean conubia. Lectus quam varius, quam, vitae ultrices, non, pellentesque feugiat, augue. Mi nullam dictumst aliquet commodo a, rhoncus nec quam, enim. Sit amet, enim, volutpat, lacinia, vivamus consequat arcu, sagittis congue.", 24m, 33m, "Eleifend", "In." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nulla", "Augue et, duis facilisis finibus erat, litora ut suscipit efficitur. Viverra turpis dictum congue ipsum sem quis inceptos aliquet varius. Urna libero ut vel mi, nulla dui, vel, gravida nisl. A, dictumst consectetur efficitur et interdum, dui sodales ante a. Amet turpis elit id, arcu nisi convallis proin neque, himenaeos.", 92m, 13m, 1, "Arcu", "Leo." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Massa", "Feugiat, porttitor, posuere, dapibus aenean mattis auctor, ligula fermentum taciti. Placerat, fames ligula, porta, ut est massa, lobortis vestibulum, dictum. Leo nulla, consequat eu, eleifend congue ut euismod, eros, feugiat. Faucibus duis ut mattis, fusce interdum, dui semper habitasse aptent. Elit nisi ante, dolor, eleifend, auctor, vitae odio morbi magna.", 75m, 19m, "Sagittis", "Scelerisque." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Elit", "Convallis sodales nec, finibus leo porttitor, luctus, fringilla rutrum interdum. Augue at at, massa, lacinia, cursus, arcu, nulla, ex, primis. Elementum cras nullam ad nunc, sagittis libero feugiat aptent nisi. Dui, mollis libero felis purus commodo, dui sollicitudin ligula, sem. Massa arcu nulla nostra, lorem, et, taciti etiam neque rhoncus.", 30m, 54m, 0, "Sed", "Nisl." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba3c9243-5390-488e-b598-2779fd398da8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vitae", "Bibendum ullamcorper eleifend arcu magna, at, quis, orci, nostra, lorem. Aliquet urna arcu, enim litora phasellus enim, lectus, torquent augue. Risus cursus taciti sem, tellus, adipiscing eu, rutrum sed, congue. Urna, interdum, neque, tristique lacinia dui, fringilla vitae, commodo, morbi. Cras pulvinar curabitur congue posuere dolor eleifend sagittis, aptent eros.", 65m, 81m, 1, "Leo", "Blandit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Cursus", "Sagittis, morbi ligula curabitur habitasse vestibulum lorem non, inceptos sodales. Urna, blandit ultrices, ligula, porttitor dictum elit lorem, lacinia inceptos. Aptent quis, libero placerat, tempus a, feugiat porta, platea hac. Sagittis malesuada nibh in, arcu, odio, praesent non magna, elementum. Rutrum quis erat, cursus, conubia id, elit, ante placerat erat.", 21m, 49m, 0, "Blandit", "Amet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tortor", "Rhoncus lacinia interdum elementum augue auctor, tortor egestas in, aliquet. Dolor euismod, mattis blandit, laoreet luctus suscipit cras congue ultrices. Consectetur et, rhoncus, aptent massa, efficitur ac, ligula eros lobortis. Ultricies dictumst turpis feugiat neque nam mollis cras vel euismod. Tempor, euismod, vestibulum, quis, diam suscipit lorem, tellus, sem ad.", 76m, 6m, "Ac", "Tellus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ullamcorper", "Facilisis vestibulum tellus, ipsum consequat dui, vivamus dictum tellus odio. Aenean magna fringilla nec auctor, finibus, eros, vulputate enim, pulvinar. Efficitur ullamcorper feugiat cras ligula nec, dolor tempus quis aenean. Viverra taciti porta vestibulum sem, ante, dictum lacus mauris, aenean. Libero himenaeos porttitor, nulla accumsan dui, sagittis torquent fringilla justo.", 41m, 35m, "Id", "Congue." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"),
                columns: new[] { "Category", "Description", "Price", "SubCategory", "Title" },
                values: new object[] { "Pulvinar", "Nec pharetra tortor metus lorem cursus, ac, tempus arcu, maximus. Turpis etiam laoreet efficitur at platea volutpat metus interdum, ligula. Libero eros, varius, elit convallis torquent sociosqu aliquet accumsan finibus. Nunc, himenaeos quis, tortor, maximus aenean id eleifend cursus, pulvinar. Ipsum dignissim lacinia, dui at ex laoreet, euismod, feugiat tempor.", 65m, "Urna", "Interdum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dui", "Elementum amet at, iaculis in, ante, conubia sodales ligula quis. Justo tellus praesent urna pulvinar nec elementum id, euismod auctor. Consectetur mi, varius, aliquet arcu, porta pulvinar fringilla, maecenas in. Volutpat, ac, dolor mauris, eros sed erat, lectus, vestibulum, arcu. Nunc proin id, suscipit sagittis odio, nibh duis orci laoreet.", 10m, 32m, 1, "Lacus", "Ante." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Torquent", "Vulputate luctus, taciti mauris, eleifend tempor convallis bibendum, pulvinar, aptent. Cursus urna, luctus urna ultrices, congue curabitur leo, ornare ullamcorper. Erat varius, proin eu per ullamcorper in nostra, phasellus massa. Dui maecenas sollicitudin varius, in, vel, urna elementum litora est. Justo congue, amet, pharetra nibh, nibh eleifend, magna taciti nullam.", 94m, 73m, "Elementum", "Laoreet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ut", "Lorem, pellentesque elit, urna, lectus odio vehicula hac augue tempus. Lorem torquent quis ultricies congue, vivamus vitae curabitur eros morbi. Vitae laoreet, quis nunc lorem mauris, enim metus purus tristique. Neque, vulputate placerat sociosqu at tincidunt dapibus eleifend, hac dignissim. Lectus, hendrerit proin taciti at sagittis, himenaeos imperdiet curabitur neque.", 67m, 96m, 0, "Eleifend", "Laoreet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Litora", "Mollis ante quis, platea amet, ac, suspendisse sapien quam auctor. Sociosqu vestibulum, scelerisque cursus, tempor elementum odio, eros, vel, lectus. Arcu euismod, rutrum vestibulum, urna non, elit, etiam volutpat elit. Nam lorem justo luctus, maximus morbi luctus est vivamus vitae. Dignissim dapibus sem diam dolor enim, nisi, ante, massa leo.", 19m, 41m, 1, "Semper", "Pulvinar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Torquent", "Nunc quis dictum per at ac laoreet, nibh, ligula, fringilla. Dolor, eu auctor neque, odio eros libero auctor, enim, congue. Quam, eros ex, ex cursus, eget et, lectus, cursus dui. Placerat, varius a, tellus mi, aliquet semper aliquam quisque cursus. Sem, vel vitae aptent a, egestas eu, ac sem posuere.", 90m, 76m, "A", "Eu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Platea", "Sem, enim, sed lorem, proin a, eget aliquet nec ultrices. Massa molestie eleifend convallis lectus ornare enim efficitur magna tristique. Nam semper aliquet torquent habitasse mauris, nullam consequat nulla praesent. Et, euismod suscipit odio mattis id, nisi, habitasse hac cursus. Ligula, pharetra turpis id, feugiat, taciti aliquet varius tempor, quisque.", 72m, 4m, "Massa", "Molestie." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Fermentum facilisis commodo, sociosqu class orci, interdum, vehicula faucibus arcu. Cursus nulla, porttitor ultrices, fusce dictum ut mauris tempor egestas. Iaculis rhoncus orci himenaeos cursus, inceptos porta, blandit, viverra sollicitudin. Morbi class leo maximus neque, nam sociosqu nunc, volutpat, bibendum. Risus sociosqu conubia ultrices, pellentesque maecenas quam lectus interdum suscipit.", 71m, 38m, "Mi", "Volutpat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Laoreet", "Ultrices, platea amet phasellus interdum mollis himenaeos neque, nec, accumsan. Ante, quis ipsum sagittis, eu, fringilla duis rhoncus scelerisque a. Placerat eros, odio amet lobortis eleifend tellus, mauris, condimentum elementum. Vitae feugiat luctus lectus ultrices, tellus commodo, quis fusce ullamcorper. Sagittis, dui, nec, iaculis sed blandit, inceptos fusce interdum, dignissim.", 90m, 18m, "Sociosqu", "Inceptos." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lectus", "Accumsan turpis ex, molestie dapibus fermentum blandit ex venenatis taciti. Placerat, ante, euismod curabitur augue nunc auctor integer accumsan varius. Commodo, habitasse laoreet nisi ipsum pellentesque varius nibh, neque vel. Convallis ipsum et, ad at luctus quisque felis fames erat. Mattis ut quam, vel, quis, elit, et laoreet sociosqu fermentum.", 82m, 7m, 1, "Egestas", "Eleifend." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Habitasse", "Consectetur venenatis etiam sit ac quis, suscipit luctus, habitasse molestie. Dolor, vestibulum, risus molestie gravida porta, commodo lobortis ultrices, quis. Fermentum condimentum ultrices etiam rhoncus mattis per iaculis fringilla aliquam. Bibendum placerat himenaeos primis hendrerit eget dictum ligula, nec, interdum. Tortor, mattis porttitor nostra, elit accumsan eu rhoncus, fringilla amet.", 73m, 64m, 0, "Eleifend", "Tristique." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Auctor", "Sagittis lorem, finibus arcu, urna, porttitor lectus commodo, suscipit eget. In, nostra, integer elementum fermentum neque, rutrum erat, suspendisse luctus. Auctor, nunc, maecenas enim, posuere cursus orci, nibh consectetur blandit. Amet, ac, taciti lobortis mauris, nulla porttitor, semper nostra, maecenas. Himenaeos leo, sodales vel sapien rhoncus, eu nunc ultrices, hendrerit.", 76m, 71m, 0, "Vitae", "Malesuada." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ante", "Tempus rutrum lobortis a, ligula, id, erat odio, venenatis faucibus. Interdum, ut volutpat venenatis leo, suscipit cras sed, viverra faucibus. Non, mi ac, massa, ante placerat, lectus congue fringilla vivamus. Vivamus eget nulla dolor, mattis, tortor, litora arcu, leo sed. Commodo turpis platea interdum vel sit arcu nulla, magna, taciti.", 74m, 21m, 0, "Integer", "Erat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f19d67-4312-431c-a3f9-1a76d5306820"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Primis", "At, semper arcu, suspendisse maecenas mattis, massa hac mauris et. Vel, lobortis id, enim, ex, porta et, nam fames lorem. Ultrices, aliquam congue, aptent maecenas finibus enim rhoncus, id, neque. Semper elementum tempor, eleifend interdum, quisque suscipit lectus, eleifend, vivamus. Tempus porta id volutpat fames aptent nunc, velit lacus commodo.", 8m, 98m, 0, "Class", "Arcu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Sagittis", "Quis, lacus varius purus vestibulum, tellus taciti dui, eu lacinia. Integer tincidunt nisi hac odio, vehicula sapien vel lorem a. Ultricies vel erat congue, odio dictumst tortor, quis, imperdiet in. Sem morbi sapien id, ullamcorper luctus feugiat, risus ligula, et. Vitae vestibulum sed, aliquet euismod, a elit, enim, ante, congue.", 9m, 75m, 1, "Convallis", "Placerat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nisl", "Nullam sem auctor mollis dolor volutpat nulla mi in, mauris. Primis lacus tempor luctus, vitae molestie neque, ex, tellus, posuere. Sollicitudin eros, amet laoreet, duis commodo quisque felis consequat ex. Porttitor erat, libero metus conubia aptent mattis, faucibus torquent vulputate. Tempus inceptos vitae nulla, efficitur convallis pulvinar tortor, ante, primis.", 13m, 83m, "Nibh", "Justo." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Consequat", "Aptent non, justo vitae, per malesuada dolor, finibus, dictumst primis. Sem massa habitasse imperdiet interdum, amet in ipsum enim euismod. At, non egestas porttitor fusce arcu inceptos iaculis ante, feugiat. Ligula nam libero per porttitor consectetur mauris ad orci vitae. Aliquet suscipit adipiscing interdum, curabitur volutpat sit gravida at, arcu.", 26m, 28m, "Sed", "Adipiscing." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Ante", "Duis pulvinar semper laoreet, lectus, commodo porttitor, mauris ultricies feugiat. Ipsum per auctor in, orci, lorem, habitasse fusce porttitor, mauris. Justo non, in tortor, sagittis litora enim, vel metus conubia. Rutrum porta justo vestibulum per magna scelerisque sagittis, proin ac. Molestie nec, luctus maximus erat nec blandit sociosqu condimentum nulla.", 53m, 56m, 1, "Finibus", "Lorem." });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Leo dolor, rhoncus venenatis urna, blandit, litora ullamcorper eleifend, ante. Suspendisse rutrum convallis at, malesuada posuere justo blandit, non ad. Nibh hendrerit integer mattis imperdiet lacinia donec platea consequat augue. Interdum non, duis cursus, metus nec, lectus, hac commodo, odio. Dictum sed taciti interdum, congue, magna a sodales nec, ac.", "Risus.", "Bibendum sapien" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Eros, luctus vivamus tellus fermentum lacinia et, rhoncus himenaeos urna. Ligula proin eu mattis a fames laoreet, elit et, ullamcorper. Eros arcu, ultrices, feugiat finibus, sollicitudin congue hac pulvinar, malesuada. Suscipit luctus duis ante, laoreet, sem aliquam eleifend, sagittis, quis. Nibh, eget ac orci, erat, sollicitudin adipiscing viverra bibendum, luctus.", "Lobortis.", "Id fusce" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Auctor sem molestie pellentesque duis torquent aenean in risus commodo. Suscipit efficitur dictum pellentesque conubia bibendum leo justo rutrum tempor. Eleifend tempor odio nulla, imperdiet cursus risus rutrum lorem, turpis. Laoreet neque pulvinar, bibendum, curabitur dictum massa, sociosqu condimentum euismod. Ullamcorper ac pretium congue porttitor, nisi magna, class nostra, nisl.", "Feugiat.", "Sit lectus" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Vitae lacinia, placerat, volutpat, quam, ex velit leo finibus, auctor. Elementum vel fames dictumst amet, ac, suscipit taciti ex, finibus. In, scelerisque quam, erat, iaculis dolor nam faucibus quis, auctor. Elementum mattis, sem, malesuada aliquam sem libero in, mattis rhoncus. Nostra, vulputate lorem hendrerit aliquam dolor, scelerisque sagittis, ad tempor.", "Praesent.", "Eros in" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Nunc ac nisl efficitur platea congue, finibus pellentesque porta, dui. Sed, enim, aliquet elit, nullam elit vehicula iaculis himenaeos molestie. In eros aliquam lectus, iaculis fermentum class ultrices eleifend, faucibus. Orci, lacinia, urna, eros, tristique magna, mattis quisque maecenas hac. Sodales mattis, neque duis augue magna ornare et ultricies efficitur.", "Odio.", "Pulvinar morbi" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Dapibus efficitur sed, maecenas blandit sodales proin eros luctus lacinia. Commodo, purus sit turpis lacus dignissim odio feugiat, ad nisi. Quis elit proin sit sapien ultrices nulla, sociosqu ex eros. Convallis pharetra taciti neque sem, primis eros, a, vivamus felis. Lorem blandit, conubia risus nisi lacus odio magna nibh, finibus.", "Feugiat.", "Iaculis nisi" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Vestibulum, vitae ac suspendisse taciti fringilla, dictumst sed dapibus neque. Imperdiet finibus diam nulla malesuada orci, urna, fringilla, at, consectetur. Tellus tristique nisi, primis sapien nec, pulvinar, odio libero accumsan. Neque rhoncus, viverra orci, vestibulum commodo proin velit id, tempor. Pulvinar, convallis nec quis massa, tempor, urna magna justo ullamcorper.", "Finibus.", "Turpis tellus" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Amet, et, aliquet lectus, bibendum, leo convallis vitae, sed, ex. Sollicitudin odio, erat adipiscing eu dui maximus aliquet varius sapien. Ligula malesuada interdum, lorem, lectus amet, nec, tempus vitae orci. Class enim, laoreet per maximus nibh, habitasse facilisis dolor molestie. Elit nisi odio, tincidunt per tristique amet, lacus libero eu.", "Sagittis.", "Odio tempus" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Interdum, feugiat sagittis, nam auctor, efficitur in pretium class ac. Dictum ante, diam orci ultricies litora lacinia, justo bibendum ut. Aliquam luctus, vitae, fermentum ipsum quam, condimentum purus nibh phasellus. Ad placerat, nec, orci, quisque mi, justo nulla sapien vitae. Quisque dignissim sapien egestas suscipit arcu, eleifend, nam dolor malesuada.", "Id.", "Egestas posuere" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "At ultricies a, hendrerit suscipit nullam ex lobortis primis lectus. Urna, ullamcorper ante, orci, lacinia, a lectus, leo platea quis. Ligula, vulputate fringilla, nec, porta, nullam metus blandit, felis sem. Interdum gravida consectetur in, metus tempor, ante, at, ullamcorper urna. Posuere, dignissim amet elementum eu dui vitae vehicula fringilla, lorem.", "Ligula.", "Ac magna" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "curabitur@per.com", "Leo metus", "Volutpat", "Magna", "Integer" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "dignissim@cursus.com", "Magna euismod", "Ac", "Dolor", "Mollis" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "sit@lorem.com", "Porttitor maximus", "Eget", "Lacus", "Vitae" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6c8019dc-0237-484d-80dc-452428bce548"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "rhoncus@hendrerit.com", "Magna ultrices", "Nec", "Vitae", "Tincidunt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "placerat@erat.com", "Ante ligula", "Amet", "Risus", "Neque" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "pharetra@lobortis.com", "Habitasse efficitur", "Mollis", "Porttitor", "Fames" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "aliquam@placerat.com", "Mauris ultrices", "Feugiat", "Consequat", "Efficitur" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("df749524-0c6b-416d-94c2-398f8b62e92d"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "dictum@tellus.com", "Justo hac", "Massa", "Vestibulum", "Duis" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "integer@phasellus.com", "Erat duis", "Lobortis", "Amet", "Semper" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f70f7a45-8539-4082-a181-9705c2b5c505"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "laoreet@eros.com", "Vitae ante", "Ex", "Eu", "Efficitur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Maecenas", "Interdum quis vitae, malesuada interdum, et class quam, id, purus. Nisi, mattis, ad sodales imperdiet lacinia neque tempus faucibus elit. Mauris egestas vel, sagittis porta, iaculis mauris, donec cras in. Pharetra varius consectetur vehicula porttitor, curabitur varius, aptent malesuada et. Dignissim finibus leo porta, porttitor imperdiet ullamcorper laoreet, ante, lacus.", 4m, 2m, 0, "Turpis", "Fermentum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("036526be-993c-4d69-ba77-42f606d587cb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Platea feugiat mi finibus tristique tempor, varius, integer placerat, scelerisque. Nisi platea pulvinar augue accumsan cursus, inceptos urna, fames nullam. Gravida mattis, ex neque duis placerat vestibulum, arcu quisque euismod. Diam sodales luctus, congue, tempus egestas posuere, adipiscing arcu volutpat. Nibh, nullam sagittis ultricies dapibus lacinia orci magna, tortor, turpis.", 73m, 41m, "Neque", "At." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quis", "Leo, volutpat iaculis tristique eros, nibh, odio vulputate congue, lectus. Aliquet lacinia, sapien varius, venenatis ligula sem feugiat, et, lectus. Mauris enim nam dictum pellentesque interdum, bibendum, eget tempor nulla. Lacinia, diam primis tristique tellus placerat sapien hendrerit nullam habitasse. Congue, amet, dolor nullam a, mi, nam mattis, id, nostra.", 30m, 62m, 1, "Elit", "Ex." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c30630-ef18-465b-9514-fc742de98727"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Orci", "Finibus sed, sociosqu hendrerit quam suspendisse aenean feugiat, suscipit vitae. Varius egestas elit, risus phasellus quam, dapibus ullamcorper lorem aliquet. Felis feugiat pulvinar, finibus consectetur mauris, nulla, cras magna gravida. Feugiat quisque auctor nisi, pretium elit blandit, porta ante interdum. Aenean cras posuere justo lacus nostra, himenaeos tincidunt tempor, mi.", 66m, 71m, "Aptent", "Amet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dui", "Mollis porttitor in eget mauris, arcu nostra, ut odio, taciti. A sed class bibendum, sodales egestas finibus dapibus cras conubia. Viverra vulputate commodo, mi nisi, cras conubia commodo nibh, vivamus. Risus orci, purus ante, aliquam cursus, dapibus erat, ultrices donec. Pulvinar tristique mauris, eleifend vestibulum nisl ullamcorper litora ipsum maecenas.", 10m, 76m, 0, "Vitae", "Velit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Aliquet", "Sollicitudin gravida taciti nam malesuada hendrerit conubia dapibus donec suspendisse. Suspendisse sagittis, id, rutrum sem accumsan convallis vestibulum, ornare cras. Arcu, ornare pulvinar, interdum, platea neque, condimentum arcu sodales ultrices. Euismod vestibulum nam diam vitae per sed, elit, gravida ante. Elementum sem nulla quis nec libero sapien sed, urna, lorem.", 12m, 20m, 0, "Maecenas", "Id." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Eu", "Convallis sagittis, a nunc, facilisis et mauris, molestie id lobortis. Habitasse euismod, hac litora fringilla, dictumst turpis nostra, mollis in. Pulvinar, ullamcorper aliquet feugiat tincidunt congue curabitur sollicitudin suscipit platea. Odio, massa mattis, interdum, himenaeos at phasellus auctor, cursus arcu. Mauris, eu tempor, faucibus dui, aptent suspendisse venenatis sit enim.", 23m, 32m, 1, "Id", "Lacus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff8504f-e274-4d9f-984b-df155739e516"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Lorem", "Amet, ipsum at conubia hac nisi euismod feugiat eget malesuada. Ut pharetra at gravida odio nec, et mi quam, phasellus. In nullam iaculis sem, hendrerit orci, maecenas dictumst diam aenean. Bibendum blandit ad sagittis nisl felis malesuada pulvinar, eleifend, elit. Pulvinar luctus tellus efficitur euismod, faucibus mauris donec porttitor laoreet.", 58m, 57m, "Finibus", "Rhoncus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Elementum", "Congue, torquent vestibulum vel praesent etiam sed morbi adipiscing convallis. Dapibus donec euismod interdum lectus, placerat vehicula pulvinar, id, cursus. Vulputate adipiscing proin mauris nulla, eros sollicitudin interdum non nulla. Amet, dignissim id, egestas nec, volutpat, mauris dictum blandit, cursus. Dictum id enim condimentum quis, accumsan sed laoreet, semper efficitur.", 14m, 7m, "Vehicula", "Malesuada." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vivamus", "Viverra id ornare sagittis aptent massa tortor, laoreet sagittis, per. Nullam blandit, malesuada ultricies nec imperdiet quis, eros aenean dignissim. Ante malesuada dapibus et, faucibus leo tortor aliquam arcu, venenatis. Fringilla, tellus placerat turpis lobortis enim ligula varius nibh porta. Sem rutrum nec venenatis luctus, quam, class conubia lorem, cursus.", 21m, 87m, 1, "Adipiscing", "Pulvinar." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Placerat", "Condimentum ullamcorper aliquet per non, tempor, sit nec a malesuada. Viverra sodales orci class ante posuere, elit, dignissim vitae neque. Finibus, sed, tortor, placerat interdum, sagittis, vestibulum praesent suspendisse mi. Consectetur sociosqu dolor tempor, ipsum maximus maecenas gravida lacinia, amet. Tempor erat vel pulvinar nam lacinia, libero nunc, magna, mattis.", 75m, 10m, 1, "Tempor", "Tempor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tempor", "Pulvinar commodo, orci leo pellentesque sapien ante placerat ultrices, tortor. Varius, ultrices tortor, donec pulvinar ornare sem, laoreet, curabitur nec. Dictum ad class ultrices interdum sem, felis nostra, porttitor, nulla. Sociosqu dolor enim ullamcorper pharetra nunc, rhoncus, condimentum vivamus cras. Fusce erat, fermentum ex, nec, conubia arcu sociosqu et eros.", 35m, 59m, "Ac", "Sagittis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21420154-8f18-4fb3-b745-60621cca5541"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Sagittis, gravida elementum rhoncus sagittis nec nunc, auctor, est ligula. Egestas placerat ex augue sit lacinia efficitur quam et, fusce. Rutrum eros, quisque ornare elit, fames elit accumsan dictumst commodo. Nibh euismod turpis ultrices magna blandit, aenean et, congue, interdum. Nam mi, odio, id nunc, ante, eget tellus, arcu, lacinia.", 96m, 84m, 0, "Turpis", "In." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Justo", "Interdum tortor, phasellus lectus dignissim sagittis, tortor risus felis nullam. Ante mi, vestibulum finibus in dolor commodo scelerisque ante, imperdiet. Blandit auctor, ex porttitor justo fringilla, vestibulum purus lacinia augue. Lectus, ac, lorem, sit habitasse nullam fermentum neque hac non. Aliquet vulputate vehicula ligula tellus mauris, mollis viverra sed auctor.", 91m, 61m, 1, "Suspendisse", "Cursus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dui", "Consectetur quis, laoreet, magna bibendum, torquent dapibus leo, porttitor, dui. Inceptos tortor, commodo etiam dolor, fusce id, arcu, odio, litora. Blandit, in pretium donec rhoncus sagittis elit turpis lobortis sem. Per at, malesuada eros elit, eget proin placerat purus ornare. Pulvinar auctor ligula ante ex, nunc, tincidunt eleifend, praesent nisi.", 88m, 54m, "Quis", "Efficitur." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Dui", "Mollis luctus, proin nunc nibh pulvinar, vivamus nec, aliquam nunc. Nisi rhoncus fringilla diam erat imperdiet sem amet, donec maximus. Dapibus eleifend tincidunt non, pretium ante, blandit, turpis adipiscing eleifend. Himenaeos congue turpis dui, nibh pulvinar id, nisl erat, in. Donec pulvinar platea nostra, tincidunt congue, a porta id, aptent.", 20m, 18m, "Nisi", "Magna." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "At", "Tellus, platea odio, eleifend fusce tincidunt sollicitudin maecenas mollis adipiscing. Porttitor euismod lorem proin arcu, porttitor, ut vehicula sagittis, est. Felis nulla, tristique proin torquent auctor ultrices, venenatis lectus donec. Tortor, maximus pulvinar volutpat, vitae at mauris elit, egestas rutrum. Nulla eleifend, volutpat, nullam convallis justo nisl varius, odio nostra.", 81m, 5m, 1, "Tellus", "Malesuada." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Rhoncus", "Pellentesque sem non, posuere nisi quis hac a imperdiet taciti. Nibh, hac risus nullam mi volutpat, ad nisi, enim vel. Consectetur dui sit finibus blandit amet per primis gravida ligula. Dui, quisque sapien phasellus platea nec, hac mollis a, amet. Nullam suspendisse sodales ornare conubia amet lobortis mattis integer odio.", 11m, 18m, "Auctor", "Sem." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Porttitor", "Porttitor tincidunt eros, erat nunc maximus nostra, posuere vestibulum aptent. Duis sollicitudin posuere eu luctus tellus dui arcu, amet mauris. Pellentesque nulla tempor, lorem, hac ultrices dolor, massa integer eros. Pulvinar nisi eu nam varius dui, eleifend, nulla purus cursus. Turpis mattis, mi sollicitudin ligula condimentum neque iaculis posuere neque.", 29m, 47m, 1, "Magna", "Tellus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Cras", "Vestibulum, blandit adipiscing vel, massa, hendrerit dapibus placerat curabitur orci. Non, inceptos auctor phasellus donec fusce in, fames sit blandit. Fringilla ex, iaculis tempor facilisis purus eget praesent proin vel. Erat sed sodales facilisis phasellus eleifend gravida malesuada nulla nibh. Tincidunt egestas volutpat, aliquam ad purus laoreet, quis euismod elementum.", 9m, 55m, 0, "Rutrum", "Eget." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("357cca07-da0f-4263-9575-9304ba791639"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Non", "Leo, feugiat, lorem, libero fringilla, mi, lacus tortor ac sollicitudin. Maximus ligula ac lacinia, arcu laoreet, finibus libero neque, mollis. Ex, porta, nisi at, cursus, sem, massa bibendum sagittis enim. Primis porta placerat risus porttitor, magna massa, odio, dapibus posuere. Lobortis cursus finibus donec porttitor, curabitur orci, vestibulum scelerisque eleifend.", 17m, 66m, 0, "Varius", "Dui." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quis", "At, maecenas ligula, tortor, orci sagittis turpis tristique efficitur laoreet. Ultricies aliquam arcu adipiscing ad rhoncus imperdiet quam, consectetur lacus. Lacus risus venenatis at, egestas aptent blandit, purus iaculis est. Rhoncus venenatis torquent massa, cursus bibendum luctus consectetur nulla etiam. Ut lorem imperdiet tristique nisl bibendum, tortor ligula, ultricies conubia.", 61m, 20m, 0, "Class", "Metus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nunc", "Turpis ad eros iaculis ac lacus amet eget sollicitudin dui. Imperdiet neque, conubia lobortis ligula, finibus, tellus, justo proin class. Molestie torquent lorem massa luctus, bibendum, fringilla, rhoncus ultrices elementum. Nostra, non interdum velit finibus, viverra luctus, per mauris tempor. Consequat enim erat efficitur cursus, congue, iaculis turpis tellus, ex.", 57m, 59m, 0, "Dolor", "Molestie." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Arcu", "At, ultrices, semper in, magna iaculis facilisis non, primis tristique. Semper tortor massa, mauris odio ipsum pharetra orci, fringilla lorem. Elit, sociosqu ex nisi donec lacinia ut consequat vel, dignissim. Turpis finibus ut congue nostra, risus dolor, erat, enim, odio. Vitae vitae, varius luctus augue tortor et praesent felis est.", 73m, 79m, "Mi", "Posuere." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Non", "Tincidunt sem, tempor id, imperdiet faucibus interdum, vitae, lectus porttitor. At ultrices eros, bibendum, vel mollis platea porttitor, odio, duis. Rutrum dictum diam velit ac, consequat nibh pulvinar, vestibulum, gravida. Proin odio, varius, ultrices curabitur iaculis per ipsum egestas phasellus. Porta, justo sagittis, amet, aenean nostra, viverra adipiscing a, odio.", 39m, 45m, "In", "Hendrerit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dictumst", "Sagittis enim sagittis, tempus interdum nostra, varius, massa, blandit, ante. Hendrerit varius sit lectus, tincidunt semper efficitur diam dui tellus. Justo placerat, a, hac ac, iaculis varius, bibendum, eleifend amet. Scelerisque rhoncus vel aliquam massa neque, risus cursus, non, torquent. Facilisis ultricies lacinia augue sed, ex tempor, leo, dapibus porttitor.", 22m, 66m, 0, "Quisque", "Torquent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4158bf42-0721-4e06-9ebd-ddf682240f7a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Rutrum", "Himenaeos dolor vestibulum enim, tempus condimentum mi, viverra finibus eleifend. Sociosqu eget tortor, rhoncus non per lectus semper rhoncus, felis. Est etiam at bibendum, a nisi, mattis, lacinia hendrerit ante. Nisi, ac nulla, enim quam, vestibulum vulputate arcu, interdum, eros. Hac sed, egestas elit, dapibus blandit quam felis aliquet magna.", 69m, 6m, "Pharetra", "Lacinia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nec", "Ullamcorper velit hendrerit libero lorem, lacinia, donec posuere, erat, porttitor. Eget hendrerit sollicitudin congue nec, nam lacinia neque amet, porta. Ex, nisl mauris, aenean ante aliquam condimentum neque molestie rhoncus. Aenean torquent libero fames nisl hendrerit sollicitudin at, nulla, tortor. Lacinia praesent orci laoreet blandit, ex, nunc commodo eu fusce.", 9m, 99m, "Accumsan", "Risus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"),
                columns: new[] { "Category", "Description", "Price", "Status", "SubCategory", "Title" },
                values: new object[] { "Interdum", "Vivamus dui magna, non massa, odio, ultrices, rutrum vel, tempor. Euismod finibus nulla, condimentum congue, venenatis feugiat, bibendum ipsum massa. Ultricies quisque varius, vel sagittis, facilisis ex a, elit, odio. Primis ullamcorper accumsan fermentum massa, adipiscing pulvinar porta, nisl laoreet. Amet, consequat in massa, viverra neque, magna nunc ut feugiat.", 63m, 0, "Sodales", "Est." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Tempor", "Nec at, tincidunt in, ultrices sem, quam id, tellus molestie. Sem, pulvinar fermentum varius, fringilla, purus faucibus mattis, phasellus vitae. Nulla, maximus fringilla, ex, lorem, varius, velit amet torquent vivamus. Euismod, sollicitudin sodales iaculis volutpat massa, mauris, est malesuada facilisis. Ipsum fermentum maximus sodales lorem eu adipiscing sagittis arcu luctus.", 0m, 50m, 0, "Vestibulum", "Lorem." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Tristique", "Urna, ultrices, torquent ultricies euismod nisi, lobortis fusce dui quis. Blandit, a, vel euismod, dignissim suspendisse porta laoreet, massa pellentesque. Interdum, cras tincidunt sagittis arcu erat, in, neque mi justo. Nisi lobortis nisl pulvinar, viverra auctor, proin eleifend elit aenean. Tempus posuere, finibus orci, platea porta, nulla per rhoncus lacinia.", 57m, 34m, "Iaculis", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Massa", "Massa nisl id bibendum, finibus porttitor feugiat elementum ipsum aliquam. Faucibus interdum donec scelerisque rhoncus enim, mattis, tortor lacinia sagittis. Est feugiat, in, nunc litora interdum, tellus, massa vel, sollicitudin. Torquent non, conubia id, semper pulvinar donec hendrerit viverra quam. Tempus ex, finibus, varius, et, dictumst etiam placerat, nisi, quam.", 49m, 85m, "Euismod", "Cras." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mattis", "Magna in ligula, blandit pharetra commodo, velit molestie maecenas tempor. Morbi mi, nam nisi sociosqu feugiat, urna, lectus per nibh. Tempor, placerat, eu sit nibh, volutpat eros, ipsum bibendum, erat. Elit sociosqu pellentesque curabitur nulla id, non odio sollicitudin massa. Turpis amet finibus, aenean himenaeos sollicitudin bibendum volutpat fames quisque.", 62m, 69m, "Lobortis", "Semper." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Enim", "Mattis aliquam placerat dolor, non varius, per congue et, euismod. Quis porta, conubia ut interdum quam, tempor lacinia dui, convallis. Neque, semper rutrum bibendum pharetra aliquam lacinia, dolor magna ut. Commodo, fringilla, fusce aliquam himenaeos vel egestas hac fames phasellus. Curabitur habitasse nisi varius dolor eleifend consequat turpis diam sed.", 53m, 22m, 1, "Vitae", "Tellus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nisl", "Pharetra placerat urna, mi sapien quisque ante amet vel, quis. Dignissim posuere, gravida eu etiam lorem, vivamus lacinia, pulvinar class. Fringilla, egestas faucibus mauris, sodales commodo ut id, fames feugiat. Semper vulputate ultrices, ipsum neque cursus, amet dignissim quis vitae. Pulvinar aptent lorem convallis ad mattis, eu, elit, rhoncus, sem.", 43m, 79m, 0, "Risus", "Quam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Bibendum", "Lacinia non facilisis elementum tempor nullam mollis orci id, luctus. Vel aliquam dignissim nisi mauris, elit dui, lectus, ut primis. Efficitur lectus nunc, mattis, conubia auctor turpis amet tincidunt rutrum. Rutrum vestibulum non bibendum fusce nostra, vel, condimentum feugiat elit. Aptent habitasse non, lacinia, per duis mattis, enim magna ipsum.", 1m, 54m, 0, "Mattis", "Amet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53c7a9de-03b5-4482-8163-2d925ca7f3c5"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Felis", "Porttitor dignissim tortor, gravida urna tristique enim suscipit vel eleifend. Ad sapien metus lobortis class eu placerat porttitor commodo, id. Curabitur id eu felis varius, placerat, varius eget laoreet elit. Cras tortor blandit massa, porta neque vitae varius, tempus ligula. Sed metus turpis purus enim tincidunt euismod, accumsan nisi pulvinar.", 5m, 69m, 0, "Mi", "Et." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("543372da-be2f-4ef6-8496-98a8a075799c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Litora", "Ex, nisi, aenean nulla, nisl cursus, aliquam suspendisse dolor lorem. Nec, erat, condimentum dignissim interdum a, ultricies vestibulum mattis per. Tortor, proin nibh, consequat vel luctus laoreet feugiat, quam nunc. Tellus, mi tellus accumsan suspendisse lectus, lacinia, lorem ac phasellus. Quis, rhoncus mi, turpis aptent auctor odio, at, venenatis leo.", 93m, 59m, "Quam", "Mattis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Mattis", "Blandit, lacinia, mattis, interdum vitae, dui, placerat, nullam varius, porttitor. Donec platea ad torquent euismod odio, litora suspendisse sem consequat. Curabitur finibus, vestibulum, erat tempus nam euismod, ultrices sed, habitasse. Duis dapibus libero elit, fames ad ex non facilisis dignissim. Posuere sapien vehicula congue, lorem, erat accumsan turpis condimentum interdum.", 76m, 66m, "Id", "Faucibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quis", "Leo lacinia, sagittis inceptos at eu, hendrerit posuere, facilisis eros. Vitae, ornare porta, nunc integer aliquam nec lacus sem, ex. Amet suscipit id, dictum placerat orci dictumst a, lorem conubia. Dictumst ex, luctus, nec, torquent quam, interdum, auctor lectus, pulvinar. Purus rhoncus neque risus class eu, vestibulum, nibh, sem fringilla.", 47m, 60m, 1, "Cras", "Interdum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Rutrum", "Mauris, iaculis venenatis felis lacinia, eu, feugiat nullam posuere nec. Ac, elementum platea eros gravida porta, sagittis, tempor ornare curabitur. Lorem, congue, ac congue ullamcorper vehicula in rutrum dui, torquent. Commodo nulla, egestas euismod, mi auctor, ligula, pulvinar magna, adipiscing. Massa maximus sollicitudin orci, nibh, nam augue class non, eu.", 45m, 53m, "Molestie", "Sed." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Sapien", "Arcu, conubia ornare nunc, porttitor, dictumst vitae, quis metus massa. Consectetur viverra vitae, diam molestie pulvinar, sit dapibus feugiat, tellus. Semper commodo habitasse nec risus in nisi malesuada interdum erat. Maximus interdum placerat mi, lorem elementum eros nulla at interdum. Ante, gravida eleifend volutpat auctor quam lorem elit arcu consequat.", 61m, 71m, 0, "Integer", "Bibendum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Cursus", "Diam et euismod, non lobortis et, inceptos tempor, vitae nisi. Consequat lacinia, in, mollis eleifend, ornare nisi, ultrices, finibus, nibh. Varius finibus, mollis bibendum, accumsan torquent conubia euismod, volutpat egestas. Posuere malesuada eros, hendrerit pharetra nisi arcu, finibus, convallis praesent. Nam blandit, morbi vehicula porttitor id at, sit hendrerit lacinia.", 37m, 24m, 1, "Molestie", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lorem", "Eros aliquet tellus dui augue class tempus nisi, viverra taciti. Scelerisque porta, dictum gravida viverra dui, luctus, urna, proin varius. Id diam dui quis, nibh turpis morbi pulvinar, risus finibus. Luctus pulvinar, arcu urna taciti et tincidunt urna, ligula, ipsum. Dui, aenean consequat tellus orci, leo quam, inceptos urna, eros.", 88m, 62m, 0, "Sapien", "Finibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Quis", "Orci lacus amet, luctus, commodo, inceptos pretium nec commodo vel. Duis porttitor sit magna per volutpat eros, eu suscipit lorem. Dui primis aliquet platea pellentesque augue semper luctus, fames velit. Justo magna habitasse eleifend lacinia, dictum ultrices, consectetur leo neque. Class pulvinar tristique eleifend eu enim metus bibendum, est porta.", 47m, 22m, "Mollis", "Vulputate." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Mollis", "Nunc, eget odio elementum adipiscing vel vivamus dui mi integer. Vitae, curabitur feugiat placerat, blandit massa, eget vulputate enim, blandit. Massa, elit, fusce dictumst tincidunt eget accumsan viverra sit tortor. Ipsum adipiscing justo eleifend, dui, at, in, pulvinar, nulla risus. Hac urna magna, velit convallis consequat ac rhoncus, tempus varius.", 76m, 45m, 0, "Eu", "Duis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory" },
                values: new object[] { "Et", "Accumsan id malesuada nulla, ante ante, ex elementum dolor, urna. Erat semper augue cras mollis dolor nostra, bibendum, sapien a. Luctus neque posuere, feugiat inceptos elit, morbi aliquam vestibulum, volutpat. Massa elit, mattis, vulputate egestas nisi dictum enim, ad consectetur. Condimentum nulla vestibulum dapibus elementum gravida ante dui, luctus, odio.", 49m, 36m, 0, "Nunc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Lorem", "Sed, rhoncus sem, platea nibh bibendum, nibh, eget turpis luctus. Ac, blandit, blandit aliquet sed nunc, nisi luctus cursus, efficitur. Mattis, nunc, lorem, dictum aptent pellentesque orci eros, et luctus. Placerat, odio, metus fames taciti pulvinar in mattis nisl molestie. Purus dui vivamus molestie non, condimentum lectus habitasse dolor, tellus.", 22m, 47m, "Laoreet", "Odio." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Dictum", "Lorem, et, ac, est platea eu, vulputate himenaeos nibh, dolor. Luctus, amet vel amet, aliquet dolor ac, sed sem, rutrum. Ex porta, rutrum arcu, vestibulum bibendum, vitae, quam sed maecenas. Volutpat lacinia enim pharetra aliquam scelerisque lobortis magna, cursus cursus. Sit mi, nullam magna fusce nunc nunc, quis, urna, nec.", 61m, 7m, 1, "Per", "Cursus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Libero", "Vel, nibh, luctus, tempor cursus amet ultrices torquent eros nulla. Feugiat, ac interdum, mollis sagittis tempor, nullam diam nam cursus. Non nisl suscipit pharetra sociosqu felis vitae hendrerit class elit. Litora varius orci aenean volutpat ut eleifend pharetra ligula, nulla. Erat, sociosqu dui fringilla, lobortis auctor libero nunc luctus sit.", 95m, 43m, "Class", "Conubia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Commodo", "Risus cras consectetur pellentesque blandit, vitae, non, nibh, iaculis massa. Nec finibus, justo ex scelerisque nulla himenaeos augue malesuada blandit. Aliquet nisl vestibulum mattis lacus dolor accumsan volutpat feugiat, sociosqu. Aliquam bibendum porta ut nulla, tortor posuere, orci eros auctor. Torquent vestibulum nulla nisi tristique sit in primis quisque semper.", 70m, 1m, 1, "Neque", "Donec." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Massa", "Duis ullamcorper porttitor, class proin inceptos nostra, eu sapien euismod. Nec, dignissim euismod id, maximus justo vivamus mi, in nam. Pretium quis vitae erat finibus placerat, urna, auctor, consequat lorem. Odio, quisque malesuada nam orci, habitasse luctus rhoncus, dignissim nec. Orci semper lacus efficitur integer felis placerat, ultrices phasellus pulvinar.", 45m, 43m, 1, "Arcu", "Nulla." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "A", "Aliquam magna, consequat finibus, ante, nec, urna, dui, sagittis, mauris. Dui, interdum lacus magna amet, odio lectus, commodo, porta, gravida. Porttitor, consectetur vel, nisi lectus varius taciti mauris himenaeos arcu. Vivamus dictumst urna, ipsum elit semper orci, lacus eleifend lorem. Non litora sociosqu enim, luctus accumsan diam ipsum nisi mi.", 66m, 30m, 1, "Velit", "Nec." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("836bf6f7-71a6-485d-8514-455393908657"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ligula", "Iaculis dui ac, porttitor, malesuada urna fusce eros sem torquent. Dui, arcu, porttitor, ante orci, posuere, dapibus accumsan sem tristique. Nibh, odio, interdum etiam non libero in eu, blandit, leo. Himenaeos duis sollicitudin eu placerat ligula, tristique mollis dignissim sed. Mattis nisl urna maximus tincidunt laoreet, vestibulum massa in, sem.", 2m, 24m, "Quam", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Iaculis", "Nunc sit ex felis platea vehicula neque dictumst porta a. Pulvinar rhoncus, interdum at, ultrices, adipiscing in fusce tristique id. Ullamcorper ac dui molestie augue ultricies quis massa, in, fringilla. Pulvinar, porttitor luctus, himenaeos vestibulum id, feugiat, elit, elementum vitae. Nec lobortis facilisis volutpat, aenean elit, dui, nunc, neque, aliquam.", 61m, 48m, 0, "Facilisis", "Dictumst." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Convallis", "Sodales orci congue, dolor elit venenatis imperdiet dolor, non sociosqu. Tempor erat, mauris, lobortis nec, ante lorem, convallis quam donec. Lorem, eros, lacinia nullam quam, nostra, feugiat, nibh iaculis sed. Feugiat, praesent nibh, ullamcorper et lectus, elementum et, imperdiet euismod. Nunc, dictumst lectus, malesuada eget tempus sem, quis, mattis ultrices.", 51m, 27m, 1, "Tellus", "Dapibus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Semper", "Imperdiet aptent amet, maximus lacinia duis porta, conubia eros, egestas. A, lectus, feugiat ultricies blandit, eros, magna, fusce laoreet, justo. Semper erat felis commodo inceptos purus tempor, enim convallis suscipit. Vestibulum, amet, lorem dignissim euismod eros ac nunc ut congue. Pulvinar eros, elementum blandit lacinia, consectetur integer nostra, sagittis euismod.", 97m, 99m, 1, "Gravida", "Ad." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Primis", "Odio, pellentesque elit dolor quis laoreet cras tempus maximus sem. Efficitur eros, aliquam adipiscing arcu fusce suscipit ut platea felis. Convallis dui, nec, leo, massa, placerat mi, magna mattis arcu. Torquent dictumst magna, massa, convallis eu, metus erat interdum, arcu. Mi odio, lorem rhoncus eleifend, amet curabitur in nunc in.", 27m, 74m, "Torquent", "Eleifend." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Maximus", "Fames litora ac, pulvinar, dictum libero per himenaeos aenean sollicitudin. Ante, lacinia, vitae, amet, non, mattis diam tortor aliquam sapien. Inceptos ad ligula, auctor, augue dictum porta, fames est scelerisque. Fringilla torquent morbi odio nunc duis mollis tempus nunc, odio. Odio, tellus ex nisi, metus fringilla adipiscing ornare ullamcorper quis.", 97m, 52m, "Adipiscing", "Luctus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vehicula", "Et dapibus porttitor, nunc lorem ac nibh lectus dui, malesuada. Egestas facilisis aenean hendrerit a quis, porta, leo, iaculis proin. Blandit erat a, tincidunt vestibulum aliquet integer interdum, nec curabitur. Id, euismod, sollicitudin quisque convallis tristique urna mi, maecenas lacinia. Suscipit auctor nulla, id, pellentesque blandit, a, donec mi, facilisis.", 71m, 5m, 1, "Dolor", "Suscipit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("962d2024-995d-4165-89c9-55e15d2176e3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Tortor", "Fermentum scelerisque posuere tellus est hac ultricies urna, a, in. Blandit, imperdiet tortor, hac maecenas fringilla, eros massa viverra lorem. Lacus congue, feugiat eros, congue a auctor, quis auctor hendrerit. Posuere nisi, odio, maximus fusce bibendum enim sapien lectus, feugiat. Bibendum, sociosqu vestibulum volutpat lacus suscipit viverra tincidunt lobortis risus.", 70m, 1m, 0, "Feugiat", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Suspendisse", "Quisque nec, a porttitor, proin leo, fusce condimentum ornare ultricies. Odio cursus eleifend ac, arcu, augue nostra, sem, vehicula scelerisque. Ullamcorper class himenaeos gravida tempor est nostra, magna, a cursus. Nostra, auctor sed, fringilla, lectus, aptent eros conubia faucibus neque. Tempor, hendrerit laoreet posuere leo ad ullamcorper pretium nostra, pellentesque.", 48m, 31m, 0, "Lorem", "Ullamcorper." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ut", "Ante, quisque curabitur varius, nec, ligula, proin vitae, vitae in. Amet vel, malesuada rhoncus, sapien ullamcorper vivamus eget orci dictumst. Pharetra euismod egestas vel, nunc, auctor nostra, taciti consequat sem. Magna, ad accumsan dapibus ligula, gravida ligula donec sollicitudin diam. Aenean ipsum hac taciti auctor, porttitor ante, tellus diam eget.", 76m, 52m, "Odio", "Euismod." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lectus", "Suscipit odio nisl orci, fringilla, fermentum erat torquent neque et. Aptent proin nam mollis nunc, fames vitae, metus pulvinar morbi. Orci orci, eleifend ante dui, nostra, metus congue, elit euismod. Facilisis ante est placerat elit, iaculis lacinia, finibus, purus quam. Vitae, lorem, lectus sagittis, ipsum aliquet dolor, amet, massa, dui.", 83m, 40m, 0, "Finibus", "Nullam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Sit", "Ligula hendrerit commodo lorem fermentum vestibulum, sit auctor, augue nisi. Fermentum blandit inceptos interdum, fringilla nec egestas felis rhoncus sociosqu. Porta ad cursus, elit ac ullamcorper nulla, lorem praesent class. Platea placerat, tempor, sagittis quam, pharetra odio finibus, eget quam. Ad fames ultricies donec in vivamus nibh cursus, sem blandit.", 0m, 12m, 1, "Tempus", "Tempus." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Massa", "Leo faucibus litora nisi mauris, felis hendrerit dictumst lorem est. Nostra, interdum, odio, magna laoreet libero lorem, dui, mattis porta. Dui, varius aptent interdum pretium leo, taciti venenatis lacinia nisi. Molestie pellentesque nulla, rutrum quisque congue, amet integer lacus metus. Interdum magna sed porta, sapien a, lorem sollicitudin tempus ac.", 8m, 31m, "Fames", "Porttitor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Commodo", "Sed, viverra arcu sed habitasse dapibus mauris a id, dictumst. Auctor, nullam cras lectus, etiam porttitor eu eu, libero in. Integer eget lectus, ac, efficitur in, lectus sagittis, varius, suspendisse. Fusce convallis orci sociosqu varius, inceptos arcu, sodales cursus ante. A odio, nam luctus, tellus, congue, orci, pulvinar, neque tempor.", 5m, 24m, 0, "Hac", "Blandit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Nunc", "Mattis a id, class porta velit laoreet rhoncus mauris, urna. Tortor, torquent laoreet ipsum amet, felis nisl imperdiet at auctor. Adipiscing sociosqu finibus aliquet nostra, ullamcorper orci finibus, arcu, per. Fames sed nunc, cursus nisi, mauris, platea tellus nec, placerat. Accumsan magna ipsum ante est tortor, lacinia praesent laoreet, torquent.", 67m, 93m, "Egestas", "Diam." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Ultrices", "Suspendisse nisl sagittis urna lacinia, porta, placerat, feugiat, porttitor, ultricies. Vestibulum, nullam blandit iaculis suscipit eu sodales rhoncus, eleifend, volutpat. At porta nisi faucibus fringilla, hac ultrices cursus, nunc fermentum. Accumsan et, eget aenean vestibulum, class per tempor, ac nunc. In, vivamus ac nulla, laoreet mauris, urna pulvinar, fusce velit.", 49m, 76m, "Vestibulum", "Aliquet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Quis", "Urna eleifend, sem, ultrices vehicula odio, tempor, mollis erat lorem. Lectus condimentum arcu, vivamus diam sem pretium porttitor, et nam. Sed aenean pharetra posuere finibus dui, iaculis taciti vestibulum, gravida. Congue fringilla, nunc pharetra dignissim diam nisi, integer tortor, ligula. Tincidunt vehicula lectus, enim integer fermentum et efficitur finibus, non.", 7m, 24m, 1, "Nec", "Nec." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adaa5968-bab8-433d-abc6-217d49fa3395"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Vel", "Vitae mattis quam, risus varius, id, nisi, interdum, ultrices laoreet. Urna non nulla ultrices imperdiet ac placerat, adipiscing sed porttitor. Neque, mi tortor dolor fringilla consectetur inceptos condimentum gravida ullamcorper. Varius, vivamus elementum quisque ad massa ipsum non integer erat. Nulla, dapibus orci bibendum, libero duis faucibus ultricies elementum laoreet.", 66m, 65m, "Etiam", "Nostra." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Donec", "Litora dictumst vivamus per turpis inceptos vehicula egestas tortor, duis. Lorem lacinia, et, ante, sagittis nibh vestibulum, mollis sem ipsum. Posuere purus tempor, proin litora sem, maecenas quis aptent congue. Per ultricies himenaeos bibendum pharetra luctus, consectetur laoreet, a, nulla. Neque, posuere, quam placerat at himenaeos blandit accumsan quisque fringilla.", 39m, 22m, "Euismod", "Gravida." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Congue", "Odio, hac metus sem pulvinar, in feugiat orci, laoreet, porta. Lorem pulvinar lobortis massa mi nunc quisque commodo, consectetur ac. Elit fermentum commodo, egestas ipsum consectetur tellus rutrum praesent class. Ligula, quam, efficitur non, elit, lectus, porttitor diam torquent enim. Tincidunt euismod, sapien praesent pulvinar pulvinar, et feugiat, luctus, malesuada.", 77m, 48m, "Ornare", "Imperdiet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Lectus", "Magna commodo lectus sollicitudin commodo, lacinia arcu varius, cras volutpat. Ornare risus magna blandit tellus, eleifend fringilla dictum dignissim pulvinar. Rutrum ultrices, inceptos dictumst class fames dolor, hac rhoncus, tortor. Bibendum massa tellus, tincidunt mattis magna, euismod commodo, pretium in. Justo bibendum felis et, malesuada litora nam consectetur class odio.", 54m, 86m, 1, "Arcu", "Euismod." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Proin", "Magna, hendrerit at, habitasse vitae, condimentum donec urna, porttitor erat. Feugiat, ipsum finibus nibh, lectus, posuere, vel ante vestibulum, imperdiet. Velit urna commodo finibus venenatis sagittis, litora varius dictumst fusce. Volutpat nullam tempor nostra, posuere at porttitor primis tincidunt interdum. Sed, aliquam consectetur condimentum elit, feugiat, pharetra volutpat velit tortor.", 0m, 46m, "Praesent", "Pellentesque." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Duis", "Ornare malesuada imperdiet vitae, et lectus, dictumst per laoreet blandit. Ultrices etiam lobortis praesent tempor, sollicitudin ornare amet, vestibulum per. Sagittis tortor ante, luctus, taciti consequat nam convallis ipsum feugiat. Ex lectus mattis cursus ante, vitae lorem, volutpat, orci hac. Dictum congue diam dolor semper amet, euismod, duis himenaeos lacus.", 97m, 7m, 0, "Cursus", "Quisque." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Turpis", "Dictumst elit lorem, proin sit varius id mattis maecenas tellus. Neque, dolor nibh tempor bibendum, imperdiet convallis hendrerit elementum eu. Libero dignissim urna adipiscing orci tempus rhoncus, amet pulvinar tempor. Libero duis pharetra arcu posuere faucibus erat fusce torquent laoreet. Dictum commodo, est in integer finibus urna adipiscing fusce feugiat.", 89m, 66m, "Accumsan", "Sit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Maecenas", "Adipiscing at porta, nibh, quisque platea congue, integer in cursus. Elementum vehicula magna, aenean vel, sed neque, lacinia, velit congue. Ullamcorper ex sociosqu mauris varius etiam purus dolor ipsum nec. Tellus, platea rutrum et, dui, nunc, metus quam, nec, pretium. Volutpat habitasse amet, urna vivamus nisi nisi, magna, lacinia vestibulum.", 38m, 80m, 1, "Ipsum", "Lacinia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba3c9243-5390-488e-b598-2779fd398da8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Efficitur", "Quis quis, purus auctor, ultricies convallis pretium leo, elit nisi. Habitasse sit fusce dui, conubia nunc, rhoncus, et, erat luctus. Arcu odio ante cursus, volutpat, viverra torquent dapibus accumsan neque. Lectus primis maecenas rhoncus, bibendum eu eros eu, nam a. Iaculis interdum a morbi varius fringilla, molestie elit, blandit justo.", 12m, 61m, 0, "Fermentum", "Nisl." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Nullam", "Mollis odio, at, amet, mattis, iaculis turpis molestie vestibulum, nisl. Condimentum odio neque vulputate vivamus dui luctus, vel auctor consectetur. Consectetur sit rutrum nulla, adipiscing sem, nisi tincidunt at, faucibus. Sagittis, ultrices enim, convallis posuere, odio ex, pulvinar sagittis quis. Lorem, porta eu aliquet praesent pulvinar, varius maximus purus urna.", 30m, 55m, 1, "Scelerisque", "Habitasse." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Sit", "At risus leo euismod, magna, interdum, neque, suspendisse nisi ligula. Porta, nisi, integer in, commodo in at, eros, sagittis lorem. Sed felis euismod blandit dapibus justo ex, proin mollis et. Vestibulum dolor auctor, nec, lacus sit porta tellus erat, feugiat. Neque tincidunt molestie non, lectus, vivamus donec sapien et imperdiet.", 33m, 59m, "Ad", "Massa." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Turpis", "Adipiscing diam primis ex nostra, tincidunt suscipit hac nulla erat. Feugiat, et, fringilla, volutpat mi dapibus finibus quisque erat blandit. Euismod est venenatis primis ex iaculis odio sapien maecenas tristique. Aenean ut ad enim, vitae, congue facilisis libero consequat neque. Eu nisi, ullamcorper ac euismod, volutpat laoreet, morbi mattis nunc.", 92m, 3m, "Sapien", "Vulputate." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"),
                columns: new[] { "Category", "Description", "Price", "SubCategory", "Title" },
                values: new object[] { "Et", "Quis, vitae, auctor maximus metus lobortis pellentesque nibh mollis scelerisque. Nibh fusce sagittis, nibh, lacinia, vel, in praesent feugiat, quisque. Maximus laoreet, interdum, rhoncus odio, suscipit orci volutpat, nulla, maecenas. Nibh, dui, posuere magna odio tempus a himenaeos malesuada diam. Ullamcorper feugiat duis platea inceptos eleifend, imperdiet congue, tristique magna.", 92m, "Neque", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Hendrerit", "Elit, elit blandit aliquam turpis odio ante lobortis nisl nulla. Malesuada nunc arcu, praesent neque vitae volutpat efficitur consectetur eros. Congue, tortor, arcu, ex, consequat tortor id, et, pulvinar, ex. Mattis nulla dolor, dictum quam arcu, quis lacinia accumsan morbi. Quisque varius imperdiet blandit, amet, venenatis tempus eros, aptent ac.", 4m, 70m, 0, "Nunc", "Vestibulum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Velit", "Amet, augue congue lorem ut volutpat sagittis, vitae, arcu, arcu. Urna, ante congue, varius at, justo sit nam eros, quis. Vel, in, platea euismod, sagittis, vivamus praesent dolor ultrices, ac. Vel congue laoreet risus ultricies sem eu, dignissim vivamus porta. Justo quam interdum pretium sagittis, fringilla, consectetur curabitur hendrerit platea.", 54m, 53m, "Purus", "Erat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Rhoncus", "Faucibus ut rhoncus blandit sapien arcu, nisi urna, posuere, varius. Vehicula felis gravida porttitor, sagittis nec, velit aliquet morbi tortor. Odio, lorem faucibus pharetra at euismod etiam ultrices, elit lobortis. Morbi id nostra, leo sollicitudin dictum porta, convallis ipsum phasellus. Congue neque cras arcu, sed quam duis lorem mauris, vestibulum.", 49m, 15m, 1, "Interdum", "Porta." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Placerat", "Pharetra vel, quis, a blandit, finibus lorem leo, faucibus nisl. Non diam congue, purus magna egestas conubia molestie nibh, nam. Blandit pulvinar, volutpat, nunc, rhoncus, sem etiam ante integer sagittis. Semper sed augue tellus, auctor, nec, congue quam iaculis placerat. Ac ut lorem leo, ligula cursus facilisis adipiscing finibus, eros.", 95m, 74m, 0, "Ornare", "Sit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Amet", "Nisi, praesent tellus lacinia faucibus et tempor, ligula ultrices aenean. Magna, ipsum pulvinar cursus neque, litora sagittis ac vivamus rutrum. Semper phasellus integer volutpat pulvinar, lorem, a, ligula dolor sed. Placerat, commodo ornare interdum fringilla, porta est lectus metus morbi. Porttitor, fringilla, libero interdum, mattis, lacinia est lacus mollis urna.", 65m, 98m, "Bibendum", "Amet." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Odio", "Malesuada odio, litora diam etiam nostra, dapibus ac sem amet. Quam eleifend, condimentum nec justo convallis sapien posuere risus varius. Rhoncus, dictum semper mauris, hac inceptos ante dapibus accumsan commodo. Euismod sollicitudin molestie in placerat amet proin placerat, eros tellus. Varius, odio fermentum nec odio, semper iaculis hac lacus eget.", 34m, 65m, "Ultrices", "Suscipit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Pulvinar", "Rhoncus, vulputate odio, ligula tempor tincidunt enim sed, laoreet, a. Orci vel odio, per metus finibus dolor eget malesuada lacinia. Enim ipsum donec neque, imperdiet facilisis pulvinar, sem, nibh, nibh. Viverra finibus, dolor mauris elementum vivamus sagittis, a, rhoncus imperdiet. Erat id, ipsum nulla, diam ut blandit volutpat per ullamcorper.", 35m, 33m, "Nullam", "Nec." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Orci", "Mattis dolor, tortor laoreet, euismod iaculis purus elit, posuere sodales. Vel proin malesuada nibh, per facilisis sem eget pharetra rutrum. Tortor per euismod erat, porta cursus, ac vel, euismod, nisi. Viverra sem lorem amet, rhoncus mollis elit, nec fames molestie. Porta rhoncus sapien scelerisque felis condimentum nunc phasellus viverra curabitur.", 1m, 16m, "Mauris", "Commodo." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Cursus", "Cursus, interdum, varius, massa arcu, et blandit, odio, ligula, torquent. Scelerisque ad ultrices, blandit, dui, accumsan bibendum, convallis ligula, eros. Egestas odio libero fringilla, bibendum vulputate euismod, quam, inceptos nisi. Odio, sociosqu scelerisque mauris, massa, risus litora mattis, cras nec. Tincidunt orci, sagittis elit, tellus, aenean leo, hendrerit sed tempus.", 11m, 47m, 0, "Mattis", "Arcu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Blandit", "Finibus, velit magna vitae, fames magna, varius metus lorem lacus. Lacus suspendisse maecenas euismod, laoreet, aptent vestibulum, ac hac congue. Eleifend ullamcorper placerat, vehicula auctor, venenatis sem, mi, habitasse pharetra. Id tellus porta nunc fringilla, pellentesque sagittis, eget faucibus ultrices. Ultrices fusce massa ex euismod orci, commodo interdum, ultrices, velit.", 37m, 40m, 1, "Porta", "Enim." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Enim", "Dignissim diam fringilla, dictum sapien rutrum vestibulum, eu feugiat, ligula. Feugiat vel, luctus platea et non nulla tellus, porttitor bibendum. Litora tempus cursus, ac, non eros, diam mauris proin pharetra. Enim nisl curabitur fringilla, magna, id tempus venenatis tempor lacus. Lacus ante volutpat lectus, duis in, tortor, auctor, nam nisi.", 47m, 45m, 1, "Fringilla", "Torquent." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Eros", "Etiam auctor erat, nibh, tortor, accumsan at nisl lectus vitae. Sit finibus fusce eu tempus vivamus himenaeos vestibulum molestie commodo. Cursus, sem, at, praesent pulvinar sed, feugiat massa euismod, interdum. Urna fringilla amet, lacinia, metus neque id eros, sem condimentum. Venenatis at placerat, tempus tincidunt dui eleifend, non, massa, id.", 58m, 27m, 1, "Morbi", "Mi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f19d67-4312-431c-a3f9-1a76d5306820"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Purus", "Molestie varius eleifend, posuere, quam mauris pulvinar, eros, tempus sed. Praesent torquent laoreet feugiat sodales id accumsan gravida vivamus ad. Turpis tempor at, faucibus ultrices, elit, viverra pellentesque fringilla, nunc. Vulputate sem, maximus aptent habitasse gravida eu, vehicula ac ex. Convallis rutrum posuere cursus laoreet, luctus eros, quisque congue, tellus.", 78m, 35m, 1, "Nisi", "Sollicitudin." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Posuere", "Et ligula, pellentesque non, sollicitudin morbi pulvinar elementum eu sapien. Risus egestas porttitor, adipiscing a, iaculis tellus, sed, vivamus pellentesque. Nibh odio, quisque risus conubia venenatis sem nisl dictumst lectus. Dictum sed porta, turpis suscipit etiam aptent tempus dignissim efficitur. Magna bibendum, morbi ligula orci, justo urna sagittis, nullam ac.", 71m, 69m, 0, "Congue", "Posuere." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "Rhoncus", "Magna, ac, quam arcu mollis primis faucibus id, fringilla sed. Hac tempor tempor, erat, quis placerat, inceptos primis pellentesque ligula. Ante, nullam commodo condimentum magna, fringilla tortor efficitur iaculis vestibulum. Nunc sodales turpis venenatis feugiat ante, laoreet commodo, pellentesque blandit. Fusce aenean sapien nisi, sed, aliquam pretium varius, eget maximus.", 82m, 25m, "Magna", "Feugiat." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "SubCategory", "Title" },
                values: new object[] { "A", "Vivamus sapien varius, malesuada etiam pellentesque ultricies convallis dolor, urna. Luctus, quam, elementum magna mollis vitae purus posuere, neque volutpat. Eros, consequat quam, mattis, neque eu, orci augue neque, torquent. Iaculis urna consequat aliquet magna, nostra, magna fusce lobortis morbi. Quisque porta, nulla, bibendum commodo, lectus in faucibus diam fames.", 6m, 34m, "Bibendum", "Interdum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"),
                columns: new[] { "Category", "Description", "Price", "Quantity", "Status", "SubCategory", "Title" },
                values: new object[] { "Vestibulum", "Ligula quis pulvinar, placerat magna, dui hac nullam facilisis at. Mattis integer cursus, mauris, tellus commodo rutrum pellentesque mollis leo. Turpis blandit, diam ligula nec, vitae, imperdiet eu morbi feugiat. Bibendum gravida a arcu, odio ac iaculis nisi libero pellentesque. Nostra, facilisis volutpat, pulvinar ultrices, vitae elementum urna congue nulla.", 12m, 55m, 0, "Ex", "Egestas." });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Taciti ligula duis in eu, velit porttitor, dolor, vehicula magna. Phasellus massa, magna aliquam velit lobortis lacus mauris molestie justo. Aliquam odio duis litora turpis tortor amet, eget hendrerit laoreet. Rhoncus nec, ullamcorper luctus, torquent vitae auctor malesuada ex elit. Interdum quam vivamus mollis curabitur suscipit viverra mattis erat consequat.", "Tellus.", "Efficitur in" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Nullam at, urna enim, vitae, feugiat tortor, tempor varius, tellus. Hac tellus maecenas ad taciti elementum nulla, primis sapien fames. Dui, eleifend, dignissim massa, commodo, semper sed tellus, duis vitae. Leo, laoreet, quis, habitasse adipiscing sem in, rutrum euismod, etiam. Ex, laoreet ullamcorper lacus hendrerit et augue porta nullam elementum.", "Justo.", "Nibh euismod" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Commodo magna bibendum per blandit nunc semper et, dolor, lacinia. Eros non faucibus nec congue taciti ac mi fames accumsan. Maecenas augue lobortis fringilla aliquet rutrum placerat metus habitasse pretium. Feugiat, quis, pharetra lacinia, elementum amet integer platea scelerisque dolor. Faucibus vel augue euismod, sodales convallis class tempor, laoreet, mollis.", "Ante.", "Elementum elit" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Nunc, conubia tempor, maximus luctus leo massa, consequat enim sodales. Varius, suspendisse platea a amet lacinia, neque, in, diam rhoncus. Enim, tempor finibus, amet nulla, litora commodo eleifend elit molestie. Vitae egestas in inceptos mattis interdum, amet ante, sociosqu at. Eget leo felis dictum arcu, nullam hendrerit nec, aliquet himenaeos.", "Neque.", "A justo" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Orci proin lectus est laoreet commodo, luctus felis fusce nostra. Quisque quam, erat praesent laoreet, rhoncus, iaculis maximus consectetur eleifend. Quam, volutpat tortor ad fringilla aenean feugiat, posuere mattis, arcu. Elementum rutrum feugiat lacus lorem semper sem praesent auctor, hac. Consectetur nulla vivamus faucibus vestibulum vitae lorem est nullam mi.", "Auctor.", "Morbi malesuada" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Primis per sagittis, sed proin sem nunc semper platea erat. Ullamcorper cras urna, mauris conubia justo aliquet interdum, risus sed. Et, odio scelerisque imperdiet porttitor, odio, nisi fringilla, erat, justo. Finibus nunc ligula, auctor luctus magna, sagittis, bibendum nisi laoreet. Euismod massa, odio primis non, commodo, fermentum egestas interdum, pellentesque.", "A.", "Dictum class" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Tortor, sem, volutpat at iaculis ac convallis luctus, pulvinar, primis. Nullam porttitor dui, vivamus vel, nam feugiat, dictum urna quis. Congue ac urna, viverra scelerisque lorem sem luctus nulla sagittis. Quam tortor arcu, in venenatis quam, porttitor mi, ipsum ac. Ante ex, placerat, integer erat, nulla, nisi cras risus proin.", "Dignissim.", "Nec euismod" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Luctus, placerat vestibulum viverra ornare ante, dignissim volutpat eros dolor. Congue, erat vestibulum, per tempor, varius lorem massa, pulvinar, massa. Vel, aliquet felis ultrices, vitae, sollicitudin sem lacinia, dapibus accumsan. Praesent mi elementum aenean eros luctus, ac luctus enim cras. Cursus, rhoncus amet dolor, volutpat, mollis sodales rutrum maecenas curabitur.", "Dapibus.", "Est ornare" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Rutrum imperdiet elit habitasse sapien massa ornare platea augue egestas. Volutpat, bibendum proin at, erat, eleifend vestibulum, leo laoreet in. Maximus non phasellus vitae, odio, lacinia per lacus curabitur porta. Ex sagittis purus pellentesque elit, tempor ac, duis dui porta. Maximus vestibulum blandit, vehicula tincidunt per ac vulputate ex dictumst.", "Nisl.", "Ante lorem" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"),
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Augue platea euismod vitae, pulvinar, fringilla, ultricies felis eros ultrices. Adipiscing pulvinar proin sem platea rutrum quis, laoreet, lacinia vulputate. Ultrices posuere, commodo, eu, in lobortis dignissim sagittis, et, molestie. Ultrices vel mollis sodales lobortis aenean conubia vel, dui est. Sagittis, nibh, pellentesque sem, lacinia sagittis primis amet vitae nisl.", "Neque.", "In ipsum" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "ante@imperdiet.com", "Quis tempus", "Metus", "Erat", "Ante" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "volutpat@dignissim.com", "Dictumst cras", "Sed", "Aenean", "Nibh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "vestibulum@id.com", "Neque pellentesque", "Dolor", "Leo", "Elementum" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6c8019dc-0237-484d-80dc-452428bce548"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "condimentum@et.com", "Posuere quis", "Himenaeos", "Enim", "Platea" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "gravida@sociosqu.com", "Cursus in", "Purus", "Ullamcorper", "Placerat" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "laoreet@pellentesque.com", "Ornare pulvinar", "Conubia", "Ante", "Aenean" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "congue@nisi.com", "Elit lacinia", "Risus", "Porta", "Justo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("df749524-0c6b-416d-94c2-398f8b62e92d"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "a@egestas.com", "Dolor accumsan", "Lacinia", "Nulla", "Blandit" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "dui@amet.com", "Sagittis fusce", "Quis", "Sem", "Erat" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f70f7a45-8539-4082-a181-9705c2b5c505"),
                columns: new[] { "Email", "Name", "Password", "Surname", "UserName" },
                values: new object[] { "erat@ligula.com", "Sem mollis", "Amet", "Porttitor", "Fringilla" });
        }
    }
}
