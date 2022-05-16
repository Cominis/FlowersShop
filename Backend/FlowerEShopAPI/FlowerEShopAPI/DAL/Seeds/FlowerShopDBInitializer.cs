using FlowerEShopAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using static FlowerEShopAPI.DAL.Entities.Product;

namespace FlowerEShopAPI.DAL.Seeds
{
    public static class FlowerShopDBInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var userIds = new string[]{"f70f7a45-8539-4082-a181-9705c2b5c505",
                                        "d74cfad8-b077-44f7-b29b-d8fa88164cfd",
                                        "c3940bfc-2107-4713-b8b6-a332cf0eb318",
                                        "e5053ea0-23d0-4319-a56f-16a719e7a5bf",
                                        "6c8019dc-0237-484d-80dc-452428bce548",
                                        "bf2adec3-895b-4cc1-b5b5-a408255fce2b",
                                        "df749524-0c6b-416d-94c2-398f8b62e92d",
                                        "341df24b-16d2-4455-b5a9-c902c78a6543",
                                        "669eeb98-5fa4-45a5-bfa0-24554a7945ec",
                                        "12ed44f0-8d58-475c-890f-ea1c69fb18e2"
            };

            List<User> users = new List<User>();

            foreach (string id in userIds)
            {
                users.Add(new User
                {
                    Id = new Guid(id),
                    Name = LoremNET.Lorem.Words(2),
                    Email = LoremNET.Lorem.Email(),
                    Surname = LoremNET.Lorem.Words(1),
                    UserName = LoremNET.Lorem.Words(1),
                    Password = LoremNET.Lorem.Words(1)
                });
            }

            modelBuilder.Entity<User>().HasData(users);

            //**********************************************************************************************************************

            var shopIds = new string[]{"232d3f3d-c138-4f4b-a682-c28928c0593b",
                                       "4340854d-95d2-4156-9b53-4af221fbc7ab",
                                       "36371838-e3fe-43f7-8e14-10d372ed4d2f",
                                       "97d490c6-a39f-40ea-a42b-041e256470b0",
                                       "ebe00220-011d-43ed-9869-c852ea8ed3dc",
                                       "040f82fb-9fdb-4ba9-adad-a260b2656c3d",
                                       "1e6fb1e8-b881-4e27-a6ae-0fc90aa91ee7",
                                       "fb38ec3f-bb19-4744-96f9-48a251b574ba",
                                       "158ad77c-5b60-4656-ac54-b4208d4df31d",
                                       "585ef689-630d-4dc9-99b1-7b78d6c5f324"
            };

            List<Shop> shops = new List<Shop>();
            var shopIdx = 0;

            foreach (string id in shopIds)
            {
                shops.Add(new Shop
                {
                    Id = new Guid(id),
                    Name = LoremNET.Lorem.Words(2),
                    Description = LoremNET.Lorem.Paragraph(10, 5),
                    Location = LoremNET.Lorem.Sentence(1),
                    UserId = new Guid(userIds[shopIdx]),
                });
                shopIdx++;
            }

            modelBuilder.Entity<Shop>().HasData(shops);

            //**********************************************************************************************************************

