using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowerEShopAPI.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "Name", "Password", "Surname", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bibendum@phasellus.com", "Sed turpis", "Quam", "Vivamus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nibh" },
                    { new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "elit@leo.com", "Enim volutpat", "Nisi", "Et", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sagittis" },
                    { new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ac@dolor.com", "Fringilla platea", "Ligula", "Mi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vestibulum" },
                    { new Guid("6c8019dc-0237-484d-80dc-452428bce548"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "tortor@ligula.com", "Lobortis erat", "Maximus", "Ligula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullamcorper" },
                    { new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "condimentum@donec.com", "Odio maecenas", "Elementum", "Quis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Etiam" },
                    { new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "pharetra@tempus.com", "Vitae ultrices", "Dolor", "Varius", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Purus" },
                    { new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "pulvinar@sociosqu.com", "Auctor orci", "Nullam", "Gravida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nunc" },
                    { new Guid("df749524-0c6b-416d-94c2-398f8b62e92d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eleifend@rhoncus.com", "Nulla nunc", "Urna", "Euismod", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tempor" },
                    { new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "a@mauris.com", "Tempor cras", "Velit", "Eu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo" },
                    { new Guid("f70f7a45-8539-4082-a181-9705c2b5c505"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "sem@at.com", "Enim lectus", "Vivamus", "Rhoncus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquet" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Location", "Name", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sit bibendum convallis arcu, ornare etiam ad fringilla, viverra aliquam. Placerat leo quam, turpis nam pretium blandit, ante risus blandit. Mauris, et porttitor, quam, praesent non libero ac hendrerit mattis. Orci, lacinia, tristique tortor, scelerisque non, maecenas mi, sagittis, class. Magna, gravida blandit, orci metus eget vivamus augue nunc at.", "Luctus.", "Varius tortor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eleifend mauris ullamcorper viverra imperdiet nunc, aliquam enim a eleifend. Adipiscing ad vestibulum in, odio tortor, eros, luctus, amet gravida. Sit dolor, luctus, in vivamus ligula, dignissim enim class aliquam. Luctus, sed, litora mauris, vitae pellentesque at odio, taciti imperdiet. Pretium fringilla, ac, pellentesque duis ut orci, interdum, mauris, vulputate.", "At.", "Laoreet non", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nec dictum nulla etiam turpis non, adipiscing aptent mauris, primis. Donec eros, odio elementum eleifend, imperdiet massa, eleifend ante, congue. Velit mi a, id, euismod, in eros, fringilla, lorem, amet. Phasellus praesent non finibus congue, nostra, facilisis nullam leo, faucibus. Placerat tincidunt nunc, malesuada convallis integer cursus, sit porta, posuere.", "Auctor.", "Ipsum eleifend", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") },
                    { new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dignissim interdum laoreet taciti rhoncus, torquent urna, massa felis leo. Erat finibus nec ante pretium urna, massa aliquam bibendum commodo. Nisl rutrum elit, risus posuere commodo tellus, diam volutpat, mi. Arcu at, tincidunt integer sit id egestas tempus lorem, posuere. Bibendum dolor, odio dictum fames at, vel tortor, inceptos lobortis.", "Est.", "Nostra primis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dolor nisi viverra varius semper rutrum elementum placerat magna rhoncus. Etiam odio, commodo dolor, blandit, turpis suspendisse hendrerit non, et. Pretium orci vulputate vestibulum nullam sollicitudin ultrices justo hac leo. Mollis massa torquent augue arcu nec quam, metus dolor, vestibulum. Eleifend cursus neque ac, lacinia, iaculis fringilla, finibus, gravida condimentum.", "Eros.", "Amet suspendisse", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Suscipit finibus ligula congue a dignissim tortor praesent ante rutrum. Porta, sem, finibus augue id congue, eleifend, varius, tristique porta. Dolor malesuada ullamcorper at, ex, id, vulputate neque class dui. Felis cras euismod molestie aliquam amet sit lacinia, platea dui. Posuere, placerat orci, mauris ultrices, lorem interdum mauris, mattis, fringilla.", "Ex.", "Dui primis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fames aliquet luctus, massa, cursus, nisl magna aptent sit nunc. Volutpat ipsum dolor magna, hac ligula, blandit ligula neque vehicula. Dolor, vehicula nulla, magna sollicitudin egestas nostra, purus ipsum odio. Nunc dolor, nisi, feugiat, tempus bibendum, purus duis tellus, iaculis. Rutrum elit arcu purus cursus, sodales semper et, ultrices porttitor.", "Lacinia.", "Tempor arcu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pulvinar blandit amet, tortor per quam, eros, vehicula commodo dui. Non in mollis magna massa class tempus ex, nunc sed. Semper amet ligula nibh, cursus, fringilla, augue elementum est in. Donec morbi elit faucibus amet fringilla, himenaeos et, felis id. Leo lorem, purus pulvinar mauris nulla, eros morbi erat rutrum.", "Sed.", "Nunc maximus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elit eu pharetra venenatis posuere vivamus habitasse nostra, nibh eleifend. Dolor, nisl ac, nec sagittis, elit orci aliquet nunc mattis. Inceptos commodo ligula porttitor erat, justo nisl nunc massa ut. Laoreet dictumst quis varius, orci eros cursus ante tincidunt interdum. Nibh, amet, sem, euismod, arcu semper ornare risus lacus magna.", "Condimentum.", "Ad in", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ligula accumsan tellus, facilisis ex lacinia, at, massa, vel sed. Taciti vulputate rhoncus vel, congue, tempor viverra ultricies vitae, laoreet. Lectus quam, vestibulum, pulvinar inceptos nec, vehicula nisi, sagittis, lorem. Arcu interdum, efficitur tortor, nulla, vestibulum sociosqu proin urna ad. Orci consequat cras pellentesque blandit dolor duis sapien elementum quis.", "Porta.", "Laoreet et", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "Price", "Quantity", "ShopId", "Status", "SubCategory", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00a894bf-a9c6-4930-9928-8b958f0e70ea"), "Ultrices", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luctus leo duis mi aenean accumsan euismod, enim congue posuere. Pretium rhoncus dui neque vestibulum morbi hendrerit amet, blandit ligula. Arcu, volutpat dolor, himenaeos nunc a volutpat, lacinia, iaculis vulputate. Lectus accumsan gravida nullam vestibulum, eros rhoncus conubia at integer. Pharetra neque sociosqu elementum tempus vitae nec vel, sed justo.", 14m, 27m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Dui", "Tellus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("036526be-993c-4d69-ba77-42f606d587cb"), "Orci", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tellus odio, nulla, malesuada lacinia, augue tortor consequat orci, congue. Condimentum dui suscipit adipiscing ut luctus, phasellus vulputate facilisis tempus. Sapien volutpat, justo dolor vel ex, ut vivamus ligula, dictum. Nunc, sem, varius dictumst fringilla nunc aliquet ligula, lectus sed. Sem, finibus, lacinia facilisis massa lorem, venenatis magna, porta, sed.", 66m, 60m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Finibus", "Varius.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06b8beef-8b34-41f7-97e3-b6f2f968a635"), "Dictumst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Porttitor, enim per nunc dignissim arcu curabitur nibh ante, turpis. Nunc, arcu, quam, ultrices gravida erat molestie quis, finibus, tempor. Quis, ad torquent odio neque, ornare ipsum tempor, tortor, litora. Lobortis metus sit eleifend, tortor elementum erat ligula, nisi duis. Non mauris, efficitur leo, blandit neque, lectus donec a curabitur.", 90m, 43m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Mattis", "Elit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08c30630-ef18-465b-9514-fc742de98727"), "Rhoncus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Varius dolor tempor, venenatis libero et lorem, vestibulum, elit, dolor. Ac accumsan hac nullam tristique erat nibh, nisi elementum posuere. Scelerisque nibh, magna fringilla diam viverra elit, nibh id finibus. Nam congue, vitae elit arcu, platea venenatis feugiat, sagittis, urna. Sed aliquet erat, a ipsum pulvinar scelerisque ac augue tincidunt.", 52m, 62m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Efficitur", "Auctor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("095212ae-d9c1-4d27-b6a0-db9421c0651d"), "Porttitor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pellentesque mattis feugiat euismod, ipsum torquent eget nibh vestibulum, mi. Fringilla nisi mi nulla sit augue fermentum dui taciti euismod. Adipiscing eget ut ad cras volutpat et, praesent lacinia, elit. Vel pretium et sed, sollicitudin neque, finibus, lectus tincidunt ultricies. Leo, blandit libero per sem tempor, ex scelerisque lorem, dictum.", 60m, 0m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Nibh", "Tortor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"), "Vulputate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dui proin at fermentum facilisis donec cursus, ex tincidunt orci. Justo vestibulum, nam ultricies lacinia nullam tellus vitae, placerat, ipsum. Arcu, metus egestas mattis, tortor tempor, euismod leo, integer porta. Tempor orci, nulla, egestas quis blandit posuere, inceptos habitasse hac. Sapien lacus nisi, et, diam rutrum fusce nibh turpis sollicitudin.", 92m, 30m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Elit", "Fusce.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"), "Maximus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Porttitor tristique tellus, metus euismod lorem rhoncus, placerat, ante vulputate. Semper orci, nec lectus interdum ligula ac nisl rhoncus, purus. Quam ultrices convallis accumsan orci magna, leo, nisl euismod, neque. Dolor accumsan conubia eleifend, interdum, arcu, maecenas eu sed nec. Neque mattis, quis, vehicula vel, sagittis fames justo gravida eget.", 99m, 12m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 0, "Sed", "Porta.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ff8504f-e274-4d9f-984b-df155739e516"), "Rhoncus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Congue dolor lacinia, leo phasellus malesuada laoreet cras mauris vitae. Enim, mattis, elit fames egestas non volutpat, vitae, massa, dolor. Mauris et, vestibulum placerat, bibendum, finibus luctus conubia nec arcu. Erat massa fames ex, velit fermentum primis sem tempor vestibulum. Leo, eu consequat nisi, arcu dapibus per quam sagittis enim.", 5m, 25m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Id", "Pretium.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"), "Sem", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magna, aenean integer imperdiet posuere eros, accumsan ex, at odio. Donec eget hendrerit euismod fermentum nec, ex turpis finibus id. Etiam cursus, taciti vel cras tortor proin fringilla, pulvinar nec. Malesuada at congue, convallis tempor, nunc ligula varius bibendum lacus. Pulvinar euismod eu torquent nullam nam nisi ultrices ac, et.", 63m, 0m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Bibendum", "Convallis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"), "Faucibus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Amet, primis enim, non vestibulum nibh tempor, eget porttitor eleifend. At, placerat laoreet consequat nostra, feugiat ac nisi, eu dignissim. Magna consectetur iaculis porttitor vel, blandit, rhoncus, tincidunt nisl tristique. Primis ante non, himenaeos augue condimentum commodo lobortis leo placerat. Tristique habitasse magna urna, eu lectus, maximus ornare himenaeos pharetra.", 72m, 74m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 0, "Neque", "Lacus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"), "Consequat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sagittis enim, libero vitae, lobortis velit fusce cras fermentum non. Justo varius nec urna, massa mattis, dictumst euismod ullamcorper ultrices. Proin posuere sociosqu auctor gravida porttitor maecenas feugiat in, massa. Ultrices arcu convallis efficitur euismod, interdum, eu, suscipit ex, proin. Efficitur id, quam, platea bibendum molestie vulputate nostra, sapien aptent.", 78m, 95m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Ligula", "Posuere.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18c3aee2-141e-470b-87e3-cd3320eb073a"), "Orci", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fusce nulla nisi vel elit, lorem, dapibus diam ex, auctor. Condimentum posuere phasellus congue commodo fames eu, convallis quam, pulvinar. Libero ac, nulla, scelerisque id risus ac vitae arcu in. Ac maximus nibh, ultrices, at torquent fames placerat tempor feugiat. Condimentum nisl non efficitur euismod, quis, per in ad aenean.", 91m, 19m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Nullam", "Blandit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21420154-8f18-4fb3-b745-60621cca5541"), "Condimentum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Malesuada nisi, ultrices, diam pharetra sociosqu lorem, commodo, curabitur porttitor. Dolor condimentum sit elit, blandit, sagittis elit eleifend consequat quis. Quisque risus interdum gravida odio et per luctus commodo habitasse. Neque molestie est pretium ante massa congue, litora diam sagittis. Nisi porttitor cras nunc ex interdum, fames quis, dictumst sollicitudin.", 89m, 12m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Curabitur", "Tortor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"), "Nunc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mattis molestie mattis, erat posuere sagittis vestibulum sem, vel gravida. Sagittis, venenatis nisi fusce quis quisque pulvinar, nec efficitur ex. Erat, in, posuere tincidunt mi conubia sociosqu bibendum cursus, placerat. Turpis bibendum, amet nunc, nec sodales pulvinar quam ullamcorper conubia. Nisi, finibus nec dolor, amet, nulla orci porttitor, feugiat, sociosqu.", 33m, 9m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Aliquet", "Eros.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"), "Vitae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eget varius venenatis erat litora augue congue, mi aliquam fames. Interdum ornare litora aenean at ipsum primis nec quis ante. Sed odio eleifend, consequat tincidunt commodo at leo, malesuada volutpat. Lorem, at sem, eu a, tempus neque, leo, dictum duis. Arcu inceptos fusce euismod velit mattis, dapibus posuere nec blandit.", 84m, 84m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Commodo", "Eget.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"), "Erat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sem a urna lobortis et, vehicula lacus elementum felis nunc. Enim venenatis sit nisl vestibulum, blandit aliquam litora lorem, sapien. Nulla enim vulputate aenean sapien mi, volutpat commodo a quisque. Consequat accumsan lectus cursus magna sociosqu ultrices laoreet, ornare donec. Lectus, sollicitudin sed, sit commodo nec, ac suspendisse velit suscipit.", 9m, 79m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Amet", "Euismod.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"), "Fringilla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arcu eu, consequat urna, risus dignissim aenean scelerisque bibendum per. Aenean eros, in lobortis sapien vehicula finibus, eleifend nec, neque. Habitasse tristique non taciti efficitur purus tempor a lacus feugiat. Morbi elementum vitae donec semper nostra, torquent orci, tempus quisque. Ante, dapibus eu commodo, volutpat nibh interdum, maecenas lacinia, torquent.", 92m, 25m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Ad", "Auctor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"), "Blandit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sem quam orci, eu, eros, tincidunt imperdiet gravida massa, conubia. Pulvinar mattis quis et feugiat lacus nisl fringilla, litora per. Mi, ultrices class blandit mauris efficitur erat massa, cras magna. Sem aliquet sollicitudin phasellus laoreet, elit urna, ac ligula eleifend. Bibendum per quisque blandit viverra commodo, phasellus aliquet sollicitudin ante.", 65m, 90m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "Fringilla", "Aliquet.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"), "Tellus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magna nunc ullamcorper varius, interdum at, porta, elit, sociosqu euismod. Massa, gravida vestibulum pulvinar luctus, fermentum nunc ultrices, semper eu. Vehicula odio, risus suspendisse lobortis diam integer duis dui, morbi. Malesuada vestibulum, ornare vitae, mauris, tristique nunc, dolor libero sollicitudin. Purus maecenas taciti venenatis aptent congue himenaeos inceptos nec, adipiscing.", 18m, 65m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Vivamus", "Primis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"), "Justo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elit consectetur hendrerit inceptos odio amet sed ante massa, egestas. Accumsan ultrices fermentum tortor, ad leo, tempus aenean nulla, dictum. Tristique a a, consectetur nisl bibendum, id amet, magna, ultrices. Ullamcorper vehicula orci ligula, viverra libero non donec volutpat, ultricies. Suspendisse pellentesque luctus, dignissim bibendum, luctus taciti mauris, lectus, tellus.", 29m, 30m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Bibendum", "Pharetra.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("357cca07-da0f-4263-9575-9304ba791639"), "Curabitur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rutrum arcu, lectus, conubia eleifend quam fringilla, facilisis ultrices, commodo. Pulvinar, aenean eu, dictum convallis maecenas porta feugiat inceptos amet. Torquent finibus, elementum porttitor, imperdiet leo, per massa, varius diam. Vehicula sodales varius elementum sollicitudin vestibulum, taciti lacinia orci, nec. Elementum mattis neque, ornare lectus, volutpat ante lectus dignissim maximus.", 69m, 95m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Proin", "Quam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"), "In", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elit, facilisis amet, suscipit maximus eget tellus mattis viverra maecenas. Elit ornare curabitur nullam proin sit tristique consectetur maximus pulvinar. Orci quam luctus, nisl maximus ultrices, etiam integer placerat, dictum. Arcu, libero sem tristique elit urna, varius sem, elementum interdum. Orci, at elementum ipsum eu, urna, dictum dignissim mauris lacinia.", 37m, 21m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Tempus", "Non.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"), "Blandit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Viverra magna, tempor ac, porta suscipit accumsan porta, fringilla bibendum. Leo, porta, nec et elit, congue quisque nibh, tortor tempus. Rhoncus, feugiat, ante, in dui, quisque sem, euismod leo vulputate. Cras nibh, aenean inceptos mauris, luctus eros nisl lectus rutrum. A amet sem tellus tellus, lorem nullam bibendum ex, congue.", 10m, 1m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Sapien", "Viverra.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"), "Tristique", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sagittis, posuere, amet, ac sociosqu mi orci, leo, quisque odio. Euismod non, tempor maximus rutrum cursus nibh amet, litora consequat. Varius, sodales pretium aliquet congue posuere sagittis fringilla, elit, luctus. Mi, odio, ultrices, vitae tellus sed aliquet elit, elementum condimentum. Orci, nisl eros, leo, hendrerit consectetur risus fusce vitae arcu.", 4m, 66m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "Nostra", "Nisi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"), "Justo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Volutpat a, amet sem venenatis at luctus, bibendum amet, sem. Fringilla, neque, sem consectetur eleifend, varius, fames ante tincidunt per. Interdum vitae, mi, placerat, quis, cursus, in, elit, lacus conubia. Nibh, cursus, phasellus erat, scelerisque metus lacinia magna pulvinar, at. In proin arcu commodo, suscipit laoreet, posuere odio tristique pretium.", 12m, 74m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Cursus", "Ligula.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3fb47659-d12f-4d78-aa5e-da6eb65ceb79"), "Tempus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem, condimentum dictumst purus facilisis id, hac varius rutrum ex. At blandit fermentum finibus iaculis risus cursus, nam tempor, lectus. Feugiat amet, cursus mauris tincidunt phasellus nisi nibh pulvinar, eros. Porttitor, et nisl turpis a dolor, vel mauris luctus varius. Fusce mauris sagittis enim felis non, lobortis nibh, nisi, rutrum.", 91m, 45m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Orci", "At.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4158bf42-0721-4e06-9ebd-ddf682240f7a"), "Viverra", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mollis dignissim diam dictum non nibh, pulvinar, aenean quam urna. Adipiscing consectetur vitae, ultrices eget nostra, at, iaculis quam viverra. Nulla lorem urna proin dignissim quis pretium lectus erat finibus. Proin suspendisse massa, enim maximus ultrices placerat, efficitur laoreet sagittis. Leo, erat libero non rhoncus, varius, hendrerit commodo eros, mauris.", 63m, 3m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Congue", "Dui.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4662d12e-51f3-47f7-af9b-4929fd9212ba"), "Volutpat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Volutpat, vivamus adipiscing id, ex, ornare interdum, turpis tincidunt condimentum. Tellus massa, mi bibendum aliquet volutpat nec, mattis lacinia suscipit. Vel, turpis tempor rhoncus, urna ultricies porta, nec, posuere euismod. Vehicula nullam nunc tellus nostra, vitae, vel, facilisis consectetur pulvinar. Ante, congue, bibendum, non iaculis dolor, id class id, tempus.", 8m, 92m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Torquent", "Mattis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("485e8c77-c563-46f4-89f7-2af34dd677a9"), "Lacinia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magna, vel efficitur gravida eget a, porta, est dictumst dolor. Vulputate facilisis imperdiet tellus inceptos dui, lobortis ex neque, convallis. Odio, sed, etiam vulputate vestibulum euismod risus quis, convallis libero. Sapien taciti dictum commodo venenatis non id, fringilla congue, lacus. Neque, metus nec, laoreet, litora vulputate proin auctor himenaeos sem.", 78m, 74m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Aenean", "Interdum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"), "Mauris", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Porta quisque molestie nullam faucibus congue rhoncus, lorem eleifend pulvinar. Sem, laoreet lorem, arcu tortor nunc orci, imperdiet dignissim consectetur. Dolor, non, tellus, rhoncus aliquam platea ex aenean cursus, placerat. Dui nibh, class lectus, lectus odio, vestibulum, nec, massa, gravida. Commodo eu, posuere, fames dictumst iaculis maecenas enim dignissim nulla.", 81m, 40m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Turpis", "Consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"), "Dignissim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mattis, eros, torquent suscipit placerat, euismod, dui ac eros aliquet. Sit placerat mattis, nec convallis sollicitudin nibh, neque, libero lacinia. Finibus, vitae proin lectus ultrices ultrices, eu massa sociosqu blandit. Ultricies consequat quis, aptent mauris luctus id rhoncus leo euismod. Cursus tempor, turpis mattis, placerat quis, auctor, magna est aptent.", 15m, 35m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Urna", "Vitae.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"), "At", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maecenas arcu, neque, lectus, nisi, dictumst vel, commodo, tortor justo. Tempor, per ligula, condimentum duis blandit finibus eget velit orci. Sagittis, euismod, sapien porta, cras sit sollicitudin metus ex, risus. Mollis ornare ligula amet, sociosqu risus venenatis quam velit maecenas. Porttitor tempor, dignissim magna condimentum mollis ex erat, dui, eleifend.", 38m, 28m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Amet", "Finibus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"), "Pulvinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gravida maecenas proin tempor tristique ullamcorper in varius erat a. Maximus lectus inceptos mattis, ut malesuada ullamcorper congue ornare vulputate. Felis ornare maecenas dictumst sollicitudin vestibulum facilisis tincidunt habitasse laoreet. Efficitur est scelerisque dui fermentum elit, at, tortor, commodo, nam. Posuere ultricies nisl hac vulputate erat, sit habitasse vivamus mauris.", 57m, 4m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Urna", "A.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"), "Metus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "In, enim ante ex, fermentum dictumst cras placerat, sem, euismod. Mattis, varius, imperdiet fringilla, ornare suspendisse eu fringilla nibh, felis. Lorem, malesuada magna odio in, dictumst nunc commodo sed, inceptos. Nostra, ut elit, mi vitae, vel, sit accumsan feugiat, sem. Nisi, suspendisse in, consectetur auctor, pretium mauris nisl laoreet augue.", 0m, 10m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Hendrerit", "Congue.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50ebb3ee-ec7f-457e-af35-91e698569a9d"), "Ante", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Libero ad lobortis eleifend, fames class cras pharetra eros quis. Litora dolor, posuere mauris neque, odio, est ante ornare sodales. Lacinia nibh, tempor quis eleifend congue non maecenas tristique massa. Hendrerit imperdiet tellus, urna, inceptos fringilla ligula augue rhoncus quam. Cras nibh blandit tempus tincidunt massa finibus, elementum sed et.", 33m, 69m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Turpis", "Bibendum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53553cf5-e117-48da-9b60-9a6fa5555183"), "Sociosqu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tristique nunc, euismod, luctus eros, vulputate a sed, lectus duis. Sed, eleifend, aptent quam taciti semper amet, cras tortor hac. Laoreet, erat, iaculis pretium mollis egestas finibus bibendum neque nec. Adipiscing accumsan libero dapibus nisl id pulvinar sociosqu et, ornare. Arcu turpis quis at rutrum nec maecenas mollis rhoncus, bibendum.", 63m, 32m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Vitae", "Integer.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53c7a9de-03b5-4482-8163-2d925ca7f3c5"), "Tempor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eros iaculis congue, orci, per felis tortor, aenean pulvinar ex. Varius, malesuada fames lectus magna, libero venenatis lacinia, nullam non. Hendrerit non accumsan orci id, orci, bibendum iaculis eleifend, erat. Rhoncus, blandit, lacinia in, lorem, primis massa, orci fames vel. Conubia faucibus ad vestibulum nec, commodo massa, feugiat, malesuada gravida.", 94m, 46m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Morbi", "A.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("543372da-be2f-4ef6-8496-98a8a075799c"), "Risus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fames mi, primis ligula vitae, consequat faucibus porttitor enim, nec. Mauris magna, massa, cursus suspendisse quis at ipsum himenaeos ligula. Tempor, finibus, vel libero lectus lorem elit interdum habitasse proin. Eros posuere semper taciti urna, venenatis eu, dapibus cras eros. Vel urna, eros, lorem, ex nulla commodo elit, ex, lobortis.", 17m, 84m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Imperdiet", "Velit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"), "Vivamus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eget finibus massa consectetur mauris, aptent id, erat gravida in. Tempor, sed, cursus feugiat, velit nunc conubia varius, sodales interdum. Interdum duis id in, rhoncus volutpat, nostra, auctor ipsum magna. Leo phasellus ante, pretium adipiscing laoreet, orci lacus praesent mauris. Dui ullamcorper sagittis, lectus, at nostra, donec volutpat, odio, torquent.", 63m, 24m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Est", "Tempus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"), "Gravida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sociosqu id euismod blandit, nullam himenaeos elementum nec mauris, odio. Nam laoreet, praesent primis himenaeos nisi, tincidunt condimentum vestibulum donec. Tortor convallis massa, iaculis nullam purus tellus at magna quam. Torquent in maximus proin habitasse erat, est ante mattis felis. Proin semper dui imperdiet vulputate magna, ante, curabitur nisi dignissim.", 4m, 59m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Neque", "Quisque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"), "Magna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Posuere, primis iaculis congue ex vitae elit, ac metus finibus. Semper faucibus et ad nunc lacinia, justo condimentum fames proin. Elit lorem, laoreet leo, tempor nibh, amet inceptos felis lacus. Efficitur pharetra a porttitor, et ligula finibus, aliquet ultricies primis. Efficitur vehicula nulla hac congue eleifend, nostra, eu, leo, feugiat.", 33m, 54m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Pharetra", "Fringilla.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"), "Hac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auctor, eleifend, tristique iaculis ornare a pellentesque elit, morbi finibus. Morbi massa, vitae blandit urna, enim eleifend, donec dictumst facilisis. Ad suscipit vel mauris vestibulum nec finibus ornare sagittis luctus. Enim, congue, tincidunt eu, lacinia, porta ullamcorper placerat felis porta. Sit hendrerit habitasse egestas facilisis volutpat, quis mollis fermentum porta.", 36m, 51m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Augue", "Ex.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "Price", "Quantity", "ShopId", "Status", "SubCategory", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("67f51578-3b2d-47af-888c-fa2122dfeaf1"), "Augue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Euismod diam congue, condimentum vel rhoncus nisl elit eu a. Dui, non urna, class pharetra ornare luctus, lectus nulla id. Erat, diam sagittis arcu rutrum ligula, volutpat sed elementum nisi. Amet euismod, porttitor, rhoncus, magna, platea ultrices, cursus vehicula venenatis. Et maximus euismod dignissim quis, vestibulum tempor, lectus ad integer.", 79m, 75m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Velit", "Gravida.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68562155-6ccf-4062-b8ae-277761e3f02d"), "Gravida", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auctor, dui blandit, quisque porta malesuada eleifend, mauris, ullamcorper platea. Aliquam torquent ornare gravida dapibus magna, congue phasellus id urna. Ex gravida sagittis quis leo laoreet, blandit cras lorem fermentum. Libero sapien nunc amet, tortor, sit quis sagittis tempor fusce. Vestibulum sagittis donec litora platea cursus eleifend aliquet dui bibendum.", 18m, 39m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Lectus", "Curabitur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"), "Odio", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Malesuada vulputate neque, pulvinar, nam hac eros lacinia blandit nulla. Proin porta, mauris lectus, lacinia feugiat class congue, porta dui. Massa, himenaeos ligula semper torquent urna, cursus, amet tortor, leo. Ad varius massa etiam inceptos laoreet hac ornare odio, ultrices. Dui ex mauris, risus varius, sed, ac class nisi, commodo.", 98m, 75m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Quis", "Consectetur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"), "Sagittis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Congue elit, platea mi, aenean imperdiet consectetur tristique fringilla dui. Amet quisque enim bibendum, velit tempor, odio fringilla, nec, torquent. Porta eu ipsum dictum class laoreet, lorem sem, lectus hendrerit. Tristique fringilla, habitasse luctus feugiat, aliquam viverra rhoncus mattis sem. Vitae, mauris, porttitor hac neque, eros metus lacus porta lorem.", 19m, 15m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "Neque", "Pellentesque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"), "Rutrum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Duis interdum suspendisse arcu orci, blandit diam nullam eros, a. Eleifend, class quis rhoncus, nunc pellentesque lectus, sem, dignissim elit. Nisi, dictumst laoreet, orci, auctor dolor, malesuada volutpat mauris, etiam. Ullamcorper suscipit condimentum rutrum vivamus quam ornare est lacinia porttitor. Tortor, posuere, egestas pulvinar, nisi sem, amet, volutpat imperdiet condimentum.", 98m, 47m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Ultrices", "Lorem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"), "Rutrum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Erat, nisi sodales nec, ut risus phasellus placerat lacus ac. Nulla, dolor habitasse fusce integer enim, congue, elit, suspendisse leo. Nunc felis volutpat, tortor himenaeos lorem, leo litora fames nec. Dui, hac conubia himenaeos egestas duis dolor, justo iaculis hendrerit. Feugiat tellus, lacinia nunc, turpis mauris, a, mollis quis, pretium.", 18m, 70m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Lacinia", "Interdum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"), "Mauris", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Himenaeos leo pretium erat, ut mauris, vehicula semper scelerisque volutpat. Dui class et, hac lectus, urna platea habitasse dapibus sem. Ac maecenas dictumst risus fames mi, imperdiet nibh, turpis nec. Ornare nisi augue erat, enim odio aliquam congue et habitasse. Odio, aptent mattis, id congue volutpat sit malesuada sodales vestibulum.", 44m, 80m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Dictum", "Vel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"), "Erat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dolor nec amet fermentum urna facilisis urna, sit laoreet, tellus. Vel bibendum, mi sagittis lacinia, vulputate magna, massa quis nisi. Vehicula dui lacinia porttitor, sem malesuada ultricies condimentum lacus laoreet. Nisi, aenean orci, id eros tristique lacinia ornare massa auctor. Nunc ultricies eleifend, et luctus, venenatis pretium maecenas nullam eu.", 43m, 28m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Donec", "Donec.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"), "Leo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dolor, arcu, pulvinar, cursus eleifend, mattis faucibus bibendum phasellus curabitur. Ligula, dictum vitae, donec rhoncus accumsan turpis non pretium duis. Mauris, erat aenean tincidunt lorem, volutpat, pretium ex, mattis, neque. Lorem, ultricies placerat proin malesuada mattis, ipsum purus ad platea. Neque odio, egestas lacinia, vel libero bibendum, est massa, eu.", 4m, 34m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Efficitur", "Mi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"), "Velit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Id feugiat diam etiam justo non dictumst vestibulum euismod, rhoncus. Himenaeos lacinia, torquent quam, auctor, id, leo, porta, neque, etiam. Dui, sagittis, quis luctus euismod odio, vestibulum, vulputate ullamcorper auctor. Faucibus mollis dictum platea pulvinar metus quam molestie erat, ante. Nisi eget conubia lectus, nam sapien cursus, sodales turpis fringilla.", 33m, 36m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Massa", "Neque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"), "Sit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nibh rhoncus augue eleifend, dictum fringilla condimentum porta at, bibendum. Ipsum egestas faucibus mattis, turpis lobortis fringilla, neque, per euismod. Auctor enim venenatis in convallis sociosqu quis, nunc, tincidunt blandit. Lacinia lobortis fermentum lorem, elit vitae, ex, aliquet laoreet fames. Turpis quis, mattis venenatis pulvinar, vel, arcu, sed, nulla, ante.", 99m, 46m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Quam", "At.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("836bf6f7-71a6-485d-8514-455393908657"), "Phasellus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vivamus bibendum amet, consectetur id, erat mi, dui, at vestibulum. Et, bibendum, dui, finibus, aliquam arcu aptent amet, venenatis himenaeos. Cursus, nec, vestibulum, vel per hendrerit quis lectus dui at. Fringilla lorem, neque sagittis augue orci viverra taciti donec purus. Mollis in turpis ullamcorper urna eu gravida metus consectetur ut.", 36m, 51m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Tincidunt", "Ultrices.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"), "Id", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nunc laoreet auctor, vehicula massa nunc, consequat tellus, convallis donec. Eget conubia orci cras accumsan quam non, volutpat, nibh massa. Erat vel sem, aliquet torquent phasellus porttitor, commodo nisi ante. Vehicula dictumst mauris, praesent lorem fames orci in, et auctor. Iaculis quisque quam rutrum gravida eu elementum dolor mi, massa.", 53m, 83m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Sollicitudin", "Diam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"), "Mattis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Urna vestibulum ad tempor, cursus, dictum hac sodales neque habitasse. Magna, ad iaculis ultrices nam elementum mi, nisl blandit, dictum. Faucibus tempor luctus, cursus, aenean congue lectus ac, feugiat sodales. Lorem, lacus ante, volutpat, adipiscing turpis fusce dolor varius rutrum. Lorem, varius lectus libero torquent suspendisse himenaeos nam eleifend, urna.", 14m, 50m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Sollicitudin", "Volutpat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"), "Vulputate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nam lacus quam, interdum praesent dignissim lectus, mauris aliquet ornare. Facilisis commodo enim et, amet hendrerit elementum aenean maximus aliquet. Vel, tempus bibendum porttitor ligula nunc, augue enim rhoncus massa. Lorem nisl placerat et, commodo, nisi, cras luctus, sagittis, elit. Nec, lectus dui commodo integer aliquam ante, vel inceptos sit.", 64m, 90m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Interdum", "Leo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"), "Cras", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Orci, nisi gravida tristique eget feugiat diam massa eu, in. Eleifend, urna, posuere congue bibendum condimentum et quis, interdum euismod. Ullamcorper enim, lacinia consequat dapibus tristique ante adipiscing varius accumsan. Varius non, quis pellentesque at sem nisi, aliquet cursus, eget. Eros per tristique cras efficitur primis magna, malesuada fames adipiscing.", 56m, 1m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Vel", "Elit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"), "Libero", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lectus, mauris, leo per praesent risus rhoncus, neque suscipit bibendum. Sapien volutpat facilisis vitae blandit, varius, quisque enim, rhoncus, dui. Consectetur lacinia, vitae accumsan placerat, mauris in, elementum nisl risus. Leo enim, nec aptent porttitor, dui nisl neque integer at. Ornare volutpat, vulputate sociosqu odio commodo, libero est cursus tempor.", 25m, 56m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Ante", "Primis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"), "Consequat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Varius id integer elit, mi urna ad auctor, rhoncus, bibendum. Leo ex, cras phasellus fames vitae, efficitur neque taciti sociosqu. Urna, eu porta curabitur ligula auctor sem, vel, odio, eget. Per ac, urna, eget commodo, ligula magna mollis consequat suscipit. Mauris varius, porta, erat, vestibulum, facilisis malesuada consequat a tortor.", 59m, 6m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Massa", "Vestibulum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("962d2024-995d-4165-89c9-55e15d2176e3"), "Pulvinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ultricies dapibus turpis vehicula lacus est posuere congue lacinia mattis. Duis ullamcorper sagittis vestibulum, rhoncus, turpis magna nisl hendrerit placerat. Mattis suspendisse laoreet, blandit, nullam semper lacus mauris, nibh, porta. Porta ultricies lectus, mattis pharetra enim enim, nunc, eleifend, per. Porta et, iaculis rhoncus nisi, scelerisque commodo sed, felis feugiat.", 78m, 39m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Lobortis", "Iaculis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"), "Lacinia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Risus inceptos ultricies congue commodo pulvinar non eros, cursus, proin. Aliquet fusce sodales arcu dignissim mollis ultrices lacinia volutpat, ante. Elit, dignissim himenaeos enim, quisque quis dictumst sollicitudin gravida aliquam. Nisl curabitur litora pulvinar, ullamcorper maximus magna, est at mollis. Orci varius vivamus odio lectus, pretium conubia litora congue, rutrum.", 78m, 79m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Habitasse", "Elit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"), "Nulla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ut non, vel dictum sed urna aliquam sagittis, nec, nunc. Vestibulum class vehicula phasellus quisque blandit, eleifend, aliquet porttitor, morbi. Maximus scelerisque elit feugiat dolor, proin vulputate lectus porta, hendrerit. Luctus posuere, sodales mauris, primis commodo, consectetur massa nulla, maecenas. At quis et, tortor conubia nibh quam ultricies non, turpis.", 33m, 68m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Laoreet", "Habitasse.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"), "Feugiat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Laoreet, varius, eleifend eros fames taciti ac, ullamcorper morbi non. Interdum, lacus imperdiet enim metus magna a platea ultrices, et. Odio, praesent a, laoreet, sem sociosqu velit iaculis euismod, semper. Fringilla, arcu interdum, auctor efficitur dignissim tempor, at, pulvinar, magna. Bibendum, tincidunt fringilla quisque urna, egestas dignissim mattis, cursus ante.", 74m, 81m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Quam", "Leo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"), "Id", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Volutpat, mauris, iaculis ullamcorper amet, interdum, ex semper faucibus quam. Ornare nisi dolor, pretium ut lectus, lorem, mi lectus arcu. Porta, nullam rhoncus, maximus lectus, maecenas sem in tempus tellus. Bibendum, nulla lorem ligula, at ac tempor, quam luctus auctor. Vestibulum rhoncus, massa, per sagittis, sit ultricies elementum ante, dolor.", 89m, 31m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 0, "Odio", "Vel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2431d50-d56a-44d6-9f98-cef4cffc1d25"), "Cursus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pretium molestie maximus auctor quam, quisque ac, quam nec efficitur. Sed, leo, elementum vulputate metus himenaeos eleifend, euismod enim interdum. Neque nibh, aenean lectus placerat lacus erat, dictumst nisi adipiscing. Placerat blandit, et, sem, sagittis interdum magna sagittis, rhoncus, suscipit. Consectetur pharetra consequat risus mattis pellentesque non eleifend non, dui.", 24m, 76m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Aliquet", "Eros.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4d10547-52c0-405f-88c3-9b3d1c51e043"), "Fames", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nunc integer litora quam ante auctor urna, id quis, et. Fusce odio maximus ex inceptos tempor, lorem, quisque malesuada nec. Varius commodo, neque aliquet pulvinar, justo quam congue, orci molestie. Hac conubia magna, varius quis ultricies nisi, vel nam ex. Eros, elit, neque, torquent in ac, congue, hac pretium ante.", 30m, 80m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Ultrices", "Dictumst.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"), "Malesuada", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pellentesque dui, vitae quam congue, consequat non, morbi amet, vel. Euismod morbi laoreet diam integer bibendum, porta, sodales mattis, sagittis. Placerat ante, neque orci luctus, porttitor id aliquet dui, volutpat. Feugiat, porttitor laoreet dolor nibh vel phasellus faucibus sit metus. Vehicula lacus integer turpis suscipit conubia nec urna aenean class.", 17m, 28m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Tempus", "Neque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"), "Vestibulum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Taciti facilisis interdum, porttitor, vel hendrerit nisi, rutrum ex accumsan. Cras faucibus cursus sollicitudin porta in, quis, adipiscing facilisis metus. Praesent massa, tristique eget inceptos arcu, vel consequat taciti sollicitudin. Urna, ligula, arcu, litora pulvinar, luctus, fringilla, habitasse elementum fames. Tortor, quam, congue pellentesque per blandit ut ipsum tortor nunc.", 15m, 67m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 1, "At", "Nisi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6691809-aee3-46ac-8313-a2eedb8409cd"), "Fames", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eleifend, bibendum, fusce tortor hendrerit placerat neque mauris morbi vitae. Finibus, elit blandit quam leo, amet, habitasse fringilla at lacinia. Maecenas vehicula mollis euismod, erat, augue sollicitudin faucibus habitasse eros. Odio, aptent mattis, tincidunt fermentum scelerisque ligula leo sem, fames. Tempus sagittis, id vulputate vitae, luctus, eu cras blandit porttitor.", 52m, 78m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Neque", "Mattis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("adaa5968-bab8-433d-abc6-217d49fa3395"), "Aenean", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mollis iaculis libero congue, dui ornare pretium vestibulum ac, sagittis. Turpis sem, volutpat, dolor, molestie arcu ex euismod pulvinar semper. Taciti magna ligula, aliquet elit, fringilla, platea aenean vel lobortis. Enim orci vestibulum cras fringilla, primis sociosqu eget at, vitae. Fermentum sollicitudin commodo pellentesque hac dui duis malesuada vulputate massa.", 6m, 26m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Velit", "In.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"), "Enim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Velit molestie nam sit pharetra cras laoreet, eu, ac, porta. Quam quisque placerat dui, consequat vel, massa elit orci elit. Nibh, orci conubia nec, varius, ipsum tempus convallis arcu euismod. Posuere vestibulum venenatis tortor litora phasellus congue commodo, nostra, dolor. Lacus class erat, suspendisse neque scelerisque metus a sed pulvinar.", 56m, 8m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Dapibus", "Congue.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aedd63d0-11e5-48e1-bf68-02bb9745c0e2"), "At", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lacus nisi sagittis aptent lectus ullamcorper tortor, eleifend imperdiet libero. Porta elit, himenaeos dui, posuere, orci, erat imperdiet conubia interdum. Porta, ante, accumsan tempor varius, nisl neque molestie congue tellus. Conubia nibh sapien gravida est nulla congue, odio congue condimentum. Morbi auctor libero curabitur orci eleifend hendrerit vestibulum, nulla sed.", 53m, 64m, new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"), 1, "Placerat", "Commodo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"), "Quisque", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eleifend, ex luctus, non adipiscing porttitor cursus, aliquam sagittis facilisis. Sed, ante ac porttitor lacinia, imperdiet in aenean turpis tristique. Massa vestibulum, nullam bibendum, quam pharetra sapien hendrerit orci nulla. Tincidunt ullamcorper porta, a pharetra dignissim gravida sed in adipiscing. Enim tristique id, bibendum metus lacus eu dignissim malesuada tellus.", 4m, 83m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Dictum", "Etiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"), "Lorem", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mauris, dapibus inceptos semper volutpat, odio, quam, feugiat leo, eros. Sociosqu lacus ante, aptent feugiat, sodales posuere, neque scelerisque proin. Posuere euismod, tempus metus rhoncus, mollis tempor gravida curabitur tellus. Quam, platea ante, lacus elit arcu porta at, molestie magna. Sem, fermentum pulvinar maecenas hendrerit interdum, feugiat euismod, porta risus.", 62m, 13m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Tellus", "Luctus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"), "Fringilla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Accumsan dictum tortor, ultricies aliquam nunc, vulputate ornare duis porttitor. Venenatis lorem, ex, elit, porta dictum faucibus duis congue tellus. Nulla felis pretium consequat lobortis eleifend fermentum vel eu lacinia. Per est nisi cursus, elit, tortor, lectus at varius sodales. Pulvinar, orci, ac sociosqu inceptos condimentum varius, facilisis placerat bibendum.", 84m, 3m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Porta", "Blandit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"), "Faucibus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Feugiat magna, erat vitae, volutpat in leo fusce dui ac. Sit justo consequat enim, accumsan rhoncus, urna, fermentum auctor, quisque. Dolor, eu, fames convallis class consequat velit interdum, nullam taciti. Sed, placerat sem cursus risus hendrerit orci, commodo vulputate a. Lacinia pellentesque arcu, porta, sem, nec rhoncus himenaeos posuere, commodo.", 59m, 0m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 0, "Quam", "Viverra.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"), "Cursus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Velit congue aenean imperdiet suscipit euismod eleifend nisi ultrices, laoreet. Magna, etiam primis eros, lectus placerat a, commodo malesuada interdum. Ultrices himenaeos ex donec quam sagittis sed, vitae venenatis habitasse. Donec nunc, ullamcorper massa ligula, sagittis, viverra eleifend nullam varius. Purus morbi nam luctus, hac eros nisi, nibh convallis lorem.", 22m, 32m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 1, "Ex", "Ultrices.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba3c9243-5390-488e-b598-2779fd398da8"), "Id", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Congue, in dolor vitae, accumsan platea nunc, dapibus ultricies nec. Volutpat, convallis eu ex augue at mollis vulputate nunc, aliquam. Lectus, molestie porttitor efficitur litora himenaeos urna interdum euismod vivamus. Ultrices, interdum, vehicula dolor, laoreet, nibh vulputate varius himenaeos at. Aptent commodo, luctus, eros ut vehicula orci tempus dolor suscipit.", 18m, 43m, new Guid("ebe00220-011d-43ed-9869-c852ea8ed3dc"), 0, "Ante", "Dui.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"), "Vestibulum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Finibus, semper ante vitae, justo eu, ligula enim suscipit lobortis. Lorem neque auctor urna, habitasse faucibus dui elit in congue. Fringilla dolor morbi maecenas nam ornare pulvinar, quisque eros, massa. Leo, nunc vulputate in, interdum enim, egestas rutrum porta maecenas. Vitae sed nostra, finibus, leo, cras elit ultrices hac torquent.", 25m, 55m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Ac", "Proin.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"), "Eget", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ligula ultricies arcu donec laoreet, tellus, vel, cursus, urna, elit. Semper habitasse felis eleifend, non, tempus sociosqu eu vivamus class. Nostra, quis nibh commodo, integer hac nec tempus volutpat feugiat. Lorem, a, cursus, orci, molestie efficitur vitae, nullam sem interdum. Nulla sociosqu congue, nibh, finibus, conubia vestibulum, proin per dictumst.", 79m, 35m, new Guid("36371838-e3fe-43f7-8e14-10d372ed4d2f"), 1, "Aptent", "Neque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca66e36f-e1b2-4e22-9ad8-0627719b1cb0"), "Eros", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vestibulum, fusce ultricies tincidunt neque, laoreet rutrum donec non auctor. Tortor, et, ligula a, quis nibh, rutrum feugiat, libero integer. Posuere ex, eu tempus nisi, luctus, taciti hac porttitor, lobortis. Nullam eros, class porta varius non dui, litora suspendisse proin. Porttitor litora etiam eu eleifend, a commodo, himenaeos vitae consectetur.", 7m, 58m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Himenaeos", "Ullamcorper.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0dc2435-2fe7-49a3-9d31-ac57636b7061"), "Vel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Urna, enim eleifend tortor, sagittis, leo, nulla dignissim vitae semper. Congue, donec vehicula litora mi mauris, non et, magna bibendum. Mauris lacinia, metus lectus, erat, placerat sed, congue sem, ipsum. Ornare dui suspendisse efficitur aliquam placerat, commodo lectus, varius, maximus. Eu tempor, pellentesque eleifend ullamcorper rutrum augue est dui, nunc.", 16m, 61m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 1, "Class", "Amet.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"), "Conubia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aenean hendrerit ex platea lectus molestie non tortor per praesent. Ad auctor, eleifend, tempor, bibendum, phasellus varius platea facilisis blandit. Integer sem, vel, tortor, volutpat praesent enim ex nisl tempor. Posuere tristique fringilla rhoncus auctor, in orci, finibus quis erat. Ultricies luctus eget cursus molestie lorem, sit quam vel, accumsan.", 21m, 26m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Ac", "Etiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "DeletedAt", "Description", "Price", "Quantity", "ShopId", "Status", "SubCategory", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"), "Vel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mi eu inceptos morbi aliquam aenean pharetra enim, massa, dictum. Posuere, urna hendrerit elit at, fringilla tempor, finibus volutpat condimentum. Torquent ac, sagittis nisi, class primis gravida dictumst facilisis lectus. Quam commodo tellus ut nostra, faucibus nec, lectus vel, nam. Dui, proin placerat in, vestibulum, sem a erat, litora eleifend.", 17m, 58m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 0, "Pulvinar", "Sed.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"), "Dapibus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Interdum, nulla, odio maximus scelerisque class leo ipsum sem, tortor. Libero tortor, nisi himenaeos litora dui, commodo, quam, blandit dictum. Nulla, eros non, orci interdum, sed porttitor, a, quam diam. Nam nunc, phasellus vitae iaculis mollis tortor, mauris orci, ligula. Et litora vitae nulla convallis dictumst taciti justo diam urna.", 8m, 43m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 1, "Varius", "Euismod.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"), "Cras", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sem, tempor, dictum tortor, consectetur volutpat nulla, ex orci faucibus. Placerat nibh, accumsan viverra et, habitasse ipsum nam vel eget. Eget pretium dolor vulputate ornare tempor, sagittis tempor suscipit tellus. Porta, justo tortor viverra tempor ultrices, metus eu, amet himenaeos. Gravida quam, odio augue vitae, imperdiet feugiat viverra nisi enim.", 64m, 72m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 0, "Sapien", "Semper.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"), "Pulvinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nostra, etiam curabitur mauris, faucibus sem, mi, lectus ultricies primis. Rhoncus, quam, ex, lectus, eleifend, orci, tortor, faucibus malesuada erat. Porta ullamcorper massa fusce porttitor, dolor, mattis volutpat malesuada aptent. Habitasse vivamus laoreet per quis, vulputate vel inceptos mattis tincidunt. Bibendum, mi enim posuere, cursus, taciti non rutrum proin mauris.", 72m, 98m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 1, "Turpis", "Fames.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"), "Arcu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sem proin quis fames consectetur pharetra interdum maximus conubia nulla. Semper placerat, quisque mauris justo tempor, dignissim leo, non nec. Imperdiet semper phasellus a, efficitur ex, hac libero id, nam. Erat integer per ullamcorper luctus, aenean enim, inceptos class magna. Quam arcu, dolor, lobortis mi commodo, fringilla vestibulum, convallis et.", 67m, 84m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "Magna", "Bibendum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"), "Mauris", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auctor, proin lacinia, efficitur malesuada nibh, et orci fringilla, turpis. Neque aliquet cursus duis vestibulum, fringilla, congue, euismod, convallis tortor. Adipiscing amet, lacinia class tempor nisi diam elementum cras sit. Sem cursus ex ex, rhoncus et in praesent bibendum, ultrices. Arcu, feugiat, mi eros quam, convallis est ad ac, a.", 78m, 72m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Sem", "Nec.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"), "Ex", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lobortis nec, erat tortor aenean luctus, enim, sagittis nostra, phasellus. Mattis, pulvinar, est varius, pretium in sagittis, ac, ultrices, nisl. Semper habitasse aliquam justo tortor, cursus, eleifend neque nec mi. Cursus nisi, adipiscing massa, pellentesque laoreet per volutpat, tortor, augue. Fringilla, vehicula torquent arcu, non, gravida blandit, ullamcorper platea vestibulum.", 24m, 18m, new Guid("1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7"), 1, "Quam", "Commodo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"), "Rhoncus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Euismod sagittis tristique donec rutrum tempor, velit est purus vel. Nisi, orci, rhoncus, ac, placerat praesent tellus, porttitor, morbi laoreet. Ultricies mi dictumst sit dolor suspendisse tellus tristique amet est. Cursus massa, imperdiet leo vitae sit phasellus ex, mattis, efficitur. Erat maximus gravida inceptos fusce nam porta, orci posuere, nibh.", 33m, 65m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Iaculis", "Pulvinar.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"), "Massa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ex auctor sodales rhoncus neque adipiscing dignissim justo orci, at. Fusce in, a, eu, mollis accumsan lacinia at nec in. Erat, varius, etiam at tristique sagittis tortor himenaeos porttitor, fames. Interdum, porttitor, urna facilisis interdum nunc, semper tristique posuere neque. Leo, sem, massa integer pretium ex arcu, risus tristique sociosqu.", 40m, 93m, new Guid("232d3f3d-c138-4f4b-a682-c28928c0593b"), 1, "Vestibulum", "Lobortis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"), "Amet", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Volutpat conubia suscipit sociosqu dignissim nec tristique elementum platea posuere. Augue consequat ac cursus, sociosqu ultricies dignissim tempor, blandit luctus. Cras blandit, arcu et laoreet aliquam dignissim viverra ex, lorem. Nulla, volutpat, est aliquam magna eros hac mauris orci, volutpat. Elit, nunc, condimentum tempor, laoreet, pellentesque porttitor, ac, neque, nunc.", 69m, 43m, new Guid("97d490c6-a39f-40ea-a42b-041e256470b0"), 0, "Lobortis", "Pellentesque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7"), "Cursus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pharetra maecenas bibendum orci, taciti conubia sed mauris, sem, at. Rutrum interdum sem euismod himenaeos tincidunt morbi hac bibendum erat. Tortor aliquam volutpat convallis nam tincidunt pharetra mauris elit, platea. Placerat luctus, ultricies etiam a, consequat suscipit dictum hac tortor. Enim, aenean libero sem, nec, consectetur et id, lacinia, ultrices.", 3m, 75m, new Guid("158ad77c-5b60-4656-ac54-b4208d4df31d"), 0, "Est", "Consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4f19d67-4312-431c-a3f9-1a76d5306820"), "Commodo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fringilla, orci, commodo, tempus ligula, volutpat, leo maecenas cursus, sem. Magna, ligula nulla hac massa, ac, proin donec platea ex. Tellus, sollicitudin non a bibendum, primis convallis vestibulum, feugiat felis. Id lobortis in nulla, ultrices, non, lectus, rhoncus molestie amet. Rhoncus porta semper nullam nibh commodo, varius et lacinia, sem.", 56m, 72m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Varius", "Turpis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"), "Vel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ac, lectus ligula, neque lacus blandit eleifend, habitasse quisque malesuada. Dignissim vitae, mauris, viverra sit adipiscing sociosqu venenatis mi, proin. Molestie luctus, dictum laoreet, ultrices, urna, elit, bibendum maecenas euismod. Mauris eleifend, massa, id, congue, vel mattis, nulla, urna, porttitor. Cursus, quisque volutpat, varius fermentum non dictum enim, velit lorem.", 73m, 13m, new Guid("585ef689-630d-4dc9-99b1-7b78d6c5f324"), 0, "Ac", "Volutpat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"), "Euismod", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nulla eget donec blandit feugiat, ex, elit suscipit neque vestibulum. Diam libero vel, class tempus maecenas facilisis quisque mattis etiam. Hendrerit est eu, morbi eget varius, accumsan nec, proin sem. Quis, interdum eleifend, class non ex erat at taciti vehicula. Aenean tortor donec orci, fusce litora malesuada nunc, ex dolor.", 85m, 2m, new Guid("040f82fb-9fdb-4ba9-adad-a260b2656c3d"), 0, "Sodales", "Mattis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"), "Ex", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tortor odio vel et, habitasse sodales placerat, interdum sagittis, magna. Suspendisse luctus iaculis tristique sociosqu vestibulum neque bibendum, dolor nisl. Dictumst nulla, duis semper fringilla, suscipit interdum id, condimentum lacinia. Vel dignissim pellentesque orci, viverra ad laoreet, aliquet porta, felis. Mauris mollis posuere, nisi ac, et, platea libero urna ligula.", 86m, 81m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 1, "Ac", "Elit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd321667-43d3-4a3f-beea-66f62c826f62"), "Odio", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ultrices tellus lobortis sapien erat id egestas massa, duis auctor. Id, nisi, tempor nec eros, nec, tincidunt malesuada congue, laoreet. Posuere, tortor gravida in, ex, lacinia, pellentesque efficitur cursus lorem. Adipiscing magna porta lorem vel, vulputate dapibus interdum, torquent vestibulum. Conubia hac lorem porta odio pellentesque volutpat, luctus, mi, lorem.", 58m, 67m, new Guid("4340854d-95d2-4156-9b53-4af221fbc7ab"), 0, "Leo", "Tempor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ProductId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("057912aa-1fee-42ef-ac7a-1fc00873f500"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("05935a3f-9210-4e21-ab3f-7a08662f0960"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("0b25a43d-8674-48bb-bb37-33c5868cc6bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("0ce1f781-ba3b-4353-9d2d-ea4fc3bff138"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("322fa14d-15a4-4b54-8d5d-7c0ba422ae17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("13c5e19c-8fec-46c6-a5b0-bd9a071727e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("167b01aa-f3a2-4e92-98f8-15285397c324"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("16d834c4-899e-4385-a5c5-7ee20a866156"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("94053d32-4e55-4c9d-bf0e-d533c0c2f7f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("19df2e7d-b6b1-4279-865c-c3cb6eef469c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("1c712568-3924-496e-bd2b-e90e273bdf77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("962d2024-995d-4165-89c9-55e15d2176e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("20de9a89-a7af-457c-a77d-5525f7967e71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3421e1b7-8a77-48c5-ad11-912e3c0a5e5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("22c529e3-c0cf-4dea-b975-81f33f1344b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("27f9f8c7-445a-4c15-8f9a-c210e9d0498d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("29326627-aeb0-4ef2-8df3-50afa9958b6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("29f51c20-f78d-44ff-b1ca-7a2dfd530c37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("3efab290-b8a5-4786-a245-82b1cedcaaa9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("3f895757-60c2-47b5-b970-8a7b6d2f21bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("41a465a9-a9ee-4074-9e8f-eaa9bf9b162b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("4281874c-0163-4a72-b7dc-bd5c2ae99d9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("08c30630-ef18-465b-9514-fc742de98727"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("52741742-e69e-4e6f-aadd-2c7c2a1bdce5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("52b62791-a93f-492e-bf2d-dacf15084c91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("541d3c16-c3cf-424a-81ed-1e78e871834c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8cf1e86a-ae98-4087-b230-4ed19e072c90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("5ddcc969-219c-4a7b-9f81-cee0fb595a94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("6036aa7e-32f4-462a-9daf-d36a60d29f96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("6364170f-fe82-47eb-95f5-860fe13c01d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("65a5c17e-1da1-479d-99b1-85b25ac6d7f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("6bf27763-d7fc-4893-96e2-d844a2356432"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("71e1abf5-dba4-4a14-96a7-26ab5ff08ae3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") },
                    { new Guid("74faf6c6-2d55-4423-9816-49f2c0e84a02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("7f65eba2-8e80-4619-aacc-d5b2fdbe37cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("341df24b-16d2-4455-b5a9-c902c78a6543") },
                    { new Guid("812663ee-abb0-4ffa-b869-dfd39087bfb6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("8288865c-9838-46ca-aabc-a09e26628e49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("846a7c4f-b232-4a0f-a4b4-e3dc3c36fd4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5053ea0-23d0-4319-a56f-16a719e7a5bf") },
                    { new Guid("85bde701-fb9d-4046-9a3e-9b9935657855"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df749524-0c6b-416d-94c2-398f8b62e92d") },
                    { new Guid("91892802-c837-47a1-8f34-64cf30a26d8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("926e452a-8a75-4aec-ba93-6fe3b8312d9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("a680a97b-eea7-417b-a3f2-6d2eaf01bec4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("ba3c9243-5390-488e-b598-2779fd398da8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("a7b1da80-5a54-4d50-a0a0-13360bb50b63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("0ff8504f-e274-4d9f-984b-df155739e516"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("a96f73c9-1a70-4355-bd13-ee8cd0b2ae98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") },
                    { new Guid("b8c76a8e-bb51-4398-ace7-b52fde7de3e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6d7f7be7-1d23-478e-8aca-581c78e961ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("c2ab942e-060c-43a0-af48-73d80b94cb03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("c3874b20-25ff-4ce1-a9de-5330f8bdf89b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("88896fd9-3470-4c4c-ba9b-2fd1899b910a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("cbf6d242-6f27-4c36-bd3d-075b6c041229"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("357cca07-da0f-4263-9575-9304ba791639"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3940bfc-2107-4713-b8b6-a332cf0eb318") }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ProductId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("ce8e41b9-03ba-430d-94f5-486658c7fdc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("883b612a-0eaf-43bf-8d9b-e69a018a7140"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d74cfad8-b077-44f7-b29b-d8fa88164cfd") },
                    { new Guid("e03e356a-90ec-411d-94f2-64a96123c72f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c8019dc-0237-484d-80dc-452428bce548") },
                    { new Guid("e304a5d2-a1a5-4e5a-b39e-2b833bcde4e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6c48d5d0-ad7e-4678-8e72-6e2878e8e431"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("f0652b4f-a6cb-482e-9183-a331198dac04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("669eeb98-5fa4-45a5-bfa0-24554a7945ec") },
                    { new Guid("f3f84eba-6811-4212-b5a0-a2cd63065214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("69009dde-2586-4cb1-a78d-560cbe078c68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f70f7a45-8539-4082-a181-9705c2b5c505") },
                    { new Guid("f86e9a91-7df3-4fcb-9e35-83d33840b92e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2") },
                    { new Guid("f9d55e34-a009-403d-a97b-e9ea438b37d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") },
                    { new Guid("fc14503a-a7d9-4872-8e04-97c51e8841dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2adec3-895b-4cc1-b5b5-a408255fce2b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("0c565494-047e-49f7-bcd4-16981f33a32b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d840aa1-19af-44b6-b74e-b36df4f8f53d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15dc89e1-80ef-4083-9beb-86c83c3eee74"));

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
                keyValue: new Guid("2923f717-c7fb-4f1e-b74f-9eaaeff98672"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("352a6160-e3b6-46eb-be08-e7702c3f111d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37309a47-24d9-47d2-af34-7ed863b78e2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382dc6cf-617d-4974-aa9b-3d166feeebff"));

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
                keyValue: new Guid("4a33ee82-a5de-4f44-972e-c54edb321299"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1056de-68cd-4ec4-9894-09a8eb1b008d"));

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
                keyValue: new Guid("5f60fd31-6e4a-4e08-ad83-f0e90680a00a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67347a37-faa5-4e00-83d1-da4019d814e1"));

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
                keyValue: new Guid("74b10291-cdcc-42fd-8595-59db3aab19ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77bca806-729f-48b3-aa6c-03da08cbc266"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bdce160-945a-4b8d-84c9-f3375a1814f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("813727fb-f1f2-49fd-8c4e-1c6c7018f82d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("836bf6f7-71a6-485d-8514-455393908657"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91863f6f-4179-4d5d-9eea-c4e5be4a3059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9873295b-5f32-4aa8-a1cc-8b411d16cbb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9afb1d8d-3f4e-4c03-8bd1-0630298f2362"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0da6667-3488-411a-aa3c-f7c6636a2a65"));

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
                keyValue: new Guid("a4f61a6f-1102-4819-a69e-63bc9600ffb3"));

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
                keyValue: new Guid("b2580f32-8d33-4ef6-a843-49fa87da6a7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba09d33b-4a76-463e-ab62-2d789a476acb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bda9c7da-7497-40d4-886e-e7bbe1f5c7bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c05ecf17-278d-4da4-b89f-ed53e0fa3c58"));

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
                keyValue: new Guid("d2d818d2-5043-4dc9-a0c9-5cc21023fcbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcfa04b0-16a5-46dc-8330-f079042ce625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfc14f24-fbbd-4a9e-9c1d-16fce7eca059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1397126-d294-4f79-9a2b-391d6fdada76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e69bfb37-d24f-4376-8959-42143d4c5065"));

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
                keyValue: new Guid("f638cfec-4c44-4f64-81dc-99571de3e9d8"));

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
                keyValue: new Guid("08c30630-ef18-465b-9514-fc742de98727"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff8504f-e274-4d9f-984b-df155739e516"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12c181d8-a78a-40ad-b0f2-71bf99865b8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17552b6b-d1cc-4523-b973-f5039c1cb106"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23430694-fddc-4e08-98d4-3c52b17dc4fd"));

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
                keyValue: new Guid("357cca07-da0f-4263-9575-9304ba791639"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38a7e503-013b-43bd-8631-356c4b4d747e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2fa608-afb0-4c9c-ae60-bbe2b7762304"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49c5590c-12ed-4ef3-968d-153ef7055136"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0c38c0-7649-47d8-80e8-d7914230a744"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8951f5-036d-4ece-8611-298ba00192c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5973bb6b-46eb-4195-a2ff-d7ca45f0f417"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674dec6d-7fe3-4d85-989e-1079386ec1fe"));

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
                keyValue: new Guid("7672c5c7-0f5a-42d7-a124-2b50b31fbb41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e94f610-cbf6-409f-afd2-d081dd0beff1"));

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
                keyValue: new Guid("8d5ed85e-31b2-46aa-bb85-4539f5110b3e"));

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
                keyValue: new Guid("9b5640af-3fcd-4c74-9638-f56bca829a56"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64bae90-cfa9-4705-8473-77dc2e677f7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeab4c1f-ff32-49ed-99b2-8e2a1589a258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2ba784a-6a97-4e25-a0f9-248ce5251876"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b0d0e3-996b-4b44-9c8c-721ff33eeb19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7465522-4e9a-4c00-b968-5900b3db048c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba3c9243-5390-488e-b598-2779fd398da8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2e1d185-02d7-451b-9899-1a4a83a471a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d713a170-922c-4910-a5a2-d8767340ac4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de28c479-8088-46a6-9bb9-d6bf815c0b1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df02dfa8-fd96-4ad5-914d-ac8b3deed4bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e78a40b9-e3e1-46e7-8eb3-f951033b782c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5efe784-3acb-4b05-a63a-aa1de9fcd6ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabbf12c-a482-47c0-aa3d-502a1ba61819"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("fb38ec3f-bb19-4744-96f9-48a251b574ba"));

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
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("341df24b-16d2-4455-b5a9-c902c78a6543"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("12ed44f0-8d58-475c-890f-ea1c69fb18e2"));

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
