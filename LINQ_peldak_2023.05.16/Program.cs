using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    { //Alapértelmezett listák

        List<string> tintapatronok = new List<string>()
            {
                "Canon BCI-6eBK Black / S800, 820, 900","Canon BCI-6eC Color / S800, 820, 900","HP 6615DE (15) Black tintapatron","HP 6578D (78) Color tintapatron","HP 51645A (45) Black tintapatron","HP 6657AE (57) Color tintapatron","HP 6656AE (56) Black tintapatron","HP 8727A (27) Black tintapatron","HP 8728A (28) Color tintapatron","Canon BCI-3eM Color  / BJC3000,6000, i550","Canon BCI-6eM Color / S800, 820, 900","Canon BCI-6eY Color / S800, 820, 900","HP 4836AE (11) Cyan tintapatron","HP 4837AE (11) Magenta tintapatron","HP 4838AE (11) Yellow tintapatron","HP 4844AE (10) Black tintapatron","Epson T0483 Magenta","Epson T0484 Yellow","Epson T0485 Light Cyan","Epson T0486 Light Magenta","Epson T0481 Black","HP 8765A (338) Black tintapatron","HP 8766A (343) Color tintapatron","Epson T0441 Black","HP 9363EE (344) Color tintapatron","HP 8767A (339) Black tintapatron","HP 9351AE (21) Black tintapatron","HP 9352AE (22) Color tintapatron","Canon PG40 Black","Canon PG50 Black","Canon CL51 Color","Canon CL41 Color","Canon CL52 Photo Color","Canon PGI 5 Black","Canon CLI 8 Black","Canon CLI 8 Cyan","Canon CLI 8 Magenta","Canon CLI 8 Yellow","HP 9361EE (342) Color tintapatron","HP 9362EE (336) Black tintapatron","HP 8719EE (363XL) Black tintapatron","HP 8721EE (363) Black tintapatron","HP 8771EE (363) Cyan tintapatron","HP 8772EE (363) Magenta tintapatron","HP 8773EE (363) Yellow tintapatron","HP 8774EE (363) Light Cyan tintapatron","HP 8775EE (363) Light Magenta tintapatron","HP 9391AE (88XL) Cyan tintapatron","HP 9392AE (88XL) Magenta tintapatron","HP 9393AE (88XL) Yellow tintapatron","HP 9396A (88XL) Black tintapatron","HP CB335E (350) Black tintapatron","Canon CLI 8 Photo Magenta","Canon CLI 8 Photo Cyan","HP CB337EE (351) Color tintapatron","Epson T0711 Black","Epson T0712 Cyan","Epson T0713 Magenta","Epson T0714 Yellow","Epson T0611 Black","Epson T0612 Cyan","Epson T0613 Magenta","Epson T0614 Yellow","HP 9364EE (337) Black tintapatron","Epson T0801 Black","Epson T0802 Cyan","Epson T0804 Yellow","Epson T0805 Light Cyan","Epson T0715 Multipack","Canon PG37 Black","Epson T0711H Twin Pack Black","Canon PGI 520 Black","Canon CLI 521 Black","HP 9351C (21XL) Black tintapatron","HP CB336E (350XL) Black tintapatron","HP 9352CE (22XL) Color tintapatron","HP CB318EE (364) Cyan tintapatron","HP CB319EE (364) Magenta tintapatron","HP CB320EE (364) Yellow tintapatron","HP CB324EE (364XL) Magenta tintapatron","HP CC640EE (300) Black tintapatron","HP CC641EE (300XL) Black tintapatron","HP CC643EE (300) Color tintapatron","HP CC644EE (300XL) Color tintapatron","HP CC656AE (901) Color tintapatron","HP CC653AE (901) Black tintapatron","Canon CL 511 Color","Canon CLI 521 Cyan","Canon CLI 521 Magenta","Canon CLI 521 Yellow","Canon PG 510 Black","Epson T0806 Light Magenta","HP CB322EE (364XL) Photo Black tintapatron","HP CB323EE (364XL) Cyan tintapatron","HP CB325EE (364XL) Yellow tintapatron","Canon PGI 35 Black","HP 4913A (82) Yellow tintapatron","HP CC654AE (901XL) Black tintapatron","HP 9387AE (88) Magenta tintapatron","Canon CL38 Color","HP 9385AE (88) Black tintapatron","HP 9386AE (88) Cyan tintapatron","Canon CL 513","HP CB338EE (351XL) Color tintapatron","Canon PG 512 Black","HP 4906AE (940XL) Black tintapatron","HP 4907AE (940XL) Cyan tintapatron","HP 4908AE (940XL) Magenta tintapatron","HP 4909AE (940XL) Yellow tintapatron","Canon BX-20","HP CD971AE (920) Black tintapatron","HP CB317EE (364) Photo Black tintapatron","HP CD975AE (920XL) Black tintapatron","HP CD972AE (920XL) Cyan tintapatron","HP CD973AE (920XL) Magenta tintapatron","HP CD974AE (920XL) Yellow tintapatron","Canon CLI-521 MultiPack C,M,Y","Canon CLI-521GY Grey","HP CB331EE (338) Duopack Black tintapatron","HP 9505EE (344) Duopack Color tintapatron","HP 9503AE (57) Duopack Color tintapatron","HP 9502AE (56) Duopack Black tintapatron","HP 9504EE (339) Duopack Black tintapatron","HP CB332EE (343) Duopack Color tintapatron","Canon PFI-102MBk Matt Black","Canon PFI-102M Magenta","Canon PFI-102Y Yellow","Canon PFI-102Bk Black","Canon PFI-102C Cyan","HP 4911A (82) Cyan tintapatron","Canon PGI-9 Yellow","Canon PGI-9 Matt Black","Canon CLI-36  Color","Epson T0452 Cyan","Epson T0453 Magenta","Epson T0893 Magenta","Epson T0894 Yellow","Epson T6039 Light Light Black","Epson T0795 Light Cyan","Epson T0487 Multipack (6-szinü)","Epson T0551 Black","Epson T0556 Multipack (4-szinü)","Epson T0540 Gloss Optimizer","Epson T6034 Yellow","Epson T0969 Light Light Black","Epson T0968 Matte Black","Epson T0961 Photo Black","Epson T0615 Multipack (4-színű)","Epson T0792 Cyan","Epson T0554 Yellow","Epson T0592 Cyan Ultra Chrome K3","Epson T0597 Light Black Ultra Chrome K3","Epson T0549 Blue","Epson T0891 Black","Epson T0892 Cyan","HP CH565A (82) Black tintapatron","HP 4912A (82) Magenta tintapatron","HP 6578A (78) Color tintapatron","HP CH563EE (301XL) Black tintapatron","HP CH564EE (301XL) Color tintapatron","HP CH562EE (301) Color tintapatron","Canon CLI 526 Black","Canon CLI-526 MultiPack C,M,Y","Canon CLI 526 Cyan","Canon CLI 526 Yellow","Canon PGI-525 Black","Epson T1281 Black","Epson T1282 Cyan","Epson T1283 Magenta","Epson T1284 Yellow","Epson T0793 Magenta","Epson T0794 Yellow","Epson T0796 Light Magenta","Epson T0454 Yellow","Epson T0591 Photo Black  Ultra Chrome K3","Epson T0593 Magenta  Ultra Chrome K3","Epson T0594 Yellow  Ultra Chrome K3","Epson T0595 Light Cyan Ultra Chrome K3","Epson T0596 Light Magenta Ultra Chrome K3","Epson T0598 Matte Black Ultra Chrome K3","Epson T0599 Light Light  Black Ultra Chrome K3","Epson T0541 Photo Black","Epson T0542 Cyan","Epson T0543 Magenta","Epson T0544 Yellow","Epson T0547 Red","Epson T0548 Matte Black","Epson T0962  Cyan","Epson T0963 Magenta","Epson T0967 Light Black","Epson T0965 Light Cyan","Epson T0966 Light Magenta","Epson T0964  Yellow","Epson T6031 Photo Black","Epson T6032 Cyan","Epson T6037  Light Black","Epson T6035 Light Cyan","Brother LC1100 Multipack (Black, Cyan, Magenta, Yellow)","Epson T1285 Multipack","Epson T1295 Multi Pack - (Black, Magenta, Yellow, Cyan)","Epson T1291 Black","Epson T1292 Cyan","Epson T1293 Magenta","Epson T1294 Yellow","HP CN684EE (364XL) Black tintapatron","Epson T0807 Multipack (6-színű)","Canon CL 541XL Color","Canon PG 540XL Black","Canon PG 540 Black","Canon CL 541 Color","Epson T1006 Multipack (3-szinü)","Epson T1003 Magenta","Epson T1004 Yellow","Epson T1591 Black","Epson T1590 Gloss optimizer","Epson T1592 Cyan","Epson T1598 Matte Black","Epson T1599 Orange","Epson T1593 Magenta","Epson T1594 Yellow","Epson T1597 Red","Epson  T1579 Light Black","Epson T0895 Multipack (4-szinü)","Epson T1302 Cyan","Epson T1304 Yellow","Epson T7014 Yellow","Epson T7031 Black","Epson T7032 Cyan","Epson T7033 Magenta","Epson T7034 Yellow","Epson T7021 Black","Epson T7022 Cyan","Epson T7023 Magenta","Epson T7024 Yellow","Epson T7012 Cyan","Epson T7013 Magenta","Epson T6174 Yellow","Epson T6173 Magenta","Epson T6171 Black","Brother LC1100BK Black","Brother LC1100HY Yellow","Brother LC985Y Yellow","Brother LC985M Magenta","Brother LC985C Cyan","Brother LC985BK Black","Brother LC980M Magenta","Brother LC970Y Yellow","Brother LC970BK Black","Brother LC1280XLY Yellow","Brother LC1280XLM Magenta","Brother LC1280XLC Cyan","Brother LC1280XLBK Black","Brother LC1220Y Yellow","Brother LC1220M Magenta","Brother LC1220C Cyan","Brother LC1220BK Black","Brother LC1100M Magenta","Brother LC1100HYBK Black","Epson T1303 Magenta","Epson T1306 Multi Pack","Epson T1571 Black","Epson T1572 Cyan","Epson T1573 Magenta","Epson T1574 Yellow","Epson T1575 Light Cyan","Epson T1577 Light Black","Epson T1578 Matte Black","Epson T008 Color (5-szinü)","Epson T0445 Multipack (4-szinü)","Epson T0342 Cyan","Epson T0343 Magenta","Epson T0442 Cyan","Epson T0443 Magenta","Epson T0444 Yellow","Epson T051 Black","Epson T0871 Black","Epson T0874 Yellow","Epson T0877 Red","Epson T0878 Matte Black","Epson T0879 Orange","Epson T1001 Black","Epson T6161 Black","Epson T6162 Cyan","Epson T6163 Magenta","Epson T6164 Yellow","Epson T7011 XXL Black","Epson T6172 Cyan","Epson T619 Maintenance Kit","Epson T6181 Black","Epson T1002 Cyan","Epson L800 Light Magenta","Epson L800 Light Cyan","Epson L800 Yellow","Epson L800 Magenta","Epson L800 Cyan","Epson L800 Black (T6731)","Epson T6641 L100/L200 Black","Epson T6642 L100/L200 Cyan","Epson T6643 L100/L200 Magenta","Epson T6644 L100/L200 Yellow","Brother LC1100Y Yellow","Brother LC980Y Yellow","Brother LC980BK Black","Brother LC980 Multipack (Black, Cyan, Magenta, Yellow)","Brother LC-900BK Black","HP CN048AE (951XL) Yellow tintapatron","HP CN049AE (950) Black tintapatron","Brother LC980C Cyan","Epson T1301 Black","Brother LC985 Kit (Black, Cyan, Magenta, Yellow)","Brother LC1280XL Kit (Black, Cyan, Magenta, Yellow)","Brother LC970C Cyan","Brother LC970M Magenta","Brother LC1240BK Black","Brother LC1240C Cyan","Brother LC1240M Magenta","Brother LC1240Y Yellow","Brother LC1000BK Black","Brother LC1000C Cyan","Brother LC1000M Magenta","Brother LC1000Y Yellow","Brother LC1100HYC Cyan","Brother LC1100HYM Magenta","Brother LC1100HY nagykapacitású kit (Cyan, Magenta, Yellow, Black)","HP CN054AE (933XL) Cyan tintapatron","HP CN055AE (933XL) Magenta tintapatron","HP CN056AE (933XL) Yellow tintapatron","Epson T0872 Cyan","Epson T0873 Magenta","HP CN057AE (932) Black tintapatron","Canon PGI-525 Black Duo","Epson T1576 Light Magenta","Epson T1801 Black","Epson T1802 Cyan","Epson T1803 Magenta","Epson T1804 Yellow","Epson T1811XL Black","Epson T1812XL Cyan","Epson T1813XL Magenta","Epson T1814XL Yellow","Epson 18XL Multipack (4-színű)","Canon PGI-9 Magenta","Canon PGI-9 Photo Black","Canon PGI-9 Photo Magenta","Canon CLI 551 XL Cyan","Canon CLI 551 XL Yellow","Canon PGI-550 Black","Canon CLI 551 XL Grey","Canon CLI 551 XL Black","HP CZ109AE (655) Black tintapatron","HP CZ110AE (655) Cyan tintapatron","HP CZ112AE (655) Yellow tintapatron","HP CZ111AE (655) Magenta tintapatron","Canon CLI 551 XL Magenta","Canon CLI 8 MultiPack C,M,Y","Canon PGI-550XL Black","Brother LC-123BK Black","Brother LC-123Y Yellow","Brother LC-123M Magenta","Brother LC-123C Cyan","Canon PGI-9 Photo Cyan","HP C2N92AE (920XL) Color 4-Multipack tintapatron","HP C2N93AE (940XL) Color 4-Multipack tintapatron","HP CZ102AE (650) Color  tintapatron","Epson 18 Multipack (4-színű)","Brother LC-127XLBK Black","Epson T0870 Gloss Optimizer","Epson T007 Singlepack Black","HP CZ131A (711) Magenta tintaparton","HP CZ130A (711) Cyan tintapatron","HP CZ129A (711) Black tintapatron ","Canon PGI-9 Cyan","Epson T6122 Cyan","Epson T6123 Magenta","Epson T6124 Yellow","Epson T6128 Matte Black","Brother LC-125XLC Cyan","Brother LC-125XLM Magenta","Brother LC-125XLY Yellow","Brother LC-900C Cyan","Brother LC-900M Magenta","Brother LC-900Y Yellow","HP CZ132A (711) Yellow  tintaparton","HP CZ133A (711) Black tintapatron","Brother LC1100C Cyan","Brother LC123VALBP CMYK Pack","Brother LC-127XLVALBP CMYK XL Pack","Epson 16 Black","Epson 16 Cyan","Epson 16 Magenta","Epson 16 Yellow","Epson T7741A Black","Canon CL 546 Color","Canon PG 545 Black","HP SD412EE (350) Black + (351) Color Combo-pack","Brother LC-129XLBK Black","HP CN626AE (971XL) Cyan tintapatron","HP CN627AE (971XL) Magenta tintapatron","HP CN628AE (971XL) Yellow tintapatron","Canon CL 546 Color XL","Epson T7441 Black","Canon PG 545 XL Black","HP CN625AE (970XL) Black tintapatron","Brother LC-525XL-C Cyan","Brother LC-525XL-M Magenta","Brother LC-525XL-Y Yellow","Brother LC-529XL-BK Black","Epson 16XL Black","Epson T7893 XXL Magenta","Epson T7892 XXL Cyan","Epson T7891 XXL Black","Epson T7894 XXL Yellow","Canon PG-545 / CL-546 Combipack","Samsung INK-M210 Black","Canon PGI 520 Twin Black","Epson SJIC22P Black","Epson SJIC22P Cyan","Epson SJIC22P Magenta","Epson SJIC22P Yellow","Canon PGI 5 Duo Black","Epson T1694 Photo Black","Epson T6942 Cyan","Brother LC227XLBK Black","HP C2P21AE (935) Magenta tintapatron","HP C2P25AE (935XL) Magenta tintapatron","HP C2P26AE (935XL) Yellow tintapatron","HP J3M83AE (364XL) Black + Color tintapatron + 10db fotópapír","Canon PGI-2500XL Magenta","Canon PGI-2500XL Cyan","Canon PGI-2500XL Black","Canon PGI-2500XL Multipack","Canon PGI-2500XL Yellow","Brother LC-121C Cyan","Brother LC-121M Magenta","Brother LC-121Y Yellow","Brother LC-121BK Black","Epson 16 Multipack","Brother LC-125XL Color Set (C/M/Y)","Canon PG-40 / CL-41 Multipack","Brother LC225XLC Cyan  XL","Brother LC225XLM Magenta XL","Brother LC225XLY Yellow XL","Canon PG-540/CL-541 Multipack","Brother LC-229XLBK Black","Brother LC-223BK Black","Brother LC-223C Cyan","Brother LC-223M Magenta","Brother LC-223Y Yellow","Canon CLI 571 Black","Canon CLI 571 Cyan","Canon CLI 571 Magenta","Canon CLI 571 Yellow","Canon CLI 571XL Black","Canon CLI 571XL Cyan","Canon CLI 571XL Magenta","Canon PGI 570 Black","Canon PGI 570XL Black","Epson T7554 XL Yellow"
            };

        List<double> arfolyam = new List<double> { 329.99, 329.45, 329.98, 330.71, 331.4, 331.58, 333.84, 334.98, 332.65, 333.21, 333.83, 335.49, 336.91, 335.53, 335.09, 336.9, 336.17, 337.16, 337.36, 337.61, 337.98, 336.65 };

        List<int> szamsor = new List<int> { 5, 309, 796, 555, 557, 629, 703, 124, 365, 99, 654, 333, 615, 961, 560, 904, 131, 346, 567, 95, 914, 286, 549, 383, 289, 491, 482, 211, 236, 688, 679, 928, 387, 351, 571, 660, 523, 803, 209, 58, 348, 952, 191, 438, 489, 94, 963, 370, 396, 860, 575, 959, 572, 362, 90, 212, 382, 43, 253, 809, 72, 199, 775, 129, 960, 912, 415, 715, 191, 113, 222, 611, 371, 941, 340, 387, 887, 947, 941, 320, 603, 541, 771, 966, 241, 642, 445, 91, 36, 35, 602, 893, 848, 351, 859, 64, 287, 348, 231, 445 };

        List<int> szamsorA = new List<int> { 2, 4, 8, 16, 32, 64, 128, 256 };
        List<int> szamsorB = new List<int> { 3, 9, 27, 81, 243, 729, 800 };


        List<char> jelek = new List<char> { '+', '-', '0', '0', '+', '-', '0', '0', '+', '+', '-', '0', '0', '+', '+', '+', '-', '-', '+', '-', '+', '+', '-', '0', '0', '+', '+', '-', '0', '-', '+' };

        List<string> nevek = new List<string>() { "Kovács Ádám", "Nagy Béla", "Kiss Kinga", "Sas Márk", "Budavári Kelemen", "Kovács Éva", "Nagy Tivadar" };
        List<int> fizetesek = new List<int> { 379000, 450000, 527000, 810000, 450240, 729000, 1180900 };


        //Hasznos linkek
        // https://csharp.net-tutorials.com/linq/linq-query-syntax-vs-method-syntax/

        //Többféle írásmód létezik LINQ-ban.
        //A)
        //Query Syntax (Lekérdezési szintaxis)

        var qNames = from name in nevek
                     where name.Length <= 8
                     select name;
        foreach (var item in qNames)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();

        //B)
        // Method Syntax (Metódusszintaxis) 
        // Metódusok láncolataként jön létre. pld. Where->Select->OrderBy->ToList
        List<string> felhasznaloiNevek =
             nevek.Where(nev => nev.Length < 10)
                    .Select(nev => nev[0] + nev.Split()[1])
                    .OrderBy(felhasznalo => felhasznalo)
                    .ToList();
        
        Console.ReadKey();

        //C)
        // Kevert szintaxis
        var kevert = from name in nevek
                     where name.Length <= 8
                     select name.ToUpper();

        /*
        foreach (var item in kevert)
        {
            Console.WriteLine(item);
        }
        */ 

        Console.ReadKey();

        //Mi a metódusszintaxist fogjuk használni. A lekérdezési szintaxist a fordító egyből átfordítja metódusszintaxisra.

        //Lambda kifejezés
        //parameter(ek) => kifejezés|utasítás
        //input => output
        //pld.
        //    x  => x.length > 5  - itt minden elemhez egy logikai értéket rendel
        //    kavics => (4 * Math.Pow(kavics.r, 3) * Math.PI) / 3  - itt a kavics névvel hivatkozott objektumokhoz azok r értéke alapján számított gömbtérfogatot rendeli

        //Most még nem kell, de már jelzem, hogy a lamda kifejezés bal oldalán lehet két paraméter is, ekkor a 2. paraméter egy 0-ról induló indexet jelent.
        //példa: Az 500eFt feletti fizetésű dolgozók neveit és fizetését írja a képernyőre.
        nevek.Where((nev, index) => fizetesek[index] > 500000)  //szűkítés feltétel szerint - jobb oldalon log.kif.
             .Select((nev, index) => $"{nev} fizetése {fizetesek[index]} Ft")   //leképezés új értékre - jobb oldalon karakterláncot adó kifejezés
             .ToList()   //struktúra átalakítása, hogy a ForEach használható legyen
             .ForEach(x => Console.WriteLine(x));  //képernyőre írás - jobb oldalon utasítás (statement)


        /* Név              - bemenet->kimenet    | Rövid leírás
         * 
         * Count            - sorozathoz->elem    | Megszámlálás
         * Sum              - sorozathoz->elem    | Összegzés
         * Avarage          - sorozathoz->elem    | Átlag
         * Min              - sorozathoz->elem    | Minimumelem
         * Max              - sorozathoz->elem    | Maximumelem

         * Any              - sorozathoz->elem    | Eldöntés (van olyan elem ami teljesíti a megadott feltételt?)
         * All              - sorozathoz->elem    | Eldöntés (minden elem teljesíti a megadott feltételt?)

         * FindIndex        - sorozathoz->elem    | Kiválasztás, keresés (elölről az első találat indexe)
         * FindLastIndex    - sorozathoz->elem    | Kiválasztás, keresés (végéről az első találat indexe)
         * Find             - sorozathoz->elem    | Kiválasztás, keresés (elölről az első eleme, ami megfelel a feltételnek)
         * FindLast         - sorozathoz->elem    | Kiválasztás, keresés (végéről az első eleme, ami megfelel a feltételnek)

         * Where            - sorozathoz->sorozat (n->m, m<=n) | Kiválogatás, az adott feltételnek eleget tevő elemek
         * Distinct         - sorozathoz->sorozat (n->m, m<=n) | Kiválogatás, minden elem csak 1x fordulhat elő
         * Select           - sorozathoz->sorozat (n->n) | Leképezés
         * First            - sorozathoz->elem    | Az első elemet adja vissza
         * Last             - sorozathoz->elem    | Az utolsó elemet adja vissza

         *Foreach          - sorozathoz->sorozat (n->n) | Minden tagon végrehajt vmilyen tevékenységet. Pld. Console.WriteLine vagy más metódus meghívása

 //RENDEZÉSEK
         * OrderBy          - sorozathoz->sorozat (n->n) | Rendezés növekvően
         * OrderByDescending- sorozathoz->sorozat (n->n) | Rendezés csökkenőenű            
         * ThenBy           - sorozathoz->sorozat (n->n) | Másodlagos rendezés növekvően. Az elsődleges szempont szerinti azonosakat rendezi tovább. 
         * ThenByDescending - sorozathoz->sorozat (n->n) | Másodlagos rendezés csökkenően. - || -


 //RÉSZSOROZAT LÉTREHOZÁSA
         * Skip             - sorozathoz->sorozat (n->m, m<=n) | Kihagyja (átugorja) a megadott számú elemet a sorozat elejéről
         * SkipLast         - sorozathoz->sorozat (n->m, m<=n) | Kihagyja (átugorja) a megadott számú elemet a sorozat végéről.
         * Take             - sorozathoz->sorozat (n->m, m<=n) | Megadott darabszámú elemet vesz a sorozat elejéről.
         * TakeLast         - sorozathoz->sorozat (n->m, m<=n) | Megadott darabszámú elemet vesz a sorozat végéről.
         */


        //még nem    *GroupBy          - sorozathoz->csoportok| Csoportosítás megadott kulcs szerint

        //A LINQ elsősorban a sokszor használt programozási tételek (nev.alg.-ok) kiváltására hasznos.
        /*
        Nevezetes algoritmusok:

            Megszámlálás - https://www.webotlet.hu/?p=1921#Megsz%C3%A1ml%C3%A1l%C3%A1s
            Összegzés - https://www.webotlet.hu/?p=1921#%C3%96sszegz%C3%A9s
            Eldöntés - https://www.webotlet.hu/?p=1921#Eld%C3%B6nt%C3%A9s
            Kiválasztás - https://www.webotlet.hu/?p=1921#Kiv%C3%A1laszt%C3%A1s
            Minimum/Maximum keresés - https://www.webotlet.hu/?p=1921#Keres%C3%A9s
        */


        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Megszámlálás - https://www.webotlet.hu/?p=1921#Megsz%C3%A1ml%C3%A1l%C3%A1s
        //
        //Az alapfeladat az, hogy számoljuk meg, hogy egy adott kollekcióban hány darab adott (T) tulajdonságú elem van. 
        //LINQ:Count
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        //1) feladat: Hány nap volt 335 felett az EUR árfolyama?

        //Megoldás (hagyományos):

        int db = 0; //segédváltozó
        for (int index = 0; index < arfolyam.Count; index++)
        {
            if (arfolyam[index] > 335)
            {
                db++;
            }
        }
        Console.WriteLine("Megszámlálás 1) (hagyományos) :" + db);


        //Megoldás (lambda+LINQ):
        db = arfolyam.Count(x => x > 335);  //A T tulajdonság x>335, A Count megszámolja a feltételnek eleget tévő elemek számát
        Console.WriteLine("Megszámlálás 1) (lambda+LINQ) :" + db);

        //Erőforrás használat miatt nem szerencsés megoldás, mivel előbb leválogat (szűr), majd a szűkebb lista elemeinek számát írja ki. 
        db = arfolyam.Where(x => x > 335).Count();
        Console.ReadKey();


        //2) feladat: Hány "Epson" márkájú festékpatront tartalmaz a lista?

        //Megoldás (hagyományos):

        db = 0; //segédváltozó
        for (int index = 0; index < tintapatronok.Count; index++)
        {
            if (tintapatronok[index].Contains("Epson"))
            {
                db++;
            }
        }
        Console.WriteLine("Megszámlálás 2) (hagyományos) :" + db);

        /*
        db = 0; //segédváltozó
        foreach (var aktPatron in tintapatronok)
        {
            if (aktPatron.Contains("Epson"))
            {
                db++;
            }
        }
        */

        //Megoldás (lambda+LINQ):
        db = tintapatronok.Count(x => x.Contains("Epson"));  //A T tulajdonság x.Contains("Epson"). A Contains - true értéket ad vissza, ha az x karakterláncban előfordul az "Epson" szó.
        Console.WriteLine("Megszámlálás 2) (lambda+LINQ) :" + db);


        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Összegzés - https://www.webotlet.hu/?p=1921#%C3%96sszegz%C3%A9s
        //
        //A kollekció számértékű tagjainak összegzése
        //LINQ:Sum, Avarage
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        //1) feladat: Mennyi a SzamsorA lista elemeinek összege?

        //Megoldás (hagyományos):

        int osszeg = 0; //gyűjtőváltozó
        for (int index = 0; index < szamsorA.Count; index++)
        {
            osszeg += szamsorA[index];
        }
        Console.WriteLine("Összegzés 1) (hagyományos) :" + osszeg);

        //Megoldás (lambda+LINQ):
        osszeg = szamsorA.Sum();
        Console.WriteLine("Összegzés 1) (lambda+LINQ) :" + osszeg);


        //2) feladat: Mennyi a SzamsorB lista elemeinek átlaga?

        //Megoldás (hagyományos):

        double osszeg2 = 0; //gyűjtőváltozó
        for (int index = 0; index < szamsorB.Count; index++)
        {
            osszeg2 += szamsorB[index];
        }
        Console.WriteLine("Átlag 2) (hagyományos) :" + osszeg2 / szamsorB.Count);

        //Megoldás (lambda+LINQ):
        Console.WriteLine("Átlag 2) (lambda+LINQ) :" + szamsorB.Average());






        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Eldöntés - https://www.webotlet.hu/?p=1921#Eld%C3%B6nt%C3%A9s
        //
        //Azt vizsgáljuk, hogy a kollekcióban található-e egy bizonyos tulajdonságú elem. Nem érdekel, hogy hány ilyen elem van, csak az a fontos, hogy van-e benne ilyen.
        //LINQ:Any
        //Bár eltér a klasszikus eldöntési tételtől, de ide kapcsolódik az All
        //LINQ:All
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        //1) feladat: Volt-e 337 felett az EUR árfolyam?

        //Megoldás (hagyományos):


        int cik = 0; //Ciklusváltozó

        while (cik < arfolyam.Count && arfolyam[cik] <= 337) //Amíg nincs a lista végén és nincs meg a T tulajdonságú elem
        {
            cik++; //jöhet a következő
        }
        bool vanIlyen = cik < arfolyam.Count; //Ha a cik változó elérte a lista elemeinek számát, akkor nem volt ilyen és false értéket kap.
        Console.WriteLine("Eldöntés 1) (hagyományos while ciklus) :" + vanIlyen);

        //Lehet for ciklussal is, de ilyenkor ki kell lépni a ciklusmagból, ha megtalálja a keresett T tulajdonságú elemet.
        vanIlyen = false; //segédváltozó:  feltételezzük, hogy nincs ilyen
        for (cik = 0; cik < arfolyam.Count; cik++)
        {
            if (arfolyam[cik] > 337)
            {
                vanIlyen = true;
                break;
            }
        }
        Console.WriteLine("Eldöntés 1) (hagyományos for ciklus) :" + vanIlyen);

        //Megoldás (lambda+LINQ):
        vanIlyen = arfolyam.Any(x => x > 337);
        Console.WriteLine("Eldöntés 1) (lambda+LINQ) :" + vanIlyen);

        // 2) feladat: Minden szám páros a listában?
        if (szamsorA.All(s => s % 2 == 0))
        {
            Console.WriteLine("Minden szám páros!");
        }
        else
        {
            Console.WriteLine("Van köztük páratlan!");
        }
        //A fenti 3 operandusú operátorral
        Console.WriteLine(
            szamsorA.All(s => s % 2 == 0) ? "Minden szám páros!" : "Van köztük páratlan!");



        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Kiválasztás - https://www.webotlet.hu/?p=1921#Kiv%C3%A1laszt%C3%A1s
        //
        //Ezzel az algoritmussal azt adhatjuk meg, hogy egy adott elem pontosan hol szerepel a kollekcióban. Ez természetesen az adott elem indexét jelenti, amellyel hivatkozunk rá. Feltételezzük, hogy az elem tényleg benne van a kollekcióban.
        //LINQ:FindIndex,FindLastIndex
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        //1) feladat: Hanyadik szám a szamsorB-ben a 243? (Hol van a listában a 243?)

        //FONTOS! Biztosak vagyunk, hogy benne van a listában.

        //Megoldás (hagyományos):
        int cok = 0; //Ciklusváltozó

        while (szamsorB[cok] != 243) //Amíg nincs meg a keresett elem
        {
            cok++; //jöhet a következő
        }

        Console.WriteLine("Kiválasztás 1) (hagyományos while ciklus) :" + cok);

        //Megoldás (lambda+LINQ):
        int hol = szamsorB.FindIndex(x => x == 243); //Ha nincs ilyen feltételnek eleget tevő elem, akkor -1 -et ad vissza
        Console.WriteLine("Kiválasztás 1) (lambda+LINQ) :" + hol);

        hol = szamsorB.FindLastIndex(x => x == 243);
        Console.WriteLine("Kiválasztás 1) (lambda+LINQ) :" + hol);


        // 2) feladat: Hanyadik a "6615DE" típusú patron a listában?

        //Megoldás (hagyományos):
        int cuk = 0; //Ciklusváltozó

        while (!(tintapatronok[cuk].Contains("6615DE"))) //Amíg még van vizsgálandó eleme és nincs meg a keresett elem
        {
            cuk++; //jöhet a következő
        }
        Console.WriteLine("Kiválasztás 2) (hagyományos while ciklus) :" + cuk);

        //Megoldás (lambda+LINQ):
        hol = tintapatronok.FindIndex(x => x.Contains("6615DE"));
        Console.WriteLine("Kiválasztás 2) (lambda+LINQ) :" + hol);



        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Feltételre történő keresés
        //
        //Megkeresi az adott feltételnek eleget tevő első elemet (előlről|hátulról)
        //LINQ:Find,FindLast
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        // 1) feladat: Mi az első "6615DE" szót tartalmazó elem a patronlistában?

        //Megoldás (hagyományos):
        int cek = 0; //Ciklusváltozó

        while (cek < tintapatronok.Count && !(tintapatronok[cek].Contains("6615DE"))) //Amíg még van vizsgálandó eleme és nincs meg a keresett elem
        {
            cek++; //jöhet a következő
        }
        if (cek < tintapatronok.Count)
        {
            Console.WriteLine("Feltételre történő keresés 1) (hagyományos while ciklus) :" + tintapatronok[cek]);
        }
        else
        {
            Console.WriteLine("Nincs a megadott feltételnek eleget tevő elem!");
        }

        //Megoldás (lambda+LINQ):
        String elem = tintapatronok.Find(x => x.Contains("6615DE")); //Ha nincs ilyen elem, akkor üres stringet ad vissza
        Console.WriteLine("Feltételre történő keresés 1) (lambda+LINQ) :" + elem);

        elem = tintapatronok.FindLast(x => x.Contains("6615DE"));
        Console.WriteLine("Feltételre történő keresés 1) (lambda+LINQ) :" + elem);





        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Minimum/Maximum keresés - https://www.webotlet.hu/?p=1921#Keres%C3%A9s
        //
        //Egy kollekció legkisebb/legnagyobb elemének meghatározása (nem csak számok esetén)


        // 1) feladat: Mi volt a legkisebb EUR árfolyam?

        //Megoldás (hagyományos):
        double min = arfolyam[0]; //Az első elemet tekintjük minimumértéknek

        for (int i = 0; i < arfolyam.Count; i++)
        {
            if (arfolyam[i] < min)
            {
                min = arfolyam[i];
            }
        }
        Console.WriteLine("Minimérték keresése 1) (hagyományos) :" + min);

        //Megoldás (lambda+LINQ):
        Console.WriteLine("Minimérték keresése 1) (lambda+LINQ) :" + arfolyam.Min());


        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Minimumhely/Maximumhely keresés
        //
        //Egy kollekció legkisebb/legnagyobb elemének a helyének a meghatározása. Sokkal hatékonyabb mint a min/max érték keresés, mivel a helyből az értéket is el lehet érni.
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        // 1) feladat: Hányadik nap volt a legmagasabb az EUR árfolyam?

        //Megoldás (hagyományos):
        int maxIndex = 0; //Az első elemet tekintjük maximumnak
        for (int i = 1; i < arfolyam.Count; i++)
        {
            if (arfolyam[i] > arfolyam[maxIndex])
            {
                maxIndex = i;
            }
        }
        Console.WriteLine("Maximumhely keresése 1) (hagyományos) :" + maxIndex);
        Console.WriteLine("Maximumérték, maximumhely alapján 1) (hagyományos) :" + arfolyam[maxIndex]);

        //Megoldás (lambda+LINQ):
        Console.WriteLine("Minimhely keresése 1) (lambda+LINQ) :"
            + arfolyam.FindIndex(x => x == arfolyam.Max()));

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //LINQ: Foreach
        //A sorozat (másként:kollekció | gyűjtemény) valamennyi elemét sorra veszi és egy adott cselekvés tárgyaként felhasználja.
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 


        //Példa: A "HP"-t tartalmazó patronokat növekvő sorrendben képernyőre írja.

        List<String> hplista = tintapatronok.Where(k => k.Contains("HP")).ToList(); //új segédlista

        hplista = hplista.OrderBy(x => x).ToList(); //rendezi a listát

        foreach (string patron in hplista) //minden tagját képernyőre írja
        {
            Console.WriteLine(patron);
        }

        //A kiírató rész LINQ segítségével
        hplista.ForEach(h => Console.WriteLine(h));

        //Az egész egyben:
        tintapatronok.Where(k => k.Contains("HP"))
                     .OrderBy(x => x)
                     .ToList()
                     .ForEach(h => Console.WriteLine(h));

        //Progresszív írásmód
        var s1 = tintapatronok.Where(k => k.Contains("HP"));
        var s2 = s1.OrderBy(x => x);
        var s3 = s2.ToList();
        s3.ForEach(h => Console.WriteLine(h));




        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //LINQ: Select
        //A sorozat minden tagjához egy leképezés révén hozzárendel egy másik értéket. Az eredmény egy másik sorozat lesz.
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        // 1) feladat: Készítsük el a szamsorB listából a benne lévő számok négyzetgyökeinek listáját!
        List<double> ujlista = szamsorB.Select(x => Math.Sqrt(x)).ToList();


        // 2) feladat: A 330 feletti EUR értékeket 1 tiz. jegyre kerekítve szeretnénk megkapni egy másik listában.
        List<double> reszEUR = arfolyam.Where(x => x > 330).Select(h => Math.Round(h, 1)).ToList();

        //Hagyományos úton elkészítve
        List<double> ujLista = new List<double>();
        foreach (var elem2 in arfolyam)
        {
            if (elem2 > 330)
            {
                ujlista.Append(Math.Round(elem2, 1));
            }
        }


        File
            .ReadAllLines("fajl.txt")
            .Skip(1)
            .Where(sor => sor.Length > 0)
            .Select(h => $"[{h.Length} sor]")
            .OrderBy(s => s)
            .ToList()
            .ForEach(h => Console.WriteLine(h));


    }
}
