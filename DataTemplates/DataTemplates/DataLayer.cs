using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates
{
    public static class DataLayer
    {
        public static List<Status> GetStatuses()
        {
            return new List<Status>
            {
                new Status { Id = 1, Name = "Bronze" },
                new Status { Id = 2, Name = "Silver" },
                new Status { Id = 3, Name = "Gold" },
            };
        }

        public static List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id=Guid.Parse("946D4FAE-7446-EE7D-467C-5A2A3F1E3BEE"), FirstName="Lois", LastName="Cortez", Phone="989-123-2895", Age=49, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("5A7DB000-24D0-96CD-4F8E-D131158F6FF1"), FirstName="Daria", LastName="Rice", Phone="491-588-5415", Age=20, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("387AF170-1AAA-43DF-24B9-FB074368DA66"), FirstName="Acton", LastName="Keller", Phone="441-273-6974", Age=64, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("EC6C0E45-4A25-6C9E-D6FF-60F20784B585"), FirstName="Galena", LastName="Collier", Phone="666-795-1219", Age=21, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("5E04A1B3-CC0D-5EA4-6DBB-FDF432270530"), FirstName="Nissim", LastName="Mercer", Phone="409-355-2361", Age=63, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("3AA7AA00-086A-310F-027E-59C8DA24A7EC"), FirstName="Edward", LastName="Hayden", Phone="887-622-8408", Age=50, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("0465E6F1-8B97-724E-DEA0-52D969D560B2"), FirstName="Hop", LastName="Carrillo", Phone="283-726-1446", Age=65, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("A9B4E771-5061-5A98-C49F-5C7C5D6B9B05"), FirstName="Lisandra", LastName="Clayton", Phone="354-359-7133", Age=57, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("AA799FEB-9836-5630-8B97-63528AAAD23B"), FirstName="Zenia", LastName="Thomas", Phone="849-907-9904", Age=53, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("26237A61-004E-4F41-0192-D2EA6A1315A1"), FirstName="McKenzie", LastName="Madden", Phone="444-807-8926", Age=32, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("CDC6F950-F08E-816D-740D-2B5B21112D77"), FirstName="Nerea", LastName="Fox", Phone="344-719-6596", Age=21, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("2E81648A-C63B-BC76-64F2-2644EC15848E"), FirstName="Uriel", LastName="Schneider", Phone="542-279-8934", Age=21, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("F9CC616A-34FC-0904-917D-97F7894354EA"), FirstName="Melinda", LastName="Gentry", Phone="562-963-4193", Age=18, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("3217DD9B-3331-9EF9-0309-8124C267804E"), FirstName="Clinton", LastName="Guthrie", Phone="379-291-4430", Age=54, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("460E3F2B-6923-072E-8574-DD8A8AD6775C"), FirstName="Xyla", LastName="Hayden", Phone="777-107-5670", Age=57, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("DF3A1644-007E-488A-D074-0902622D9EE0"), FirstName="Chester", LastName="Patrick", Phone="847-458-2877", Age=61, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("22B8A759-68E3-ED7F-FEEC-B829D2F5AD1B"), FirstName="Chaney", LastName="Kent", Phone="911-959-5245", Age=49, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("970179A1-6BF5-8E0C-E9A0-25F4CFC334FC"), FirstName="Kelly", LastName="Knowles", Phone="709-530-7194", Age=19, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("9F608415-C523-F0E7-A0DD-D87BBEC0AE0D"), FirstName="Justin", LastName="Torres", Phone="300-987-6074", Age=66, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("512CFA9A-0402-6A12-62FE-DFDD7F61ED16"), FirstName="Angelica", LastName="Waters", Phone="414-284-0099", Age=51, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("0A4C749C-6B28-E098-8124-1DBEE1183CA5"), FirstName="Kai", LastName="Booth", Phone="798-685-6137", Age=52, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("46205724-8D6D-56FE-0D7A-407A073CA172"), FirstName="Wanda", LastName="Anderson", Phone="427-440-1076", Age=47, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("C35EC92C-8B6F-3AE6-D638-F02F2784B754"), FirstName="Jasper", LastName="Ellison", Phone="546-531-2894", Age=64, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("169A2F56-A095-5340-5E79-DAD3EEF74781"), FirstName="Dexter", LastName="Fitzgerald", Phone="870-925-3673", Age=59, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("7CA6ECDB-6146-533F-BC02-D9FF0413304A"), FirstName="Kylynn", LastName="Brown", Phone="654-154-5283", Age=36, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("77F611C0-CB30-71B4-B87C-A8511E5913F3"), FirstName="Kaden", LastName="Solis", Phone="973-617-6467", Age=34, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("A98D99B3-A5AB-D522-8D21-6CD13D9D1BC6"), FirstName="Ryan", LastName="Chambers", Phone="511-947-7995", Age=44, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("D597A182-4436-97E3-341A-1B190AAF25C5"), FirstName="Plato", LastName="Spence", Phone="846-557-1191", Age=46, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("31E5D347-84C9-DE81-D9EA-CC7DE8EA95FA"), FirstName="Kasper", LastName="Harmon", Phone="193-201-4787", Age=67, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("E0722C44-3DBF-7FF2-B0F0-F8F537321DD8"), FirstName="Leila", LastName="Sykes", Phone="826-157-5196", Age=46, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("E5599CDE-24F3-B646-641C-7BEA4A84C2D2"), FirstName="Odysseus", LastName="Erickson", Phone="422-429-1368", Age=32, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("B0E199F4-E896-8407-6434-659753B764FB"), FirstName="Patricia", LastName="Burns", Phone="651-720-1289", Age=60, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("D286B84F-4FCF-5120-8AC7-8B8D63170048"), FirstName="Rahim", LastName="Mckenzie", Phone="659-142-6765", Age=57, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("8F216496-ED3C-2CA6-CF10-38760D59F80D"), FirstName="Keefe", LastName="Collins", Phone="974-868-9616", Age=42, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("3B7EC10C-3B65-9E7F-366C-5057B378661F"), FirstName="Dawn", LastName="Wagner", Phone="597-704-9320", Age=28, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("B3F2E20B-D2D2-87E9-BFCE-ECA748199794"), FirstName="Colby", LastName="Huber", Phone="941-375-9723", Age=19, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("CA2E2082-C5B5-21A0-A22C-17DAAF63D0A6"), FirstName="Indira", LastName="Fisher", Phone="327-513-6877", Age=70, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("CFA56210-8C93-36A9-2593-FE85A3C36932"), FirstName="Brynne", LastName="Craig", Phone="640-769-7551", Age=62, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("896F80A5-44E9-1B19-166B-0D72F71B66A1"), FirstName="Octavius", LastName="Cherry", Phone="781-700-1597", Age=33, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("C89D5FDE-A31F-6D1E-6979-E6903E3F8459"), FirstName="Yuri", LastName="Robles", Phone="660-624-2843", Age=48, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("6C5CFDC6-912F-D5BD-839E-C7C076272AA0"), FirstName="Kim", LastName="Vega", Phone="560-405-7158", Age=56, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("B078A634-1751-82CA-DFAD-A5E25441869A"), FirstName="Bert", LastName="Gardner", Phone="456-642-9153", Age=70, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("EBCC6559-751A-4CBA-3B3E-7C321827E948"), FirstName="Kai", LastName="Atkinson", Phone="240-942-1705", Age=44, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("6E221BD0-7461-04F2-D58D-A71B38DD8C70"), FirstName="Ivan", LastName="Cash", Phone="107-303-4072", Age=30, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("31036E2A-441C-5606-D18B-E85A8521D320"), FirstName="Yael", LastName="Mendez", Phone="949-836-0532", Age=42, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("EF1514F0-91FC-3CA6-838F-81D095D0CB4B"), FirstName="Anne", LastName="Anderson", Phone="144-402-9499", Age=36, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("8BF21ACA-E98D-A766-93B0-14061C196804"), FirstName="Magee", LastName="Marsh", Phone="758-835-3421", Age=49, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("19C6949D-22D6-8538-E8A4-2724E3A509C7"), FirstName="Rudyard", LastName="Langley", Phone="513-670-8986", Age=21, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("E6DFCD22-492D-EB52-8190-C1E1A360393D"), FirstName="Zane", LastName="Roman", Phone="779-384-9563", Age=67, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("68794C39-E0C5-FDDD-1293-91894C93C01A"), FirstName="Elliott", LastName="Decker", Phone="107-248-5499", Age=48, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("5DF0B00B-2E14-5864-1DE2-25DA6D16B86E"), FirstName="Michelle", LastName="Randall", Phone="166-303-5116", Age=67, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("231869C4-6E64-CAA8-6C7D-A062E0931D85"), FirstName="Savannah", LastName="Garrison", Phone="456-824-9559", Age=55, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("373FA058-3CB6-91A3-DF64-FD923AD7940A"), FirstName="Galvin", LastName="Farley", Phone="430-838-3982", Age=51, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("157BF478-16A9-71C6-885A-4E37DF870982"), FirstName="Belle", LastName="Rogers", Phone="821-723-3649", Age=28, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("A833A958-74E1-DE63-493C-E12BAD305868"), FirstName="Daniel", LastName="Rosa", Phone="306-833-0480", Age=52, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("D25E0CC0-E4F3-5406-B94D-211AEF04F2B1"), FirstName="Adria", LastName="Kramer", Phone="768-372-1646", Age=25, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("AA43E7C5-0354-7E02-7C13-A733F1677AA7"), FirstName="Lesley", LastName="Norris", Phone="320-488-3379", Age=30, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("B6856054-F27A-A520-3174-636E44DB7611"), FirstName="Kristen", LastName="Love", Phone="634-714-9923", Age=50, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("F15DAB96-464A-9927-8042-18906B99113C"), FirstName="Stuart", LastName="Delaney", Phone="862-901-5972", Age=51, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("4BCAE3BB-B881-6F82-DC14-0828D9BE6474"), FirstName="Xenos", LastName="Elliott", Phone="315-793-7074", Age=26, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("EFD7E77B-AD8E-096F-A2FB-5690F40085DF"), FirstName="Iona", LastName="Kelly", Phone="968-636-3872", Age=22, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("32AF5D88-DDD5-AC78-28EC-FB17F91BF2EF"), FirstName="Paul", LastName="Lynch", Phone="848-897-0224", Age=68, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("F920D1CF-FFEA-4915-2459-FE87CFD5467C"), FirstName="Rajah", LastName="Wise", Phone="778-989-5908", Age=18, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("00E07451-005B-A21C-C545-95B97538E833"), FirstName="Laura", LastName="Hendricks", Phone="557-420-9675", Age=69, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("BA98ABCC-E210-8561-97D6-8D6A71A75706"), FirstName="Maryam", LastName="Dickson", Phone="701-257-9455", Age=37, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("19F20207-1114-BEDA-7797-F3CB8F06337E"), FirstName="Cassady", LastName="Horn", Phone="910-702-1695", Age=47, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("B6A92CE8-488A-0CD8-9BC5-1E38BB28AEC3"), FirstName="Isabella", LastName="Levy", Phone="960-186-2492", Age=24, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("5ABBAA40-6492-C43E-4D46-03A0492E1B2F"), FirstName="Latifah", LastName="Lane", Phone="770-175-1125", Age=56, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("3131598F-1698-02C1-B9BB-8A2885C04AEA"), FirstName="Devin", LastName="Lindsay", Phone="863-434-1619", Age=43, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("1AE6CE39-9205-395D-C5B9-6754D43D29A9"), FirstName="Eugenia", LastName="Holland", Phone="959-675-5610", Age=59, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("F4925DE5-826B-A99E-06C6-D27E9B7BEC2D"), FirstName="Jennifer", LastName="Gibbs", Phone="801-956-1677", Age=51, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("682A6483-365F-4598-2719-A199BA35EE96"), FirstName="Tate", LastName="Salazar", Phone="427-323-9485", Age=19, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("9BCF2154-2DAC-FF81-6D02-36AA798AE5CC"), FirstName="Sandra", LastName="Underwood", Phone="912-237-3129", Age=43, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("327BFC9F-C228-490B-96C6-1FB809910563"), FirstName="Fritz", LastName="Valdez", Phone="338-345-5207", Age=44, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("2B9EA207-7552-364B-BD34-081BA20A156E"), FirstName="Lila", LastName="Mcleod", Phone="589-832-6273", Age=62, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("03510981-AA7D-0D41-A14B-ADEBA62C164F"), FirstName="Iris", LastName="Sweeney", Phone="857-750-4826", Age=63, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("16AD8F97-C174-2859-26E0-A30C95B6E2BE"), FirstName="Karyn", LastName="Durham", Phone="877-900-9947", Age=36, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("68FE95B4-74DB-73D2-8776-35F028B4E328"), FirstName="Kennan", LastName="Juarez", Phone="993-993-8703", Age=59, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("1F101F67-32E0-6518-C326-3B34AB2E9C4A"), FirstName="Jackson", LastName="Lynn", Phone="126-629-0488", Age=56, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("5926F2F0-C429-27CE-9C96-616A2F7DED98"), FirstName="Kyle", LastName="Mercer", Phone="103-390-1876", Age=19, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("6B917072-EDF5-BB3D-789D-F93580AC2AC0"), FirstName="Jason", LastName="Travis", Phone="364-459-1681", Age=33, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("A57D9785-4465-6FDB-EE2A-F0E68D6D4CD4"), FirstName="Amena", LastName="Merritt", Phone="328-573-9321", Age=68, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("FE028098-C6D8-FA61-EFC9-F0E49E9E3D24"), FirstName="Leila", LastName="Mendez", Phone="631-413-9715", Age=40, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("FE0D8BEA-49B0-83AD-0F7F-7822D062BE76"), FirstName="Kimberley", LastName="Becker", Phone="692-363-4053", Age=25, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("06C7C340-E7A7-D286-507C-901F4CEF9DED"), FirstName="Ima", LastName="Huber", Phone="990-997-0398", Age=64, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("74D14BAE-A473-BA8F-DB50-6E4E677EF43D"), FirstName="Joseph", LastName="Rodgers", Phone="739-144-3385", Age=42, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("93EC9ABF-984D-68EC-751C-B68C21E7FF96"), FirstName="Leilani", LastName="Workman", Phone="717-236-6913", Age=33, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("C6EDA5AE-A3FF-5A79-67D4-C2B6D42F848B"), FirstName="Thomas", LastName="Sanders", Phone="170-853-1416", Age=39, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("862E1CC4-648E-B2E2-BE47-1F2A00A52064"), FirstName="Elvis", LastName="Mason", Phone="970-466-4239", Age=28, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("FCC7EFD3-2C45-C5CC-6E5C-2F49D7716F95"), FirstName="Kasimir", LastName="Ramirez", Phone="659-501-6054", Age=49, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("6A24580F-7C17-96DE-F3D8-8F03655CA0F0"), FirstName="Kevin", LastName="Petty", Phone="623-230-8870", Age=41, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("67AB6392-4BE0-6AEA-BB54-0A7CB92A7D83"), FirstName="Reuben", LastName="Gonzales", Phone="168-816-1815", Age=38, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("9035CE27-A4CB-1B8A-2C38-E961034CCC38"), FirstName="Hasad", LastName="Lee", Phone="214-594-7103", Age=49, IsActive=false, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("C85F234F-1650-83F6-E112-C64EFA26D71F"), FirstName="Allegra", LastName="Riggs", Phone="422-913-6322", Age=39, IsActive=true, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("52E28680-539F-47D0-206E-D74EEF00B77F"), FirstName="Kenneth", LastName="Webster", Phone="900-872-5277", Age=31, IsActive=true, StatusId=3, Status="Bronze"},
                new Customer { Id=Guid.Parse("1DD5ACB3-3C4E-9DAC-1EAC-2B0176B71186"), FirstName="Austin", LastName="Rutledge", Phone="201-736-0627", Age=57, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("B84A31AB-0A9B-5A2A-E065-C8F9DCA32096"), FirstName="Debra", LastName="Dudley", Phone="287-273-0586", Age=61, IsActive=false, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("5B33E1A3-CD12-03B4-4791-3154DBB5AD68"), FirstName="Naida", LastName="West", Phone="738-838-0518", Age=33, IsActive=true, StatusId=1, Status="Silver"},
                new Customer { Id=Guid.Parse("66F47383-11A1-0053-6351-90F1A975A539"), FirstName="Valentine", LastName="Greer", Phone="556-456-1125", Age=34, IsActive=false, StatusId=2, Status="Gold"},
                new Customer { Id=Guid.Parse("F02945BF-77E8-A1CA-3472-9E9386C04D0C"), FirstName="Giacomo", LastName="Mcguire", Phone="144-263-1941", Age=62, IsActive=true, StatusId=2, Status="Gold"}

        };
        }
    }
}