            var productIds = new string[]{"a4d10547-52c0-405f-88c3-9b3d1c51e043",
                                          "674dec6d-7fe3-4d85-989e-1079386ec1fe",
                                          "00a894bf-a9c6-4930-9928-8b958f0e70ea",
                                          "d713a170-922c-4910-a5a2-d8767340ac4a",
                                          "67f51578-3b2d-47af-888c-fa2122dfeaf1",
                                          "b2ba784a-6a97-4e25-a0f9-248ce5251876",
                                          "08c30630-ef18-465b-9514-fc742de98727",
                                          "94053d32-4e55-4c9d-bf0e-d533c0c2f7f7",
                                          "e69bfb37-d24f-4376-8959-42143d4c5065",
                                          "6d7f7be7-1d23-478e-8aca-581c78e961ed",
                                          "4f8951f5-036d-4ece-8611-298ba00192c0",
                                          "aeab4c1f-ff32-49ed-99b2-8e2a1589a258",
                                          "b2580f32-8d33-4ef6-a843-49fa87da6a7e",
                                          "fd321667-43d3-4a3f-beea-66f62c826f62",
                                          "17552b6b-d1cc-4523-b973-f5039c1cb106",
                                          "4158bf42-0721-4e06-9ebd-ddf682240f7a",
                                          "fabbf12c-a482-47c0-aa3d-502a1ba61819",
                                          "f4f19d67-4312-431c-a3f9-1a76d5306820",
                                          "df02dfa8-fd96-4ad5-914d-ac8b3deed4bf",
                                          "382dc6cf-617d-4974-aa9b-3d166feeebff",
                                          "c05ecf17-278d-4da4-b89f-ed53e0fa3c58",
                                          "813727fb-f1f2-49fd-8c4e-1c6c7018f82d",
                                          "7bdce160-945a-4b8d-84c9-f3375a1814f8",
                                          "4f0c38c0-7649-47d8-80e8-d7914230a744",
                                          "7672c5c7-0f5a-42d7-a124-2b50b31fbb41",
                                          "b7465522-4e9a-4c00-b968-5900b3db048c",
                                          "8cf1e86a-ae98-4087-b230-4ed19e072c90",
                                          "352a6160-e3b6-46eb-be08-e7702c3f111d",
                                          "68562155-6ccf-4062-b8ae-277761e3f02d",
                                          "50ebb3ee-ec7f-457e-af35-91e698569a9d",
                                          "e78a40b9-e3e1-46e7-8eb3-f951033b782c",
                                          "d6fa0e2e-0afd-4968-ae10-78b17c9b8fb7",
                                          "69009dde-2586-4cb1-a78d-560cbe078c68",
                                          "49c5590c-12ed-4ef3-968d-153ef7055136",
                                          "2923f717-c7fb-4f1e-b74f-9eaaeff98672",
                                          "21420154-8f18-4fb3-b745-60621cca5541",
                                          "357cca07-da0f-4263-9575-9304ba791639",
                                          "e1397126-d294-4f79-9a2b-391d6fdada76",
                                          "962d2024-995d-4165-89c9-55e15d2176e3",
                                          "67347a37-faa5-4e00-83d1-da4019d814e1",
                                          "a2431d50-d56a-44d6-9f98-cef4cffc1d25",
                                          "3f2fa608-afb0-4c9c-ae60-bbe2b7762304",
                                          "2c9dffd8-ba31-4fa2-a8b4-69df5eb1e981",
                                          "88896fd9-3470-4c4c-ba9b-2fd1899b910a",
                                          "322fa14d-15a4-4b54-8d5d-7c0ba422ae17",
                                          "12c181d8-a78a-40ad-b0f2-71bf99865b8a",
                                          "31a0cf5d-3c9a-4c3b-b348-68eb4299f6f2",
                                          "ba3c9243-5390-488e-b598-2779fd398da8",
                                          "a64bae90-cfa9-4705-8473-77dc2e677f7b",
                                          "77bca806-729f-48b3-aa6c-03da08cbc266",
                                          "5973bb6b-46eb-4195-a2ff-d7ca45f0f417",
                                          "4a33ee82-a5de-4f44-972e-c54edb321299",
                                          "91863f6f-4179-4d5d-9eea-c4e5be4a3059",
                                          "d0dc2435-2fe7-49a3-9d31-ac57636b7061",
                                          "095212ae-d9c1-4d27-b6a0-db9421c0651d",
                                          "23430694-fddc-4e08-98d4-3c52b17dc4fd",
                                          "de28c479-8088-46a6-9bb9-d6bf815c0b1e",
                                          "38a7e503-013b-43bd-8631-356c4b4d747e",
                                          "6c48d5d0-ad7e-4678-8e72-6e2878e8e431",
                                          "f638cfec-4c44-4f64-81dc-99571de3e9d8",
                                          "53c7a9de-03b5-4482-8163-2d925ca7f3c5",
                                          "0c565494-047e-49f7-bcd4-16981f33a32b",
                                          "bda9c7da-7497-40d4-886e-e7bbe1f5c7bf",
                                          "5f60fd31-6e4a-4e08-ad83-f0e90680a00a",
                                          "3421e1b7-8a77-48c5-ad11-912e3c0a5e5c",
                                          "d2e1d185-02d7-451b-9899-1a4a83a471a7",
                                          "18c3aee2-141e-470b-87e3-cd3320eb073a",
                                          "b5b0d0e3-996b-4b44-9c8c-721ff33eeb19",
                                          "dfc14f24-fbbd-4a9e-9c1d-16fce7eca059",
                                          "adaa5968-bab8-433d-abc6-217d49fa3395",
                                          "543372da-be2f-4ef6-8496-98a8a075799c",
                                          "a0da6667-3488-411a-aa3c-f7c6636a2a65",
                                          "3fb47659-d12f-4d78-aa5e-da6eb65ceb79",
                                          "9873295b-5f32-4aa8-a1cc-8b411d16cbb9",
                                          "4d1056de-68cd-4ec4-9894-09a8eb1b008d",
                                          "aedd63d0-11e5-48e1-bf68-02bb9745c0e2",
                                          "4662d12e-51f3-47f7-af9b-4929fd9212ba",
                                          "036526be-993c-4d69-ba77-42f606d587cb",
                                          "74b10291-cdcc-42fd-8595-59db3aab19ba",
                                          "06b8beef-8b34-41f7-97e3-b6f2f968a635",
                                          "7e94f610-cbf6-409f-afd2-d081dd0beff1",
                                          "d2d818d2-5043-4dc9-a0c9-5cc21023fcbe",
                                          "f2457ca0-52c9-49c6-b072-1f9b4cb5b7d7",
                                          "485e8c77-c563-46f4-89f7-2af34dd677a9",
                                          "9b5640af-3fcd-4c74-9638-f56bca829a56",
                                          "53553cf5-e117-48da-9b60-9a6fa5555183",
                                          "8d5ed85e-31b2-46aa-bb85-4539f5110b3e",
                                          "ca66e36f-e1b2-4e22-9ad8-0627719b1cb0",
                                          "dcfa04b0-16a5-46dc-8330-f079042ce625",
                                          "37309a47-24d9-47d2-af34-7ed863b78e2b",
                                          "0ff8504f-e274-4d9f-984b-df155739e516",
                                          "f5efe784-3acb-4b05-a63a-aa1de9fcd6ae",
                                          "836bf6f7-71a6-485d-8514-455393908657",
                                          "a4f61a6f-1102-4819-a69e-63bc9600ffb3",
                                          "0d840aa1-19af-44b6-b74e-b36df4f8f53d",
                                          "883b612a-0eaf-43bf-8d9b-e69a018a7140",
                                          "15dc89e1-80ef-4083-9beb-86c83c3eee74",
                                          "ba09d33b-4a76-463e-ab62-2d789a476acb",
                                          "9afb1d8d-3f4e-4c03-8bd1-0630298f2362",
                                          "a6691809-aee3-46ac-8313-a2eedb8409cd"
            };

