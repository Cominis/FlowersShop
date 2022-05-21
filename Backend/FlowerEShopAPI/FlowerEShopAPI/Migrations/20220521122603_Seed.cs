using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowerEShopAPI.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "Name", "Password", "Surname", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "tellus@bibendum.com", "Egestas tempor", "Eros", "Conubia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Litora" },
                    { new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nunc@accumsan.com", "Fermentum elit", "Augue", "Sem", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volutpat" },
                    { new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ante@luctus.com", "Diam blandit", "Egestas", "Placerat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostra" },
                    { new Guid("6c8019dc-0237-484d-80dc-452428bce548"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "maximus@ullamcorper.com", "Lectus blandit", "Augue", "Ullamcorper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Augue" },
                    { new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "lorem@consequat.com", "Lacus non", "Molestie", "Dolor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis" },
                    { new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "efficitur@vehicula.com", "Leo porta", "Laoreet", "Felis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gravida" },
                    { new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "interdum@ligula.com", "Bibendum tortor", "Volutpat", "Feugiat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curabitur" },
                    { new Guid("df749524-0c6b-416d-94c2-398f8b62e92d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "fringilla@inceptos.com", "Efficitur non", "Ligula", "Turpis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eu" },
                    { new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "himenaeos@porttitor.com", "Rutrum facilisis", "Varius", "Ipsum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ornare" },
                    { new Guid("f70f7a45-8539-4082-a181-9705c2b5c505"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ultrices@dui.com", "Quisque tempor", "Elementum", "Tortor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nunc" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Location", "Name", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aptent torquent a quis, donec quis nec, amet, maximus sodales. Lorem, orci pellentesque tortor mauris, augue aenean scelerisque nisl est. Hendrerit risus euismod libero enim suscipit orci quisque mattis, accumsan. Ut inceptos nunc lobortis dui donec scelerisque sed maximus ligula. Suspendisse a libero feugiat, mollis accumsan nec, ultrices fringilla adipiscing.", "Odio.", "In ultricies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Varius pretium rhoncus odio, odio sem maecenas eget mi suspendisse. Lacinia, metus aliquam facilisis dignissim proin arcu aenean dui, phasellus. Fringilla blandit eu, nisi ex tincidunt id, turpis praesent hendrerit. Id, magna suspendisse ex, euismod ornare neque, ullamcorper commodo arcu. Fringilla, aptent viverra ligula, at id sem, non leo sollicitudin.", "Nunc.", "Orci commodo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Integer interdum, tempor, bibendum sed turpis nibh proin placerat, finibus. Accumsan consectetur leo, sem, eu, praesent sit orci, volutpat, fusce. Pellentesque leo porta, nunc, porttitor, placerat elit, elit tortor interdum. Lectus, ultrices morbi neque, orci, feugiat nostra, ultricies euismod aenean. Egestas facilisis auctor id, morbi id iaculis euismod, dignissim consectetur.", "Fusce.", "Phasellus adipiscing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") },
                    { new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eros aliquet sed laoreet lectus, adipiscing semper luctus rhoncus eu. Dui, ad ut dignissim neque, primis luctus, inceptos bibendum nec. Non orci, eu, lectus, sem cursus placerat, turpis augue laoreet. Vel a in, sapien tristique tellus, mauris non, nec, rhoncus. Elit sagittis, leo, eleifend, est dui facilisis himenaeos nostra, suscipit.", "Et.", "Dui faucibus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Urna ultrices, eget suspendisse quam, inceptos auctor dictum elit facilisis. Dictum ante, odio, quis, massa pellentesque luctus class purus imperdiet. Dictum laoreet mi, placerat, sapien tempor, odio, ipsum lobortis maecenas. Sociosqu enim interdum vehicula ante, dictum arcu, bibendum, aliquam amet. Aptent euismod sociosqu mattis, faucibus eros posuere, nisi sem congue.", "Neque.", "Libero sodales", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rutrum interdum amet ante, tristique tellus, urna erat, congue aliquet. Mauris, pharetra eleifend, ligula, tellus non feugiat orci placerat taciti. Efficitur at, maximus mollis id, donec sed hendrerit condimentum mi. Tortor, quisque ultrices, nostra, aptent litora enim, mauris, odio auctor. Bibendum vivamus tortor tellus, dui himenaeos fermentum quis, magna, est.", "Placerat.", "Platea pulvinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nec, suspendisse finibus maecenas lobortis nisi ante, aliquam tempor, eu. Quis finibus rhoncus erat interdum, aliquet neque nisl dapibus porttitor. Himenaeos platea luctus mollis elementum urna fusce aliquet a ullamcorper. Volutpat ex vestibulum in curabitur orci tortor, risus diam morbi. Nisi laoreet nec tellus, himenaeos enim id orci, volutpat urna.", "Mattis.", "Tempus est", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orci, sapien rutrum sociosqu ultricies venenatis fringilla dapibus id turpis. Libero auctor, elit viverra sed ex, molestie pretium ligula, commodo. Elit conubia suspendisse pulvinar, vitae phasellus bibendum ultrices egestas mauris. Ultrices, bibendum, amet, adipiscing interdum, vel, fermentum ligula, ac ante. Ornare est lacinia, ultricies lorem, enim conubia magna, massa orci.", "In.", "Pharetra pulvinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neque mollis ultricies integer erat in, eros, commodo quam, porta. Consectetur blandit odio vulputate varius, volutpat fusce varius ante, gravida. Commodo eros, nulla, sagittis, maecenas varius eleifend, vivamus efficitur et. Id ut feugiat, duis a class at, torquent maecenas accumsan. Iaculis duis urna diam quis porttitor, nullam a, primis efficitur.", "Massa.", "A porttitor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A vestibulum nullam massa, rutrum euismod ante, leo varius, suscipit. Nibh, nulla at, fusce ligula, dui, facilisis integer amet et. Feugiat, amet, suspendisse arcu, cras amet ante quisque aliquet hendrerit. Fringilla, porttitor, ornare suscipit etiam interdum a, sagittis, aliquam ac. Auctor condimentum eros, efficitur cursus fringilla, non, fusce lectus, lacus.", "Suspendisse.", "Efficitur himenaeos", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "Price", "Quantity", "ShopId", "Status", "SubCategory", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"), "Dapibus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luctus ante, quis, taciti consectetur fringilla, ante et cursus, tortor. Nisl vivamus per neque erat, cursus, egestas commodo, enim posuere. Etiam diam vehicula odio viverra pellentesque volutpat ipsum urna, malesuada. Varius, pulvinar euismod diam taciti quisque volutpat, ultrices nibh vulputate. Eleifend nibh, dui arcu, molestie lorem, ornare phasellus eros curabitur.", 26m, 64m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Porttitor", "Non.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("036526be-993c-4d69-ba77-42f606d587cb"), "Mattis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arcu, congue, cras vulputate aenean ullamcorper porta habitasse sagittis consectetur. Primis fringilla vehicula nunc, varius, erat cursus, eleifend, commodo commodo. Bibendum, dictumst ultrices mollis dui mi, condimentum non, nibh, et. Dapibus nostra, lacus risus suscipit auctor, vitae vestibulum, orci molestie. Bibendum amet, elementum ultrices, lobortis faucibus id, imperdiet himenaeos finibus.", 84m, 67m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Habitasse", "Tortor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"), "Ligula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nulla dolor a accumsan mi elit, vitae nibh, ipsum gravida. Placerat a etiam cursus, finibus praesent vivamus ante, porta, rhoncus. Lectus, volutpat nostra, elit, ex auctor, eros euismod bibendum, varius. Pellentesque eros, non adipiscing lorem, vestibulum quam non, primis duis. Orci, inceptos conubia fringilla, cursus, rhoncus vivamus vitae, rutrum vestibulum.", 99m, 76m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Fringilla", "Litora.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08c30630-ef18-465b-9514-fc742de98727"), "Vitae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fringilla, nostra, elementum inceptos ante, sed imperdiet tempus conubia semper. In hac habitasse hendrerit conubia inceptos commodo risus sed nulla. Enim, dictum imperdiet aptent massa, blandit arcu, dignissim proin bibendum. Lacinia, interdum, donec vel, bibendum tortor, tempus nulla, rhoncus, eros. Ante luctus ligula congue, ligula, erat torquent bibendum ante, laoreet.", 66m, 48m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Auctor", "Et.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"), "Quam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lacinia mauris placerat, platea odio enim est nibh, sagittis litora. Tristique odio, tortor, torquent eros vel, ante, interdum, sed, porttitor. Rhoncus interdum, praesent eleifend, diam cursus, conubia libero quam, a. Quis mi justo fringilla consequat eleifend porttitor libero mattis, dictumst. Vitae auctor, est vitae, congue, orci, nullam libero porttitor pharetra.", 17m, 92m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Consequat", "In.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"), "Lacinia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "In, nisi consequat ultrices, odio, porttitor, suscipit rhoncus lorem, nisi. Interdum, eu non, ultricies mollis fermentum efficitur integer dolor, dapibus. Vel, bibendum, purus cursus, posuere, conubia elit, nisi, fermentum nec. Elit, euismod, euismod maecenas facilisis mauris luctus consequat sollicitudin sociosqu. Consequat ante orci nullam hendrerit in, mauris platea et, lacinia.", 30m, 79m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Torquent", "Etiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"), "Semper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Turpis varius luctus, ad integer imperdiet magna cursus, non dolor. Commodo egestas tempor, imperdiet luctus, diam nibh at sociosqu pharetra. Quis ornare quisque integer ullamcorper nisi, euismod vulputate feugiat eros. Laoreet, finibus platea nisi bibendum, velit suscipit feugiat, posuere, et. Sit donec risus congue, ante, mattis iaculis ut eros, ligula.", 29m, 66m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Et", "Bibendum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ff8504f-e274-4d9f-984b-df155739e516"), "Elementum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pellentesque magna, mattis, dui fringilla finibus, habitasse lacus consectetur nostra. Porttitor, accumsan mauris, sagittis himenaeos rutrum sem at, arcu hendrerit. Fusce justo per morbi ac, at egestas risus nostra, blandit. Aenean ad turpis justo leo, volutpat, nam vel est dictum. Nisi, consequat sem auctor nam amet etiam dolor, congue donec.", 28m, 40m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 0, "Dictum", "Neque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"), "Euismod", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Feugiat lacinia, imperdiet justo risus ante nisi, ad volutpat, id. Massa sem, ultricies laoreet, taciti non sagittis malesuada quis, suscipit. Integer non, arcu, metus nec, ligula, quam leo, quis, odio. Metus lectus, suscipit odio, tortor, quis platea leo auctor, sodales. Commodo, vehicula id, varius, tellus, himenaeos posuere, maximus consectetur ut.", 35m, 20m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "At", "Duis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"), "Facilisis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commodo, cras turpis suscipit tellus, est arcu, curabitur scelerisque morbi. Orci malesuada ex ante, tempor vivamus vestibulum, et, maximus sapien. Dapibus lorem sodales quam, ante tortor quisque morbi per euismod. Aenean fringilla eleifend egestas vel, vitae porttitor sem sagittis, volutpat. Nibh, massa arcu dapibus fermentum tempor egestas hac neque, feugiat.", 52m, 17m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 0, "Iaculis", "A.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"), "Nibh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magna at, blandit, arcu scelerisque ultrices, porttitor, volutpat, orci, diam. Phasellus quam, est vivamus nec, turpis tellus class at platea. Rhoncus ipsum ante etiam pulvinar, curabitur tellus dictum commodo mi. Pretium praesent purus venenatis velit in, rhoncus, rutrum platea ante. Enim, suscipit faucibus dignissim metus dolor ullamcorper lacus vel, conubia.", 49m, 37m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Pharetra", "Risus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"), "Quis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Placerat placerat, eros, at, ac, posuere vitae taciti efficitur praesent. Pretium auctor in taciti duis blandit a urna, efficitur porta. Vestibulum odio, eleifend, congue cursus, interdum, purus tincidunt sagittis mattis. Id, ac urna ligula, in nibh, dictumst in, iaculis tellus. Sagittis, turpis dictumst blandit porttitor, aliquam lectus nisi accumsan interdum.", 95m, 29m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Nisi", "Feugiat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21420154-8f18-4fb3-b745-60621cca5541"), "Non", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Accumsan maecenas nam cras libero aenean non semper aptent suscipit. Ac ullamcorper quam, dapibus eros euismod, molestie bibendum, finibus, magna. Massa blandit lacinia nostra, et quam, elit, velit nisi, gravida. Accumsan habitasse mauris, purus tristique luctus, nunc imperdiet mattis, convallis. Justo mi, inceptos nulla mauris proin urna velit donec ante.", 77m, 82m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Sit", "Erat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"), "Ante", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sagittis ante, mi at ac, maecenas ac ipsum non pretium. Pharetra non mattis bibendum orci, phasellus sit aliquet odio, nam. Lorem, sapien pulvinar erat, a tellus, magna odio varius fames. Dapibus sed nec, amet, feugiat dolor lacus quis, dolor, cursus. Tellus, lacinia maximus id, lacinia, platea finibus, commodo, sed sit.", 35m, 37m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "Aliquet", "Etiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"), "Arcu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rutrum eros, blandit phasellus mauris, maximus varius, per nulla dictumst. Erat, vestibulum sociosqu nostra, vehicula dignissim diam iaculis consectetur a. Dictumst mauris, vehicula vel vestibulum urna nostra, ex feugiat, ullamcorper. Sem, ex, placerat, consectetur fermentum convallis tempor porta, ante, integer. Enim, conubia mattis neque quis posuere sem himenaeos odio accumsan.", 38m, 40m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Commodo", "Rhoncus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"), "Blandit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Praesent facilisis platea id consequat mollis malesuada porttitor, mi, tellus. Lorem condimentum lectus pharetra gravida ante purus porttitor class nam. Interdum laoreet quis vehicula vulputate sed, sem, orci praesent in. Bibendum, massa ac, eget luctus, inceptos nulla, suscipit tempor neque. Id, lectus ultrices pharetra lorem, augue nulla, sit vel, egestas.", 33m, 9m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "Accumsan", "Dolor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"), "Sem", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Suspendisse ante pulvinar, ac mattis sem bibendum nibh molestie aliquam. Risus blandit luctus ornare orci venenatis nullam interdum, maximus nec. Per blandit sem lectus lacinia, commodo, elementum bibendum, nulla maximus. Interdum sed imperdiet mattis, venenatis orci fusce elit odio lectus. Ultricies tellus, leo taciti cras platea vel sit iaculis vitae.", 51m, 70m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Porta", "Euismod.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"), "Risus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eu erat ex, lobortis tristique nec sem, lacus arcu, tincidunt. Hac sagittis interdum condimentum varius erat praesent donec eros vitae. Eu, suspendisse consectetur et justo dui, aliquet id, ex rutrum. Urna, pulvinar viverra aliquet ex tempor, tortor ut feugiat nulla. Nulla, felis auctor ipsum molestie ante, per nisl quis sagittis.", 88m, 77m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "Lacinia", "Vehicula.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"), "Mi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tempor, praesent mattis, ante, feugiat, ullamcorper elit varius vel, commodo. Eu, per luctus, litora pretium ligula, mattis, venenatis taciti fringilla. Curabitur vel nulla varius, ultricies sed sit iaculis non mi. Amet faucibus suscipit a, a sed, odio, taciti non, eros. Ultrices, posuere, justo litora eget sed, mattis, mauris, mattis id.", 34m, 29m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Id", "Tempor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"), "Porttitor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Imperdiet mi, accumsan class elit, auctor, tempor ut quis, dui. Mi ornare vulputate sapien ligula, nam nec mollis ultrices, dapibus. Nisi aliquet in sem arcu, pretium cursus vestibulum, rutrum porta. Sagittis, enim, sagittis dictum id, aptent feugiat, imperdiet lorem, auctor. At quis, sit lacinia iaculis metus conubia mi suscipit feugiat.", 19m, 31m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Mattis", "Bibendum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("357cca07-da0f-4263-9575-9304ba791639"), "Etiam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tortor cras tempor neque finibus porta, blandit pulvinar, ac quam. Ante, integer sem, inceptos eleifend, turpis erat, urna, adipiscing magna. Bibendum, blandit, sem, quis, feugiat nulla, aliquet odio ligula elit. Pharetra varius finibus litora ligula, sed ex vitae diam eu. Ultricies nunc enim, enim vestibulum, sapien ante, quam, mi, ipsum.", 81m, 57m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Tortor", "Non.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"), "Dui", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lectus, nibh nisi sagittis, dictumst suscipit vulputate at, per tristique. Conubia ex, nisi, suscipit posuere, malesuada felis dui dictum cursus. Commodo feugiat et conubia morbi finibus, himenaeos primis etiam iaculis. Varius semper eget dapibus eros, posuere vel sagittis felis a. Taciti imperdiet conubia amet lacinia posuere sed, orci placerat, integer.", 26m, 98m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Fringilla", "Nulla.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"), "Himenaeos", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Porta ligula lobortis cursus faucibus quis, lectus ex sodales id. Venenatis phasellus lacinia eu, vehicula vulputate lorem, suspendisse urna, pellentesque. Odio, nulla, lobortis suscipit urna eu, porttitor, et aptent nunc. Maximus mattis sollicitudin semper dignissim quis, massa velit tincidunt luctus. Tempor, lacus sed, nam praesent est eu at vitae, libero.", 75m, 45m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Nisi", "Lacus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"), "Ad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mollis finibus, egestas amet feugiat, sagittis varius nec molestie sed. Massa lorem, tellus blandit viverra eros quam sodales tincidunt sagittis. Purus inceptos sollicitudin hendrerit etiam suspendisse feugiat orci, eros congue. Quis eros, cursus, massa, odio elit, congue sem elit sem. Commodo odio, eleifend efficitur mi odio orci platea blandit sed.", 48m, 79m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Ante", "Cursus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"), "Efficitur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Massa, proin velit nam leo, diam volutpat amet ultricies ad. Blandit egestas mollis phasellus quis eleifend sem duis dolor, laoreet. Adipiscing velit tristique quis duis vitae vel laoreet, malesuada varius. Faucibus bibendum porttitor cursus, tellus, nunc, ex, elementum sagittis semper. Massa libero condimentum malesuada dolor massa, convallis sit non, adipiscing.", 79m, 43m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "Lectus", "Aenean.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"), "Eros", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phasellus porta libero velit dui, aptent turpis non nibh, augue. Dolor commodo, dui, erat, sagittis blandit purus nisi, ac gravida. Finibus dui lorem metus posuere conubia nec, leo gravida adipiscing. Id, congue, enim tristique finibus suspendisse elit diam feugiat, metus. Tincidunt at libero non amet dictum mollis tempor justo proin.", 87m, 43m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Sollicitudin", "Fames.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4158bf42-0721-4e06-9ebd-ddf682240f7a"), "Morbi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dapibus luctus, a, rhoncus odio, curabitur imperdiet sagittis, enim, et. Non, consequat dictum nullam eget ante tempor a egestas mauris. Sed, praesent lectus, tortor, sagittis, semper tristique blandit porttitor, donec. Congue mi interdum, nulla, venenatis sed nisi aliquet litora nullam. Commodo pulvinar, sodales sagittis, condimentum porttitor fringilla efficitur vestibulum semper.", 0m, 81m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Risus", "Sem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"), "Eros", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neque, lorem enim aptent nisi, morbi sollicitudin efficitur lectus dapibus. Cras egestas at, vestibulum nunc, orci donec justo varius, malesuada. Sodales hac eros est habitasse arcu, eu, a, faucibus donec. Nibh lacinia, orci, nulla, sagittis eleifend ad est eu fringilla. Dolor congue, varius, nisi lobortis vehicula nostra, euismod, eget dapibus.", 85m, 25m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Cursus", "Scelerisque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"), "Placerat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Viverra rutrum ornare sodales maecenas class nec egestas elit, eros. Porta, eleifend orci tincidunt pulvinar, etiam tellus, volutpat, est neque. Blandit elit sem, cursus, vitae lorem himenaeos nunc malesuada euismod. Rhoncus enim, fames efficitur ac lacinia etiam ultricies arcu posuere. Dui, quisque tristique conubia rutrum elementum mauris ullamcorper quis, porta.", 81m, 88m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Imperdiet", "Laoreet.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"), "Porttitor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Primis ultrices, dui posuere, vel nulla semper dapibus vulputate in. Est vivamus turpis dui tempor, sagittis ligula quam, etiam fringilla. Euismod commodo libero quisque non quam, neque vel rhoncus tortor. Bibendum elementum felis ligula, odio volutpat, elit lacinia tempus lorem. Mauris, tellus, in, erat placerat, arcu, tempus lacus nulla, lorem.", 16m, 50m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Sagittis", "Ante.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"), "Dapibus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Metus congue, finibus auctor, arcu quisque litora ullamcorper maximus dolor. Sem ante luctus, nisi placerat, facilisis platea aliquet dapibus ad. Pellentesque nostra, sodales dapibus arcu platea dui, duis bibendum, nulla. At, luctus, vestibulum nunc, odio fusce cras ut sit imperdiet. Litora enim, sem, fringilla, sagittis, fames suscipit porta sociosqu felis.", 85m, 82m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "Ex", "Quis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"), "Malesuada", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quisque porta, sem himenaeos a duis hendrerit auctor arcu convallis. Blandit, vitae, lorem, conubia egestas malesuada risus tristique sed placerat. Diam varius varius, eros, et ipsum ultrices, ut tempor sed. Lacus sit sem, scelerisque congue aliquam a tortor, id sed. Cursus, magna lacus consequat finibus vestibulum at vitae enim, tristique.", 27m, 68m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Sollicitudin", "Eget.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"), "Sed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ante, consectetur id, nulla bibendum, velit elit, ad faucibus commodo. Ex, efficitur vitae, fames mi, et, venenatis dui eros, mauris. Ullamcorper suspendisse phasellus urna, dapibus tellus, consequat conubia diam luctus. Tincidunt praesent molestie inceptos nisi lectus volutpat, sed, vestibulum, pharetra. Finibus, faucibus facilisis risus pellentesque tortor, tincidunt conubia mattis, congue.", 86m, 99m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Maecenas", "Dignissim.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"), "Lobortis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tellus, morbi a leo primis lectus, cras odio, fames phasellus. Ultricies vel nisl integer vestibulum, nam tortor condimentum lacinia ut. Semper nisl cursus eu suspendisse praesent in, in vivamus erat. Aliquet hendrerit feugiat felis morbi convallis est enim egestas vestibulum. Molestie vivamus sit sollicitudin varius, ante lobortis finibus est aenean.", 87m, 18m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Nulla", "Nec.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"), "Mattis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sagittis ultricies porta, in, per sed, adipiscing justo pharetra purus. Nulla scelerisque quis eleifend, tristique elit, etiam praesent a, duis. Quis urna, inceptos taciti erat, tellus, neque, mattis, eleifend, neque. Pellentesque gravida erat neque quis in nunc, sed ad euismod. Tristique vulputate tellus eget neque arcu aliquet id volutpat torquent.", 57m, 52m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Quis", "Sed.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"), "Nisi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ligula suscipit luctus, finibus, id, vitae, commodo feugiat, nullam in. Posuere, quis, vel lacinia, ipsum vehicula hendrerit dui fringilla, nisi. Placerat, et, praesent magna, maximus accumsan ullamcorper nec, erat nulla. Viverra malesuada mattis, quam ac sit mollis vestibulum sed porttitor. Arcu, sagittis rhoncus quis sodales libero duis nisi, egestas pharetra.", 69m, 8m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Rutrum", "Pulvinar.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53c7a9de-03b5-4482-8163-2d925ca7f3c5"), "Bibendum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Interdum eu, ipsum porttitor, tincidunt litora dolor nec, bibendum, sagittis. Vitae, et, justo taciti massa mi, tellus, praesent eu leo. Ante feugiat sociosqu nulla vestibulum posuere mattis, orci erat fringilla. Lacinia, sodales fusce donec cras turpis ac amet, dui sollicitudin. Est purus leo, lorem, leo vitae amet ipsum euismod, sit.", 34m, 51m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Himenaeos", "Mattis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("543372da-be2f-4ef6-8496-98a8a075799c"), "Lacinia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Odio, torquent lectus mi, et leo, vel mauris velit eleifend. Maximus nunc, laoreet eu rhoncus, ornare vel congue rutrum lorem. Vitae, tellus maecenas tempus adipiscing justo ultricies volutpat, dolor, sagittis. Cursus, suscipit dui ligula taciti quam, mattis erat commodo, hac. Condimentum nibh, vulputate facilisis auctor nibh duis lectus enim, dui.", 45m, 23m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Tempor", "Porttitor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"), "Inceptos", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pulvinar, tortor malesuada lorem, efficitur vel, nibh, lobortis odio, himenaeos. Laoreet vel nec, vestibulum, porta, tortor, maecenas posuere auctor odio. Luctus, laoreet dui, eros, bibendum mi, id posuere sollicitudin torquent. Diam himenaeos erat porta pharetra interdum, eu, a, cursus, facilisis. Torquent interdum aliquam mi pharetra pulvinar, blandit maecenas cursus, hac.", 50m, 24m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "In", "Cras.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"), "Non", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mi, scelerisque taciti lobortis iaculis interdum, luctus sed tempor, imperdiet. Malesuada donec faucibus imperdiet integer eget lacus suscipit enim massa. Vitae a vehicula tristique ac, efficitur interdum, sapien blandit, adipiscing. Sem, at lectus, ex ac ornare rhoncus amet dapibus id. Non ut eleifend, maximus mollis integer vestibulum elementum bibendum viverra.", 50m, 70m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Amet", "Adipiscing.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"), "Donec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magna cursus dolor elementum mattis, hendrerit malesuada integer dapibus ullamcorper. Finibus mauris, vitae, euismod bibendum, faucibus dui tincidunt hac iaculis. Hac nostra, non, elit, blandit porta id per laoreet quam. Nullam tellus quam, efficitur eros, fermentum a, libero volutpat venenatis. Pellentesque mattis fermentum nam fringilla massa quam eu, augue id.", 1m, 54m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Fames", "Hac.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"), "Sed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quam mattis pharetra orci eleifend sed auctor, ante, non ultrices. Bibendum, eu euismod sed id elit sociosqu dui nibh, volutpat. Eget tellus, molestie gravida eros dui varius, consequat dui, cursus. Per nec torquent lacinia, interdum, dictum vehicula nisl etiam odio. Rhoncus eleifend, augue congue, bibendum, diam magna, vel, sociosqu etiam.", 0m, 66m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Dictumst", "Mollis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "Price", "Quantity", "ShopId", "Status", "SubCategory", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"), "Elit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neque enim, varius, ex, arcu inceptos eros, varius metus mauris. Auctor amet varius faucibus dolor, congue, ligula erat nisl lacinia. Suscipit ultrices, maecenas ac et elit, quis urna dui himenaeos. Urna, non tempor, hac et, libero auctor, sem, lorem suspendisse. Proin viverra metus euismod maximus malesuada eu, massa lobortis eget.", 47m, 12m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Purus", "Leo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"), "Litora", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luctus, massa mauris sapien pulvinar eros, lacinia, euismod lorem, dui. Quis, vestibulum, quisque non, sodales rutrum auctor blandit leo ex. At id, porttitor lobortis mollis bibendum eu, eleifend, nunc, congue. Porta, dapibus semper nisi feugiat eros, massa cursus, felis mauris. Nibh, rhoncus vitae fusce tortor, venenatis posuere, faucibus elit, enim.", 34m, 20m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Vel", "Ullamcorper.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"), "Aptent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cras ipsum phasellus sapien nisi, elementum id, odio, aliquet nulla. Ultrices dictumst class torquent eu, adipiscing massa pulvinar, elit vulputate. Dictumst ligula himenaeos sociosqu dignissim nisl faucibus interdum rhoncus, ac. Donec consequat tincidunt platea cursus risus cursus, vestibulum, urna, mauris. Sit accumsan sagittis rutrum himenaeos arcu lectus feugiat, ante nisl.", 53m, 65m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Elit", "Lorem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"), "Fringilla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luctus, dolor nisi, lobortis urna lacinia, quisque lorem, phasellus at. Ullamcorper vestibulum, habitasse arcu, turpis dolor aliquet blandit dolor, orci. Et mattis conubia cras vel, est leo neque, nullam finibus. Orci, at bibendum ex tristique eu nunc venenatis eget curabitur. Nunc donec mi, laoreet adipiscing a id, justo volutpat, congue.", 72m, 74m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Ante", "Sem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"), "Ligula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nullam consequat quam, donec augue iaculis efficitur euismod quis volutpat. Nullam conubia elementum fermentum condimentum aptent nunc vitae, proin quis. Urna, morbi varius, nisi, varius ac, pulvinar faucibus finibus arcu. Class tincidunt imperdiet tempor, fringilla, leo ac ultrices egestas odio. Id, lectus, nulla, fames tincidunt blandit, erat, mattis, mi, in.", 61m, 18m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Ad", "Pellentesque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"), "Arcu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Erat, sodales phasellus ex sapien eros, feugiat, nisl nulla felis. Integer nisl viverra leo erat sapien quis ac, vitae varius. Eget feugiat, nibh, amet, mattis, luctus erat, enim semper vulputate. Felis purus placerat, sollicitudin bibendum velit praesent lacus varius leo. Vel nunc quam sed maecenas ante posuere feugiat posuere, volutpat.", 81m, 39m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Molestie", "Consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"), "Lacinia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pharetra dictumst nibh, in, varius, congue, aenean varius vitae elit. Nam lorem diam mattis fermentum odio volutpat suspendisse ipsum sem. Viverra porttitor rhoncus, nullam elit, finibus tempor, mattis mauris pharetra. Nec at mi, leo, ante auctor, mauris hendrerit blandit commodo. Bibendum luctus, class iaculis blandit elementum luctus felis erat, ad.", 45m, 2m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Blandit", "Lectus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"), "Urna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fringilla, orci bibendum, ultricies aliquam mi dolor, torquent tempor, imperdiet. Leo, phasellus ullamcorper litora quisque eleifend tortor, libero ex, ipsum. Odio ut tincidunt neque, pellentesque maecenas molestie facilisis mattis, sed. Faucibus massa ultricies integer interdum, cursus, posuere scelerisque auctor, nostra. Mauris ante nulla, enim euismod, ad quis ultricies volutpat, nunc.", 62m, 8m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "Turpis", "Nec.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"), "Magna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cras praesent mattis taciti quis sagittis eros, arcu, duis laoreet. Vehicula non cursus, ullamcorper leo orci tortor neque, sociosqu nisi. Massa, fringilla, vel, interdum, sollicitudin pretium rhoncus tincidunt sem, vivamus. Ipsum enim fames hac massa class enim, dolor odio litora. Conubia volutpat consectetur eros, sit mattis, sagittis vestibulum, fringilla lorem.", 32m, 45m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Sollicitudin", "Suscipit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"), "Volutpat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Curabitur nibh finibus integer ipsum eleifend, varius, etiam eu ligula. Lorem, eros, tortor, lobortis leo scelerisque dolor elementum blandit luctus. Nostra, nisi, massa, elit, eros, sem magna curabitur porta, semper. Quisque dapibus ullamcorper ligula et mi nisi, finibus, vivamus ut. Fames taciti ante posuere, nisl enim fringilla, vehicula suspendisse porta.", 16m, 25m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Vel", "Ex.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"), "Malesuada", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Volutpat, magna, euismod litora placerat, luctus, fames nec, lobortis augue. Vehicula laoreet cursus auctor, facilisis massa, torquent neque interdum aenean. Urna, metus vestibulum a porta maximus ex proin a, vestibulum. Non, dolor, euismod lacinia dui, sed, pretium malesuada tortor libero. Porttitor volutpat nunc leo tellus, fermentum praesent fringilla, ullamcorper eleifend.", 52m, 7m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Eros", "Pulvinar.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("836bf6f7-71a6-485d-8514-455393908657"), "Consequat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Porta efficitur interdum, volutpat, quam lobortis ad integer vel, lacus. Bibendum nulla maecenas fusce eros urna conubia in elementum mauris. Congue, nunc facilisis ornare laoreet, nostra, interdum efficitur vehicula tincidunt. Dui ornare magna, sollicitudin lacinia, eu, faucibus varius, amet, quam. Quam, inceptos arcu varius, laoreet, integer aenean himenaeos sem, enim.", 17m, 61m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "At", "Nostra.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"), "Semper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arcu, massa odio volutpat, ex mattis, venenatis amet elementum lorem. Lorem, maecenas inceptos ac neque integer eu, aliquet placerat, varius. Nam rhoncus, neque, sed, facilisis at in, semper faucibus elit. Erat, pretium congue sem placerat, porttitor, hac taciti porttitor praesent. Semper elementum proin magna, convallis sollicitudin eget aliquam vestibulum eros.", 20m, 38m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 0, "Vestibulum", "In.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"), "Euismod", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ultricies finibus sodales nec, curabitur magna, mattis, scelerisque interdum, tortor. Quisque lectus, tempor mi cras efficitur sagittis, tellus, bibendum maecenas. Gravida dignissim nec, vestibulum, per amet pulvinar, tempus neque varius. Habitasse maximus arcu, quis, vitae maecenas nullam fusce sociosqu rutrum. Pretium leo, lorem faucibus in dictum platea eros tellus, neque.", 40m, 1m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Conubia", "Metus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Accumsan vestibulum torquent sed interdum tortor, ante sagittis, commodo, feugiat. Varius consectetur mollis dui, convallis dapibus in blandit lacinia tempus. Velit platea conubia pellentesque sem, inceptos aptent efficitur neque imperdiet. Per imperdiet mi faucibus at eleifend, habitasse quis aenean placerat. Suspendisse cursus bibendum, sociosqu phasellus ante vitae auctor, feugiat, elementum.", 65m, 15m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Nibh", "Ac.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"), "Sem", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Donec scelerisque fringilla, mi porta, sapien et fusce mattis, congue. Ad convallis condimentum ex, leo varius, arcu, nam tempus nullam. Dolor, urna primis mattis, metus condimentum rhoncus tempor quam, enim. Fames scelerisque dui, fringilla aptent tristique auctor, porttitor nibh dapibus. Ultrices, diam adipiscing euismod nam quisque tortor, leo fames eleifend.", 31m, 63m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Aliquet", "Aenean.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"), "Fusce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auctor, pulvinar massa sem, nisi torquent dignissim varius quis, eleifend. Euismod, interdum amet nam sit consectetur gravida diam nec magna. Sapien ligula, per elementum fringilla enim mi, faucibus nunc viverra. Convallis himenaeos primis dolor mattis a, sem, lorem, scelerisque bibendum. Cras gravida non, fermentum etiam efficitur mi ac, vehicula ligula.", 73m, 29m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Bibendum", "Sem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"), "Ligula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Id, ut vel habitasse eleifend finibus massa, dignissim commodo platea. Bibendum auctor, eu, vestibulum, dui facilisis pellentesque nostra, leo, dapibus. Nulla, nostra, facilisis litora orci dignissim eleifend, risus nibh lorem. Pulvinar imperdiet quis dui, tempor, neque tellus neque, mollis quis. Fusce finibus, orci, ultrices, donec nibh, ante vulputate at, nisi.", 10m, 41m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Dui", "Egestas.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("962d2024-995d-4165-89c9-55e15d2176e3"), "Sapien", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Non porta, odio fames varius porttitor venenatis augue cras a. Mattis sagittis dignissim quisque praesent nunc nec, mollis posuere, volutpat. Fames vehicula lectus, amet, lectus inceptos euismod, aliquam risus commodo. Ultrices, ex, sed, accumsan quam, mattis tortor, commodo, maecenas platea. Suscipit aliquet congue, dolor, nisi nunc, bibendum, metus vivamus urna.", 77m, 11m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Id", "Commodo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"), "Purus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Felis torquent commodo, sodales leo porttitor aptent ipsum orci nisi. Semper morbi posuere, vestibulum fames et augue ut odio nulla. Auctor, ante rutrum iaculis conubia molestie ipsum sagittis, placerat, est. Fames mauris maecenas taciti placerat adipiscing ante purus morbi ante. Urna, diam et, tellus dictumst nibh, ac, curabitur lectus cursus.", 82m, 63m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Est", "Ultricies.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"), "Dictumst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Neque non lectus porttitor sapien risus fringilla, aliquet nisi elit. Lorem adipiscing amet, sagittis, accumsan pharetra tincidunt vestibulum nibh, nunc. Auctor aliquet vulputate tempor porta, fusce laoreet, himenaeos vehicula at. Primis in, vel libero fringilla rhoncus, erat, eros, eros aptent. Urna enim suspendisse luctus nibh, aliquam faucibus fringilla porta, amet.", 87m, 49m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Ut", "Commodo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"), "Massa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tellus ipsum condimentum tempor, egestas aenean malesuada fringilla aptent inceptos. Ultrices, nisi, volutpat, sem vestibulum, commodo leo dictumst ultricies non. Euismod, ultricies scelerisque fringilla, dui pulvinar, porttitor, duis luctus, condimentum. Dolor, euismod auctor morbi vestibulum, eros, faucibus tristique luctus, ac. Luctus, placerat, etiam libero dui, consequat id leo, cras ligula.", 89m, 17m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Nam", "Tempor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"), "Vitae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Varius, erat, quis lorem imperdiet elit, nunc, fringilla sagittis, non. Rhoncus, ac, a, at tortor, donec dignissim ante metus feugiat. Est leo mi inceptos aliquam eu, tincidunt sagittis, bibendum, id. Fringilla non massa, vitae quam maximus libero tellus neque, pretium. Et volutpat luctus iaculis varius leo, et, risus scelerisque consectetur.", 83m, 32m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Aliquet", "Turpis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"), "Facilisis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Venenatis maecenas amet, ultrices, vel, nunc nisi integer massa, nulla. Blandit, et, ex varius erat, cursus, lectus eu, egestas molestie. Ac blandit faucibus odio duis magna, fusce quisque sollicitudin suscipit. Sit eleifend, ante, iaculis semper sodales posuere, fermentum elementum massa. Dictumst est ex, finibus vitae, phasellus mollis massa conubia eros.", 73m, 70m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "Enim", "Blandit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"), "Tortor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vitae, tempor, ante sed, libero consectetur fringilla, non, ornare turpis. Interdum, velit luctus tempor euismod, porttitor purus primis tellus turpis. Tempor adipiscing eget fringilla, commodo eros arcu, scelerisque porttitor blandit. Pulvinar dictum enim, magna, accumsan scelerisque sit sem, nulla, ultrices. Dignissim dui, mi in sem eu porttitor, velit nullam sagittis.", 8m, 6m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Elit", "Vestibulum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"), "Taciti", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magna et, nullam interdum, mattis, dictumst condimentum bibendum aenean dolor. Praesent amet, cursus hendrerit neque accumsan imperdiet nunc, quam feugiat. Integer ligula, tempor, justo ullamcorper ornare euismod, maximus eu lacinia. Orci, vel, placerat, donec gravida vestibulum praesent consequat cras euismod. Tempor lacinia class blandit amet, sagittis ex, auctor malesuada dui.", 31m, 35m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Lacinia", "Orci.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"), "Pharetra", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem himenaeos cursus, eros nulla nulla, in velit facilisis volutpat. Fusce est pulvinar arcu, orci sociosqu eu leo congue, finibus. Venenatis consequat bibendum, tristique iaculis nisi, mi, conubia eget id. Mattis metus nam proin egestas porttitor, consequat pulvinar, ac, feugiat. Fringilla, ex venenatis finibus donec vitae, ipsum mi, maecenas malesuada.", 42m, 2m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Litora", "Tortor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"), "Tempus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Posuere accumsan fringilla nullam nisi porttitor bibendum blandit, primis neque. Egestas molestie nulla, pretium adipiscing quis mattis, laoreet, congue, a. Nunc, mauris, est sollicitudin eros, nec, enim, commodo, eu cras. Ultrices, euismod, metus sed varius, nullam dapibus nec porta urna. Mauris, malesuada enim, vivamus amet nostra, tincidunt rutrum iaculis morbi.", 31m, 77m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Ultrices", "Congue.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("adaa5968-bab8-433d-abc6-217d49fa3395"), "Imperdiet", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dignissim pretium egestas venenatis quis, odio hendrerit magna, pulvinar, aliquet. Nunc lorem curabitur tortor vestibulum a, dolor, class himenaeos velit. Leo donec leo, nunc varius, eu, efficitur arcu et porttitor. Tincidunt pellentesque finibus vivamus in, praesent viverra nullam pulvinar sagittis. Massa euismod hendrerit consequat etiam varius vel rhoncus ad erat.", 37m, 84m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Aptent", "Condimentum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"), "Neque", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mi nulla id, non, nec, per scelerisque leo nibh, euismod. Fringilla suscipit egestas rhoncus laoreet, tortor interdum, nulla euismod, nostra. Vestibulum aliquet arcu, aptent orci, erat magna tortor, diam rhoncus. Facilisis quis nisi dui, dictumst sit sodales tristique interdum, molestie. Odio varius, feugiat, ac auctor duis class commodo, ligula praesent.", 0m, 61m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Lacinia", "Scelerisque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"), "Sit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Suscipit adipiscing mi, facilisis proin magna maecenas curabitur leo pellentesque. Mauris, egestas lectus, justo sapien hac nibh, nec, ut urna. Efficitur tristique blandit, turpis nec, tempor enim, diam quis, eros. Vitae, nibh aenean vulputate sodales tellus diam euismod, vestibulum, adipiscing. Consectetur vitae finibus mauris cursus, suspendisse eleifend platea nunc orci.", 43m, 25m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Vulputate", "Placerat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"), "Suscipit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cursus, id enim gravida metus vestibulum, torquent ornare ultrices, rhoncus. Dignissim dui sed, inceptos fringilla mattis, lobortis hendrerit hac scelerisque. Vestibulum est urna conubia ac, porta, nec lorem litora ut. At, felis per convallis urna dolor est velit elit, porta. Ligula, tempus vel amet, gravida quam, mattis massa at phasellus.", 74m, 78m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Dictum", "Congue.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"), "Fermentum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eleifend, nibh amet, iaculis aliquet massa porta vestibulum, rhoncus, lobortis. Vehicula platea mattis, odio aptent venenatis nec, inceptos convallis suspendisse. Nibh eleifend auctor, leo, condimentum et bibendum luctus placerat, congue. Scelerisque amet, primis nec libero nullam euismod, non, risus tellus. Bibendum, laoreet, commodo consequat nulla rhoncus eleifend, faucibus neque nibh.", 6m, 49m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Urna", "Dui.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"), "Nec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Congue, nec leo vehicula taciti nulla at, hendrerit rutrum urna. Dignissim ut vivamus ullamcorper nam scelerisque elit, praesent conubia viverra. Metus eros, suscipit mattis primis massa vestibulum, inceptos duis porttitor. Commodo mi, turpis sollicitudin sed, sagittis, ex, tristique in amet. Posuere, venenatis fermentum ex eros massa, auctor, per consectetur mattis.", 39m, 25m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Non", "Quis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"), "Dolor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elit praesent vel, dictum lacinia litora id, ac quam, vestibulum. Urna, diam blandit quis ante, tempus tortor ex, suspendisse elit. Neque aliquet viverra lorem ad semper justo laoreet, mi, placerat. Vitae, malesuada ultricies orci himenaeos eu, mi finibus pellentesque dolor. Iaculis ac, scelerisque vehicula id conubia eros, euismod nostra, mattis.", 13m, 95m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Commodo", "Conubia.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"), "Orci", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "At, dictum eleifend curabitur dignissim vivamus sit augue quam, ipsum. Non, nisi, accumsan mattis dolor, vivamus vestibulum, eleifend, tellus fringilla. Urna, urna placerat litora sagittis sollicitudin dignissim sodales vestibulum, aptent. Pellentesque quis urna, posuere, finibus erat, ut gravida auctor, lacus. Curabitur amet, tellus imperdiet congue, nisi, pharetra porttitor, feugiat, in.", 70m, 27m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Non", "Laoreet.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba3c9243-5390-488e-b598-2779fd398da8"), "Fringilla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Molestie vel mattis, mauris turpis rutrum odio, vivamus phasellus magna. Fringilla non tempor praesent nam volutpat phasellus amet, lorem, auctor. Tellus, elit dapibus sagittis, et eu imperdiet consequat arcu, sodales. Nunc urna, eros, sapien enim, eu mattis maximus himenaeos feugiat. Amet fames faucibus tristique iaculis eleifend, enim platea et consectetur.", 41m, 69m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "Adipiscing", "Eu.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"), "Dolor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Egestas mattis tristique aliquam adipiscing dui odio, risus vestibulum, pulvinar. Urna taciti suspendisse sit varius blandit hendrerit litora urna, ligula. Fringilla, leo nisi, suscipit ut in, rhoncus, enim, bibendum, nunc. Sagittis, sollicitudin eleifend eleifend, nam enim, dictumst urna id, orci. Fringilla, malesuada imperdiet justo tortor, et, commodo vitae, faucibus convallis.", 24m, 57m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Nunc", "Volutpat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"), "Molestie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Felis leo, lorem duis ante odio, gravida molestie iaculis blandit. Varius, sed, tortor maximus accumsan elit, bibendum, litora torquent posuere. Interdum quam fringilla tincidunt habitasse augue volutpat, neque turpis semper. Mattis placerat leo, sodales consequat quis, dignissim pharetra nisl massa. Tortor tincidunt habitasse dignissim eros, orci, tempor, fringilla nec, integer.", 7m, 86m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Adipiscing", "Etiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"), "Sociosqu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Urna suscipit arcu, quisque blandit, magna mi iaculis curabitur nullam. Luctus, velit viverra volutpat morbi pharetra elit, nisi, placerat, dictum. Congue non, consequat nulla, quis curabitur lacus eu maximus amet. Vestibulum at dui, habitasse tortor quam, placerat dolor, rhoncus, euismod. Tempus porttitor elementum mauris mi, praesent felis est aptent interdum.", 50m, 87m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Interdum", "Odio.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"), "Mattis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nulla, turpis pellentesque aenean amet, in, quam, ultrices, rhoncus torquent. Pellentesque ante ornare integer blandit placerat, porta, id, bibendum proin. Nostra, ultricies finibus magna, eu varius adipiscing ornare semper class. Metus donec sapien lacinia, sociosqu nisi odio feugiat cras integer. Fames per inceptos quam, mi, enim nulla, placerat et, vivamus.", 58m, 28m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Risus", "Neque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"), "Ipsum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tincidunt justo bibendum, convallis ultrices viverra ornare ac fames litora. Dignissim consequat accumsan non, amet mi porttitor nam dolor, bibendum. Metus ante, habitasse odio, lacinia, suscipit posuere, gravida tortor nam. Sociosqu arcu, scelerisque lorem nullam semper ac, quis, enim, ac. In varius feugiat, massa ut aliquet enim platea id convallis.", 57m, 46m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Neque", "Mi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "Price", "Quantity", "ShopId", "Status", "SubCategory", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"), "Porttitor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sem blandit euismod lacinia proin ac, conubia condimentum pellentesque enim. Rutrum duis orci vel, elementum sed interdum platea risus porttitor. Nunc, consequat fermentum consectetur augue imperdiet vitae mollis vel, euismod. Tortor, eleifend, consectetur pulvinar praesent posuere ad arcu nec, ornare. Quis augue pellentesque lorem, tristique hendrerit tempor molestie venenatis nostra.", 29m, 78m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Cras", "Dignissim.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"), "Molestie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Semper iaculis quisque ullamcorper lorem, lacus orci, ex finibus viverra. Velit fames ullamcorper mattis, lorem arcu, lorem, aptent diam ac. Risus dictumst quis, dui tincidunt ad vitae lectus, inceptos fringilla. Vestibulum velit arcu, aenean metus tellus, dolor luctus et, lobortis. In elit, amet quis nibh, ornare habitasse eleifend, porttitor, hac.", 94m, 31m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "A", "Pellentesque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"), "Quis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nec, eleifend mattis, taciti arcu, fringilla sollicitudin cras interdum eleifend. Enim varius eros, a quis, dolor, finibus id ante, mauris. Felis eros at litora enim fermentum cursus, tellus in nibh. Interdum, sapien sem mauris, pharetra et dolor, dignissim ullamcorper iaculis. Lectus magna, class magna eleifend fusce cras odio, amet, orci.", 89m, 19m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Inceptos", "Gravida.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"), "Tempus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Convallis sollicitudin commodo, magna sem, quam fermentum lectus ante dolor. Turpis fusce ultrices, nam nunc integer sagittis quis ligula hac. Nisi, sed, commodo, ultrices, tellus mattis class elementum leo, himenaeos. Odio, vel finibus, mattis, placerat consectetur blandit enim, aliquet quis. Odio, malesuada placerat, blandit feugiat enim rhoncus, non, tortor iaculis.", 53m, 83m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Sagittis", "Tincidunt.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"), "Et", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eleifend pulvinar, donec nulla praesent ex interdum erat, eleifend, posuere. Pulvinar auctor, non laoreet, iaculis pretium volutpat, magna nam vestibulum. Sollicitudin arcu adipiscing ante, felis elementum ac, laoreet, sodales mattis. At amet id, nisi felis lacus magna, dui etiam dolor. Est dolor auctor, eu praesent rhoncus ligula, curabitur maecenas vivamus.", 39m, 30m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "Urna", "Libero.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"), "Adipiscing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luctus finibus, nam nulla arcu, sed ligula consectetur commodo, nisi. Nec commodo, ultrices, proin arcu inceptos himenaeos ac, turpis vestibulum. Dictumst ante luctus, malesuada urna, sem suspendisse proin etiam tincidunt. Neque interdum, malesuada amet, lacinia arcu porta, phasellus lorem, orci. Quis est etiam euismod, erat vel, donec commodo metus leo.", 45m, 14m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Odio", "Viverra.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"), "Auctor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mattis pellentesque nec, ligula, aenean sollicitudin in, volutpat gravida maximus. Quam, nisi et, luctus, id, sagittis feugiat, turpis sem bibendum. Dapibus blandit orci, ornare scelerisque convallis vitae eu, euismod, mattis. Bibendum, ultricies metus sem, finibus, nostra, sodales tempor elit, ante. Auctor, hac id amet, euismod, vel imperdiet blandit, luctus vitae.", 7m, 72m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Morbi", "Posuere.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"), "Imperdiet", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luctus nisi, vitae pulvinar aliquet dignissim auctor, arcu, porttitor lectus. Ac nisl lacus rhoncus malesuada nunc vel class commodo, turpis. Ligula, urna neque, cursus suscipit tempor, tortor, ultricies duis laoreet. Rhoncus, et urna, gravida hac tempus tortor ac, vestibulum, risus. Mattis, orci efficitur dapibus venenatis euismod luctus, commodo, lacinia, placerat.", 94m, 56m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Suspendisse", "Malesuada.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"), "Luctus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eu, donec ligula adipiscing tempor tempor, suscipit luctus, himenaeos lectus. Sem, quis amet, vestibulum, posuere in, iaculis magna, volutpat, ultricies. Urna, vestibulum bibendum, vitae, luctus, semper dui laoreet, mi litora. Varius, ex, sem orci, nisl eleifend ante, curabitur elementum imperdiet. Eleifend luctus commodo, vel, ante quis ligula eros lacinia taciti.", 37m, 93m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Ultrices", "Adipiscing.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"), "Semper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nunc, aenean a, tortor, lacus sem lobortis nisi, gravida sapien. Lorem, tellus, ornare et, taciti vestibulum suspendisse posuere varius, id. Ac, lacinia, in nunc, accumsan dui finibus, rutrum orci class. Aenean tempor sem tellus, interdum sollicitudin posuere, aliquam maecenas litora. Fusce sapien diam quisque nisl tempor, vestibulum lorem erat nulla.", 74m, 75m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Litora", "Eleifend.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7"), "Amet", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eget sed tempor porttitor consequat pretium litora justo vitae vel. Tincidunt nulla, placerat tortor, sem congue ligula, arcu aliquam luctus. Luctus, proin consectetur sollicitudin congue suspendisse neque dictumst ipsum condimentum. Blandit enim, libero odio, sapien tempor, conubia diam ante nisi. Finibus hac ligula porttitor per ex, mauris erat, vestibulum leo.", 69m, 70m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Maximus", "Morbi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4f19d67-4312-431c-a3f9-1a76d5306820"), "Sagittis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tortor elit mattis, vestibulum torquent bibendum inceptos eu accumsan semper. Metus auctor vulputate scelerisque inceptos nisl integer placerat at, aliquam. Consectetur semper diam posuere sapien amet, mattis, mi conubia neque. Lectus, platea urna, tempor, luctus, vivamus tortor, est vestibulum mi. Nunc dictumst vestibulum, porta, phasellus elit, imperdiet erat, massa condimentum.", 82m, 10m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Litora", "Vitae.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"), "Etiam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nec maecenas odio sagittis, a cursus lacus lorem aptent phasellus. Lacus porta elit, purus arcu, molestie condimentum vehicula urna, interdum. Sodales nec, lobortis lectus velit per turpis aptent tincidunt semper. Enim, condimentum varius, lectus bibendum, orci maximus hac dui bibendum. Ullamcorper sem, varius, non, consectetur rhoncus mauris, quam bibendum, hac.", 45m, 71m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 0, "Varius", "Et.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"), "Tortor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commodo, quam fringilla venenatis adipiscing malesuada cras pulvinar rhoncus magna. Mi congue, sapien eu, facilisis volutpat, leo massa, lacinia quis. Integer pharetra arcu tortor luctus cras dapibus enim cursus, dictum. Dignissim eros, interdum, in finibus dolor, porta, volutpat, quis morbi. Porta a massa, in cursus, neque, dolor lorem at id.", 84m, 64m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Fringilla", "Vestibulum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"), "Duis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Enim euismod, nisi, nec, risus a, tempus molestie condimentum ultricies. Dictumst sagittis, enim, dapibus venenatis id nec, vitae odio, posuere. Finibus id, metus ultrices volutpat conubia turpis quisque varius, ante. Sed cras quis sodales finibus libero bibendum rutrum eros dui. Et arcu neque, nam suspendisse sodales mollis porta dui, vestibulum.", 19m, 17m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Nunc", "Diam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"), "Urna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Placerat in, suspendisse magna curabitur leo commodo, nunc sollicitudin lorem. Rutrum adipiscing cursus condimentum sem nisl fermentum leo euismod conubia. Nisl lacinia, iaculis litora elementum cras tempus feugiat pharetra tellus. Vestibulum, erat ligula, interdum consectetur inceptos dolor nibh vehicula mi. At blandit, at, tempor, ligula dui, hac sollicitudin ac, tortor.", 47m, 99m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Convallis", "Nibh.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ProductId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("057912aa-1fee-42ef-ac7a-1fc00873f500"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("05935a3f-9210-4e21-ab3f-7a08662f0960"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("357cca07-da0f-4263-9575-9304ba791639"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("0b25a43d-8674-48bb-bb37-33c5868cc6bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("836bf6f7-71a6-485d-8514-455393908657"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("0ce1f781-ba3b-4353-9d2d-ea4fc3bff138"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("357cca07-da0f-4263-9575-9304ba791639"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("13c5e19c-8fec-46c6-a5b0-bd9a071727e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("167b01aa-f3a2-4e92-98f8-15285397c324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("16d834c4-899e-4385-a5c5-7ee20a866156"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("19df2e7d-b6b1-4279-865c-c3cb6eef469c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("036526be-993c-4d69-ba77-42f606d587cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("1c712568-3924-496e-bd2b-e90e273bdf77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("20de9a89-a7af-457c-a77d-5525f7967e71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("22c529e3-c0cf-4dea-b975-81f33f1344b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("27f9f8c7-445a-4c15-8f9a-c210e9d0498d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("29326627-aeb0-4ef2-8df3-50afa9958b6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("29f51c20-f78d-44ff-b1ca-7a2dfd530c37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("3efab290-b8a5-4786-a245-82b1cedcaaa9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("3f895757-60c2-47b5-b970-8a7b6d2f21bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("41a465a9-a9ee-4074-9e8f-eaa9bf9b162b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("4281874c-0163-4a72-b7dc-bd5c2ae99d9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") },
                    { new Guid("52741742-e69e-4e6f-aadd-2c7c2a1bdce5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("52b62791-a93f-492e-bf2d-dacf15084c91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("541d3c16-c3cf-424a-81ed-1e78e871834c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("5ddcc969-219c-4a7b-9f81-cee0fb595a94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("6036aa7e-32f4-462a-9daf-d36a60d29f96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("6364170f-fe82-47eb-95f5-860fe13c01d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("65a5c17e-1da1-479d-99b1-85b25ac6d7f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("6bf27763-d7fc-4893-96e2-d844a2356432"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("71e1abf5-dba4-4a14-96a7-26ab5ff08ae3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("74faf6c6-2d55-4423-9816-49f2c0e84a02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("7f65eba2-8e80-4619-aacc-d5b2fdbe37cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("812663ee-abb0-4ffa-b869-dfd39087bfb6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("8288865c-9838-46ca-aabc-a09e26628e49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("846a7c4f-b232-4a0f-a4b4-e3dc3c36fd4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("85bde701-fb9d-4046-9a3e-9b9935657855"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("91892802-c837-47a1-8f34-64cf30a26d8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("926e452a-8a75-4aec-ba93-6fe3b8312d9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("a680a97b-eea7-417b-a3f2-6d2eaf01bec4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("a7b1da80-5a54-4d50-a0a0-13360bb50b63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("a96f73c9-1a70-4355-bd13-ee8cd0b2ae98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("b8c76a8e-bb51-4398-ace7-b52fde7de3e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("c2ab942e-060c-43a0-af48-73d80b94cb03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("c3874b20-25ff-4ce1-a9de-5330f8bdf89b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("cbf6d242-6f27-4c36-bd3d-075b6c041229"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ProductId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("ce8e41b9-03ba-430d-94f5-486658c7fdc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("e03e356a-90ec-411d-94f2-64a96123c72f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("e304a5d2-a1a5-4e5a-b39e-2b833bcde4e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("f0652b4f-a6cb-482e-9183-a331198dac04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("f3f84eba-6811-4212-b5a0-a2cd63065214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("f86e9a91-7df3-4fcb-9e35-83d33840b92e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("f9d55e34-a009-403d-a97b-e9ea438b37d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("fc14503a-a7d9-4872-8e04-97c51e8841dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c30630-ef18-465b-9514-fc742de98727"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff8504f-e274-4d9f-984b-df155739e516"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21420154-8f18-4fb3-b745-60621cca5541"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4158bf42-0721-4e06-9ebd-ddf682240f7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53c7a9de-03b5-4482-8163-2d925ca7f3c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("543372da-be2f-4ef6-8496-98a8a075799c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("962d2024-995d-4165-89c9-55e15d2176e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adaa5968-bab8-433d-abc6-217d49fa3395"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba3c9243-5390-488e-b598-2779fd398da8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f19d67-4312-431c-a3f9-1a76d5306820"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("057912aa-1fee-42ef-ac7a-1fc00873f500"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("05935a3f-9210-4e21-ab3f-7a08662f0960"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("0b25a43d-8674-48bb-bb37-33c5868cc6bf"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("0ce1f781-ba3b-4353-9d2d-ea4fc3bff138"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("13c5e19c-8fec-46c6-a5b0-bd9a071727e6"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("167b01aa-f3a2-4e92-98f8-15285397c324"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("16d834c4-899e-4385-a5c5-7ee20a866156"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("19df2e7d-b6b1-4279-865c-c3cb6eef469c"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("1c712568-3924-496e-bd2b-e90e273bdf77"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("20de9a89-a7af-457c-a77d-5525f7967e71"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("22c529e3-c0cf-4dea-b975-81f33f1344b2"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("27f9f8c7-445a-4c15-8f9a-c210e9d0498d"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("29326627-aeb0-4ef2-8df3-50afa9958b6b"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("29f51c20-f78d-44ff-b1ca-7a2dfd530c37"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("3efab290-b8a5-4786-a245-82b1cedcaaa9"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("3f895757-60c2-47b5-b970-8a7b6d2f21bf"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("41a465a9-a9ee-4074-9e8f-eaa9bf9b162b"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("4281874c-0163-4a72-b7dc-bd5c2ae99d9c"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("52741742-e69e-4e6f-aadd-2c7c2a1bdce5"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("52b62791-a93f-492e-bf2d-dacf15084c91"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("541d3c16-c3cf-424a-81ed-1e78e871834c"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("5ddcc969-219c-4a7b-9f81-cee0fb595a94"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6036aa7e-32f4-462a-9daf-d36a60d29f96"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6364170f-fe82-47eb-95f5-860fe13c01d8"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("65a5c17e-1da1-479d-99b1-85b25ac6d7f8"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("6bf27763-d7fc-4893-96e2-d844a2356432"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("71e1abf5-dba4-4a14-96a7-26ab5ff08ae3"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("74faf6c6-2d55-4423-9816-49f2c0e84a02"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("7f65eba2-8e80-4619-aacc-d5b2fdbe37cf"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("812663ee-abb0-4ffa-b869-dfd39087bfb6"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("8288865c-9838-46ca-aabc-a09e26628e49"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("846a7c4f-b232-4a0f-a4b4-e3dc3c36fd4a"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("85bde701-fb9d-4046-9a3e-9b9935657855"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("91892802-c837-47a1-8f34-64cf30a26d8d"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("926e452a-8a75-4aec-ba93-6fe3b8312d9b"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a680a97b-eea7-417b-a3f2-6d2eaf01bec4"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a7b1da80-5a54-4d50-a0a0-13360bb50b63"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("a96f73c9-1a70-4355-bd13-ee8cd0b2ae98"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("b8c76a8e-bb51-4398-ace7-b52fde7de3e5"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("c2ab942e-060c-43a0-af48-73d80b94cb03"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("c3874b20-25ff-4ce1-a9de-5330f8bdf89b"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("cbf6d242-6f27-4c36-bd3d-075b6c041229"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("ce8e41b9-03ba-430d-94f5-486658c7fdc8"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("e03e356a-90ec-411d-94f2-64a96123c72f"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("e304a5d2-a1a5-4e5a-b39e-2b833bcde4e9"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f0652b4f-a6cb-482e-9183-a331198dac04"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f3f84eba-6811-4212-b5a0-a2cd63065214"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f86e9a91-7df3-4fcb-9e35-83d33840b92e"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("f9d55e34-a009-403d-a97b-e9ea438b37d7"));

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: new Guid("fc14503a-a7d9-4872-8e04-97c51e8841dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("036526be-993c-4d69-ba77-42f606d587cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("357cca07-da0f-4263-9575-9304ba791639"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("836bf6f7-71a6-485d-8514-455393908657"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6c8019dc-0237-484d-80dc-452428bce548"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("df749524-0c6b-416d-94c2-398f8b62e92d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f70f7a45-8539-4082-a181-9705c2b5c505"));
        }
    }
}
