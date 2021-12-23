using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.UpcastingDowncasting
{
    public static class Helper
    {
        public static List<Person> GetMockPersons()
        {
            var persons = new List<Person>();

            persons.Add(new Person()
            {
                FullName = "Jonathan Simon",
                FirstName = "Jonathan",
                LastName = "Simon",
                DateOfBirth = new DateTime(1930, 1, 13),
                RegistrationNumber = "4173194929658",
                Contact = new Contact()
                {
                    Street = "864 Niwim Path",
                    PostalCode = "05811",
                    City = "Vipopu",
                    PhoneNumber = "(287) 787-1827",
                    Mobile = "(535) 867-7660",
                    Email = "dubzo@ru.tt"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Edith Rowe",
                FirstName = "Edith",
                LastName = "Rowe",
                DateOfBirth = new DateTime(1940, 3, 8),
                RegistrationNumber = "5918153530189",
                Contact = new Contact()
                {
                    Street = "1824 Ebneg Glen",
                    PostalCode = "08332",
                    City = "Otubaimu",
                    PhoneNumber = "(286) 955-5993",
                    Mobile = "(345) 537-6757",
                    Email = "pus@wugazel.bn"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Matilda Kelley",
                FirstName = "Matilda",
                LastName = "Kelley",
                DateOfBirth = new DateTime(1933, 7, 14),
                RegistrationNumber = "6454015481397",
                Contact = new Contact()
                {
                    Street = "1580 Virihi Mill",
                    PostalCode = "23175",
                    City = "Kezugor",
                    PhoneNumber = "(263) 673-8836",
                    Mobile = "(330) 582-9804",
                    Email = "fimiji@vurukvaz.br"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Edwin Phelps",
                FirstName = "Edwin",
                LastName = "Phelps",
                DateOfBirth = new DateTime(1935, 11, 11),
                RegistrationNumber = "4705005510158",
                Contact = new Contact()
                {
                    Street = "262 Veev Drive",
                    PostalCode = "37822",
                    City = "Asvetdup",
                    PhoneNumber = "(453) 716-6527",
                    Mobile = "(708) 522-2284",
                    Email = "bene@awe.so"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Russell King",
                FirstName = "Russell",
                LastName = "King",
                DateOfBirth = new DateTime(1932, 9, 2),
                RegistrationNumber = "1984941321367",
                Contact = new Contact()
                {
                    Street = "1695 Gioce Place",
                    PostalCode = "22426",
                    City = "Ruseci",
                    PhoneNumber = "(425) 559-6995",
                    Mobile = "(985) 900-8096",
                    Email = "jiruet@pafawho.az"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Jackson Fields",
                FirstName = "Jackson",
                LastName = "Fields",
                DateOfBirth = new DateTime(1963, 4, 6),
                RegistrationNumber = "9591314469961",
                Contact = new Contact()
                {
                    Street = "1035 Uhweh Mill",
                    PostalCode = "73683",
                    City = "Tajudag",
                    PhoneNumber = "(546) 868-1995",
                    Mobile = "(624) 620-2785",
                    Email = "rojciztah@nafmajib.nr"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Maud Smith",
                FirstName = "Maud",
                LastName = "Smith",
                DateOfBirth = new DateTime(1952, 5, 14),
                RegistrationNumber = "8055937610960",
                Contact = new Contact()
                {
                    Street = "1648 Woizu Lane",
                    PostalCode = "48911",
                    City = "Dahcahec",
                    PhoneNumber = "(554) 762-5934",
                    Mobile = "(901) 801-5844",
                    Email = "bugeppor@neifi.so"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Lina Lloyd",
                FirstName = "Lina",
                LastName = "Lloyd",
                DateOfBirth = new DateTime(1936, 11, 26),
                RegistrationNumber = "7641830717938",
                Contact = new Contact()
                {
                    Street = "1296 Ihawe Park",
                    PostalCode = "57832",
                    City = "Jepzauk",
                    PhoneNumber = "(342) 927-1449",
                    Mobile = "(274) 260-1599",
                    Email = "jon@niceg.gs"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Beulah Burgess",
                FirstName = "Beulah",
                LastName = "Burgess",
                DateOfBirth = new DateTime(1969, 10, 1),
                RegistrationNumber = "2983650578723",
                Contact = new Contact()
                {
                    Street = "259 Lire Lane",
                    PostalCode = "03891",
                    City = "Sozapma",
                    PhoneNumber = "(860) 260-3406",
                    Mobile = "(974) 594-4449",
                    Email = "eha@aj.md"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Warren Park",
                FirstName = "Warren",
                LastName = "Park",
                DateOfBirth = new DateTime(1943, 6, 18),
                RegistrationNumber = "5760038506745",
                Contact = new Contact()
                {
                    Street = "1756 Covsof Park",
                    PostalCode = "26024",
                    City = "Heirci",
                    PhoneNumber = "(684) 868-3003",
                    Mobile = "(569) 949-6585",
                    Email = "vula@be.pe"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Travis Kelly",
                FirstName = "Travis",
                LastName = "Kelly",
                DateOfBirth = new DateTime(1954, 5, 9),
                RegistrationNumber = "6072303971859",
                Contact = new Contact()
                {
                    Street = "789 Woon Glen",
                    PostalCode = "29650",
                    City = "Icnorve",
                    PhoneNumber = "(540) 999-7608",
                    Mobile = "(603) 386-3934",
                    Email = "tunetoj@ezemiev.ax"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Florence Steele",
                FirstName = "Florence",
                LastName = "Steele",
                DateOfBirth = new DateTime(1970, 9, 17),
                RegistrationNumber = "8398764024069",
                Contact = new Contact()
                {
                    Street = "508 Badcun Place",
                    PostalCode = "16072",
                    City = "Vosumi",
                    PhoneNumber = "(588) 599-1452",
                    Mobile = "(301) 903-1858",
                    Email = "lu@vujovi.in"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Lulu Cortez",
                FirstName = "Lulu",
                LastName = "Cortez",
                DateOfBirth = new DateTime(1949, 10, 11),
                RegistrationNumber = "2155386994601",
                Contact = new Contact()
                {
                    Street = "1067 Kuve Turnpike",
                    PostalCode = "76782",
                    City = "Ezarasuf",
                    PhoneNumber = "(867) 282-6758",
                    Mobile = "(746) 269-1854",
                    Email = "nuj@dasoru.lu"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Addie Casey",
                FirstName = "Addie",
                LastName = "Casey",
                DateOfBirth = new DateTime(1980, 4, 9),
                RegistrationNumber = "1661602608465",
                Contact = new Contact()
                {
                    Street = "713 Veri Grove",
                    PostalCode = "29878",
                    City = "Vofumelo",
                    PhoneNumber = "(820) 488-1049",
                    Mobile = "(400) 736-9385",
                    Email = "ecfed@mok.md"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Rebecca Reynolds",
                FirstName = "Rebecca",
                LastName = "Reynolds",
                DateOfBirth = new DateTime(1945, 5, 10),
                RegistrationNumber = "5798480548355",
                Contact = new Contact()
                {
                    Street = "782 Onfus Terrace",
                    PostalCode = "55623",
                    City = "Wijezel",
                    PhoneNumber = "(812) 487-6552",
                    Mobile = "(442) 387-4795",
                    Email = "ejwimcas@wuofetup.si"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Lettie Cook",
                FirstName = "Lettie",
                LastName = "Cook",
                DateOfBirth = new DateTime(1993, 10, 3),
                RegistrationNumber = "5232762821503",
                Contact = new Contact()
                {
                    Street = "846 Pirni Trail",
                    PostalCode = "32522",
                    City = "Jamtijas",
                    PhoneNumber = "(481) 599-1230",
                    Mobile = "(743) 654-6843",
                    Email = "uhnuf@ecvib.mh"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Frank Owen",
                FirstName = "Frank",
                LastName = "Owen",
                DateOfBirth = new DateTime(1979, 11, 1),
                RegistrationNumber = "0113812453127",
                Contact = new Contact()
                {
                    Street = "295 Wudo Square",
                    PostalCode = "48844",
                    City = "Gifivce",
                    PhoneNumber = "(542) 651-1603",
                    Mobile = "(874) 700-7910",
                    Email = "use@bac.jm"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Victor Poole",
                FirstName = "Victor",
                LastName = "Poole",
                DateOfBirth = new DateTime(1994, 11, 19),
                RegistrationNumber = "1453435748715",
                Contact = new Contact()
                {
                    Street = "544 Zuki Point",
                    PostalCode = "57377",
                    City = "Nifahevov",
                    PhoneNumber = "(510) 783-5342",
                    Mobile = "(660) 978-8457",
                    Email = "dikduar@acahome.pm"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Clara Herrera",
                FirstName = "Clara",
                LastName = "Herrera",
                DateOfBirth = new DateTime(1965, 11, 4),
                RegistrationNumber = "6767764812373",
                Contact = new Contact()
                {
                    Street = "1764 Gilet Loop",
                    PostalCode = "94628",
                    City = "Vepsawe",
                    PhoneNumber = "(566) 639-8899",
                    Mobile = "(200) 637-1651",
                    Email = "ugim@ku.ae"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Phoebe Burke",
                FirstName = "Phoebe",
                LastName = "Burke",
                DateOfBirth = new DateTime(1964, 4, 4),
                RegistrationNumber = "0928472090516",
                Contact = new Contact()
                {
                    Street = "734 Juma Trail",
                    PostalCode = "51506",
                    City = "Revahmi",
                    PhoneNumber = "(746) 296-7046",
                    Mobile = "(533) 814-9899",
                    Email = "muj@imamos.nz"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Carolyn West",
                FirstName = "Carolyn",
                LastName = "West",
                DateOfBirth = new DateTime(1993, 5, 5),
                RegistrationNumber = "0215301211074",
                Contact = new Contact()
                {
                    Street = "1163 Tepza View",
                    PostalCode = "41918",
                    City = "Ikgetro",
                    PhoneNumber = "(932) 769-8869",
                    Mobile = "(671) 545-8199",
                    Email = "hed@bu.by"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Lola Holmes",
                FirstName = "Lola",
                LastName = "Holmes",
                DateOfBirth = new DateTime(1960, 2, 24),
                RegistrationNumber = "4704808836124",
                Contact = new Contact()
                {
                    Street = "312 Ursi Heights",
                    PostalCode = "77303",
                    City = "Picewos",
                    PhoneNumber = "(553) 320-7060",
                    Mobile = "(336) 281-8220",
                    Email = "jen@mesropi.in"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Mabelle Santiago",
                FirstName = "Mabelle",
                LastName = "Santiago",
                DateOfBirth = new DateTime(1946, 8, 21),
                RegistrationNumber = "4997661800174",
                Contact = new Contact()
                {
                    Street = "534 Ojnig Manor",
                    PostalCode = "06445",
                    City = "Nofeju",
                    PhoneNumber = "(211) 680-4687",
                    Mobile = "(714) 664-7021",
                    Email = "nub@sikudro.hn"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Abbie Diaz",
                FirstName = "Abbie",
                LastName = "Diaz",
                DateOfBirth = new DateTime(1994, 12, 10),
                RegistrationNumber = "2181449123878",
                Contact = new Contact()
                {
                    Street = "1685 Wasruc Square",
                    PostalCode = "97335",
                    City = "Pecejaow",
                    PhoneNumber = "(302) 410-7211",
                    Mobile = "(289) 232-9485",
                    Email = "zanroubu@ma.fr"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Mable Sullivan",
                FirstName = "Mable",
                LastName = "Sullivan",
                DateOfBirth = new DateTime(1958, 1, 1),
                RegistrationNumber = "1792219356213",
                Contact = new Contact()
                {
                    Street = "432 Jelu Grove",
                    PostalCode = "06439",
                    City = "Gulokro",
                    PhoneNumber = "(858) 660-7859",
                    Mobile = "(719) 592-2706",
                    Email = "zemdo@kipod.kr"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Dustin Kelley",
                FirstName = "Dustin",
                LastName = "Kelley",
                DateOfBirth = new DateTime(1939, 9, 8),
                RegistrationNumber = "8281662388102",
                Contact = new Contact()
                {
                    Street = "220 Ejedoc Park",
                    PostalCode = "79898",
                    City = "Pulodmum",
                    PhoneNumber = "(807) 814-2433",
                    Mobile = "(822) 352-8545",
                    Email = "ko@paogice.mo"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Gordon Fuller",
                FirstName = "Gordon",
                LastName = "Fuller",
                DateOfBirth = new DateTime(1948, 11, 9),
                RegistrationNumber = "3508958908431",
                Contact = new Contact()
                {
                    Street = "1432 Ataren Grove",
                    PostalCode = "93589",
                    City = "Amnewfe",
                    PhoneNumber = "(912) 274-6197",
                    Mobile = "(560) 729-2357",
                    Email = "dufri@patwaz.mp"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Cole Doyle",
                FirstName = "Cole",
                LastName = "Doyle",
                DateOfBirth = new DateTime(1961, 9, 20),
                RegistrationNumber = "3495278886154",
                Contact = new Contact()
                {
                    Street = "312 Zucjot Pike",
                    PostalCode = "55387",
                    City = "Mewvozwem",
                    PhoneNumber = "(304) 334-8474",
                    Mobile = "(744) 206-7679",
                    Email = "rifiur@muwbo.er"
                }
            });

            persons.Add(new Person()
            {
                FullName = "Richard Marsh",
                FirstName = "Richard",
                LastName = "Marsh",
                DateOfBirth = new DateTime(1986, 1, 3),
                RegistrationNumber = "4779489024271",
                Contact = new Contact()
                {
                    Street = "1871 Hatwe Manor",
                    PostalCode = "44859",
                    City = "Mepzaeki",
                    PhoneNumber = "(602) 872-7512",
                    Mobile = "(207) 755-3854",
                    Email = "hefaj@tararato.gu"
                }
            });

            return persons;

        }


        public static List<Company> GetMockCompanies()
        {
            var companies = new List<Company>();

            companies.Add(new Company()
            {
                FullName = "Ewiwaswe Company",
                RegistrationNumber = "32630555",
                TaxId = "857904481",
                NumberOfEmployees = 266,
                Contact = new Contact()
                {
                    Street = "1270 Gehmor Drive",
                    PostalCode = "23010",
                    City = "Kozwehib",
                    PhoneNumber = "(473) 417-2455",
                    Mobile = "(626) 308-6912",
                    Email = "atiwes@nit.ie"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Ucitawab Company",
                RegistrationNumber = "76609288",
                TaxId = "064451118",
                NumberOfEmployees = 105,
                Contact = new Contact()
                {
                    Street = "472 Udosuc Trail",
                    PostalCode = "25350",
                    City = "Ojodaho",
                    PhoneNumber = "(433) 246-1789",
                    Mobile = "(320) 240-1737",
                    Email = "ce@latoc.er"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Comiza Company",
                RegistrationNumber = "81170829",
                TaxId = "774972316",
                NumberOfEmployees = 207,
                Contact = new Contact()
                {
                    Street = "1063 Nuna Boulevard",
                    PostalCode = "88569",
                    City = "Cemimhid",
                    PhoneNumber = "(476) 664-7827",
                    Mobile = "(825) 925-9343",
                    Email = "fahrora@ahahazaj.mk"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Kecaki Company",
                RegistrationNumber = "40982694",
                TaxId = "095451089",
                NumberOfEmployees = 59,
                Contact = new Contact()
                {
                    Street = "1491 Lawez Point",
                    PostalCode = "75907",
                    City = "Zugviizi",
                    PhoneNumber = "(438) 861-3156",
                    Mobile = "(943) 316-8421",
                    Email = "rittu@moke.ae"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Ommeevi Company",
                RegistrationNumber = "97234312",
                TaxId = "121522033",
                NumberOfEmployees = 175,
                Contact = new Contact()
                {
                    Street = "218 Ipoak Lane",
                    PostalCode = "22139",
                    City = "Lajemma",
                    PhoneNumber = "(586) 472-2767",
                    Mobile = "(202) 549-7175",
                    Email = "bijjaw@dukfamca.pe"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Orikodon Company",
                RegistrationNumber = "32747739",
                TaxId = "305453203",
                NumberOfEmployees = 253,
                Contact = new Contact()
                {
                    Street = "466 Sotuz Square",
                    PostalCode = "23613",
                    City = "Igodimoku",
                    PhoneNumber = "(349) 354-3576",
                    Mobile = "(914) 285-6105",
                    Email = "buzce@zehenum.cu"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Pedopa Company",
                RegistrationNumber = "46379371",
                TaxId = "002093221",
                NumberOfEmployees = 222,
                Contact = new Contact()
                {
                    Street = "1369 Buahe Grove",
                    PostalCode = "94292",
                    City = "Gucheude",
                    PhoneNumber = "(786) 720-6350",
                    Mobile = "(474) 517-1249",
                    Email = "hidagciw@reze.th"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Zosmives Company",
                RegistrationNumber = "65124269",
                TaxId = "272451921",
                NumberOfEmployees = 266,
                Contact = new Contact()
                {
                    Street = "352 Mubli Drive",
                    PostalCode = "88082",
                    City = "Dujauf",
                    PhoneNumber = "(776) 602-4369",
                    Mobile = "(311) 453-8633",
                    Email = "cod@ito.ly"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Cajono Company",
                RegistrationNumber = "02377182",
                TaxId = "893350034",
                NumberOfEmployees = 30,
                Contact = new Contact()
                {
                    Street = "1309 Ripip View",
                    PostalCode = "29277",
                    City = "Diredac",
                    PhoneNumber = "(764) 666-5855",
                    Mobile = "(645) 735-1947",
                    Email = "tuhgegej@kiv.fo"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Gefejge Company",
                RegistrationNumber = "96585466",
                TaxId = "895000636",
                NumberOfEmployees = 28,
                Contact = new Contact()
                {
                    Street = "1275 Oparun Trail",
                    PostalCode = "07132",
                    City = "Azulihled",
                    PhoneNumber = "(534) 280-6196",
                    Mobile = "(886) 547-9693",
                    Email = "gohmaza@ek.je"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Bogbuljuf Company",
                RegistrationNumber = "78915748",
                TaxId = "336740358",
                NumberOfEmployees = 296,
                Contact = new Contact()
                {
                    Street = "857 Asisu Ridge",
                    PostalCode = "35353",
                    City = "Kumoduva",
                    PhoneNumber = "(251) 420-7748",
                    Mobile = "(314) 688-2180",
                    Email = "fowhan@rimobkab.mw"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Ukgocik Company",
                RegistrationNumber = "12824072",
                TaxId = "314280131",
                NumberOfEmployees = 271,
                Contact = new Contact()
                {
                    Street = "1355 Mikgi Junction",
                    PostalCode = "72705",
                    City = "Bohepfos",
                    PhoneNumber = "(833) 380-2313",
                    Mobile = "(841) 206-3139",
                    Email = "ho@gos.bj"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Lecasoh Company",
                RegistrationNumber = "74418841",
                TaxId = "600433368",
                NumberOfEmployees = 160,
                Contact = new Contact()
                {
                    Street = "832 Uvvez Heights",
                    PostalCode = "72782",
                    City = "Bomewpud",
                    PhoneNumber = "(805) 699-5310",
                    Mobile = "(812) 304-5803",
                    Email = "howebav@mecsutopu.bv"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Cizsaciw Company",
                RegistrationNumber = "43214663",
                TaxId = "034737996",
                NumberOfEmployees = 133,
                Contact = new Contact()
                {
                    Street = "1897 Hupe Lane",
                    PostalCode = "02344",
                    City = "Buorrav",
                    PhoneNumber = "(459) 858-6303",
                    Mobile = "(206) 862-5064",
                    Email = "fujlo@nowgelpul.pw"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Luselkud Company",
                RegistrationNumber = "88231155",
                TaxId = "202703521",
                NumberOfEmployees = 211,
                Contact = new Contact()
                {
                    Street = "1829 Tijcuf Court",
                    PostalCode = "03446",
                    City = "Fecdaot",
                    PhoneNumber = "(586) 566-3290",
                    Mobile = "(373) 563-9000",
                    Email = "ukdekkuk@geduf.cd"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Denjimca Company",
                RegistrationNumber = "66221217",
                TaxId = "235142186",
                NumberOfEmployees = 258,
                Contact = new Contact()
                {
                    Street = "1719 Bonce Mill",
                    PostalCode = "61890",
                    City = "Ugapenher",
                    PhoneNumber = "(676) 381-3210",
                    Mobile = "(557) 456-1567",
                    Email = "hiv@tuwwulab.gw"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Gohiken Company",
                RegistrationNumber = "60832999",
                TaxId = "782437195",
                NumberOfEmployees = 155,
                Contact = new Contact()
                {
                    Street = "1979 Jebma Junction",
                    PostalCode = "56415",
                    City = "Lackogamo",
                    PhoneNumber = "(801) 805-3010",
                    Mobile = "(632) 970-2024",
                    Email = "tedtuor@fujhaw.sm"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Durmunoz Company",
                RegistrationNumber = "43618592",
                TaxId = "479938395",
                NumberOfEmployees = 14,
                Contact = new Contact()
                {
                    Street = "708 Ninsal River",
                    PostalCode = "89494",
                    City = "Ceduzemig",
                    PhoneNumber = "(868) 921-7834",
                    Mobile = "(725) 953-4793",
                    Email = "erlaihi@cawula.ch"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Baozni Company",
                RegistrationNumber = "76393400",
                TaxId = "877472338",
                NumberOfEmployees = 273,
                Contact = new Contact()
                {
                    Street = "1394 Robep Parkway",
                    PostalCode = "18181",
                    City = "Olgozet",
                    PhoneNumber = "(487) 561-8413",
                    Mobile = "(249) 893-4349",
                    Email = "dig@gohmu.gh"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Upefkab Company",
                RegistrationNumber = "67015327",
                TaxId = "624893025",
                NumberOfEmployees = 215,
                Contact = new Contact()
                {
                    Street = "1433 Nedtat Path",
                    PostalCode = "04308",
                    City = "Boibjog",
                    PhoneNumber = "(801) 418-8916",
                    Mobile = "(607) 527-7880",
                    Email = "fusnir@kuvwogsop.ag"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Maacni Company",
                RegistrationNumber = "55765250",
                TaxId = "201733332",
                NumberOfEmployees = 247,
                Contact = new Contact()
                {
                    Street = "1668 Liwil River",
                    PostalCode = "16398",
                    City = "Zihsisu",
                    PhoneNumber = "(583) 694-6884",
                    Mobile = "(540) 711-2089",
                    Email = "gise@nanemu.mw"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Setsete Company",
                RegistrationNumber = "06332118",
                TaxId = "272753871",
                NumberOfEmployees = 188,
                Contact = new Contact()
                {
                    Street = "1276 Wajo Plaza",
                    PostalCode = "41988",
                    City = "Gevsofri",
                    PhoneNumber = "(954) 822-3347",
                    Mobile = "(480) 623-5897",
                    Email = "kupeliod@dezotek.ee"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Ipdurvec Company",
                RegistrationNumber = "03767778",
                TaxId = "271898037",
                NumberOfEmployees = 185,
                Contact = new Contact()
                {
                    Street = "1451 Innoc Pass",
                    PostalCode = "87935",
                    City = "Ogigiwge",
                    PhoneNumber = "(870) 434-2729",
                    Mobile = "(266) 585-9642",
                    Email = "jo@vo.lv"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Tobkora Company",
                RegistrationNumber = "53159516",
                TaxId = "886883405",
                NumberOfEmployees = 257,
                Contact = new Contact()
                {
                    Street = "83 Nasu Terrace",
                    PostalCode = "22294",
                    City = "Zakmolef",
                    PhoneNumber = "(629) 804-8681",
                    Mobile = "(700) 542-2823",
                    Email = "ororub@vuz.zm"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Rehpembum Company",
                RegistrationNumber = "80614897",
                TaxId = "172533452",
                NumberOfEmployees = 228,
                Contact = new Contact()
                {
                    Street = "1698 Miza Way",
                    PostalCode = "07183",
                    City = "Fahsimku",
                    PhoneNumber = "(834) 538-3429",
                    Mobile = "(300) 952-8174",
                    Email = "sov@fumli.gr"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Hilniaco Company",
                RegistrationNumber = "31645816",
                TaxId = "963593155",
                NumberOfEmployees = 79,
                Contact = new Contact()
                {
                    Street = "1088 Lubuz Plaza",
                    PostalCode = "55547",
                    City = "Goelcuz",
                    PhoneNumber = "(717) 281-3648",
                    Mobile = "(888) 959-2341",
                    Email = "toh@cikanin.gs"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Pocidumab Company",
                RegistrationNumber = "03831577",
                TaxId = "717632176",
                NumberOfEmployees = 41,
                Contact = new Contact()
                {
                    Street = "31 Weit Court",
                    PostalCode = "95911",
                    City = "Zufaho",
                    PhoneNumber = "(446) 979-4653",
                    Mobile = "(374) 282-8198",
                    Email = "akupob@ew.td"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Gepunnok Company",
                RegistrationNumber = "37026435",
                TaxId = "813881939",
                NumberOfEmployees = 121,
                Contact = new Contact()
                {
                    Street = "1917 Micgo Boulevard",
                    PostalCode = "34335",
                    City = "Mupelgov",
                    PhoneNumber = "(211) 677-4167",
                    Mobile = "(448) 352-4334",
                    Email = "rid@mif.ly"
                }
            });

            companies.Add(new Company()
            {
                FullName = "Zezawooto Company",
                RegistrationNumber = "79352069",
                TaxId = "545771782",
                NumberOfEmployees = 67,
                Contact = new Contact()
                {
                    Street = "27 Ucmu Key",
                    PostalCode = "03795",
                    City = "Joabasu",
                    PhoneNumber = "(920) 510-8814",
                    Mobile = "(741) 913-2479",
                    Email = "kutovalov@ijiviufe.sn"
                }
            });

            return companies;
        }


    }
}