            List<Product> products = new List<Product>();
            var productIdx = 0;

            foreach (string shopId in shopIds)
            {
                for (int i = 0; i < 10; i++)
                {
                    products.Add(new Product
                    {
                        Id = new Guid(productIds[productIdx]),
                        Title = LoremNET.Lorem.Sentence(1),
                        Description = LoremNET.Lorem.Paragraph(10, 5),
                        Category = LoremNET.Lorem.Words(1),
                        SubCategory = LoremNET.Lorem.Words(1),
                        Status = LoremNET.Lorem.Enum<StatusEnum>(),
                        Price = (decimal)Convert.ToDouble(LoremNET.Lorem.Integer(0, 100)),
                        Quantity = LoremNET.Lorem.Integer(0, 100),
                        ShopId = new Guid(shopId)
                    });
                    productIdx++;
                }
            }

            modelBuilder.Entity<Product>().HasData(products);

            //**********************************************************************************************************************

            var shoppingCartIds = new string[] {"52b62791-a93f-492e-bf2d-dacf15084c91",
                                                "19df2e7d-b6b1-4279-865c-c3cb6eef469c",
                                                "3f895757-60c2-47b5-b970-8a7b6d2f21bf",
                                                "e304a5d2-a1a5-4e5a-b39e-2b833bcde4e9",
                                                "7f65eba2-8e80-4619-aacc-d5b2fdbe37cf",
                                                "3efab290-b8a5-4786-a245-82b1cedcaaa9",
                                                "05935a3f-9210-4e21-ab3f-7a08662f0960",
                                                "74faf6c6-2d55-4423-9816-49f2c0e84a02",
                                                "0b25a43d-8674-48bb-bb37-33c5868cc6bf",
                                                "27f9f8c7-445a-4c15-8f9a-c210e9d0498d",
                                                "a7b1da80-5a54-4d50-a0a0-13360bb50b63",
                                                "812663ee-abb0-4ffa-b869-dfd39087bfb6",
                                                "cbf6d242-6f27-4c36-bd3d-075b6c041229",
                                                "f0652b4f-a6cb-482e-9183-a331198dac04",
                                                "ce8e41b9-03ba-430d-94f5-486658c7fdc8",
                                                "0ce1f781-ba3b-4353-9d2d-ea4fc3bff138",
                                                "c2ab942e-060c-43a0-af48-73d80b94cb03",
                                                "846a7c4f-b232-4a0f-a4b4-e3dc3c36fd4a",
                                                "6364170f-fe82-47eb-95f5-860fe13c01d8",
                                                "f9d55e34-a009-403d-a97b-e9ea438b37d7",
                                                "16d834c4-899e-4385-a5c5-7ee20a866156",
                                                "85bde701-fb9d-4046-9a3e-9b9935657855",
                                                "41a465a9-a9ee-4074-9e8f-eaa9bf9b162b",
                                                "e03e356a-90ec-411d-94f2-64a96123c72f",
                                                "1c712568-3924-496e-bd2b-e90e273bdf77",
                                                "a96f73c9-1a70-4355-bd13-ee8cd0b2ae98",
                                                "f86e9a91-7df3-4fcb-9e35-83d33840b92e",
                                                "8288865c-9838-46ca-aabc-a09e26628e49",
                                                "65a5c17e-1da1-479d-99b1-85b25ac6d7f8",
                                                "20de9a89-a7af-457c-a77d-5525f7967e71",
                                                "f3f84eba-6811-4212-b5a0-a2cd63065214",
                                                "fc14503a-a7d9-4872-8e04-97c51e8841dc",
                                                "6bf27763-d7fc-4893-96e2-d844a2356432",
                                                "29326627-aeb0-4ef2-8df3-50afa9958b6b",
                                                "52741742-e69e-4e6f-aadd-2c7c2a1bdce5",
                                                "22c529e3-c0cf-4dea-b975-81f33f1344b2",
                                                "541d3c16-c3cf-424a-81ed-1e78e871834c",
                                                "29f51c20-f78d-44ff-b1ca-7a2dfd530c37",
                                                "b8c76a8e-bb51-4398-ace7-b52fde7de3e5",
                                                "4281874c-0163-4a72-b7dc-bd5c2ae99d9c",
                                                "c3874b20-25ff-4ce1-a9de-5330f8bdf89b",
                                                "13c5e19c-8fec-46c6-a5b0-bd9a071727e6",
                                                "167b01aa-f3a2-4e92-98f8-15285397c324",
                                                "057912aa-1fee-42ef-ac7a-1fc00873f500",
                                                "91892802-c837-47a1-8f34-64cf30a26d8d",
                                                "5ddcc969-219c-4a7b-9f81-cee0fb595a94",
                                                "71e1abf5-dba4-4a14-96a7-26ab5ff08ae3",
                                                "6036aa7e-32f4-462a-9daf-d36a60d29f96",
                                                "a680a97b-eea7-417b-a3f2-6d2eaf01bec4",
                                                "926e452a-8a75-4aec-ba93-6fe3b8312d9b"
            };

            List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();

            foreach (string id in shoppingCartIds)
            {

                shoppingCarts.Add(new ShoppingCart
                {
                    Id = new Guid(id),
                    ProductId = new Guid(LoremNET.Lorem.Random(productIds)),
                    UserId = new Guid(LoremNET.Lorem.Random(userIds)),
                    Quantity = LoremNET.Lorem.Integer(1, 10),
                });

            }

            modelBuilder.Entity<ShoppingCart>().HasData(shoppingCarts);
        }
    }
}
